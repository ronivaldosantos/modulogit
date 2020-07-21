using System;
using System.Globalization;

namespace ExemploVetor02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Vetor da classe produtos
            Product[] vect = new Product[n];

            //Preenche o vetor de produtos com as informações digitadas.
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Intanciado o produto sem a atulização de construtor, instaciação direta.
                vect[i] = new Product { Nome = name, Price = price };
            }

            //Percorrer o vetor de produtos para encontrar o preço médio
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            //Obtem preço médio.
            double avg = sum / n;

            Console.WriteLine("Preço médio:" + avg.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
