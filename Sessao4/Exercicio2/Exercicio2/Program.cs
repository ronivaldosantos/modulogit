using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1, funcionario2;
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome:");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário:");
            funcionario2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome:");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário:");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salMedio = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.WriteLine("Salário médio:" + salMedio.ToString("F2",CultureInfo.InvariantCulture) );

        }
    }
}
