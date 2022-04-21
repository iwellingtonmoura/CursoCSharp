using System;
using CouseAula135Heranca.Entities;

namespace CouseAula135Heranca
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BusinessAccount businessAccount = new BusinessAccount(116792, "Wellington", 1000.0, 10000.00);

            Console.WriteLine(businessAccount.Balance);

            //Nào posso modificar pois a propriedade é Protected
            //businessAccount.Balance = 10000.00;
        }
    }
}
