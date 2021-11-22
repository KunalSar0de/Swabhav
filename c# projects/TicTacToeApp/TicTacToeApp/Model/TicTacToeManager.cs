using System;

namespace TicTacToeApp.Model
{
    class TicTacToeManager
    {
        private int _currentPlayer = 1;
        private string _playerOne;
        private string _playerTwo;
        private string _winnerPlayer;
        private int flag = 0;
        private Board _board;

        public TicTacToeManager(Board board)
        {
            _board = board;
        }

        public void StartGame()
        {
            SetPlayerNames();
            GameLogic();
        }

        private void SetPlayerNames()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\tTik Tak Toe");
            Console.WriteLine("------------------------------");
            Console.Write("Enter Player 1 name : ");
            _playerOne = Console.ReadLine();
            Console.Write("Enter Player 2 name : ");
            _playerTwo = Console.ReadLine();
            Console.Clear();
        }

        private void GameLogic()
        {
            do
            {
                CheckPlayerTurn();
                _board.BoardForGame();
                Console.Write("\nEnter Number(1-9) : ");
                int choice = int.Parse(Console.ReadLine());
                _currentPlayer=_board.PositionFiller(choice,_currentPlayer);
                flag = _board.CheckPlayerWin();
                Console.Clear();
            } while (flag != 1 && flag != -1);

            _board.BoardForGame();
            WinnerPrint();
        }
        private void CheckPlayerTurn()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Player {_playerOne}\t: X \nPlayer {_playerTwo}\t: O");
            Console.WriteLine("----------------------------------------");
            if (_currentPlayer % 2 != 0)
            {
                Console.WriteLine("\n-->Player 1 Turn");
            }
            else
            {
                Console.WriteLine("\n-->player 2 Turn");
            }
            Console.WriteLine("\n");
        }        

        private void WinnerPrint()
        {

            if (flag == 1)
            {
                if ((_currentPlayer % 2) + 1 == 1)
                {
                    _winnerPlayer = _playerOne;
                }
                else
                {
                    _winnerPlayer = _playerTwo;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n-------------------------");
                Console.WriteLine($"Player #{_winnerPlayer} won");
                Console.WriteLine("-------------------------");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nMatch Drow!!");
            }
        }           
    }
}

