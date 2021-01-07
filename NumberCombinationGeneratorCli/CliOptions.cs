using CommandLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberCombinationGeneratorCli
{
    public class CliOptions
    {
        [Option('s', "size", Required = false, Default = 4, HelpText = "size of the combinations.")]
        public int Size { get; set; }
        [Option("min", Required = false, Default = 0, HelpText = "minimum value of numbers inside the combination.")]
        public int Min { get; set; }
        [Option("max", Required = false, Default = 20, HelpText = "minimum value of numbers inside the combination.")]
        public int Max { get; set; }
        [Option('c', "count", Required = false, Default = 10, HelpText = "number of combinations to generate.")]
        public int Count { get; set; }
        [Option("dc", Required = false, Default = false, HelpText = "allow dupliicate combinations.")]
        public bool AllowDuplicateCombinations { get; set; }
        [Option("dn", Required = false, Default = false, HelpText = "allow duplicate numbers inside combinations.")]
        public bool AllowDuplicateNumbers { get; set; }
    }
}
