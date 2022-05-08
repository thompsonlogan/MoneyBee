//---------------------------------------------------------------------
//
// MoneyBee: EditTransactionCommand
//
// Course:  SE 3330, Spring 2020
//
// Purpose: This class implements the command interface which facilities 
//          editing and unediting transactions for the users. This class also
//          functions with the undo/redo buttons on the MoneyBee form
//          so the user can unedit and reedit a transaction
//---------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{
    public class EditTransactionCommand : Command
    {
        private const int FLIPSIGN = -1;
        private const int EXPENSE = 0;
        string newDesc;
        double newAmount;
        int transactionKey;
        User currentUser;
        Transaction transactionToEdit;
        Transaction transactionToSave;
        DatabaseManager database = new DatabaseManager();

        //---------------------------------------------------------------------
        // Constructor for the edit transaction command. This also envokes the base
        // class Command's constructor
        // params: (in, in, in, in, in, in, in)
        //---------------------------------------------------------------------
        public EditTransactionCommand(User user, Transaction t, TransactionManager transactionManager, int inTransactionKey, double newAmt, string desc) : base(transactionManager)
        {
            this.transactionKey = inTransactionKey;
            this.newAmount = newAmt;
            this.currentUser = user;
            this.transactionToEdit = new Transaction(t);
            this.transactionToSave = new Transaction(t);
            this.newDesc = desc;
        }

        //---------------------------------------------------------------------
        // Executes the edit on a transaction
        // params: ()
        //---------------------------------------------------------------------
        // Note: expenses are stored as positive numbers and revenues as negative numbers
        public override void execute()
        {
            double priceDifference;
            transactionKey = database.getTransactionPrimaryKey(transactionToSave);
            transactionToEdit.setDesc(newDesc);
            if (transactionToSave.getPrice() > EXPENSE) // if it's an expense transaction
            {
                if (newAmount > transactionToSave.getPrice())
                    priceDifference = newAmount - transactionToSave.getPrice();
                else
                    priceDifference = FLIPSIGN * (transactionToSave.getPrice() - newAmount);
                currentUser.changeTotalExpenses(priceDifference);
                transactionToEdit.setPrice(newAmount);
            }
            else // if it's a revenue transaction
            {
                if (newAmount > FLIPSIGN * (transactionToSave.getPrice()))
                    priceDifference = newAmount - FLIPSIGN * transactionToSave.getPrice();
                else
                {
                    priceDifference = (FLIPSIGN * transactionToSave.getPrice()) - newAmount;
                    priceDifference = priceDifference * FLIPSIGN;
                }
                currentUser.updateActualIncome(FLIPSIGN * priceDifference);
                transactionToEdit.setPrice(FLIPSIGN * priceDifference);
            }
            transactionManager.editTransaction(transactionToEdit, transactionKey);
        }

        //---------------------------------------------------------------------
        // Unxecutes, undoes, the edit of the transaction for the user
        // params: ()
        //---------------------------------------------------------------------
        // Note: expenses are stored as positive numbers and revenues as negative numbers
        public override void unexecute()
        {
            double priceDifference;
            transactionToEdit.setPrice(transactionToSave.getPrice());
            transactionToEdit.setDesc(transactionToSave.getDesc());
            if (transactionToSave.getPrice() > EXPENSE)
            {
                if (newAmount > transactionToSave.getPrice())
                    priceDifference = newAmount - transactionToSave.getPrice();
                else
                    priceDifference = FLIPSIGN * (transactionToSave.getPrice() - newAmount);
                currentUser.changeTotalExpenses(FLIPSIGN * priceDifference);
            }
            else
            {
                if (newAmount > FLIPSIGN * (transactionToSave.getPrice()))
                    priceDifference = newAmount - FLIPSIGN * transactionToSave.getPrice();
                else
                {
                    priceDifference = (FLIPSIGN * transactionToSave.getPrice()) - newAmount;
                    priceDifference = priceDifference * FLIPSIGN;
                }
                currentUser.updateActualIncome(priceDifference);
            }
            transactionManager.editTransaction(transactionToEdit, transactionKey);
        }
    }
}
