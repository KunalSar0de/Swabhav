using Microsoft.VisualStudio.TestTools.UnitTesting;

using ShoppingCartLib.Model;
namespace ShoppingCartLib.Test
{
    [TestClass]
    public class LineItemUnitTest
    {
        [TestMethod]
        public void LineItemTest()
        {
            LineItem lineItem = new LineItem(1, new Product(101, "Cadbury", 20, 0.5f), 1);
            Assert.IsTrue(lineItem.Quantity == 1);
            Assert.AreEqual<Product>(lineItem.Product, new Product(101, "Laptop", 30000, 0.5f));
        }
        [TestMethod]
        public void DiscountedPriceTest()
        {
            LineItem lineItem = new LineItem(1, new Product(101, "Laptop", 30000, 50f),3);
            Assert.AreEqual<int>(lineItem.Quantity , 3);
            Assert.AreEqual<double>(lineItem.Calculate(), 45000);
        }
    }
}
