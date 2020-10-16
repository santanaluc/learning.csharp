using System;

namespace ModificadorParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = Calculator.Sum(2, 3);
            int soma2 = Calculator.Sum(2, 4, 3);

            Console.WriteLine(soma);
            Console.WriteLine(soma2);
        }
    }
}
