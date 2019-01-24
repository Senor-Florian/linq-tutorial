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

            Console.WriteLine("ELEMENTAT(0)");
            Console.WriteLine(firstElement);
            Console.WriteLine("ELEMENTAT_OR_DEFAULT(100)");
            Console.WriteLine(hundredthElement);
        }

        // First/FirstOrDefault
        // Returns the first element of a collection, or the first element that satisfies a condition (or a default value if no such element exists.)
        public static void LinqFirst(List<int> integers, List<User> users)
        {
            // Returns the first doctor user from a list
            var firstDoctorUser = users.First(u => u.UserRole == UserRole.DOCTOR);
            // Returns the first number over 100, doesn't throw an error if none is found
            var firstNumberOverOneHundred = integers.FirstOrDefault(i => i > 100);

            Console.WriteLine("FIRST(doctor)");
            Console.WriteLine(firstDoctorUser);
            Console.WriteLine("FIRST_OR_DEFAULT(i > 100)");
            Console.WriteLine(firstNumberOverOneHundred);
        }

        // Last/LastOrDefault
        // Returns the last element of a collection, or the last element that satisfies a condition (or a default value if no such element exists)
        public static void LinqLast(List<int> integers, List<User> users)
        {
            // Returns the last doctor user from a list
            var lastDoctorUser = users.Last(u => u.UserRole == UserRole.DOCTOR);
            // Returns the last number over 100, doesn't throw an error if none is found
            var lastNumberOverOneHundred = integers.LastOrDefault(i => i > 100);

            Console.WriteLine("LAST(doctor)");
            Console.WriteLine(lastDoctorUser);
            Console.WriteLine("LAST_OR_DEFAULT(i > 100)");
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

            Console.WriteLine("SINGLE(id)");
            Console.WriteLine(user.ToString());
            Console.WriteLine("SINGLE_OR_DEFAULT(i > 100)");
            Console.WriteLine(integerOverOneHundred);
        }
    }
}
