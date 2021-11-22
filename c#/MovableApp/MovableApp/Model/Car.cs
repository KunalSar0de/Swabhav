using System;


namespace MovableApp.Model
{
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving...");
        }
    }
}
