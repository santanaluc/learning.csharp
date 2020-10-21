using System;

namespace InferenciaTiposVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10; //int
            var y = 20.0; //double
            var z = "Maria"; //string

            int w = z;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);
        }
    }
}
