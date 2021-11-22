using System;


namespace FactoryMethodLib.Product
{
    internal class Audi : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Audi started");
        }

        public void Stop()
        {
            Console.WriteLine("Audi stop");
        }
    }
}
