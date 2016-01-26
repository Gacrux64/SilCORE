using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewUser;


public class CreateUser
{
    public CreateUser(String firstName, String lastName, String login, String email, String password)
    {
        Boolean status = false;

        NewUser.UserPassword PWClass = new UserPassword();

        Byte[] salt = PWClass.GenerateSalt();
        Byte[] encryptedPassword = PWClass.EncodePassword(password, salt);
        /*
        //String mailBody = NewPasswordEmail(firstName, login, password);

        //If(EnterUser(firstName, lastName, login, email, salt, encryptedPassword))
        //{
        //    If(SendEmail("CharacterCreator@DP9.com", email, "New SilCORE Character Creator System User", mailBody))
        //    {
        //        status = true;
        //    }
        //    Else
        //    {
        //        NewErrorMail("Undefined", "The resource has been successfully entered, but their initial login e-mail failed to be sent. Please use the Per Diem Tools application to generate and send them a new one.", "SendEMail Function");
        //    }
        //}
        //else
        //{
        //    NewErrorMail("Undefined", "The Module to load a V1 resource into the Per Diem system has failed in some way.", "EnterUser Function");
        //}

        return status;
        */
    }
}