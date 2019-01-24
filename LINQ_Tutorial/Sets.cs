using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Sets
    {
        // Distinct
        // Returns distinct values from a collection
        public static void LinqDistinct(List<User> users)
        {
            var distinct = users.Select(u => u.UserRole).Distinct();
            foreach (var d in distinct)
            {
                Console.WriteLine(d);
            }
        }

        // Except
        // Returns a new collection with elements from the first collection which do not exist in the second collection
        public static void LinqExcept(List<int> integers, List<int> integers2)
        {
            Console.WriteLine("Különbség lista");
            var except = integers.Except(integers2);
            foreach (var e in except)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }

        // Intersect
        // Returns a new collection that includes common elements that exists in both collections
        public static void LinqIntersect(List<int> integers, List<int> integers2)
        {
            // Return a list with only the numbers that are present in both lists
            // Even if a value is present multiple times in both collections, there's only one instance of it in the intersected collection
            Console.WriteLine("Metszet lista");
            var intersect = integers.Intersect(integers2);
            foreach (var i in intersect)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Union
        // Requires two collections and returns a new collection that includes distinct elements from both the collections
        public static void LinqUnion(List<int> integers, List<int> integers2)
        {
            // Returns the combined, distinct values of the two integer lists
            Console.WriteLine("Unió lista");
            var union = integers.Union(integers2);
            foreach (var i in union)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
