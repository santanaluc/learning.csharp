using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;

            double y = x; // conversão implicita de tipos
            //float = 4 bytes e double 8bytes

            Console.WriteLine(y);

            double a;
            int b;

            a = 5.6;
            b = (int)a; //conversão explicita de tipo (casting)
            // se mudar um valor float/double para int, o valor é truncado
            Console.WriteLine(b);

            int c = 5;
            int d = 2;

            double resultado = (double) c / d;

            Console.WriteLine(resultado);
        }
    }
}
