using System;


namespace CrudableApp.Model
{
    class PremiumCustomerDB:CustomerDB
    {
       

        public override void Delete()
        {
            Console.WriteLine("Premium Customer data deleted");
        }

        public override void Update()
        {
            Console.WriteLine("Premium Customer data Updated");
        }
    }
}
