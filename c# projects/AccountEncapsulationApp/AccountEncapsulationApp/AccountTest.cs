using System;
using AccountEncapsulationApp.Module;

namespace AccountEncapsulationApp
{
    class AccountTest
    {
        static void Main()
        {           
            Account[] a=new Account[4];

            a[0] = new Account("kunal", 101, 1000);
            //a[0].DepositAmt(5700.86);
            //a[0].WithdrowAmt(1008);
            a[1] = new Account("vinay", 102, 2000);
            //a[1].DepositAmt(7000);            
            a[2] = new Account("sohan", 103, 6000);
            a[2].DepositAmt(1800);
            a[3] = new Account("arbaz", 104, 3500);
            a[3].DepositAmt(1200);
            //a[3].WithdrowAmt(705);

            Console.WriteLine("\nUser Account Info:");
            PrintArrayInfo(a);
            WithdrowErrorMsg(a);
            DistributeOther(a);           
            Console.ReadKey();         
        }

        public static void DistributeOther(Account[] a)
        {
            int count = 0;
            double remainingAmt,distAmt;
            double richUserAmount = a[0].GetBalance();
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i].GetBalance() > richUserAmount)
                {
                    richUserAmount = a[i].GetBalance();
                    count = i;
                }
            }         
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.WriteLine("Rich User!!");
            Console.WriteLine("Account Holder Name: {0} , Account No: {1} , User Balance: {2}"
                , a[count].GetName(), a[count].GetAccountNum(),a[count].GetBalance());
            Console.WriteLine("---------------------------------------------------------------------------------\n");
            
            //Distribution calculation
            remainingAmt = richUserAmount - 500;
            distAmt = remainingAmt / (a.Length-1);
            Console.WriteLine("Distribution Amount: {0:F2} ",distAmt);
            Console.WriteLine("\nUpdated Accounts");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == a[count])
                {
                    a[count].WithdrowAmt(remainingAmt);
                }
                else
                {
                    a[i].DepositAmt(distAmt);
                }
            }
            PrintArrayInfo(a);
        }

        public static void PrintArrayInfo(Account[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                PrintDetails(a[i]);               
            }           
        }

        public static void PrintDetails(Account a)
        {
            Console.WriteLine("\nAccount Number: {0}", a.GetAccountNum());
            Console.WriteLine("Account Holders Name: {0}", a.GetName());
            Console.WriteLine("Current Balance: {0:F2}", a.GetBalance());
        }  
        
        public static void WithdrowErrorMsg(Account[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].GetWithdrowError() == true)
                {
                    a[i].WithdrowError();
                }
            }
        }
    }
}
