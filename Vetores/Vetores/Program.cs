using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos? ");
            int n = int.Parse(Console.ReadLine());

            Produtos[] vetor = new Produtos[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                vetor[i] = new Produtos { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("Valor média = " + media.ToString("F2"));
        }
    }
}
