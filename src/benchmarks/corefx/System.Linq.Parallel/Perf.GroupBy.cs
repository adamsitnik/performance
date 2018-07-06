// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace System.Linq.Parallel.Tests
{
    public class GroupByPerfTestsUnordered : GroupByPerfTests
    {
    }

    public class GroupByPerfTestsOrdered : GroupByPerfTests
    {
        protected override ParallelQuery<int> CreateQueryBase(int count) => base.CreateQueryBase(count).AsOrdered();
    }

    public abstract class GroupByPerfTests
    {
        const int TotalElementCount = 50_000;
        const int CrossProductInnerIterationCount = 100;
        const int EnumerateGroupInnerIterationCount = 1_000;

        protected virtual ParallelQuery<int> CreateQueryBase(int count) => UnorderedSources.Default(count);

        private ParallelQuery<KeyValuePair<int, int>> CreateQuery(int groupCount, int elementsPerGroup)
        {
            return CreateQuery(groupCount, elementsPerGroup, (key, vals) => KeyValuePair.Create(key, vals.Sum()));
        }

        private ParallelQuery<KeyValuePair<int, int>> CreateQuery(int groupCount, int elementsPerGroup, Func<int, IEnumerable<int>, KeyValuePair<int, int>> resultSelector)
        {
            return CreateQueryBase(groupCount * elementsPerGroup).GroupBy(x => x % groupCount, resultSelector);
        }

        [Benchmark]
        public void QueryCreation() => QueryCreation(10, 1_000_000);

        [GlobalSetup(Target = nameof(CrossProduct____10))]
        public void SetupCrossProduct____10() => SetupCrossProductQuery(10);

        [Benchmark]
        public void CrossProduct____10() => CrossProduct(CrossProductInnerIterationCount);

        [GlobalSetup(Target = nameof(CrossProduct____25))]
        public void SetupCrossProduct____25() => SetupCrossProductQuery(25);

        [Benchmark]
        public void CrossProduct____25() => CrossProduct(CrossProductInnerIterationCount);

        [GlobalSetup(Target = nameof(CrossProduct____50))]
        public void SetupCrossProduct____50() => SetupCrossProductQuery(50);

        [Benchmark]
        public void CrossProduct____50() => CrossProduct(CrossProductInnerIterationCount);

        [GlobalSetup(Target = nameof(CrossProduct___100))]
        public void SetupCrossProduct____100() => SetupCrossProductQuery(100);

        [Benchmark]
        public void CrossProduct___100() => CrossProduct(CrossProductInnerIterationCount);

        [GlobalSetup(Target = nameof(CrossProduct___500))]
        public void SetupCrossProduct____500() => SetupCrossProductQuery(500);

        [Benchmark]
        public void CrossProduct___500() => CrossProduct(CrossProductInnerIterationCount);
            
        [GlobalSetup(Target = nameof(EnumerateGroup__10))]
        public void SetupEnumerateGroup__10() => SetupEnumerateGroupQuery(10, EnumerateGroupInnerIterationCount);

        [Benchmark]
        public void EnumerateGroup__10() => EnumerateGroup();

        [GlobalSetup(Target = nameof(EnumerateGroup__25))]
        public void SetupEnumerateGroup__25() => SetupEnumerateGroupQuery(25, EnumerateGroupInnerIterationCount);

        [Benchmark]
        public void EnumerateGroup__25() => EnumerateGroup();
        
        [GlobalSetup(Target = nameof(EnumerateGroup__50))]
        public void SetupEnumerateGroup__50() => SetupEnumerateGroupQuery(50, EnumerateGroupInnerIterationCount);

        [Benchmark]
        public void EnumerateGroup__50() => EnumerateGroup();

        [GlobalSetup(Target = nameof(EnumerateGroup_100))]
        public void SetupEnumerateGroup_100() => SetupEnumerateGroupQuery(100, EnumerateGroupInnerIterationCount);
        
        [Benchmark]
        public void EnumerateGroup_100() => EnumerateGroup();

        [GlobalSetup(Target = nameof(EnumerateGroup_500))]
        public void SetupEnumerateGroup_500() => SetupEnumerateGroupQuery(500, EnumerateGroupInnerIterationCount);
        
        [Benchmark]
        public void EnumerateGroup_500() => EnumerateGroup();

        private static volatile ParallelQuery<KeyValuePair<int, int>> _queryCreationResult;

        private void QueryCreation(int elementsPerGroup, long innerIterationCount)
        {
            for (int i = 0; i < innerIterationCount; i++)
            {
                _queryCreationResult = CreateQuery(TotalElementCount / elementsPerGroup, elementsPerGroup);
            }
        }

        private ParallelQuery<KeyValuePair<int, int>> _valuesCross;

        private void SetupCrossProductQuery(int elementsPerGroup) => _valuesCross = CreateQuery(TotalElementCount / elementsPerGroup, elementsPerGroup);
        
        private static volatile int _crossProductResult;

        private void CrossProduct(long innerIterationCount)
        {
            ParallelQuery<KeyValuePair<int, int>> values = _valuesCross;

            for (int i = 0; i < innerIterationCount; i++)
            {
                _crossProductResult = 0;
                foreach (KeyValuePair<int, int> pair in values)
                {
                    _crossProductResult += pair.Key * pair.Value;
                }
            }
        }

        private ParallelQuery<KeyValuePair<int, int>> _valuesGroup;

        private void SetupEnumerateGroupQuery(int elementsPerGroup, long innerIterationCount)
        {
            int iters = (int)innerIterationCount;
            
            _valuesGroup = CreateQuery(TotalElementCount / elementsPerGroup, elementsPerGroup,
                (key, vals) =>
                {
                    int value = 0;

                    for (int i = 0; i < iters; i++)
                    {
                        value += vals.Sum();
                    }

                    return KeyValuePair.Create(key, value / iters);
                });
        }

        private static volatile int _enumerateGroupResult;

        private void EnumerateGroup()
        {
            ParallelQuery<KeyValuePair<int, int>> values = _valuesGroup;

            _enumerateGroupResult = 0;
            foreach (KeyValuePair<int, int> pair in values)
            {
                _enumerateGroupResult += pair.Key * pair.Value;
            }
        }
    }
}
