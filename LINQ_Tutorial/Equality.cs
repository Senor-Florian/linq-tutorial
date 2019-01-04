using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Equality
    {
        // SequenceEqual
        // Checks whether the number of elements, value of each element and order of elements in two collections are equal or not
        public static void LinqSequenceEqual(List<int> integers, List<int> integers2)
        {
            // Returns true because the two lists have the same elements in the same order
            var isEqual = integers.SequenceEqual(integers2);

            Console.WriteLine("SequenceEqual:");
            Console.WriteLine(isEqual);
        }
    }
}
