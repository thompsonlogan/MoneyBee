namespace MoneyBee
{
    partial class LoginForm
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblWrongLogin = new System.Windows.Forms.Label();
			this.tbEnterPassword = new System.Windows.Forms.TextBox();
			this.tbEnterUsername = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(191, 254);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(85, 38);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegister.Location = new System.Drawing.Point(351, 254);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(85, 38);
			this.btnRegister.TabIndex = 1;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(187, 191);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(105, 21);
			this.lblUsername.TabIndex = 2;
			this.lblUsername.Text = "Username:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(187, 220);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(101, 21);
			this.lblPassword.TabIndex = 3;
			this.lblPassword.Text = "Password:";
			// 
			// lblWrongLogin
			// 
			this.lblWrongLogin.AutoSize = true;
			this.lblWrongLogin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWrongLogin.ForeColor = System.Drawing.Color.Red;
			this.lblWrongLogin.Location = new System.Drawing.Point(187, 294);
			this.lblWrongLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblWrongLogin.Name = "lblWrongLogin";
			this.lblWrongLogin.Size = new System.Drawing.Size(264, 19);
			this.lblWrongLogin.TabIndex = 4;
			this.lblWrongLogin.Text = "Username or password is incorrect";
			this.lblWrongLogin.Visible = false;
			// 
			// tbEnterPassword
			// 
			this.tbEnterPassword.Location = new System.Drawing.Point(295, 223);
			this.tbEnterPassword.Margin = new System.Windows.Forms.Padding(2);
			this.tbEnterPassword.Name = "tbEnterPassword";
			this.tbEnterPassword.PasswordChar = '*';
			this.tbEnterPassword.Size = new System.Drawing.Size(141, 20);
			this.tbEnterPassword.TabIndex = 5;
			// 
			// tbEnterUsername
			// 
			this.tbEnterUsername.Location = new System.Drawing.Point(296, 191);
			this.tbEnterUsername.Margin = new System.Windows.Forms.Padding(2);
			this.tbEnterUsername.Name = "tbEnterUsername";
			this.tbEnterUsername.Size = new System.Drawing.Size(140, 20);
			this.tbEnterUsername.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MoneyBee.Properties.Resources.MoneyBee;
			this.pictureBox1.InitialImage = global::MoneyBee.Properties.Resources.MoneyBee;
			this.pictureBox1.Location = new System.Drawing.Point(191, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(245, 175);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(619, 339);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tbEnterUsername);
			this.Controls.Add(this.tbEnterPassword);
			this.Controls.Add(this.lblWrongLogin);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnLogin);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(635, 378);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblWrongLogin;
        private System.Windows.Forms.TextBox tbEnterPassword;
        private System.Windows.Forms.TextBox tbEnterUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}