using System;
using DIPViolationApp.Model;

namespace DIPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator(LogType.FileLogger);
            Console.WriteLine(calc.CalculateTax(10, 5));
            Console.WriteLine(calc.CalculateTax(10,0000));
            Console.ReadKey();
        }
    }
}
