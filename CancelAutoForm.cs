//---------------------------------------------------------------
//
// Project: MoneyBee
//
// Purpose: This form is where the user can select automatic transactions
//          that they wish to no longer be implemented. 
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
	
	public partial class CancelAutoForm : Form
	{
		private DatabaseManager databaseManager = new DatabaseManager();
		private AutomaticList  removal = new AutomaticList();
		private static List<Transaction> autoList = new List<Transaction>();
		//---------------------------------------------------------------------
		// Displays the form in Designer mode
		//---------------------------------------------------------------------
		public CancelAutoForm()
		{
			InitializeComponent();
		}

		//---------------------------------------------------------------------
		// Displays the form in run mode with the given automaticlist
		//---------------------------------------------------------------------
		public CancelAutoForm(AutomaticList alist)
		{
			InitializeComponent();
			autoList = alist.getList();
			removal = alist;
			AutoListBox.Items.Clear();
			List<Transaction>.Enumerator em = autoList.GetEnumerator();
			while (em.MoveNext())
			{
				AutoListBox.Items.Add(em.Current.getDate() + " " + em.Current.getPrice() + " " + em.Current.getDesc(), false);
			}
		}

		//---------------------------------------------------------------------
		// Removes the checked Autotransaction when the deletebutton is clicked
		// if none are selected, presents the error message
		//---------------------------------------------------------------------

		private void DeleteButt_Click_1(object sender, EventArgs e)
		{
			Transaction temp;
			if (AutoListBox.CheckedItems.Count == 0)
				label2.Visible = true;
			else
			{
				int count = 0;
				while (count < AutoListBox.CheckedItems.Count)
				{
					temp = removal.getAutoTransaction(AutoListBox.CheckedIndices[count]);
					int transactionKey = databaseManager.getTransactionPrimaryKey(temp);
					temp.setAuto(false);
					databaseManager.updateTransactionToDatabase(temp, transactionKey);
					removal.remove(AutoListBox.CheckedIndices[count]);
					count++;
				}
				this.Close();
			}
		}
	}
}
