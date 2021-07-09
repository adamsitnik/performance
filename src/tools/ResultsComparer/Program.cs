// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Mathematics.StatisticalTesting;
using CommandLine;
using DataTransferContracts;
using MarkdownLog;
using Newtonsoft.Json;

namespace ResultsComparer
{
    public class Program
    {
        private const string FullBdnJsonFileExtension = "full.json";

        public static void Main(string[] args)
        {
            // we print a lot of numbers here and we want to make it always in invariant way
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Parser.Default.ParseArguments<CommandLineOptions>(args).WithParsed(Compare);
        }

        private static void Compare(CommandLineOptions args)
        {
            if (!Threshold.TryParse(args.StatisticalTestThreshold, out var testThreshold))
            {
                Console.WriteLine($"Invalid Threshold {args.StatisticalTestThreshold}. Examples: 5%, 10ms, 100ns, 1s.");
                return;
            }
            if (!Threshold.TryParse(args.NoiseThreshold, out var noiseThreshold))
            {
                Console.WriteLine($"Invalid Noise Threshold {args.NoiseThreshold}. Examples: 0.3ns 1ns.");
                return;
            }
            if (args.BasePaths.Count() != args.DiffPaths.Count())
            {
                Console.WriteLine($"The number of base and diff input files/folders must be the same.");
                return;
            }

            if (!string.IsNullOrEmpty(args.Input))
            {
                var basePaths = new List<string>();
                var diffPaths = new List<string>();
                foreach (var netcoreapp31Folder in Directory.GetDirectories(args.Input, "net50*"))
                {
                    var netcoreapp50Folder = netcoreapp31Folder.Replace("net50", "net60");
                    if (Directory.Exists(netcoreapp50Folder))
                    {
                        basePaths.Add(netcoreapp31Folder);
                        diffPaths.Add(netcoreapp50Folder);
                    }
                }

                args.BasePaths = basePaths;
                args.DiffPaths = diffPaths;
            }

            Regex[] filters = args.Filters.Select(pattern => new Regex(WildcardToRegex(pattern), RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)).ToArray();

            Console.WriteLine("# Legend");
            Console.WriteLine();
            Console.WriteLine($"* Statistical Test threshold: {testThreshold}, the noise filter: {noiseThreshold}");
            Console.WriteLine("* Result is conslusion: Slower|Faster|Same");
            Console.WriteLine("* Base is median base execution time in nanoseconds");
            Console.WriteLine("* Diff is median diff execution time in nanoseconds");
            Console.WriteLine("* Ratio = Base/Diff (the higher the better)");
            Console.WriteLine("* Alloc Delta = Allocated bytes diff - Allocated bytes base (the lower the better)");
            Console.WriteLine("* Base V = Base Runtime Version");
            Console.WriteLine("* Diff V = Diff Runtime Version");
            Console.WriteLine();
            
            foreach(var benchmarkResults in args.BasePaths
                .SelectMany((basePath, index) => GetResults(basePath, args.DiffPaths.ElementAt(index), testThreshold, noiseThreshold, filters))
                .GroupBy(result => result.id, StringComparer.InvariantCulture)
                //.Where(group => group.Any(result => result.conclusion == EquivalenceTestConclusion.Slower))
                //.Where(group => !group.All(result => result.conclusion == EquivalenceTestConclusion.Same || result.conclusion == EquivalenceTestConclusion.Base)) // we are not interested in things that did not change
                .Take(args.TopCount ?? int.MaxValue)
                .OrderBy(group => group.Sum(result => Score(result.conclusion, result.baseEnv, result.baseResult, result.diffResult))))
            {
                Console.WriteLine($"## {benchmarkResults.Key}");
                Console.WriteLine();

                var data = benchmarkResults
                    .OrderBy(result => Importance(result.baseEnv))
                    .Select(result => new
                    {
                        Conclusion = result.conclusion,
                        BaseMedian = result.baseResult.Statistics.Median,
                        DiffMedian = result.diffResult.Statistics.Median,
                        Ratio = result.baseResult.Statistics.Median / result.diffResult.Statistics.Median,
                        AllocatedDiff = (result.diffResult.Memory.BytesAllocatedPerOperation - result.baseResult.Memory.BytesAllocatedPerOperation).ToString("+0;-#"),
                        Modality = GetModalInfo(result.baseResult) ?? GetModalInfo(result.diffResult),
                        OperatingSystem = Simplify(result.baseEnv.OsVersion),
                        Architecture = result.baseEnv.Architecture,
                        ProcessorName = result.baseEnv.ProcessorName,
                        BaseRuntimeVersion = GetSimplifiedRuntimeVersion(result.baseEnv.RuntimeVersion),
                        DiffRuntimeVersion = GetSimplifiedRuntimeVersion(result.diffEnv.RuntimeVersion),
                    })
                    .ToArray();

                var table = data.ToMarkdownTable().WithHeaders("Result", "Base", "Diff", "Ratio", "Alloc Delta", "Modality", "Operating System", "Bit", "Processor Name", "Base V", "Diff V");

                foreach (var line in table.ToMarkdown().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
                    Console.WriteLine($"| {line.TrimStart()}|"); // the table starts with \t and does not end with '|' and it looks bad so we fix it

                Console.WriteLine();
            }
        }

        private static IEnumerable<(string id, Benchmark baseResult, Benchmark diffResult, EquivalenceTestConclusion conclusion, HostEnvironmentInfo baseEnv, HostEnvironmentInfo diffEnv)> GetResults(
            string basePath, string diffPath, Threshold testThreshold, Threshold noiseThreshold, IEnumerable<Regex> filters)
        {
            foreach (var info in ReadResults(basePath, diffPath, filters)
                .Where(result => result.baseResult.Statistics != null && result.diffResult.Statistics != null)) // failures
            {
                if (info.baseEnv.Architecture != info.diffEnv.Architecture)
                    throw new InvalidOperationException("Use ResultsComparer to compare different Architectures");
                if (info.baseEnv.OsVersion != info.diffEnv.OsVersion)
                    throw new InvalidOperationException("Use ResultsComparer to compare different OS Versions");
                if (info.baseEnv.ProcessorName != info.diffEnv.ProcessorName)
                    throw new InvalidOperationException("Use ResultsComparer to compare different Processors");

                var baseValues = info.baseResult.GetOriginalValues();
                var diffValues = info.diffResult.GetOriginalValues();

                var userTresholdResult = StatisticalTestHelper.CalculateTost(MannWhitneyTest.Instance, baseValues, diffValues, testThreshold);
                var noiseResult = StatisticalTestHelper.CalculateTost(MannWhitneyTest.Instance, baseValues, diffValues, noiseThreshold);

                if (noiseResult.Conclusion == EquivalenceTestConclusion.Same) // filter noise (0.20 ns vs 0.25ns etc)
                    yield return (info.id, info.baseResult, info.diffResult, noiseResult.Conclusion, info.baseEnv, info.diffEnv);
                else
                    yield return (info.id, info.baseResult, info.diffResult, userTresholdResult.Conclusion, info.baseEnv, info.diffEnv);
            }
        }

        private static IEnumerable<(string id, Benchmark baseResult, Benchmark diffResult, HostEnvironmentInfo baseEnv, HostEnvironmentInfo diffEnv)> ReadResults(
            string basePath, string diffPath, IEnumerable<Regex> filters)
        {
            var baseFiles = GetFilesToParse(basePath);
            var diffFiles = GetFilesToParse(diffPath);

            if (!baseFiles.Any() || !diffFiles.Any())
                throw new ArgumentException($"Provided paths contained no {FullBdnJsonFileExtension} files.");

            var baseResults = baseFiles.Select(ReadFromFile);
            var diffResults = diffFiles.Select(ReadFromFile);

            var benchmarkIdToDiffResults = new Dictionary<string, (Benchmark result, HostEnvironmentInfo env)>(StringComparer.InvariantCulture);

            foreach (var diffResult in diffResults)
            {
                foreach (var diffBenchmark in diffResult.Benchmarks.Where(benchmarkResult => !filters.Any() || filters.Any(filter => filter.IsMatch(benchmarkResult.FullName))))
                {
                    benchmarkIdToDiffResults.Add(diffBenchmark.FullName, (diffBenchmark, diffResult.HostEnvironmentInfo));
                }
            }

            foreach (var baseResult in baseResults)
            {
                foreach (var baseBenchmark in baseResult.Benchmarks.Where(result => benchmarkIdToDiffResults.ContainsKey(result.FullName)))
                {
                    (Benchmark diffBenchmark, HostEnvironmentInfo diffEnv) = benchmarkIdToDiffResults[baseBenchmark.FullName];

                    yield return (baseBenchmark.FullName, baseBenchmark, diffBenchmark, baseResult.HostEnvironmentInfo, diffEnv);
                }
            }
        }

        private static BdnResult ReadFromFile(string resultFilePath)
        {
            try
            {
                return JsonConvert.DeserializeObject<BdnResult>(File.ReadAllText(resultFilePath));
            }
            catch (JsonSerializationException)
            {
                Console.WriteLine($"Exception while reading the {resultFilePath} file.");

                throw;
            }
        }

        private static string[] GetFilesToParse(string path)
        {
            if (Directory.Exists(path))
                return Directory.GetFiles(path, $"*{FullBdnJsonFileExtension}", SearchOption.AllDirectories);
            else if (File.Exists(path) || !path.EndsWith(FullBdnJsonFileExtension))
                return new[] { path };
            else
                throw new FileNotFoundException($"Provided path does NOT exist or is not a {path} file", path);
        }

        private static double Score(EquivalenceTestConclusion conclusion, HostEnvironmentInfo env, Benchmark baseResult, Benchmark diffResult)
        {
            switch (conclusion)
            {
                case EquivalenceTestConclusion.Base:
                case EquivalenceTestConclusion.Same:
                    return 0;
                case EquivalenceTestConclusion.Faster:
                    double improvementXtimes = baseResult.Statistics.Median / diffResult.Statistics.Median;
                    return (double.IsNaN(improvementXtimes) || double.IsInfinity(improvementXtimes))
                        ? Importance(env) * 10.0
                        : Importance(env) * Math.Min(improvementXtimes, 10.0);
                case EquivalenceTestConclusion.Slower:
                    double regressionXtimes = diffResult.Statistics.Median / baseResult.Statistics.Median;
                    return (double.IsNaN(regressionXtimes) || double.IsInfinity(regressionXtimes))
                        ? Importance(env) * -10.0
                        : Importance(env) * Math.Min(regressionXtimes, 10.0) * -1.0;
                default:
                    throw new NotSupportedException($"{conclusion} is not supported");
            }
        }

        private static int Importance(HostEnvironmentInfo env)
        {
            // it's not any kind of official Microsoft priority, just the way I see them:
            // 1. x64 Windows
            // 2. x64 Linux
            // 3. arm64 Linux
            // 4. arm64 Windows
            // 5. x86 Windows
            // 6. arm Windows
            // 7. x64 macOS

            if (env.Architecture == "X64" && env.OsVersion.StartsWith("Windows", StringComparison.OrdinalIgnoreCase))
            {
                return 1;
            }
            else if (env.Architecture == "X64" && !env.OsVersion.StartsWith("macOS", StringComparison.OrdinalIgnoreCase))
            {
                return 2;
            }
            else if (env.Architecture == "Arm64" && !env.OsVersion.StartsWith("Windows", StringComparison.OrdinalIgnoreCase))
            {
                return 3;
            }
            else if (env.Architecture == "Arm64")
            {
                return 4;
            }
            else if (env.Architecture == "X86")
            {
                return 5;
            }
            else if (env.Architecture == "Arm")
            {
                return 6;
            }
            else
            {
                return 7;
            }
        }

        private static string Simplify(string text) => text.Split('(')[0];

        private static string GetSimplifiedRuntimeVersion(string text)
        {
            if (text.StartsWith(".NET Core 3", StringComparison.OrdinalIgnoreCase))
            {
                // it's something like ".NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603)"
                // and what we care about is "3.1.6"
                return text.Substring(".NET Core ".Length, "3.1.X".Length);
            }
            else
            {
                // it's something like ".NET 6.0.0 (6.0.21.35216)"
                // and what we care about is "6.0.21.35216"
                int index = text.IndexOf('(');
                return text.Substring(index + 1, text.Length - index - 2);
            }
        }

        // code and magic values taken from BenchmarkDotNet.Analysers.MultimodalDistributionAnalyzer
        // See http://www.brendangregg.com/FrequencyTrails/modes.html
        private static string GetModalInfo(Benchmark benchmark)
        {
            if (benchmark.Statistics.N < 12) // not enough data to tell
                return null;

            double mValue = MathHelper.CalculateMValue(new BenchmarkDotNet.Mathematics.Statistics(benchmark.GetOriginalValues()));
            if (mValue > 4.2)
                return "multimodal";
            else if (mValue > 3.2)
                return "bimodal";
            else if (mValue > 2.8)
                return "several?";

            return null;
        }

        // https://stackoverflow.com/a/6907849/5852046 not perfect but should work for all we need
        private static string WildcardToRegex(string pattern) => $"^{Regex.Escape(pattern).Replace(@"\*", ".*").Replace(@"\?", ".")}$";
    }
}