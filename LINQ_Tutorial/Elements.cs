using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Elements
    {
        // ElementAt/ElementAtOrDefault
        // Returns the element at a specified index in a collection (or a default value if the index is out of range)
        public static void LinqElementAt(IEnumerable<int> integers)
        {
            // Az adott indexű elemet adja vissza a listából, hibát dob ha nincs ilyen index
            var firstElement = integers.ElementAt(0);
            // Az adott indexű elemet adja vissza a listából, a típus default értékét adja vissza, ha nincs ilyen index
            var hundredthElement = integers.ElementAtOrDefault(100);
        }

        // First/FirstOrDefault
        // Returns the first element of a collection, or the first element that satisfies a condition (or a default value if no such element exists.)
        public static void LinqFirst(IEnumerable<int> integers, IEnumerable<User> users)
        {
            // Visszaadja az első olyan elemet, amely megfelel a feltételnek
            // Hibát dob, ha nem talál ilyet (üres a lista, vagy nem felel meg a feltételnek egy elem se)
            var firstDoctorUser = users.First(u => u.UserRole == UserRole.DOCTOR);
            // Visszaadja az első olyan elemet, amely megfelel a feltételnek
            // Nem dob hibát, han nem talál ilyet, visszaadja a típus alapértelmezett értékét
            var firstNumberOverOneHundred = integers.FirstOrDefault(i => i > 100);
        }

        // Last/LastOrDefault
        // Returns the last element of a collection, or the last element that satisfies a condition (or a default value if no such element exists)
        public static void LinqLast(IEnumerable<int> integers, IEnumerable<User> users)
        {
            // Visszaadja az utolsó olyan elemet, amely megfelel a feltételnek
            // Hibát dob, ha nem talál ilyet (üres a lista, vagy nem felel meg a feltételnek egy elem se)            
            var lastDoctorUser = users.Last(u => u.UserRole == UserRole.DOCTOR);
            // Visszaadja az utolsó olyan elemet, amely megfelel a feltételnek
            // Nem dob hibát, han nem talál ilyet, visszaadja a típus alapértelmezett értékét            
            var lastNumberOverOneHundred = integers.LastOrDefault(i => i > 100);
        }

        // Single/SingleOrDefault
        // Returns the only element from a collection, or the only element that satisfies a condition (or a default value if no such element exists) 
        public static void LinqSingle(IEnumerable<User> users, Guid id, IEnumerable<int> integers)
        {
            // Visszaadja az egyetlen olyan elemet, amelyre teljesül a feltétel
            // Hibát dob, ha üres a lista, egyik elemre se teljesül a fetétel, vagy több elemre is teljesül
            var user = users.Single(u => u.Id == id);
            // Visszaadja az egyetlen olyan elemet, amelyre teljesül a feltétel
            // Nem dob hibát, ha üres a lista, vagy egyetlen elemre se teljesül a feltétel
            // Hibát dob, ha több elemre teljesül a feltétel
            var integerOverOneHundred = integers.SingleOrDefault(i => i > 100);
        }
    }
}
