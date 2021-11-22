using System;
using DotComGameApp.Model;

namespace DotComGameApp
{
    class SimpleDotComGameTest
    {
       static void Main(string[] args)
        {
            int numOfGuesses = 0;
        DotComBackground dot = new DotComBackground();//object creation
        Random RandomNumGenerator = new Random();//random num generator
        int randomNum = RandomNumGenerator.Next(1, 8);
        int[] locations = { randomNum, randomNum + 2, randomNum + 1 };
            foreach(int c in locations)
            {
                Console.Write(" {0} ",c);                
            }
    dot.SetLocationCells(locations);
            bool isActive = true;
    Console.WriteLine("\n\n###Simple DotCom Game ###");
            while (isActive == true)
            {
                Console.WriteLine("Enter Number:(1-10)");
                string guess = Console.ReadLine();
    string result = dot.CheckYourself(guess);
    numOfGuesses++;
                if (result.Equals("kill"))
                {
                    isActive = false;
                    Console.WriteLine("\n\nYou took " + numOfGuesses + " guesses");
                }
            }
            Console.ReadLine();
        }
    }
}
