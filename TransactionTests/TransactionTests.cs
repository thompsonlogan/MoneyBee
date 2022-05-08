using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyBee;
namespace ExpenseUnitTests
{
	[TestClass]
	public class ExpenseUnitTests
	{
		[TestMethod]
		public void TestGetDesc()
		{
			//Arrange
			Transaction e = new Transaction();
			e.setDesc("This is a test");

			//Actual
			string actual = e.getDesc();

			//Assert
			Assert.AreEqual("This is a test", actual, "Good");
		}

		[TestMethod]
		public void TestGetPrice()
		{
			//Arrange
			Transaction e = new Transaction();
			e.setPrice(10);

			//Actual
			double actual = e.getPrice();

			//Assert
			Assert.AreEqual(10, actual, 0, "Good");
		}

		[TestMethod]
		public void TestGetCategory()
		{
			//Arrange
			Transaction e = new Transaction();
			Category testCategory = new Category("title", 0, 0);
			e.setCategory(testCategory);
			string expected = "title";

			//Actual
			string actual = e.getCategory().getCategoryTitle();

			//Assert
			Assert.AreEqual(expected, actual, "Good");
		}

		[TestMethod]
		public void TestGetDate()
		{
			//Arrange
			Transaction e = new Transaction();
			e.setDate("12/13/2014");

			//Actual
			string actual = e.getDate();

			//Assert
			Assert.AreEqual("12/13/2014", actual, "Good");
		}

		[TestMethod]
		public void TestGetTime()
		{
			//Arrange
			Transaction e = new Transaction();
			e.setTime("10:15");

			//Actual
			string actual = e.getTime();

			//Assert
			Assert.AreEqual("10:15", actual, "Good");
		}
		[TestMethod]
		public void TestGetTransactionNumber()
		{
			//Arrange
			Transaction e = new Transaction();
			e.setTransactionNumber(5);
			int expected = 5;

			//Actual
			int actual = e.getTransactionNumber();

			//Assert
			Assert.AreEqual(expected, actual, "Good");
		}
	}
}
