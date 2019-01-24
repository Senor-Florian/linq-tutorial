using LINQ_Tutorial.DataAccess;
using LINQ_Tutorial.MockData;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial {

    public class App {

        static List<UserPoco> sortedUsers = new List<UserPoco>();
        static List<int> roles = new List<int>();
        static UserPoco firstDoctor;
        static List<UserPoco> doctorUsers = new List<UserPoco>();
        static List<string> userNames = new List<string>();
        static List<UserPoco> firstFiveUsers = new List<UserPoco>();
        static List<UserPoco> joinedUsers = new List<UserPoco>();
        private static string connectionString = @"asd";

        public async static Task Main(string[] args)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var repository = new Repository(connection);

                sortedUsers = await repository.SortUsers();
                roles = await repository.GetUserRoles();
                firstDoctor = await repository.GetFirstDoctorUser();
                doctorUsers = await repository.GetDoctorUsers();
                userNames = await repository.SelectUserNames();
                firstFiveUsers = await repository.GetFirstFiveUsers();
                joinedUsers = await repository.JoinUsers();
            }

            #region Sorting
            Console.WriteLine("<<< 1 SORTING >>>");
            Console.WriteLine("<< 1.1 ORDERBY >>");
            Console.WriteLine("Userek rendezése role, majd teljes név szerint");
            Console.WriteLine("< 1.1.1 SQL >");
            foreach (var user in sortedUsers)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("< 1.1.1 LINQ >");
            Sorting.LinqOrderBy(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 1.2 REVERSE >>");
            Console.WriteLine("< 1.2.1 LINQ >");
            Sorting.LinqReverse(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Sets
            Console.WriteLine("<<< 2 SETS >>>");
            Console.WriteLine("<< 2.1 DISTINCT >>");
            Console.WriteLine("User role-ok visszaadása egy user listából");
            Console.WriteLine("< 2.1.1 SQL >");
            foreach (var role in roles)
            {
                Console.WriteLine(((UserRole)role).ToString());
            }
            Console.WriteLine("< 2.1.2 LINQ >");
            Sets.LinqDistinct(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine("1-es lista");
            foreach (var i in DataGenerator.GetIntegerList1())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("2-es lista");
            foreach (var i in DataGenerator.GetIntegerList2())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 2.2 EXCEPT >>");
            Console.WriteLine("< 2.2.1 LINQ >");
            Sets.LinqExcept(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 2.3 INTERSECT >>");
            Console.WriteLine("< 2.3.1 LINQ >");
            Sets.LinqIntersect(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 2.4 UNION >>");
            Console.WriteLine("< 2.4.1 LINQ >");
            Sets.LinqUnion(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Elements
            Console.WriteLine("<<< 3 ELEMENTS >>>");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Eredeti lista");
            foreach (var i in DataGenerator.GetIntegerList1())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 3.1 ELEMENTAT >>");
            Console.WriteLine("< 3.1.1 LINQ >");
            Elements.LinqElementAt(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 3.2 FIRST >>");
            Console.WriteLine("< 3.2.1 SQL >");
            Console.WriteLine(firstDoctor);
            Console.WriteLine("< 3.2.2 LINQ >");
            Elements.LinqFirst(DataGenerator.GetIntegerList1(), DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 3.3 LAST >>");
            Console.WriteLine("< 3.3.1 LINQ >");
            Elements.LinqLast(DataGenerator.GetIntegerList1(), DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 3.4 SINGLE >>");
            Console.WriteLine("< 3.4.1 LINQ >");
            Elements.LinqSingle(DataGenerator.GetUsers(), new Guid("567b145b-876e-4e82-9071-c8a7f7c31667"), DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Converting
            Console.WriteLine("<<< 4 CONVERTING >>>");
            Console.WriteLine("<< 4.1 TODICTIONARY >>");
            Console.WriteLine("< 4.1.1 LINQ >");
            Converting.LinqToDictionary(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Aggragetion
            Console.WriteLine("Szám lista");
            foreach (var i in DataGenerator.GetIntegerList1())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Nevek");
            Console.WriteLine(string.Join(", ", DataGenerator.GetNames()));
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<<< 5 AGGREGATION >>>");
            Console.WriteLine("<< 5.1 AGGREGATE >>");
            Console.WriteLine("< 5.1.1 LINQ >");
            Aggregation.LinqAggregate(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 5.2 AVERAGE >>");
            Console.WriteLine("< 5.2.1 LINQ >");
            Aggregation.LinqAverage(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 5.3 COUNT >>");
            Console.WriteLine("< 5.3.1 LINQ >");
            Aggregation.LinqCount(DataGenerator.GetNames());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 5.4 MAX >>");
            Console.WriteLine("< 5.4.1 LINQ >");
            Aggregation.LinqMax(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 5.5 MIN >>");
            Console.WriteLine("< 5.5.1 LINQ >");
            Aggregation.LinqMin(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 5.6 SUM >>");
            Console.WriteLine("< 5.6.1 LINQ >");
            Aggregation.LinqSum(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Filtering
            Console.WriteLine("Vegyes lista");
            foreach (var i in DataGenerator.GetMixedList())
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<<< 6 FILTERING >>>");
            Console.WriteLine("<< 6.1 OFTYPE >>");
            Console.WriteLine("< 6.1.1 LINQ >");
            Filtering.LinqOfType(DataGenerator.GetMixedList());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 6.2 WHERE >>");
            Console.WriteLine("< 6.2.1 SQL >");
            foreach (var user in doctorUsers)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("< 6.2.2 LINQ >");
            Filtering.LinqWhere(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Quantifiers
            Console.WriteLine("Szám lista");
            foreach (var i in DataGenerator.GetIntegerList1())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Nevek");
            Console.WriteLine(string.Join(", ", DataGenerator.GetNames()));
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<<< 7 QUANTIFIERS >>>");
            Console.WriteLine("<< 7.1 ALL(i > 0) >>");
            Console.WriteLine("< 7.1.1 LINQ >");
            Quantifiers.LinqAll(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 7.2 ANY(i < 0) >>");
            Console.WriteLine("< 7.2.1 LINQ >");
            Quantifiers.LinqAny(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 7.3 CONTAINS(Alizaunder Bonauiti) >>");
            Console.WriteLine("< 7.3.1 LINQ >");
            Quantifiers.LinqContains(DataGenerator.GetNames());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Projection
            Console.WriteLine("<<< 8 PROJECTION >>>");
            Console.WriteLine("<< 8.1 SELECT >>");
            Console.WriteLine("< 8.1.1 SQL >");
            foreach (var name in userNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("< 8.1.2 LINQ >");
            Projection.LinqSelect(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 8.2 SELECTMANY >>");
            Console.WriteLine("< 8.2.1 LINQ >");
            Projection.LinqSelectMany(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Partitioning
            Console.WriteLine("Szám lista");
            foreach (var i in DataGenerator.GetIntegerList1())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<<< 9 PARTITIONING >>>");
            Console.WriteLine("<< 9.1 SKIP(5) >>");
            Console.WriteLine("< 9.1.1 LINQ >");
            Partitioning.LinqSkip(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 9.2 SKIPWHILE(!MONITOR) >>");
            Console.WriteLine("< 9.2.1 LINQ >");
            Partitioning.LinqSkipWhile(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 9.3 TAKE(5) >>");
            Console.WriteLine("< 9.3.1 SQL >");
            foreach (var user in firstFiveUsers)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("< 9.3.2 LINQ >");
            Partitioning.LinqTake(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 9.4 TAKEWHILE(!MONITOR) >>");
            Console.WriteLine("< 9.4.1 LINQ >");
            Partitioning.LinqTakeWhile(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Join
            Console.WriteLine("<<< 10 JOIN >>>");
            Console.WriteLine("<< 10.1 JOIN >>");
            Console.WriteLine("< 10.1.1 SQL >>");
            Console.WriteLine("Userek címhez joinolása");
            foreach (var user in joinedUsers)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("< 10.1.1 LINQ >>");
            Console.WriteLine("Userek intézményhez joinolása");
            Join.LinqJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 10.2 GROUPJOIN >>");
            Console.WriteLine("< 10.2.1 LINQ >");
            Console.WriteLine("Intézmények, és az ott dolgozó userek");
            Join.LinqGroupJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Grouping
            Console.WriteLine("<<< 11 GROUPING >>>");
            Console.WriteLine("Userek role szerinti csoportosítása");
            Console.WriteLine("<< 11.1 TOLOOKUP >>");
            Console.WriteLine("< 11.1.1 LINQ >");
            Grouping.LinqToLookUp(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 11.2 GROUPBY >>");
            Console.WriteLine("<< 11.2.1 LINQ >>");
            Grouping.LinqGroupBy(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Generation
            Console.WriteLine("<<< 12 GENERATION >>>");
            Console.WriteLine("<< 12.1 DEFAULTIFEMPTY(100) >>");
            Console.WriteLine("< 12.1.1 LINQ >");
            Generation.LinqDefaultIfEmpty();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Equality
            Console.WriteLine("<<< 13 EQUALITY >>>");
            Console.WriteLine("<< 13.1 SEQUENCE_EQUAL >>");
            Console.WriteLine("< 13.1.1 LINQ >");
            Equality.LinqSequenceEqual(DataGenerator.GetIntegerList2(), DataGenerator.GetIntegerList3());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Concatenation
            Console.WriteLine("1-es lista");
            foreach (var i in DataGenerator.GetIntegerList1())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("2-es lista");
            foreach (var i in DataGenerator.GetIntegerList2())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<<< 14 CONCATENATION >>>");
            Console.WriteLine("<< 14.1 CONCAT >>");
            Console.WriteLine("< 14.1.1 LINQ >");
            Concatenation.LinqConcat(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Zip
            Console.WriteLine("1-es lista");
            foreach (var i in DataGenerator.GetIntegerList1())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("2-es lista");
            foreach (var i in DataGenerator.GetIntegerList2())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<<< 15 ZIP >>>");
            Console.WriteLine("<< 15.1 ZIP >>");
            Console.WriteLine("< 15.1.1 LINQ >");
            Zip.LinqZip(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Console.WriteLine("-------------------------------------------------------------------------");
            #endregion

            Console.ReadKey();
        }
    }
}
