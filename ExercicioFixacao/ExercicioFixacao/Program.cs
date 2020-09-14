using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: \n{0}, curjo preco é $ {1:F2} \n{2}, cujo preço é {3:F2}\n", produto1, preco1, produto2, preco2);
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}\n", idade, codigo, genero);
            Console.WriteLine("Medida com oito casas decimais: {0}",medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais): {0}", medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
