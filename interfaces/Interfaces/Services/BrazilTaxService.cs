using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Interfaces.Services
{
    class BrazilTaxService : ITaxService //não é herança, é uma realização de interface
    {
        public double Tax (double amount)
        {
            /*if (amount < 100.0)
            {
                return amount * 0.2;
            } 
            else
            {
                return amount * 0.15;
            }*/

            //return (amount < 100) ? amount * 0.2 : amount * 0.15;
            return amount * (amount < 100 ? 0.2 : 0.15);
        }
    }
}
