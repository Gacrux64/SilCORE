using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewUser;
using System.Net.Mail;

namespace NewUser
{
    public class UserMail
    {
        //E-mail-related functions
        public string NewPasswordEmail(string name, string login, string password)
        {
            string body = "Thank you for signing up with the SilCORE character Builder. " +
                          "We hope that you will enjoy using it to quickly generate PCs, or NPCs, for your campaign." + 
                          "\n\nPlease be aware that the system is a work in progress, and as such, is a bit feature bare. " +
                          "Updating and maintaining the SilCORE character builder is a hobby of mine and I strive to release meaningful " +
                          "updates once a month." +
                          "\n\nThe system is currently in an alpha state and can be used for quick and easy character generation. " + 
                          "More features will be added soon!" +
                          "\n\nIf you have any questions, concerns, or want to report a bug, you can contact the developers at SilCORECB@Gmail.com. " +
                          "We hope you find the tool useful." +
                          "\n\n- Matt, SilCORECB co-developer";

            return body;
        }

        public Boolean SendEmail(string sender, string email, string subject, string body)
        {
            Boolean status;

            try
            {
                SmtpClient mailClient = new SmtpClient();
                mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                mailClient.Host = "smtp.gmail.com";
                mailClient.EnableSsl = true;
                mailClient.Port = 587;

                mailClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("silcorecb@gmail.com", "$i1cor3cb");
                mailClient.Credentials = credentials;

                MailMessage newMail = new MailMessage();
                newMail.To.Add(new MailAddress(email));
                newMail.From = new MailAddress(sender);
                newMail.Subject = subject;
                newMail.Body = body;



                mailClient.Send(newMail);

                status = true;
            }
            catch (Exception ex)
            {
                NewErrorMail(ex.ToString(), "The initial login information e-mail was unable to be sent. Account is linked to " + email + ".", "SendEMail Function");
                status = false;
            }

            return status;
        }

        //E-mail-related subs
        public void NewErrorMail(string ex, string cause, string location)
        {
            string body = "The following error has occurred when a user attempted to create an account:" + "\n\n" +
                          "Location: " + location + "\n\n" +
                          "Most likely cause: " + cause + "\n\n" +
                          "Exception: " + ex;

            SendEmail("SilCORECB@gmail.com", "Matthew.Ullyott@Gmail.com", "There has been an error when a user attempted to sign up for the character builder:", body);
        }
    }
}



    

