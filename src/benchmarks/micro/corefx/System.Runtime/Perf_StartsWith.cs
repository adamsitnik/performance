using BenchmarkDotNet.Attributes;
using MicroBenchmarks;

namespace System.Runtime
{
    [BenchmarkCategory(Categories.CoreFX)]
    public class Perf_StartsWith
    {
        [Params(1, 512, 200_000)]
        public int Length;

        [Params(true, false)]
        public bool Cached;

        [Params(true, false)]
        public bool EdgeCase;

        private string left;

        private string Left => Cached ? left : EdgeCase ? string.Concat(new string('a', Length), "-") : new string('a', Length);

        [GlobalSetup]
        public void Setup() => left = EdgeCase ? string.Concat(new string('a', Length), "-") : new string('a', Length);

        [Benchmark]
        public bool StartsWith() => Left.StartsWith("i", StringComparison.CurrentCulture);
    }
}
