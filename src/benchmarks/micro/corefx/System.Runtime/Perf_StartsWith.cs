using BenchmarkDotNet.Attributes;
using MicroBenchmarks;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace System.Runtime
{
    [BenchmarkCategory(Categories.CoreFX)]
    public class Perf_StartsWith
    {
        public IEnumerable<object[]> StartsWithArguments()
        {
            yield return new object[] { "a", "a" };
            yield return new object[] { "aaaaaaaaaaa", "a" };
            yield return new object[] { "a", "aaaaaaaaaaa" };
            yield return new object[] { new string('a', 512), "a" };
            yield return new object[] { new string('a', 512), "aaaaaaaaaaa" };
            yield return new object[] { new string('a', 512), new string('a', 512) };
            yield return new object[] { new string('a', 200_000), "a" };
            yield return new object[] { new string('a', 200_000), "aaaaaaaaaaa" };
            yield return new object[] { new string('a', 200_000), new string('a', 200_000) };
        }

        [GlobalSetup]
        public void Setup() => Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR"); // isAsciiEqualityOrdinal=false

        [Benchmark]
        [ArgumentsSource(nameof(StartsWithArguments))]
        public bool StartsWith(string text, string prefix) => text.StartsWith(prefix);
    }
}
