//---------------------------------------------------------------------
// Name: Logan
//
// MoneyBee: Register form
//
// Course:  SE 3330, Spring 2020
//
// Purpose: This form functions in displaying the regrestration process
//          to the user and communicates with the regrestration manager
//          to accomplish this
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
    public partial class RegisterForm : Form
    {
        Notifications notification = new Notifications();
        RegistrationManager regManager = new RegistrationManager();

        //---------------------------------------------------------------------
        // Constructor initializing the register form components
        // params: ()
        //---------------------------------------------------------------------
        public RegisterForm()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        // Activates with the register button is pressed and works with the 
        // regrestration manger to properly register a new user
        // params: (in, in)
        //---------------------------------------------------------------------
        private void btnRegister_Click(object sender, EventArgs e)
        {
            double projectedIncome;
            double actualIncome;
            lblError.Hide();
            lblUsername.Hide();
            bool isIncomplete = this.Controls.OfType<TextBox>().Any(tb => string.IsNullOrEmpty(tb.Text)); //checking for all textboes to be filled in
            if (isIncomplete)
                lblError.Show();
            else if (regManager.usernameExists(tbEnterUsername.Text))//username already exists
                lblUsernameExists.Show();
            else
            {
                bool sentEmail = notification.sendEmail(tbEnterEmail.Text);
                if (!sentEmail)//if email was invalid/no email sent
                {
                    lblInvalidEmail.Show();
                }
                else //register user
                {
                    Double.TryParse(tbEnterProjectedIncome.Text, out projectedIncome);
                    Double.TryParse(tbEnterActualIncome.Text, out actualIncome);
                    regManager.registerUser(tbEnterUsername.Text, tbEnterPassword.Text, tbEnterName.Text, tbEnterEmail.Text, projectedIncome, actualIncome);
                    this.Close();
                }
            }
        }

        //---------------------------------------------------------------------
        // Activates when the menu button is clicked and returns the user to
        // to the login page
        // params: (in, in)
        //---------------------------------------------------------------------
        private void btnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
