using System;
using HerancaExemplo.Entities;

namespace HerancaExemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01); // UpCasting

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            Console.WriteLine("---------------------");

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);


            // *********** INÍCIO - Exemplos UpCasting e DowCasting **********************
           /* Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcasting - Conversão da subClasse para superClasse
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);


            //DownCasting - Conversão da superClasse para subClasse (Tem que indicar o Casting.
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // Não compila pois as classe não são compatíveis, tipos diferentes
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount) 
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }
            **************** FIM Exemplos ********************************************************    */






        }
    }
}
