// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Linq.Parallel.Tests
{
    public static class UnorderedSources
    {
        /// <summary>
        /// Returns a default ParallelQuery source.
        /// </summary>
        /// For most instances when dealing with unordered input, the individual source does not matter.
        ///
        /// Instead, that is reserved for ordered, where partitioning and dealing with indices has important
        /// secondary effects.  The goal of unordered input, then, is mostly to make sure the query works.
        /// <param name="count">The count of elements.</param>
        /// <returns>A ParallelQuery with elements running from 0 to count - 1</returns>
        public static ParallelQuery<int> Default(int count)
        {
            return Default(0, count);
        }

        /// <summary>
        /// Returns a default ParallelQuery source.
        /// </summary>
        /// For most instances when dealing with unordered input, the individual source does not matter.
        ///
        /// Instead, that is reserved for ordered, where partitioning and dealing with indices has important
        /// secondary effects.  The goal of unordered input, then, is mostly to make sure the query works.
        /// <param name="start">The starting element.</param>
        /// <param name="count">The count of elements.</param>
        /// <returns>A ParallelQuery with elements running from 0 to count - 1</returns>
        private static ParallelQuery<int> Default(int start, int count)
        {
            // Of the underlying types used elsewhere, some have "problems",
            // in the sense that they may be too-easily indexible.
            // For instance, Array and List are both trivially range partitionable and indexible.
            // A parallelized Enumerable.Range is being used (not easily partitionable or indexible),
            // but at the moment ParallelEnumerable.Range is being used for speed and ease of use.
            // ParallelEnumerable.Range is not trivially indexible, but is easily range partitioned.
            return ParallelEnumerable.Range(start, count);
        }
    }
}
