using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Sets
    {
        // TODO: query implementation

        // Distinct
        // Returns distinct values from a collection
        public static void LinqDistinct(List<int> integers)
        {
            var distinct = integers.Distinct();
            Console.WriteLine("Distinct:");
            foreach (var i in distinct)
            {
                Console.WriteLine(i);
            }
        }

        // Except
        // Returns a new collection with elements from the first collection which do not exist in the second collection
        public static void LinqExcept(List<int> integers, List<int> integers2)
        {
            var except = integers.Except(integers2);
            Console.WriteLine("Except:");
            foreach (var i in except)
            {
                Console.WriteLine(i);
            }
        }

        // Intersect
        // Returns a new collection that includes common elements that exists in both collections
        public static void LinqIntersect(List<int> integers, List<int> integers2)
        {
            // Return a list with only the numbers that are present in both lists
            // Even if a value is present multiple times in both collections, there's only one instance of it in the intersected collection
            var intersect = integers.Intersect(integers2);
            Console.WriteLine("Intersect:");
            foreach (var i in intersect)
            {
                Console.WriteLine(i);
            }
        }

        // Union
        // Requires two collections and returns a new collection that includes distinct elements from both the collections
        public static void LinqUnion(List<int> integers, List<int> integers2)
        {
            // Returns the combined_ distinct values of the two integer lists
            var union = integers.Union(integers2);
            Console.WriteLine("Union");
            foreach (var i in union)
            {
                Console.WriteLine(i);
            }
        }
    }
}
