using System;


namespace RuleTwoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkManager drinkManager = new DrinkManager();
           // drinkManager.AskForDrink();
            drinkManager.AskForDrinkRuleSolution();
            Console.ReadKey();
        }
    }
}
