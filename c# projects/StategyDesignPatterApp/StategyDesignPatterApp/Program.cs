using System;
using StategyDesignPatterApp.Model;

namespace StategyDesignPatterApp
{
    class Program
    {
        static void Main()
        {         
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
            Console.ReadKey();
        }
    }
}
