using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null; // Nullable<double>
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Operador de coalescência nula = "??"
            double a = x ?? 5;
            double b = y ?? 5;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            } else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }
        }
    }
}
