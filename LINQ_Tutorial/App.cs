using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial {

    public class App {

        public static void Main(string[] args)
        {
            List<string> names = new List<string>() {
                "Geffrei Neubert",
                "Alizaunder Bonauiti",
                "Artor Lerch",
                "Cniva Labouré",
                "Euryhus Dekever",
                "Eduuin Sprecher",
                "Ciprianus Larosière",
                "Hemonnet Garavini",
                "Sansalas Bosman",
                "Virus Kunz"
            };

            List<int> integers = new List<int>() { 4, 6, 1, 34, -7, -23, 6, 8, 8 };
            List<int> integers2 = new List<int>() { 4, 10, 45, 11, 7, -49, 23, 8, 98 };

            List<User> users = new List<User>() {
                new User() {
                    ID = new Guid("1f7778d1-da5f-4c60-8b14-0cad7e20a56e"),
                    InstitutionID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    FullName = "Turbertus Talenti",
                    LoginName = "turbertus",
                    UserRole = UserRole.DOCTOR
                },
                new User() {
                    ID = new Guid("8a345a04-ff6b-4d0f-bf8d-a43ccf5f7119"),
                    InstitutionID = new Guid("1243ff5d-08f4-4fda-b8b8-7de312b9b9e1"),
                    FullName = "Spertias d'Aufai",
                    LoginName = "spertias",
                    UserRole = UserRole.STUDY_ADMIN
                },
                new User() {
                    ID = new Guid("ea2ca41c-dfc8-4afc-a0c6-bc5201095da1"),
                    InstitutionID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    FullName = "Waldef Brugger",
                    LoginName = "waldef",
                    UserRole = UserRole.DOCTOR
                },
                new User() {
                    ID = new Guid("109cf32a-30a4-4105-bbff-a9a6ab70e1ee"),
                    InstitutionID = new Guid("51fd5201-a0d1-49cd-b995-2fbcdd2a0d5f"),
                    FullName = "Georgius Ferrari",
                    LoginName = "georgius",
                    UserRole = UserRole.MONITOR
                },
                new User() {
                    ID = new Guid("3243b8e7-a6b4-4c33-b375-242f4e94a02f"),
                    InstitutionID = new Guid("1243ff5d-08f4-4fda-b8b8-7de312b9b9e1"),
                    FullName = "Willmot Vries",
                    LoginName = "willmot",
                    UserRole = UserRole.MONITOR
                },
                new User() {
                    ID = new Guid("567b145b-876e-4e82-9071-c8a7f7c31667"),
                    InstitutionID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    FullName = "Radoald Friedek",
                    LoginName = "radoald",
                    UserRole = UserRole.DOCTOR
                }
            };

            List<Institution> institutions = new List<Institution>() {
                new Institution() {
                    ID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    Name = "Lakeside Clinic"
                },
                new Institution() {
                    ID = new Guid("1243ff5d-08f4-4fda-b8b8-7de312b9b9e1"),
                    Name = "Silverwood Community Hospital"
                },
                new Institution() {
                    ID = new Guid("51fd5201-a0d1-49cd-b995-2fbcdd2a0d5f"),
                    Name = "Southshore Hospital Center"
                }
            };

            //LinqAggregate(integers);
            //LinqAll(integers);
            //LinqAny(integers);
            //LinqAverage(integers);
            //LinqConcat(names);
            //LinqContains(names);
            //LinqCount(names);
            //LinqDefaultIfEmpty(integers);
            //LinqDistinct(integers);
            //LinqElementAt(integers);
            //LinqExcept(integers, integers2);
            //LinqFirst(integers);
            //LinqGroupBy(users);
            LinqGroupJoin(users, institutions);
            Console.ReadKey();
        }

        // Aggregate
        // Performs a custom aggregation operation on the values in the collection
        public static void LinqAggregate(List<int> integers)
        {
            // Calculates the sum of integers
            var sum = integers.Aggregate((a, b) => a + b);

            Console.WriteLine("Aggregate: \n" + sum);
        }

        // All
        // Returns with a bool, checks if all the elements in a sequence satisfies the specified condition 
        public static void LinqAll(List<int> integers)
        {
            // Checks if all integers are positive in the list
            var allPositives = integers.All(i => i > 0);

            Console.WriteLine("All: \n" + allPositives);
        }

        // Any
        // Returns with a bool, checks if any of the elements in a sequence satisfies the specified condition 
        public static void LinqAny(List<int> integers)
        {
            // Checks if there are any negative integers in the lsit
            var isAnyNegative = integers.All(i => i < 0);
            Console.WriteLine("Any: \n" + isAnyNegative);
        }

        // AsEnumberable
        // AsQueryable
        public static IEnumerable<int> LinqAsEnumberable(List<int> integers)
        {
            // Converts the list
            return integers.AsEnumerable();
            //intgers.AsQueryable
        }

        // Average
        // Calculates the average of the numeric items in the collection
        public static void LinqAverage(List<int> integers)
        {
            // Returns the average of the intgers
            var average = integers.Average();
            Console.WriteLine("Average: \n" + average);
            
        }

        // TODO
        // Cast
        // Coverts a non-generic collection to a generic collection
        public static IEnumerable<string> LinqCast(List<int> integers)
        {
            return integers.Cast<string>();
        }

        // Concat
        // Appends two sequences of the same type and returns a new sequence
        public static void LinqConcat(List<string> names)
        {
            var concatenation = names.Concat(names);
            Console.WriteLine("Concat:");
            foreach (var c in concatenation)
            {
                Console.WriteLine(c);
            }
        }

        // Contains
        // Checks whether a specified element exists in the collection or not and returns a boolean
        public static void LinqContains(List<string> names)
        {
            var containsName = names.Contains("Alizaunder Bonauiti");
            Console.WriteLine("Contains: \n" + containsName);
        }

        // Count
        // Returns the number of elements in the collection or number of elements that have satisfied the given condition
        public static void LinqCount(List<string> names)
        {
            var longNameCount = names.Count(n => n.Count() > 15);
            Console.WriteLine("Count: \n" + longNameCount);
        }

        // DefaultIfEmpty
        // Returns a new collection with the default value if the given collection on which DefaultIfEmpty() is invoked is empty
        public static void LinqDefaultIfEmpty(List<int> integers)
        {
            // Returns a list containing one element with the value of 100 if the original list is empty
            var filtered = integers.Where(i => i > 100).DefaultIfEmpty(100);

            Console.WriteLine("DefaultIfEmpty:");
            foreach(var i in filtered)
            {
                Console.WriteLine(i);
            }
        }

        // Distinct
        // Returns distinct values from a collection
        public static void LinqDistinct(List<int> integers)
        {
            var distinct = integers.Distinct();
            Console.WriteLine("Distinct:");
            foreach(var i in distinct)
            {
                Console.WriteLine(i);
            }
        }

        // ElementAt/ElementAtOrDefault
        // Returns the element at a specified index in a collection (or a default value if the index is out of range)
        public static void LinqElementAt(List<int> integers)
        {
            //If the index is out of the range then it will throw an Index out of range exception
            var firstElement = integers.ElementAt(0);
            // Returns the default value if if the index is out of the range
            var hundredthElement = integers.ElementAtOrDefault(100);

            Console.WriteLine("ElementAt:");
            Console.WriteLine(firstElement);
            Console.WriteLine(hundredthElement);
        }

        // Except
        // Returns a new collection with elements from the first collection which do not exist in the second collection
        public static void LinqExcept(List<int> integers, List<int> integers2)
        {
            var except = integers.Except(integers2);
            Console.WriteLine("Except:");
            foreach (var i in except)
            {
                Console.WriteLine(i);
            }
        }

        // First/FirstOrDefault
        // Returns the first element of a collection, or the first element that satisfies a condition (or a default value if index is out of range)
        public static void LinqFirst(List<int> integers)
        {
            // Returns the first negative number in the list
            var firstNegativeNumber = integers.First(i => i < 0);
            // Returns the first number over 100, doesn't throw error if none is found
            var firstNumberOverOneHundred = integers.FirstOrDefault(i => i > 100);

            Console.WriteLine("First");
            Console.WriteLine(firstNegativeNumber);
            Console.WriteLine(firstNumberOverOneHundred);
        }

        // GroupBy
        // Returns groups of elements based on some key value
        public static void LinqGroupBy(List<User> users)
        {
            // Groups the users by their role
            var groupedUsers = users.GroupBy(u => u.UserRole);
            Console.WriteLine("GroupBy");
            foreach(var g in groupedUsers)
            {
                Console.WriteLine("---" + g.Key + "---");
                foreach(var u in g)
                {
                    Console.WriteLine(u.ToString());
                }
            }
        }

        // GroupJoin
        // Joins two sequences based on key and groups the result by matching key and then returns the collection of grouped result and key
        public static void LinqGroupJoin(List<User> users, List<Institution> institutions)
        {
            // Returns the name of the users and the institution they work at
            var groupJoin = users.GroupJoin(institutions, u => u.InstitutionID, i => i.ID, (u, i) => new { u.FullName, u.LoginName, i.SingleOrDefault().Name });

            Console.WriteLine("GroupJoin:");

            foreach(var g in groupJoin)
            {
                Console.WriteLine(string.Join(", ", new List<string>() { g.FullName, g.LoginName, g.Name }));
            }
        }
    }
}
