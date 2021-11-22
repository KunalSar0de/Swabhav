using System;
using TicTacToeApp.Model;
namespace TIC_TAC_TOE
{
    class Program
    {
        static void Main()
        {
            var tictactoe = new TicTacToeManager(new Board());
            tictactoe.StartGame();
            Console.ReadKey();
        }
    }
}