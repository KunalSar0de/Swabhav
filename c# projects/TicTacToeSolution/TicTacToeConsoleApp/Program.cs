using System;
using TicTacToeCore;

namespace TicTacToeConsoleApp
{
    class Program
    {
        static void Main()
        {
            Player[] players = new Player[2];
            players[0] = new Player("kunal", MarkType.X);
            players[1] = new Player("sohan", MarkType.O);


            Game game = new Game(players, new ResultAnalyzer(new Board()));
            do
            {

                Console.Write("input : ");
                var input = int.Parse(Console.ReadLine());
                game.Play(input);
                GameBoard(game);

            } while (game.GetStatus == ResultType.NO_RESULT);

            Console.ReadKey();
        }
        public static void GameBoard(Game game)
        {
            Console.WriteLine(game.GetBoard.GetAllCells[0].GetMark + "|" + game.GetBoard.GetAllCells[1].GetMark + "|" + game.GetBoard.GetAllCells[2].GetMark);
            Console.WriteLine("-------------------");
            Console.WriteLine(game.GetBoard.GetAllCells[3].GetMark + "|" + game.GetBoard.GetAllCells[4].GetMark + "|" + game.GetBoard.GetAllCells[5].GetMark);
            Console.WriteLine("-------------------");
            Console.WriteLine(game.GetBoard.GetAllCells[8].GetMark + "|" + game.GetBoard.GetAllCells[7].GetMark + "|" + game.GetBoard.GetAllCells[8].GetMark);

        }
    }
}
