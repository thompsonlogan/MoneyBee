//---------------------------------------------------------------
//
// Project: MoneyBee
//
// Purpose: Creates a form for the user to interact with, to create a new 
//          transaction.
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBee
{
	public partial class TransactionForm : Form
	{
		private const int YEARLYINDEX = 7;
		private const int SIXMONTHSINDEX = 6;
		private const int MONTHLYINDEX = 5;
		private const int BIWEEKLYINDEX = 4;
		private const int WEEKLYINDEX = 3;
		private const int YEAR = 365;
		private const int SIXMONTHS = 182;
		private const int MONTH = 30;
		private const int BIWEEKLY = 14;
		private const int WEEKLY = 7;
		private const int ADDITION = -1;//used to add additional money to a users account
		int primaryKey = 0;

		AutomaticList AutoList;
		Transaction newTransaction = null;
		CategoryList Cate;
		TransactionHistory transHistory;
		TransactionManager transactionManager = new TransactionManager();
		User currentUser;
		Date currentDate;
		Handler commandHandler;
		DatabaseManager databaseManager = new DatabaseManager();
		public Transaction ReturnData { get; set; }

		//---------------------------------------------------------------------
		// This is a method to create the design form
		//---------------------------------------------------------------------
		public TransactionForm()
		{
			InitializeComponent();
		}

		//---------------------------------------------------------------------
		// Creates the form when running the program
		// params: (in CategoryList, in TransactionHistory, in int, in AutomaticList,
		// in Date, in User)
		//---------------------------------------------------------------------
		public TransactionForm(CategoryList categories, TransactionHistory inTransHistory, int inPrimaryKey, AutomaticList autolist, Date inDate, User inUser, Handler inCommandHandler)
		{
			primaryKey = inPrimaryKey;
			InitializeComponent(categories);
			transHistory = inTransHistory;

			for (int i = 0; i < categories.getLength(); i++)
				CatePicker.Items.Add(categories.getCategory(i).getCategoryTitle());

			AutoList = autolist;
			Cate = categories;
			currentUser = inUser;
			currentDate = inDate;
			commandHandler = inCommandHandler;
		}


		//---------------------------------------------------------------------
		// Enables the Frequency label and Combobox or disables 
		// params: (in object, in EventArgs)
		//---------------------------------------------------------------------
		private void AutoCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (FreqCB.Enabled == false)
			{
				FreqCB.Enabled = true;
				FrequencyLb.Enabled = true;
			}
			else
			{
				FreqCB.Enabled = false;
				FrequencyLb.Enabled = false;
			}
		}

		//---------------------------------------------------------------------
		// Checks if there was an error with the information entered in
		// if not Creates the new Transaction
		// if so displays a relevent error message
		// params: (in object, in EventArgs)
		//---------------------------------------------------------------------
		private void CreateButt_Click_1(object sender, EventArgs e)
		{
			Category category = null;
			Transaction trans = transHistory.getLastTransaction();
			int transnumber = 0;// set for the frist transaction

			//setting the transaction number for the transaction if there was a previous transaction
			if (trans != null)
				transnumber = transHistory.getTransactionCount();
			Date d = new Date();
			//if expense and addition or checked. ERROR.
			if (cbExpense.Checked && cbRevenue.Checked)
				lblError.Show();
			else if (AutoCheck.Checked == true && FreqCB.Text == " ")
				AutomaticError.Visible = true;
			else if (d.toDate(DateTimePicker.Value.ToShortDateString()).isBefore(currentDate))
				DateErr.Visible = true;

			//if revenue is checked or expense is checked and category is not selected. NOTE: can not have a revenue in a category
			else if (cbRevenue.Checked || (cbExpense.Checked && CatePicker.Text == ""))
			{
				int auto;
				if (AutoCheck.Checked == false)
					auto = 0;
				else
				{
					string tbString = FreqCB.Text;
					string frequency = tbString.Substring(0, 1);
					auto = Int32.Parse(frequency);
					if (auto == YEARLYINDEX)
						auto = YEAR;
					else if (auto == SIXMONTHSINDEX)
						auto = SIXMONTHS;
					else if (auto == MONTHLYINDEX)
						auto = MONTH;
					else if (auto == BIWEEKLYINDEX)
						auto = BIWEEKLY;
					else if (auto == WEEKLYINDEX)
						auto = WEEKLY;
				}

				if (cbRevenue.Checked)
				{
					newTransaction = new Transaction(DescTB.Text,
					ADDITION * Double.Parse(PriceTB.Text),
					null,
					DateTimePicker.Value.ToShortDateString(), DateTimePicker.Value.ToShortTimeString(), transnumber, AutoCheck.Checked, auto);
				}
				else
				{
					newTransaction = new Transaction(DescTB.Text,
					Double.Parse(PriceTB.Text),
					null,
					DateTimePicker.Value.ToShortDateString(), DateTimePicker.Value.ToShortTimeString(), transnumber, AutoCheck.Checked, auto);
				}

				if (AutoCheck.Checked == true)
				{
					AutoList.add(newTransaction);
					currentUser.changeBalance();
				}

				commandHandler.addTransaction(newTransaction, primaryKey);
				this.ReturnData = newTransaction;
				this.Visible = false;
			}

			//if expense is checked
			else if (cbExpense.Checked)
			{
				int auto;
				if (AutoCheck.Checked == false)
					auto = 0;
				else
				{
					string tbString = FreqCB.Text;
					string frequency = tbString.Substring(0, 1);
					auto = Int32.Parse(frequency);
				}

				category = Cate.getCategory(Cate.getIndex(CatePicker.Text));

				newTransaction = new Transaction(DescTB.Text,
					Double.Parse(PriceTB.Text),
					category, DateTimePicker.Value.ToShortDateString(),
					DateTimePicker.Value.ToShortTimeString(), transnumber, AutoCheck.Checked, auto);

				if (AutoCheck.Checked == true)
				{
					AutoList.add(newTransaction);

					currentUser.changeBalance();
				}

				AutoList.add(newTransaction);

				updateCategoryOnNewTransaction(newTransaction, category, primaryKey);

				this.ReturnData = newTransaction;
				this.Visible = false;
			}
		}

		//---------------------------------------------------------------------
		// Updates category for a new transaction
		// params: (in, in, in)
		//---------------------------------------------------------------------
		public void updateCategoryOnNewTransaction(Transaction transaction, Category category, int primaryKey)
		{
			int categoryKey = databaseManager.getCategoryPrimaryKey(category);
			transaction.setCategory(category);
			category.addTransaction(transaction);
			databaseManager.updateCategoryToDatabase(category, categoryKey);
			commandHandler.addTransaction(transaction, primaryKey);
		}

		//---------------------------------------------------------------------
		// Enables the Frequency label and Combobox or disables 
		// params: (in object, in EventArgs)
		//---------------------------------------------------------------------
		private void AutoCheck_CheckedChanged_2(object sender, EventArgs e)
		{
			if (AutoCheck.Checked)
			{
				FreqCB.Enabled = true;
				FrequencyLb.Enabled = true;
			}
			else
			{
				FreqCB.Enabled = false;
				FrequencyLb.Enabled = false;
			}
		}
	}
}
