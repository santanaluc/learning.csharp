using System;

namespace ProblemaSemOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X: ");

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
            
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            //Conta X:
            double areaX = x.Area();
            //Conta Y:
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4"));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("Área maior: X");
            } else
            {
                Console.WriteLine("Área maior: Y");
            }
        }
    }
}
