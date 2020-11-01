using System;
using System.Collections.Generic;
using Exercício2.Entities;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> set = new HashSet<Student>();

            var courseNames = "ABC";

            for (var i = 0; i < 3; i++)
            {
                Console.Write($"How many students for course {courseNames[i]}? ");
                int n = int.Parse(Console.ReadLine());

                for (var j = 0; j < n; j++)
                {
                    int student = int.Parse(Console.ReadLine());
                    set.Add(new Student(student));
                }
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