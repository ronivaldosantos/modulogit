using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Declaração de matriz tamanho n X n.
            int[,] mat = new int[n, n];

            // Percorre as linas da matriz
            for (int i = 0; i < n; i++)
            {
                //Fazendo a leitura da linha digitada
                string[] values = Console.ReadLine().Split(' ');

                //Percorre as colunas da matriz
                for (int j = 0; j < n; j++)
                {
                    //Insere valores na Matriz
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int negative = 0;
            //Percorrer a matriz para imprimir os números negativos
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //Quantidade números negativos na matriz
                    if (mat[i, j] < 0)
                    {
                        negative++;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Negative numbers = " + negative);
        }
    }
}
