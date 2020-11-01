using System;
using System.Collections.Generic;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //uniao (tudo que já tem no A + o que tiver no B)
            SortedSet<int> c = new SortedSet<int>(a); //pega o conjunte a e adiciona no c
            c.UnionWith(b); // uniao de b com c
            PrintCollection(c);

            //intersection - elementos que existem nos dois conjuntos
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //diference - elementos de a que não existem no conjunto b
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
