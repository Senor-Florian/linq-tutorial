using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Elements
    {
        // ElementAt/ElementAtOrDefault
        // Returns the element at a specified index in a collection (or a default value if the index is out of range)
        public static void LinqElementAt(List<int> integers)
        {
            //If the index is out of the range then it will throw an Index out of range exception
            var firstElement = integers.ElementAt(0);
            // Returns the default value if the index is out of the range
            var hundredthElement = integers.ElementAtOrDefault(100);

            Console.WriteLine("ElementAt:");
            Console.WriteLine(firstElement);
            Console.WriteLine(hundredthElement);
        }

        // First/FirstOrDefault
        // Returns the first element of a collection, or the first element that satisfies a condition (or a default value if no such element exists.)
        public static void LinqFirst(List<int> integers)
        {
            // Returns the first negative number in the list
            var firstNegativeNumber = integers.First(i => i < 0);
            // Returns the first number over 100, doesn't throw an error if none is found
            var firstNumberOverOneHundred = integers.FirstOrDefault(i => i > 100);

            Console.WriteLine("First:");
            Console.WriteLine(firstNegativeNumber);
            Console.WriteLine(firstNumberOverOneHundred);
        }

        // Last/LastOrDefault
        // Returns the last element of a collection, or the last element that satisfies a condition (or a default value if no such element exists)
        public static void LinqLast(List<int> integers)
        {
            // Returns the last negative number in the list
            var lastNegativeNumber = integers.Last(i => i < 0);
            // Returns the last number over 100, doesn't throw an error if none is found
            var lastNumberOverOneHundred = integers.LastOrDefault(i => i > 100);

            Console.WriteLine("Last:");
            Console.WriteLine(lastNegativeNumber);
            Console.WriteLine(lastNumberOverOneHundred);
        }

        // Single/SingleOrDefault
        // Returns the only element from a collection, or the only element that satisfies a condition (or a default value if no such element exists) 
        public static void LinqSingle(List<User> users, Guid id, List<int> integers)
        {
            // Finds a user by its ID
            var user = users.Single(u => u.ID == id);
            // Returns the default value of int if the condition is not met, returns the desired number if only one element satisfies the condition,
            // and throws an error if multiple elements satisfy the condition
            var integerOverOneHundred = integers.SingleOrDefault(i => i > 100);

            Console.WriteLine("Single:");
            Console.WriteLine(user.ToString());
            Console.WriteLine(integerOverOneHundred);
        }
    }
}
