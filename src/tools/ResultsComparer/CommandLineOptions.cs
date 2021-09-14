// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CommandLine;

namespace ResultsComparer
{
    public class CommandLineOptions
    {
        [Option("1st", HelpText = "Path to the folder with 1st parition results.")]
        public string FirstPartition { get; set; }

        [Option("2nd", HelpText = "Path to the folder with 2nd parition results.")]
        public string SecondPartition { get; set; }

        [Option("out", HelpText = "Path to the folder where merged results should be stored.")]
        public string Output { get; set; }
    }
}