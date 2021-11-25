using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeCore;

namespace TicTacToeCore.Test
{
    [TestClass]
    public class BoardTest
    {
        Board board = new Board();
        [TestMethod]
        public void Test_CellsCount()
        {
            Assert.AreEqual(board.CellCountCheck(), 9);
        }

        [TestMethod]
        public void Test_CellsAreEmptyOrNot()
        {
            Assert.AreEqual<bool>(board.CheckBoardEmpty(),true);
        }

        [TestMethod]
        public void Test_MarkCellAtLocation()
        {
            int location = 4;
            board.MarkCellAtPosition(location, MarkType.O);
            Assert.AreEqual(MarkType.O,board.GetMarkAtSpecificLocation(location));
        }
        [TestMethod]
        public void Test_MarkCellTwice() 
        {
            board.MarkCellAtPosition(2, MarkType.X);
            try
            {
                board.MarkCellAtPosition(2, MarkType.O);
                Assert.Fail();
            }
            catch (Exception ex) { }
        }

    }
}
