using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Aggregation
    {
        // Aggregate
        // Performs a custom aggregation operation on the values in the collection
        public static void LinqAggregate(List<int> integers)
        {
            // A collection minden egyes eleme esetén elvégzi a megadott műveletet az adott elemmel és az előző elem esetén elvégzett művelet eredményével
            // Példa: egy integer lista elemeit összegezhetjük, az aktuális elemet mindig hozzáadja a korábbi elemek összegéhez
            var sum = integers.Aggregate((a, b) => a + b);
        }

        // Average
        // Calculates the average of the numeric items in the collection
        public static void LinqAverage(List<int> integers)
        {
            // Átlagolja a collection elemeinek értékét
            // Csak numerikus típusok esetén használható
            var average = integers.Average();
            Console.WriteLine(average);
        }

        // Count / LongCount
        // Returns the number (int / long) of elements in the collection or number of elements that have satisfied the given condition
        public static void LinqCount(List<int> integers)
        {
            // Visszaadja egy lista elemeinek számát, illetve azon elemek számát, melyek megfelelnek az adott feltételnek
            var intCount = integers.Count(i => i > 15);
            var intCount2 = integers.Count();
        }

        // Max
        // Returns the largest numeric element from a collection
        public static void LinqMax(List<User> users)
        {
            // Visszaadja a legnagyobb értékű elemet a listából
            var youngestUserDob = users.Max(i => i.DateOfBirth);
        }

        // Min
        // Returns the smalles numeric element from a collection
        public static void LinqMin(List<int> integers)
        {
            // Visszaadja a legkisebb értékű elemet a listából
            var smallestNumber = integers.Min();
        }

        // Sum
        // Calculates the sum of numeric items in the collection
        public static void LinqSum(List<int> integers)
        {
            // Összeadja a collection elemeinek értékét
            var sum = integers.Sum();
        }

        // Gyakorlás

        // 1.
        // Egy neveket tartalmazó string lista elemeit fűzzük össze egy string-é, vesszőkkel elválasztva

        // 2.
        // Számoljuk össze, hogy egy neveket tartalmazó string lista hány eleme hosszabb 10 karakternél

        // 3.
        // Keressük meg a felhasználók közül a legöregebbet
    }
}
