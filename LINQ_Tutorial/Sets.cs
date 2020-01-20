using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Tutorial
{
    public class Sets
    {
        // Distinct
        // Returns distinct values from a collection
        public static void LinqDistinct(List<User> users)
        {
            // Az azonos értékű elemekből csak egyet ad vissza duplikátumok nélkül
            var distinct = users.Select(u => u.UserRole).Distinct();
        }

        // Except
        // Returns a new collection with elements from the first collection which do not exist in the second collection
        public static void LinqExcept(List<int> integers, List<int> integers2)
        {
            // A két lista különbségét adja vissza
            // Azokat az elemeket adja vissza az 1. listából, melyek nem szerepelnek a 2. listában
            // Csak egyedi elemeket ad vissza
            var except = integers.Except(integers2);
        }

        // Intersect
        // Returns a new collection that includes common elements that exists in both collections
        public static void LinqIntersect(List<int> integers, List<int> integers2)
        {
            // A két lista metszetét adja vissza
            // Azokat az elemeket adja vissza, amelyek mindkét listában megtalálhatók
            // Csak egyedi elemeket ad vissza
            var intersect = integers.Intersect(integers2);
        }

        // Union
        // Requires two collections and returns a new collection that includes distinct elements from both the collections
        public static void LinqUnion(List<int> integers, List<int> integers2)
        {
            // A két lista unióját adja vissza
            // Azokat az elemeket adja vissza, amelyek legalább az egyik listában megtalálhatók
            // Csak egyedi elemeket ad vissza
            var union = integers.Union(integers2);
        }

        // Gyakorlás

        // 1.
        // Van egy bizonylat listánk (string lista), amibe véletlenül többször kerültek azonos sorszámú bizonylatok
        // Adjunk vissza egy olyan listát, amiben a számlák csak egyszer szerepelnek.

        // 2.
        // Van két integer listánk, az egyikben páros számok, a másikban négyzetszámok vannak
        // Szükségünk van egy olyan listára, ami a két előbbi listából összeszedi a páros négyzetszámokat
    }
}
