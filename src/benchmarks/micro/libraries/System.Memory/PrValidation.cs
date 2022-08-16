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

        [Benchmark] public void Contains_byte() => new ReadOnlySpan<byte>(_bytes).Contains((byte)1);
        [Benchmark] public void Contains_char() => new ReadOnlySpan<char>(_chars).Contains('a');

        [Benchmark] public void IndexOf_byte() => new ReadOnlySpan<byte>(_bytes).IndexOf((byte)1);
        [Benchmark] public void IndexOf_char() => new ReadOnlySpan<char>(_chars).IndexOf('a');

        [Benchmark] public void IndexOfAnyExcept_byte() => new ReadOnlySpan<byte>(_bytes).IndexOfAnyExcept(default(byte));
        [Benchmark] public void IndexOfAnyExcept_char() => new ReadOnlySpan<char>(_chars).IndexOfAnyExcept(default(char));

        [Benchmark] public void LastIndexOf_byte() => new ReadOnlySpan<byte>(_bytes).LastIndexOf((byte)1);
        [Benchmark] public void LastIndexOf_char() => new ReadOnlySpan<char>(_chars).LastIndexOf('a');

        [Benchmark] public void LastIndexOfAnyExcept_byte() => new ReadOnlySpan<byte>(_bytes).LastIndexOfAnyExcept(default(byte));
        [Benchmark] public void LastIndexOfAnyExcept_char() => new ReadOnlySpan<char>(_chars).LastIndexOfAnyExcept(default(char));

        [Benchmark] public void IndexOfAnyTwo_byte() => new ReadOnlySpan<byte>(_bytes).IndexOfAny((byte)1, (byte)2);
        [Benchmark] public void IndexOfAnyTwo_char() => new ReadOnlySpan<char>(_chars).IndexOfAny('a', 'b');

        [Benchmark] public void IndexOfAnyExceptTwo_byte() => new ReadOnlySpan<byte>(_bytes).IndexOfAnyExcept(default(byte), default(byte));
        [Benchmark] public void IndexOfAnyExceptTwo_char() => new ReadOnlySpan<char>(_chars).IndexOfAny(default(char), default(char));

        [Benchmark] public void LastIndexOfAnyTwo_byte() => new ReadOnlySpan<byte>(_bytes).LastIndexOfAny((byte)1, (byte)2);
        [Benchmark] public void LastIndexOfAnyTwo_char() => new ReadOnlySpan<char>(_chars).LastIndexOfAny('a', 'b');

        [Benchmark] public void LastIndexOfAnyExceptTwo_byte() => new ReadOnlySpan<byte>(_bytes).LastIndexOfAnyExcept(default(byte), default(byte));
        [Benchmark] public void LastIndexOfAnyExceptTwo_char() => new ReadOnlySpan<char>(_chars).LastIndexOfAnyExcept(default(char), default(char));

        [Benchmark] public void IndexOfAnyThree_byte() => new ReadOnlySpan<byte>(_bytes).IndexOfAny((byte)1, (byte)2, (byte)3);
        [Benchmark] public void IndexOfAnyThree_char() => new ReadOnlySpan<char>(_chars).IndexOfAny('a', 'b', 'c');

        [Benchmark] public void IndexOfAnyExceptThree_byte() => new ReadOnlySpan<byte>(_bytes).IndexOfAnyExcept(default(byte), default(byte), default(byte));
        [Benchmark] public void IndexOfAnyExceptThree_char() => new ReadOnlySpan<char>(_chars).IndexOfAnyExcept(default(char), default(char), default(char));

        [Benchmark] public void LastIndexOfAnyThree_byte() => new ReadOnlySpan<byte>(_bytes).LastIndexOfAny((byte)1, (byte)2, (byte)3);
        [Benchmark] public void LastIndexOfAnyThree_char() => new ReadOnlySpan<char>(_chars).LastIndexOfAny('a', 'b', 'c');

        [Benchmark] public void LastIndexOfAnyExceptThree_byte() => new ReadOnlySpan<byte>(_bytes).LastIndexOfAnyExcept(default(byte), default(byte), default(byte));
        [Benchmark] public void LastIndexOfAnyExceptThree_char() => new ReadOnlySpan<char>(_chars).LastIndexOfAnyExcept(default(char), default(char), default(char));

        [Benchmark] public void IndexOfAnyFour_byte() => new ReadOnlySpan<byte>(_bytes).IndexOfAny(_fourBytes);
        [Benchmark] public void IndexOfAnyFour_char() => new ReadOnlySpan<char>(_chars).IndexOfAny(_fourChars);

        [Benchmark] public void IndexOfAnyExceptFour_byte() => new ReadOnlySpan<byte>(_bytes).IndexOfAnyExcept(_fourDefaultBytes);
        [Benchmark] public void IndexOfAnyExceptFour_char() => new ReadOnlySpan<char>(_chars).IndexOfAnyExcept(_fourDefaultChars);

        [Benchmark] public void LastIndexOfAnyFour_byte() => new ReadOnlySpan<byte>(_bytes).LastIndexOfAny(_fourBytes);
        [Benchmark] public void LastIndexOfAnyFour_char() => new ReadOnlySpan<char>(_chars).LastIndexOfAny(_fourChars);

        [Benchmark] public void LastIndexOfAnyExceptFour_byte() => new ReadOnlySpan<byte>(_bytes).LastIndexOfAnyExcept(_fourDefaultBytes);
        [Benchmark] public void LastIndexOfAnyExceptFour_char() => new ReadOnlySpan<char>(_chars).LastIndexOfAnyExcept(_fourDefaultChars);

        // currently vectorized only for chars
        [Benchmark] public void IndexOfAnyFive_char() => new ReadOnlySpan<char>(_chars).IndexOfAny(_fiveChars);
    }
}
#endif