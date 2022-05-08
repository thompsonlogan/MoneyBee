//---------------------------------------------------------------------
// MoneyBee: User.cs
//
//
// Purpose: Class to encapsulate the data of a registered user.
//          Data is defined by a name (string), a username (string),
//          a password (string), an email address (string),
//          the user's current balance (double), the user's
//          projected income (double), the user's actual income
//          (double), the user's total expenses (double), and
//          the user's relative use in the database.
//
// Input:   Parameters for sets and constructor require inputs
//          See below for more details regarding inputs
//
// Output:  A user object with the data described in the class
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MoneyBee
{
    public class User
    {
        private string name;
        private string username;
        private string password;
        private string email;
        private double currentBalance;
        private double projectedIncome;
        private double actualIncome;
        private double totalExpenses;
        private int primaryKey;
        private bool isloggedIn;
        DatabaseManager database = new DatabaseManager();

        //---------------------------------------------------------------------
        // Constructor for user
        // params: (in, in, in, in, in, in, in, in)
        //---------------------------------------------------------------------
        public User(string inName = "", string inUsername = "",
            string inPassword = "", string inEmail = "",
            double inProjectedIncome = 0, double inActualIncome = 0,
            double inTotalExpense = 0, double inCurrentBalance = 0)
        {
            this.name = inName;
            this.username = inUsername;
            this.password = inPassword;
            this.email = inEmail;
            this.currentBalance = inCurrentBalance;
            this.projectedIncome = inProjectedIncome;
            this.actualIncome = inActualIncome;
            this.totalExpenses = inTotalExpense;
        }

        //---------------------------------------------------------------------
        // Returns the name of the user (testing)
        // params: none
        //---------------------------------------------------------------------
        public string getName()
        {
            return name;
        }

        //---------------------------------------------------------------------
        // Sets the name of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void setName(string inName)
        {
            this.name = inName;
        }

        //---------------------------------------------------------------------
        // Returns the username of the user (testing)
        // params: none
        //---------------------------------------------------------------------
        public string getUsername()
        {
            return username;
        }

        //---------------------------------------------------------------------
        // Sets the username of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void setUsername(string inUsername)
        {
            this.username = inUsername;
        }

        //---------------------------------------------------------------------
        // Returns the password of the user (testing)
        // params: none
        //---------------------------------------------------------------------
        public string getPassword()
        {
            return password;
        }

        //---------------------------------------------------------------------
        // Sets the password of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void setPassword(string inPassword)
        {
            this.password = inPassword;
        }

        //---------------------------------------------------------------------
        // Returns the email address of the user
        // params: none
        //---------------------------------------------------------------------
        public string getEmail()
        {
            return email;
        }

        //---------------------------------------------------------------------
        // Sets the email address of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void setEmail(string inEmail)
        {
            this.email = inEmail;
        }

        //---------------------------------------------------------------------
        // Returns the projected income of the user
        // params: none
        //---------------------------------------------------------------------
        public double getProjectedIncome()
        {
            return projectedIncome;
        }

        //---------------------------------------------------------------------
        // Sets the projected of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void setProjectedIncome(double inProjectedIncome)
        {
            this.projectedIncome = inProjectedIncome;
        }

        //---------------------------------------------------------------------
        // Returns the actual income of the user
        // params: none
        //---------------------------------------------------------------------
        public double getActualIncome()
        {
            return actualIncome;
        }

        //---------------------------------------------------------------------
        // Sets the actual income of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void setActualIncome(double inActualIncome)
        {
            this.actualIncome = inActualIncome;
        }

        //---------------------------------------------------------------------
        // Returns the total expenses of the user
        // params: none
        //---------------------------------------------------------------------
        public double getTotalExpenses()
        {
            return totalExpenses;
        }

        //---------------------------------------------------------------------
        // Sets the total expenses of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void setTotalExpenses(double inTotalExpenses)
        {
            this.totalExpenses = inTotalExpenses;
        }

        //---------------------------------------------------------------------
        // Returns the current balance of the user
        // params: none
        //---------------------------------------------------------------------
        public double getCurrentBalance()
        {
            return currentBalance;
        }

        //---------------------------------------------------------------------
        // Sets the current balance of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void setCurrentBalance(double inCurrentBalance)
        {
            this.currentBalance = inCurrentBalance;
        }

        //---------------------------------------------------------------------
        // Returns the primary key of the user
        // params: none
        //---------------------------------------------------------------------
        public int getPrimaryKey()
        {
            return primaryKey;
        }

        //---------------------------------------------------------------------
        // Sets the primary key of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void setPrimaryKey(int inPrimaryKey)
        {
            this.primaryKey = inPrimaryKey;
        }

        //---------------------------------------------------------------------
        // Returns the log in status of the user
        // params: none
        //---------------------------------------------------------------------
        public bool getloggedInStatus()
        {
            return isloggedIn;
        }

        //---------------------------------------------------------------------
        // Sets the log in status of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void setLoggedInStatus(bool inIsLoggedIn)
        {
            this.isloggedIn = inIsLoggedIn;
        }

        //---------------------------------------------------------------------
        // Updates the balance of the user (based on user's actual income
        // and total expenses)
        // params: none
        //---------------------------------------------------------------------
        public void changeBalance()
        {
            currentBalance = actualIncome - totalExpenses;
        }

        //---------------------------------------------------------------------
        // Updates the total expenses of the user
        // params: (in)
        //---------------------------------------------------------------------
        public void changeTotalExpenses(double inExpense)
        {
            totalExpenses += inExpense;
        }

        //---------------------------------------------------------------------
        // Updates the actual income of the user (based on user's actual
        // income and the transaction amount entered as the parameter
        // params: (in)
        //---------------------------------------------------------------------
        public void updateActualIncome(double transactionAmount)
        {
            this.actualIncome = this.actualIncome - transactionAmount;
        }
    }
}