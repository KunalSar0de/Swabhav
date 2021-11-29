using System;
using AccountEventLib;

namespace AccountEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Account account = new Account(101,"Kunal",2000);
                  
            account.OnBalanceChanged += PrintDetails;            
            account.OnBalanceChanged += SendMail;
            account.OnBalanceChanged += StoreInDatabase;
            account.DepositAmount(3000);
            Console.ReadKey();
        }
        public static void PrintDetails(Account account)
        {
            Console.WriteLine("Printing Details..");
            Console.WriteLine("Account Number : {0}",account.AccNo);
            Console.WriteLine("Account Holder Name : {0}", account.Name);
            Console.WriteLine("Account Balance : {0}", account.AccBalance);
        }
        public static void SendMail(Account account)
        {
            Console.WriteLine("\nSending Mail...");
            Console.WriteLine("Mail send to Account Number {0} Current " +
                "Balance is {1}",account.AccNo,account.AccBalance);            
        }
        public static void StoreInDatabase(Account account)
        {
            Console.WriteLine("\nStorin data in database..");
            Console.WriteLine("Data stored in databse as Account Number {0} Account Name {1} Current " +
                "Balance is {2}", account.AccNo,account.Name, account.AccBalance);
        }
    }
}
