using ExercicioFixacao.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter full file path: ");
            string path = Console.ReadLine();*/

            //Reading the path
            var path = @"D:\csharp\Temp\in4.txt";
            Console.Write("Enter salary: ");
            var enterSalary = double.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    var name = fields[0];
                    var email = fields[1];
                    var salary = double.Parse(fields[2]);

                    list.Add(new Employee(name, email, salary));
                }
            }
            // Finish of read the path and add to entities

            Console.WriteLine("Email of people whose salary is more than " + enterSalary.ToString("F2"));
            var emailSalary = list.Where(e => e.Salary > enterSalary).Select(e => e.Email);
            foreach (var email in emailSalary)
            {
                Console.WriteLine(email);
            }

            var sumSalary = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine("Sum of salary of people whose name stats with 'M': " + sumSalary.ToString("F2"));
        }
    }
}
