using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char sn = char.Parse(Console.ReadLine());

            if (sn == 's' || sn == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                c = new ContaBancaria(numero, nome, deposito);
            } else
            {
                c = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            c.Deposito(valorDeposito);
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            c.Saque(valorSaque);
            Console.WriteLine();
            Console.WriteLine(c);
        }
    }
}
