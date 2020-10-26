using Exercicio8.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine();
                
                if (ch == 'c')
                {
                    Product product = new Product(name, price);
                    list.Add(product);
                } else if (ch == 'u')
                {
                    Console.Write("Manufacture date (MM/DD/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Product product = new UsedProduct(name, price, date);
                    list.Add(product);
                } else
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    Product product = new ImportedProduct(name, price, fee);
                    list.Add(product);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags"); 
            foreach(Product proc in list)
            {
                Console.WriteLine(proc.PriceTag());
            }
        }
    }
}
