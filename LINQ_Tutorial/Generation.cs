using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Generation
    {
        // DefaultIfEmpty
        // Returns a new collection with the default value if the given collection on which DefaultIfEmpty() is invoked is empty
        public static void LinqDefaultIfEmpty()
        {
            // Visszatér az eredeti collection elemeivel, ha az nem üres
            // Ha üres, akkor visszatér egy egy elemű listával, melynek értéke az elem típusának default értéke, vagy a paraméterben megadott érték
            var integers = new List<int>();
            var filtered = integers.DefaultIfEmpty();
            // var filtered = integers.DefaultIfEmpty(100); => ha üres a lista, akkor visszaad egy listát, aminek egyetlen eleme a 100
        }
    }
}
