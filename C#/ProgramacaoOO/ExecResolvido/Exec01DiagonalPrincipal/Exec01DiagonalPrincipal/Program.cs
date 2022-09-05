using System;

namespace Exec01DiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int negativo = 0;

            for(int i = 0; i <n; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');

                for (int j = 0 ; j < n; j++)
                {
                    matrix[i, j] = int.Parse(valor[j]);
                    if (matrix[i,j] < 0)
                    {
                        negativo+=1;
                    }
                }
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write(matrix[i,i]+" ");
            }

            Console.WriteLine();
            Console.WriteLine(negativo);
        }
    }
}
