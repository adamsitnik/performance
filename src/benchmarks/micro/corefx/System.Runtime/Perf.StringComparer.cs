using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Extensions;
using MicroBenchmarks;
using System.Threading;
using System.Threading.Tasks;

namespace System.Tests
{
    [BenchmarkCategory(Categories.CoreFX, Categories.CoreCLR)]
    public class Perf_StringComparer
    {
        [Params(128)] // ArrayPool.Shared.Rent WITH allocation
        public int Count { get; set; }

        [Params(StringComparison.InvariantCultureIgnoreCase)]
        public StringComparison Comparison { get; set; }

        private string _input, _same;
        private StringComparer _comparer;

        [GlobalSetup]
        public void Setup()
        {
            _comparer = GetStringComparer();
            char[] characters = ValuesGenerator.Array<char>(Count);
            _input = new string(characters);
            _same = new string(characters);
        }

        [Benchmark]
        public int GetStringHashCode() => _comparer.GetHashCode(_input);

        [Benchmark]
        public int CompareSame() => _comparer.Compare(_input, _same);

        [Benchmark]
        public bool Repro()
        {
            bool result = false;

            Parallel.For(0, Environment.ProcessorCount / 2, _ =>
            {
                bool local = true;

                for (int i = 0; i < 10_000; i++)
                {
                    local ^= _input.StartsWith(_same);
                }

                result ^= local;
            });

            return result;
        }

        private StringComparer GetStringComparer()
        {
            switch (Comparison)
            {
                case StringComparison.CurrentCulture:
                    return StringComparer.CurrentCulture;
                case StringComparison.CurrentCultureIgnoreCase:
                    return StringComparer.CurrentCultureIgnoreCase;
                case StringComparison.InvariantCulture:
                    return StringComparer.InvariantCulture;
                case StringComparison.InvariantCultureIgnoreCase:
                    return StringComparer.InvariantCultureIgnoreCase;
                case StringComparison.Ordinal:
                    return StringComparer.Ordinal;
                case StringComparison.OrdinalIgnoreCase:
                    return StringComparer.OrdinalIgnoreCase;
                default:
                    throw new NotSupportedException($"{Comparison} is not supported");
            }
        }
    }
}
