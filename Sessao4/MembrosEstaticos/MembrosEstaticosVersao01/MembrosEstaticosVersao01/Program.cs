using System;
using System.Globalization;

namespace MembrosEstaticosVersao01
{
    class Program
    {
        // Pi deve ser static por que será usado dentro de um método static
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2",CultureInfo.InvariantCulture));

            double volume = Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + Pi.ToString("F2",CultureInfo.InvariantCulture) );
        }

        //Deve ser static por que será chamada em um método static.
        static double Circunferencia(double r) {
            return 2.0 * Pi * r;        
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r; 
        }


    }
}
