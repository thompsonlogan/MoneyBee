//---------------------------------------------------------------------
//
// MoneyBee: Notifications
//
//
// Purpose: This class functions in send email notification to the user
//          when they register. Plan to expend in coming updates
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace MoneyBee
{
    public class Notifications
    {
        const int GMAIL_PORT = 587;
        const bool SSL_ENABLED = true;
        const string SMTP_SERVER = "smtp.gmail.com";
        const string EMAIL_SUBJECT = "Welcome to Money Bee!";
        const string APPLICATION_PASSWORD = "bssvwplyhldqswaw";
        const string AUTOMATED_EMAIL = "snal.moneybee@gmail.com";
        const string EMAIL_BODY = "Thank you for signing up for Money Bee! We appreciate you for using our service!";

        //---------------------------------------------------------------------
        // Sends the user a default welcome message to the passed email
        // params: (in)
        //---------------------------------------------------------------------
        public bool sendEmail(string email)
        {
            try
            {
                //smtp client details
                SmtpClient clientDetails = new SmtpClient(SMTP_SERVER, GMAIL_PORT);
                clientDetails.EnableSsl = SSL_ENABLED;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(AUTOMATED_EMAIL, APPLICATION_PASSWORD);

                //message details
                MailMessage mailDetails = new MailMessage(AUTOMATED_EMAIL, email, EMAIL_SUBJECT, EMAIL_BODY);

                //send email
                clientDetails.Send(mailDetails);
            }
            //if system fails to send email
            catch (SmtpFailedRecipientException)
            {
                return false;
            }
            return true;
        }
    }
}
