using System;

namespace ProblemaSemOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X: ");

            double ax, bx, cx;
            ax = double.Parse(Console.ReadLine());
            bx = double.Parse(Console.ReadLine());
            cx = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");

            double ay, by, cy;
            ay = double.Parse(Console.ReadLine());
            by = double.Parse(Console.ReadLine());
            cy = double.Parse(Console.ReadLine());

            //Conta X:
            double p = (ax + bx + cx) / 2.0;
            double areaX = Math.Sqrt(p * (p - ax) * (p - bx) * (p - cx));
            //Conta Y:
            p = (ay + by + cy) / 2.0;
            double areaY = Math.Sqrt(p * (p - ay) * (p - by) * (p - cy));

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
