using System;
using ThisPointerApp.Model;
namespace ThisPointerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player sachin = new Player("sachin",45,GenderType.Male);
            Player virat = new Player("virat");
            PrintDetails(sachin);
            PrintDetails(virat);
            Player elder = sachin.WhoIsElder(virat);
            PrintDetails1(elder);
            Console.ReadKey();
        }
        public static void PrintDetails(Player p)
        {
            Console.WriteLine("\nPlayer name: {0}",p.GetName());
            Console.WriteLine("Player Age: {0}", p.GetAge());
            Console.WriteLine("Player gender: {0}", p.GetGender());      
        }
        public static void PrintDetails1(Player p)
        {
            Console.WriteLine("\nElder player:");
            Console.WriteLine("Player name: {0}", p.GetName());
            Console.WriteLine("Player Age: {0}", p.GetAge());
            Console.WriteLine("Player gender: {0}", p.GetGender());        
        }
    }
}
