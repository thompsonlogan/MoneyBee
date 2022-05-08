using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyBee;

namespace DatabaseTests
{
    /*[TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void getUsernameFromDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("admin");
            string expected = "admin";

            //Actual
            string actual = database.getUsernameFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Username matches expected");
        }
        [TestMethod]
        public void getPasswordFromDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("admin");
            string expected = "admin1";

            //Actual
            string actual = database.getPasswordFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Password matches expected");
        }
        [TestMethod]
        public void getNameFromDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("admin");
            string expected = "adminName";

            //Actual
            string actual = database.getNameFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Name matches expected");
        }
        [TestMethod]
        public void getEmailFromDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("admin");
            string expected = "admin@gmail.com";

            //Actual
            string actual = database.getEmailFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Email matches expected");
        }
        [TestMethod]
        public void getProjectedIncomeFromDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("admin");
            double expected = 100000;

            //Actual
            double actual = database.getProjectedIncomeFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Projected Income matches expected");
        }
        [TestMethod]
        public void getActualIncomeFromDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("admin");
            string expected = "95000";

            //Actual
            double actual = 10;//database.getActualIncomeFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Actual Income matches expected");
        }
        [TestMethod]
        public void getTotalExpensesFromDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("admin");
            string expected = "5";

            //Actual
            double actual = database.getTotalExpensesFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Total Expenses matches expected");
        }
        [TestMethod]
        public void setUsernameToDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("user");
            database.setUsernameToDatabase(primaryKey, "userUpdate");
            string expected = "userUpdate";

            //Actual
            string actual = database.getUsernameFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Username matches expected");
        }
        [TestMethod]
        public void setPasswordToDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("user");
            database.setPasswordToDatabase(primaryKey, "userpass");
            string expected = "userpass";

            //Actual
            string actual = database.getPasswordFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Password matches expected");
        }
        [TestMethod]
        public void setNameToDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("user");
            database.setNameToDatabase(primaryKey, "userName");
            string expected = "userName";

            //Actual
            string actual = database.getNameFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Name matches expected");
        }
        [TestMethod]
        public void setEmailToDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("user");
            database.setEmailToDatabase(primaryKey, "newuser@gmail.com");
            string expected = "useradmin@gmail.com";

            //Actual
            string actual = database.getEmailFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Email matches expected");
        }
        [TestMethod]
        public void setProjectedIncomeToDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("user");
            database.setProjectedIncomeToDatabase(primaryKey, 115000);
            double expected = 115000;

            //Actual
            double actual = database.getProjectedIncomeFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Projected Income matches expected");
        }
        [TestMethod]
        public void setActualIncomeToDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("user");
            database.setActualIncomeToDatabase(primaryKey, 90000);
            double expected = 90000;

            //Actual
            double actual = 10;// database.getActualIncomeFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Actual Income matches expected");
        }
        [TestMethod]
        public void setTotalExpensesToDatabaseTest()
        {
            //Arrange
            Database database = new Database();
            int primaryKey = database.getPrimaryKey("user");
            database.setTotalExpensesToDatabase(primaryKey, 1500);
            double expected = 1500;

            //Actual
            double actual = database.getTotalExpensesFromDatabase(primaryKey);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Email matches expected");
        }
        [TestMethod]
        public void userLoginTest()
        {
            //Arrange
            Database database = new Database();
            User user = database.login("admin", "admin");
            string expected = "admin@gmail.com";

            //Actual
            string actual = user.getEmail();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - User email matches email from database");
        }
        [TestMethod]
        public void createUserObjectTest()
        {
            //Arrange
            Database database = new Database();
            User user = database.createUser(2);
            string expected = "user@gmail.com";

            //Actual
            string actual = user.getEmail();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - User email matches email from database");
        }
        //validate login
        [TestMethod]
        public void validateLoginTest1()
        {
            //Arrange
            Database database = new Database();
            bool expected = true;

            //Actual
            bool actual = database.validateLogin("admin", "admin");

            //Assert
            Assert.AreEqual(expected, actual, "Positive - User was validated for login");
        }
        [TestMethod]
        public void validateLoginTest2()
        {
            //Arrange
            Database database = new Database();
            bool expected = false;

            //Actual
            bool actual = database.validateLogin("random", "random");

            //Assert
            Assert.AreEqual(expected, actual, "Positive - User was not validated for login");
        }
        //get primary key
        [TestMethod]
        public void getPrimaryKeyTest()
        {
            //Arrange
            Database database = new Database();
            int expected = 1;

            //Actual
            int actual = database.getPrimaryKey("admin");

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Primary key matches expected");
        }
        //register user
        [TestMethod]
        public void registerUserTest()
        {
            //Arrange
            Database database = new Database();
            database.registerUser("bob123", "bob123", "bob", "bob@gmail.com", 10000);
            User user = database.createUser(database.getPrimaryKey("bob"));
            string expected = "bob@gmail.com";

            //Actual
            string actual = user.getEmail();

            //Assert
            Assert.AreEqual(expected, actual, "Positive - User email matches email from database");
        }
    }*/
}
