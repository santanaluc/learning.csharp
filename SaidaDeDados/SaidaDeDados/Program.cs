using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 20;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2")); // limitar o número de casas depois da virgula
            Console.WriteLine(nome);
            Console.WriteLine("Saldo com 4 casas: " + saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // mudar o separador de decimais
            Console.WriteLine("");
            Console.WriteLine("=============================================================");
            Console.WriteLine("");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2:F2} reais",nome, idade, saldo); // PLACEHOLDER

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); // INTERPOLAÇÃO

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais"); //Concatenacao
        }
    }
}
