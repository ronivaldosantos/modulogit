using System;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        //Propriedades
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double SaldoDaConta { get; private set; }

        public Conta(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public Conta(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta,nomeTitular)
        {
            Deposito(depositoInicial);
        }
        
        //Métodos
        public void Deposito(double valor)
        {           
            SaldoDaConta += valor;           
        }

        public void Saque(double valor) {
            SaldoDaConta -= valor + 5.0;
        }

        //Retorna os dados da conta
        public override string ToString()
        {
            return "Conta: "     
                 + NumeroConta
                 + ", Titular: " + NomeTitular
                 + ", Saldo: $ " + SaldoDaConta.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
