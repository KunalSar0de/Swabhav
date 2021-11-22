using System;
using SrpViolation.Model;

namespace SrpViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice i = new Invoice(1,"solar power invoice",100000,10f,50f);
            i.PrintDetails();
            Console.ReadKey();
        }
    }
}
