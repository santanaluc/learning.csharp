using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee()
        {

        }

        public OutSourcedEmployee(double additionalCharge)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            base.Payment();
            return AdditionalCharge *= 0.1;
        }
    }
}
