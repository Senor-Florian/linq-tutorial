using LINQ_Tutorial.MockData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Filtering
    {
        // OfType
        // Filters the collection based on the ability to cast an element in a collection to a specified type
        public static void LinqOfType(IList mixedList)
        {
            // Returns the integer from the list
            var integers = mixedList.OfType<int>();
            foreach (var i in integers)
            {
                Console.WriteLine(i);
            }
        }

        // Where
        // Returns values from the collection based on a predicate function
        public static void LinqWhere(List<User> users)
        {
            // Returns the users who are doctors
            var filteredUsers = users.Where(u => u.UserRole == UserRole.DOCTOR);
            foreach (var u in filteredUsers)
            {
                Console.WriteLine(u);
            }
        }
    }
}
