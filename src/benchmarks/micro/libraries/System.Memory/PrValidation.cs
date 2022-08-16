#if NET7_0_OR_GREATER
using BenchmarkDotNet.Attributes;
using MicroBenchmarks;

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

        [Benchmark] public bool Contains_byte() => _bytes.AsSpan().Contains((byte)1);
        [Benchmark] public bool Contains_char() => _chars.AsSpan().Contains('a');

        [Benchmark] public int IndexOf_byte() => _bytes.AsSpan().IndexOf((byte)1);
        [Benchmark] public int IndexOf_char() => _chars.AsSpan().IndexOf('a');

        [Benchmark] public int IndexOfAnyExcept_byte() => _bytes.AsSpan().IndexOfAnyExcept(default(byte));
        [Benchmark] public int IndexOfAnyExcept_char() => _chars.AsSpan().IndexOfAnyExcept(default(char));

        [Benchmark] public int LastIndexOf_byte() => _bytes.AsSpan().LastIndexOf((byte)1);
        [Benchmark] public int LastIndexOf_char() => _chars.AsSpan().LastIndexOf('a');

        [Benchmark] public int LastIndexOfAnyExcept_byte() => _bytes.AsSpan().LastIndexOfAnyExcept(default(byte));
        [Benchmark] public int LastIndexOfAnyExcept_char() => _chars.AsSpan().LastIndexOfAnyExcept(default(char));

        [Benchmark] public int IndexOfAnyTwo_byte() => _bytes.AsSpan().IndexOfAny((byte)1, (byte)2);
        [Benchmark] public int IndexOfAnyTwo_char() => _chars.AsSpan().IndexOfAny('a', 'b');

        [Benchmark] public int IndexOfAnyExceptTwo_byte() => _bytes.AsSpan().IndexOfAnyExcept(default(byte), default(byte));
        [Benchmark] public int IndexOfAnyExceptTwo_char() => _chars.AsSpan().IndexOfAny(default(char), default(char));

        [Benchmark] public int LastIndexOfAnyTwo_byte() => _bytes.AsSpan().LastIndexOfAny((byte)1, (byte)2);
        [Benchmark] public int LastIndexOfAnyTwo_char() => _chars.AsSpan().LastIndexOfAny('a', 'b');

        [Benchmark] public int LastIndexOfAnyExceptTwo_byte() => _bytes.AsSpan().LastIndexOfAnyExcept(default(byte), default(byte));
        [Benchmark] public int LastIndexOfAnyExceptTwo_char() => _chars.AsSpan().LastIndexOfAny(default(char), default(char));

        [Benchmark] public int IndexOfAnyThree_byte() => _bytes.AsSpan().IndexOfAny((byte)1, (byte)2, (byte)3);
        [Benchmark] public int IndexOfAnyThree_char() => _chars.AsSpan().IndexOfAny('a', 'b', 'c');

        [Benchmark] public int IndexOfAnyExceptThree_byte() => _bytes.AsSpan().IndexOfAnyExcept(default(byte), default(byte), default(byte));
        [Benchmark] public int IndexOfAnyExceptThree_char() => _chars.AsSpan().IndexOfAnyExcept(default(char), default(char), default(char));

        [Benchmark] public int LastIndexOfAnyThree_byte() => _bytes.AsSpan().LastIndexOfAny((byte)1, (byte)2, (byte)3);
        [Benchmark] public int LastIndexOfAnyThree_char() => _chars.AsSpan().LastIndexOfAny('a', 'b', 'c');

        [Benchmark] public int LastIndexOfAnyExceptThree_byte() => _bytes.AsSpan().LastIndexOfAnyExcept(default(byte), default(byte), default(byte));
        [Benchmark] public int LastIndexOfAnyExceptThree_char() => _chars.AsSpan().LastIndexOfAnyExcept(default(char), default(char), default(char));

        [Benchmark] public int IndexOfAnyFour_byte() => _bytes.AsSpan().IndexOfAny(_fourBytes);
        [Benchmark] public int IndexOfAnyFour_char() => _chars.AsSpan().IndexOfAny(_fourChars);

        [Benchmark] public int IndexOfAnyExceptFour_byte() => _bytes.AsSpan().IndexOfAnyExcept(_fourDefaultBytes);
        [Benchmark] public int IndexOfAnyExceptFour_char() => _chars.AsSpan().IndexOfAnyExcept(_fourDefaultChars);

        [Benchmark] public int LastIndexOfAnyFour_byte() => _bytes.AsSpan().LastIndexOfAny(_fourBytes);
        [Benchmark] public int LastIndexOfAnyFour_char() => _chars.AsSpan().LastIndexOfAny(_fourChars);

        [Benchmark] public int LastIndexOfAnyExceptFour_byte() => _bytes.AsSpan().LastIndexOfAnyExcept(_fourDefaultBytes);
        [Benchmark] public int LastIndexOfAnyExceptFour_char() => _chars.AsSpan().LastIndexOfAnyExcept(_fourDefaultChars);

        // currently vectorized only for chars
        [Benchmark] public int IndexOfAnyFive_char() => _chars.AsSpan().IndexOfAny(_fiveChars);
    }
}
#endif