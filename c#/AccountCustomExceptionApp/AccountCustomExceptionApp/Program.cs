using System;
using AccountCustomExceptionApp.Model;

namespace AccountCustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101, "Kunal", 5000);
            try
            {
                account.WithdrowAmt(4501);
            }
            catch(InsufficientFundsException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            finally
            {               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nWe still execute Print Details");
                PrintDetails(account);
            }
            Console.ReadLine();
        }

        public static void PrintDetails(Account a )
        {
            Console.WriteLine("Account No: {0}",a.AccNo);
            Console.WriteLine("Account Holder Name: {0}", a.Name);
            Console.WriteLine("Account Balance: {0}", a.Balance);
        }
    }
}
