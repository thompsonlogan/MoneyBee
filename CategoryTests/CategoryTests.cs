//ADD TO PUSH
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyBee;

namespace CategoryTests
{
    [TestClass]
    public class CategoryTests
    {
        //Checks to see if constructor passes as expected
        [TestMethod]
        public void TestConstructor()
        {
            //Arrange
            int expectedpriority = 5;
            string expectedtitle = "Title";
            double expectedbudget = 10.00;
            double expectedTotal = 0.00;
            Category newCategory = new Category(expectedtitle, expectedbudget, expectedpriority);

            //Actual
            int actualpriority = newCategory.getPriorityRating();
            string actualtitle = newCategory.getCategoryTitle();
            double actualtotal = newCategory.getCategoryTotal();
            double actualbudget = newCategory.getBudget();

            //Assert
            Assert.AreEqual(expectedpriority, actualpriority, 0, "Positive - Expected matches actual");
            Assert.AreEqual(expectedbudget, actualbudget, 0, "Positive - Expected matches actual");
            Assert.AreEqual(expectedtitle, actualtitle, "Positive - Expected matches actual");
            Assert.AreEqual(expectedTotal, actualtotal, "Positive - Expected matches actual");
        }

        //Checks to see if priority rating sets and gets properly
        [TestMethod]
        public void TestPriorityRating()
        {
            //Arrange
            Category newCategory = new Category("", 0, 0);
            int expected = 5;
            newCategory.setPriorityRating(5);

            //Actual
            int actual = newCategory.getPriorityRating();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }

        //Checks to see if the title is set and get properly
        [TestMethod]
        public void TestCategoryTitle()
        {
            //Arrange
            Category newCategory = new Category("", 0, 0);
            string expected = "Title";
            newCategory.setCategoryTitle("Title");

            //Actual
            string actual = newCategory.getCategoryTitle();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Expected matches actual");
        }

        //Checks to see if the total is set and get properly
        [TestMethod]
        public void TestCategoryTotal()
        {
            //Arrange
            Category newCategory = new Category("", 0, 0);
            double expected = 5.50;
            newCategory.incrementCategoryTotal(5.50);

            //Actual
            double actual = newCategory.getCategoryTotal();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }

        //Checks to see if adding a new transaction to the category is set properly
        [TestMethod]
        public void TestAddingTransaction()
        {
            //Arrange
            Category newCategory = new Category("Test", 0, 0);
            Transaction newTransaction = new Transaction();
            newCategory.addTransaction(newTransaction);
            bool expected = true;

            //Actual
            bool actual = newCategory.categoryHistory.head != null;

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Expected matches actual");
        }

        //Checks to see if getting transaction details from a category is set properly
        [TestMethod]
        public void TestGettingTransactionDetails()
        {
            //Arrange
            Category newCategory = new Category("Test", 0, 0);
            Transaction newTransaction = new Transaction("", 10, newCategory, "", "", 0, false, 0);
            newCategory.addTransaction(newTransaction);
            double expected = 10;

            //Actual
            double actual = newCategory.getTransactionDetails(0).Data.getPrice();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Expected matches actual");
        }

        //Checks to see if budget is set and get properly
        [TestMethod]
        public void TestBudget()
        {
            //Arrange
            Category newCategory = new Category("", 0, 0);
            double expected = 50.00;
            newCategory.setBudget(50.00);

            //Act
            double actual = newCategory.getBudget();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }

        //Checks to see if the difference is returned properly
        [TestMethod]
        public void TestDifference()
        {
            //Arrange
            Category newCategory = new Category("", 0, 0);
            newCategory.incrementCategoryTotal(25.00);
            newCategory.setBudget(100.00);
            double expected = 75.00;

            //Act
            double actual = newCategory.getDifference();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }
    }
}
