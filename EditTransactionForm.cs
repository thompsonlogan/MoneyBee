//---------------------------------------------------------------
//
// Project: MoneyBee
//
// Purpose: General purpose of code and/or declarations in the file.
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
    // -------------------------------------------------------------------
    // This is the class that opens/deals with the form
    // -------------------------------------------------------------------
    public partial class originalTransactionDate : Form
    {
        TransactionManager transactionManager = new TransactionManager();
        DatabaseManager databaseManager = new DatabaseManager();
        Transaction editTrans = new Transaction();
        Handler commandHandler;
        User currentUser;
        double nAmt = 0.0;
        int transactionKey;
        private const int FLIPSIGN = -1;
        private const int EXPENSE = 0;

        //---------------------------------------------------------------------
        // Intializes the form
        //---------------------------------------------------------------------
        public originalTransactionDate(TransactionHistory transHis, int index, User user, Handler handler)
        {
            InitializeComponent();
            editTrans = transHis.getTransaction(index);
            transactionKey = databaseManager.getTransactionPrimaryKey(editTrans);
            if(editTrans.getPrice() > 0)
                originalTransactionDisplay.Text = editTrans.getPrice().ToString();
            else
                originalTransactionDisplay.Text = (-1*editTrans.getPrice()).ToString();
            originalTransactionDateDisplay.Text = editTrans.getDate().ToString();
            originalTransactionDescriptionDisplay.Text = editTrans.getDesc().ToString();
            this.currentUser = user;
            this.commandHandler = handler;
        }

        // -------------------------------------------------------------------
        // This closes the form when the user clicks on the change button and 
        // all of the fields are filled out
        // -------------------------------------------------------------------
        private void transactionChange_Click(object sender, EventArgs e)
        {
            String nDesc = editDescIntake.Text;
            String enteredAmount = changeOrigAmountBy.Text;

            if ((string.IsNullOrEmpty(editDescIntake.Text) == true) || (string.IsNullOrEmpty(changeOrigAmountBy.Text)) == true)
            {
                lblmissingField.Show();
            }
            else
            {
                nAmt = Convert.ToDouble(enteredAmount);
                commandHandler.editTransaction(currentUser, editTrans, transactionKey, nAmt, nDesc);
                this.Visible = false;
            }
        }
    }
}