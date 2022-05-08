//---------------------------------------------------------------
// Name:    Andi Fuerst, Logan Thompson, Nathan Kawula
//
// Project: MoneyBee
//
// Purpose: Creates a transaction with a description, price, category,
//          date, time, transaction number, boolean repeating, and 
//          a frequency
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//

namespace MoneyBee
{
	public class Transaction
	{
		private string description;
		private double price;
		private Category cate;
		private string date;
		private string time;
		private int transactionNumber;
		private bool auto;
		private int frequency;

		//---------------------------------------------------------------------
		// Constructor
		//---------------------------------------------------------------------
		public Transaction(string d, double p, Category c, string da, string t,
			int inTransactionNumber, bool a, int f)
		{
			description = d;
			price = p;
			cate = c;
			date = da;
			time = t;
			transactionNumber = inTransactionNumber;
			auto = a;
			frequency = f;
		}

		//---------------------------------------------------------------------
		// default constructor
		//---------------------------------------------------------------------
		public Transaction()
		{
			description = "undefined";
			price = 0.00;
			cate = null;
			date = "01/01/2001";
			time = "00:00";
		}

		//---------------------------------------------------------------------
		// Copy constructor
		//---------------------------------------------------------------------
		public Transaction(Transaction t)
		{
			description = t.description;
			price = t.price;
			cate = t.cate;
			date = t.date;
			time = t.time;
			auto = t.auto;
			frequency = t.frequency;
		}

		//---------------------------------------------------------------------
		// Returns the description as a string
		//---------------------------------------------------------------------
		public string getDesc()
		{
			return description;
		}

		//---------------------------------------------------------------------
		// Returns the price as a double
		//---------------------------------------------------------------------
		public double getPrice()
		{
			return price;
		}

		//---------------------------------------------------------------------
		// Returns the Category as a Category object
		//---------------------------------------------------------------------
		public Category getCategory()
		{
			return cate;
		}

		//---------------------------------------------------------------------
		// Returns the Date as a string
		//---------------------------------------------------------------------
		public string getDate()
		{
			return date;
		}

		//---------------------------------------------------------------------
		// Returns the Time as a string
		//---------------------------------------------------------------------
		public string getTime()
		{
			return time;
		}

		//---------------------------------------------------------------------
		// Sets the Description to the given string
		//---------------------------------------------------------------------
		public void setDesc(string s)
		{
			description = s;
		}

		//---------------------------------------------------------------------
		// Sets the Price to the given double
		//---------------------------------------------------------------------
		public void setPrice(double s)
		{
			price = s;
		}

		//---------------------------------------------------------------------
		// Sets Category to the given Category object
		//---------------------------------------------------------------------
		public void setCategory(Category c)
		{
			cate = c;
		}

		//---------------------------------------------------------------------
		// Sets the date to the given string
		//---------------------------------------------------------------------
		public void setDate(string s)
		{
			date = s;
		}

		//---------------------------------------------------------------------
		// Sets the time to the given string
		//---------------------------------------------------------------------
		public void setTime(string s)
		{
			time = s;
		}

		//---------------------------------------------------------------------
		// Returns the Transaction Number as an integer
		//---------------------------------------------------------------------
		public int getTransactionNumber()
		{
			return transactionNumber;
		}

		//---------------------------------------------------------------------
		// Sets the Transaction Number to the given integer

		//---------------------------------------------------------------------
		public void setTransactionNumber(int inTransNumber)
		{
			transactionNumber = inTransNumber;
		}


		//---------------------------------------------------------------------
		// Returns the boolean value whether or not the transaction repeats
		//---------------------------------------------------------------------
		public bool getAuto()
		{
			return auto;
		}

		//---------------------------------------------------------------------
		// Sets the boolean value whether or not the transaction repeats to 
		// the given boolean
		//---------------------------------------------------------------------
		public void setAuto(bool a)
		{
			auto = a;
		}

		//---------------------------------------------------------------------
		// Returns an integer refering to how often the transaction repeats
		// 0-Never, 1-Everyday, 2-Every Other day, 7-Every Week, 14-Every two weeks, 
		// 30-Every Month, 182-Every 6 Months, 365-Every Year
		//---------------------------------------------------------------------
		public int getFreq()
		{
			return frequency;
		}

		//---------------------------------------------------------------------
		// Sets the how often the transaction should be repeated. It should be one
		// of the values below. The method does not check for this. 
		// 0-Never, 1-Everyday, 2-Every Other day, 7-Every Week, 14-Every two weeks,
		// 30-Every Month, 182-Every 6 Months, 365-Every Year
		//---------------------------------------------------------------------
		public void setFreq(int a)
		{
			frequency = a;
		}
	}
}
