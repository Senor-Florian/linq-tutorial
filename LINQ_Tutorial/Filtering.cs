using LINQ_Tutorial.MockData;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Filtering
    {
        // OfType
        // Filters the collection based on the ability to cast an element in a collection to a specified type
        public static void LinqOfType(IList mixedList)
        {
            // Visszaad egy olyan collectiont, ami csak a megadott típusú elemeket tartalmazza az eredeti collectionből
            var integers = mixedList.OfType<int>();
        }

        // Where
        // Returns values from the collection based on a predicate function
        public static void LinqWhere(IEnumerable<User> users)
        {
            // Visszaad egy olyan collectiont, ami a megadott feltételnek megfelelő elemeket tartalmazza az eredeti collectionből
            var filteredUsers = users.Where(u => u.UserRole == UserRole.DOCTOR);
        }
    }
}
