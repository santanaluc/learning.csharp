using System;
using System.Collections.Generic;
using Exercício2.Entities;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Course> set = new HashSet<Course>();

            Console.Write("How many students for course A? ");
            int nA = int.Parse(Console.ReadLine());

            for (int i = 0; i < nA; i++)
            {
                int student = int.Parse(Console.ReadLine());
                set.Add(new Course(student));
            }

            Console.Write("How many students for course B? ");
            int nB = int.Parse(Console.ReadLine());

            for (int i = 0; i < nB; i++)
            {
                int student = int.Parse(Console.ReadLine()); 
                set.Add(new Course(student));

            }

            Console.Write("How many students for course C? ");
            int nC = int.Parse(Console.ReadLine());

            for (int i = 0; i < nC; i++)
            {
                int student = int.Parse(Console.ReadLine());
                set.Add(new Course(student));
            }

            Console.WriteLine($"Total of {set.Count} students.");
            
            
            /*TESTE
            foreach (Course obj in set)
            {
                Console.WriteLine(obj);
            }*/

            //PrintCollection(set);
        }

        //Teste
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
