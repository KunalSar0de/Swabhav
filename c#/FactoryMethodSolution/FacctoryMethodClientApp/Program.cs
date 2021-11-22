using System;
using FactoryMethodLib.Factory;
using FactoryMethodLib.Product;

namespace FacctoryMethodClientApp
{
    class Program
    {
        static void Main()
        {
            /*var autoFactory1 = JaguarFactory.GetInstance();            
            IAuto auto = autoFactory1.Make();
            auto.Start();
            auto.Stop();
            Console.WriteLine(autoFactory1.GetHashCode());

            Console.WriteLine("\n");

            var autoFactory2 = JaguarFactory.GetInstance();
            IAuto auto2 = autoFactory2.Make();
            auto2.Start();
            auto2.Stop();
            Console.WriteLine(autoFactory2.GetHashCode());*/

            //inputs from app.config

            Reflector reflector = new Reflector();
            IAutoFactory autoFactory1 = reflector.GetFactory();
            IAuto auto = autoFactory1.Make();
            auto.Start();
            auto.Stop();

            Console.ReadKey();
        }
        
    }
}
