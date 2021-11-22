using System;

namespace CrudableApp.Model
{
    class ProductDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("product data created");
        }

        public void Delete()
        {
            Console.WriteLine("Product data Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Product data read");
        }

        public void Update()
        {
            Console.WriteLine("Product data updated");
        }
    }
}
