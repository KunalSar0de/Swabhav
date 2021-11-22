using System;
using DecoratorPatternApp.Component;
using DecoratorPatternApp.ConcreteComponent;
using DecoratorPatternApp.ConcreteDecorator;

namespace DecoratorPatternApp
{
    class Program
    {
        static void Main()
        {
            IHat hat1 = new RibbonHat(new GoldenHat(new PremiumHat()));
            IHat hat2 = new RibbonHat(new StandardHat());
            //printing Details of Hat
            ConsolePrinter consolePrinter = new ConsolePrinter();
            consolePrinter.PrintDetailsOfHat(hat1);
            consolePrinter.PrintDetailsOfHat(hat2);
            Console.WriteLine();
        }
    }
}
