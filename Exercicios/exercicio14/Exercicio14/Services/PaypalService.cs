using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio14.Services
{
    class PaypalService : IPaymentService
    {
        public double Payment(double amount)
        {
            return amount *= 0.02;
        }

        public double Interest(double amount, int month)
        {
            return amount * 0.01 * month;
        }
    }
}
