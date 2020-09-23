using System;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu ultimo nome, idade e altura:");
            string[] vetor = Console.ReadLine().Split(' ');
            string sobrenome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2]);

            Console.WriteLine("================================");
            Console.WriteLine(nome + "\n" + quartos + "\n" + preco.ToString("F2") + "\n" + sobrenome + "\n" + idade + "\n" + altura.ToString("F2"));
        }
    }
}
