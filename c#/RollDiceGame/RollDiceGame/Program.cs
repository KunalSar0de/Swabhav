using System;
namespace RandomNumGame
{
    class RandomNumGameTest
    {
        static void Main()
        {
        start:
            int userInput, randomNum, guessCount = 0;
            Random random = new Random();
            randomNum = random.Next(100);
            //Console.WriteLine("Random num:" + ran_num);
            Console.WriteLine("Hey user...Guess The Number:");
            for (; ; )
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                guessCount++;
                if (userInput == randomNum)
                {
                    Console.WriteLine
                    ("\nBravo!! You Guess Correct Number\nYou have tried " + guessCount + "times");
                    Console.WriteLine("\n\n1)Play Again \n2)Exit Game");
                    Console.WriteLine("Enter your choice:");
                    int c = Convert.ToInt32(Console.ReadLine());

                    switch (c)
                    {
                        case 1:
                            goto start;
                            break;
                        case 2:
                            Console.WriteLine("Thank You For Playing...");
                            break;
                        default:
                            Console.WriteLine("Wrong Choice!");
                            break;
                    }

                }
                else if (userInput < randomNum)
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