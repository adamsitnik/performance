#if NET7_0_OR_GREATER
using BenchmarkDotNet.Attributes;
using MicroBenchmarks;
using System.Runtime.CompilerServices;

namespace System.Memory
{
    [BenchmarkCategory(Categories.Runtime, Categories.Libraries, Categories.Span)]
    public class PrValidation
    {
        [Params(4, 8, 32, 1024)]
        public int Size;

        private byte[] _bytes, _fourBytes, _fourDefaultBytes;
        private char[] _chars, _fourChars, _fiveChars, _fourDefaultChars;

        [GlobalSetup]
        public void Setup()
        {
            _bytes = new byte[Size];
            _fourBytes = new byte[4] { 1, 2, 3, 4 };
            _fourDefaultBytes = new byte[4];
            _chars = new char[Size];
            _fourChars = new char[4] { 'a', 'b', 'c', 'd' };
            _fiveChars = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            _fourDefaultChars = new char[4];
        }

        [Benchmark] public void Contains_byte() => _bytes.AsSpan().Contains((byte)1);
        [Benchmark] public void Contains_char() => _chars.AsSpan().Contains('a');

        [Benchmark] public void IndexOf_byte() => _bytes.AsSpan().IndexOf((byte)1);
        [Benchmark] public void IndexOf_char() => _chars.AsSpan().IndexOf('a');

        [Benchmark] public void IndexOfAnyExcept_byte() => _bytes.AsSpan().IndexOfAnyExcept(default(byte));
        [Benchmark] public void IndexOfAnyExcept_char() => _chars.AsSpan().IndexOfAnyExcept(default(char));

        [Benchmark] public void LastIndexOf_byte() => _bytes.AsSpan().LastIndexOf((byte)1);
        [Benchmark] public void LastIndexOf_char() => _chars.AsSpan().LastIndexOf('a');

        [Benchmark] public void LastIndexOfAnyExcept_byte() => _bytes.AsSpan().LastIndexOfAnyExcept(default(byte));
        [Benchmark] public void LastIndexOfAnyExcept_char() => _chars.AsSpan().LastIndexOfAnyExcept(default(char));

        [Benchmark] public void IndexOfAnyTwo_byte() => _bytes.AsSpan().IndexOfAny((byte)1, (byte)2);
        [Benchmark] public void IndexOfAnyTwo_char() => _chars.AsSpan().IndexOfAny('a', 'b');

        [Benchmark] public void IndexOfAnyExceptTwo_byte() => _bytes.AsSpan().IndexOfAnyExcept(default(byte), default(byte));
        [Benchmark] public void IndexOfAnyExceptTwo_char() => _chars.AsSpan().IndexOfAny(default(char), default(char));

        [Benchmark] public void LastIndexOfAnyTwo_byte() => _bytes.AsSpan().LastIndexOfAny((byte)1, (byte)2);
        [Benchmark] public void LastIndexOfAnyTwo_char() => _chars.AsSpan().LastIndexOfAny('a', 'b');

        [Benchmark] public void LastIndexOfAnyExceptTwo_byte() => _bytes.AsSpan().LastIndexOfAnyExcept(default(byte), default(byte));
        [Benchmark] public void LastIndexOfAnyExceptTwo_char() => _chars.AsSpan().LastIndexOfAnyExcept(default(char), default(char));

        [Benchmark] public void IndexOfAnyThree_byte() => _bytes.AsSpan().IndexOfAny((byte)1, (byte)2, (byte)3);
        [Benchmark] public void IndexOfAnyThree_char() => _chars.AsSpan().IndexOfAny('a', 'b', 'c');

        [Benchmark] public void IndexOfAnyExceptThree_byte() => _bytes.AsSpan().IndexOfAnyExcept(default(byte), default(byte), default(byte));
        [Benchmark] public void IndexOfAnyExceptThree_char() => _chars.AsSpan().IndexOfAnyExcept(default(char), default(char), default(char));

        [Benchmark] public void LastIndexOfAnyThree_byte() => _bytes.AsSpan().LastIndexOfAny((byte)1, (byte)2, (byte)3);
        [Benchmark] public void LastIndexOfAnyThree_char() => _chars.AsSpan().LastIndexOfAny('a', 'b', 'c');

        [Benchmark] public void LastIndexOfAnyExceptThree_byte() => _bytes.AsSpan().LastIndexOfAnyExcept(default(byte), default(byte), default(byte));
        [Benchmark] public void LastIndexOfAnyExceptThree_char() => _chars.AsSpan().LastIndexOfAnyExcept(default(char), default(char), default(char));

        [Benchmark] public void IndexOfAnyFour_byte() => _bytes.AsSpan().IndexOfAny(_fourBytes);
        [Benchmark] public void IndexOfAnyFour_char() => _chars.AsSpan().IndexOfAny(_fourChars);

        [Benchmark] public void IndexOfAnyExceptFour_byte() => _bytes.AsSpan().IndexOfAnyExcept(_fourDefaultBytes);
        [Benchmark] public void IndexOfAnyExceptFour_char() => _chars.AsSpan().IndexOfAnyExcept(_fourDefaultChars);

        [Benchmark] public void LastIndexOfAnyFour_byte() => _bytes.AsSpan().LastIndexOfAny(_fourBytes);
        [Benchmark] public void LastIndexOfAnyFour_char() => _chars.AsSpan().LastIndexOfAny(_fourChars);

        [Benchmark] public void LastIndexOfAnyExceptFour_byte() => _bytes.AsSpan().LastIndexOfAnyExcept(_fourDefaultBytes);
        [Benchmark] public void LastIndexOfAnyExceptFour_char() => _chars.AsSpan().LastIndexOfAnyExcept(_fourDefaultChars);

        // currently vectorized only for chars
        [Benchmark] public void IndexOfAnyFive_char() => _chars.AsSpan().IndexOfAny(_fiveChars);
    }
}
#endif