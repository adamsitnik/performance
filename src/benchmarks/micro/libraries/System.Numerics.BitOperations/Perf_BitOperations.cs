// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Numerics;
using BenchmarkDotNet.Attributes;
using MicroBenchmarks;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Extensions;
using System.Runtime.Intrinsics;
using System;
using System.Memory;

namespace System.Numerics.Tests
{
    [BenchmarkCategory(Categories.Libraries, Categories.SIMD, Categories.JIT)]
    public class Perf_BitOperations
    {
        private static uint[] input_uint = ValuesGenerator.Array<uint>(1000);
        private static ulong[] input_ulong = ValuesGenerator.Array<ulong>(1000);

        [Benchmark]
        public int LeadingZeroCount_uint()
        {
            int sum = 0;
            uint[] input = input_uint;
            for (int i = 0; i < input.Length; i++)
            {
                sum += BitOperations.LeadingZeroCount(input[i]);
            }
            return sum;
        }

        [Benchmark]
        public int LeadingZeroCount_ulong()
        {
            int sum = 0;
            ulong[] input = input_ulong;
            for (int i = 0; i < input.Length; i++)
            {
                sum += BitOperations.LeadingZeroCount(input[i]);
            }
            return sum;
        }

        [Benchmark]
        public int Log2_uint()
        {
            int sum = 0;
            uint[] input = input_uint;
            for (int i = 0; i < input.Length; i++)
            {
                sum += BitOperations.Log2(input[i]);
            }
            return sum;
        }

        [Benchmark]
        public int Log2_ulong()
        {
            int sum = 0;
            ulong[] input = input_ulong;
            for (int i = 0; i < input.Length; i++)
            {
                sum += BitOperations.Log2(input[i]);
            }
            return sum;
        }

        [Benchmark]
        public int TrailingZeroCount_uint()
        {
            int sum = 0;
            uint[] input = input_uint;
            for (int i = 0; i < input.Length; i++)
            {
                sum += BitOperations.TrailingZeroCount(input[i]);
            }
            return sum;
        }

        [Benchmark]
        public int TrailingZeroCount_ulong()
        {
            int sum = 0;
            ulong[] input = input_ulong;
            for (int i = 0; i < input.Length; i++)
            {
                sum += BitOperations.TrailingZeroCount(input[i]);
            }
            return sum;
        }

        [Benchmark]
        public int PopCount_uint()
        {
            int sum = 0;
            uint[] input = input_uint;
            for (int i = 0; i < input.Length; i++)
            {
                sum += BitOperations.PopCount(input[i]);
            }
            return sum;
        }

        [Benchmark]
        public int PopCount_ulong()
        {
            int sum = 0;
            ulong[] input = input_ulong;
            for (int i = 0; i < input.Length; i++)
            {
                sum += BitOperations.PopCount(input[i]);
            }
            return sum;
        }
    }

#if NET7_0_OR_GREATER
    [BenchmarkCategory(Categories.Libraries, Categories.SIMD, Categories.JIT)]
    public class Repro
    {
        private byte[] _bytes;
        private short[] _shorts;

        public Repro()
        {
            _bytes = new byte[512];
            _bytes[_bytes.Length / 2] = 1;
            _shorts = new short[512];
            _shorts[_shorts.Length / 2] = 1;
        }

        [Benchmark]
        public int Byte_FirstIndex_BuiltIn() => new ReadOnlySpan<byte>(_bytes).IndexOf((byte)1);

        [Benchmark]
        public int Byte_Lastndex_BuiltIn() => new ReadOnlySpan<byte>(_bytes).LastIndexOf((byte)1);

        [Benchmark]
        public int Short_FirstIndex_BuiltIn() => new ReadOnlySpan<short>(_shorts).IndexOf((short)1);

        [Benchmark]
        public int Short_Lastndex_BuiltIn() => new ReadOnlySpan<short>(_shorts).LastIndexOf((short)1);

        [Benchmark]
        public int Byte_FirstIndex() => IndexOfValueType<byte>(ref _bytes[0], 1, _bytes.Length);

        [Benchmark]
        public int Byte_Lastndex() => LastIndexOfValueType<byte>(ref _bytes[0], 1, _bytes.Length);

        [Benchmark]
        public int Short_FirstIndex() => IndexOfValueType<short>(ref _shorts[0], 1, _shorts.Length);

        [Benchmark]
        public int Short_Lastndex() => LastIndexOfValueType<short>(ref _shorts[0], 1, _shorts.Length);

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static int IndexOfValueType<T>(ref T searchSpace, T value, int length) where T : struct, INumber<T>
        {
            if (!Vector128.IsHardwareAccelerated || length < Vector128<T>.Count)
            {
                // removed for brevity
            }
            else
            {
                Vector128<T> equals, values = Vector128.Create(value);
                ref T currentSearchSpace = ref searchSpace;
                ref T oneVectorAwayFromEnd = ref Unsafe.Add(ref searchSpace, length - Vector128<T>.Count);

                // Loop until either we've finished all elements or there's less than a vector's-worth remaining.
                do
                {
                    equals = Vector128.Equals(values, Vector128.LoadUnsafe(ref currentSearchSpace));
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
                    equals = Vector128.Equals(values, Vector128.LoadUnsafe(ref oneVectorAwayFromEnd));
                    if (equals != Vector128<T>.Zero)
                    {
                        return ComputeFirstIndex(ref searchSpace, ref oneVectorAwayFromEnd, equals);
                    }
                }
            }

            return -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static int LastIndexOfValueType<T>(ref T searchSpace, T value, int length)
            where T : struct, INumber<T>
        {
            if (!Vector128.IsHardwareAccelerated || length < Vector128<T>.Count)
            {
                // removed for brevity
            }
            else
            {
                Vector128<T> equals, values = Vector128.Create(value);
                ref T currentSearchSpace = ref Unsafe.Add(ref searchSpace, length - Vector128<T>.Count);

                // Loop until either we've finished all elements or there's less than a vector's-worth remaining.
                do
                {
                    equals = Vector128.Equals(values, Vector128.LoadUnsafe(ref currentSearchSpace));
                    if (equals == Vector128<T>.Zero)
                    {
                        currentSearchSpace = ref Unsafe.Subtract(ref currentSearchSpace, Vector128<T>.Count);
                        continue;
                    }

                    return ComputeLastIndex(ref searchSpace, ref currentSearchSpace, equals);
                }
                while (!Unsafe.IsAddressLessThan(ref currentSearchSpace, ref searchSpace));

                // If any elements remain, process the first vector in the search space.
                if ((uint)length % Vector128<T>.Count != 0)
                {
                    equals = Vector128.Equals(values, Vector128.LoadUnsafe(ref searchSpace));
                    if (equals != Vector128<T>.Zero)
                    {
                        return ComputeLastIndex(ref searchSpace, ref searchSpace, equals);
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
            return index + (int)((long)Unsafe.ByteOffset(ref searchSpace, ref current) / Unsafe.SizeOf<T>());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int ComputeLastIndex<T>(ref T searchSpace, ref T current, Vector128<T> equals) where T : struct
        {
            uint notEqualsElements = equals.ExtractMostSignificantBits();
            int index = 31 - BitOperations.LeadingZeroCount(notEqualsElements); // 31 = 32 (bits in Int32) - 1 (indexing from zero)
            return (int)((long)Unsafe.ByteOffset(ref searchSpace, ref current) / Unsafe.SizeOf<T>()) + index;
        }
    }
#endif
}
