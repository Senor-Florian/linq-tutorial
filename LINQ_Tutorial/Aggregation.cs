using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Aggregation
    {
        // Aggregate
        // Performs a custom aggregation operation on the values in the collection
        public static void LinqAggregate(List<int> integers)
        {
            // Calculates the sum of integers
            var sum = integers.Aggregate((a, b) => a + b);
            Console.WriteLine(sum);
        }

        // Average
        // Calculates the average of the numeric items in the collection
        public static void LinqAverage(List<int> integers)
        {
            // Returns the average of the integers
            var average = integers.Average();
            Console.WriteLine(average);
        }

        // Count / LongCount
        // Returns the number (int / long) of elements in the collection or number of elements that have satisfied the given condition
        public static void LinqCount(List<string> names)
        {
            // Returns the number of the names from list that are longer than 15 characters
            var nameCount = names.Count(n => n.Count() > 15);
            Console.WriteLine(nameCount);
        }

        // Max
        // Returns the largest numeric element from a collection
        public static void LinqMax(List<User> users)
        {
            // Returns date of birth of the youngest user from the list (largest datetime value)
            var youngestUserDob = users.Max(i => i.DateOfBirth);
            Console.WriteLine(youngestUserDob);
        }

        // Min
        // Returns the smalles numeric element from a collection
        public static void LinqMin(List<int> integers)
        {
            // Returns the smallest positive number from the list
            var smallestNumber = integers.Min();
            Console.WriteLine(smallestNumber);
        }

        // Sum
        // Calculates the sum of numeric items in the collection
        public static void LinqSum(List<int> integers)
        {
            // Sums the value of the integers
            var sum = integers.Sum();
            Console.WriteLine(sum);
        }
    }
}
