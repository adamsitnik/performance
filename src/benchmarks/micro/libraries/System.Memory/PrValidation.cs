using BenchmarkDotNet.Attributes;
using MicroBenchmarks;

namespace System.Memory
{
    [BenchmarkCategory(Categories.Runtime, Categories.Libraries, Categories.Span)]
    public class PrValidation
    {
        [Params(4, 8, 12, 32, 64, 512)]
        public int Size;

        private byte[] _bytes;
        private char[] _chars;

        [GlobalSetup]
        public void Setup()
        {
            _bytes = new byte[Size];
            _chars = new char[Size];
        }

        [Benchmark]
        public int IndexOf_byte() => _bytes.AsSpan().IndexOf((byte)1);

        [Benchmark]
        public int IndexOf_char() => _chars.AsSpan().IndexOf('a');

        [Benchmark]
        public int LastIndexOf_byte() => _bytes.AsSpan().LastIndexOf((byte)1);

        [Benchmark]
        public int LastIndexOf_char() => _chars.AsSpan().LastIndexOf('a');
    }
}
