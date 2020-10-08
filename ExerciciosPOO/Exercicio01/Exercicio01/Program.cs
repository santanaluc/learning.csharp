using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("ÁREA = " + ret.Area().ToString("F2"));
            Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2"));
        }
    }
}
