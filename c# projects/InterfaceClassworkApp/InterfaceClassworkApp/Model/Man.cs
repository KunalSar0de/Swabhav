using System;

namespace InterfaceClassworkApp.Model
{
    class Man : IManner
    {
        public void Depart()
        {
            Console.WriteLine("Man depart");
        }

        public void Wish()
        {
            Console.WriteLine("Man wishing");
        }
    }
}
