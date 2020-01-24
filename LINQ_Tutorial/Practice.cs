using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Practice
    {
        // Gyakorlás

        // 1.
        // Rendezzük a felhasználókat először születési évük szerint csökkenő, majd teljes nevük szerint növekvő sorrendben.

        public static void SortUsers(IEnumerable<User> users)
        {
            var sortedUsers = users.OrderByDescending(x => x.DateOfBirth.Year).ThenBy(x => x.FullName);

            Console.WriteLine($"1.\n{string.Join(",\n", sortedUsers.Select(x => x.ToString()))}");

            // Output
            // Login name: favonia, FullName: Favonia Sidonius, User role: DATA_MANAGER, Date of birth: 1992.09.20. 0:00:00,
            // Login name: georgius, FullName: Georgius Ferrari, User role: MONITOR, Date of birth: 1992.01.27. 0:00:00,
            // Login name: spertias, FullName: Spertias d'Aufai, User role: STUDY_ADMIN, Date of birth: 1989.04.08. 0:00:00,
            // Login name: syncerastus, FullName: Syncerastus Viator, User role: STUDY_ADMIN, Date of birth: 1989.06.12. 0:00:00,
            // Login name: dionysia, FullName: Dionysia Augustalis, User role: DATA_PROVIDER, Date of birth: 1988.05.02. 0:00:00,
            // Login name: radoald, FullName: Radoald Friedek, User role: DOCTOR, Date of birth: 1988.02.17. 0:00:00,
            // Login name: turbertus, FullName: Turbertus Talenti, User role: DOCTOR, Date of birth: 1980.12.06. 0:00:00,
            // Login name: waldef, FullName: Waldef Brugger, User role: DOCTOR, Date of birth: 1974.07.13. 0:00:00,
            // Login name: willmot, FullName: Willmot Vries, User role: MONITOR, Date of birth: 1967.03.14. 0:00:00
        }

        // 2.
        // Van egy bizonylat listánk (string lista), amibe véletlenül többször kerültek azonos sorszámú bizonylatok.
        // Adjunk vissza egy olyan listát, amiben a számlák csak egyszer szerepelnek.

        public static void FilterInvoices(IEnumerable<string> invoices)
        {
            var filteredInvoices = invoices.Distinct();

            Console.WriteLine($"2.\n{string.Join(",\n", filteredInvoices)}");

            // Output
            // AGDF326534,
            // 5234GSGBNX,
            // KDFHDF43GF,
            // CBSDGS35AG,
            // LFGHBD3534,
            // CAQQ42HFCN
        }

        // 3.
        // Van két integer listánk, az egyikben páros számok, a másikban négyzetszámok vannak.
        // Szükségünk van egy olyan listára, ami a két előbbi listából összeszedi a páros négyzetszámokat.

        public static void GetEvenSquareNumbers(IEnumerable<int> integers, IEnumerable<int> integers2)
        {
            var evenSquareNumbers = integers.Intersect(integers2);

            Console.WriteLine($"3.\n{string.Join(",\n", evenSquareNumbers)}");

            // Output
            // 36,
            // 64,
            // 100
        }

        // 4.
        // Adjuk vissza egy integer lista 20. elemét úgy, hogy az ne dobjon hibát, ha nincs ilyen index és adjon vissza 42-őt

        public static void GetTwentiethElement(IEnumerable<int> integers)
        {
            var element = integers.ElementAtOrDefault(42);

            // Output
            // 42
        }

        // 5.
        // Egy felhasználó listából keressük ki a megfelelő azonosítójú (Id) felhasználót
        // Ne dobjon hibát az alkalmazás, ha nincs ilyen felhasználó

        public static void GetUserById(Guid userId, IEnumerable<User> users)
        {
            var user = users.SingleOrDefault(x => x.Id == userId);

            Console.WriteLine(user.ToString());

            // Output
            // Login name: syncerastus, FullName: Syncerastus Viator, User role: STUDY_ADMIN, Date of birth: 1989.06.12. 0:00:00
        }

        // 6.
        // Egy neveket tartalmazó string lista elemeit fűzzük össze egy string-é, vesszőkkel elválasztva

        public static void ConcatenateNames(IEnumerable<string> names)
        {
            var concatenatedNames = names.Aggregate((x, y) => x + ", " + y);

            Console.WriteLine(concatenatedNames);

            // Output
            // Geffrei Neubert, Alizaunder Bonauiti, Artor Lerch, Cniva Labouré, Euryhus Dekever, Eduuin Sprecher, Ciprianus Larosicre, Hemonnet Garavini, Sansalas Bosman, Virus Kunz
        }

        // 7.
        // Számoljuk össze, hogy egy neveket tartalmazó string lista hány eleme hosszabb 15 karakternél

        public static void CountLongNames(IEnumerable<string> names)
        {
            var count = names.Count(x => x.Count() > 15);

            Console.WriteLine(count);

            // Output
            // 3
        }

        // 8.
        // Keressük meg a felhasználók közül a legöregebb születési dátumát

        public static void GetOldesUserDateOfBirth(IEnumerable<User> users)
        {
            var dataOfBirth = users.Min(x => x.DateOfBirth);

            Console.WriteLine(dataOfBirth);

            // Output
            // 1967.03.14. 0:00:00
        }

        // 9.
        // Adjuk vissza azokat a felhasználókat, akik 1980-ban, vagy utána születtek

        public static void GetUsersAfter1980(IEnumerable<User> users)
        {
            var usersAfter1980 = users.Where(x => x.DateOfBirth.Year >= 1980);

            Console.WriteLine($"9.\n{string.Join(",\n", usersAfter1980.Select(x => x.ToString()))}");

            // Output
            // Login name: turbertus, FullName: Turbertus Talenti, User role: DOCTOR, Date of birth: 1980.12.06. 0:00:00,
            // Login name: spertias, FullName: Spertias d'Aufai, User role: STUDY_ADMIN, Date of birth: 1989.04.08. 0:00:00,
            // Login name: georgius, FullName: Georgius Ferrari, User role: MONITOR, Date of birth: 1992.01.27. 0:00:00,
            // Login name: radoald, FullName: Radoald Friedek, User role: DOCTOR, Date of birth: 1988.02.17. 0:00:00,
            // Login name: syncerastus, FullName: Syncerastus Viator, User role: STUDY_ADMIN, Date of birth: 1989.06.12. 0:00:00,
            // Login name: dionysia, FullName: Dionysia Augustalis, User role: DATA_PROVIDER, Date of birth: 1988.05.02. 0:00:00,
            // Login name: favonia, FullName: Favonia Sidonius, User role: DATA_MANAGER, Date of birth: 1992.09.20. 0:00:00
        }

        // 10.
        // Adjuk vissza azokat a felhasználókat, akiknek 2-nél több hobbija van.

        public static void GetUsersWithManyHobbies(IEnumerable<User> users)
        {
            var usersWithManyHobbies = users.Where(x => x.Hobbies.Count > 2);

            Console.WriteLine($"10.\n{string.Join(",\n", usersWithManyHobbies.Select(x => x.ToString()))}");

            // Output
            // Login name: waldef, FullName: Waldef Brugger, User role: DOCTOR, Date of birth: 1974.07.13. 0:00:00,
            // Login name: radoald, FullName: Radoald Friedek, User role: DOCTOR, Date of birth: 1988.02.17. 0:00:00
        }

        // 11.
        // Határozzuk meg, hogy van-e olyan felhasználó, aki 1970-01-01 előtt született

        public static void AreThereUsersBefore1970(IEnumerable<User> users)
        {
            var areThereUsersBefore1980 = users.Any(x => x.DateOfBirth.Year < 1970);

            // Output
            // true
        }

        // 12.
        // Készítsünk egy olyan anonymous object listát egy felhasználó listából, mely
        // a felhasználó nevét, születési dátumát és azonosítóját tartalmazza

        public static void GetProjectedUsers(IEnumerable<User> users)
        {
            var projectedUsers = users.Select(x => new { name = x.FullName, dob = x.DateOfBirth, id = x.Id });

            Console.WriteLine($"12.\n{string.Join(",\n", projectedUsers.Select(x => x.name + ", " + x.dob.ToString() + ", " + x.id.ToString()))}");

            // Output
            // Turbertus Talenti, 1980.12.06. 0:00:00, 1f7778d1 - da5f - 4c60 - 8b14 - 0cad7e20a56e,
            // Spertias d'Aufai, 1989.04.08. 0:00:00, 8a345a04-ff6b-4d0f-bf8d-a43ccf5f7119,
            // Waldef Brugger, 1974.07.13. 0:00:00, ea2ca41c - dfc8 - 4afc - a0c6 - bc5201095da1,
            // Georgius Ferrari, 1992.01.27. 0:00:00, 109cf32a - 30a4 - 4105 - bbff - a9a6ab70e1ee,
            // Willmot Vries, 1967.03.14. 0:00:00, 3243b8e7 - a6b4 - 4c33 - b375 - 242f4e94a02f,
            // Radoald Friedek, 1988.02.17. 0:00:00, 567b145b - 876e-4e82 - 9071 - c8a7f7c31667,
            // Syncerastus Viator, 1989.06.12. 0:00:00, 948068b8 - 7b67 - 4298 - bafa - ac7227663ed5,
            // Dionysia Augustalis, 1988.05.02. 0:00:00, 4b732aa4 - ffec - 410a - b6c9 - 66f46f13205f,
            // Favonia Sidonius, 1992.09.20. 0:00:00, f2c1017f - b878 - 4d0a - 874e-c1b588f5100b
        }

        // 13.
        // Oldalunkon szeretnénk paginálva megjeleníteni egy listában a felhasználókat, mert lassú lenne, ha a backend mindig visszaadná az összeset.
        // Írjunk egy metódust, amely visszaadja az adott oldalon megjelenítendő felhasználókat úgy, hogy megkapja az oldal számát (2) és az oldalon
        // megjelenítendő felhasználók számát (3).     

        public static void PaginateUsers(IEnumerable<User> users, int pageNumber, int pageSize)
        {
            var paginatedUsers = users.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            Console.WriteLine($"13.\n{string.Join(",\n", paginatedUsers.Select(x => x.ToString()))}");

            // Output

            // Login name: georgius, FullName: Georgius Ferrari, User role: MONITOR, Date of birth: 1992.01.27. 0:00:00,
            // Login name: willmot, FullName: Willmot Vries, User role: MONITOR, Date of birth: 1967.03.14. 0:00:00,
            // Login name: radoald, FullName: Radoald Friedek, User role: DOCTOR, Date of birth: 1988.02.17. 0:00:00
        }

        // 14.
        // Kapcsoljuk össze azokat a felhasználókat a címükkel, akiknek van AddressId-ja, és adjuk
        // vissza egy olyan collectiont, ami tartalmazza felhasználók nevét, a címük országát és megyéjét.

        public static void GetUsersWithAddress(IEnumerable<User> users, IEnumerable<Address> addresses)
        {
            var usersWithAddress = users.Join(addresses, u => u.AddressId, a => a.Id, (u, a) => new { u.FullName, a.Country, a.County });

            Console.WriteLine($"14.\n{string.Join(",\n", usersWithAddress.Select(x => x.FullName + ", " + x.Country + ", " + x.County))}");

            // Output

            // Spertias d'Aufai, HU, Csongrád,
            // Favonia Sidonius, HU, Budapest
        }

        // 15.
        // Csoportosítsuk a felhasználókat születési évük szerint, és írjuk ki a konzolra, hogy az egyes években hány felhasználó született.

        public static void GroupUsersByBirthYear(IEnumerable<User> users)
        {
            var groupedUsers = users.GroupBy(u => u.DateOfBirth.Year);

            Console.WriteLine($"14.\n{string.Join(",\n", groupedUsers.Select(x => x.Key + ", " + x.Count()))}");

            // Output

            // 1980, 1,
            // 1989, 2,
            // 1974, 1,
            // 1992, 2,
            // 1967, 1,
            // 1988, 2
        }

        // 16.
        // Írjunk egy olyan metódust, ami vár egy felhasználó listát. Ha a lista nem üres, akkor adjunk vissza egy új listát
        // az eredeti elemeivel, egyébként pedig egy egy elmeű listát, mely egy "Artotrogus Eburnus" teljes nevű, "artotrogus" login nevű felhasználót tartalmaz.

        public static void GetDefaultUser(IEnumerable<User> users)
        {
            var user = users.DefaultIfEmpty(new User { FullName = "Artotrogus Eburnus", LoginName = "artotrogus" }).SingleOrDefault();

            Console.WriteLine(user.ToString());

            // Output
            // Login name: artotrogus, FullName: Artotrogus Eburnus, User role: STUDY_ADMIN, Date of birth: 0001.01.01. 0:00:00
        }
    }
}
