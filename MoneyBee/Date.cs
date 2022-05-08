//---------------------------------------------------------------
//
// Project: MoneyBee
//
// Purpose: FOR TESTING/DEMONSTRATION PURPOSES-- creates an object that
//          holds 3 integers day, month, and year. Used for testing
//          functions in the moneybee program. .
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{

	public class Date
	{
		//Date //Will be printed MM/DD/YYYY
		private int month;
		private int day;
		private int year;

		//---------------------------------------------------------------------
		// Constructor
		//---------------------------------------------------------------------
		public Date()
		{
			month = DateTime.Now.Month;
			day = DateTime.Now.Day;
			year = DateTime.Now.Year;
		}

		//---------------------------------------------------------------------
		// copy constructor
		//---------------------------------------------------------------------
		public Date(Date copy)
		{
			month = copy.month;
			day = copy.day;
			year = copy.year;
		}

		//---------------------------------------------------------------------
		// Increments the date by one day
		//---------------------------------------------------------------------
		public void increDay()
		{
			//incrementing the day
			day++;

			//leap year febuary last day
			if (year % 4 == 0 && month == 2 && day == 30)
			{
				day = 1;
				month++;
			}

			//normal year febuary last day
			if (month == 2 && day == 29)
			{
				day = 1;
				month++;
			}

			//last day of 31 day month
			if ((month == 1 || month == 3 || month == 5 ||
				month == 7 || month == 8 || month == 10 ||
				month == 12) && day == 32)
			{
				day = 1;
				month++;
			}

			//last day of 30 day month
			if ((month == 4 || month == 6 || month == 9 ||
				month == 11) && day == 31)
			{
				day = 1;
				month++;
			}

			//last day of year
			if (month == 13)
			{
				month = 1;
				year++;
			}
		}

		//---------------------------------------------------------------------
		// Returns a string of the date in the format of MM/DD/YYYY
		//---------------------------------------------------------------------
		public string toString()
		{
			return month.ToString() + "/" + day.ToString()
				+ "/" + year.ToString();
		}

		//---------------------------------------------------------------------
		// Returns the Month integer
		//---------------------------------------------------------------------
		public int getMonth()
		{
			return month;
		}

		//---------------------------------------------------------------------
		// Returns the Day integer
		//---------------------------------------------------------------------
		public int getDay()
		{
			return day;
		}

		//---------------------------------------------------------------------
		// Returns the Year integer
		//---------------------------------------------------------------------
		public int getYear()
		{
			return year;
		}

		//---------------------------------------------------------------------
		// An overide operator for the ==(isequals) boolean. Returns whether
		// the two dates are the same. 
		//---------------------------------------------------------------------
		public static bool operator ==(Date a, Date b)
		{
			if (a.year == b.year && a.month == b.month && a.day == b.day)
				return true;
			else
				return false;
		}

		//---------------------------------------------------------------------
		// An overide operator for the !=(isnotequal) boolean. Returns whether
		// the two dates are not the same. 
		//---------------------------------------------------------------------
		public static bool operator !=(Date a, Date b)
		{
			if (a.year == b.year && a.month == b.month && a.day == b.day)
				return false;
			else
				return true;
		}


		//---------------------------------------------------------------------
		// Returns the number of days between the two dates given. 
		// *****THE LATER DATE SHOULD BE THE ONE IN PARENTHESES*************
		//---------------------------------------------------------------------
		public int daysBetween(Date t)
		{
			Date iter = new Date(this);
			Date today = new Date(t);
			int count = 0;
			while (iter != today)
			{
				iter.increDay();
				count++;
			}
			//count++;
			return count;
		}

		//---------------------------------------------------------------------
		// Returns whether the date is before the parameter date.
		//---------------------------------------------------------------------
		public bool isBefore(Date t)
		{
			if (year < t.year)
				return true;
			else if (year > t.year)
				return false;
			else
			{
				if (month < t.month)
					return true;
				else if (month > t.month)
					return false;
				else
				{
					if (day < t.day)
						return true;
					else
						return false;
				}
			}
		}

		//---------------------------------------------------------------------
		// Returns the Date form of a string
		//---------------------------------------------------------------------
		public Date toDate(String s)
		{
			Date d = new Date();
			string[] num = s.Split('/');
			d.setMonth(int.Parse(num[0]));
			d.setDay(int.Parse(num[1]));
			d.setYear(int.Parse(num[2]));
			return d;
		}

		//---------------------------------------------------------------------
		// Sets the month integer to the given value
		//---------------------------------------------------------------------
		public void setMonth(int m)
		{
			month = m;
		}

		//---------------------------------------------------------------------
		// Sets the day integer to the given value
		//---------------------------------------------------------------------
		public void setDay(int d)
		{
			day = d;
		}

		//---------------------------------------------------------------------
		// Sets the year integer to the given value
		//---------------------------------------------------------------------
		public void setYear(int y)
		{
			year = y;
		}
	}
}
