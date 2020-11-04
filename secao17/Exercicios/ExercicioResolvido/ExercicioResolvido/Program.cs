using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExercicioResolvido.Entities;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter full file path: ");
            string path = Console.ReadLine();*/
            string path = @"D:\csharp\Temp\in3.txt";

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    var name = fields[0];
                    var price = double.Parse(fields[1]);

                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2"));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
