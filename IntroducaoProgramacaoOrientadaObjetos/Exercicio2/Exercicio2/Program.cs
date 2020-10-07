using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios a, b, c;
            a = new Funcionarios();
            b = new Funcionarios();
            c = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine());

            double media = c.MediaSalario(a.Salario, b.Salario);

            Console.WriteLine("Salário médio = " + media.ToString("F2"));
        }
    }
}
