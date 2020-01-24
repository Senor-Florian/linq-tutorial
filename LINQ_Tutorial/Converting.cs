using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Converting
    {
        // AsEnumberable
        public static IEnumerable<int> LinqAsEnumberable(IEnumerable<int> integers)
        {
            // IEnumberable-t ad vissza az eredeti helyett 
            return integers.AsEnumerable();
        }

        // AsQueryable
        public static IQueryable<int> LinqAsQueryable(IEnumerable<int> integers)
        {
            // IQueryable-t ad vissza az eredeti helyett 
            return integers.AsQueryable();
        }

        // ToList
        // Converts collection to List
        public static List<string> LinqToList(string[] names)
        {
            // Listává alakítja az eredeti collectiont
            return names.ToList();
        }

        // ToArray
        // Converts collection to array
        public static string[] LinqToArray(IEnumerable<string> names)
        {
            // Tömbbé alakítja az eredeti collectiont
            return names.AsEnumerable().ToArray();
        }

        // ToDictionary
        // Puts elements into a Dictionary based on key selector function
        public static void LinqToDictionary(IEnumerable<User> users)
        {
            // Egy collectionből dictionary-t készít
            // A felhasználók Id-ja lesz a kulcs (key), maguk a felhasználók pedig az érték (value).
            IDictionary<Guid, User> usersDictionary = users.ToDictionary(u => u.Id);
        }
    }
}
