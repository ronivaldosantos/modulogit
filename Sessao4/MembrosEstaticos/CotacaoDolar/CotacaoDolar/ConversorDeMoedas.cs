
namespace CotacaoDolar
{
    class ConversorDeMoedas
    {
        //Propriedades
        public static double Cotacao;
        public static double QuantidadeDolares;
        public static double Iof = 0.06;

        //Método
        public static double CalculaValorReal() { 
         return (Cotacao * QuantidadeDolares) + (Cotacao * QuantidadeDolares) * Iof;        
        }
    }
}
