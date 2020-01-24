using LINQ_Tutorial.MockData;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Partitioning
    {
        // Skip
        // Skips elements up to a specified position starting from the first element in a sequence
        public static void LinqSkip(IEnumerable<int> integers)
        {
            // Visszad egy olyan collection-t, amely nem tartalmazza az eredeti collection első x elemét
            var nonSkippedNumbers = integers.Skip(5);
        }

        // SkipWhile
        // Skips elements based on a condition until an element does not satisfy the condition 
        // If the first element itself doesn't satisfy the condition, it then skips 0 elements and returns all the elements in the sequence
        public static void LinqSkipWhile(IEnumerable<User> users)
        {
            // Kihagyja az új collection-ből az eredeti elemeit, amíg a megadott feltétel teljesül
            var nonSkippedUsers = users.SkipWhile(u => u.UserRole != UserRole.MONITOR);
        }

        // Take
        // Takes elements up to a specified position starting from the first element in a sequence
        public static void LinqTake(IEnumerable<User> users)
        {
            // Visszad egy olyan collection-t, amely tartalmazza az eredeti collection első x elemét
            var takenUsers = users.Take(5);
        }

        // TakeWhile
        // Returns elements from the first element until an element does not satisfy the condition
        // If the first element itself doesn't satisfy the condition then returns an empty collection. 
        public static void LinqTakeWhile(IEnumerable<User> users)
        {
            // Tartalmazza az új collection az eredeti elemeit, amíg a megadott feltétel teljesül
            var takenUsers = users.TakeWhile(u => u.UserRole != UserRole.MONITOR);
        }
    }
}
