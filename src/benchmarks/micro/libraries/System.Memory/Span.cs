// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Extensions;
using MicroBenchmarks;

namespace System.Memory
{
    [GenericTypeArguments(typeof(byte))]
    [GenericTypeArguments(typeof(char))]
    [GenericTypeArguments(typeof(int))]
    [BenchmarkCategory(Categories.Runtime, Categories.Libraries, Categories.Span)]
    public class Span<T> 
        where T : struct, IComparable<T>, IEquatable<T>
    {
        [Params(4, 8, 12, 32, 64, 512)]
        public int Size;

        private T[] _array, _same, _emptyWithSingleValue;
        private T[] _fourValues, _fiveValues;
        private T _notDefaultValue;

        [GlobalSetup]
        public void Setup()
        {
            _array = ValuesGenerator.Array<T>(Size);
            _same = _array.ToArray();
        }

        [Benchmark]
        public void Clear() => new System.Span<T>(_array).Clear();
        
        [Benchmark]
        public void Fill() => new System.Span<T>(_array).Fill(default);
        
        [Benchmark]
        public void Reverse() => new System.Span<T>(_array).Reverse();

        [Benchmark]
        public T[] ToArray() => new System.Span<T>(_array).ToArray();
        
        [Benchmark]
        public bool SequenceEqual() => new System.Span<T>(_array).SequenceEqual(new System.ReadOnlySpan<T>(_same));

        [Benchmark]
        public int SequenceCompareTo() => new System.Span<T>(_array).SequenceCompareTo(new System.ReadOnlySpan<T>(_same));

        [Benchmark]
        public bool StartsWith() => new System.Span<T>(_array).StartsWith(new System.ReadOnlySpan<T>(_same).Slice(start: 0, length: Size / 2));
        
        [Benchmark]
        public bool EndsWith() => new System.Span<T>(_array).EndsWith(new System.ReadOnlySpan<T>(_same).Slice(start: Size / 2));

        [GlobalSetup(Targets = new [] { nameof(IndexOfValue), nameof(LastIndexOfValue), nameof(LastIndexOfTwoValues), nameof(LastIndexOfThreeValues), nameof(LastIndexOfAnyFourValues),
            nameof(IndexOfAnyTwoValues), nameof(IndexOfAnyThreeValues), nameof(IndexOfAnyFourValues), nameof(IndexOfAnyFiveValues) })]
        public void SetupIndexOf()
        {
            _notDefaultValue = ValuesGenerator.GetNonDefaultValue<T>();
            _fourValues = Enumerable.Repeat(_notDefaultValue, 4).ToArray();
            _fiveValues = Enumerable.Repeat(_notDefaultValue, 5).ToArray();
            _emptyWithSingleValue = new T[Size];
            _emptyWithSingleValue[Size / 2] = _notDefaultValue;
        }

        [Benchmark]
        public int IndexOfValue() => new System.Span<T>(_emptyWithSingleValue).IndexOf(_notDefaultValue);

        [Benchmark]
        public int IndexOfAnyTwoValues() => new System.Span<T>(_emptyWithSingleValue).IndexOfAny(_notDefaultValue, _notDefaultValue);

        [Benchmark]
        public int IndexOfAnyThreeValues() => new System.Span<T>(_emptyWithSingleValue).IndexOfAny(_notDefaultValue, _notDefaultValue, _notDefaultValue);

        [Benchmark]
        public int IndexOfAnyFourValues() => new System.Span<T>(_emptyWithSingleValue).IndexOfAny(new ReadOnlySpan<T>(_fourValues));

        [Benchmark]
        public int IndexOfAnyFiveValues() => new System.Span<T>(_emptyWithSingleValue).IndexOfAny(new ReadOnlySpan<T>(_fiveValues));

        [Benchmark]
        public int LastIndexOfValue() => new System.Span<T>(_emptyWithSingleValue).LastIndexOf(_notDefaultValue);

        [Benchmark]
        public int LastIndexOfTwoValues() => new System.Span<T>(_emptyWithSingleValue).LastIndexOfAny(_notDefaultValue, _notDefaultValue);

        [Benchmark]
        public int LastIndexOfThreeValues() => new System.Span<T>(_emptyWithSingleValue).LastIndexOfAny(_notDefaultValue, _notDefaultValue, _notDefaultValue);

        [Benchmark]
        public int LastIndexOfAnyFourValues() => new System.Span<T>(_emptyWithSingleValue).IndexOfAny(new ReadOnlySpan<T>(_fourValues));

        [GlobalSetup(Target = nameof(BinarySearch))]
        public void SetupBinarySearch()
        {
            _notDefaultValue = ValuesGenerator.GetNonDefaultValue<T>();
            _emptyWithSingleValue = new T[Size];
            _emptyWithSingleValue[Size - 1] = _notDefaultValue;
        }

        [Benchmark]
        public int BinarySearch() => new System.Span<T>(_emptyWithSingleValue).BinarySearch(_notDefaultValue);

        [Benchmark(OperationsPerInvoke = 16)]
        public void GetPinnableReference()
        {
            var span = new System.Span<T>(_array);

            Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference());
            Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference());
            Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference());
            Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference()); Consume(span.GetPinnableReference());
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void Consume(in T _) { }
    }

#if NET7_0_OR_GREATER
    [BenchmarkCategory(Categories.Runtime, Categories.Libraries, Categories.Span)]
    public class Experiment
    {
        [Params(4, 8, 12)]
        public int Size;

        private char[] _array;

        [GlobalSetup]
        public void Setup() => _array = new char[Size];

        [Benchmark(Baseline = true)]
        public int BuiltIn() => new ReadOnlySpan<char>(_array).IndexOf('a');

        [Benchmark()]
        public int Current() => Current<short>(ref Unsafe.As<char, short>(ref _array[0]), (short)'a', _array.Length);

        [Benchmark()]
        public int Copy() => IndexOfValueType<short>(ref Unsafe.As<char, short>(ref _array[0]), (short)'a', _array.Length);

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static int Current<T>(ref T searchSpace, T value, int length) where T : struct, INumber<T>
        {
            nuint offset = 0;

            while (length >= 8)
            {
                length -= 8;

                if (Unsafe.Add(ref searchSpace, offset) == value) return (int)offset;
                if (Unsafe.Add(ref searchSpace, offset + 1) == value) return (int)offset + 1;
                if (Unsafe.Add(ref searchSpace, offset + 2) == value) return (int)offset + 2;
                if (Unsafe.Add(ref searchSpace, offset + 3) == value) return (int)offset + 3;
                if (Unsafe.Add(ref searchSpace, offset + 4) == value) return (int)offset + 4;
                if (Unsafe.Add(ref searchSpace, offset + 5) == value) return (int)offset + 5;
                if (Unsafe.Add(ref searchSpace, offset + 6) == value) return (int)offset + 6;
                if (Unsafe.Add(ref searchSpace, offset + 7) == value) return (int)offset + 7;

                offset += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                if (Unsafe.Add(ref searchSpace, offset) == value) return (int)offset;
                if (Unsafe.Add(ref searchSpace, offset + 1) == value) return (int)offset + 1;
                if (Unsafe.Add(ref searchSpace, offset + 2) == value) return (int)offset + 2;
                if (Unsafe.Add(ref searchSpace, offset + 3) == value) return (int)offset + 3;

                offset += 4;
            }

            while (length > 0)
            {
                length -= 1;

                if (Unsafe.Add(ref searchSpace, offset).Equals(value)) return (int)offset;

                offset += 1;
            }
            
            return -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int IndexOfValueType<T>(ref T searchSpace, T value, int length) where T : struct, INumber<T>
            => IndexOfValueType<T, DontNegate<T>>(ref searchSpace, value, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int IndexOfAnyExceptValueType<T>(ref T searchSpace, T value, int length) where T : struct, INumber<T>
            => IndexOfValueType<T, Negate<T>>(ref searchSpace, value, length);

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static int IndexOfValueType<T, N>(ref T searchSpace, T value, int length)
            where T : struct, INumber<T>
            where N : struct, INegator<T>
        {
            Debug.Assert(length >= 0, "Expected non-negative length");
            Debug.Assert(value is byte or short or int or long, "Expected caller to normalize to one of these types");

            if (!Vector128.IsHardwareAccelerated || length < Vector128<T>.Count)
            {
                nuint offset = 0;

                while (length >= 8)
                {
                    length -= 8;

                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset) == value)) return (int)offset;
                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset + 1) == value)) return (int)offset + 1;
                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset + 2) == value)) return (int)offset + 2;
                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset + 3) == value)) return (int)offset + 3;
                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset + 4) == value)) return (int)offset + 4;
                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset + 5) == value)) return (int)offset + 5;
                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset + 6) == value)) return (int)offset + 6;
                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset + 7) == value)) return (int)offset + 7;

                    offset += 8;
                }

                if (length >= 4)
                {
                    length -= 4;

                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset) == value)) return (int)offset;
                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset + 1) == value)) return (int)offset + 1;
                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset + 2) == value)) return (int)offset + 2;
                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset + 3) == value)) return (int)offset + 3;

                    offset += 4;
                }

                while (length > 0)
                {
                    length -= 1;

                    if (N.NegateIfNeeded(Unsafe.Add(ref searchSpace, offset).Equals(value))) return (int)offset;

                    offset += 1;
                }
            }
            else if (Vector256.IsHardwareAccelerated && length >= Vector256<T>.Count)
            {
                Vector256<T> equals, values = Vector256.Create(value);
                ref T currentSearchSpace = ref searchSpace;
                ref T oneVectorAwayFromEnd = ref Unsafe.Add(ref searchSpace, length - Vector256<T>.Count);

                // Loop until either we've finished all elements or there's less than a vector's-worth remaining.
                do
                {
                    equals = N.NegateIfNeeded(Vector256.Equals(values, Vector256.LoadUnsafe(ref currentSearchSpace)));
                    if (equals == Vector256<T>.Zero)
                    {
                        currentSearchSpace = ref Unsafe.Add(ref currentSearchSpace, Vector256<T>.Count);
                        continue;
                    }

                    return ComputeFirstIndex(ref searchSpace, ref currentSearchSpace, equals);
                }
                while (!Unsafe.IsAddressGreaterThan(ref currentSearchSpace, ref oneVectorAwayFromEnd));

                // If any elements remain, process the last vector in the search space.
                if ((uint)length % Vector256<T>.Count != 0)
                {
                    equals = N.NegateIfNeeded(Vector256.Equals(values, Vector256.LoadUnsafe(ref oneVectorAwayFromEnd)));
                    if (equals != Vector256<T>.Zero)
                    {
                        return ComputeFirstIndex(ref searchSpace, ref oneVectorAwayFromEnd, equals);
                    }
                }
            }
            else
            {
                Vector128<T> equals, values = Vector128.Create(value);
                ref T currentSearchSpace = ref searchSpace;
                ref T oneVectorAwayFromEnd = ref Unsafe.Add(ref searchSpace, length - Vector128<T>.Count);

                // Loop until either we've finished all elements or there's less than a vector's-worth remaining.
                do
                {
                    equals = N.NegateIfNeeded(Vector128.Equals(values, Vector128.LoadUnsafe(ref currentSearchSpace)));
                    if (equals == Vector128<T>.Zero)
                    {
                        currentSearchSpace = ref Unsafe.Add(ref currentSearchSpace, Vector128<T>.Count);
                        continue;
                    }

                    return ComputeFirstIndex(ref searchSpace, ref currentSearchSpace, equals);
                }
                while (!Unsafe.IsAddressGreaterThan(ref currentSearchSpace, ref oneVectorAwayFromEnd));

                // If any elements remain, process the first vector in the search space.
                if ((uint)length % Vector128<T>.Count != 0)
                {
                    equals = N.NegateIfNeeded(Vector128.Equals(values, Vector128.LoadUnsafe(ref oneVectorAwayFromEnd)));
                    if (equals != Vector128<T>.Zero)
                    {
                        return ComputeFirstIndex(ref searchSpace, ref oneVectorAwayFromEnd, equals);
                    }
                }
            }

            return -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int ComputeFirstIndex<T>(ref T searchSpace, ref T current, Vector128<T> equals) where T : struct
        {
            uint notEqualsElements = equals.ExtractMostSignificantBits();
            int index = BitOperations.TrailingZeroCount(notEqualsElements);
            return index + (int)(Unsafe.ByteOffset(ref searchSpace, ref current) / Unsafe.SizeOf<T>());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int ComputeFirstIndex<T>(ref T searchSpace, ref T current, Vector256<T> equals) where T : struct
        {
            uint notEqualsElements = equals.ExtractMostSignificantBits();
            int index = BitOperations.TrailingZeroCount(notEqualsElements);
            return index + (int)(Unsafe.ByteOffset(ref searchSpace, ref current) / Unsafe.SizeOf<T>());
        }

        private interface INegator<T> where T : struct
        {
            static abstract bool NegateIfNeeded(bool equals);
            static abstract Vector128<T> NegateIfNeeded(Vector128<T> equals);
            static abstract Vector256<T> NegateIfNeeded(Vector256<T> equals);
        }

        private readonly struct DontNegate<T> : INegator<T> where T : struct
        {
            public static bool NegateIfNeeded(bool equals) => equals;
            public static Vector128<T> NegateIfNeeded(Vector128<T> equals) => equals;
            public static Vector256<T> NegateIfNeeded(Vector256<T> equals) => equals;
        }

        private readonly struct Negate<T> : INegator<T> where T : struct
        {
            public static bool NegateIfNeeded(bool equals) => !equals;
            public static Vector128<T> NegateIfNeeded(Vector128<T> equals) => ~equals;
            public static Vector256<T> NegateIfNeeded(Vector256<T> equals) => ~equals;
        }
    }
#endif
}
