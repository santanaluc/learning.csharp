using System;

namespace OperadorAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            a++;
            Console.WriteLine(a);

            a--;
            Console.WriteLine(a);
        }
    }
}
