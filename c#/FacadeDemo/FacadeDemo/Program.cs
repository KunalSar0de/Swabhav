using System;
using FacadeDemo.Model;

namespace FacadeDemo
{
    /*Façade is a general term for simplifying the outward appearance of a
    complex or large system.*/
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
            Console.ReadKey();
        }
    }
}
