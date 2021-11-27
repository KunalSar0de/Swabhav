using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeCore;

namespace TicTacToeCore.Test
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Test_CheckPlayersName()
        {
            Player[] players = new Player[2];
            players[0] = new Player("kunal", MarkType.X);
            players[1] = new Player("sohan", MarkType.O);

            Assert.AreEqual<string>(players[0].GetPlayerName, "kunal");
            Assert.AreEqual<string>(players[1].GetPlayerName, "sohan");

        }

        [TestMethod]
        public void Test_CheckCurrentPlayer()
        {
            Player[] players = new Player[2];
            players[0] = new Player("kunal", MarkType.X);
            players[1] = new Player("sohan", MarkType.O);
            Game game = new Game(players, new ResultAnalyzer(new Board()));
            game.Play(2);//x=kunal
            game.Play(5);//o=sohan
            //game.Play(7);//x=kunal

            Assert.AreEqual<string>(game.GetCurrentPlayer, "kunal");
        }

        [TestMethod]
        public void Test_InsertMarkAtLocation()
        {
            Player[] players = new Player[2];
            players[0] = new Player("kunal", MarkType.X);
            players[1] = new Player("sohan", MarkType.O);
            Game game = new Game(players, new ResultAnalyzer(new Board()));
            game.Play(2);
            game.Play(5);
            game.Play(7);

            Assert.AreEqual<MarkType>(game.GetAnalyzer.GetBoard.GetMarkAtSpecificLocation(2), MarkType.X);
            Assert.AreEqual<MarkType>(game.GetAnalyzer.GetBoard.GetMarkAtSpecificLocation(5), MarkType.O);
            Assert.AreEqual<MarkType>(game.GetAnalyzer.GetBoard.GetMarkAtSpecificLocation(7), MarkType.X);
        }

        [TestMethod]
        public void Test_CheckWinCondition()
        {
            Player[] players = new Player[2];
            players[0] = new Player("kunal", MarkType.X);
            players[1] = new Player("sohan", MarkType.O);
            Game game = new Game(players, new ResultAnalyzer(new Board()));
            while (game.GetStatus == ResultType.NO_RESULT)
            {
                /*  X O X
                    O X
                    O   X  */
                game.Play(1);//x
                game.Play(2);//o
                game.Play(3);//x
                game.Play(4);//o
                game.Play(5);//x
                game.Play(7);//o
                game.Play(9);//x                
            }
            Assert.AreEqual(game.GetStatus,ResultType.WIN);
        }

        [TestMethod]
        public void Test_CheckDrowCodition()
        {
            Player[] players = new Player[2];
            players[0] = new Player("kunal", MarkType.X);
            players[1] = new Player("sohan", MarkType.O);
            Game game = new Game(players, new ResultAnalyzer(new Board()));
            while (game.GetStatus == ResultType.NO_RESULT)
            {              
                game.Play(1);
                game.Play(4);
                game.Play(2);
                game.Play(3);
                game.Play(5);
                game.Play(8);
                game.Play(6);
                game.Play(9);
                game.Play(7);
            }
            Assert.AreEqual(game.GetStatus, ResultType.DRAW);
        }
    }
}
