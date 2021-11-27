using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeCore;

namespace TicTacToeCore.Test
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        readonly ResultAnalyzer analyzer = new ResultAnalyzer(new Board());

        [TestMethod]
        public void Test_CheckRowWin()
        {
            analyzer.GetBoard.MarkCellAtPosition(1, MarkType.O);
            analyzer.GetBoard.MarkCellAtPosition(2, MarkType.O);
            analyzer.GetBoard.MarkCellAtPosition(3, MarkType.O);
            Assert.AreEqual<ResultType>(analyzer.Analyze(),ResultType.WIN);
        }
        
        [TestMethod]
        public void Test_CheckColumnWin()
        {
            analyzer.GetBoard.MarkCellAtPosition(1, MarkType.O);
            analyzer.GetBoard.MarkCellAtPosition(4, MarkType.X);
            analyzer.GetBoard.MarkCellAtPosition(7, MarkType.O);
            Assert.AreEqual<ResultType>(analyzer.Analyze(), ResultType.NO_RESULT);
        }

        [TestMethod]
        public void Test_CheckDiagonalWin()
        {
            analyzer.GetBoard.MarkCellAtPosition(1, MarkType.X);
            analyzer.GetBoard.MarkCellAtPosition(2, MarkType.O);
            analyzer.GetBoard.MarkCellAtPosition(3, MarkType.X);
            analyzer.GetBoard.MarkCellAtPosition(4, MarkType.O);
            analyzer.GetBoard.MarkCellAtPosition(5, MarkType.X);
            analyzer.GetBoard.MarkCellAtPosition(6, MarkType.O);
            analyzer.GetBoard.MarkCellAtPosition(7, MarkType.X);
            Assert.AreEqual<ResultType>(analyzer.Analyze(), ResultType.WIN);
        }

        [TestMethod]
        public void Test_CheckDorwCondition()
        {
            /*X O X
              X X O
              O X O */
            analyzer.GetBoard.MarkCellAtPosition(1, MarkType.X);
            analyzer.GetBoard.MarkCellAtPosition(2, MarkType.O);
            analyzer.GetBoard.MarkCellAtPosition(3, MarkType.X);
            analyzer.GetBoard.MarkCellAtPosition(4, MarkType.X);
            analyzer.GetBoard.MarkCellAtPosition(5, MarkType.X);
            analyzer.GetBoard.MarkCellAtPosition(6, MarkType.O);
            analyzer.GetBoard.MarkCellAtPosition(7, MarkType.O);
            analyzer.GetBoard.MarkCellAtPosition(8, MarkType.X);
            analyzer.GetBoard.MarkCellAtPosition(9, MarkType.O);
            Assert.AreEqual<ResultType>(analyzer.Analyze(), ResultType.DRAW);
        }
    }
}
