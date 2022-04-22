using System;
using CouseAula135Heranca.Entities;

namespace CouseAula135Heranca
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //BusinessAccount businessAccount = new BusinessAccount(116792, "Wellington", 1000.0, 10000.00);

            //Console.WriteLine(businessAccount.Balance);

            //Nào posso modificar pois a propriedade é Protected
            //businessAccount.Balance = 10000.00;


            //Exemplo Aula 136 UPCASTING / DOWNCASTING

            Account account1 = new Account(1001, "Alex", 0.0);
            BusinessAccount bccount2 = new BusinessAccount(1002, "Maria", 0.0, 5000.0);


            //UPCASTING

            account1 = bccount2;
            Account account3 = new BusinessAccount(1003, "Pedro", 0.0, 5000.0);
            Account account4 = new SavingsAccount(1004, "Tadeu", 0.0, 0.01);


            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)bccount2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if (account3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = account3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (account3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = account3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");

            }
        }
    }
}
