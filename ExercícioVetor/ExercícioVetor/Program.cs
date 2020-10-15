using System;

namespace ExercícioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] vect = new Quartos[10];
            
            Console.Write("Quantos quartos serão reservados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                int numRoom = i + 1;
                Console.WriteLine("Aluguel #" + numRoom);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                Console.WriteLine();

                vect[room] = new Quartos(name, email);
            }

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
