// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using CommandLine;
using DataTransferContracts;
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

            Parser.Default.ParseArguments<CommandLineOptions>(args).WithParsed(Merge);
        }

        private static void Merge(CommandLineOptions args)
        {
            if (Directory.Exists(args.Output))
            {
                Directory.Delete(args.Output, recursive: true);
            }

            Directory.CreateDirectory(args.Output);

            var firstPartitionFiles = GetFilesToParse(args.FirstPartition).ToDictionary(path => Path.GetFileName(path), path => path);
            var secondPartitionFiles = GetFilesToParse(args.SecondPartition).ToDictionary(path => Path.GetFileName(path), path => path);

            CopyNotMatching(args, firstPartitionFiles, secondPartitionFiles);
            CopyNotMatching(args, secondPartitionFiles, firstPartitionFiles);

            foreach (var pair in secondPartitionFiles)
            {
                if (firstPartitionFiles.TryGetValue(pair.Key, out string path))
                {
                    BdnResult merged = Merge(ReadFromFile(pair.Value), ReadFromFile(path));

                    File.WriteAllText(Path.Combine(args.Output, pair.Key), JsonConvert.SerializeObject(merged));
                }
            }
        }

        private static BdnResult Merge(BdnResult left, BdnResult right)
        {
            BdnResult merged = new BdnResult
            {
                Title = left.Title,
                HostEnvironmentInfo = left.HostEnvironmentInfo,
                Benchmarks = new List<Benchmark>()
            };

            foreach (var benchmark in left.Benchmarks.Concat(right.Benchmarks))
            {
                if (!merged.Benchmarks.Contains(benchmark, Comparer.Instance))
                {
                    merged.Benchmarks.Add(benchmark);
                }
            }

            return merged;
        }

        private static void CopyNotMatching(CommandLineOptions args, Dictionary<string, string> firstPartitionFiles, Dictionary<string, string> secondPartitionFiles)
        {
            foreach (var pair in secondPartitionFiles)
            {
                if (!firstPartitionFiles.TryGetValue(pair.Key, out string path))
                {
                    File.Copy(pair.Value, Path.Combine(args.Output, pair.Key));
                }
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

        private class Comparer : IEqualityComparer<Benchmark>
        {
            internal static Comparer Instance = new Comparer();

            public bool Equals(Benchmark x, Benchmark y) => x.FullName == y.FullName;

            public int GetHashCode([DisallowNull] Benchmark obj) => obj.FullName.GetHashCode();
        }
    }
}
