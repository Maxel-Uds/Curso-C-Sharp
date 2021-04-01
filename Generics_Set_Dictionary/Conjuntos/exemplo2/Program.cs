﻿using System;
using System.Collections.Generic;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4 ,5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() {5, 6, 7, 8, 9, 10 };

            //União
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);
            
            //Intersecção
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);
            
            //Diferença
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            Console.Write("{");
            foreach(T obj in collection)
            {
                Console.Write(" " + obj + ", ");
            }
            Console.WriteLine("}");
        }
    }
}
