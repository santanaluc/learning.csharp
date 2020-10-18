using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ExercícioListas
{
    class Employee
    {
        public int Id { get; set; }
        private string Name;
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percent)
        {
            Salary *= (percent * 100.0);
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary;
        }
    }
}
