// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Diagnostics;

namespace MicroBenchmarks
{
    [BenchmarkCategory(Categories.Libraries)]
    public class CachingMemory
    {
        [GlobalSetup]
        public void PrintVersionAndPath()
        {
            Console.WriteLine("---------------");
            Console.WriteLine(typeof(MemoryCache).Assembly.Location);
            Console.WriteLine(FileVersionInfo.GetVersionInfo(typeof(MemoryCache).Assembly.Location));
            Console.WriteLine("---------------");

        }

        [Benchmark]
        public MemoryCache Some()
        {
            var cache = new MemoryCache(new MemoryCacheOptions());

            cache.CreateEntry("key").SetValue("value");

            cache.Dispose();

            return cache;
        }
    }
}