//---------------------------------------------------------------------
//
// MoneyBee: AddCategoryCommand
//
//
// Purpose: This class implements the command interface which facilities 
//          adding and removing categorys for the users. This class also
//          functions with the undo/redo buttons on the MoneyBee form
//          so the user can undo and redo the creation of categories
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{
    class AddCategoryCommand : Command
    {
        int primaryKey;
        Category categoryToAdd;

        //---------------------------------------------------------------------
        // Constructor for the add category command. This also envokes the base
        // class Command's constructor
        // params: (in, in, in, in)
        //---------------------------------------------------------------------
        public AddCategoryCommand(Category c, TransactionManager transManger, int inPrimaryKey) : base(transManger)
        {
            this.primaryKey = inPrimaryKey;
            this.categoryToAdd = c;
        }

        //---------------------------------------------------------------------
        // Executes the creation of a category for the user
        // params: ()
        //---------------------------------------------------------------------
        public override void execute()
        {
            base.transactionManager.insertCategory(categoryToAdd, primaryKey);
        }

        //---------------------------------------------------------------------
        // Unexecutes, undoes the creation of a category for the user
        // params: ()
        //---------------------------------------------------------------------
        public override void unexecute()
        {
            base.transactionManager.deleteCategory(categoryToAdd, primaryKey);
        }
    }
}
