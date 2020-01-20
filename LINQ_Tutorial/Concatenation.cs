using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Concatenation
    {
        // Concat
        // Appends two sequences of the same type and returns a new sequence
        public static void LinqConcat(List<int> integers, List<int> integers2)
        {
            var concatenation = integers.Concat(integers2);
            foreach (var c in concatenation)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }
    }
}
