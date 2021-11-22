using System;

namespace TicTacToeApp.Model
{
    class Board
    {
        private char[] _arrforBoard = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public void BoardForGame()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arrforBoard[1], _arrforBoard[2], _arrforBoard[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arrforBoard[4], _arrforBoard[5], _arrforBoard[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arrforBoard[7], _arrforBoard[8], _arrforBoard[9]);
            Console.WriteLine("     |     |      ");
        }
        public int PositionFiller(int choice,int currentPlayer)
        {
            if (_arrforBoard[choice] != 'X' && _arrforBoard[choice] != 'O')
            {
                if (currentPlayer % 2 == 0)
                {
                    _arrforBoard[choice] = 'O';
                    currentPlayer++;
                    return currentPlayer;
                }
                if (currentPlayer % 2 != 0)
                {
                    _arrforBoard[choice] = 'X';
                    currentPlayer++;
                    return currentPlayer;
                }
            }
            else
            {
                Console.WriteLine("\n-->Position is marked with '{0}'\nYou can try diffrent position.. ", _arrforBoard[choice]);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            return 0;
        }
        public int CheckPlayerWin()
        {
            //for rows
            if (_arrforBoard[1] == _arrforBoard[2] && _arrforBoard[2] == _arrforBoard[3] ||
               _arrforBoard[4] == _arrforBoard[5] && _arrforBoard[5] == _arrforBoard[6] ||
               _arrforBoard[7] == _arrforBoard[8] && _arrforBoard[8] == _arrforBoard[9])
            {
                return 1;
            }
            //for colums
            if (_arrforBoard[1] == _arrforBoard[4] && _arrforBoard[4] == _arrforBoard[7] ||
               _arrforBoard[2] == _arrforBoard[5] && _arrforBoard[5] == _arrforBoard[8] ||
               _arrforBoard[3] == _arrforBoard[6] && _arrforBoard[6] == _arrforBoard[9])
            {
                return 1;
            }
            //for diagonal
            if (_arrforBoard[1] == _arrforBoard[5] && _arrforBoard[5] == _arrforBoard[9] ||
               _arrforBoard[3] == _arrforBoard[5] && _arrforBoard[5] == _arrforBoard[7])
            {
                return 1;
            }
            //if match drow
            if (_arrforBoard[1] != '1' && _arrforBoard[2] != '2' && _arrforBoard[3] != '3'
                && _arrforBoard[4] != '4' && _arrforBoard[5] != '5' && _arrforBoard[6] != '6'
                && _arrforBoard[7] != '7' && _arrforBoard[8] != '8' && _arrforBoard[9] != '9')
            {
                return -1;
            }
            return 0;
        }
    }
}
