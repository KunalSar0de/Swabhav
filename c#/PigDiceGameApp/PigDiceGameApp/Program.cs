using System;
namespace PigDiceGameApp
{
    class Program
    {
        static readonly int target = 20;
        
        private static int GameTurns(int currentScore)
        {
            
            int randomNumber;
            Random RandomNumGenerator = new Random();
            char turn;
            while (true)
            {
                Console.Write("Roll or hold ? (r / h) : ");
                turn = Console.ReadLine()[0];
                if (turn == 'r')
                {
                    randomNumber = RandomNumGenerator.Next(1, 7);
                    Console.WriteLine("Dice Rolled: {0} ", randomNumber);
                    if (randomNumber != 1)
                    {
                        currentScore += randomNumber;
                        Console.WriteLine("Score Now: {0}\n",currentScore);
                        if (currentScore >= target)
                        {
                            return currentScore;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you rolled 1, Your this turn score  is 0 now!!");
                        currentScore = bucketScore;
                        return currentScore;
                    }
                }
                else if (turn == 'h')
                {
                    Console.WriteLine("Total score=" + currentScore);
                    bucketScore = currentScore;
                    return currentScore;
                }
            }
        }
        static int bucketScore;
        static void Main()
        {
            
            Console.Clear();
            int currentScore = 0;
            int turnCount = 0;
           
            int userChoice;
            Console.WriteLine("## Welcome To PigDice ##");
            Console.WriteLine("\nQuick Guide:\n1)You Need 20 Score To Win Game\n2)If dice rolls 1 then your total score will be ZERO" +
                                "\n3)If you get other dice numbers the it will be added in your score\n\nBEST LUCK!!!");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            while (currentScore < target)
            {
                turnCount += 1;
                Console.WriteLine("\nTurn {0}\n", turnCount);
                currentScore = GameTurns(currentScore );
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Congractulations !! You completed Game in {0} turns!!", turnCount);
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("\n\nSelect One Menu:\n1)Start Game Again\n2)Exit Game");
            char START = '1';
            char EXIT = '2';
            Console.Write("Enter Your Choice:");
            userChoice = Console.ReadLine()[0];
            if (userChoice == '1')
            {
                Main();

            }
            else if (userChoice == '2')
            {
                Console.WriteLine("\nThank You For Playing Game!!");
            }
            Console.ReadLine();
        }
    }
}
