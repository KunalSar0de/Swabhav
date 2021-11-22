using System;

namespace RuleTwoApp
{
    class DrinkManager
    {
        public void AskForDrink()
        {
            while (true)
            {
                Console.WriteLine("\nwhich drink do you wont?(beer,juice)");
                string input = Console.ReadLine();
                if (input.Equals("beer"))
                {
                    Console.WriteLine("Whats your age??");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age < 18)
                    {
                        Console.WriteLine("Heyy buddy,You are not old enough to drink beer!!");
                    }
                    else
                    {
                        Console.WriteLine("Serving beer for you!!");
                    }
                }
                else if (input.Equals("juice"))
                {
                    Console.WriteLine("Which juice you wont?(1,2)\n1)Lemon juice\n" +
                        "2)Orange Juice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Serving Lemon Juice");
                    }
                    else
                    {
                        Console.WriteLine("Serving Orange Juice");
                    }
                }
                else
                {
                    Console.WriteLine("Drink is not available");
                }
            }
        }


        public void AskForDrinkRuleSolution()
        {
            while (true)
            {
                Console.WriteLine("\nwhich drink do you wont?(beer,juice)");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "beer":
                        BeerServeMethod();
                        break;
                    case "juice":
                        JuiceServeMethod();
                        break;
                    default:
                        Console.WriteLine("Entered Wrong Drink...");
                        break;
                }               
            }
        }

        private static void JuiceServeMethod()
        {
            Console.WriteLine("Which juice you wont?(1,2)\n1)Lemon juice\nOrange Juice");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Serving Lemon Juice");
                return;
            }
            Console.WriteLine("Serving Orange Juice");
        }

        private static void BeerServeMethod()
        {
            Console.WriteLine("Whats your age??");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 18)
            {
                Console.WriteLine("Heyy buddy,You are old enough to drink beer!!");
                return;
            }            
            Console.WriteLine("Serving beer for you!!");           
        }
    }
}
