using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Concatenation
    {
        // Concat
        // Appends two sequences of the same type and returns a new sequence
        public static void LinqConcat(IEnumerable<int> integers, IEnumerable<int> integers2)
        {
            // Visszatér egy olyan collectionnel, amely tartalmazza az 1. és a 2. lista elemeit, ebben a sorrendben
            var concatenation = integers.Concat(integers2);
        }
    }
}
