using System;
using System.Linq;

namespace IntroducaoLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };//data source

            //Define the query expression
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
