using System;
using CourseAula137VirtualOverride.Entities;

namespace CouseAula135Heranca
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Account account1 = new Account(1001, "Alex", 500.00);
            Account account2 = new SavingsAccount(1002, "Anna", 500.00, 0.001);

            account1.Withdraw(10.0);
            account2.Withdraw(10.0);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);
        }
    }
}
