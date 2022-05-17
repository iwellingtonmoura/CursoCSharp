using System;
using System.Collections.Generic;

namespace CouseAulaHashSetESortedSet
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 2, 4, 5, 7, 9, 19 };
            SortedSet<int> b = new SortedSet<int>() { 1, 3, 4, 8, 10, 9 };

            SortedSet<int> c = new SortedSet<int>(a);

            //Union
            c.UnionWith(b);

            //Intersection

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);


            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintColletction(c);
            PrintColletction(d);
            PrintColletction(e);

        }


        static void PrintColletction<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");

            }

            Console.WriteLine();
        }
    }
}
