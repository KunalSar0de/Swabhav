using System;


namespace SimpleFactoryLib.Product
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
