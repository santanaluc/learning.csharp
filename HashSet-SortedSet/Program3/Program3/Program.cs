using Program3.Entities;
using System;
using System.Collections.Generic;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0); // dois obj diferentes por conta do "new"

            Console.WriteLine(a.Contains(prod));

            //Quando o tipo é struct, ele vai comparar o conteúdo e não a referência (que neste caso daria false)
            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
        }
    }
}
