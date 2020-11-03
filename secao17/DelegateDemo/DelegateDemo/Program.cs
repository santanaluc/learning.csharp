using DelegateDemo.Services;
using System;

namespace DelegateDemo
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum; //objeto op é uma referência para a função CalculationService
            //BinaryNumericOperation op1 = new BinaryNumericOperation(CalculationService.Sum); da na mesma coisa

            double result = op(a, b);
            //double result1 = op.Invoke(a, b); mesma coisa
            Console.WriteLine(result);
        }
    }
}
