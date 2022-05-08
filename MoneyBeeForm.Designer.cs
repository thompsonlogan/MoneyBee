namespace MoneyBee
{
    partial class MoneyBeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcHeaderTabs = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.lblTotalExpensesValue = new System.Windows.Forms.Label();
            this.lblActualIncomeValue = new System.Windows.Forms.Label();
            this.lblProjectedIncomeValue = new System.Windows.Forms.Label();
            this.CancelAutoButt = new System.Windows.Forms.Button();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblActualIncome = new System.Windows.Forms.Label();
            this.lblProjectedIncome = new System.Windows.Forms.Label();
            this.bNewTransaction = new System.Windows.Forms.Button();
            this.bEditTransaction = new System.Windows.Forms.Button();
            this.lbTransactionHistory = new System.Windows.Forms.ListBox();
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.lblTotalBalanceValue = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.tabExpenditures = new System.Windows.Forms.TabPage();
            this.bCategoryHelp = new System.Windows.Forms.Button();
            this.tbBudget = new System.Windows.Forms.TextBox();
            this.tbPriority = new System.Windows.Forms.TextBox();
            this.tbCategoryTitle = new System.Windows.Forms.TextBox();
            this.lblCategoryBudget = new System.Windows.Forms.Label();
            this.lblCategoryPriority = new System.Windows.Forms.Label();
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.bCreateExpenditure = new System.Windows.Forms.Button();
            this.tcExpenditures = new System.Windows.Forms.TabControl();
            this.tabMonthlyReport = new System.Windows.Forms.TabPage();
            this.lblMonthlyDifference = new System.Windows.Forms.Label();
            this.lblMonthlyExpenses = new System.Windows.Forms.Label();
            this.lblMonthlyRevenues = new System.Windows.Forms.Label();
            this.lblPreviousMonth = new System.Windows.Forms.Label();
            this.lbMonthlyReport = new System.Windows.Forms.ListBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.bLogOut = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lbExpenditures = new System.Windows.Forms.ListBox();
            this.lblTestDate = new System.Windows.Forms.Label();
            this.DateAdvance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcHeaderTabs.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabExpenditures.SuspendLayout();
            this.tabMonthlyReport.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcHeaderTabs
            // 
            this.tcHeaderTabs.Controls.Add(this.tabMain);
            this.tcHeaderTabs.Controls.Add(this.tabExpenditures);
            this.tcHeaderTabs.Controls.Add(this.tabMonthlyReport);
            this.tcHeaderTabs.Controls.Add(this.tabSettings);
            this.tcHeaderTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcHeaderTabs.Location = new System.Drawing.Point(12, 12);
            this.tcHeaderTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcHeaderTabs.Name = "tcHeaderTabs";
            this.tcHeaderTabs.SelectedIndex = 0;
            this.tcHeaderTabs.Size = new System.Drawing.Size(850, 422);
            this.tcHeaderTabs.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabMain.Controls.Add(this.lblTotalExpensesValue);
            this.tabMain.Controls.Add(this.lblActualIncomeValue);
            this.tabMain.Controls.Add(this.lblProjectedIncomeValue);
            this.tabMain.Controls.Add(this.CancelAutoButt);
            this.tabMain.Controls.Add(this.lblTotalExpenses);
            this.tabMain.Controls.Add(this.lblActualIncome);
            this.tabMain.Controls.Add(this.lblProjectedIncome);
            this.tabMain.Controls.Add(this.bNewTransaction);
            this.tabMain.Controls.Add(this.bEditTransaction);
            this.tabMain.Controls.Add(this.lbTransactionHistory);
            this.tabMain.Controls.Add(this.lblTransactionHistory);
            this.tabMain.Controls.Add(this.lblTotalBalanceValue);
            this.tabMain.Controls.Add(this.lblTotalBalance);
            this.tabMain.Location = new System.Drawing.Point(4, 38);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Size = new System.Drawing.Size(842, 380);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // lblTotalExpensesValue
            // 
            this.lblTotalExpensesValue.AutoSize = true;
            this.lblTotalExpensesValue.Location = new System.Drawing.Point(400, 42);
            this.lblTotalExpensesValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalExpensesValue.Name = "lblTotalExpensesValue";
            this.lblTotalExpensesValue.Size = new System.Drawing.Size(26, 29);
            this.lblTotalExpensesValue.TabIndex = 17;
            this.lblTotalExpensesValue.Text = "0";
            // 
            // lblActualIncomeValue
            // 
            this.lblActualIncomeValue.AutoSize = true;
            this.lblActualIncomeValue.Location = new System.Drawing.Point(220, 42);
            this.lblActualIncomeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualIncomeValue.Name = "lblActualIncomeValue";
            this.lblActualIncomeValue.Size = new System.Drawing.Size(26, 29);
            this.lblActualIncomeValue.TabIndex = 16;
            this.lblActualIncomeValue.Text = "0";
            // 
            // lblProjectedIncomeValue
            // 
            this.lblProjectedIncomeValue.AutoSize = true;
            this.lblProjectedIncomeValue.Location = new System.Drawing.Point(14, 42);
            this.lblProjectedIncomeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectedIncomeValue.Name = "lblProjectedIncomeValue";
            this.lblProjectedIncomeValue.Size = new System.Drawing.Size(26, 29);
            this.lblProjectedIncomeValue.TabIndex = 15;
            this.lblProjectedIncomeValue.Text = "0";
            // 
            // CancelAutoButt
            // 
            this.CancelAutoButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAutoButt.Location = new System.Drawing.Point(607, 284);
            this.CancelAutoButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelAutoButt.Name = "CancelAutoButt";
            this.CancelAutoButt.Size = new System.Drawing.Size(228, 80);
            this.CancelAutoButt.TabIndex = 14;
            this.CancelAutoButt.Text = "Cancel Automatic Transaction";
            this.CancelAutoButt.UseVisualStyleBackColor = true;
            this.CancelAutoButt.Click += new System.EventHandler(this.CancelAutoButt_Click);
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Location = new System.Drawing.Point(400, 11);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(180, 29);
            this.lblTotalExpenses.TabIndex = 11;
            this.lblTotalExpenses.Text = "Total Expenses";
            // 
            // lblActualIncome
            // 
            this.lblActualIncome.AutoSize = true;
            this.lblActualIncome.Location = new System.Drawing.Point(219, 11);
            this.lblActualIncome.Name = "lblActualIncome";
            this.lblActualIncome.Size = new System.Drawing.Size(163, 29);
            this.lblActualIncome.TabIndex = 9;
            this.lblActualIncome.Text = "Actual Income";
            // 
            // lblProjectedIncome
            // 
            this.lblProjectedIncome.AutoSize = true;
            this.lblProjectedIncome.Location = new System.Drawing.Point(14, 11);
            this.lblProjectedIncome.Name = "lblProjectedIncome";
            this.lblProjectedIncome.Size = new System.Drawing.Size(202, 29);
            this.lblProjectedIncome.TabIndex = 7;
            this.lblProjectedIncome.Text = "Projected Income";
            // 
            // bNewTransaction
            // 
            this.bNewTransaction.Location = new System.Drawing.Point(16, 284);
            this.bNewTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bNewTransaction.Name = "bNewTransaction";
            this.bNewTransaction.Size = new System.Drawing.Size(228, 80);
            this.bNewTransaction.TabIndex = 6;
            this.bNewTransaction.Text = "New Transaction";
            this.bNewTransaction.UseVisualStyleBackColor = true;
            this.bNewTransaction.Click += new System.EventHandler(this.bNewTransaction_Click);
            // 
            // bEditTransaction
            // 
            this.bEditTransaction.Location = new System.Drawing.Point(311, 284);
            this.bEditTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditTransaction.Name = "bEditTransaction";
            this.bEditTransaction.Size = new System.Drawing.Size(228, 80);
            this.bEditTransaction.TabIndex = 4;
            this.bEditTransaction.Text = "Edit Transaction";
            this.bEditTransaction.UseVisualStyleBackColor = true;
            this.bEditTransaction.Click += new System.EventHandler(this.bEditTransaction_Click);
            // 
            // lbTransactionHistory
            // 
            this.lbTransactionHistory.FormattingEnabled = true;
            this.lbTransactionHistory.ItemHeight = 29;
            this.lbTransactionHistory.Location = new System.Drawing.Point(17, 117);
            this.lbTransactionHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTransactionHistory.Name = "lbTransactionHistory";
            this.lbTransactionHistory.Size = new System.Drawing.Size(819, 149);
            this.lbTransactionHistory.TabIndex = 3;
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.Location = new System.Drawing.Point(306, 86);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(219, 29);
            this.lblTransactionHistory.TabIndex = 2;
            this.lblTransactionHistory.Text = "Transaction History";
            // 
            // lblTotalBalanceValue
            // 
            this.lblTotalBalanceValue.AutoSize = true;
            this.lblTotalBalanceValue.Location = new System.Drawing.Point(603, 42);
            this.lblTotalBalanceValue.Name = "lblTotalBalanceValue";
            this.lblTotalBalanceValue.Size = new System.Drawing.Size(26, 29);
            this.lblTotalBalanceValue.TabIndex = 1;
            this.lblTotalBalanceValue.Text = "0";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Location = new System.Drawing.Point(603, 11);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(161, 29);
            this.lblTotalBalance.TabIndex = 0;
            this.lblTotalBalance.Text = "Total Balance";
            // 
            // tabExpenditures
            // 
            this.tabExpenditures.BackColor = System.Drawing.Color.Thistle;
            this.tabExpenditures.Controls.Add(this.bCategoryHelp);
            this.tabExpenditures.Controls.Add(this.tbBudget);
            this.tabExpenditures.Controls.Add(this.tbPriority);
            this.tabExpenditures.Controls.Add(this.tbCategoryTitle);
            this.tabExpenditures.Controls.Add(this.lblCategoryBudget);
            this.tabExpenditures.Controls.Add(this.lblCategoryPriority);
            this.tabExpenditures.Controls.Add(this.lblCategoryTitle);
            this.tabExpenditures.Controls.Add(this.bCreateExpenditure);
            this.tabExpenditures.Controls.Add(this.tcExpenditures);
            this.tabExpenditures.Location = new System.Drawing.Point(4, 38);
            this.tabExpenditures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabExpenditures.Name = "tabExpenditures";
            this.tabExpenditures.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabExpenditures.Size = new System.Drawing.Size(842, 380);
            this.tabExpenditures.TabIndex = 1;
            this.tabExpenditures.Text = "Categories";
            // 
            // bCategoryHelp
            // 
            this.bCategoryHelp.Location = new System.Drawing.Point(756, 17);
            this.bCategoryHelp.Name = "bCategoryHelp";
            this.bCategoryHelp.Size = new System.Drawing.Size(80, 66);
            this.bCategoryHelp.TabIndex = 8;
            this.bCategoryHelp.Text = "Help";
            this.bCategoryHelp.UseVisualStyleBackColor = true;
            this.bCategoryHelp.Click += new System.EventHandler(this.bCategoryHelp_Click);
            // 
            // tbBudget
            // 
            this.tbBudget.Location = new System.Drawing.Point(420, 48);
            this.tbBudget.Name = "tbBudget";
            this.tbBudget.Size = new System.Drawing.Size(200, 35);
            this.tbBudget.TabIndex = 2;
            this.tbBudget.Enter += new System.EventHandler(this.tbBudget_Enter);
            // 
            // tbPriority
            // 
            this.tbPriority.Location = new System.Drawing.Point(214, 48);
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.Size = new System.Drawing.Size(200, 35);
            this.tbPriority.TabIndex = 0;
            this.tbPriority.Enter += new System.EventHandler(this.tbPriority_Enter);
            // 
            // tbCategoryTitle
            // 
            this.tbCategoryTitle.Location = new System.Drawing.Point(8, 48);
            this.tbCategoryTitle.Name = "tbCategoryTitle";
            this.tbCategoryTitle.Size = new System.Drawing.Size(200, 35);
            this.tbCategoryTitle.TabIndex = 0;
            this.tbCategoryTitle.Enter += new System.EventHandler(this.tbCategoryTitle_Enter);
            // 
            // lblCategoryBudget
            // 
            this.lblCategoryBudget.AutoSize = true;
            this.lblCategoryBudget.Location = new System.Drawing.Point(416, 17);
            this.lblCategoryBudget.Name = "lblCategoryBudget";
            this.lblCategoryBudget.Size = new System.Drawing.Size(90, 29);
            this.lblCategoryBudget.TabIndex = 4;
            this.lblCategoryBudget.Text = "Budget";
            // 
            // lblCategoryPriority
            // 
            this.lblCategoryPriority.AutoSize = true;
            this.lblCategoryPriority.Location = new System.Drawing.Point(208, 17);
            this.lblCategoryPriority.Name = "lblCategoryPriority";
            this.lblCategoryPriority.Size = new System.Drawing.Size(88, 29);
            this.lblCategoryPriority.TabIndex = 3;
            this.lblCategoryPriority.Text = "Priority";
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.AutoSize = true;
            this.lblCategoryTitle.Location = new System.Drawing.Point(6, 17);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Size = new System.Drawing.Size(61, 29);
            this.lblCategoryTitle.TabIndex = 2;
            this.lblCategoryTitle.Text = "Title";
            // 
            // bCreateExpenditure
            // 
            this.bCreateExpenditure.Location = new System.Drawing.Point(626, 17);
            this.bCreateExpenditure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCreateExpenditure.Name = "bCreateExpenditure";
            this.bCreateExpenditure.Size = new System.Drawing.Size(124, 66);
            this.bCreateExpenditure.TabIndex = 3;
            this.bCreateExpenditure.Text = "Create";
            this.bCreateExpenditure.UseVisualStyleBackColor = true;
            this.bCreateExpenditure.Click += new System.EventHandler(this.bCreateExpenditure_Click);
            // 
            // tcExpenditures
            // 
            this.tcExpenditures.Location = new System.Drawing.Point(8, 94);
            this.tcExpenditures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcExpenditures.Name = "tcExpenditures";
            this.tcExpenditures.SelectedIndex = 0;
            this.tcExpenditures.Size = new System.Drawing.Size(828, 288);
            this.tcExpenditures.TabIndex = 0;
            // 
            // tabMonthlyReport
            // 
            this.tabMonthlyReport.BackColor = System.Drawing.Color.PeachPuff;
            this.tabMonthlyReport.Controls.Add(this.lblMonthlyDifference);
            this.tabMonthlyReport.Controls.Add(this.lblMonthlyExpenses);
            this.tabMonthlyReport.Controls.Add(this.lblMonthlyRevenues);
            this.tabMonthlyReport.Controls.Add(this.lblPreviousMonth);
            this.tabMonthlyReport.Controls.Add(this.lbMonthlyReport);
            this.tabMonthlyReport.Location = new System.Drawing.Point(4, 38);
            this.tabMonthlyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMonthlyReport.Name = "tabMonthlyReport";
            this.tabMonthlyReport.Size = new System.Drawing.Size(842, 380);
            this.tabMonthlyReport.TabIndex = 2;
            this.tabMonthlyReport.Text = "Monthly Report";
            // 
            // lblMonthlyDifference
            // 
            this.lblMonthlyDifference.AutoSize = true;
            this.lblMonthlyDifference.Location = new System.Drawing.Point(14, 346);
            this.lblMonthlyDifference.Name = "lblMonthlyDifference";
            this.lblMonthlyDifference.Size = new System.Drawing.Size(218, 29);
            this.lblMonthlyDifference.TabIndex = 4;
            this.lblMonthlyDifference.Text = "Monthly Difference:";
            this.lblMonthlyDifference.Visible = false;
            // 
            // lblMonthlyExpenses
            // 
            this.lblMonthlyExpenses.AutoSize = true;
            this.lblMonthlyExpenses.Location = new System.Drawing.Point(14, 318);
            this.lblMonthlyExpenses.Name = "lblMonthlyExpenses";
            this.lblMonthlyExpenses.Size = new System.Drawing.Size(174, 29);
            this.lblMonthlyExpenses.TabIndex = 3;
            this.lblMonthlyExpenses.Text = "Expense Total:";
            this.lblMonthlyExpenses.Visible = false;
            // 
            // lblMonthlyRevenues
            // 
            this.lblMonthlyRevenues.AutoSize = true;
            this.lblMonthlyRevenues.Location = new System.Drawing.Point(12, 292);
            this.lblMonthlyRevenues.Name = "lblMonthlyRevenues";
            this.lblMonthlyRevenues.Size = new System.Drawing.Size(176, 29);
            this.lblMonthlyRevenues.TabIndex = 2;
            this.lblMonthlyRevenues.Text = "Revenue Total:";
            this.lblMonthlyRevenues.Visible = false;
            // 
            // lblPreviousMonth
            // 
            this.lblPreviousMonth.AutoSize = true;
            this.lblPreviousMonth.Location = new System.Drawing.Point(12, 14);
            this.lblPreviousMonth.Name = "lblPreviousMonth";
            this.lblPreviousMonth.Size = new System.Drawing.Size(582, 29);
            this.lblPreviousMonth.TabIndex = 0;
            this.lblPreviousMonth.Text = "Your report will be ready by the first day of next month";
            // 
            // lbMonthlyReport
            // 
            this.lbMonthlyReport.FormattingEnabled = true;
            this.lbMonthlyReport.ItemHeight = 29;
            this.lbMonthlyReport.Location = new System.Drawing.Point(16, 43);
            this.lbMonthlyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMonthlyReport.Name = "lbMonthlyReport";
            this.lbMonthlyReport.Size = new System.Drawing.Size(804, 207);
            this.lbMonthlyReport.TabIndex = 1;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabSettings.Controls.Add(this.bLogOut);
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(842, 380);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(3, 2);
            this.bLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(150, 40);
            this.bLogOut.TabIndex = 1;
            this.bLogOut.Text = "Log Out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.Location = new System.Drawing.Point(258, 450);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(112, 52);
            this.btnRedo.TabIndex = 13;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(378, 447);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(118, 52);
            this.btnUndo.TabIndex = 12;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lbExpenditures
            // 
            this.lbExpenditures.Location = new System.Drawing.Point(0, 0);
            this.lbExpenditures.Name = "lbExpenditures";
            this.lbExpenditures.Size = new System.Drawing.Size(120, 96);
            this.lbExpenditures.TabIndex = 0;
            // 
            // lblTestDate
            // 
            this.lblTestDate.AutoSize = true;
            this.lblTestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDate.Location = new System.Drawing.Point(28, 462);
            this.lblTestDate.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblTestDate.Name = "lblTestDate";
            this.lblTestDate.Size = new System.Drawing.Size(117, 50);
            this.lblTestDate.TabIndex = 5;
            this.lblTestDate.Text = "Test Date";
            // 
            // DateAdvance
            // 
            this.DateAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAdvance.Location = new System.Drawing.Point(152, 449);
            this.DateAdvance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateAdvance.Name = "DateAdvance";
            this.DateAdvance.Size = new System.Drawing.Size(98, 54);
            this.DateAdvance.TabIndex = 6;
            this.DateAdvance.Text = ">>";
            this.DateAdvance.UseVisualStyleBackColor = true;
            this.DateAdvance.Click += new System.EventHandler(this.DateAdvance_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MoneyBee.Properties.Resources.MoneyBee___Long;
            this.pictureBox1.Location = new System.Drawing.Point(510, 434);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 91);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MoneyBeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(928, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateAdvance);
            this.Controls.Add(this.tcHeaderTabs);
            this.Controls.Add(this.lblTestDate);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnRedo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(938, 542);
            this.Name = "MoneyBeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Bee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoneyBeeForm_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.MoneyBeeForm_VisibleChanged);
            this.tcHeaderTabs.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabExpenditures.ResumeLayout(false);
            this.tabExpenditures.PerformLayout();
            this.tabMonthlyReport.ResumeLayout(false);
            this.tabMonthlyReport.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcHeaderTabs;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabExpenditures;
        private System.Windows.Forms.TabPage tabMonthlyReport;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label lblTransactionHistory;
        private System.Windows.Forms.Label lblTotalBalanceValue;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Button bNewTransaction;
        private System.Windows.Forms.Label lblTestDate;
        private System.Windows.Forms.Button bEditTransaction;
        private System.Windows.Forms.ListBox lbTransactionHistory;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Label lblActualIncome;
        private System.Windows.Forms.Label lblProjectedIncome;
        private System.Windows.Forms.TabControl tcExpenditures;
        private System.Windows.Forms.Button bCreateExpenditure;
        private System.Windows.Forms.ListBox lbMonthlyReport;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.ListBox lbExpenditures;
        private System.Windows.Forms.Button DateAdvance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbBudget;
        private System.Windows.Forms.TextBox tbPriority;
        private System.Windows.Forms.TextBox tbCategoryTitle;
        private System.Windows.Forms.Label lblCategoryBudget;
        private System.Windows.Forms.Label lblCategoryPriority;
        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.Button bCategoryHelp;
        private System.Windows.Forms.Label lblPreviousMonth;
        private System.Windows.Forms.Label lblMonthlyDifference;
        private System.Windows.Forms.Label lblMonthlyExpenses;
        private System.Windows.Forms.Label lblMonthlyRevenues;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button CancelAutoButt;
        private System.Windows.Forms.Label lblTotalExpensesValue;
        private System.Windows.Forms.Label lblActualIncomeValue;
        private System.Windows.Forms.Label lblProjectedIncomeValue;
    }
}