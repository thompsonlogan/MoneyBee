//---------------------------------------------------------------------
//
// MoneyBee: Login Manager
//
//
// Purpose: This class functions in managing the login process and
//          communicates with the database manager to ensure all the 
//          correct information is pulled for the user when they log
//          in to the system, as well as validating users login atempts
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{
    public class LoginManager
    {
        User user;
        int primaryKey;
        DatabaseManager database = new DatabaseManager();

        //---------------------------------------------------------------------
        // Validates a login atempt by checking with username password pairs
        // with the database manager
        // params: (in, in)
        //---------------------------------------------------------------------
        public bool validateLogin(string inPassword, int primaryKey)
        {
            string savedPassword = database.getPasswordFromDatabase(primaryKey);
            if (savedPassword == inPassword)
                return true;
            return false;
        }

        //---------------------------------------------------------------------
        // Logs in a user and pulls all the relevant information from the 
        // datbase manager for them to login and for the forms to work
        // properly
        // params: ()
        //---------------------------------------------------------------------
        public User loginUser()
        {
            user = new User();
            user.setName(database.getUsernameFromDatabase(primaryKey));
            user.setUsername(database.getUsernameFromDatabase(primaryKey));
            user.setPassword(database.getPasswordFromDatabase(primaryKey));
            user.setEmail(database.getEmailFromDatabase(primaryKey));
            user.setProjectedIncome(database.getProjectedIncomeFromDatabase(primaryKey));
            user.setActualIncome(database.getActualIncomeFromDatabase(primaryKey));
            user.setTotalExpenses(database.getTotalExpensesFromDatabase(primaryKey));
            user.setLoggedInStatus(true);
            user.setPrimaryKey(primaryKey);
            return user;
        }

        //---------------------------------------------------------------------
        // Retrives the primary key associtaed with the users username 
        // from the datbase
        // params: (in)
        //---------------------------------------------------------------------
        public int getPrimaryKeyFromDBManager(string username)
        {
            this.primaryKey = database.getPrimaryKey(username);
            return primaryKey;
        }

        //---------------------------------------------------------------------
        // Sets the current users primary key
        // params: (in)
        //---------------------------------------------------------------------
        public void setPrimaryKey(int inPrimaryKey)
        {
            this.primaryKey = inPrimaryKey;
        }

        //---------------------------------------------------------------------
        // Returns the current users primary key
        // params: ()
        //---------------------------------------------------------------------
        public int getPrimaryKey()
        {
            return primaryKey;
        }
    }
}
