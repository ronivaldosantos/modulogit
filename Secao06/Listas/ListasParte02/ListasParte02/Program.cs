using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasParte02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria");  // Adciona o elemento no sequencial.
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco"); // Adciona o elemento na posição definida.
            
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List count: " + list.Count); // Tamanho da lista.

            Console.WriteLine("-------------------------------------------");

            string s1 = list.Find(x => x[0] == 'A'); // Expressão lambda (x => x[0] == 'A') Trazer o resultado
                                                     // Quando o primeiro da lista x na posição 0 for igual a 'A'       

            Console.WriteLine("First 'A' = " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' = " + s2); // Quando o último da lista x na posição 0 for igual a 'A'       
                        
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);
                     
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            // Criar uma nova lista baseada na primeira com os elementos que atendam o predicado
            Console.WriteLine("------------------------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }
 /*
            Console.WriteLine("------------------------------------------");

            // Remover um ítem da lista
            list.Remove("Alex");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------");
       
            // Remover todos os itens que atendem um predicado
            list.RemoveAll(x => x[0] == 'M');
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------");

            // Remover na posição determinada
            list.RemoveAt(1);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            */
            Console.WriteLine("------------------------------------------");

            

            // A partir de uma contagem remover quantos elementos desejar
            list.RemoveRange(1, 2);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}
