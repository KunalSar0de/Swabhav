using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
              /* O E X
                 E x o 
                 E E x */
                
                game.Play(2);//x
                game.Play(0);//o
                game.Play(4);//x
                game.Play(3);//o
                game.Play(8);//x

                
            }
        }
    }
}
