using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());

            if (a.Nota1 > 30 || a.Nota2 > 35 || a.Nota3 > 35)
            {
                Console.WriteLine("Verifique as notas digitadas e tente novamente");
                return;
            } else
            {
                Console.WriteLine("NOTA FINAL = " + a.CalcularNota().ToString("F2"));

                if (a.Aprovado())
                {
                    Console.WriteLine("APROVADO");
                }
                else
                {
                    Console.WriteLine("Reprovado!\nFaltaram " + a.SituacaoFinal().ToString("F2") + " pontos");
                }
            }            
        }
    }
}
