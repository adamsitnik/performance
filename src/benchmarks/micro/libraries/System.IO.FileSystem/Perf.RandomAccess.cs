// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Extensions;
using MicroBenchmarks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Tests
{
    [BenchmarkCategory(Categories.Libraries)]
    public class Perf_RandomAccess
    {
        private const int OneKibibyte  = 1 << 10; // 1024
        private const int FourKibibytes = OneKibibyte << 2; // default Stream buffer size
        private const int SixteenKibibytes = FourKibibytes << 2; // default Stream buffer size * 4
        private const int SixtyFourKibibytes = SixteenKibibytes << 2; // default Stream buffer size * 16
        private const int OneMibibyte = OneKibibyte  << 10;
        private const int HundredMibibytes = OneMibibyte * 100;

        const int FileSize = 100_000_000;
        string _filePath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
        byte[] _buffer = new byte[16000];

        [Benchmark]
        [Arguments(true)]
        [Arguments(false)]
        public void PreallocationSize(bool specifyPreallocationSize)
        {
            byte[] userBuffer = _buffer;

            long preallocationSize = specifyPreallocationSize ? FileSize : 0;

            using (SafeFileHandle fileHandle = File.OpenHandle(_filePath, FileMode.Create, FileAccess.Write, FileShare.Read, FileOptions.DeleteOnClose, preallocationSize))
            {
                long bytesWritten = 0;
                for (int i = 0; i < FileSize / userBuffer.Length; i++)
                {
                    RandomAccess.Write(fileHandle, userBuffer, bytesWritten);
                    bytesWritten += userBuffer.Length;
                }
            }
        }

        [Benchmark(Baseline = true)]
        public void Write()
        {
            byte[] userBuffer = _buffer;
            using SafeFileHandle fileHandle = File.OpenHandle(_filePath, FileMode.Create, FileAccess.Write, FileShare.Read, FileOptions.DeleteOnClose);

            long bytesWritten = 0;
            for (int i = 0; i < FileSize / userBuffer.Length; i++)
            {
                RandomAccess.Write(fileHandle, userBuffer, bytesWritten);
                bytesWritten += userBuffer.Length;
            }
        }

        [Benchmark]
        public void WriteGather()
        {
            byte[] userBuffer = _buffer;
            IReadOnlyList<ReadOnlyMemory<byte>> buffers = new ReadOnlyMemory<byte>[] { _buffer, _buffer, _buffer, _buffer };
            using SafeFileHandle fileHandle = File.OpenHandle(_filePath, FileMode.Create, FileAccess.Write, FileShare.Read, FileOptions.DeleteOnClose);
            
            long bytesWritten = 0;
            for (int i = 0; i < FileSize / (userBuffer.Length * 4); i++)
            {
                RandomAccess.Write(fileHandle, buffers, bytesWritten);
                bytesWritten += userBuffer.Length * 4;
            }
        }
    }
}


//namespace System.IO
//{
//    public static class RandomAccess
//    {
//        public static int Read(SafeFileHandle handle, Span<byte> buffer, long fileOffset) => 0;
//        public static void Write(SafeFileHandle handle, ReadOnlySpan<byte> buffer, long fileOffset) { }

//        public static ValueTask<int> ReadAsync(SafeFileHandle handle, Memory<byte> buffer, long fileOffset, CancellationToken cancellationToken = default) => new ValueTask<int>(0);
//        public static ValueTask WriteAsync(SafeFileHandle handle, ReadOnlyMemory<byte> buffer, long fileOffset, CancellationToken cancellationToken = default) => new ValueTask();

//        public static long Read(SafeFileHandle handle, IReadOnlyList<Memory<byte>> buffers, long fileOffset) => 0;
//        public static void Write(SafeFileHandle handle, IReadOnlyList<ReadOnlyMemory<byte>> buffers, long fileOffset) { }

//        public static ValueTask<long> ReadAsync(SafeFileHandle handle, IReadOnlyList<Memory<byte>> buffers, long fileOffset, CancellationToken cancellationToken = default) => new ValueTask<long>(0);
//        public static ValueTask WriteAsync(SafeFileHandle handle, IReadOnlyList<ReadOnlyMemory<byte>> buffers, long fileOffset, CancellationToken cancellationToken = default) => new ValueTask();

//        public static long GetLength(SafeFileHandle handle) => 0;
//    }

//    partial class File
//    {
//        public static SafeFileHandle OpenHandle(string filePath, FileMode mode = FileMode.Open, FileAccess access = FileAccess.Read,
//            FileShare share = FileShare.Read, FileOptions options = FileOptions.None, long preallocationSize = 0) => null;
//    }
//}