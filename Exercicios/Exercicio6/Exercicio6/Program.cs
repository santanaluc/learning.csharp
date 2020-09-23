using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vetor = Console.ReadLine().Split(' ');

            A = double.Parse(vetor[0]);
            B = double.Parse(vetor[1]);
            C = double.Parse(vetor[2]);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: {0} \nCIRCULO: {1} \nTRAPEZIO: {2} \nQUADRADO: {3} \nRETANGULO: {4}",
                triangulo.ToString("F3"), circulo.ToString("F3"), trapezio.ToString("F3"), quadrado.ToString("F3"), retangulo.ToString("F3"));
        }
    }
}
