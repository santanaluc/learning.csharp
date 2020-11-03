using System;
using System.Linq;
using DelegateFunc.Entities;
using System.Collections.Generic;

namespace DelegateFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Métodos diferentes de fazer a mesma coisa
            Func<Product, string> func = NameUpper;
            //Lambda
            Func<Product, string> func2 = p => p.Name.ToUpper();

            //Referência para o método
            List<string> result = list.Select(NameUpper).ToList();
            List<string> result2 = list.Select(func).ToList();
            //Lambda inline
            List<string> result3 = list.Select(p => p.Name.ToUpper()).ToList();


            foreach (string s in result3)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
