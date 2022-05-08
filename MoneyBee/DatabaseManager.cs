//---------------------------------------------------------------------
//
// MoneyBee: Database Manager
//
//
// Purpose: The class functions as a middle man between the forms and 
//          the domain level class and functions in managing all
//          all information being change in the system. Also functions
//          in retreving and saving information to and from the database
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MoneyBee
{
    public class DatabaseManager
    {
        private string connectionString;
        const int USERNAME_NOT_IN_DB = 0;//constant to represnt a 0 index in the db, i.e that username does not exist
        private SqlConnection connection;

        //---------------------------------------------------------------------
        // constructor for the datbase manager initializing the connection
        // string to the local database on the users computer
        // params: ()
        //---------------------------------------------------------------------
        public DatabaseManager()
        {
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Logan\\Desktop\\repos\\src\\MoneyBeeProjectMainFolder\\MoneyBee\\MoneyBeeDataBase.mdf;Integrated Security=True";
            //use the lower connection string if the top one does not work. The top string is specific for my computer: logan
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MoneyBeeDataBase.mdf;Integrated Security=True";
        }

        //---------------------------------------------------------------------
        // Function retries the primary key associated with a username, which
        // is used for accessing data associated to the user
        // params: (in)
        //---------------------------------------------------------------------
        public int getPrimaryKey(string username)
        {
            string query = "SELECT Id FROM UserInfo WHERE Username = @Username";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Username", username);
                if (command.ExecuteScalar() == null)
                    return USERNAME_NOT_IN_DB;
                return ((int)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Updates the name associated with the passed primary key in the database
        // params: (in, in)
        //---------------------------------------------------------------------
        // to be used in setting which is not complete
        public void updateNameToDatabase(int primaryKey, string name)
        {
            string query = "UPDATE Userinfo SET Name = @name WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Retrives the name associated with a primary key in the database
        // params: (in)
        //---------------------------------------------------------------------
        // to be used in setting which is not complete
        public string getNameFromDatabase(int primaryKey)
        {
            string query = "SELECT Name FROM UserInfo WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                return ((string)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Updates the username associated with the passed primary key in
        // the database
        // params: (in, in)
        //---------------------------------------------------------------------
        // to be used in setting which is not complete
        public void updateUsernameToDatabase(int primaryKey, string username)
        {
            string query = "UPDATE Userinfo SET Username = @username WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                command.Parameters.AddWithValue("@username", username);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Retrives the username from the database associated with the passed
        // primary key
        // params: (in)
        //---------------------------------------------------------------------
        public string getUsernameFromDatabase(int primaryKey)
        {
            string query = "SELECT Username FROM UserInfo WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                return ((string)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Updates the password associated with the passed primary key 
        // in the database
        // params: (in, in)
        //---------------------------------------------------------------------
        // to be used in setting which is not complete
        public void updatePasswordToDatabase(int primaryKey, string password)
        {
            string query = "UPDATE Userinfo SET Password = @password WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Retrives the password associated with the passed primary key
        // in the database
        // params: (in)
        //---------------------------------------------------------------------
        public string getPasswordFromDatabase(int primaryKey)
        {
            string query = "SELECT Password FROM UserInfo WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                return ((string)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Updates the email associated with the passed primary key in the
        // database
        // params: (in, in)
        //---------------------------------------------------------------------
        // to be used in setting which is not complete
        public void updateEmailToDatabase(int primaryKey, string email)
        {
            string query = "UPDATE Userinfo SET Email = @email WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                command.Parameters.AddWithValue("@email", email);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Retrives the email associated with the passed primary key
        // in the database
        // params: (in)
        //---------------------------------------------------------------------
        public string getEmailFromDatabase(int primaryKey)
        {
            string query = "SELECT Email FROM UserInfo WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                return ((string)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Updates the projacted income associated with the passed primary key
        // in the database
        // params: (in, in)
        //---------------------------------------------------------------------
        public void updateProjectedIncomeToDatabase(int primaryKey, double projectedIncome)
        {
            string query = "UPDATE Userinfo SET ProjectedIncome = @projectedIncome WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                command.Parameters.AddWithValue("@projectedIncome", projectedIncome);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Retrives the projected income associated with the passed primary key
        // in the database
        // params: (in)
        //---------------------------------------------------------------------
        public double getProjectedIncomeFromDatabase(int primaryKey)
        {
            string query = "SELECT ProjectedIncome FROM UserInfo WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                return ((double)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Updates the actual income associated with the passed primary key
        // in the database
        // params: (in, in)
        //---------------------------------------------------------------------
        public void updateActualIncomeToDatabase(int primaryKey, double actualIncome)
        {
            string query = "UPDATE Userinfo SET ActualIncome = @actualIncome WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                command.Parameters.AddWithValue("@actualIncome", actualIncome);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Retrives the actual income associated with the pass primary key
        // in the database
        // params: (in)
        //---------------------------------------------------------------------
        public double getActualIncomeFromDatabase(int primaryKey)
        {
            string query = "SELECT ActualIncome FROM UserInfo WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                return ((double)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Updates the total expense associtaed with the passed primary key
        // in the database
        // params: (in, in)
        //---------------------------------------------------------------------
        public void updateTotalExpensesToDatabase(int primaryKey, double totalExpenses)
        {
            string query = "UPDATE Userinfo SET TotalExpenses = @totalExpenses WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                command.Parameters.AddWithValue("@totalExpenses", totalExpenses);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Retrives the total expense associated with the passed primary key
        // in the datbase
        // params: (in)
        //---------------------------------------------------------------------
        public double getTotalExpensesFromDatabase(int primaryKey)
        {
            string query = "SELECT TotalExpenses FROM UserInfo WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                return ((double)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Updates the current balance associated with the passed primary key
        // in the database
        // params: (in, in)
        //---------------------------------------------------------------------
        public void updateCurrentBalanceToDatabase(int primaryKey, double currentBalance)
        {
            string query = "UPDATE Userinfo SET CurrentBalance = @currentBalance WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                command.Parameters.AddWithValue("@currentBalance", currentBalance);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Retrives the current balance associated with the passed primary key
        // in the database
        // params: (in)
        //---------------------------------------------------------------------
        public double getCurrentBalanceFromDatabase(int primaryKey)
        {
            string query = "SELECT CurrentBalance FROM UserInfo WHERE Id = @primaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                return ((double)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Creates a new user in the database and works with the registration
        // manager to ensure a valid creation of a new user
        // params: (in, in, in, in, in)
        //---------------------------------------------------------------------
        public void insertNewUser(string username, string password, string name, string email, double projectIncome, double actualIncome)
        {
            string query = "INSERT INTO UserInfo VALUES (@username, @password, @name, @email, @projectedIncome, @actualIncome, '0', '0')";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@projectedIncome", projectIncome);
                command.Parameters.AddWithValue("@actualIncome", actualIncome);
                command.ExecuteNonQuery();
            }
        }
        
        //---------------------------------------------------------------------
        // Retrives all the transactions associated with the passed primary key
        // in the database. Returns a datatable of the transaction information to be
        // turned into transaction objects
        // params: (in)
        //---------------------------------------------------------------------
        public DataTable getTransactionHistory(int primaryKey)
        {
            string query = "select a.TransactionNumber, a.Date, a.Amount, a.Description, a.Time, a.Auto, "+
                           "a.Frequency, a.Category from UserExpense a " +
                           "inner join UserInfoUserExpense b on a.Id = b.UserExpenseId " +
                           "where b.UserInfoId = @primaryKey";



            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("primaryKey", primaryKey);

                DataTable expenseTable = new DataTable();
                adapter.Fill(expenseTable);

                return expenseTable;
            }
        }

        //---------------------------------------------------------------------
        // Retrives all the categories associated with the passed primary key
        // in the database. Returns a datatable of the category information
        // to be turned into category objects
        // params: (in)
        //---------------------------------------------------------------------
        public DataTable getCategories(int primaryKey)
        {
            string query = "select a.Title, a.PriorityRating, a.CategoryTotal, a.TransactionAmount, a.Budget, a.Difference  from UserCategory a " +
                "inner join UserInfoUserCategory b on a.Id = b.UserCategoryId " +
                "where b.UserInfoId = @PrimaryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@PrimaryKey", primaryKey);

                DataTable expenseTable = new DataTable();
                adapter.Fill(expenseTable);

                return expenseTable;
            }
        }

        //---------------------------------------------------------------------
        // Retrives all transactions in the category associtaed with the passed
        // category key in the database. Returns the connected transactions
        // in a database of the transaction information to be turned into 
        // transaction objects
        // params: (in)
        //---------------------------------------------------------------------
        public DataTable getCategoryTransactions(int categoryKey)
        {
            string query = "select a.TransactionNumber, a.Date, a.Amount, a.Description, a.Time from UserExpense a " +
                           "inner join UserCategoryUserExpense b on a.Id = b.UserExpenseId " +
                           "where b.UserCategoryId = @categoryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("categoryKey", categoryKey);

                DataTable expenseTable = new DataTable();
                adapter.Fill(expenseTable);

                return expenseTable;
            }
        }

        //---------------------------------------------------------------------
        // Inserts a new transaction into the database based on the passed
        // transaction object
        // params: (in)
        //---------------------------------------------------------------------
        public void addTransaction(Transaction transaction)
        {
            string query = "INSERT INTO UserExpense VALUES (@Amount, @Description, @Category, @Time, @Date, @TransactionNumber, @Auto, @Frequency)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Amount", transaction.getPrice());
                command.Parameters.AddWithValue("@Description", transaction.getDesc());
                if (transaction.getCategory() == null)//if there is no category associated with the transaction
                    command.Parameters.AddWithValue("@Category", "null");
                else
                    command.Parameters.AddWithValue("@Category", transaction.getCategory().getCategoryTitle());
                command.Parameters.AddWithValue("@Time", transaction.getTime());
                command.Parameters.AddWithValue("@Date", transaction.getDate());
                command.Parameters.AddWithValue("@TransactionNumber", transaction.getTransactionNumber());
                command.Parameters.AddWithValue("@Auto", transaction.getAuto().ToString());
                command.Parameters.AddWithValue("@Frequency", transaction.getFreq());
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Inserts a new category into the database based on the passed
        // category object
        // params: (in)
        //---------------------------------------------------------------------
        public void addCategory(Category category)
        {
            string query = "INSERT INTO UserCategory VALUES (@Title, @PriorityRating, @CategoryTotal, @TransactionAmount, @Budget, @Difference)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Title", category.getCategoryTitle());
                command.Parameters.AddWithValue("@PriorityRating", category.getPriorityRating());
                command.Parameters.AddWithValue("@CategoryTotal", category.getCategoryTotal());
                command.Parameters.AddWithValue("@TransactionAmount", category.getTransactionCount());
                command.Parameters.AddWithValue("@Budget", category.getBudget());
                command.Parameters.AddWithValue("@Difference", category.getDifference());
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Links a transaction to a user in the database based on the passed
        // transaction key and primary key.
        // params: (in, in)
        //---------------------------------------------------------------------
        public void linkTransactionToUser(int primaryKey, int transactionKey)
        {
            string query = "insert into UserInfoUserExpense values (@UserInfoId, @UserExpenseId)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@UserInfoId", primaryKey);
                command.Parameters.AddWithValue("@UserExpenseId", transactionKey);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Links a category to a user in the database based on the passed
        // category key and primary key
        // params: (in, in)
        //---------------------------------------------------------------------
        public void linkCategoryToUser(int primaryKey, int categoryKey)
        {
            string query = "insert into UserInfoUserCategory values (@UserInfoId, @UserCategoryId)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@UserInfoId", primaryKey);
                command.Parameters.AddWithValue("@UserCategoryId", categoryKey);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Links a transaction to a category in the database based on the passed
        // category key and transaction key
        // params: (in, in)
        //---------------------------------------------------------------------
        public void linkCategoryToTransaction(int categoryKey, int transactionKey)
        {
            string query = "insert into UserCategoryUserExpense values (@UserCategoryId, @UserExpenseId)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@UserCategoryId", categoryKey);
                command.Parameters.AddWithValue("@UserExpenseId", transactionKey);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Returns the transaction key of the passed transaction object
        // params: (in)
        //---------------------------------------------------------------------
        public int getTransactionPrimaryKey(Transaction transaction)
        {
            string query = "SELECT Id FROM UserExpense WHERE Amount = @Amount and Description = @Description " +
                           "and Category = @Category and Time = @Time and Date = @Date and TransactionNumber = @TransactionNumber";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Amount", transaction.getPrice());
                command.Parameters.AddWithValue("@Description", transaction.getDesc());
                if (transaction.getCategory() == null) //if there is no category for the transaction
                    command.Parameters.AddWithValue("@Category", "null");
                else
                    command.Parameters.AddWithValue("@Category", transaction.getCategory().getCategoryTitle());
                command.Parameters.AddWithValue("@Time", transaction.getTime());
                command.Parameters.AddWithValue("@Date", transaction.getDate());
                command.Parameters.AddWithValue("@TransactionNumber", transaction.getTransactionNumber());
                return ((int)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Returns the category key of the passed category object
        // params: (in)
        //---------------------------------------------------------------------
        public int getCategoryPrimaryKey(Category category)
        {
            string query = "SELECT Id FROM UserCategory WHERE Title = @Title and PriorityRating = @PriorityRating and CategoryTotal = @CategoryTotal " +
                           "and TransactionAmount = @TransactionAmount and Budget = @Budget and Difference = @Difference";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Title", category.getCategoryTitle());
                command.Parameters.AddWithValue("@PriorityRating", category.getPriorityRating());
                command.Parameters.AddWithValue("@CategoryTotal", category.getCategoryTotal());
                command.Parameters.AddWithValue("@TransactionAmount", category.getTransactionCount());
                command.Parameters.AddWithValue("@Budget", category.getBudget());
                command.Parameters.AddWithValue("@Difference", category.getDifference());
                return ((int)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Updates the information of a cateogry associtaed to the passed
        // category key based on the passed category object
        // params: (in, in)
        //---------------------------------------------------------------------
        public void updateCategoryToDatabase(Category category, int categoryKey)
        {
            string query = "UPDATE UserCategory SET CategoryTotal = @CategoryTotal, TransactionAmount = @TransactionAmount, Budget = @Budget, Difference = @Difference WHERE Id = @CategoryId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@CategoryTotal", category.getCategoryTotal());
                command.Parameters.AddWithValue("@TransactionAmount", category.getTransactionCount());
                command.Parameters.AddWithValue("@Budget", category.getBudget());
                command.Parameters.AddWithValue("@Difference", category.getDifference());
                command.Parameters.AddWithValue("@CategoryId", categoryKey);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Updates the information of a transaction associtaed to the passed
        // transaction key based on the passed transaction object
        // params: (in, in)
        //---------------------------------------------------------------------
        public void updateTransactionToDatabase(Transaction transaction, int transactionKey)
        {
            string query = "UPDATE UserExpense SET Amount = @Amount, Description = @Description, Category = @Category, "+
                            "Time = @Time, Date = @Date, TransactionNumber = @TransactionNumber, Auto = @Auto, Frequency = @Frequency WHERE Id = @TransactionId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Amount", transaction.getPrice());
                command.Parameters.AddWithValue("@Description", transaction.getDesc());
                if (transaction.getCategory() == null)//if there is no category associated with the transaction
                    command.Parameters.AddWithValue("@Category", "null");
                else
                    command.Parameters.AddWithValue("@Category", transaction.getCategory().getCategoryTitle());
                command.Parameters.AddWithValue("@Time", transaction.getTime());
                command.Parameters.AddWithValue("@Date", transaction.getDate());
                command.Parameters.AddWithValue("@TransactionNumber", transaction.getTransactionNumber());
                command.Parameters.AddWithValue("@Auto", transaction.getAuto());
                command.Parameters.AddWithValue("@Frequency", transaction.getFreq());
                command.Parameters.AddWithValue("@TransactionId", transactionKey);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Returns the key in the associated table between transactions and 
        // a users where the passed transaction links to 
        // params: (in)
        //---------------------------------------------------------------------
        public int getTransactionLinkKey(int transactionKey)
        {
            string query = "select Id from UserInfoUserExpense where UserExpenseId = @TransactionKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TransactionKey", transactionKey);
                return ((int)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Returns the key in the associated table between transactions and
        // categories where the passed transaction key links to 
        // params: (in)
        //---------------------------------------------------------------------
        public int getCategoryTransactionLinkKey(int transactionKey)
        {
            string query = "select Id from UserCategoryUserExpense where UserExpenseId = @TransactionKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TransactionKey", transactionKey);
                return ((int)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Unlinks a transaction in the category transaction associated table
        // based on the passed category-transaction link key
        // params: (in)
        //---------------------------------------------------------------------
        public void deleteCategoryTransactionLink(int categoryTransactionLinkKey)
        {
            string query = "delete from UserCategoryUserExpense where Id = @CategoryTransactionLinkKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@CategoryTransactionLinkKey", categoryTransactionLinkKey);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Unlines a transaction in the user transaction associtaed table
        // based on the passed user-transsaction link key
        // params: (in)
        //---------------------------------------------------------------------
        public void deleteTransactionUserLink(int transactionLinkKey)
        {
            string query = "delete from UserInfoUserExpense where Id = @TransactionLinkKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TransactionLinkKey", transactionLinkKey);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Removes a transaction from the database based on the passed
        // transactio key
        // params: (in)
        //---------------------------------------------------------------------
        public void deleteTransaction(int transactionKey)
        {
            string query = "delete from UserExpense where Id = @TransactionKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TransactionKey", transactionKey);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Returns the category-user link in the category-user associated table
        // in the datbase based on the passe category key
        // params: (in)
        //---------------------------------------------------------------------
        public int getCategoryUserLinkKey(int categoryKey)
        {
            string query = "select Id from UserInfoUserCategory where UserCategoryId = @CategoryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@CategoryKey", categoryKey);
                return ((int)command.ExecuteScalar());
            }
        }

        //---------------------------------------------------------------------
        // Unlinks a category from the user in the category-user associated table
        // in the database based on the pased category link key
        // params: (in)
        //---------------------------------------------------------------------
        public void deleteUserCategoryLink(int categoryLinkKey)
        {
            string query = "delete from UserInfoUserCategory where Id = @CategoryLinkKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@CategoryLinkKey", categoryLinkKey);
                command.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Removes a cateogry from the database based on the passed category key
        // params: (in)
        //---------------------------------------------------------------------
        public void deleteCategory(int categoryKey)
        {
            string query = "delete from UserCategory where Id = @CategoryKey";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@CategoryKey", categoryKey);
                command.ExecuteNonQuery();
            }
        }
    }
}
