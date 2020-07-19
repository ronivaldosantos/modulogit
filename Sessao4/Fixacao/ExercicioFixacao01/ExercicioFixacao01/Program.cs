using System;
using System.Globalization;

namespace ExercicioFixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Área= " + ret.Area());
            Console.WriteLine("Perímetro = " + ret.Perimetro());
            Console.WriteLine("Diagonal = " + ret.Diagonal());

        }
    }
}
