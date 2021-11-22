using System;
namespace RandomNumGame
{
    class RandomNumGameTest
    {
        static void Main()
        {
                int Num, randomNumber, triesCount = 0;
                Random random = new Random();
                randomNumber = random.Next(1, 100);
                Console.WriteLine("Random number:" + randomNumber);
                Console.WriteLine("\nHey user...Guess The Number:");
                for (; ; )
                {
                    Num = Convert.ToInt32(Console.ReadLine());
                    triesCount++;
                    if (Num == randomNumber)
                    {
                        Console.WriteLine("\nBravo!! You Guess Correct Number...");
                        Console.WriteLine("You have tried " + triesCount + " times");
                        Console.WriteLine("\n\n1)Play Again \n2)Exit Game");
                        Console.WriteLine("Enter your choice:");
                        int c = Convert.ToInt32(Console.ReadLine());
                        switch (c)
                        {
                            case 1:
                                Main();
                                break;
                            case 2:
                                Console.WriteLine("Thank You For Playing...");
                                break;
                            default:
                                Console.WriteLine("Wrong Choice!");
                                break;
                        }

                    }
                    else if (Num < randomNumber)
                    {
                        Console.WriteLine("Sorry!! Too Low");
                    }
                    else
                    {
                        Console.WriteLine("Sorry!! Too High");
                    }
                }
                Console.ReadLine();
            }
        
    }
}
