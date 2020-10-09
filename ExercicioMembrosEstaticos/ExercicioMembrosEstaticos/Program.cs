using System;

namespace ExercicioMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double v = double.Parse(Console.ReadLine());

            double calculo = ConversorDeMoeda.CalculoDolar(c, v);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.CalcularImposto().ToString("F2"));
        }
    }
}
