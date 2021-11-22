using DecoratorPatternApp.Component;
using System;

namespace DecoratorPatternApp
{
    class ConsolePrinter
    {
        public void PrintDetailsOfHat(IHat hat)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Hat Name : {0}", hat.GetName());
            Console.WriteLine("Hat Description : {0}", hat.GetDiscription() + " Hat");
            Console.WriteLine("Hat Price : {0}", hat.GetPrice());
        }
    }
}
