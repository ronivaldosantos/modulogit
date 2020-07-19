using System;
using System.Globalization;

namespace Sessao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            //Lados do triângulo x
            Console.WriteLine("Entre com as medidas do triângulo x:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Lados do triângulo y
            Console.WriteLine("Entre com as medidas do triângulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Calcula da área do triangulo x:            
            double areax = x.Area();

            //Calcula da área do triangulo y:            
            double areay = y.Area();

            //Imprimindo área de x
            Console.WriteLine("Área de X = " + areax.ToString("F4",CultureInfo.InvariantCulture));

            //Imprimindo área de y
            Console.WriteLine("Área de Y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

            //Mostrar a Maior área

            if (areax > areay)
            {
                Console.WriteLine("Maior área é X");
            }
            else
            {
                Console.WriteLine("Maior área é Y");
            }

        }
    }
}
