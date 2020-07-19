using System;
using System.Globalization;

namespace ExercicioFixacao02
{
    class Funcionario
    {
        //Propriedades
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        //Métodos
        public double SalarioLiquido() {
            return SalarioBruto - Imposto;        
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
        
    }
}
