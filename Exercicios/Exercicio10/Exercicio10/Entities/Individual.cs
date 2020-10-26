using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio10.Entities
{
    class Individual : Collaborators
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {

        }
        public Individual(string name, double income, double healthExpenditures) : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (Income <= 20000.00)
            {
                return (Income * 0.2) - (HealthExpenditures * 0.5);
            } else
            {
                return (Income * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
