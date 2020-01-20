using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Grouping
    {
        // GroupBy
        // Groups elements of a sequence that share a common attribute
        public static void LinqGroupBy(List<User> users)
        {
            // Csoportosít egy collection-t a megadott property alapján
            // Példa: a felhasználók csoportosítva lettek role alapján
            // olyan adathalmazt eredményezve, melynek minden eleme rendelkezik egy kulccsal, aminek értéke a csoportosítást meghatározó property (role) éréke,
            // illetve egy collection-t, amiben a csoportosított elemek (felhasználók) vannak
            var groupedUsers = users.GroupBy(u => u.UserRole);
        }

        // ToLookUp
        // Returns groups of elements based on some key value
        // Inserts elements into a Lookup (a one-to-many dictionary) based on a key selector function
        // ToLookup is the same as GroupBy, the only difference is the execution of GroupBy is deferred whereas ToLookup execution is immediate
        public static void LinqToLookUp(List<User> users)
        {
            // Működésben nagyon hasonló a GroupBy-hoz
            // Különbség: a ToLookup kiértékelése azonnali, a GroupBy kiértékelése késleltetett 
            ILookup<UserRole, User> groupedUsers = users.ToLookup(u => u.UserRole);
        }
    }
}
