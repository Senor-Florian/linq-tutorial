using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial {

    public class App {

        public static void Main(string[] args)
        {
            //LinqAggregate(DataGenerator.GetIntegerList1());
            //LinqAll(DataGenerator.GetIntegerList1());
            //LinqAny(DataGenerator.GetIntegerList1());
            //LinqAverage(DataGenerator.GetIntegerList1());
            //LinqConcat(DataGenerator.GetNames());
            //LinqContains(DataGenerator.GetNames());
            //LinqCount(DataGenerator.GetNames());
            //LinqDefaultIfEmpty(DataGenerator.GetIntegerList1());
            //LinqDistinct(DataGenerator.GetIntegerList1());
            //LinqElementAt(DataGenerator.GetIntegerList1());
            //LinqExcept(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            //LinqFirst(DataGenerator.GetIntegerList1());
            //LinqGroupBy(DataGenerator.GetUsers());
            //LinqGroupJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
            //LinqIntersect(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            //LinqJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
            //LinqLast(DataGenerator.GetIntegerList1());
            //LinqMax(DataGenerator.GetUsers());
            //LinqMin(DataGenerator.GetIntegerList1());
            //LinqOfType(DataGenerator.GetMixedList());
            //LinqOrderBy(DataGenerator.GetUsers());
            //LinqSelect(DataGenerator.GetUsers());
            //LinqSelectMany(DataGenerator.GetUsers());
            //LinqSequenceEqual(DataGenerator.GetIntegerList2(), DataGenerator.GetIntegerList3());
            //LinqSingle(DataGenerator.GetUsers(), new Guid("567b145b-876e-4e82-9071-c8a7f7c31667"), DataGenerator.GetIntegerList1());
            //LinqSkip(DataGenerator.GetIntegerList1());
            //LinqSkipWhile(DataGenerator.GetUsers());
            //LinqSum(DataGenerator.GetIntegerList1());
            //LinqTake(DataGenerator.GetIntegerList1());
            //LinqTakeWhile(DataGenerator.GetUsers());
            //LinqToDictionary(DataGenerator.GetUsers());
            //LinqLookUp(DataGenerator.GetUsers());
            //LinqUnion(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            //LinqWhere(DataGenerator.GetUsers());
            LinqZip(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
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
            // Returns the average of the integers
            var average = integers.Average();
            Console.WriteLine("Average: \n" + average);
            
        }

        // Cast
        // Coverts a non-generic collection to a generic collection
        public static IEnumerable<string> LinqCast(List<int> integers)
        {
            // Cast the integer list into a string list
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

        // Count / LongCount
        // Returns the number (int / long) of elements in the collection or number of elements that have satisfied the given condition
        public static void LinqCount(List<string> names)
        {
            // Returns the number of the names from list that are longer than 15 characters
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
            // Returns the default value if the index is out of the range
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
        // Returns the first element of a collection, or the first element that satisfies a condition (or a default value if no such element exists.)
        public static void LinqFirst(List<int> integers)
        {
            // Returns the first negative number in the list
            var firstNegativeNumber = integers.First(i => i < 0);
            // Returns the first number over 100, doesn't throw an error if none is found
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
            // Returns the name of the institutions and the users who work at them
            var groupJoin = institutions.GroupJoin(users, i => i.ID, u => u.InstitutionID, (i, u) => new { i.Name, u });

            Console.WriteLine("GroupJoin:");

            foreach(var g in groupJoin)
            {
                Console.WriteLine(g.Name + ":");
                foreach(var u in g.u)
                {
                    Console.WriteLine(string.Join(", ", new List<string>() { u.FullName, u.LoginName }));
                }
                
            }
        }

        // Intersect
        // Returns a new collection that includes common elements that exists in both collections
        public static void LinqIntersect(List<int> integers, List<int> integers2)
        {
            // Return a list with only the numbers that are present in both lists
            // Even if a value is present multiple times in both collections, there's only one instance of it in the intersected collection
            var intersect = integers.Intersect(integers2);
            Console.WriteLine("Intersect:");
            foreach (var i in intersect)
            {
                Console.WriteLine(i);
            }
        }

        // Join
        // Joins two sequences (collections) based on a key and returns a resulted sequence
        public static void LinqJoin(List<User> users, List<Institution> institutions)
        {
            var join = users.Join(institutions, u => u.InstitutionID, i => i.ID, (u, i) => new { u.FullName, u.LoginName, i.Name });

            Console.WriteLine("Join:");

            foreach (var j in join)
            {
                Console.WriteLine(string.Join(", ", new List<string>() { j.FullName, j.LoginName, j.Name }));
            }
        }

        // Last/LastOrDefault
        // Returns the last element of a collection, or the last element that satisfies a condition (or a default value if no such element exists)
        public static void LinqLast(List<int> integers)
        {
            // Returns the last negative number in the list
            var lastNegativeNumber = integers.Last(i => i < 0);
            // Returns the last number over 100, doesn't throw an error if none is found
            var lastNumberOverOneHundred = integers.LastOrDefault(i => i > 100);

            Console.WriteLine("Last");
            Console.WriteLine(lastNegativeNumber);
            Console.WriteLine(lastNumberOverOneHundred);
        }

        // Max
        // Returns the largest numeric element from a collection
        public static void LinqMax(List<User> users)
        {
            // Returns date of birth of the youngest user from the list (largest datetime value)
            var youngestUserDob = users.Max(i => i.DateOfBirth);
            Console.WriteLine("Max");
            Console.WriteLine(youngestUserDob);
        }

        // Min
        // Returns the smalles numeric element from a collection
        public static void LinqMin(List<int> integers)
        {
            // Returns the smallest number from the list
            var smallestPositiveNumber = integers.Min();
            Console.WriteLine("Min");
            Console.WriteLine(smallestPositiveNumber);
        }

        // OfType
        // Filters the collection based on the ability to cast an element in a collection to a specified type
        public static void LinqOfType(IList mixedList)
        {
            // Returns the integer from the list
            var integers = mixedList.OfType<int>();
            Console.WriteLine("OfType");
            foreach(var i in integers)
            {
                Console.WriteLine(i);
            }
        }

        // OrderBy/OrderByDescending/ThenBy/ThenByDescending
        // Arranges the elements of the collection in ascending or descending order
        public static void LinqOrderBy(List<User> users)
        {
            // Orders the users first by their role, then by their fullname
            var sortedUsers = users.OrderBy(u => u.UserRole.ToString())
                                   .ThenBy(u => u.FullName);

            Console.WriteLine("OrderBy");
            foreach (var u in sortedUsers)
            {
                Console.WriteLine(u);
            }
        }

        // Select
        // Returns an IEnumerable collection which contains elements based on a transformation function
        public static void LinqSelect(List<User> users)
        {
            // Returns the names of the users
            var userNames = users.Select(u => u.FullName);

            Console.WriteLine("Select");
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

            Console.WriteLine("SelectMany");
            foreach(var h in hobbies)
            {

                Console.WriteLine(h);
            }
        }

        // SequenceEqual
        // Checks whether the number of elements, value of each element and order of elements in two collections are equal or not
        public static void LinqSequenceEqual(List<int> integers, List<int> integers2)
        {
            // Returns true because the two lists have the same elements in the same order
            var isEqual = integers.SequenceEqual(integers2);

            Console.WriteLine("SequenceEqual");
            Console.WriteLine(isEqual);
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

            Console.WriteLine("Single");
            Console.WriteLine(user.ToString());
            Console.WriteLine(integerOverOneHundred);
        }

        // Skip
        // Skips elements up to a specified position starting from the first element in a sequence
        public static void LinqSkip(List<int> integers)
        {
            // Removes the first 5 elements of the list
            var nonSkippedNumbers = integers.Skip(5);
            Console.WriteLine("Skip");
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
            Console.WriteLine("SkipWhile");
            foreach(var u in nonSkippedUsers)
            {
                Console.WriteLine(u);
            }
        }

        // Sum
        // Calculates the sum of numeric items in the collection
        public static void LinqSum(List<int> integers)
        {
            // Sums the value of the integers
            var sum = integers.Sum();
            Console.WriteLine("Sum");
            Console.WriteLine(sum);
        }

        // Take
        // Takes elements up to a specified position starting from the first element in a sequence
        public static void LinqTake(List<int> integers)
        {
            // Returns the first 5 elements of the list
            var takenNumbers = integers.Take(5);
            Console.WriteLine("Take");
            foreach (var i in takenNumbers)
            {
                Console.WriteLine(i);
            }
        }

        // TakeWhile
        // Returns elements from the first element until an element does not satisfy the condition
        // If the first element itself doesn't satisfy the condition then returns an empty collection. 
        public static void LinqTakeWhile(List<User> users)
        {
            // Takes users until it finds one with the user role of a Monitor
            var takenUsers = users.TakeWhile(u => u.UserRole != UserRole.MONITOR);
            Console.WriteLine("TakeWhile");
            foreach (var u in takenUsers)
            {
                Console.WriteLine(u);
            }
        }

        // ToDictionary
        // Puts elements into a Dictionary based on key selector function
        public static void LinqToDictionary(List<User> users)
        {
            // Creates a dictionary from the user list where they keys are Guids and the values are the users themselves
            IDictionary<Guid, User> usersDictionary = users.ToDictionary<User, Guid>(u => u.ID);
            Console.WriteLine("ToDictionary");
            foreach(var key in usersDictionary.Keys)
            {
                Console.WriteLine("Key: " + key + ", " + usersDictionary[key]);
            }
        }

        // ToList
        // Converts collection to List
        public static List<string> LinqToList(List<string> names)
        {
            // Converts an array to a list
            var nameArray = names.ToArray();
            return nameArray.ToList();
        }

        // LookUp
        // Returns groups of elements based on some key value
        // ToLookup is the same as GroupBy, the only difference is the execution of GroupBy is deferred whereas ToLookup execution is immediate
        public static void LinqLookUp(List<User> users)
        {
            // Groups the users by their role
            var groupedUsers = users.ToLookup(u => u.UserRole);
            Console.WriteLine("LookUp");
            foreach (var g in groupedUsers)
            {
                Console.WriteLine("---" + g.Key + "---");
                foreach (var u in g)
                {
                    Console.WriteLine(u.ToString());
                }
            }
        }

        // Union
        // Requires two collections and returns a new collection that includes distinct elements from both the collections
        public static void LinqUnion(List<int> integers, List<int> integers2)
        {
            // Returns the combined_ distinct values of the two integer lists
            var union = integers.Union(integers2);
            Console.WriteLine("Union");
            foreach (var i in union)
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

        // Zip
        // Iterates through two collections and combines their elements, one by one, into a single new collection
        public static void LinqZip(List<int> integers, List<int> integers2)
        {
            // Multiplies the respective elements of two lists
            var zippedList = integers.Zip(integers2, (a, b) => a * b);
            Console.WriteLine("Zip");
            foreach (var i in zippedList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
