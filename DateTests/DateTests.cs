using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBee;

namespace DateTests
{
	[TestClass]
	public class DateTests
	{
		[TestMethod]
		public void constructorTest()
		{
			//Arrange 
			Date d = new Date();
			//Actual
			string actual = "5/18/2020";
			Assert.AreEqual(d.toString(), actual, "good");
		}

		[TestMethod]
		public void IncrementDayTest1()
		{
			//Arrange 
			Date d = new Date();
			d.setDay(29);
			d.setMonth(2);
			d.setYear(2020);
			d.increDay();
			//Actual
			string actual = "3/1/2020";
			//Assert
			Assert.AreEqual(d.toString(), actual, "good");
		}

		[TestMethod]
		public void IncrementDayTest2()
		{
			//Arrange 
			Date d = new Date();
			d.setDay(28);
			d.setMonth(2);
			d.setYear(2019);
			d.increDay();
			//Actual
			string actual = "3/1/2019";
			//Assert
			Assert.AreEqual(d.toString(), actual, "good");
		}

		[TestMethod]
		public void IncrementDayTest3()
		{
			//Arrange 
			Date d = new Date();
			d.setDay(31);
			d.setMonth(1);
			d.setYear(2020);
			d.increDay();
			//Actual
			string actual = "2/1/2020";
			//Assert
			Assert.AreEqual(d.toString(), actual, "good");
		}

		[TestMethod]
		public void IncrementDayTest4()
		{
			//Arrange 
			Date d = new Date();
			d.setDay(30);
			d.setMonth(4);
			d.setYear(2020);
			d.increDay();
			//Actual
			string actual = "5/1/2020";
			//Assert
			Assert.AreEqual(d.toString(), actual, "good");
		}

		[TestMethod]
		public void IncrementDayTest5()
		{
			//Arrange 
			Date d = new Date();
			d.setDay(31);
			d.setMonth(12);
			d.setYear(2019);
			d.increDay();
			//Actual
			string actual = "1/1/2020";
			//Assert
			Assert.AreEqual(d.toString(), actual, "good");
		}

		[TestMethod]
		public void DaysBetweenTest1()
		{
			//Arrange 
			Date d = new Date();
			Date d2 = new Date();
			//Actual
			int actual = 0;
			//Assert
			Assert.AreEqual(d.daysBetween(d2), actual, "good");
		}


		[TestMethod]
		public void DaysBetweenTest2()
		{
			//Arrange 
			Date d = new Date();
			Date d2 = new Date();
			d2.setDay(19);
			d2.setMonth(5);
			d2.setYear(2020);
			//Actual
			int actual = 1;
			//Assert
			Assert.AreEqual(d.daysBetween(d2), actual, "good");
		}

		[TestMethod]
		public void DaysBetweenTest3()
		{
			//Arrange 
			Date d = new Date();
			Date d2 = new Date();
			d2.setDay(26);
			d2.setMonth(5);
			d2.setYear(2020);
			//Actual
			int actual = 8;
			//Assert
			Assert.AreEqual(d.daysBetween(d2), actual, "good");
		}

		[TestMethod]
		public void DaysBetweenTest4()
		{
			//Arrange 
			Date d = new Date();
			Date d2 = new Date();
			d2.setDay(31);
			d2.setMonth(5);
			d2.setYear(2020);
			//Actual
			int actual = 13;
			//Assert
			Assert.AreEqual(d.daysBetween(d2), actual, "good");
		}

		[TestMethod]
		public void DaysBetweenTest5()
		{
			//Arrange 
			Date d = new Date();
			Date d2 = new Date();
			d2.setYear(2021);
			//Actual
			int actual = 365;
			//Assert
			Assert.AreEqual(d.daysBetween(d2), actual, "good");
		}

		[TestMethod]
		public void IsbetweenTest1()
		{
			//Arrange 
			Date d = new Date();
			Date d2 = new Date();
			d2.setYear(2019);
			//Actual
			bool actual = true;
			//Assert
			Assert.AreEqual(d2.isBefore(d), actual, "good");
		}

		[TestMethod]
		public void IsbetweenTest2()
		{
			//Arrange 
			Date d = new Date();
			Date d2 = new Date();
			d2.setMonth(1);
			//Actual
			bool actual = true;
			//Assert
			Assert.AreEqual(d2.isBefore(d), actual, "good");
		}

		[TestMethod]
		public void IsbetweenTest3()
		{
			//Arrange 
			Date d = new Date();
			Date d2 = new Date();
			d2.setDay(1);
			//Actual
			bool actual = true;
			//Assert
			Assert.AreEqual(d2.isBefore(d), actual, "good");
		}

		[TestMethod]
		public void IsbetweenTest4()
		{
			//Arrange 
			Date d = new Date();
			Date d2 = new Date();
			//Actual
			bool actual = false ;
			//Assert
			Assert.AreEqual(d2.isBefore(d), actual, "good");
		}

		[TestMethod]
		public void IsbetweenTest5()
		{
			//Arrange 
			Date d = new Date();
			Date d2 = new Date();
			d2.increDay();
			//Actual
			bool actual = false;
			//Assert
			Assert.AreEqual(d2.isBefore(d), actual, "good");
		}
	}
}
