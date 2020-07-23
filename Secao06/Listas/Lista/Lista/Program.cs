using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); // Criou ou lista vazia.

            //Método Add - Adcionar elemento na lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ann");

            // percorrer a lista
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
