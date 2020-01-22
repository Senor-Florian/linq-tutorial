using LINQ_Tutorial.MockData;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Join
    {
        // Join
        // Joins two sequences (collections) based on a key and returns a resulted sequence
        public static void LinqJoin(List<User> users, List<Institution> institutions)
        {
            // Két collection-t összekapcsol egy kulcs alapján.
            // Példa: a felhasználókat összekapcsolja a hozzájuk tartozó intéznménnyel, és visszaad egy olyan anonymous object
            // listát, amely mindkét osztályból tartalmaz property-ket.
            var join = users.Join(institutions, u => u.InstitutionID, i => i.Id, (u, i) => new { u.FullName, u.LoginName, i.Name });
        }

        // GroupJoin
        // Joins two sequences based on key and groups the result by matching key and then returns the collection of grouped result and key
        public static void LinqGroupJoin(List<User> users, List<Institution> institutions)
        {
            // Két collection-t összekapcsol egy kulcs alapján, és csoportosít (group).
            // Példa: az intézményeket összekapcsolja a hozzájuk tartozó felhasználókkal (felhasználó collection),
            // és visszaad egy olyan listát, amely tartalmazza az intézmények neveit és egy listában az ott dolgozó felhasználókat.
            var groupJoin = institutions.GroupJoin(users, i => i.Id, u => u.InstitutionID, (i, u) => new { i.Name, u });
        }

        // Gyakorlás

        // 1.
        // Kapcsoljuk össze azokat a felhasználókat a címükkel, akiknek van AddressId-ja, és adjuk
        // vissza egy olyan collectiont, ami tartalmazza felhasználók nevét, a címük országát és megyéjét.
    }
}
