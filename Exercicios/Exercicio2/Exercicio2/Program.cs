using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            //casas decimais conforme exemplos.

            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine());

            double area = pi * (raio * raio);

            Console.WriteLine(area.ToString("F4"));
        }
    }
}
