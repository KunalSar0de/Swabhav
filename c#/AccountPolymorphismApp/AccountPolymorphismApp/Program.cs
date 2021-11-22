using System;
using AccountPolymorphismApp.Model;

namespace AccountPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount acc1 = new SavingAccount(101, "kunal", 1000);
            PrintDetalis(acc1);
            CurrentAccount acc2 = new CurrentAccount(102, "vinay", 3000);
            PrintDetalis(acc2);

            acc1.WithdrowAmount(501);
            PrintDetalis(acc1);

            acc2.WithdrowAmount(4200);
            PrintDetalis(acc2);

            Console.ReadLine();
        }
        public static void PrintDetalis(Account a)
        {
            Console.WriteLine("\nAcc no: {0}",a.AccNo);
            Console.WriteLine("Name: {0}", a.Name);
            Console.WriteLine("Balance: {0}", a.Balance);
        } 

    }
}
