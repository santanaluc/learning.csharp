using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio10.Entities
{
    abstract class Collaborators
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Collaborators()
        {

        }
        public Collaborators(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();
    }
}
