using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio10.Entities
{
    class Company : Collaborators
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }
        public Company(string name, double income, int numberOfEmployees) : base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees <= 10)
            {
                return (Income * 0.16);
            }
            else
            {
                return (Income * 0.14);
            }
        }
    }
}
