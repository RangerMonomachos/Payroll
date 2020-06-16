using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;


namespace PayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Payroll_MainControler_checkString_True()
        {
            string x = Payroll.MainController.checkString("hello");
            Assert.IsTrue(x == "hello");
        }
        [TestMethod]
        public void Payroll_MainControler_checkInt_true()
        {
            int x = Payroll.MainController.checkInt("25");
            Assert.IsTrue(x == 25);
        }
    }
}
