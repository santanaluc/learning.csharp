using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = new string[] { "Maria", "Bob", "Alex" };

            Console.WriteLine("FOREACH:");
            //Para cada objeto 'obj' contido em vet, faça:
            foreach (string obj in vet)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            Console.WriteLine("FOR NORMAL:");
            //Com for normal:
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}
