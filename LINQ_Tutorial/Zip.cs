using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Zip
    {
        // Zip
        // Iterates through two collections and combines their elements, one by one, into a single new collection
        public static void LinqZip(List<int> integers, List<int> integers2)
        {
            // A két collection megfelelő indexű elemein elvégzi a paraméterben megadtott műveletet, és annak
            // eredményét belerakja az új lista azonos indexű poziciójába.
            // Ha a 2 lista nem egyenlő hosszú, akkor a rövidebb lista végéig megy az "összefűzés", és az eredmény
            // lista a rövidebb lista hosszával lesz megegyező hosszúságú.
            var zippedList = integers.Zip(integers2, (a, b) => a * b); // Összeszorozza a megfelelő elemeket
        }
    }
}
