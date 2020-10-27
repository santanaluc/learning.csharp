using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio14.Services
{
    interface IPaymentService
    {
        double Payment(double amount);
        double Interest(double amount, int month);
    }
}
