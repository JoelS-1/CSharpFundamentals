using _08_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_Interfaces
{
    [TestClass]
    public class CurrencyTest
    {
        [TestMethod]
        public void CurrencyValueTests()
        {
            ICurrency penny = new Penny();
            ICurrency dime = new Dime();
            ICurrency dollar = new Dollar();

            Assert.AreEqual(0.01m, penny.Value);
            Assert.AreEqual(0.10m, dime.Value);
            Assert.AreEqual(1m, dollar.Value);
        }

        [DataTestMethod]
        [DataRow(100.2)]
        [DataRow(37.12)]
        [DataRow(1.50)]
        [DataRow(19)]

        public void EPaymentTest(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);

            var ePay = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePay.Value);
        }

    }
}
