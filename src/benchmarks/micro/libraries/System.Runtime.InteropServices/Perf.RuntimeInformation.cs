using BenchmarkDotNet.Attributes;
using MicroBenchmarks;

namespace System.Runtime.InteropServices
{
    [BenchmarkCategory(Categories.Libraries)]
    public class Perf_RuntimeInformation
    {
        private readonly OSPlatform _notCurrent = OSPlatform.Create("NOPE");
        private readonly OSPlatform _current;

        public Perf_RuntimeInformation()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                _current = OSPlatform.Windows;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                _current = OSPlatform.OSX;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                _current = OSPlatform.Linux;
            }
            else
            {
                throw new NotSupportedException($"Please add {Environment.OSVersion} to the list of supported OSes");
            }
        }

        [Benchmark]
        public bool IsOSPlatform_True() => RuntimeInformation.IsOSPlatform(_current);

        [Benchmark]
        public bool IsOSPlatform_False() => RuntimeInformation.IsOSPlatform(_notCurrent);

        // OSArchitecture, ProcessArchitecture, FrameworkDescription and OSDescription are not benchmarked as they're just simple getters that return field value
    }
}
