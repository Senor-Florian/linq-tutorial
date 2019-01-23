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

        private static string connectionString = @"asd";

        public async static Task Main(string[] args)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var repository = new Repository(connection);

                #region Sorting
                Console.WriteLine("<<< 1 SORTING >>>");
                var users = await repository.SortUsers();
                Console.WriteLine("<< 1.1 ORDERBY >>");
                Console.WriteLine("< 1.1.1 SQL >");
                foreach(var user in users)
                {
                    Console.WriteLine(user);
                }
                Console.WriteLine("< 1.1.1 LINQ >");
                Sorting.LinqOrderBy(DataGenerator.GetUsers());
                Console.WriteLine("<< 1.2 REVERSE >>");
                Console.WriteLine("< 1.2.1 LINQ >");
                Sorting.LinqReverse(DataGenerator.GetIntegerList1());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Sets
                Console.WriteLine("<<< 2 SETS >>>");
                var roles = await repository.GetUserRoles();
                Console.WriteLine("<< 2.1 DISTINCT >>");
                Console.WriteLine("< 2.1.1 SQL >");
                foreach(var role in roles)
                {
                    Console.WriteLine(((UserRole)role).ToString());
                }
                Console.WriteLine("< 2.1.2 LINQ >");
                Sets.LinqDistinct(DataGenerator.GetUsers());
                Console.WriteLine("<< 2.2 EXCEPT >>");
                Console.WriteLine("< 2.2.1 LINQ >");
                Sets.LinqExcept(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
                Console.WriteLine("<< 2.3 INTERSECT >>");
                Console.WriteLine("< 2.3.1 LINQ >");
                Sets.LinqIntersect(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
                Console.WriteLine("<< 2.4 UNION >>");
                Console.WriteLine("< 2.4.1 LINQ >");
                Sets.LinqUnion(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Elements
                Console.WriteLine("<<< 3 ELEMENTS >>>");
                Console.WriteLine("<< 3.1 ELEMENTAT >>");
                Console.WriteLine("< 3.1.1 LINQ >");
                Elements.LinqElementAt(DataGenerator.GetIntegerList1());
                Console.WriteLine("<< 3.2 FIRST >>");
                Console.WriteLine("< 3.2.1 SQL >");
                var firstDoctor = await repository.GetFirstDoctorUser();
                Console.WriteLine(firstDoctor);
                Console.WriteLine("< 3.2.2 LINQ >");
                Elements.LinqFirst(DataGenerator.GetIntegerList1(), DataGenerator.GetUsers());
                Console.WriteLine("<< 3.3 LAST >>");
                Console.WriteLine("< 3.3.1 SQL >");
                var lastDoctor = await repository.GetLastDoctorUser();
                Console.WriteLine(lastDoctor);
                Console.WriteLine("< 3.3.2 LINQ >");
                Elements.LinqLast(DataGenerator.GetIntegerList1(), DataGenerator.GetUsers());
                Console.WriteLine("<< 3.4 SINGLE >>");
                Console.WriteLine("< 3.4.1 LINQ >");
                Elements.LinqSingle(DataGenerator.GetUsers(), new Guid("567b145b-876e-4e82-9071-c8a7f7c31667"), DataGenerator.GetIntegerList1());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Converting
                Console.WriteLine("<<< 4 CONVERTING >>>");
                Console.WriteLine("<< 4.1 TODICTIONARY >>");
                Console.WriteLine("< 4.1.1 LINQ >");
                Converting.LinqToDictionary(DataGenerator.GetUsers());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Aggragetion
                Console.WriteLine("<<< 5 AGGREGATION >>>");
                Console.WriteLine("<< 5.1 AGGREGATE >>");
                Console.WriteLine("< 5.1.1 LINQ >");
                Aggregation.LinqAggregate(DataGenerator.GetIntegerList1());
                Console.WriteLine("<< 5.2 AVERAGE >>");
                Console.WriteLine("< 5.2.1 LINQ >");
                Aggregation.LinqAverage(DataGenerator.GetIntegerList1());
                Console.WriteLine("<< 5.3 COUNT >>");
                Console.WriteLine("< 5.3.1 LINQ >");
                Aggregation.LinqCount(DataGenerator.GetNames());
                Console.WriteLine("<< 5.4 MAX >>");
                Console.WriteLine("< 5.4.1 LINQ >");
                Aggregation.LinqMax(DataGenerator.GetUsers());
                Console.WriteLine("<< 5.5 MIN >>");
                Console.WriteLine("< 5.5.1 LINQ >");
                Aggregation.LinqMin(DataGenerator.GetIntegerList1());
                Console.WriteLine("<< 5.6 SUM >>");
                Console.WriteLine("< 5.6.1 LINQ >");
                Aggregation.LinqSum(DataGenerator.GetIntegerList1());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Filtering
                Console.WriteLine("<<< 6 FILTERING >>>");
                Console.WriteLine("<< 6.1 OFTYPE >>");
                Console.WriteLine("< 6.1.1 LINQ >");
                Filtering.LinqOfType(DataGenerator.GetMixedList());
                Console.WriteLine("<< 6.2 WHERE >>");
                Console.WriteLine("< 6.2.1 SQL >");
                users = await repository.GetDoctorUsers();
                foreach(var user in users)
                {
                    Console.WriteLine(user);
                }
                Console.WriteLine("< 6.2.2 LINQ >");
                Filtering.LinqWhere(DataGenerator.GetUsers());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Quantifiers
                Console.WriteLine("<<< 7 QUANTIFIERS >>>");
                Console.WriteLine("<< 7.1 ALL >>");
                Console.WriteLine("< 7.1.1 LINQ >");
                Quantifiers.LinqAll(DataGenerator.GetIntegerList1());
                Console.WriteLine("<< 7.2 ANY >>");
                Console.WriteLine("< 7.2.1 LINQ >");
                Quantifiers.LinqAny(DataGenerator.GetIntegerList1());
                Console.WriteLine("<< 7.3 CONTAINS >>");
                Console.WriteLine("< 7.3.1 LINQ >");
                Quantifiers.LinqContains(DataGenerator.GetNames());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Projection
                Console.WriteLine("<<< 8 PROJECTION >>>");
                Console.WriteLine("<< 8.1 SELECT >>");
                Console.WriteLine("< 8.1.1 SQL >");
                var names = await repository.SelectUserNames();
                foreach(var name in names)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("< 8.1.2 LINQ >");
                Projection.LinqSelect(DataGenerator.GetUsers());
                Console.WriteLine("<< 8.2 SELECTMANY >>");
                Console.WriteLine("< 8.2.1 LINQ >");
                Projection.LinqSelectMany(DataGenerator.GetUsers());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Partitioning
                Console.WriteLine("<<< 9 PARTITIONING >>>");
                Console.WriteLine("<< 9.1 SKIP >>");
                Console.WriteLine("< 9.1.1 LINQ >");
                Partitioning.LinqSkip(DataGenerator.GetIntegerList1());
                Console.WriteLine("<< 9.2 SKIPWHILE >>");
                Console.WriteLine("< 9.2.1 LINQ >");
                Partitioning.LinqSkipWhile(DataGenerator.GetUsers());
                Console.WriteLine("<< 9.3 TAKE >>");
                Console.WriteLine("< 9.3.1 SQL >");
                users = await repository.GetFirstFiveUsers();
                foreach(var user in users)
                {
                    Console.WriteLine(user);
                }
                Console.WriteLine("< 9.3.2 LINQ >");
                Partitioning.LinqTake(DataGenerator.GetUsers());
                Console.WriteLine("<< 9.4 TAKEWHILE >>");
                Console.WriteLine("< 9.4.1 LINQ >");
                Partitioning.LinqTakeWhile(DataGenerator.GetUsers());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Join
                Console.WriteLine("<<< 10 JOIN >>>");
                Console.WriteLine("<< 10.1 JOIN >>");
                Console.WriteLine("< 10.1.1 SQL >>");
                users = await repository.JoinUsers();
                foreach(var user in users)
                {
                    Console.WriteLine(user);
                }
                Console.WriteLine("< 10.1.1 LINQ >>");
                Join.LinqJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
                Console.WriteLine("<< 10.2 GROUPJOIN >>");
                Console.WriteLine("< 10.2.1 LINQ >");
                Join.LinqGroupJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Grouping
                Console.WriteLine("<<< 11 GROUPING >>>");
                Console.WriteLine("<< 11.1 TOLOOKUP >>");
                Console.WriteLine("< 11.1.1 LINQ >");
                Grouping.LinqToLookUp(DataGenerator.GetUsers());
                Console.WriteLine("<< 11.2 GROUPBY >>");
                Console.WriteLine("<< 11.2.1 LINQ >>");
                Grouping.LinqGroupBy(DataGenerator.GetUsers());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Generation
                Console.WriteLine("<<< 12 GENERATION >>>");
                Console.WriteLine("<< 12.1 DEFAULTIFEMPTY >>");
                Console.WriteLine("< 12.1.1 LINQ >");
                Generation.LinqDefaultIfEmpty();
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Equality
                Console.WriteLine("<<< 13 EQUALITY >>>");
                Console.WriteLine("<< 13.1 SEQUENCE_EQUAL >>");
                Console.WriteLine("< 13.1.1 LINQ >");
                Equality.LinqSequenceEqual(DataGenerator.GetIntegerList2(), DataGenerator.GetIntegerList3());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Concatenation
                Console.WriteLine("<<< 14 CONCATENATION >>>");
                Console.WriteLine("<< 14.1 CONCAT >>");
                Console.WriteLine("< 14.1.1 LINQ >");
                Concatenation.LinqConcat(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                #endregion

                #region Zip
                Console.WriteLine("<<< 15 ZIP >>>");
                Console.WriteLine("<< 15.1 ZIP >>");
                Console.WriteLine("< 15.1.1 LINQ >");
                Zip.LinqZip(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
                Console.WriteLine("------------------------------------------------------");
                #endregion

                Console.ReadKey();
            }
        }
    }
}
