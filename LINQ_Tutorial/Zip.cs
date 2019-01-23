using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Zip
    {
        // Zip
        // Iterates through two collections and combines their elements, one by one, into a single new collection
        public static void LinqZip(List<int> integers, List<int> integers2)
        {
            // Multiplies the respective elements of two lists
            var zippedList = integers.Zip(integers2, (a, b) => a * b);
            foreach (var i in zippedList)
            {
                Console.Write(i + " ");
            }
        }
    }
}
