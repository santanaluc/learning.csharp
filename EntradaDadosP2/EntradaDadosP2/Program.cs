using System;
using System.Globalization;

namespace EntradaDadosP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); //Console.ReadLine não lê número, somente string
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            string[] vetor = Console.ReadLine().Split(" ");
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Voce digitou: " + n1);
            Console.WriteLine("Voce digitou: " + ch);
            Console.WriteLine("Voce digitou: " + n2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2"));
        }
    }
}
