using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class Join
    {
        // Join
        // Joins two sequences (collections) based on a key and returns a resulted sequence
        public static void LinqJoin(List<User> users, List<Institution> institutions)
        {
            var join = users.Join(institutions, u => u.InstitutionID, i => i.ID, (u, i) => new { u.FullName, u.LoginName, i.Name });

            foreach (var j in join)
            {
                Console.WriteLine(string.Join(", ", new List<string>() { j.FullName, j.LoginName, j.Name }));
            }
        }

        // GroupJoin
        // Joins two sequences based on key and groups the result by matching key and then returns the collection of grouped result and key
        public static void LinqGroupJoin(List<User> users, List<Institution> institutions)
        {
            // Returns the name of the institutions and the users who work at them
            var groupJoin = institutions.GroupJoin(users, i => i.ID, u => u.InstitutionID, (i, u) => new { i.Name, u });

            foreach (var g in groupJoin)
            {
                Console.WriteLine(g.Name + ":");
                foreach (var u in g.u)
                {
                    Console.WriteLine(string.Join(", ", new List<string>() { u.FullName, u.LoginName }));
                }
            }
        }
    }
}
