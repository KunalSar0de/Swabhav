using Microsoft.VisualStudio.TestTools.UnitTesting;
using LSPSolution.Model;

namespace LSPTest
{
    [TestClass]
    public class SquareUnitTest
    {
        Square square = new Square(5);

        [TestMethod]
        public void SquareSideCheck()
        {
            Assert.AreEqual<int>(5, square.GetSide());
        }

        [TestMethod]
        public void SquareArea()
        {            
            Assert.AreEqual<int>(25, square.CalculateArea());
        }
    }
}
