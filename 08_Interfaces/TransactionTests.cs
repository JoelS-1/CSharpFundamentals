using _08_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;


        [TestMethod]
        public void PayDebt(ICurrency payment)
        {
            //_debt = _debt - payment.value
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debit");
        }

        [TestInitialize]
        public void Arrange()
        {
            _debt = 9000.01m;
        }
        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(315.52m));

            decimal expectedDebt = 9000.01m - 316.52m;

            Assert.AreEqual(expectedDebt, _debt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            //created new instances of our Icurrency interface objects
            var dollar = new Dollar();
            var ePay = new ElectronicPayment(243.71m);

            //injecting them into transaction class _currency field
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePay);

            //
            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());
        }

        [TestMethod]
        public void MoreExamples()
        {
            var list = new List<Transaction>
            {
                new Transaction(new Dollar()),
                new Transaction(new ElectronicPayment(231.95m)),
                new Transaction(new Penny()),
                new Transaction(new Dime()),
                new Transaction(new Dollar())
            };

            foreach(var transaction in list)
            {
                var type = transaction.GetTransactionType();
                var amount = transaction.GetTransactionAmount();

                Console.WriteLine($"{type} { amount} {transaction.DateOfTransaction}");

                Console.WriteLine($"You paid ${transaction.GetTransactionAmount()} on {transaction.DateOfTransaction}");
            }
        }
    }
}
