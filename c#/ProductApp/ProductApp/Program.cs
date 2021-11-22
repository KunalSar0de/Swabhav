using System;
using ProductApp.Model;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            Case2();
            Console.WriteLine("\nAll over count after case1 and case 2: {0}",Product.GetCount);
            Console.ReadLine();
        }
        public static void Case1()
        {
            Product p1 = new Product(101,"Head first Java",200);
            Product p2 = new Product(102, "Head first C#", 500,2f);
            PrintDetails(p1);
            PrintDetails(p2);
        }
        public static void Case2()
        {
            Product p1 = new Product(101, "Head first Java", 200);
            Console.WriteLine("Count : {0}",p1.GetInstanceCount);
            Console.WriteLine("static count: {0}",Product.GetCount);
            Product p2 = new Product(102, "Head first C#", 500, 0.6f);
            Console.WriteLine("Count : {0}", p2.GetInstanceCount);
            Console.WriteLine("static count: {0}", Product.GetCount);
            Product p3 = new Product(103, "Head first", 800, 0.9f);
            Console.WriteLine("Count : {0}", p3.GetInstanceCount);
            Console.WriteLine("static count: {0}", Product.GetCount);
        }

        public static void PrintDetails(Product p)
        {
            Console.WriteLine("\nProduct Id: {0}",p.ProductId);
            Console.WriteLine("Product Name: {0}", p.GetPName);
            Console.WriteLine("Product  Price: {0} ", p.GetPrice);           
            Console.WriteLine("Product final Price: {0}", p.CalculateFinalPrice());
        }
    }
}
