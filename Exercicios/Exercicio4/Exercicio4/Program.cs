using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            //decimais.

            int numFuc, horas;
            double valorHora, salario;

            numFuc = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine());
            salario = valorHora * horas;

            Console.WriteLine("NUMBER = " + numFuc);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}
