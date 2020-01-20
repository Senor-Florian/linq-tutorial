using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{

    public class App {

        static List<int> roles = new List<int>();
        static List<string> userNames = new List<string>();

        public static void Main(string[] args)
        {
            #region Sorting
            Console.WriteLine("<<< 1 SORTING >>>");
            Console.WriteLine("<< 1.1 ORDERBY >>");
            Console.WriteLine("Userek rendezése role, majd teljes név szerint");
            Sorting.LinqOrderBy(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 1.2 REVERSE >>");
            Sorting.LinqReverse(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Sets
            Console.WriteLine("<<< 2 SETS >>>");
            Console.WriteLine("<< 2.1 DISTINCT >>");
            Sets.LinqDistinct(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 2.2 EXCEPT >>");
            Sets.LinqExcept(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 2.3 INTERSECT >>");
            Sets.LinqIntersect(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 2.4 UNION >>");
            Sets.LinqUnion(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Elements
            Console.WriteLine("<<< 3 ELEMENTS >>>");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 3.1 ELEMENTAT >>");
            Elements.LinqElementAt(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 3.2 FIRST >>");
            Elements.LinqFirst(DataGenerator.GetIntegerList1(), DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 3.3 LAST >>");
            Elements.LinqLast(DataGenerator.GetIntegerList1(), DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 3.4 SINGLE >>");
            Elements.LinqSingle(DataGenerator.GetUsers(), new Guid("567b145b-876e-4e82-9071-c8a7f7c31667"), DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Converting
            Console.WriteLine("<<< 4 CONVERTING >>>");
            Console.WriteLine("<< 4.1 TODICTIONARY >>");
            Converting.LinqToDictionary(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Aggragetion
            Console.WriteLine("<<< 5 AGGREGATION >>>");
            Console.WriteLine("<< 5.1 AGGREGATE >>");
            Aggregation.LinqAggregate(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 5.2 AVERAGE >>");
            Aggregation.LinqAverage(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 5.3 COUNT >>");
            Aggregation.LinqCount(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 5.4 MAX >>");
            Aggregation.LinqMax(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 5.5 MIN >>");
            Aggregation.LinqMin(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 5.6 SUM >>");
            Aggregation.LinqSum(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Filtering
            Console.WriteLine("<<< 6 FILTERING >>>");
            Console.WriteLine("<< 6.1 OFTYPE >>");
            Filtering.LinqOfType(DataGenerator.GetMixedList());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 6.2 WHERE >>");
            Filtering.LinqWhere(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Quantifiers
            Console.WriteLine("<<< 7 QUANTIFIERS >>>");
            Console.WriteLine("<< 7.1 ALL >>");
            Quantifiers.LinqAll(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 7.2 ANY >>");
            Quantifiers.LinqAny(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 7.3 CONTAINS >>");
            Quantifiers.LinqContains(DataGenerator.GetNames());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Projection
            Console.WriteLine("<<< 8 PROJECTION >>>");
            Console.WriteLine("<< 8.1 SELECT >>");
            Projection.LinqSelect(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 8.2 SELECTMANY >>");
            Projection.LinqSelectMany(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Partitioning
            Console.WriteLine("<<< 9 PARTITIONING >>>");
            Console.WriteLine("<< 9.1 SKIP >>");
            Partitioning.LinqSkip(DataGenerator.GetIntegerList1());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 9.2 SKIPWHILE >>");
            Partitioning.LinqSkipWhile(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 9.3 TAKE >>");
            Partitioning.LinqTake(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 9.4 TAKEWHILE >>");
            Partitioning.LinqTakeWhile(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Join
            Console.WriteLine("<<< 10 JOIN >>>");
            Console.WriteLine("<< 10.1 JOIN >>");
            Join.LinqJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 10.2 GROUPJOIN >>");
            Join.LinqGroupJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Grouping
            Console.WriteLine("<<< 11 GROUPING >>>");
            Console.WriteLine("<< 11.1 TOLOOKUP >>");
            Grouping.LinqToLookUp(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("<< 11.2 GROUPBY >>");
            Grouping.LinqGroupBy(DataGenerator.GetUsers());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Generation
            Console.WriteLine("<<< 12 GENERATION >>>");
            Console.WriteLine("<< 12.1 DEFAULTIFEMPTY >>");
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
