using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Projection
    {
        // Select
        // Returns an IEnumerable collection which contains elements based on a transformation function
        public static void LinqSelect(List<User> users)
        {
            // Returns the names of the users
            var userNames = users.Select(u => u.FullName);

            foreach (var n in userNames)
            {
                Console.WriteLine(n);
            }
        }

        // SelectMany
        // Projects sequences of values that are based on a transform function and then flattens them into one sequence
        public static void LinqSelectMany(List<User> users)
        {
            // Returns a list of the hobbies of the users
            var hobbies = users.SelectMany(u => u.Hobbies);

            foreach (var h in hobbies)
            {
                Console.WriteLine(h);
            }
        }
    }
}
