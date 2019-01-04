using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Quantifiers
    {
        // All
        // Returns with a bool, checks if all the elements in a sequence satisfies the specified condition 
        public static void LinqAll(List<int> integers)
        {
            // Checks if all integers are positive in the list
            var allPositives = integers.All(i => i > 0);

            Console.WriteLine("All:");
            Console.WriteLine(allPositives);
        }

        // Any
        // Returns with a bool, checks if any of the elements in a sequence satisfies the specified condition 
        public static void LinqAny(List<int> integers)
        {
            // Checks if there are any negative integers in the list
            var isAnyNegative = integers.All(i => i < 0);
            Console.WriteLine("Any:");
            Console.WriteLine(isAnyNegative);
        }

        // Contains
        // Checks whether a specified element exists in the collection or not and returns a boolean
        public static void LinqContains(List<string> names)
        {
            var containsName = names.Contains("Alizaunder Bonauiti");
            Console.WriteLine("Contains:");
            Console.WriteLine(containsName);
        }
    }
}
