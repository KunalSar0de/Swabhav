using System;
using DIPSolutionApp.CommonModel;
using DIPSolutionApp.HighLevelModel;
using DIPSolutionApp.LowLevelModel;


namespace DIPSolutionApp
{
    class Program
    {
        static void Main()
        {     
            var calc = new TaxCalculator(new DBLogger());
            Console.WriteLine(calc.CalculateTax(10, 5));
            Console.WriteLine(calc.CalculateTax(10, 0000));
            Console.ReadKey();
        }
    }
}
