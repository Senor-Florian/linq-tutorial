using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Generation
    {
        // DefaultIfEmpty
        // Returns a new collection with the default value if the given collection on which DefaultIfEmpty() is invoked is empty
        public static void LinqDefaultIfEmpty(List<int> integers)
        {
            // Returns a list containing one element with the value of 100 if the original list is empty
            var filtered = integers.Where(i => i > 100).DefaultIfEmpty(100);

            Console.WriteLine("DefaultIfEmpty:");
            foreach (var i in filtered)
            {
                Console.WriteLine(i);
            }
        }
    }
}
