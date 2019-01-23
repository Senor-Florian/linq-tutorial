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
        public static void LinqDefaultIfEmpty()
        {
            // Returns a list containing one element with the value of 100 if the original list is empty
            var integers = new List<int>();
            var filtered = integers.DefaultIfEmpty(100);

            foreach (var i in filtered)
            {
                Console.WriteLine(i);
            }
        }
    }
}
