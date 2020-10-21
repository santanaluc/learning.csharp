using System;
using System.Globalization;

namespace DateTimee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Representa um Instante
            //é um tipo struct

            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2020, 10, 21);
            DateTime d3 = new DateTime(2020, 10, 21, 04, 47, 3);
            DateTime d4 = new DateTime(2020, 10, 21, 04, 47, 3, 500);
            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.UtcNow;

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("08/15/2000 13:05:58");

            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d11 = DateTime.ParseExact("15-08-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); //quantidade de ticks que passaram
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
        }
    }
}
