using LINQ_Tutorial.MockData;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Projection
    {
        // Select
        // Returns an IEnumerable collection which contains elements based on a transformation function
        public static void LinqSelect(IEnumerable<User> users)
        {
            // Az eredeti collection elemeit új formára transzformálja
            // Példa: a felhasználó listából string listát csinál a felhasználók nevét megtartva
            var userNames = users.Select(u => u.FullName);
        }

        // SelectMany
        // Projects sequences of values that are based on a transform function and then flattens them into one sequence
        public static void LinqSelectMany(IEnumerable<User> users)
        {
            // Akkor használatos, ha egy collection elemei collection property-t tartalmaznak, és ezen
            // property-k tartalmát akarjuk egy collection-be tenni.
            // Példa: az összes felhasználó összes hobbiját egy listába helyezi.
            var hobbies = users.SelectMany(u => u.Hobbies);
        }
    }
}
