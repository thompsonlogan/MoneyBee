using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyBee;

namespace LoginManagerTests
{
    [TestClass]
    public class LoginManagerTests
    {
        [TestMethod]
        public void GetPrimaryKeyTest()
        {
            //Arrange
            LoginManager lm = new LoginManager();
            lm.setPrimaryKey(1);
            int expected = 1;

            //Actual
            int actual = lm.getPrimaryKey();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Name matches expected");
        }
        /*[TestMethod]
        public void ValidateTest()
        {
            //Arrange
            LoginManager lm = new LoginManager();
            bool expected = true;

            //Actual
            bool actual = lm.validateLogin("admin", 1);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Name matches expected");
        }
        public void LoginUserTest()
        {
            //Arrange
            LoginManager lm = new LoginManager();
            lm.setPrimaryKey(1);
            string expected = "admin";

            //Actual
            string actual = lm.loginUser().getName();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Name matches expected");
        }*/
    }
}
