using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio7.Entities;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= n; i++)
            {
                Console.WriteLine($"Employee number #{i} data:");
                Console.Write("OutSourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(name, hours, value, additionalCharge));
                } else
                {
                    list.Add(new Employee(name, hours, value));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments:");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
