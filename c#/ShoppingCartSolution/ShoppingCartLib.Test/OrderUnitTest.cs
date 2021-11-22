using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;
using System;

namespace ShoppingCartLib.Test
{

    [TestClass]
    public class OrderUnitTest
    {
        Order order = new Order(1, new DateTime(2021,02,12));       
        
        [TestMethod]
        public void OrderTestCheck()
        {
            order.AddItem(new LineItem(1, new Product(101, "Book", 50, 50f), 2));
            order.AddItem(new LineItem(2, new Product(101, "Book", 50, 50f), 2));
            Assert.AreEqual<int>(1,order.Items[0].Id);
            Assert.AreEqual<int>(2, order.Items[1].Id);
        }
        [TestMethod]
        public void NumbrOfOrderItemsCheck()
        {
            order.AddItem(new LineItem(1001, new Product(101, "Book", 50, 50f), 2));
            Assert.AreEqual<int>(1, order.ItemCount);
        }
        [TestMethod]
        public void OrderTotalCheck()
        {
            Order order1 = new Order(1, new DateTime(2021, 02, 12));
            order.AddItem(new LineItem(1, new Product(101, "Ereser", 10, 50f), 5));
            order.AddItem(new LineItem(2, new Product(102, "Book", 500, 50f), 2));

            Assert.AreEqual<double>(525, order.GetOrderTotal());
        }
    }
}
