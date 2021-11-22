using System;
using IdApp.Model;

namespace IdApp
{
    class Program
    {
        public static void Main()
        {
            Customer c1 = new Customer("kunal", 1000f);
            PrintIdDetails(c1);
            Customer c2 = new Customer("vinay", 2000f);
            PrintIdDetails(c2);
            Customer c3 = new Customer("sagar", 4000f);
            PrintIdDetails(c3);
            PrintIdDetails(c2);
          
            Console.ReadKey();
        }
       

        public static void PrintIdDetails(Customer i)
        {
            Console.WriteLine("\nCustomer Id: {0}",i.InstanceCount);
            Console.WriteLine("Customer Name: {0}", i.GetName);
            Console.WriteLine("Customer Cash Amount: {0}", i.GetAmt);
        }
    }
}
