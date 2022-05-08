using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyBee;

namespace NotificationsTest
{
    [TestClass]
    public class NotificationsTest
    {
        [TestMethod]
        public void emailNotificationTest()
        {
            //Arrange
            Notifications notification = new Notifications();
            bool expected = true;

            //Actual
            bool actual = notification.sendEmail("thompsonlog@uwplatt.edu");

            //Assert
            Assert.AreEqual(expected, actual, "Positive - email was successfully sent to the specified email");

        }
    }
}
