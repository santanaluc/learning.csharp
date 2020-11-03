using MulticastDemo.Services;
using System;

namespace MulticastDemo
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            var a = 10.0;
            var b = 12.0;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            //DIRETAMENTE POIS É DO TIPO VOID
            op(a, b);
            //op.Invoke(a,b); mesma coisa

        }
    }
}
