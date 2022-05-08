//---------------------------------------------------------------------
//
// MoneyBee: AddCategoryCommand
//
//
// Purpose: This class implements the command interface which facilities 
//          adding and removing transactions for the users. This class also
//          functions with the undo/redo buttons on the MoneyBee form
//          so the user can undo and redo the creation of transactions
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{
    public class AddTransactionCommand : Command
    {
        int primaryKey;
        Transaction transactionToAdd;

        //---------------------------------------------------------------------
        // Constructor for the add transaction command. This also envokes the base
        // class Command's constructor
        // params: (in, in, in, in)
        //---------------------------------------------------------------------
        public AddTransactionCommand(Transaction t, TransactionManager transManger, int inPrimaryKey) : base(transManger)
        {
            this.primaryKey = inPrimaryKey;
            this.transactionToAdd = t;
        }

        //---------------------------------------------------------------------
        // Executes the creation of a transaction for the user
        // params: ()
        //---------------------------------------------------------------------
        public override void execute()
        {
            base.transactionManager.insertTransaction(transactionToAdd, primaryKey);
        }

        //---------------------------------------------------------------------
        // Unexecutes, undoes the creation of a transaction for the user
        // params: ()
        //---------------------------------------------------------------------
        public override void unexecute()
        {
            base.transactionManager.deleteTransaction(transactionToAdd, primaryKey);
        }
    }
}
