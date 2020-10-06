using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine());

            while (x >= 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3"));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número negativo!");
        }
    }
}
