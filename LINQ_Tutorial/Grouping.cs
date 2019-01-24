using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Grouping
    {
        // GroupBy
        // Groups elements of a sequence that share a common attribute
        public static void LinqGroupBy(List<User> users)
        {
            // Groups the users by their role
            var groupedUsers = users.GroupBy(u => u.UserRole);
            foreach (var g in groupedUsers)
            {
                Console.WriteLine("---" + g.Key + "---");
                foreach (var u in g)
                {
                    Console.WriteLine(u.ToString());
                }
            }
        }

        // ToLookUp
        // Returns groups of elements based on some key value
        // Inserts elements into a Lookup (a one-to-many dictionary) based on a key selector function
        // ToLookup is the same as GroupBy, the only difference is the execution of GroupBy is deferred whereas ToLookup execution is immediate
        public static void LinqToLookUp(List<User> users)
        {
            // Groups the users by their role
            ILookup<UserRole, User> groupedUsers = users.ToLookup(u => u.UserRole);
            foreach (var g in groupedUsers)
            {
                Console.WriteLine("---" + g.Key + "---");
                foreach (var u in g)
                {
                    Console.WriteLine(u.ToString());
                }
            }
        }
    }
}
