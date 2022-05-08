//---------------------------------------------------------------------
//
// MoneyBee: Command
//
//
// Purpose: This class serves as an command interface which facilities 
//          a undo and redo function for the user
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{
    public abstract class Command
    {
        protected TransactionManager transactionManager;

        //---------------------------------------------------------------------
        // Constructor
        // params: (in)
        //---------------------------------------------------------------------
        protected Command(TransactionManager inTransactionManager)
        {
            transactionManager = inTransactionManager;
        }

        //---------------------------------------------------------------------
        // Abstract execute method to be implemented indeoendently for each command
        // params: ()
        //---------------------------------------------------------------------
        public abstract void execute();     //executing the command

        //---------------------------------------------------------------------
        // Abstract unexecute method to be implemented indeoendently for each command
        // params: ()
        //---------------------------------------------------------------------
        public abstract void unexecute();   //undoing the command
    }
}
