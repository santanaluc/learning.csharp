using System;

namespace MatrizExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tamanho = Console.ReadLine().Split(' ');

            int M = int.Parse(tamanho[0]);
            int N = int.Parse(tamanho[0]);

            int[,] mat = new int[M, N];

            //Linhas
            for (int i = 0; i < M; i++)
            {
                //criar um vetor com split
                string[] values = Console.ReadLine().Split(' ');

                //Colunas
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int num = int.Parse(Console.ReadLine());
            //Posição
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(mat[i,j] == num)
                    {
                        Console.WriteLine("Position: " + i + ", " + j);

                        if (M > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Up: " + mat[i - 1, j]);
                    }
                    if (j < N - 1)
                    {
                        Console.WriteLine("Right: " + mat[i, j + 1]);
                    }
                    if (i < M - 1)
                    {
                        Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }
            }
        }
    }
}
