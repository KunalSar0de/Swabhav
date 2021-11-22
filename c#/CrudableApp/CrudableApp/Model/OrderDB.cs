using System;


namespace CrudableApp.Model
{
    class OrderDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Order data created");
        }

        public void Delete()
        {
            Console.WriteLine("Order data deleted");
        }

        public void Read()
        {
            Console.WriteLine("Order data read");
        }

        public void Update()
        {
            Console.WriteLine("Order data update");
        }
    }
}
