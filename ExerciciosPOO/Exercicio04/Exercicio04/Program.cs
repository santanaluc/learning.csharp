using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c = new ContaBancaria();

            Console.Write("Entre com o número da conta: ");
            c.Conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            c.Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char sn = char.Parse(Console.ReadLine());

            if (sn == 's')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                c.Deposito(deposito);
            } else
            {
                return;
            }

            Console.WriteLine(c);
        }
    }
}
