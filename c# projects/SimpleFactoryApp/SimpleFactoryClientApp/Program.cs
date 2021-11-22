using System;
using SimpleFactoryLib.Factory;

namespace SimpleFactoryClientApp
{
    class Program
    {
        static void Main()
        {
            var factory = AutomobileFactory.GetInstance();
            var auto = factory.Make(AutoType.TESLA);
            auto.Start();
            auto.Stop();
            Console.WriteLine(factory.GetHashCode());
            Console.WriteLine("\n");
            var factory1 = AutomobileFactory.GetInstance();
            var auto1 = factory1.Make(AutoType.BMW);
            auto1.Start();
            auto1.Stop();
            Console.WriteLine(factory1.GetHashCode());
            Console.ReadKey();
        }
    }
}
