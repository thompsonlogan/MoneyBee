//---------------------------------------------------------------------
// Name: Nathan Kawula
// MoneyBee: TransactionHistory.cs (Class/Linked List)
//
// Course:  SE 3330, Spring 2020
//
// Purpose: Linked List of Transaction object creations
//
// Input:   Newly created transaction objects
//
// Output:  A list of the transaction objects that were created
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{

    //---------------------------------------------------------------------
    // Classlet contents for nodes of the TransactionHistory
    // params: none
    //---------------------------------------------------------------------
    public class TransactionNode
    {
        public TransactionNode next;
        public Transaction Data;
    }
    public class TransactionHistory
    {
        public TransactionNode head;
        private int transactionCount = 0;

        //---------------------------------------------------------------------
        // Add a new transaction to the list
        // params: (in)
        //---------------------------------------------------------------------
        public void AddTransaction(Transaction inData)
        {
            TransactionNode newTransaction = new TransactionNode();
            newTransaction.Data = inData;
            newTransaction.next = head;

            head = newTransaction;

            transactionCount += 1;
        }

        //---------------------------------------------------------------------
        // Returns the number of transactions in transaction history
        // params: none
        //---------------------------------------------------------------------
        public int getTransactionCount()
        {
            return transactionCount;
        }

        //---------------------------------------------------------------------
        // Sets the count for transaction history
        // params: (in)
        //---------------------------------------------------------------------
        public void setTransactionCount(int inTransactionCount)
        {
            transactionCount = inTransactionCount;
        }

        //---------------------------------------------------------------------
        // Retrieves the transaction from the transaction history at
        // specified index
        // params: (in)
        //---------------------------------------------------------------------
        public Transaction getTransaction(int index)
        {
            TransactionNode transPtr = head;
            if(index == 0)
            {
                return head.Data;
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    transPtr = transPtr.next;
                }
                return transPtr.Data;
            }
        }

        //---------------------------------------------------------------------
        // Returns the most recent transaction
        // params: none
        //---------------------------------------------------------------------
        public Transaction getLastTransaction()
        {
            TransactionNode transPtr = head;
            if (head == null)
            {
                return null;
            }
            else
            {
                while (transPtr.next != null)
                {
                    transPtr = transPtr.next;
                }
                return transPtr.Data;
            }
        }

        //---------------------------------------------------------------------
        // Returns the first item in transaction history
        // params: none
        //---------------------------------------------------------------------
        public Transaction getHead()
        {
            if (head == null)
                return null;
            return this.head.Data;
        }

        //---------------------------------------------------------------------
        // Clears transaction history
        // params: none
        //---------------------------------------------------------------------
        public void clear()
        {
            this.transactionCount = 0;
            this.head = null;
        }
    }
}
