using System;


namespace MovableApp.Model
{
    class Truck : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Truck is moving...");
        }
    }
}
