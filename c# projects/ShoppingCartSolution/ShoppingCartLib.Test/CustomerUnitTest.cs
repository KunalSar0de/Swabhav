using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;
using System;
namespace ShoppingCartLib.Test
{

    [TestClass]
    public class CustomerUnitTest
    {
        Customer customer = new Customer(1, "kunu");
        [TestMethod]
        public void TestCustomerOrder()
        {           
            Assert.AreEqual<int>(0, customer.OrderCount);

            Order order = new Order(1001, new DateTime(2021, 12, 22));
            order.AddItem(new LineItem(1, new Product(1, "Cadbury", 20, 50), 2));
            order.AddItem(new LineItem(2, new Product(2, "Book", 500, 50), 1));

            Order order1 = new Order(1002, new DateTime(2021, 06, 15));
            order1.AddItem(new LineItem(1, new Product(1, "Laptop", 30000, 50), 1));
            order1.AddItem(new LineItem(2, new Product(2, "Blancket", 800, 50), 2));

            customer.AddOrder(order);
            customer.AddOrder(order1);
            Assert.AreEqual<int>(2, customer.OrderCount);
          
        }
        [TestMethod]
        public void CheckCustomerDetails()
        {
            Assert.AreEqual<int>(1, customer.Id);
            Assert.AreEqual<string>("kunu", customer.Name);
        }
    }
}
