using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (inicio; condicao; incremento)
             --inicio = só executa na primeira vez
                --condicao (mesma coisa do while)
                    --incremento = vai executar toda vez que voltar*/

            int n;

            Console.Write("Quantos números inteiros você vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}
