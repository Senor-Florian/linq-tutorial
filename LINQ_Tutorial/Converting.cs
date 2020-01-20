using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Converting
    {
        // AsEnumberable
        public static IEnumerable<int> LinqAsEnumberable(List<int> integers)
        {
            // IEnumberable-t ad vissza az eredeti helyett 
            return integers.AsEnumerable();
        }

        // AsQueryable
        public static IQueryable<int> LinqAsQueryable(List<int> integers)
        {
            // IQueryable-t ad vissza az eredeti helyett 
            return integers.AsQueryable();
        }

        // ToList
        // Converts collection to List
        public static List<string> LinqToList(List<string> names)
        {
            // Listává alakítja az eredeti collectiont
            var nameArray = names.ToArray();
            return nameArray.ToList();
        }

        // ToArray
        // Converts collection to array
        public static string[] LinqToArray(List<string> names)
        {
            // Tömbbé alakítja az eredeti collectiont
            var nameArray = names.AsEnumerable().ToArray();
            return nameArray;
        }

        // ToDictionary
        // Puts elements into a Dictionary based on key selector function
        public static void LinqToDictionary(List<User> users)
        {
            // Egy collectionből dictionary-t készít
            IDictionary<Guid, User> usersDictionary = users.ToDictionary(u => u.ID);
        }
    }
}
