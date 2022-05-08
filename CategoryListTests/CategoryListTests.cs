using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyBee;

namespace CategoryListTests
{
    [TestClass]
    public class CategoryListTests
    {
        [TestMethod]
        //Checks to see if category is added to empty list properly
        public void TestAddCategoryToEmptyList()
        {
            //Arrange
            CategoryList list = new CategoryList();
            Category firstCategory = new Category("First", 0, 0);
            list.AddCategory(firstCategory);
            string expectedtitle = "First";

            //Actual
            string actualtitle = list.head.Data.getCategoryTitle();

            //Assert
            Assert.AreEqual(expectedtitle, actualtitle, "Positive - Expected matches actual");
        }

        [TestMethod]
        //Checks to see if categories are inserted in order by priority rating
        public void TestAddCategorySorted()
        {
            //Arrange
            CategoryList list = new CategoryList();

            Category firstCategory = new Category("First", 0, 0);
            list.AddCategory(firstCategory);
            Category secondCategory = new Category("Second", 0, 5);
            list.AddCategory(secondCategory);
            Category thirdCategory = new Category("Third", 0, 10);
            list.AddCategory(thirdCategory);

            string expectedtitle = "Second";

            //Actual
            string actualtitle = list.head.next.Data.getCategoryTitle();

            //Assert
            Assert.AreEqual(expectedtitle, actualtitle, "Positive - Expected matches actual");
        }

        [TestMethod]
        //Checks to see if -1 is returned if list is empty
        public void TestGetIndexWithEmptyList()
        {
            //Arrange
            CategoryList list = new CategoryList();
            int expected = -1;

            //Actual
            int actual = list.getIndex("void");

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }

        [TestMethod]
        //Checks to see if -1 is returned if item is not found
        public void TestGetIndexWithNonExistentItem()
        {
            //Arrange
            CategoryList list = new CategoryList();
            Category testCategory = new Category("Test", 0, 0);
            list.AddCategory(testCategory);
            int expected = -1;

            //Actual
            int actual = list.getIndex("void");

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }

        [TestMethod]
        //Checks to see if correct index is returned if list has one Category
        public void TestGetIndexOneItem()
        {
            //Arrange
            CategoryList list = new CategoryList();
            Category testCategory = new Category("Test", 0, 0);
            list.AddCategory(testCategory);
            int expected = 0;

            //Actual
            int actual = list.getIndex("Test");

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }

        [TestMethod]
        //Checks to see if correct index is returned from list
        public void TestGetIndex()
        {
            //Arrange
            CategoryList list = new CategoryList();

            Category firstCategory = new Category("First", 0, 0);
            list.AddCategory(firstCategory);
            Category secondCategory = new Category("Second", 0, 5);
            list.AddCategory(secondCategory);
            Category thirdCategory = new Category("Third", 0, 10);
            list.AddCategory(thirdCategory);

            int expected = 1;

            //Actual
            int actual = list.getIndex("Second");

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }

        [TestMethod]
        //Checks to see if empty list returns 0
        public void TestGetLengthOfEmpty()
        {
            //Arrange
            CategoryList list = new CategoryList();
            int expected = 0;

            //Actual
            int actual = list.getLength();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }

        [TestMethod]
        //Checks to see if populated list returns correct value
        public void TestGetLength()
        {
            //Arrange
            CategoryList list = new CategoryList();

            Category firstCategory = new Category("First", 0, 0);
            list.AddCategory(firstCategory);
            Category secondCategory = new Category("Second", 0, 5);
            list.AddCategory(secondCategory);
            Category thirdCategory = new Category("Third", 0, 10);
            list.AddCategory(thirdCategory);

            int expected = 3;

            //Actual
            int actual = list.getLength();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Positive - Expected matches actual");
        }

        [TestMethod]
        //Checks to see if value returned follows index
        public void TestGetCategory()
        {
            //Arrange
            CategoryList list = new CategoryList();

            Category firstCategory = new Category("First", 0, 0);
            list.AddCategory(firstCategory);
            Category secondCategory = new Category("Second", 0, 5);
            list.AddCategory(secondCategory);
            Category thirdCategory = new Category("Third", 0, 10);
            list.AddCategory(thirdCategory);

            Category expected = secondCategory;

            //Actual
            Category actual = list.getCategory(1);

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Expected matches actual");
        }

        [TestMethod]
        //Checks to see if value returned follows index
        public void TestCategoryExists()
        {
            //Arrange
            CategoryList list = new CategoryList();

            Category firstCategory = new Category("First", 0, 0);
            list.AddCategory(firstCategory);
            Category secondCategory = new Category("Second", 0, 5);
            list.AddCategory(secondCategory);
            Category thirdCategory = new Category("Third", 0, 10);
            list.AddCategory(thirdCategory);

            bool expected = true;

            //Actual
            bool actual = list.categoryExists("First");

            //Assert
            Assert.AreEqual(expected, actual, "Positive - Expected matches actual");
        }
    }
}