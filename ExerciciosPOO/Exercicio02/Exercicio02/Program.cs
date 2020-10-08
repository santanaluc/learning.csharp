using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + f.Nome + ", $" + f.SalarioLiquido().ToString("F2"));
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumentar = double.Parse(Console.ReadLine());
            f.AumentarSalario(aumentar);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}
