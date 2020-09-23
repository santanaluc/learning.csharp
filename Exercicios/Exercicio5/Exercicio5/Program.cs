using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.

            int peca1, numPeca1, peca2, numPeca2;
            double precoPec1, precoPec2;

            //peca 1
            string[] vet = Console.ReadLine().Split(' ');
            peca1 = int.Parse(vet[0]);
            numPeca1 = int.Parse(vet[1]);
            precoPec1 = double.Parse(vet[2]);

            //peca 2
            vet = Console.ReadLine().Split(' ');
            peca2 = int.Parse(vet[0]);
            numPeca2 = int.Parse(vet[1]);
            precoPec2 = double.Parse(vet[2]);

            double total = (numPeca1 * precoPec1) + (numPeca2 * precoPec2);

            Console.WriteLine("Valor a pagar: R$" + total.ToString("F2"));
        }
    }
}
