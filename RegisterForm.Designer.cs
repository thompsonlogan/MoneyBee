namespace MoneyBee
{
    partial class RegisterForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProjectedIncome = new System.Windows.Forms.Label();
            this.tbEnterName = new System.Windows.Forms.TextBox();
            this.tbEnterUsername = new System.Windows.Forms.TextBox();
            this.tbEnterPassword = new System.Windows.Forms.TextBox();
            this.tbEnterEmail = new System.Windows.Forms.TextBox();
            this.tbEnterProjectedIncome = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnToMenu = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblUsernameExists = new System.Windows.Forms.Label();
            this.lblInvalidEmail = new System.Windows.Forms.Label();
            this.lblActuaIncome = new System.Windows.Forms.Label();
            this.tbEnterActualIncome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(89, 52);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(320, 52);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(325, 112);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(92, 114);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblProjectedIncome
            // 
            this.lblProjectedIncome.AutoSize = true;
            this.lblProjectedIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectedIncome.Location = new System.Drawing.Point(7, 161);
            this.lblProjectedIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectedIncome.Name = "lblProjectedIncome";
            this.lblProjectedIncome.Size = new System.Drawing.Size(137, 20);
            this.lblProjectedIncome.TabIndex = 4;
            this.lblProjectedIncome.Text = "Projected Income:";
            // 
            // tbEnterName
            // 
            this.tbEnterName.Location = new System.Drawing.Point(151, 51);
            this.tbEnterName.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnterName.Name = "tbEnterName";
            this.tbEnterName.Size = new System.Drawing.Size(76, 20);
            this.tbEnterName.TabIndex = 5;
            // 
            // tbEnterUsername
            // 
            this.tbEnterUsername.Location = new System.Drawing.Point(413, 51);
            this.tbEnterUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnterUsername.Name = "tbEnterUsername";
            this.tbEnterUsername.Size = new System.Drawing.Size(76, 20);
            this.tbEnterUsername.TabIndex = 6;
            // 
            // tbEnterPassword
            // 
            this.tbEnterPassword.Location = new System.Drawing.Point(413, 113);
            this.tbEnterPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnterPassword.Name = "tbEnterPassword";
            this.tbEnterPassword.Size = new System.Drawing.Size(76, 20);
            this.tbEnterPassword.TabIndex = 7;
            // 
            // tbEnterEmail
            // 
            this.tbEnterEmail.Location = new System.Drawing.Point(151, 113);
            this.tbEnterEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnterEmail.Name = "tbEnterEmail";
            this.tbEnterEmail.Size = new System.Drawing.Size(76, 20);
            this.tbEnterEmail.TabIndex = 8;
            // 
            // tbEnterProjectedIncome
            // 
            this.tbEnterProjectedIncome.Location = new System.Drawing.Point(151, 161);
            this.tbEnterProjectedIncome.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnterProjectedIncome.Name = "tbEnterProjectedIncome";
            this.tbEnterProjectedIncome.Size = new System.Drawing.Size(76, 20);
            this.tbEnterProjectedIncome.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(144, 211);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(83, 47);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnToMenu
            // 
            this.btnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToMenu.Location = new System.Drawing.Point(345, 211);
            this.btnToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(160, 47);
            this.btnToMenu.TabIndex = 11;
            this.btnToMenu.Text = "Back to Login";
            this.btnToMenu.UseVisualStyleBackColor = true;
            this.btnToMenu.Click += new System.EventHandler(this.btnToMenu_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(210, 257);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(156, 20);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Please fill in all boxes";
            this.lblError.Visible = false;
            // 
            // lblUsernameExists
            // 
            this.lblUsernameExists.AutoSize = true;
            this.lblUsernameExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameExists.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameExists.Location = new System.Drawing.Point(196, 273);
            this.lblUsernameExists.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameExists.Name = "lblUsernameExists";
            this.lblUsernameExists.Size = new System.Drawing.Size(182, 20);
            this.lblUsernameExists.TabIndex = 13;
            this.lblUsernameExists.Text = "Username already exists";
            this.lblUsernameExists.Visible = false;
            // 
            // lblInvalidEmail
            // 
            this.lblInvalidEmail.AutoSize = true;
            this.lblInvalidEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidEmail.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidEmail.Location = new System.Drawing.Point(196, 292);
            this.lblInvalidEmail.Name = "lblInvalidEmail";
            this.lblInvalidEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInvalidEmail.Size = new System.Drawing.Size(187, 20);
            this.lblInvalidEmail.TabIndex = 14;
            this.lblInvalidEmail.Text = "Please enter a valid email";
            this.lblInvalidEmail.Visible = false;
            // 
            // lblActuaIncome
            // 
            this.lblActuaIncome.AutoSize = true;
            this.lblActuaIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActuaIncome.Location = new System.Drawing.Point(292, 159);
            this.lblActuaIncome.Name = "lblActuaIncome";
            this.lblActuaIncome.Size = new System.Drawing.Size(115, 20);
            this.lblActuaIncome.TabIndex = 15;
            this.lblActuaIncome.Text = "Actual Income:";
            // 
            // tbEnterActualIncome
            // 
            this.tbEnterActualIncome.Location = new System.Drawing.Point(413, 159);
            this.tbEnterActualIncome.Name = "tbEnterActualIncome";
            this.tbEnterActualIncome.Size = new System.Drawing.Size(76, 20);
            this.tbEnterActualIncome.TabIndex = 16;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 339);
            this.Controls.Add(this.tbEnterActualIncome);
            this.Controls.Add(this.lblActuaIncome);
            this.Controls.Add(this.lblInvalidEmail);
            this.Controls.Add(this.lblUsernameExists);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbEnterProjectedIncome);
            this.Controls.Add(this.tbEnterEmail);
            this.Controls.Add(this.tbEnterPassword);
            this.Controls.Add(this.tbEnterUsername);
            this.Controls.Add(this.tbEnterName);
            this.Controls.Add(this.lblProjectedIncome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProjectedIncome;
        private System.Windows.Forms.TextBox tbEnterName;
        private System.Windows.Forms.TextBox tbEnterUsername;
        private System.Windows.Forms.TextBox tbEnterPassword;
        private System.Windows.Forms.TextBox tbEnterEmail;
        private System.Windows.Forms.TextBox tbEnterProjectedIncome;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnToMenu;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblUsernameExists;
        private System.Windows.Forms.Label lblInvalidEmail;
		private System.Windows.Forms.Label lblActuaIncome;
		private System.Windows.Forms.TextBox tbEnterActualIncome;
	}
}