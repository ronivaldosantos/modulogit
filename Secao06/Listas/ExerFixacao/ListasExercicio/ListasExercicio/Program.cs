using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListasExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int quantida = int.Parse(Console.ReadLine());

            //Instanciar lista vazia
            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= quantida; i++)
            {
                Console.WriteLine($"Emplyoee #{i}:");
                Console.Write("Id:");
                int idFunc = int.Parse(Console.ReadLine());
                Console.Write("Name:");
                string nameFunc = Console.ReadLine();
                Console.Write("Salary:");
                double salaryFunc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                //Adciona na lista os funcionário informados
                list.Add(new Funcionario(idFunc,nameFunc, salaryFunc));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase :");
            int idIncrease = int.Parse(Console.ReadLine());

            //Pesuisa se na lista existe o Id informado
            Funcionario func = list.Find(x => x.Id == idIncrease);
            if (func != null)
            {
                Console.Write("Enter the percentage:");
                double perct = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                func.IncreaseSalary(perct);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            //Percorre a lista e imprime todos os funcionários.
            foreach (Funcionario item in list)
            {
                Console.WriteLine(item);
            }
                        
        }
    }
}
