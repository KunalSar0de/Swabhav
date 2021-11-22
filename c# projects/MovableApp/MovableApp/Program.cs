using System;
using MovableApp.Model;

namespace MovableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable[] mov = new IMovable[4];
            mov[0] = new Car();
            mov[1] = new Truck();
            mov[2] = new Bike();
            mov[3] = new Car();
            StartRace(mov);
            Console.ReadLine();
        }

        public static void StartRace(IMovable[] mo)
        {
            for(int i = 0; i < mo.Length; i++)
            {

            }

            foreach(IMovable m in mo)
            {
                m.Move();
            }
        }
       
    }
}
