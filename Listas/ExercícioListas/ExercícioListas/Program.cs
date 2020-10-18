using System;
using System.Collections.Generic;

namespace ExercícioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int register = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < register; i++)
            {
                int num = i + 1;
                Console.WriteLine("Employee #" + num);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine();

                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id2 = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == id2);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine());

                emp.increaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
