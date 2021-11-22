using System;
using CrudableApp.Model;

namespace CrudableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDBOperation(new ProductDB());
            DoDBOperation(new OrderDB());
            DoDBOperation(new PremiumCustomerDB());
            Console.ReadLine();
        }
        public static void DoDBOperation(ICrudable obj)
        {
            Console.WriteLine("\nDb Operations:");
            obj.Create();
            obj.Read();
            obj.Update();
            obj.Delete();
        }
    }
}
