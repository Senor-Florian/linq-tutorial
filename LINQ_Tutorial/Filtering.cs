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
        // TODO: query implementation

        // OfType
        // Filters the collection based on the ability to cast an element in a collection to a specified type
        public static void LinqOfType(IList mixedList)
        {
            // Returns the integer from the list
            var integers = mixedList.OfType<int>();
            Console.WriteLine("OfType:");
            foreach (var i in integers)
            {
                Console.WriteLine(i);
            }
        }

        // Where
        // Returns values from the collection based on a predicate function
        public static void LinqWhere(List<User> users)
        {
            // Returns the users who where born in 1980 or after
            var filteredUsers = users.Where(u => u.DateOfBirth >= Convert.ToDateTime("1980-01-01"));
            Console.WriteLine("Where");
            foreach (var u in filteredUsers)
            {
                Console.WriteLine(u);
            }
        }
    }
}
