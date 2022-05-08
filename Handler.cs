//---------------------------------------------------------------------
//
// MoneyBee: Handler
//
//
// Purpose: This class functions in handeling all commands that can
//          be undone and redone. This class manages the history class
//          in differentation between different type of commands and
//          executing differently depending on the type of command
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{
    public class Handler
    {
        History history = new History();
        TransactionManager transactionManager = new TransactionManager();

        //---------------------------------------------------------------------
        // Command to add a tractions for the user
        // params: (in, in)
        //---------------------------------------------------------------------
        public void addTransaction(Transaction t, int primaryKey)
        {
            history.doCommand(new AddTransactionCommand(t, transactionManager, primaryKey));
        }

        //---------------------------------------------------------------------
        // Command to add a category for the user
        // params: (in, in)
        //---------------------------------------------------------------------
        public void addCategory(Category c, int primaryKey)
        {
            history.doCommand(new AddCategoryCommand(c, transactionManager, primaryKey));
        }

        //---------------------------------------------------------------------
        // Command to edit a transaction for the user
        // params: (in, in)
        //---------------------------------------------------------------------
        public void editTransaction(User user, Transaction t, int tk, double na, string desc)
        {
            history.doCommand(new EditTransactionCommand(user, t, transactionManager, tk, na, desc));
        }

        //---------------------------------------------------------------------
        // Returns the history of commands so the users can undo/redo commands
        // from buttons on the moneybee form
        // params: ()
        //---------------------------------------------------------------------
        public History getHistory()
        {
            return this.history;
        }
    }
}
