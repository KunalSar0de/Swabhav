using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ownlibrary;

namespace DllUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double result=Functions.Add(-50,-20);
            Assert.AreEqual(-70, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double result=Functions.Subtract(40, 50);
            Assert.AreEqual(-10,result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double result= Functions.Multiply(-50, -20);
            Assert.AreEqual(-10, result);
        }
    }
}
