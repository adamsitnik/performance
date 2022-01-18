// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using BenchmarkDotNet.Attributes;
using MicroBenchmarks;
using System.Collections.Generic;

namespace System.IO.Compression
{
    [BenchmarkCategory(Categories.Libraries, Categories.NoWASM)]
    public class Brotli : CompressionStreamPerfTestBase
    {
        private const int Window = 22;

        public override Stream CreateStream(Stream stream, CompressionMode mode) => new BrotliStream(stream, mode);
        public override Stream CreateStream(Stream stream, CompressionLevel level) => new BrotliStream(stream, level);

        [Benchmark]
        public Span<byte> Compress_WithState()  
        {
            using (BrotliEncoder encoder = new BrotliEncoder(GetQuality(level), Window))
            {
                Span<byte> output = new Span<byte>(CompressedFile.CompressedData);
                ReadOnlySpan<byte> input = CompressedFile.UncompressedData;
                while (!input.IsEmpty && !output.IsEmpty)
                {
                    encoder.Compress(input, output, out int bytesConsumed, out int written, isFinalBlock:false);
                    input = input.Slice(bytesConsumed);
                    output = output.Slice(written);
                }
                encoder.Compress(input, output, out int bytesConsumed2, out int written2, isFinalBlock: true);

                return output;
            }
        }

        [Benchmark]
        public Span<byte> Decompress_WithState() // the level argument is not used here, but it describes how the data was compressed (in the benchmark id)
        {
            using (BrotliDecoder decoder = new BrotliDecoder())
            {
                Span<byte> output = new Span<byte>(CompressedFile.UncompressedData);
                ReadOnlySpan<byte> input = CompressedFile.CompressedData;
                while (!input.IsEmpty && !output.IsEmpty)
                {
                    decoder.Decompress(input, output, out int bytesConsumed, out int written);
                    input = input.Slice(bytesConsumed);
                    output = output.Slice(written);
                }

                return output;
            }
        }

        [Benchmark]
        public bool Compress_WithoutState()
            => BrotliEncoder.TryCompress(CompressedFile.UncompressedData, CompressedFile.CompressedData, out int bytesWritten, GetQuality(level), Window);

        /// <summary>
        /// The perf tests for the instant decompression aren't exactly indicative of real-world scenarios since they require you to know 
        /// either the exact figure or the upper bound of the uncompressed size of your given compressed data.
        /// </summary>
        [Benchmark]
        public bool Decompress_WithoutState() // the level argument is not used here, but it describes how the data was compressed (in the benchmark id)
            => BrotliDecoder.TryDecompress(CompressedFile.CompressedData, CompressedFile.UncompressedData, out int bytesWritten);
        
        private static int GetQuality(CompressionLevel compressLevel)
            => compressLevel == CompressionLevel.Optimal ? 11 : compressLevel == CompressionLevel.Fastest ? 1 : 0;
    }

    [BenchmarkCategory(Categories.Libraries, Categories.NoWASM)]
    public class BrotliDefaults
    {
        public IEnumerable<string> UncompressedTestFileNames()
        {
            yield return "TestDocument.pdf"; // 199 KB small test document with repeated paragraph, PDF are common
            yield return "alice29.txt"; // 145 KB, copy of "ALICE'S ADVENTURES IN WONDERLAND" book, an example of text file
            yield return "sum"; // 37.3 KB, some binary content, an example of binary file
            yield return "10x10y";
            yield return "64x";
            yield return "backward65536";
            yield return "compressed_file";
            yield return "compressed_repeated";
            yield return "empty";
            yield return "mapsdatazrh";
            yield return "monkey";
            yield return "quickfox";
            yield return "quickfox_repeated";
            yield return "random_org_10k.bin";
            yield return "x";
            yield return "ukkonooa";
            yield return "xyzzy";
            yield return "zeros";
        }

        [ParamsSource(nameof(UncompressedTestFileNames))]
        public string file { get; set; }

        [Params(5, 6, 7, 8, 9, 10, 11)]
        public int quality { get; set; }

        [Params(20, 21, 22, 23, 24)]
        public int window { get; set; }

        private byte[] compressedData;
        private byte[] uncompressedData;

        [GlobalSetup]
        public void Setup()
        {
            string filePath = CompressedFile.GetFilePath(file);
            uncompressedData = File.ReadAllBytes(filePath);
            compressedData = new byte[uncompressedData.Length];
            if (!BrotliEncoder.TryCompress(uncompressedData, compressedData, out int bytesWritten, quality, window))
            {
                throw new Exception("bug");
            }
            Array.Resize(ref compressedData, bytesWritten);
        }

        [Benchmark]
        public Span<byte> Compress_WithState()
        {
            using (BrotliEncoder encoder = new BrotliEncoder(quality, window))
            {
                Span<byte> output = new Span<byte>(compressedData);
                ReadOnlySpan<byte> input = uncompressedData;
                while (!input.IsEmpty && !output.IsEmpty)
                {
                    encoder.Compress(input, output, out int bytesConsumed, out int written, isFinalBlock: false);
                    input = input.Slice(bytesConsumed);
                    output = output.Slice(written);
                }
                encoder.Compress(input, output, out int bytesConsumed2, out int written2, isFinalBlock: true);

                return output;
            }
        }

        [Benchmark]
        public Span<byte> Decompress_WithState() // the level argument is not used here, but it describes how the data was compressed (in the benchmark id)
        {
            using (BrotliDecoder decoder = new BrotliDecoder())
            {
                Span<byte> output = new Span<byte>(uncompressedData);
                ReadOnlySpan<byte> input = compressedData;
                while (!input.IsEmpty && !output.IsEmpty)
                {
                    decoder.Decompress(input, output, out int bytesConsumed, out int written);
                    input = input.Slice(bytesConsumed);
                    output = output.Slice(written);
                }

                return output;
            }
        }

        [Benchmark]
        public bool Compress_WithoutState()
            => BrotliEncoder.TryCompress(uncompressedData, compressedData, out int _, quality, window);

        [Benchmark]
        public bool Decompress_WithoutState()
            => BrotliDecoder.TryDecompress(compressedData, uncompressedData, out int _);
    }
}
