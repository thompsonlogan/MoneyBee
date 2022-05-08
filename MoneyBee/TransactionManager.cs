//---------------------------------------------------------------------
// Name: Logan
//
// MoneyBee: Transaction Manager
//
// Course:  SE 3330, Spring 2020
//
// Purpose: This class functions in manage the creating and removal of
//          of categories and transaction as well as functions in setting
//          up undo and redo functions for the user.
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBee;

namespace MoneyBee
{
    public class TransactionManager
    {
        DatabaseManager databaseManager = new DatabaseManager();

        //---------------------------------------------------------------------
        // Inserts a new transaction for the user and sends all transaction
        // information to different parts of the system i.e the database, 
        // U.I forms, and the command stacks(undo/redo).
        // params: (in, in)
        //---------------------------------------------------------------------
        public void insertTransaction(Transaction transaction, int primaryKey)
        {
            databaseManager.addTransaction(transaction);
            int transactionKey = databaseManager.getTransactionPrimaryKey(transaction);
            if (transaction.getCategory() != null) // if the category is associated with a category
            {
                int categoryKey = databaseManager.getCategoryPrimaryKey(transaction.getCategory());
                databaseManager.linkCategoryToTransaction(categoryKey, transactionKey);
                transaction.getCategory().redoTransaction(transaction.getPrice());
                databaseManager.updateCategoryToDatabase(transaction.getCategory(), categoryKey);
            }
            databaseManager.linkTransactionToUser(primaryKey, transactionKey);
        }

        //---------------------------------------------------------------------
        // Removes a transction from the user and send all transaction information
        // to different part of the system i.e the database, U.I forms, and the 
        // command stacks(undo/redo).
        // params: (in, in)
        //---------------------------------------------------------------------
        public void deleteTransaction(Transaction transaction, int primaryKey)
        {
            if (transaction.getCategory() == null) // if the transaction is not associated with a category
            {
                int transactionKey = databaseManager.getTransactionPrimaryKey(transaction);
                int transactionLinkKey = databaseManager.getTransactionLinkKey(transactionKey);
                databaseManager.deleteTransactionUserLink(transactionLinkKey);
                databaseManager.deleteTransaction(transactionKey);
            }
            else // if the transation is associated with a category
            {
                int transactionKey = databaseManager.getTransactionPrimaryKey(transaction);
                int transactionLinkKey = databaseManager.getTransactionLinkKey(transactionKey);
                int categoryTransactionLinkKey = databaseManager.getCategoryTransactionLinkKey(transactionKey);
                int categoryKey = databaseManager.getCategoryPrimaryKey(transaction.getCategory());
                transaction.getCategory().undoTransaction(transaction.getPrice());
                databaseManager.updateCategoryToDatabase(transaction.getCategory(), categoryKey);
                databaseManager.deleteCategoryTransactionLink(categoryTransactionLinkKey);
                databaseManager.deleteTransactionUserLink(transactionLinkKey);
                databaseManager.deleteTransaction(transactionKey);
            }
        }

        //---------------------------------------------------------------------
        // Inserts a new cateogry for the user and sends all category
        // information to different parts of the system i.e the database, 
        // U.I forms, and the command stacks(undo/redo).
        // params: (in, in)
        //---------------------------------------------------------------------
        public void insertCategory(Category category, int primaryKey)
        {
            databaseManager.addCategory(category);
            int categoryKey = databaseManager.getCategoryPrimaryKey(category);
            databaseManager.linkCategoryToUser(primaryKey, categoryKey);
        }

        //---------------------------------------------------------------------
        // Removes a category from the user and send all category information
        // to different part of the system i.e the database, U.I forms, and the 
        // command stacks(undo/redo).
        // params: (in, in)
        //---------------------------------------------------------------------
        public void deleteCategory(Category category, int primaryKey)
        {
            int categoryKey = databaseManager.getCategoryPrimaryKey(category);
            int categoryLinkKey = databaseManager.getCategoryUserLinkKey(categoryKey);
            databaseManager.deleteUserCategoryLink(categoryLinkKey);
            databaseManager.deleteCategory(categoryKey);
        }

        //---------------------------------------------------------------------
        // Edits a transactions in the database. Updates the transaction
        // in the database connected to the transaction key with the vales
        // passed in the transaction object
        // params: (in, in)
        //---------------------------------------------------------------------
        public void editTransaction(Transaction transaction, int transactionKey)
        {
            databaseManager.updateTransactionToDatabase(transaction, transactionKey);
        }
    }
}
