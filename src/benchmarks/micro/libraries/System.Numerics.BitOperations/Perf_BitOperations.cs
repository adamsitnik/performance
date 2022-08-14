// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Numerics;
using BenchmarkDotNet.Attributes;
using MicroBenchmarks;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Extensions;
using System.Runtime.Intrinsics;

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
        private byte[] _bytes = new byte[1024];
        private short[] _shorts = new short[1024];

        [Benchmark]
        public int Byte_FirstIndex() => CallComputeFirstIndexALot<byte>(_bytes, 1);

        [Benchmark]
        public int Byte_Lastndex() => CallComputeLastIndexALot<byte>(_bytes, 1);

        [Benchmark]
        public int Short_FirstIndex() => CallComputeFirstIndexALot<short>(_shorts, 1);

        [Benchmark]
        public int Short_Lastndex() => CallComputeLastIndexALot<short>(_shorts, 1);

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static int CallComputeFirstIndexALot<T>(T[] array, T value) where T : struct
        {
            ref T searchSpace = ref array[0];
            ref T currentSearchSpace = ref array[0];
            ref T oneVectorAwayFromEnd = ref Unsafe.Add(ref searchSpace, array.Length - Vector128<T>.Count);
            int result = 0;
            Vector128<T> values = Vector128.Create(value);

            do
            {
                Vector128<T> equals = Vector128.Equals(Vector128.LoadUnsafe(ref currentSearchSpace), values);
                result += ComputeFirstIndex(ref searchSpace, ref currentSearchSpace, equals);
                currentSearchSpace = ref Unsafe.Add(ref currentSearchSpace, Vector128<T>.Count);
            }
            while (!Unsafe.IsAddressGreaterThan(ref currentSearchSpace, ref oneVectorAwayFromEnd));

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static int CallComputeLastIndexALot<T>(T[] array, T value) where T : struct
        {
            ref T searchSpace = ref array[0];
            ref T currentSearchSpace = ref Unsafe.Add(ref searchSpace, array.Length - Vector128<T>.Count);
            int result = 0;
            Vector128<T> values = Vector128.Create(value);

            do
            {
                Vector128<T> equals = Vector128.Equals(Vector128.LoadUnsafe(ref currentSearchSpace), values);
                result += ComputeLastIndex(ref searchSpace, ref currentSearchSpace, equals);
                currentSearchSpace = ref Unsafe.Subtract(ref currentSearchSpace, Vector128<T>.Count);
            }
            while (!Unsafe.IsAddressLessThan(ref currentSearchSpace, ref searchSpace));

            return result;
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
