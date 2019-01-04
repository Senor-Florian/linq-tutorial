using LINQ_Tutorial.MockData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial {

    public class App {

        public static void Main(string[] args)
        {
            // Sorting
            Sorting.LinqOrderBy(DataGenerator.GetUsers());
            Sorting.LinqReverse(DataGenerator.GetIntegerList1());
            // Sets
            Sets.LinqDistinct(DataGenerator.GetIntegerList1());
            Sets.LinqExcept(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Sets.LinqIntersect(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Sets.LinqUnion(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            // Elements
            Elements.LinqElementAt(DataGenerator.GetIntegerList1());
            Elements.LinqFirst(DataGenerator.GetIntegerList1());
            Elements.LinqLast(DataGenerator.GetIntegerList1());
            Elements.LinqSingle(DataGenerator.GetUsers(), new Guid("567b145b-876e-4e82-9071-c8a7f7c31667"), DataGenerator.GetIntegerList1());
            // Converting
            Converting.LinqToDictionary(DataGenerator.GetUsers());
            // Aggragetion
            Aggregation.LinqAggregate(DataGenerator.GetIntegerList1());
            Aggregation.LinqAverage(DataGenerator.GetIntegerList1());
            Aggregation.LinqCount(DataGenerator.GetNames());
            Aggregation.LinqMax(DataGenerator.GetUsers());
            Aggregation.LinqMin(DataGenerator.GetIntegerList1());
            Aggregation.LinqSum(DataGenerator.GetIntegerList1());
            // Filtering
            Filtering.LinqOfType(DataGenerator.GetMixedList());
            Filtering.LinqWhere(DataGenerator.GetUsers());
            // Quantifiers
            Quantifiers.LinqAll(DataGenerator.GetIntegerList1());
            Quantifiers.LinqAny(DataGenerator.GetIntegerList1());
            Quantifiers.LinqContains(DataGenerator.GetNames());
            // Projection
            Projection.LinqSelect(DataGenerator.GetUsers());
            Projection.LinqSelectMany(DataGenerator.GetUsers());
            // Partitioning
            Partitioning.LinqSkip(DataGenerator.GetIntegerList1());
            Partitioning.LinqSkipWhile(DataGenerator.GetUsers());
            Partitioning.LinqTake(DataGenerator.GetIntegerList1());
            Partitioning.LinqTakeWhile(DataGenerator.GetUsers());
            // Join
            Join.LinqJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
            Join.LinqGroupJoin(DataGenerator.GetUsers(), DataGenerator.GetInstitutions());
            // Grouping
            Grouping.LinqToLookUp(DataGenerator.GetUsers());
            Grouping.LinqGroupBy(DataGenerator.GetUsers());
            // Generation
            Generation.LinqDefaultIfEmpty(DataGenerator.GetIntegerList1());
            // Equality
            Equality.LinqSequenceEqual(DataGenerator.GetIntegerList2(), DataGenerator.GetIntegerList3());
            // Concatenation
            Concatenation.LinqConcat(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            // Zip
            Zip.LinqZip(DataGenerator.GetIntegerList1(), DataGenerator.GetIntegerList2());
            Console.ReadKey();
        }
    }
}
