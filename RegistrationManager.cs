//---------------------------------------------------------------------
//
// MoneyBee: Registration Manager
//
//
// Purpose: This class functions in managing the regrestration process
//          for the user and communicates with the database manger
//          to accomplish this
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{
    public class RegistrationManager
    {
        private const int USERNAME_IN_DB = 0;
        DatabaseManager database = new DatabaseManager();

        //---------------------------------------------------------------------
        // Checks with the datbase manager to see if a username already exists
        // params: (in)
        //---------------------------------------------------------------------
        public bool usernameExists(string username)
        {
            return database.getPrimaryKey(username) != USERNAME_IN_DB;
        }

        //---------------------------------------------------------------------
        // Registers a new user to the database
        // params: (in)
        //---------------------------------------------------------------------
        public void registerUser(string username, string password, string name, string email, double projectedIncome, double actualIncome)
        {
            database.insertNewUser(username, password, name, email, projectedIncome, actualIncome);
        }
    }
}
