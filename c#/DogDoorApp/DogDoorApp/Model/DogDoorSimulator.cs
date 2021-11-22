using System;
using System.Threading;

namespace DogDoorApp.Model
{
    class DogDoorSimulator
    {
        public static void DogOutsideTime(int dogOutsideTime)
        {
            DogDoor dogDoor = new DogDoor();
            Remote remote = new Remote(dogDoor);
            Console.WriteLine("Fido barks to go outside");
            remote.PressButton();
            Console.WriteLine("\nFido has gone outside for " + dogOutsideTime / 1000 + " seconds");
            Thread.Sleep(dogOutsideTime);
            Console.WriteLine("\nFido's all done ...");
            
            bool fidoBark = true;
            while (!dogDoor.IsOpen())
            {
                if (fidoBark)
                {
                    Console.WriteLine("\nBut he's stuck outside!");
                    Console.WriteLine("\nFido starts barking ...");
                    fidoBark = false;
                    Console.WriteLine("\nSo Gina grabs the remote control ...");
                    remote.PressButton();
                }
            }
            Console.WriteLine("\nFido's back inside ...");       
        }
    }
}
