using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGenerator
{
    public class NumberCombinationFactory
    {
        private readonly Random Random = new Random();

        public IList<NumberCombination> GenerateNumberCombination(int min, int max, int combinationLength = 4, int count = 1, bool uniqueNumbers = true, bool uniqueCombinations = true)
        {
            var combinations = new List<NumberCombination>();
            while (combinations.Count < count)
            {
                var randomNumbers = GenerateRandomNumbers(min, max, combinationLength);
                var combination = new NumberCombination(randomNumbers);

                while ((uniqueNumbers && !combination.HasUniqueNumbers()) || (uniqueCombinations && combinations.Any(c => c.CombinationIsEqual(combination))))
                {
                    combination = new NumberCombination(GenerateRandomNumbers(min, max, combinationLength));
                }
                combinations.Add(combination);
            }
            return combinations;
        }

        private List<int> GenerateRandomNumbers(int min, int max, int combinationLength)
        {
            var randomNumbers = new List<int>();
            for (var i = 0; i < combinationLength; i++)
            {
                randomNumbers.Add(Random.Next(min, max));
            }
            return randomNumbers;
        }
    }
}
