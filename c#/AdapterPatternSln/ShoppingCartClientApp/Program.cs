using System;
using ShoppingCartClientApp.Model;
using FancyItemExternalLib;


    
namespace ShoppingCartClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new ShoppingCart();
            c.AddItem(new HatToItemAdapter(new Hat("golden","golden ribben hat",500)));
            foreach(var items in c.Items)
            {
                Console.WriteLine("Name: {0}",items.ItemName());
                Console.WriteLine("Price: {0}", items.ItemPrice());
            }
            Console.ReadKey();

        }
    }
}
