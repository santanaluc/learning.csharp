using System;

namespace MatrizExplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //indica que criará um arranjo bi dimensional
            /*double[,] mat = new double[2, 3];
            
            Console.WriteLine(mat.Length);

            //quanto é a primeira dimensão da matriz -- quantidade de linhas
            Console.WriteLine(mat.Rank);

            //Dimensão 0 da matriz tem tamanho 2
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));*/

            Console.Write("Digite o tamanho da matriz: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[,] mat = new int[tamanho, tamanho];
            Console.WriteLine();
            //Linhas
            for (int i = 0; i < tamanho; i++)
            {
                //criar um vetor com split
                string[] values = Console.ReadLine().Split(' ');

                //Colunas
                for (int j = 0; j < tamanho; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();
            Console.Write("Main diagonal: ");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for(int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.Write("Negative numbers: " + count);
            Console.WriteLine();
        }
    }
}
