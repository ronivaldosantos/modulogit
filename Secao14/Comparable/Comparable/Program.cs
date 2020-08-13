using System;
using System.Collections.Generic;
using System.IO;
using Comparable.Entities;

namespace Comparable
{
    class Program 
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\roniv\Documents\CursoCCharp\Secao14\in.txt";

            try
            {
                using( StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    //Ordena a lista.
                    list.Sort();

                    foreach (Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An erro ocorred");
                Console.WriteLine(e.Message);
            }
        }

    }
}
