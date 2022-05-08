//---------------------------------------------------------------
//
// Project: MoneyBee
//
// Purpose: This form is where the user can select to do the actions provided.
//          And view their account information easily. 
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBee
{
    public partial class MoneyBeeForm : Form
    {
        const int MAXINTRANHIST = 10;
        const int FLIPNUMBERSIGN = -1;
        const int EXPENSE = 0;
        const int NULLCATEGORY = -1;
        const int JAN = 1;
        const int FEB = 2;
        const int MAR = 3;
        const int APR = 4;
        const int MAY = 5;
        const int JUN = 6;
        const int JUL = 7;
        const int AUG = 8;
        const int SEP = 9;
        const int OCT = 10;
        const int NOV = 11;
        const int DEC = 12;

        TransactionHistory recentHistory = new TransactionHistory();
        DatabaseManager database = new DatabaseManager();
        CategoryList categories = new CategoryList();
        User currentUser = new User();
        Date currentDate = new Date();
        AutomaticList autoList = new AutomaticList();
        Transaction transaction;
        Category category;
        DataTable dt = new DataTable();
        TabPage newCategoryTab = new TabPage();
        Handler commandHandler = new Handler();
        History history;
        TransactionManager tm = new TransactionManager();

        //---------------------------------------------------------------------
        // Displays the form with the given user
        //---------------------------------------------------------------------
        public MoneyBeeForm(User inUser)
        {
            InitializeComponent();

            IntPtr h = tcExpenditures.Handle;//used to fix a tabpage bug in vs

            EventArgs e = new EventArgs();
            currentUser = inUser;

            updateUserAmounts();

            UpdateBalance();

            lblTestDate.Text = currentDate.toString();

            loadCategories();

            loadTransactions();

            this.history = commandHandler.getHistory();
        }
        //---------------------------------------------------------------------
        // Loads the transactions into transaction history
        //---------------------------------------------------------------------
        public void loadTransactions()
        {
            lbTransactionHistory.Items.Clear();
            dt = database.getTransactionHistory(currentUser.getPrimaryKey());
            foreach (DataRow dataRow in dt.Rows)
            {
                transaction = new Transaction(dataRow["Description"].ToString(),
                    Int32.Parse(dataRow["Amount"].ToString()),
                    null,
                    dataRow["Date"].ToString(),
                    dataRow["Time"].ToString(),
                    Int32.Parse(dataRow["TransactionNumber"].ToString()),
                    false,
                    0);
                if (dataRow["Category"].ToString() != "null")
                {
                    Category temp = categories.getCategory(categories.getIndex(dataRow["Category"].ToString()));
                    transaction.setCategory(temp);
                }
                if (dataRow["Auto"].ToString() == "True")
                {
                    transaction.setAuto(true);
                    transaction.setFreq(Int32.Parse(dataRow["Frequency"].ToString()));
                    autoList.add(transaction);
                }
                recentHistory.AddTransaction(transaction);
                InsertTransaction(NULLCATEGORY);
            }
        }
        //---------------------------------------------------------------------
        //loads all logged in users categories into the form
        //---------------------------------------------------------------------
        public void loadCategories()
        {
            int index = 0;
            dt = database.getCategories(currentUser.getPrimaryKey());
            foreach (DataRow dataRow in dt.Rows)
            {
                category = new Category(dataRow["Title"].ToString(),
                    Int32.Parse(dataRow["PriorityRating"].ToString()),
                    Int32.Parse(dataRow["CategoryTotal"].ToString()),
                    Int32.Parse(dataRow["TransactionAmount"].ToString()),
                    Int32.Parse(dataRow["Budget"].ToString()),
                    Int32.Parse(dataRow["Difference"].ToString()));

                int categoryKey = database.getCategoryPrimaryKey(category);

                loadCategoryTransactions(categoryKey, category);
                categories.AddCategory(category);
                CreateNewExpenditurePage(category, index, categoryKey);
                index++;
            }
        }
        //---------------------------------------------------------------------
        // Loads all the transactions associated with the category into the
        // categories transaction history
        //---------------------------------------------------------------------
        public void loadCategoryTransactions(int categoryKey, Category category)
        {
            dt = database.getCategoryTransactions(categoryKey);
            foreach (DataRow dataRow in dt.Rows)
            {
                transaction = new Transaction(dataRow["Description"].ToString(),
                    Int32.Parse(dataRow["Amount"].ToString()),
                    category,
                    dataRow["Date"].ToString(),
                    dataRow["Time"].ToString(),
                    Int32.Parse(dataRow["TransactionNumber"].ToString()),
                    false,
                    0);
                category.loadTransactionFromDatabase(transaction);
            }
        }

        //---------------------------------------------------------------------
        // Updates transaction history list. limit 10 items
        // use: add transactions to the transaction history
        // and display them on the form
        //---------------------------------------------------------------------
        private void InsertTransaction(int categoryindex)
        {
            int num = lbTransactionHistory.Items.Count;

            if (num < MAXINTRANHIST)
            {
                string recent = recentHistory.head.Data.getTransactionNumber()
                + " " + recentHistory.head.Data.getDate()
                + ": "
                + ("$" + (recentHistory.head.Data.getPrice() * FLIPNUMBERSIGN).ToString("0.00"))
                + ", "
                + recentHistory.head.Data.getDesc();
                lbTransactionHistory.Items.Insert(0, recent);
            }
            else //inserting transaction into the transaction history
            {
                lbTransactionHistory.Items.RemoveAt(MAXINTRANHIST - 1);
                InsertTransaction(categoryindex);
            }

            if (categoryindex != -1)//inserting into a categories transaction history
            {
                tcExpenditures.SelectTab(categoryindex);
                tcExpenditures.SelectedTab.Dispose();
                CreateNewExpenditurePage(categories.getCategory(categoryindex), categoryindex, -1);
            }
        }

        //---------------------------------------------------------------------
        // Updates balance displayed
        //---------------------------------------------------------------------
        private void UpdateBalance()
        {
            currentUser.changeBalance();
            double updatedBalance = currentUser.getCurrentBalance();

            lblTotalBalanceValue.Text = "$" + updatedBalance.ToString("0.00");

            if (updatedBalance > 0)
            {
                lblTotalBalanceValue.ForeColor = Color.Green;
            }
            else if (updatedBalance < 0)
            {
                lblTotalBalanceValue.ForeColor = Color.Red;
            }
            else
            {
                lblTotalBalanceValue.ForeColor = Color.Black;
            }
        }

        //---------------------------------------------------------------------
        //Opens form for new transaction
        //---------------------------------------------------------------------
        private void bNewTransaction_Click(object sender, EventArgs e)
        {
            TransactionForm newExpense = new TransactionForm(categories,
                recentHistory, currentUser.getPrimaryKey(),
                autoList, currentDate,
                currentUser, commandHandler);

            newExpense.Show();
            newExpense.VisibleChanged += formVisibleChanged;
        }

        //---------------------------------------------------------------------
        // Returns entry from expense form after closed
        //---------------------------------------------------------------------
        private void formVisibleChanged(object sender, EventArgs e)
        {
            TransactionForm newExpense = (TransactionForm)sender;
            if (!newExpense.Visible)
            {
                int categoryindex;
                Transaction addedTransaction = newExpense.ReturnData;

                recentHistory.AddTransaction(addedTransaction);

                if (addedTransaction.getCategory() == null)
                    categoryindex = -1;
                else
                    categoryindex = categories.getIndex(addedTransaction.
                        getCategory().getCategoryTitle());

                InsertTransaction(categoryindex);

                if (addedTransaction.getPrice() < EXPENSE) // revenue transaction
                    updateFormOnRevenue(addedTransaction.getPrice());
                else // expense transaction
                    updateFormOnExpense(addedTransaction.getPrice());
                newExpense.Dispose();//destroying the transaction form
            }
        }

        //---------------------------------------------------------------------
        // Increments the test date
        //---------------------------------------------------------------------
        private void DateAdvance_Click_1(object sender, EventArgs e)
        {
            history.clear();
            currentDate.increDay();
            lblTestDate.Text = currentDate.toString();
            Transaction[] a = new Transaction[30];
            int count = 0;
            autoList.check(currentDate, ref a,
                currentUser.getPrimaryKey(),
                ref count,
                recentHistory.getTransactionCount());
            int i = 0;
            while (i < count)
            {
                recentHistory.AddTransaction(a[i]);
                updateFormOnExpense(a[i].getPrice());
                InsertTransaction(-1);
                i++;
            }
            if (currentDate.getDay() == 1)
                GenerateMonthlyReport();
        }

        //---------------------------------------------------------------------
        // Logs out of users account
        //---------------------------------------------------------------------
        private void bLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            autoList.clear();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        //---------------------------------------------------------------------
        // Saves changes made on account to database
        //---------------------------------------------------------------------
        public void saveUpdates()
        {
            database.updateProjectedIncomeToDatabase(currentUser.getPrimaryKey(),
                Double.Parse(lblProjectedIncomeValue.Text,
                System.Globalization.NumberStyles.Currency));

            database.updateActualIncomeToDatabase(currentUser.getPrimaryKey(),
                Double.Parse(lblActualIncomeValue.Text,
                System.Globalization.NumberStyles.Currency));

            database.updateTotalExpensesToDatabase(currentUser.getPrimaryKey(),
                Double.Parse(lblTotalExpensesValue.Text,
                System.Globalization.NumberStyles.Currency));
        }

        //---------------------------------------------------------------------
        // Saves updates on close
        //---------------------------------------------------------------------
        private void MoneyBeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveUpdates();
        }

        //---------------------------------------------------------------------
        // Saves updates when form visibility changes (logged out)
        //---------------------------------------------------------------------
        private void MoneyBeeForm_VisibleChanged(object sender, EventArgs e)
        {
            saveUpdates();
        }

        // -------------------------------------------------------------------
        // Opens the Edit Transaction form when the button on the main form is clicked
        // -------------------------------------------------------------------
        private void bEditTransaction_Click(object sender, EventArgs e)
        {   
            if(lbTransactionHistory.SelectedIndex != -1)
            {
                int index = lbTransactionHistory.SelectedIndex;
                //The naming got screwed up somewhere, this is calling the Edit Transaction form
                originalTransactionDate editMe = new originalTransactionDate(recentHistory, index, currentUser, commandHandler);
                editMe.Show();
                editMe.VisibleChanged += EditMe_VisibleChanged;
            }
        }

        // -------------------------------------------------------------------
        // Updates the main form with the changes made in the Edit Transaction form
        // -------------------------------------------------------------------
        private void EditMe_VisibleChanged(object sender, EventArgs e)
        {
            originalTransactionDate editTransaction = (originalTransactionDate)sender;
            if (!editTransaction.Visible)
            {
                recentHistory.clear();
                lbTransactionHistory.Items.Clear();
                updateUserAmounts();
                clearCategories();
                loadCategories();
                loadTransactions();
            }
        }

        //---------------------------------------------------------------------
        // Formatting design for entering category title text box
        // params: (in, in)
        //---------------------------------------------------------------------
        private void tbCategoryTitle_Enter(object sender, EventArgs e)
        {
            if (tbCategoryTitle.ForeColor == Color.Red)
                tbCategoryTitle.Clear();
            tbCategoryTitle.ForeColor = Color.Black;
        }

        //---------------------------------------------------------------------
        // Formatting design for entering category priority text box
        // params: (in, in)
        //---------------------------------------------------------------------
        private void tbPriority_Enter(object sender, EventArgs e)
        {
            if (tbPriority.ForeColor == Color.Red)
                tbPriority.Clear();
            tbPriority.ForeColor = Color.Black;
        }

        //---------------------------------------------------------------------
        // Formatting design for entering category budget text box
        // params: (in, in)
        //---------------------------------------------------------------------
        private void tbBudget_Enter(object sender, EventArgs e)
        {
            if (tbBudget.ForeColor == Color.Red)
                tbBudget.Clear();
            tbBudget.ForeColor = Color.Black;
        }

        //---------------------------------------------------------------------
        // Displays help messages about category detail requirements
        // params: (in, in)
        //---------------------------------------------------------------------
        private void bCategoryHelp_Click(object sender, EventArgs e)
        {
            tbCategoryTitle.ForeColor = Color.Red;
            tbCategoryTitle.Text = "Category Name";

            tbPriority.ForeColor = Color.Red;
            tbPriority.Text = "Numerical Rating";

            tbBudget.ForeColor = Color.Red;
            tbBudget.Text = "Spending Limit";
        }

        //---------------------------------------------------------------------
        // Creates a new category based on the category detail fields
        // params: (in, in)
        //---------------------------------------------------------------------
        private void bCreateExpenditure_Click(object sender, EventArgs e)
        {
            if (validateCategory(tbCategoryTitle.Text, tbBudget.Text, tbPriority.Text))
            {
                string newTitle = tbCategoryTitle.Text;
                double newBudget = Convert.ToDouble(tbBudget.Text);
                int newPriority = Convert.ToInt32(tbPriority.Text);

                Category newCategory = new Category(newTitle, newBudget, newPriority);

                categories.AddCategory(newCategory);

                commandHandler.addCategory(newCategory, currentUser.getPrimaryKey());

                int index = categories.getIndex(newCategory.getCategoryTitle());
                CreateNewExpenditurePage(newCategory, index, -1);//creating a new category tab

                //clearing the textboxes
                tbCategoryTitle.Clear();
                tbPriority.Clear();
                tbBudget.Clear();
            }
        }

        //---------------------------------------------------------------------
        // Checks to see if category details are valid
        // May change inputs if invalid
        // params: (inout, inout, inout)
        //---------------------------------------------------------------------
        private bool validateCategory(string title, string budget, string priority)
        {
            bool validinput = true;

            if (categories.categoryExists(title))
            {
                tbCategoryTitle.ForeColor = Color.Red;
                tbCategoryTitle.Text = "Already Exists";
                validinput = false;
            }

            //Checks to see if title is entered
            if (title == "")
            {
                tbCategoryTitle.ForeColor = Color.Red;
                tbCategoryTitle.Text = "Required";
                validinput = false;
            }

            //Checks to see if budget is entered
            if (budget == "")
            {
                tbBudget.ForeColor = Color.Red;
                tbBudget.Text = "Required";
                validinput = false;
            }

            //Checks to see if priority is entered
            if (priority == "")
            {
                tbPriority.ForeColor = Color.Red;
                tbPriority.Text = "Required";
                validinput = false;
            }

            //Checks to see if budget is a number
            if (!budget.All(char.IsDigit))
            {
                tbBudget.ForeColor = Color.Red;
                tbBudget.Text = "Must be number";
                validinput = false;
            }

            //Checks to see if priority is a number
            if (!priority.All(char.IsDigit))
            {
                tbPriority.ForeColor = Color.Red;
                tbPriority.Text = "Must be number";
                validinput = false;
            }

            return validinput;
        }

        //---------------------------------------------------------------------
        // Creates and formats a new category expenditure page
        // params: (in, in, in)
        //---------------------------------------------------------------------
        public void CreateNewExpenditurePage(Category newCategory, int index, int categoryKey)
        {
            newCategoryTab = new TabPage();
            newCategoryTab.Text = newCategory.getCategoryTitle();
            tcExpenditures.TabPages.Insert(index, newCategoryTab);

            System.Windows.Forms.ListBox newListBox = new System.Windows.Forms.ListBox();
            newListBox.FormattingEnabled = true;
            newListBox.ItemHeight = 20;
            newListBox.Location = new System.Drawing.Point(4, 4);
            newListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            newListBox.Size = new System.Drawing.Size(525, 100);
            TransactionNode currentTransaction;
            string currentDetails;
            for (int i = 0; i < categories.getCategory(index).transactionCount; i++)
            {
                currentTransaction = categories.getCategory(index).getTransactionDetails(i);

                currentDetails = currentTransaction.Data.getDate()
                + ": "
                + ("$" + (currentTransaction.Data.getPrice() * -1).ToString("0.00"))
                + ", "
                + currentTransaction.Data.getDesc();

                newListBox.Items.Add(currentDetails);
            }

            System.Windows.Forms.SplitContainer CategoryDetails1 = new System.Windows.Forms.SplitContainer();
            CategoryDetails1.AutoSize = true;
            CategoryDetails1.Location = new System.Drawing.Point(0, 100);
            CategoryDetails1.Size = new System.Drawing.Size(275, 40);
            CategoryDetails1.SplitterDistance = 125;

            System.Windows.Forms.SplitContainer CategoryDetails2 = new System.Windows.Forms.SplitContainer();
            CategoryDetails2.AutoSize = true;
            CategoryDetails2.Location = new System.Drawing.Point(275, 100);
            CategoryDetails2.Size = new System.Drawing.Size(275, 40);
            CategoryDetails2.SplitterDistance = 125;

            System.Windows.Forms.Label priorityLabel = new System.Windows.Forms.Label();
            priorityLabel.Text = "Priority rating:";
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(0, 0);
            priorityLabel.Size = new System.Drawing.Size(50, 20);

            System.Windows.Forms.Label priorityValue = new System.Windows.Forms.Label();
            priorityValue.Text = newCategory.getPriorityRating().ToString();
            priorityValue.AutoSize = true;
            priorityValue.Location = new System.Drawing.Point(0, 0);
            priorityValue.Size = new System.Drawing.Size(50, 20);


            System.Windows.Forms.Label totalLabel = new System.Windows.Forms.Label();
            totalLabel.Text = "Category total:";
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(0, 20);
            totalLabel.Size = new System.Drawing.Size(50, 20);

            System.Windows.Forms.Label totalValue = new System.Windows.Forms.Label();
            totalValue.Text = "$" + newCategory.getCategoryTotal().ToString("0.00");
            totalValue.AutoSize = true;
            totalValue.Location = new System.Drawing.Point(0, 20);
            totalValue.Size = new System.Drawing.Size(50, 20);

            System.Windows.Forms.Label budgetLabel = new System.Windows.Forms.Label();
            budgetLabel.Text = "Category budget: ";
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new System.Drawing.Point(0, 0);
            budgetLabel.Size = new System.Drawing.Size(50, 20);

            System.Windows.Forms.Label budgetValue = new System.Windows.Forms.Label();
            budgetValue.Text = "$" + newCategory.getBudget().ToString("0.00");
            budgetValue.AutoSize = true;
            budgetValue.Location = new System.Drawing.Point(0, 0);
            budgetValue.Size = new System.Drawing.Size(50, 20);

            System.Windows.Forms.Label differenceLabel = new System.Windows.Forms.Label();
            differenceLabel.Text = "Difference:";
            differenceLabel.AutoSize = true;
            differenceLabel.Location = new System.Drawing.Point(0, 20);
            differenceLabel.Size = new System.Drawing.Size(50, 20);

            System.Windows.Forms.Label differenceValue = new System.Windows.Forms.Label();
            differenceValue.Text = "$" + newCategory.getDifference().ToString("0.00");
            differenceValue.AutoSize = true;
            differenceValue.Location = new System.Drawing.Point(0, 20);
            differenceValue.Size = new System.Drawing.Size(50, 20);
            if (newCategory.getDifference() <= 0)
            {
                differenceValue.ForeColor = Color.Red;
            }
            else
            {
                differenceValue.ForeColor = Color.Green;
            }

            CategoryDetails1.Panel1.Controls.Add(priorityLabel);
            CategoryDetails1.Panel2.Controls.Add(priorityValue);
            CategoryDetails1.Panel1.Controls.Add(totalLabel);
            CategoryDetails1.Panel2.Controls.Add(totalValue);
            CategoryDetails2.Panel1.Controls.Add(budgetLabel);
            CategoryDetails2.Panel2.Controls.Add(budgetValue);
            CategoryDetails2.Panel1.Controls.Add(differenceLabel);
            CategoryDetails2.Panel2.Controls.Add(differenceValue);

            newCategoryTab.Controls.Add(newListBox);
            newCategoryTab.Controls.Add(CategoryDetails1);
            newCategoryTab.Controls.Add(CategoryDetails2);
        }

        //---------------------------------------------------------------------
        // Button to undo an action
        // currently works with transaction/category creation
        // params: (in, in)
        //---------------------------------------------------------------------
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (!history.doneIsEmpty())
            {
                autoList.clear();
                if(history.peekDone().GetType() == typeof(AddTransactionCommand))
                {
                    Transaction temp = recentHistory.getHead();
                    recentHistory.clear();
                    if (temp.getPrice() < 0)
                        updateFormOnRevenue(-1 * temp.getPrice());
                    else
                        updateFormOnExpense(-1 * temp.getPrice());
                }
                this.history = commandHandler.getHistory();
                autoList.clear();
                recentHistory.clear();
                history.undo();
                clearCategories();
                loadCategories();
                loadTransactions();
                updateUserAmounts();
            }
        }

        //---------------------------------------------------------------------
        // Button to redo an action
        // currently works with transaction/category creation
        // params: (in, in)
        //---------------------------------------------------------------------
        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (!history.unDoneIsEmpty())
            {
                recentHistory.clear();
                this.history = commandHandler.getHistory();
                history.redo();
                clearCategories();
                loadCategories();
                loadTransactions();
                updateUserAmounts();
                if (history.peekDone().GetType() == typeof(AddTransactionCommand))
                {
                    Transaction temp = recentHistory.getHead(); //check if the stacks are empty
                    if (temp.getPrice() < 0)
                        updateFormOnRevenue(temp.getPrice());
                    else
                        updateFormOnExpense(temp.getPrice());
                }
            }
        }

        //---------------------------------------------------------------------
        // Clears the items in the category list
        // params: none
        //---------------------------------------------------------------------
        public void clearCategories()
        {
            tcExpenditures.TabPages.Clear();
            categories.clear();
        }

        //---------------------------------------------------------------------
        // Updates form when an expense is added
        // params: (in)
        //---------------------------------------------------------------------
        public void updateFormOnExpense(double transactionAmount)
        {
            currentUser.changeTotalExpenses(transactionAmount);
            currentUser.changeBalance();
            lblTotalExpensesValue.Text = "$" + currentUser.getTotalExpenses().ToString("0.00");
            lblTotalBalanceValue.Text = "$" + currentUser.getCurrentBalance().ToString("0.00");
        }

        //---------------------------------------------------------------------
        // Updates form when revenue is added
        // params: (in)
        //---------------------------------------------------------------------
        public void updateFormOnRevenue(double transactionAmount)
        {
            currentUser.updateActualIncome(transactionAmount);
            currentUser.changeBalance();
            lblActualIncomeValue.Text = "$" + currentUser.getActualIncome().ToString("0.00");
            lblTotalBalanceValue.Text = "$" + currentUser.getCurrentBalance().ToString("0.00");
        }

        //---------------------------------------------------------------------
        // Updates user's projected/actual income and expense totals
        // params: none
        //---------------------------------------------------------------------
        public void updateUserAmounts()
        {
            lblProjectedIncomeValue.Text = "$"+currentUser.getProjectedIncome().ToString("0.00");
            lblActualIncomeValue.Text = "$"+currentUser.getActualIncome().ToString("0.00");
            lblTotalExpensesValue.Text = "$"+currentUser.getTotalExpenses().ToString("0.00");
            UpdateBalance();
        }

        //---------------------------------------------------------------------
        // Creates a monthly report based on the transaction of the 
        // previous month. Generates at the first day of every new month
        // params: none
        //---------------------------------------------------------------------
        private void GenerateMonthlyReport()
        {
            double monthlyrevenuetotal = 0;
            double monthlyexpensetotal = 0;
            double monthlydifference = 0;
            Transaction currenttransaction;
            Date dateset = new Date();

            int previousmonth = currentDate.getMonth() - 1;
            if (previousmonth == 0)
                previousmonth = DEC;

            if (previousmonth == JAN)
                lblPreviousMonth.Text = "January";
            else if (previousmonth == FEB)
                lblPreviousMonth.Text = "February";
            else if (previousmonth == MAR)
                lblPreviousMonth.Text = "March";
            else if (previousmonth == APR)
                lblPreviousMonth.Text = "April";
            else if (previousmonth == MAY)
                lblPreviousMonth.Text = "May";
            else if (previousmonth == JUN)
                lblPreviousMonth.Text = "June";
            else if (previousmonth == JUL)
                lblPreviousMonth.Text = "July";
            else if (previousmonth == AUG)
                lblPreviousMonth.Text = "August";
            else if (previousmonth == SEP)
                lblPreviousMonth.Text = "September";
            else if (previousmonth == OCT)
                lblPreviousMonth.Text = "October";
            else if (previousmonth == NOV)
                lblPreviousMonth.Text = "November";
            else if (previousmonth == DEC)
                lblPreviousMonth.Text = "December";

            lbMonthlyReport.Items.Clear();

            for (int i = 0; i < recentHistory.getTransactionCount(); i++)
            {
                if (dateset.toDate(recentHistory.getTransaction(i).getDate()).getMonth()
                    == previousmonth)
                {
                    currenttransaction = recentHistory.getTransaction(i);
                    if (currenttransaction.getPrice() * FLIPNUMBERSIGN < 0)
                        monthlyexpensetotal += currenttransaction.getPrice();
                    else
                        monthlyrevenuetotal += currenttransaction.getPrice() * FLIPNUMBERSIGN;

                    string transactiondetails = currenttransaction.getTransactionNumber()
                    + " " + currenttransaction.getDate()
                    + ": "
                    + ("$" + (currenttransaction.getPrice() * FLIPNUMBERSIGN).ToString("0.00"))
                    + ", "
                    + currenttransaction.getDesc();
                    lbMonthlyReport.Items.Insert(0, transactiondetails);
                }
            }

            monthlydifference = monthlyrevenuetotal - monthlyexpensetotal;

            lblMonthlyRevenues.Text = "Revenue Total: $" + monthlyrevenuetotal.ToString("0.00");
            lblMonthlyRevenues.Visible = true;

            lblMonthlyExpenses.Text = "Expense Total: $" + monthlyexpensetotal.ToString("0.00");
            lblMonthlyExpenses.Visible = true;

            lblMonthlyDifference.Text = "Monthly Difference: $" + monthlydifference.ToString("0.00");
            lblMonthlyDifference.Visible = true;
        }

        //---------------------------------------------------------------------
        // Button to cancel an automatic transaction
        // params: (in, in)
        //---------------------------------------------------------------------
        private void CancelAutoButt_Click(object sender, EventArgs e)
        {
            CancelAutoForm c = new CancelAutoForm(autoList);

            c.VisibleChanged += C_VisibleChanged;
            c.Show();
        }

        //---------------------------------------------------------------------
        // Formatting/data entries for cancel form
        // params: (in, in)
        //---------------------------------------------------------------------
        private void C_VisibleChanged(object sender, EventArgs e)
        {
            autoList.clear();
            clearCategories();
            loadCategories();
            loadTransactions();
        }
    }
}

 
