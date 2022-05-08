using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyBee;

namespace TransactionHistoryTests
{
    [TestClass]
    public class TransactionHistoryTests
    {
        [TestMethod]
        //Checks to see if adding one expense populates list
        public void TestAddOneTransaction()
        {
            //Arrange
            TransactionHistory newTransaction = new TransactionHistory();
            Transaction expenseDetails = new Transaction();
            expenseDetails.setPrice(10);
            newTransaction.AddTransaction(expenseDetails);
            double expected = 10;

            //Actual
            double actual = newTransaction.head.Data.getPrice();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }

        [TestMethod]
        //Checks to see if head is set to most recent node after adding two expenses
        public void TestAddTwoTransactions()
        {
            //Arrange
            TransactionHistory newTransaction = new TransactionHistory();

            Transaction expenseDetails1 = new Transaction();
            expenseDetails1.setPrice(10);

            Transaction expenseDetails2 = new Transaction();
            expenseDetails2.setPrice(20);

            newTransaction.AddTransaction(expenseDetails2);
            newTransaction.AddTransaction(expenseDetails1);
            double expected = 10;

            //Actual
            double actual = newTransaction.head.Data.getPrice();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }
        [TestMethod]
        //Checks to see if head is set to most recent node after adding two expenses
        public void getTransactionCountTest()
        {
            //Arrange
            TransactionHistory newTransaction = new TransactionHistory();
            newTransaction.setTransactionCount(10);
            double expected = 10;

            //Actual
            double actual = newTransaction.getTransactionCount();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }
        [TestMethod]
        //Checks to see if head is set to most recent node after adding two expenses
        public void getTransactionTest()
        {
            //Arrange
            TransactionHistory newTransaction = new TransactionHistory();
            Transaction expenseDetails = new Transaction();
            expenseDetails.setPrice(20);
            newTransaction.AddTransaction(expenseDetails);
            double expected = 20;

            //Actual
            double actual = newTransaction.getTransaction(0).getPrice();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }
        [TestMethod]
        //Checks to see if head is set to most recent node after adding two expenses
        public void getLastTransactionTest()
        {
            //Arrange
            TransactionHistory newTransaction = new TransactionHistory();
            Transaction expenseDetails = new Transaction();
            expenseDetails.setPrice(20);
            newTransaction.AddTransaction(expenseDetails);
            double expected = 20;

            //Actual
            double actual = newTransaction.getLastTransaction().getPrice();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }
    }
}
