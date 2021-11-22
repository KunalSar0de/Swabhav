using System;
using InterfaceClassworkApp.Model;

namespace InterfaceClassworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Boy boy = new Boy();
            Man man = new Man();
            AtThePartyHall(boy);
            AtThePartyHall(man);
            AtTheCenemaHall(boy);
            //AtTheCenemaHall(man);
            Console.ReadLine();
        }

        public static void AtThePartyHall(IManner obj)
        {
            Console.WriteLine("\nAt Party Hall");
            obj.Wish();
            obj.Depart();
        }
        public static void AtTheCenemaHall(IEmotion obj)
        {
            Console.WriteLine("\nAt Cenema Hall");
            obj.Cry();
            obj.Laugh();
        }
    }
}
