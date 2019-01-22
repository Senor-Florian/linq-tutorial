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

        private static string connectionString = @"connection";

        public async static Task Main(string[] args)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var repository = new Repository(connection);

                #region Sorting
                Console.WriteLine("<<< 1 SORTING >>>");
                var users = await repository.SortUsers();
                // OrderBy
                Console.WriteLine("<< 1.1 ORDERBY >>");
                Console.WriteLine("< 1.1.1 SQL >");
                foreach(var user in users)
                {
                    Console.WriteLine(user);
                }
                //Console.WriteLine(JsonConvert.SerializeObject(users));
                Console.WriteLine("< 1.1.1 LINQ >");
                Sorting.LinqOrderBy(DataGenerator.GetUsers());
                // Reverse
                Console.WriteLine("<< 1.2 REVERSE >>");
                Console.WriteLine("< 1.2.1 LINQ >");
                Sorting.LinqReverse(DataGenerator.GetIntegerList1());
                Console.WriteLine("------------------------------------------------------");
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
                #endregion

                #region Elements
                Console.WriteLine("<<< 3 ELEMENTS >>>");
                Console.WriteLine("<< 3.1 ELEMENTAT >>");
                Elements.LinqElementAt(DataGenerator.GetIntegerList1());
                Console.WriteLine("<< 3.2 FIRST >>");
                Elements.LinqFirst(DataGenerator.GetIntegerList1());
                Console.WriteLine("<< 3.3 LAST >>");
                Elements.LinqLast(DataGenerator.GetIntegerList1());
                Console.WriteLine("<< 3.4 SINGLE >>");
                Elements.LinqSingle(DataGenerator.GetUsers(), new Guid("567b145b-876e-4e82-9071-c8a7f7c31667"), DataGenerator.GetIntegerList1());
                Console.WriteLine("------------------------------------------------------");
                #endregion

                #region Converting
                Converting.LinqToDictionary(DataGenerator.GetUsers());
                #endregion

                #region Aggragetion
                Aggregation.LinqAggregate(DataGenerator.GetIntegerList1());
                Aggregation.LinqAverage(DataGenerator.GetIntegerList1());
                Aggregation.LinqCount(DataGenerator.GetNames());
                Aggregation.LinqMax(DataGenerator.GetUsers());
                Aggregation.LinqMin(DataGenerator.GetIntegerList1());
                Aggregation.LinqSum(DataGenerator.GetIntegerList1());
                #endregion

                #region Filtering
                // OfType
                Filtering.LinqOfType(DataGenerator.GetMixedList());
                // Where
                users = await repository.FilterUsers();
                Console.WriteLine(JsonConvert.SerializeObject(users));
                Filtering.LinqWhere(DataGenerator.GetUsers());
                #endregion

                #region Quantifiers
                Quantifiers.LinqAll(DataGenerator.GetIntegerList1());
                Quantifiers.LinqAny(DataGenerator.GetIntegerList1());
                Quantifiers.LinqContains(DataGenerator.GetNames());
                #endregion

                #region Projection
                // Select
                users = await repository.SelectUsers();
                Console.WriteLine(JsonConvert.SerializeObject(users));
                Projection.LinqSelect(DataGenerator.GetUsers());
                // TODO
                Projection.LinqSelectMany(DataGenerator.GetUsers());
                #endregion

                #region Partitioning
                Partitioning.LinqSkip(DataGenerator.GetIntegerList1());
                Partitioning.LinqSkipWhile(DataGenerator.GetUsers());
                Partitioning.LinqTake(DataGenerator.GetIntegerList1());
                Partitioning.LinqTakeWhile(DataGenerator.GetUsers());
                #endregion

                #region Join
                // Join
                users = await repository.JoinUsers();
                Console.WriteLine(JsonConvert.SerializeObject(users));
                Join.LinqJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
                // GroupJoin
                // TODO
                Join.LinqGroupJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
                #endregion

                #region Grouping
                // TODO
                Grouping.LinqToLookUp(DataGenerator.GetUsers());
                Grouping.LinqGroupBy(DataGenerator.GetUsers());
                #endregion

                #region Generation
                Generation.LinqDefaultIfEmpty(DataGenerator.GetIntegerList1());
                #endregion

                #region Equality
                Equality.LinqSequenceEqual(DataGenerator.GetIntegerList2(), DataGenerator.GetIntegerList3());
                #endregion

                #region Concatenation
                Concatenation.LinqConcat(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
                #endregion

                #region Zip
                Zip.LinqZip(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
                #endregion

                Console.ReadKey();
            }
        }
    }
}
