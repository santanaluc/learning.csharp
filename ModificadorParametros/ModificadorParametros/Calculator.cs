using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorParametros
{
    class Calculator
    {
        //Sem o params, precisaria instânciar o vetor no programa principal
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                sum += numbers[i];
            }

            return sum;
        }

        // ref vai tornar uma referência para a variável original. Sem ele retornará o mesmo valor inicial para a variável
        public static void Triple1(ref int x)
        {
            x = x * 3;
        }

        //out é similar ao ref, mas nao exige que a variável seja iniciada antes de declarada
        public static void Triple2(int inicial, out int result)
        {
            result = inicial * 3;
        }
    }
}
