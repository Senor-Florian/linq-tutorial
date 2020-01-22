using LINQ_Tutorial.MockData;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Sorting
    {
        // OrderBy/OrderByDescending/ThenBy/ThenByDescending
        // Arranges the elements of the collection in ascending or descending order
        public static void LinqOrderBy(List<User> users)
        {
            // Rendezi az elemeket egy vagy több szempont szerint
            // OrderBy: rendez egy szempont szerint
            // ThenBy: az előző rendezés szerint azonos pozicióban lévő elemeket tovább rendezi egy újabb szempont szerint
            var sortedUsers = users.OrderBy(u => u.UserRole.ToString())
                                   .ThenBy(u => u.FullName)
                                   .ThenByDescending(u => u.LoginName);

            // OrderBy/ThenBy: növekvő
            // OrderByDescending/ThenByDescending: csökkenő
        }

        // Reverse
        // Reverses the order of the elements in a collection
        public static void LinqReverse(IEnumerable<int> integers)
        {
            // Megfordítja az elemek sorrendjét
            integers.Reverse();
        }

        // Gyakorlás

        // 1.
        // Rendezzük a felhasználókat először név szerint növekvő, majd születési dátum szerint csökkenő sorrendben.
    }
}
