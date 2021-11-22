using System;


namespace CrudableApp.Model
{
    abstract class CustomerDB : ICrudable
    {
        public  void Create()
        {
            Console.WriteLine("Customer data created");
        }

        public void Read()
        {
            Console.WriteLine("Customer data read");
        }
        public abstract void Delete();
        public abstract void Update();
       
    }
}
