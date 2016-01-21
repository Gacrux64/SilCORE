using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class CreateUser
{
    public CreateUser(firstName, lastName, login, email, password)
    {
        Boolean status = False;

        Byte[] salt = GenerateSalt();
        Byte[] encryptedPassword = EncodePassword(password, salt);

        String mailBody = NewPasswordEmail(firstName, login, password);

        If(EnterUser(firstName, lastName, login, email, salt, encryptedPassword))
        {
            If(SendEmail("CharacterCreator@DP9.com", email, "New SilCORE Character Creator System User", mailBody))
            {
                status = True;
            }
            Else
            {
                NewErrorMail("Undefined", "The resource has been successfully entered, but their initial login e-mail failed to be sent. Please use the Per Diem Tools application to generate and send them a new one.", "SendEMail Function");
            }
        }
        else
        {
            NewErrorMail("Undefined", "The Module to load a V1 resource into the Per Diem system has failed in some way.", "EnterUser Function");
        }
    }
}