using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int quarto = 0;
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Estudante[] vect = new Estudante[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel + #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();                
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());

                Console.WriteLine();

                for (int z = 0; z < 9; z++)
                {
                    if (quarto == z)
                    {
                        vect[z] = new Estudante { Nome = nome, Email = email };                        
                    }
                }
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 9; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i
                                       + ":"
                                       + vect[i].Nome
                                       + ", "
                                       + vect[i].Email
                                       );
                }
            }

            Console.ReadLine();
        }
    }
}
