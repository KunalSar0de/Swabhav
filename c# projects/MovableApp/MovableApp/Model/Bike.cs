using System;


namespace MovableApp.Model
{
    class Bike : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bike is moving...");
        }
    }
}
