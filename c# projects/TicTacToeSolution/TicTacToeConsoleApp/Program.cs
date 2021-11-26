using System;
using TicTacToeCore;

namespace TicTacToeConsoleApp
{
    class Program
    {
        static void Main()
        {
            Player[] players = new Player[2];
            players[0] = new Player("kunal",MarkType.X);
            players[1] = new Player("sohan", MarkType.O);


            Game game = new Game(players, new ResultAnalyzer(new Board()));

 
            while (game.GetStatus ==ResultType.NO_RESULT)
            {
              /* o x X
                 o 0 E 
                 o E 0 */
                
                game.Play(2);//x
                game.Play(0);//o
                game.Play(1);//x
                game.Play(4);//o
                game.Play(7);//x
               // game.Play();//o
            }
           
        }
    }
}
