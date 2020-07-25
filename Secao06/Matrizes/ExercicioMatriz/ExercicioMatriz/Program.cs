using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os valores M e N da matriz separados por espaço: ");
            string[] tamanho = Console.ReadLine().Split(' ');

            int m = int.Parse(tamanho[0]);
            int n = int.Parse(tamanho[1]);

            int[,] mat = new int[m, n];

            Console.WriteLine("Informe os valore para a matriz: ");

            // Preenche as os valores na matriz.
            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Informe um número pertencente a matriz: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (numero == mat[i, j] )
                    {
                        //Linha/coluna onde está o número informado.
                        Console.Write("Position: " + i + "," + j);
                        Console.WriteLine();

                        //Primeiro a esquerda do número
                        if (j > 0)                        {
                            Console.Write("Left: " + mat[i, j - 1]);
                            Console.WriteLine();
                        }

                        //Primeiro acima do número
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                        //Primeiro a direita do número
                        if (j < n -1)
                        {
                            Console.Write("Right: " + mat[i, j + 1]);
                            Console.WriteLine();
                        }
                      
                        //Primeiro abaixo do número
                        if (i < m -1) 
                        {
                            Console.WriteLine("Down: " + mat[i + 1 ,j] );                        
                        }
                    }
                }
            }
        }
    }
}
