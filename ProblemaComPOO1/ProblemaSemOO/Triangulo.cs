using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaSemOO
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //Acrescentando um método para o calculo do triângulo
        public double Area()
        {
            double p = (A + B + C) / 2.00;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
