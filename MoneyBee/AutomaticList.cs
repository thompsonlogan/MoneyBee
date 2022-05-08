//---------------------------------------------------------------
//
// Project: MoneyBee
//
// Purpose: This is a manager class that handles all transactions
//          that repeat. It keeps a list, updates them, and checks
//          if it is the day that it needs to repeat.
//---------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{
	public class AutomaticList
	{

		private static List<Transaction> AutoHistory= new List<Transaction>();

		//---------------------------------------------------------------------
		// adds a transacion to the list of automatic transactions
		//---------------------------------------------------------------------
		public void add(Transaction transaction)
		{
			AutoHistory.Add(transaction);
		}

		//---------------------------------------------------------------------
		// Enumerates through the list and checks if it has been the right 
		// amount of days for the transaction to repeat. Then updates the
		// transaction in the list. Produces an array of new transactions to be
		// added into the transaction history and a number of how many
		// transactions in the array
		//---------------------------------------------------------------------
		public void check(Date today, ref Transaction [] a, int primaryKey, 
			ref int count, int transNumber)
		{
			List<Transaction>.Enumerator em = AutoHistory.GetEnumerator();
			count = 0;
			Date d = new Date();
			while (em.MoveNext())
			{
				if (d.toDate(em.Current.getDate()).daysBetween(today) == 
					em.Current.getFreq())
				{
					update(em.Current,  today, ref a, primaryKey, count, transNumber);
					count++;
				}
			}
		}

		//---------------------------------------------------------------------
		// a private method that updates the automatic transaction and creates
		// a new transaction and places it in the array
		//---------------------------------------------------------------------
		private void update(Transaction t, Date today, ref Transaction[] a,
			int primaryKey, int count, int transNumber)
		{
			TransactionManager transactionManager = new TransactionManager();
			Transaction newTransaction = new Transaction(t);
			t.setDate(today.toString());
			string g = t.getDesc() + " AUTO";
			newTransaction.setDesc(g);
			newTransaction.setAuto(false);
			newTransaction.setFreq(0);
			newTransaction.setDate(today.toString());
			newTransaction.setTransactionNumber(transNumber + count);
			transactionManager.insertTransaction(newTransaction, primaryKey);
			a[count] = newTransaction;
		}

		//---------------------------------------------------------------------
		// Returns the AutoHistory LinkedList
		//---------------------------------------------------------------------
		public List<Transaction> getList()
		{
			return AutoHistory;
		}

		//---------------------------------------------------------------------
		// Removes the transaction from the list at the given index
		//---------------------------------------------------------------------
		public void remove(int index)
		{
			List<Transaction>.Enumerator em = AutoHistory.GetEnumerator();
			int count = 0;
			while (count <= index)
			{
				em.MoveNext();
				count++;
			}
			AutoHistory.Remove(em.Current);
		}

		//---------------------------------------------------------------------
		// Retrieves the automatic transaction from transaction list at index
		// params: (in)
		//---------------------------------------------------------------------
		public Transaction getAutoTransaction(int index)
		{
			return AutoHistory.ElementAt(index);
		}

		//---------------------------------------------------------------------
		// Clears autohistory list
		//---------------------------------------------------------------------
		public void clear()
		{
			AutoHistory.Clear();
		}
	}
}
