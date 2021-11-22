using System;


namespace SimpleFactoryLib.Product
{
    internal class Tesla : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Tesla started");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla stop");
        }
    }
}
