using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Sorting
    {
        // OrderBy/OrderByDescending/ThenBy/ThenByDescending
        // Arranges the elements of the collection in ascending or descending order
        public static void LinqOrderBy(List<User> users)
        {
            // Orders the users first by their role, then by their fullname
            var sortedUsers = users.OrderBy(u => u.UserRole.ToString())
                                   .ThenBy(u => u.FullName);
            sortedUsers.Reverse();

            foreach (var u in sortedUsers)
            {
                Console.WriteLine(u);
            }
        }

        // Reverse
        // Reverses the order of the elements in a collection
        public static void LinqReverse(List<int> integers)
        {
            var reversedIntegers = integers.AsEnumerable().Reverse();

            foreach (var u in reversedIntegers)
            {
                Console.Write(u + " ");
            }

            Console.WriteLine();
        }
    }
}
