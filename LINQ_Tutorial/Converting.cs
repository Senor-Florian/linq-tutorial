﻿using LINQ_Tutorial.MockData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Converting
    {
        // AsEnumberable
        public static IEnumerable<int> LinqAsEnumberable(List<int> integers)
        {
            // Converts the list
            return integers.AsEnumerable();
        }

        // AsEnumberable
        public static IEnumerable<int> LinqAsQueryable(List<int> integers)
        {
            // Converts the list
            return integers.AsQueryable();
        }

        // Cast
        // Casts the elements of a collection to a specified type
        public static IEnumerable<string> LinqCast(List<int> integers)
        {
            // Cast the integer list into a string list
            return integers.Cast<string>();
        }

        // ToList
        // Converts collection to List
        public static List<string> LinqToList(List<string> names)
        {
            // Converts an array to a list
            var nameArray = names.ToArray();
            return nameArray.ToList();
        }

        // ToArray
        // Converts collection to array
        public static string[] LinqToArray(List<string> names)
        {
            // Converts a list to an array
            var nameArray = names.AsEnumerable().ToArray();
            return nameArray;
        }

        // ToDictionary
        // Puts elements into a Dictionary based on key selector function
        public static void LinqToDictionary(List<User> users)
        {
            // Creates a dictionary from the user list where they keys are Guids and the values are the users themselves
            IDictionary<Guid, User> usersDictionary = users.ToDictionary<User, Guid>(u => u.ID);
            Console.WriteLine("ToDictionary:");
            foreach (var key in usersDictionary.Keys)
            {
                Console.WriteLine("Key: " + key + ", " + usersDictionary[key]);
            }
        }
    }
}