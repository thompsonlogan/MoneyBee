namespace MoneyBee
{
	partial class TransactionForm
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
		/// Required method for Designer support. 
		/// Comment incompatabile code and move all changes to parameterized version.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.PriceTB = new System.Windows.Forms.TextBox();
			this.DescTB = new System.Windows.Forms.TextBox();
			this.CatePicker = new System.Windows.Forms.ComboBox();
			this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.CreateButt = new System.Windows.Forms.Button();
			this.cbRevenue = new System.Windows.Forms.CheckBox();
			this.cbExpense = new System.Windows.Forms.CheckBox();
			this.lblError = new System.Windows.Forms.Label();
			this.AutoCheck = new System.Windows.Forms.CheckBox();
			this.FrequencyLb = new System.Windows.Forms.Label();
			this.FreqCB = new System.Windows.Forms.ComboBox();
			this.AutomaticError = new System.Windows.Forms.Label();
			this.DateErr = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Price";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(192, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Category";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(192, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Time and Date";
			// 
			// PriceTB
			// 
			this.PriceTB.Location = new System.Drawing.Point(28, 47);
			this.PriceTB.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceTB.Name = "PriceTB";
			this.PriceTB.Size = new System.Drawing.Size(100, 20);
			this.PriceTB.TabIndex = 4;
			// 
			// DescTB
			// 
			this.DescTB.Location = new System.Drawing.Point(195, 47);
			this.DescTB.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescTB.Name = "DescTB";
			this.DescTB.Size = new System.Drawing.Size(294, 20);
			this.DescTB.TabIndex = 5;
			// 
			// CatePicker
			// 
			this.CatePicker.FormattingEnabled = true;
			this.CatePicker.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatePicker.Location = new System.Drawing.Point(28, 111);
			this.CatePicker.Name = "CatePicker";
			this.CatePicker.Size = new System.Drawing.Size(148, 21);
			this.CatePicker.TabIndex = 6;
			// 
			// DateTimePicker
			// 
			this.DateTimePicker.Location = new System.Drawing.Point(195, 111);
			this.DateTimePicker.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateTimePicker.Name = "DateTimePicker";
			this.DateTimePicker.Size = new System.Drawing.Size(294, 26);
			this.DateTimePicker.TabIndex = 7;
			// 
			// CreateButt
			// 
			this.CreateButt.Location = new System.Drawing.Point(83, 212);
			this.CreateButt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateButt.Name = "CreateButt";
			this.CreateButt.Size = new System.Drawing.Size(169, 55);
			this.CreateButt.TabIndex = 8;
			this.CreateButt.Text = "Create!";
			this.CreateButt.UseVisualStyleBackColor = true;
			//this.CreateButt.Click += (sender, e) => CreateButt_Click(sender, e, categories);
			// 
			// cbRevenue
			// 
			this.cbRevenue.AutoSize = true;
			this.cbRevenue.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRevenue.Location = new System.Drawing.Point(28, 180);
			this.cbRevenue.Name = "cbRevenue";
			this.cbRevenue.Size = new System.Drawing.Size(64, 17);
			this.cbRevenue.TabIndex = 9;
			this.cbRevenue.Text = "Revenue";
			this.cbRevenue.UseVisualStyleBackColor = true;
			// 
			// cbExpense
			// 
			this.cbExpense.AutoSize = true;
			this.cbExpense.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbExpense.Location = new System.Drawing.Point(28, 157);
			this.cbExpense.Name = "cbExpense";
			this.cbExpense.Size = new System.Drawing.Size(67, 17);
			this.cbExpense.TabIndex = 10;
			this.cbExpense.Text = "Expense";
			this.cbExpense.UseVisualStyleBackColor = true;
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(79, 270);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(162, 13);
			this.lblError.TabIndex = 11;
			this.lblError.Text = "Check either expense or addition";
			this.lblError.Visible = false;
			//
			// AutoCheck
			//
			this.AutoCheck.AutoSize = true;
			this.AutoCheck.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoCheck.Location = new System.Drawing.Point(310, 161);
			this.AutoCheck.Name = "AutoCheck";
			this.AutoCheck.Size = new System.Drawing.Size(91, 23);
			this.AutoCheck.TabIndex = 12;
			this.AutoCheck.Text = "Repeats?";
			this.AutoCheck.UseVisualStyleBackColor = true;
			//
			// FrequencyLb
			//
			this.FrequencyLb.AutoSize = true;
			this.FrequencyLb.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FrequencyLb.Location = new System.Drawing.Point(307, 187);
			this.FrequencyLb.Name = "FrequencyLb";
			this.FrequencyLb.Size = new System.Drawing.Size(116, 19);
			this.FrequencyLb.TabIndex = 13;
			this.FrequencyLb.Text = "Frequency";
			this.FrequencyLb.Enabled = false;
			// 
			// FreqCB
			// 
			this.FreqCB.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FreqCB.FormattingEnabled = true;
			this.FreqCB.Location = new System.Drawing.Point(310, 209);
			this.FreqCB.Name = "FreqCB";
			this.FreqCB.Size = new System.Drawing.Size(179, 27);
			this.FreqCB.TabIndex = 14;
			this.FreqCB.Enabled = false;
			this.FreqCB.Items.AddRange(new object[] {
			"1 - Everyday",
			"2 - Every Other day",
			"3 - Every Week",
			"4 - Every two weeks",
			"5 - Every Month",
			"6 - Every 6 Months",
			"7 - Every Year"});
			// 
			// AutomaticError
			// 
			this.AutomaticError.AutoSize = true;
			this.AutomaticError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutomaticError.ForeColor = System.Drawing.Color.Red;
			this.AutomaticError.Location = new System.Drawing.Point(79, 289);
			this.AutomaticError.Name = "AutomaticError";
			this.AutomaticError.Size = new System.Drawing.Size(253, 19);
			this.AutomaticError.TabIndex = 15;
			this.AutomaticError.Text = "Please select a frequency";
			this.AutomaticError.Visible = false;
			// 
			// DateErr
			// 
			this.DateErr.AutoSize = true;
			this.DateErr.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateErr.ForeColor = System.Drawing.Color.Red;
			this.DateErr.Location = new System.Drawing.Point(79, 308);
			this.DateErr.Name = "DateErr";
			this.DateErr.Size = new System.Drawing.Size(225, 19);
			this.DateErr.TabIndex = 16;
			this.DateErr.Text = "The date cannot before today";
			this.DateErr.Visible = false;
			// 
			// TransactionForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 324);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.cbExpense);
			this.Controls.Add(this.cbRevenue);
			this.Controls.Add(this.CreateButt);
			this.Controls.Add(this.DateTimePicker);
			this.Controls.Add(this.CatePicker);
			this.Controls.Add(this.DescTB);
			this.Controls.Add(this.PriceTB);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AutoCheck);
			this.Controls.Add(this.FrequencyLb);
			this.Controls.Add(this.FreqCB);
			this.Controls.Add(this.DateErr);
			this.Controls.Add(this.AutomaticError);
			this.MinimumSize = new System.Drawing.Size(635, 378);
			this.Name = "TransactionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Transaction";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		/// <summary>
		/// Not used in Designer. Check to make changes manually and that unparameterized controls match
		/// </summary>
		private void InitializeComponent(CategoryList categories)
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.PriceTB = new System.Windows.Forms.TextBox();
			this.DescTB = new System.Windows.Forms.TextBox();
			this.CatePicker = new System.Windows.Forms.ComboBox();
			this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.CreateButt = new System.Windows.Forms.Button();
			this.cbRevenue = new System.Windows.Forms.CheckBox();
			this.cbExpense = new System.Windows.Forms.CheckBox();
			this.lblError = new System.Windows.Forms.Label();
			this.AutoCheck = new System.Windows.Forms.CheckBox();
			this.FrequencyLb = new System.Windows.Forms.Label();
			this.FreqCB = new System.Windows.Forms.ComboBox();
			this.AutomaticError = new System.Windows.Forms.Label();
			this.DateErr = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Price";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(192, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Category";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(192, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Time and Date";
			// 
			// PriceTB
			// 
			this.PriceTB.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceTB.Location = new System.Drawing.Point(28, 47);
			this.PriceTB.Name = "PriceTB";
			this.PriceTB.Size = new System.Drawing.Size(100, 26);
			this.PriceTB.TabIndex = 4;
			// 
			// DescTB
			// 
			this.DescTB.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescTB.Location = new System.Drawing.Point(195, 47);
			this.DescTB.Name = "DescTB";
			this.DescTB.Size = new System.Drawing.Size(294, 26);
			this.DescTB.TabIndex = 5;
			// 
			// CatePicker
			// 
			this.CatePicker.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatePicker.FormattingEnabled = true;
			this.CatePicker.Location = new System.Drawing.Point(28, 111);
			this.CatePicker.Name = "CatePicker";
			this.CatePicker.Size = new System.Drawing.Size(148, 27);
			this.CatePicker.TabIndex = 6;
			// 
			// DateTimePicker
			// 
			this.DateTimePicker.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateTimePicker.Location = new System.Drawing.Point(195, 111);
			this.DateTimePicker.Name = "DateTimePicker";
			this.DateTimePicker.Size = new System.Drawing.Size(294, 26);
			this.DateTimePicker.TabIndex = 7;
			// 
			// CreateButt
			// 
			this.CreateButt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateButt.Location = new System.Drawing.Point(83, 212);
			this.CreateButt.Name = "CreateButt";
			this.CreateButt.Size = new System.Drawing.Size(169, 55);
			this.CreateButt.TabIndex = 8;
			this.CreateButt.Text = "Create!";
			this.CreateButt.UseVisualStyleBackColor = true;
			this.CreateButt.Click += new System.EventHandler(this.CreateButt_Click_1);
			// 
			// cbRevenue
			// 
			this.cbRevenue.AutoSize = true;
			this.cbRevenue.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRevenue.Location = new System.Drawing.Point(28, 180);
			this.cbRevenue.Name = "cbRevenue";
			this.cbRevenue.Size = new System.Drawing.Size(92, 23);
			this.cbRevenue.TabIndex = 9;
			this.cbRevenue.Text = "Revenue";
			this.cbRevenue.UseVisualStyleBackColor = true;
			// 
			// cbExpense
			// 
			this.cbExpense.AutoSize = true;
			this.cbExpense.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbExpense.Location = new System.Drawing.Point(28, 157);
			this.cbExpense.Name = "cbExpense";
			this.cbExpense.Size = new System.Drawing.Size(91, 23);
			this.cbExpense.TabIndex = 10;
			this.cbExpense.Text = "Expense";
			this.cbExpense.UseVisualStyleBackColor = true;
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(79, 270);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(253, 19);
			this.lblError.TabIndex = 11;
			this.lblError.Text = "Check either expense or addition";
			this.lblError.Visible = false;
			// 
			// AutoCheck
			// 
			this.AutoCheck.AutoSize = true;
			this.AutoCheck.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoCheck.Location = new System.Drawing.Point(310, 161);
			this.AutoCheck.Name = "AutoCheck";
			this.AutoCheck.Size = new System.Drawing.Size(95, 23);
			this.AutoCheck.TabIndex = 12;
			this.AutoCheck.Text = "Repeats?";
			this.AutoCheck.UseVisualStyleBackColor = true;
			this.AutoCheck.CheckedChanged += new System.EventHandler(this.AutoCheck_CheckedChanged);
			// 
			// FrequencyLb
			// 
			this.FrequencyLb.AutoSize = true;
			this.FrequencyLb.Enabled = false;
			this.FrequencyLb.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FrequencyLb.Location = new System.Drawing.Point(307, 187);
			this.FrequencyLb.Name = "FrequencyLb";
			this.FrequencyLb.Size = new System.Drawing.Size(88, 19);
			this.FrequencyLb.TabIndex = 13;
			this.FrequencyLb.Text = "Frequency";
			// 
			// FreqCB
			// 
			this.FreqCB.Enabled = false;
			this.FreqCB.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FreqCB.FormattingEnabled = true;
			this.FreqCB.Items.AddRange(new object[] {
			"1 - Everyday",
			"2 - Every Other day",
			"3 - Every Week",
			"4 - Every two weeks",
			"5 - Every Month",
			"6 - Every 6 Months",
			"7 - Every Year"});
			this.FreqCB.Location = new System.Drawing.Point(310, 209);
			this.FreqCB.Name = "FreqCB";
			this.FreqCB.Size = new System.Drawing.Size(179, 27);
			this.FreqCB.TabIndex = 14;
			// 
			// AutomaticError
			// 
			this.AutomaticError.AutoSize = true;
			this.AutomaticError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutomaticError.ForeColor = System.Drawing.Color.Red;
			this.AutomaticError.Location = new System.Drawing.Point(79, 289);
			this.AutomaticError.Name = "AutomaticError";
			this.AutomaticError.Size = new System.Drawing.Size(194, 19);
			this.AutomaticError.TabIndex = 15;
			this.AutomaticError.Text = "Please select a frequency";
			this.AutomaticError.Visible = false;
			// 
			// DateErr
			// 
			this.DateErr.AutoSize = true;
			this.DateErr.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateErr.ForeColor = System.Drawing.Color.Red;
			this.DateErr.Location = new System.Drawing.Point(79, 308);
			this.DateErr.Name = "DateErr";
			this.DateErr.Size = new System.Drawing.Size(225, 19);
			this.DateErr.TabIndex = 16;
			this.DateErr.Text = "The date cannot before today";
			this.DateErr.Visible = false;
			// 
			// TransactionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(619, 339);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.cbExpense);
			this.Controls.Add(this.cbRevenue);
			this.Controls.Add(this.CreateButt);
			this.Controls.Add(this.DateTimePicker);
			this.Controls.Add(this.CatePicker);
			this.Controls.Add(this.DescTB);
			this.Controls.Add(this.PriceTB);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AutoCheck);
			this.Controls.Add(this.FrequencyLb);
			this.Controls.Add(this.FreqCB);
			this.Controls.Add(this.DateErr);
			this.Controls.Add(this.AutomaticError);
			this.MinimumSize = new System.Drawing.Size(635, 378);
			this.Name = "TransactionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Transaction";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox PriceTB;
		private System.Windows.Forms.TextBox DescTB;
		private System.Windows.Forms.ComboBox CatePicker;
		private System.Windows.Forms.DateTimePicker DateTimePicker;
		private System.Windows.Forms.Button CreateButt;
		private System.Windows.Forms.CheckBox cbRevenue;
		private System.Windows.Forms.CheckBox cbExpense;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.CheckBox AutoCheck;
		private System.Windows.Forms.Label FrequencyLb;
		private System.Windows.Forms.ComboBox FreqCB;
		private System.Windows.Forms.Label AutomaticError;
		private System.Windows.Forms.Label DateErr;
	}
}