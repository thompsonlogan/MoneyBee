using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyBee;

namespace UserClassUnitTests
{
    [TestClass]
    public class UserTests
    {
        //testing setter and getter for name
        [TestMethod]
        public void GetNameUnitTest()
        {
            //Arrange
            User user = new User();
            user.setName("Logan");
            string expected = "Logan";

            //Actual
            string actual = user.getName();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Name matches expected");
        }
        //testing setter and getter for username
        [TestMethod]
        public void GetUsernameUnitTest()
        {
            //Arrange
            User user = new User();
            user.setUsername("myTestUsername");
            string expected = "myTestUsername";

            //Actual
            string actual = user.getUsername();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Username matches expected");
        }
        //testing getter and setter for password
        [TestMethod]
        public void GetPasswordUnitTest()
        {
            //Arrange
            User user = new User();
            user.setPassword("myTestPassword");
            string expected = "myTestPassword";

            //Actual
            string actual = user.getPassword();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Password matches expected");
        }
        //testing getter and setter for email
        [TestMethod]
        public void GetEmailUnitTest()
        {
            //Arrange
            User user = new User();
            user.setEmail("myTestEmail@gmail.com");
            string expected = "myTestEmail@gmail.com";

            //Actual
            string actual = user.getEmail();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Email matches expected");
        }
        //Tests the setter and the getter for the projected income values. 
        [TestMethod]
        public void TestProjectedIncome()
        {
            //Arrange
            User user = new User();
            double expected = 10.0;
            user.setProjectedIncome(expected);

            //Actual
            double actual = user.getProjectedIncome();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }
        //Tests the setter and getter for the actual income values. 
        [TestMethod]
        public void TestActualIncome()
        {
            //Arrange
            User user = new User();
            double expected = 10.0;
            user.setActualIncome(expected);

            //Actual
            double actual = user.getActualIncome();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }
        //Tests the setter and getter for the total expenses. 
        [TestMethod]
        public void TestTotalExpenses()
        {
            //Arrange
            User user = new User();
            double expected = 10.0;
            user.setTotalExpenses(expected);

            //Actual
            double actual = user.getTotalExpenses();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }
        //Tests the setter and getter for the current balance values. 
        [TestMethod]
        public void TestCurrentBalance()
        {
            //Arrange
            User user = new User();
            double expected = 10.0;
            user.setCurrentBalance(expected);

            //Actual
            double actual = user.getCurrentBalance();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }
        [TestMethod]
        public void GetPrimaryKeyTest()
        {
            //Arrange
            User user = new User();
            user.setPrimaryKey(1);
            int expected = 1;

            //Actual
            int actual = user.getPrimaryKey();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Primary key matches expected");
        }
        [TestMethod]
        public void GetLoggedInStatusTest()
        {
            //Arrange
            User user = new User();
            user.setLoggedInStatus(true);
            bool expected = true;

            //Actual
            bool actual = user.getloggedInStatus();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Loggedin status matches expected");
        }
        //Tests the change balance method, this one checks to make sure it 
        //adds the change in balance correctly. 
        [TestMethod]
        public void changeBalanceTest1()
        {
            //Arrange
            User user = new User();
            user.setActualIncome(50);
            user.setTotalExpenses(40);
            user.changeBalance();
            double expected = 10;

            //Actual
            double actual = user.getCurrentBalance();

            //Assert
            Assert.AreEqual(expected, actual, 0, "changeBalance is correct positive");
        }

        //Tests the change balance method as well, but this one is used
        //to test if the method subtracts from the balance correctly. 
        [TestMethod]
        public void changeBalanceTest2()
        {
            //Arrange
            User user = new User();
            user.setActualIncome(40);
            user.setTotalExpenses(50);
            user.changeBalance();
            double expected = -10;

            //Actual
            double actual = user.getCurrentBalance();

            //Assert
            Assert.AreEqual(expected, actual, 0, "changeBalance is correct negative");
        }

        //Tests the change expenses method
        [TestMethod]
        public void changeExpenses()
        {
            //Arrange
            User user = new User();
            user.setTotalExpenses(50);
            user.changeTotalExpenses(10);
            double expected = 60;

            //Actual
            double actual = user.getTotalExpenses();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - expected matches actual");
        }
    }
}
