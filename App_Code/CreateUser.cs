using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewUser;


namespace NewUser
{
    public class CreateUser
    {
        public Boolean CreateNewUser(String firstName, String lastName, String login, String email, String password)
        {
            Boolean status = false;

            NewUser.UserPassword PWClass = new UserPassword();
            NewUser.UserMail MailClass = new UserMail();
            NewUser.UserSQLIO SQLIOClass = new UserSQLIO();

            Byte[] salt = PWClass.GenerateSalt();
            Byte[] encryptedPassword = PWClass.EncodePassword(password, salt);

            String mailBody = MailClass.NewPasswordEmail(firstName, login, password);

            if (SQLIOClass.EnterUser(firstName, lastName, login, email, salt, encryptedPassword))
            {
                if (MailClass.SendEmail("CharacterCreator@DP9.com", email, "New SilCORE Character Creator System User", mailBody))
                {
                    status = true;
                }
                else
                {
                    MailClass.NewErrorMail("Undefined", "The resource has been successfully entered, but their initial login e-mail failed to be sent. Please use the Per Diem Tools application to generate and send them a new one.", "SendEMail Function");
                }
            }
            else
            {
                MailClass.NewErrorMail("Undefined", "The Module to load a V1 resource into the Per Diem system has failed in some way.", "EnterUser Function");
            }

            return status;
        }
    }
}
