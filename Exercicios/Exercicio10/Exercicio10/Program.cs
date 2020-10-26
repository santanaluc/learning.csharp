using Exercicio10.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Collaborators> list = new List<Collaborators>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine());
                    Collaborators collaborators = new Individual(name, income, expenditures);
                    list.Add(collaborators);
                } else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    Collaborators collaborators = new Company(name, income, employees);
                    list.Add(collaborators);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxes paid:");
            foreach (Collaborators col in list)
            {
                Console.WriteLine(col.Name + ": $ " + col.Tax().ToString("F2"));
            }

            Console.WriteLine();
            double sum = 0.0;
            foreach (Collaborators col in list)
            {
                sum += col.Tax();
            }
            Console.WriteLine("Total taxes: $" + sum.ToString("F2"));
        }
    }
}
