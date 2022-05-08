//---------------------------------------------------------------------
// MoneyBee: Category.cs (Class)
//
//
// Purpose: Object that encapsulates a title, a budget, a priority
//          rating, a total, a difference (between total and budget),
//          a count of transactions, and transaction history for a
//          a category. Creating a category object requires a title,
//          a budget, and a priority rating.
//
// Input:   A title (string), a budget (double), and a priority rating
//          (int) in the fields of the MoneyBeeForm's Categories tab
//
// Output:  A newly formed category whose transaction history and
//          difference are dynamically updated with each new
//          transaction that has been assigned to respective category
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{
    public class Category
    {
        private int priorityRating;
        private string categoryTitle;
        private double budget = 0.00;
        public int transactionCount = 0;
        private double difference = 0.00;
        private double categoryTotal = 0.00;
        public TransactionHistory categoryHistory = new TransactionHistory();

        //---------------------------------------------------------------------
        // Constructor for Category object. Takes title, budget, and priority
        // params: (in, in, in)
        //---------------------------------------------------------------------
        public Category(string title, double budget, int priority)
        {
            this.categoryTitle = title;
            this.budget = budget;
            this.priorityRating = priority;
        }

        //---------------------------------------------------------------------
        // Constructor for creating Category objects based on
        // database information
        // params: (in, in, in, in, in, in)
        //---------------------------------------------------------------------
        public Category(string inTitle, int inPriorityRating,
            double inCategoryTotal, int inTransactionCount,
            double inBudget, double inDifference)
        {
            this.categoryTitle = inTitle;
            this.priorityRating = inPriorityRating;
            this.categoryTotal = inCategoryTotal;
            this.transactionCount = inTransactionCount;
            this.budget = inBudget;
            this.difference = inDifference;
        }

        //---------------------------------------------------------------------
        // Sets the priority rating of the Category object
        // params: (in)
        //---------------------------------------------------------------------
        public void setPriorityRating(int inPrioRating)
        {
            this.priorityRating = inPrioRating;
        }

        //---------------------------------------------------------------------
        // Gets the priority rating of the Category object
        // params: none
        //---------------------------------------------------------------------
        public int getPriorityRating()
        {
            return this.priorityRating; 
        }

        //---------------------------------------------------------------------
        // Sets the number of transactions of the Category object
        // params: (in)
        //---------------------------------------------------------------------
        public void setTransactionCount(int inTransactionCount)
        {
            this.transactionCount = inTransactionCount;
        }

        //---------------------------------------------------------------------
        // Gets the number of transactions of the Category object
        // params: none
        //---------------------------------------------------------------------
        public int getTransactionCount()
        {
            return this.transactionCount;
        }

        //---------------------------------------------------------------------
        // Sets the title of the Category object
        // params: (in)
        //---------------------------------------------------------------------
        public void setCategoryTitle(string inCateTitle)
        {
            this.categoryTitle = inCateTitle;
        }

        //---------------------------------------------------------------------
        // Gets the title of the Category object
        // params: none
        //---------------------------------------------------------------------
        public string getCategoryTitle()
        {
            return this.categoryTitle;
        }

        //---------------------------------------------------------------------
        // Sets the spending limit of the Category object
        // params: (in)
        //---------------------------------------------------------------------
        public void setBudget(double inBudget)
        {
            this.budget = inBudget;
            updateDifference();
        }

        //---------------------------------------------------------------------
        // Gets the spending limit of the Category object
        // params: none
        //---------------------------------------------------------------------
        public double getBudget()
        {
            return this.budget;
        }

        //---------------------------------------------------------------------
        // Gets the expenditure total of the Category object
        // params: none
        //---------------------------------------------------------------------
        public double getCategoryTotal()
        {
            return this.categoryTotal;
        }

        //---------------------------------------------------------------------
        // Increments the expenditure total of the Category object
        // and updates difference
        // params: (in)
        //---------------------------------------------------------------------
        public void incrementCategoryTotal(double expenseAmount)
        {
            this.categoryTotal += expenseAmount;
            updateDifference();
        }

        //---------------------------------------------------------------------
        // Adds a transaction to Category object, updating the total,
        // the number of transactions, and the category's history.
        // params: (in)
        //---------------------------------------------------------------------
        public void addTransaction(Transaction inTran)
        {
            categoryHistory.AddTransaction(inTran);
            updateDifference();
        }

        //---------------------------------------------------------------------
        // Used to load transactions and their data from the database
        // params: (in)
        //---------------------------------------------------------------------
        public void loadTransactionFromDatabase(Transaction transaction)
        {
            categoryHistory.AddTransaction(transaction);
        }

        //---------------------------------------------------------------------
        // Returns the details of a transaction from a category's list of
        // transactions
        // params: (in)
        //---------------------------------------------------------------------
        public TransactionNode getTransactionDetails(int index)
        {
            TransactionNode currentTransaction = categoryHistory.head;

            for (int i = 0; i < index; i++)
            {
                currentTransaction = currentTransaction.next;
            }

            return currentTransaction;
        }

        //---------------------------------------------------------------------
        // Gets the difference between budget and total of the Category Object
        // params: none
        //---------------------------------------------------------------------
        public double getDifference()
        {
            updateDifference();
            return this.difference;
        }

        //---------------------------------------------------------------------
        // Updates the difference between budget and total of the Category
        // object
        // params: none
        //---------------------------------------------------------------------
        public void updateDifference()
        {
            this.difference = this.getBudget() - this.getCategoryTotal();
        }

        //---------------------------------------------------------------------
        // Undoes and unwanted transaction
        // params: (in)
        //---------------------------------------------------------------------
        public void undoTransaction(double price)
        {
            this.categoryTotal = categoryTotal - price;
            updateDifference();
            this.transactionCount = this.transactionCount - 1;
        }

        //---------------------------------------------------------------------
        // Redoes a wanted transaction
        // params: (in)
        //---------------------------------------------------------------------
        public void redoTransaction(double price)
        {
            this.categoryTotal = categoryTotal + price;
            updateDifference();
            this.transactionCount = this.transactionCount + 1;
        }
    }
}
