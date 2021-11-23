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
        public void Test_CellCountTest()
        {
            Assert.AreEqual(board.CellCountCheck(), 9);
        }

        [TestMethod]
        public void Test_CheckCellsAreEmptyOrNot()
        {
            Assert.AreEqual(board.CheckBoardValues(),true);
        }

        [TestMethod]
        public void Test_MarkCell()
        {         
            Board board = new Board();
            var cell = board._cells;
            int location = 2;
            cell[location - 1].GetMark(MarkType.O);
            
            board.MarkCellValueOnBoard(3, MarkType.EMPTY);
            Assert.AreEqual(board._cells[3].GetMark,MarkType.O);
        }
    }
}
