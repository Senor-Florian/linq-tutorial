using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Partitioning
    {
        // Skip
        // Skips elements up to a specified position starting from the first element in a sequence
        public static void LinqSkip(List<int> integers)
        {
            // Removes the first 5 elements of the list
            var nonSkippedNumbers = integers.Skip(5);
            foreach (var i in nonSkippedNumbers)
            {
                Console.WriteLine(i);
            }
        }

        // SkipWhile
        // Skips elements based on a condition until an element does not satisfy the condition 
        // If the first element itself doesn't satisfy the condition, it then skips 0 elements and returns all the elements in the sequence
        public static void LinqSkipWhile(List<User> users)
        {
            // Skips users until it finds one with the user role of a Monitor
            var nonSkippedUsers = users.SkipWhile(u => u.UserRole != UserRole.MONITOR);
            foreach (var u in nonSkippedUsers)
            {
                Console.WriteLine(u);
            }
        }

        // Take
        // Takes elements up to a specified position starting from the first element in a sequence
        public static void LinqTake(List<User> users)
        {
            // Returns the first 5 elements of the list
            var takenUsers = users.Take(5);
            foreach (var u in users)
            {
                Console.WriteLine(u);
            }
        }

        // TakeWhile
        // Returns elements from the first element until an element does not satisfy the condition
        // If the first element itself doesn't satisfy the condition then returns an empty collection. 
        public static void LinqTakeWhile(List<User> users)
        {
            // Takes users until it finds one with the user role of a Monitor
            var takenUsers = users.TakeWhile(u => u.UserRole != UserRole.MONITOR);
            foreach (var u in takenUsers)
            {
                Console.WriteLine(u);
            }
        }
    }
}
