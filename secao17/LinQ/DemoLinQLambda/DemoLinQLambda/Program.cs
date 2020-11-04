using System;
using System.Linq;
using DemoLinQLambda.Entities;
using System.Collections.Generic;

namespace DemoLinQLambda
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900:", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS:", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryNmae = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANOUNYMOUS OBJECT:", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THE BY NAME:", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THE BY NAME SKIP 2 TAKE 4:", r4);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default test 1 = " + r6);

            var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine("First or default test 2 = ", r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); // não funciona caso o resultado do where for mais de 1 resultado
            Console.WriteLine("Single or default test1 = " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault(); // não funciona caso o resultado do where for mais de 1 resultado
            Console.WriteLine("Single or default test2 = " + r9);

            //operacoes de agregação
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Max price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum Prices: " + r12);
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);// se nao tiver nenhum elemento, dará erro
            Console.WriteLine("Category 1 Average Prices: " + r13);

            //default if empty
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); //era uma sequencia de produtos que foi transformada em sequencia de double (só os precos)
            Console.WriteLine("Category 5 average prices: " + r14);

            //map.reduce(de outras linguagens)                                              para nao ter erro, colocar o 0,0 antes da expressao anonima
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y); // se o resultado for vazio dará erro
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category);
            foreach(var group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach(var p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
