using System;

namespace Sessao4
{
    class Triangulo
    {
        //Atributos do Triângulo:
        public double A;
        public double B;
        public double C;

        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));            
        }
    }
}
