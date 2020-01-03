using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberGenerator
{
    public class NumberCombination : IEqualityComparer<NumberCombination>
    {
        public IList<int> Numbers { get; set; }

        public NumberCombination(IEnumerable<int> numbers)
        {
            Numbers = numbers.ToList();
        }

        public bool HasUniqueNumbers()
        {
            return Numbers.Distinct().Count() == Numbers.Count;
        }

        public bool CombinationIsEqual(NumberCombination other)
        {
            return other != null && other.Numbers.SequenceEqual(Numbers);
        }

        public bool Equals(NumberCombination x, NumberCombination y)
        {
            return x.Numbers.SequenceEqual(y.Numbers);
        }

        public int GetHashCode(NumberCombination obj) => (Numbers).GetHashCode(); 
    }
}
