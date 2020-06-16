using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;


namespace PayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Payroll_MainControler_checkDouble_Badinput()
        {
            double x = Payroll.MainController.checkDouble("hello");
            Assert.IsTrue(x == -100.0);
        }
        [TestMethod]
        public void Payroll_MainControler_checkDouble_goodInput()
        {
            double x = Payroll.MainController.checkDouble("25.4");
            Assert.IsTrue(x == 25.4);
        }
        [TestMethod]
        public void Payroll_MainControler_checkInt_true()
        {
            int x = Payroll.MainController.checkInt("25");
            Assert.IsTrue(x == 25);
        }
        [TestMethod]
        public void Payroll_MainControler_checkInt_Badinput()
        {
            double x = Payroll.MainController.checkInt("hello");
            Assert.IsTrue(x == -100);
        }
    }
}
