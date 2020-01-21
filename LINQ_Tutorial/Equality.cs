using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Equality
    {
        // SequenceEqual
        // Checks whether the number of elements, value of each element and order of elements in two collections are equal or not
        public static void LinqSequenceEqual(List<int> integers, List<int> integers2)
        {
            // True-val tér vissza, ha a 2 collection egyforma hosszú, és a megfelelő elemek egyenlőek, egyébként false
            var isEqual = integers.SequenceEqual(integers2);
        }
    }
}
