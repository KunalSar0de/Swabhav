using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LSPSolution.Model;


namespace LSPTest
{
    [TestClass]
    public class RectangleUnitTest
    {   
        Rectangle rectangle = new Rectangle(20, 30);
        [TestMethod]
        public void RectangleHeightWidthCheck()
        {
            Assert.AreEqual<int>(20, rectangle.Width);
            Assert.AreEqual<int>(30, rectangle.Height);

            rectangle.SetHeight(rectangle.Height + 10);
            Assert.AreEqual<int>(40, rectangle.Height);

        }
        [TestMethod]
        public void RectangleAreaCheck()
        {
            rectangle.SetHeight(10);
            rectangle.SetWidth(20);
            Assert.AreEqual<int>(200,rectangle.CalculateArea());
        }
        
    }
}
