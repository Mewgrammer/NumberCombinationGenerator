using CommandLine;
using NumberGenerator;
using System;
using System.Linq;

namespace NumberCombinationGeneratorCli
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var factory = new NumberCombinationFactory();
            var size = 0;
            var count = 0;
            var min = 0;
            var max = 0;
            var uniqueNumbers = true;
            var uniqueCombinations = true;
            Parser.Default.ParseArguments<CliOptions>(args)
               .WithParsed(o =>
               {
                   size = o.Size;
                   count = o.Count;
                   min = o.Min;
                   max = o.Max;
                   uniqueCombinations = !o.AllowDuplicateCombinations;
                   uniqueNumbers = !o.AllowDuplicateNumbers;
               });
            var combinations = factory.GenerateNumberCombination(min, max, size, count, uniqueNumbers, uniqueCombinations);
            foreach(var comb in combinations)
            {
                var str = "";
                for (var j = 0; j < comb.Numbers.Count; j++)
                {
                    str += comb.Numbers.ElementAt(j);
                    if (comb.Numbers.Count > j + 1)
                    {
                        str += ",";
                    }
                }
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
