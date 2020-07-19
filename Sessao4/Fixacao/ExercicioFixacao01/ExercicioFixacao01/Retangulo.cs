using System;

namespace ExercicioFixacao01
{
    class Retangulo
    {
        //propriedades
        public double Largura;
        public double Altura;

        //Métodos
        public double Area() {
            return Largura * Altura;        
        }

        public double Perimetro() {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
        
    }
}
