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

            Assert.AreEqual<string>(game.GetCurrentPlayer.GetPlayerName, "kunal");
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
        public void Test_CheckWinner()
        {
            Player[] players = new Player[2];
            players[0] = new Player("kunal", MarkType.X);
            players[1] = new Player("sohan", MarkType.O);
            Game game = new Game(players, new ResultAnalyzer(new Board()));
            while (game.GetStatus == ResultType.NO_RESULT)
            {
                game.Play(2);//x
                game.Play(0);//o
                game.Play(4);//x
                game.Play(3);//o
                game.Play(7);//x   
            }
            Assert.AreEqual(game.GetStatus,ResultType.WIN);
        }
    }
}
