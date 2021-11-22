using System;
using AccountSerializationApp.Model;

namespace AccountSerializationApp
{
    class Program
    {
        static void Main()
        {
            Account a = new Account("kunal", 101, 1000);
            Console.WriteLine("Before Deposit:");
            Console.WriteLine("Account Number: {0} , Account Holders Name: {1} , Current Balance: {2:F2}", a.GetAccountNum, a.GetName, a.GetBalance);
            a.DepositAmt = 200;
            Console.WriteLine("\nAfter Deposit:");
            Console.WriteLine("Account Number: {0} , Account Holders Name: {1} , Current Balance: {2:F2}", a.GetAccountNum,a.GetName,a.GetBalance);
            
       
            string filePath = @"E:\swabhav\c#\OOP\AccountSerializationApp\data.txt";
            
            //object creatiion for data serializer
            DataSerializer dataSerializer = new DataSerializer();           
            //Serialization of object
            dataSerializer.BinarySerialize(a, filePath);
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Serializing object...");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Object stored in data.txt file ...");
            //Deserialization of object
            Account p = null;
            p = dataSerializer.BinaryDeSerialize(filePath) as Account;  
            PrintDetailsDeserialize(p);         
            Console.ReadKey();
        }

        
       
        public static void PrintDetailsDeserialize(Account p)
        {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Deserializing object...");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Account Number: {0}", p.GetAccountNum);
            Console.WriteLine("Account Holders Name: {0}", p.GetName);
            Console.WriteLine("Current Balance: {0:F2}", p.GetBalance);
        }
    }
}
