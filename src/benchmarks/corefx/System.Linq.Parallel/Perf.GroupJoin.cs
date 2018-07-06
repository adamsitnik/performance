// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;

namespace System.Linq.Parallel.Tests
{
    public class GroupJoinPerfTestsUnorderedLeftUnorderedRight : GroupJoinPerfTests
    {
    }

    public class GroupJoinPerfTestsUnorderedLeftOrderedRight : GroupJoinPerfTests
    {
        protected override ParallelQuery<int> CreateRight(int count) => base.CreateRight(count).AsOrdered();

        [GlobalSetup(Target = nameof(CrossProduct__1000))]
        public void SetupCrossProduct__1000() => SetupCrossProductQuery(1000);

        [Benchmark]
        public void CrossProduct__1000() => CrossProduct(CrossProductInnerIterationCount);

        [GlobalSetup(Target = nameof(CrossProduct__2000))]
        public void SetupCrossProduct__2000() => SetupCrossProductQuery(2000);

        [Benchmark]
        public void CrossProduct__2000() => CrossProduct(CrossProductInnerIterationCount);

        [GlobalSetup(Target = nameof(CrossProduct_10000))]
        public void SetupCrossProduct_10000() => SetupCrossProductQuery(10000);

        [Benchmark]
        public void CrossProduct_10000() => CrossProduct(CrossProductInnerIterationCount);
    }

    public class GroupJoinPerfTestsOrderedLeftUnorderedRight : GroupJoinPerfTests
    {
        protected override ParallelQuery<int> CreateLeft(int count) => base.CreateLeft(count).AsOrdered();
    }

    public class GroupJoinPerfTestsOrderedLeftOrderedRight : GroupJoinPerfTests
    {
        protected override ParallelQuery<int> CreateLeft(int count) => base.CreateLeft(count).AsOrdered();
        protected override ParallelQuery<int> CreateRight(int count) => base.CreateRight(count).AsOrdered();

        [GlobalSetup(Target = nameof(CrossProduct__1000))]
        public void SetupCrossProduct__1000() => SetupCrossProductQuery(1000);

        [Benchmark]
        public void CrossProduct__1000() => CrossProduct(CrossProductInnerIterationCount);

        [GlobalSetup(Target = nameof(CrossProduct__2000))]
        public void SetupCrossProduct__2000() => SetupCrossProductQuery(2000);

        [Benchmark]
        public void CrossProduct__2000() => CrossProduct(CrossProductInnerIterationCount);

        [GlobalSetup(Target = nameof(CrossProduct_10000))]
        public void SetupCrossProduct_10000() => SetupCrossProductQuery(10000);

        [Benchmark]
        public void CrossProduct_10000() => CrossProduct(CrossProductInnerIterationCount);
    }

    public abstract class GroupJoinPerfTests
    {
        const int TotalElementCount = 50_000;
        protected const int CrossProductInnerIterationCount = 100;

        protected virtual ParallelQuery<int> CreateLeft(int count) => UnorderedSources.Default(count);
        protected virtual ParallelQuery<int> CreateRight(int count) => UnorderedSources.Default(count);

        private ParallelQuery<KeyValuePair<int, int>> _values;
        
        protected void SetupCrossProductQuery(int rightsPerLeft) => _values = CreateQuery(TotalElementCount / rightsPerLeft, rightsPerLeft);

        private ParallelQuery<KeyValuePair<int, int>> CreateQuery(int leftCount, int rightsPerLeft)
        {
            return CreateLeft(leftCount).GroupJoin(CreateRight(leftCount * rightsPerLeft),
                x => x, y => y % leftCount, (x, y) => KeyValuePair.Create(x, y.Sum()));
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

        private void QueryCreation(int rightsPerLeft, long innerIterationCount)
        {
            Debug.Assert(TotalElementCount % rightsPerLeft == 0);
            QueryCreation(TotalElementCount / rightsPerLeft, rightsPerLeft, innerIterationCount);
        }

        private static volatile ParallelQuery<KeyValuePair<int, int>> _queryCreationResult;

        private void QueryCreation(int leftCount, int rightsPerLeft, long innerIterationCount)
        {
            for (int i = 0; i < innerIterationCount; i++)
            {
                _queryCreationResult = CreateQuery(leftCount, rightsPerLeft);
            }
        }

        private static volatile int _crossProductResult;

        protected void CrossProduct(long innerIterationCount)
        {
            ParallelQuery<KeyValuePair<int, int>> values = _values;

            for (int i = 0; i < innerIterationCount; i++)
            {
                _crossProductResult = 0;
                foreach (KeyValuePair<int, int> pair in values)
                {
                    _crossProductResult += pair.Key * pair.Value;
                }
            }
        }
    }
}
