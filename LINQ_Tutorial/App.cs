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
                var users = await repository.SortUsers();
                // OrderBy
                Console.WriteLine(JsonConvert.SerializeObject(users));
                Sorting.LinqOrderBy(DataGenerator.GetUsers());
                // Reverse
                Sorting.LinqReverse(DataGenerator.GetIntegerList1());
                #endregion

                #region Sets
                Sets.LinqDistinct(DataGenerator.GetIntegerList1());
                Sets.LinqExcept(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
                Sets.LinqIntersect(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
                Sets.LinqUnion(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
                #endregion

                #region Elements
                Elements.LinqElementAt(DataGenerator.GetIntegerList1());
                Elements.LinqFirst(DataGenerator.GetIntegerList1());
                Elements.LinqLast(DataGenerator.GetIntegerList1());
                Elements.LinqSingle(DataGenerator.GetUsers(), new Guid("567b145b-876e-4e82-9071-c8a7f7c31667"), DataGenerator.GetIntegerList1());
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
