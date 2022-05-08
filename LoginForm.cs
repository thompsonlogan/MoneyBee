//---------------------------------------------------------------------
//
// MoneyBee: Login Form
//
//
// Purpose: This form functions in presenting the user with a visual 
//          login form for them to log into the system. This form
//          also checks with the login manager to ensure a valid 
//          login from the user
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBee
{
    public partial class LoginForm : Form
    {
        const int USERNAME_NOT_IN_DB = 0;
        LoginManager loginManager = new LoginManager();

        //---------------------------------------------------------------------
        // Constructor initializing form components
        // params: (in/out/inout, ...)
        //---------------------------------------------------------------------
        public LoginForm()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        // Logs in the user when they press the login button. Communicates 
        // with the login manger to ensure its a valid login and retrive 
        // the users information from the datbase
        // params: (in, in)
        //---------------------------------------------------------------------
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbEnterPassword.Text == "" || tbEnterPassword.Text == "")
            {
                lblWrongLogin.Show();
                return;
            }
            int primaryKey = loginManager.getPrimaryKeyFromDBManager(tbEnterUsername.Text); //checking datbase for username
            bool invalidLoginCombo = !(loginManager.validateLogin(tbEnterPassword.Text, primaryKey)); //checking if the username and password for the primary key matches
            if (primaryKey == USERNAME_NOT_IN_DB || invalidLoginCombo)
            {
                lblWrongLogin.Show();
                tbEnterPassword.Clear();
            }
            else//sucessful login
            {
                MoneyBeeForm moneyBeeForm = new MoneyBeeForm(loginManager.loginUser());
                moneyBeeForm.Show();
                this.Hide();
            }
        }

        //---------------------------------------------------------------------
        // Opens the register form for users to register if they havn't already
        // params: (in, in)
        //---------------------------------------------------------------------
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
        }
    }
}
