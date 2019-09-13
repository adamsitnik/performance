using BenchmarkDotNet.Attributes;
using MicroBenchmarks;
using System.Globalization;
using System.Threading;

namespace System.Runtime
{
    [BenchmarkCategory(Categories.CoreFX)]
    public class Perf_StartsWith
    {
        [Params(1, 512, 200_000)]
        public int Length;

        private string text;
        private string patternDiffAtLastChar;
        private string same;

        [GlobalSetup]
        public void Setup()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");

            text = new string('a', Length);

            var copy = text.ToCharArray();
            same = new string(copy);

            copy[copy.Length - 1] = (char)(copy[copy.Length - 1] + 1);
            patternDiffAtLastChar = new string(copy);
        }

        [Benchmark]
        public bool StartsWith_DiffAtFirstChar() => text.StartsWith("i");

        [Benchmark]
        public bool StartsWith_Same() => text.StartsWith(same);

        [Benchmark]
        public bool StartsWith_DiffAtLastChar() => text.StartsWith(patternDiffAtLastChar);
    }
}
