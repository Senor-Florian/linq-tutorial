using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Quantifiers
    {
        // All
        // Returns with a bool, checks if all the elements in a sequence satisfies the specified condition 
        public static void LinqAll(List<int> integers)
        {
            // True-val tér vissza, ha a collection minden elemére igaz a megadott feltétel, egyébként false.
            var allPositives = integers.All(i => i > 0);
        }

        // Any
        // Returns with a bool, checks if any of the elements in a sequence satisfies the specified condition 
        public static void LinqAny(List<int> integers)
        {
            // True-val tér vissza, ha a collection bármely elemére igaz a megadott feltétel, egyébként false.
            // Ha nincs feltétel megadva, akkor arra vizsgál, hogy van-e elem a collection-ben.
            var isAnyNegative = integers.Any(i => i < 0);
        }

        // Contains
        // Checks whether a specified element exists in the collection or not and returns a boolean
        public static void LinqContains(List<string> names)
        {
            // Megvizsgálja, hogy az adott elem szerepel-e a collection-ben
            var containsName = names.AsEnumerable().Contains("Alizaunder Bonauiti");
        }

        // Gyakorlás

        // 1.
        // Határozzuk meg, hogy van-e olyan felhasználó, aki 1980-01-01 előtt született
    }
}
