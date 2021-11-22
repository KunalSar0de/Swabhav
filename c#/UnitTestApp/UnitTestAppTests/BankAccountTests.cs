using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void TestCase()
        {
            BankAccount b = new BankAccount();       
            b.IsPositiveNumber(100);
        }
    }
}