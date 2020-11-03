using System;
using System.Collections.Generic;
using DelegateAction.Entities;

namespace DelegateAction
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
            Action<Product> act = UpdatePrice;
            Action<Product> act1 = p => { p.Price += p.Price * 0.1 };

            list.ForEach(UpdatePrice);
            list.ForEach(act);
            list.ForEach(act1);
            list.ForEach( p => p.Price += p.Price * 0.1);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
