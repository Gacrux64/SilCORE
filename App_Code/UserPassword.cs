using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

/// <summary>
/// Summary description for UserPassword
/// </summary>
public class UserPassword
{
    public UserPassword()
    {
        
    }

    public Byte[] GenerateSalt()
    {
        Byte[] salt = new Byte[8];
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        rng.GetNonZeroBytes(salt);
        return salt;
    }

    public Byte[] EncodePassword(String password, Byte[] salt)
    {
        Byte[] fixedSalt = new Byte[8];

        fixedSalt = Convert.FromBase64String("+eroclis/");
        password = Convert.ToBase64String(salt) + password + Convert.ToBase64String(fixedSalt);

        Byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

        SHA1 hash = SHA1CryptoServiceProvider.Create();

            for (int i = 0; i < 1000; i++)
        {
            Byte[] multiHashPassword = hash.ComputeHash(passwordBytes);
            passwordBytes = multiHashPassword;
        }

        return passwordBytes;
    }
}