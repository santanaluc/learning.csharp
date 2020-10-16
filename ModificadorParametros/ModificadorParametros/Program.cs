using System;

namespace ModificadorParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            //params
            int soma = Calculator.Sum(2, 3);
            int soma2 = Calculator.Sum(2, 4, 3);

            Console.WriteLine(soma);
            Console.WriteLine(soma2);

            //ref
            int a = 10;
            Calculator.Triple1(ref a);
            Console.WriteLine(a);

            //out
            int b = 10;
            int triple;
            Calculator.Triple2(b, out triple);
            //Vai retornar o valor final na variável triple(que virá da variável result)
            Console.WriteLine(triple);
        }
    }
}
