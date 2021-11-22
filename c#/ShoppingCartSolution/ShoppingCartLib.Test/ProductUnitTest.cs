using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;


namespace ShoppingCartLib.Test
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void ProductShouldHaveIdNamePriceDiscount()
        {
            Product p = new Product(101,"Cadbury",45,50f);
            Assert.IsTrue(p.ProductId == 101);
            Assert.AreEqual(p.ProductName, "Cadbury");
            Assert.IsTrue(p.Price == 45);
            Assert.IsTrue(p.ProductDiscount == 50f);
        }
    }
}
