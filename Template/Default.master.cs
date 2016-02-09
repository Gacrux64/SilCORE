using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;

public partial class Template : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["user"] == null)
        {
            loginControls.Visible = true;

            TextBoxUsername.Attributes["value"] = TextBoxUsername.Text;

            if (TextBoxUsername.Attributes["value"].ToString().Equals(""))
            {
                TextBoxUsername.Attributes["value"] = "Username";
            }

            if (!TextBoxUsername.Attributes["value"].ToString().Equals("Username"))
            {
                TextBoxUsername.ForeColor = System.Drawing.Color.Black;
            }
        }
        else
        {
            loggedIn.Visible = true;

            SqlConnection uIDConn = GetDBCOnnection();
            SqlCommand getUID = new SqlCommand("SELECT USER_LOGIN FROM USER_INFO WHERE USER_ID LIKE @userID", uIDConn);
            SqlParameter uIDPar = new SqlParameter("userID", Session["user"].ToString());
            getUID.Parameters.Add(uIDPar);

            uIDConn.Open();
            using (SqlDataReader sqlReader = getUID.ExecuteReader())
            {

                while (sqlReader.Read())
                {
                    LabelUsername.Text = sqlReader["USER_LOGIN"].ToString().Substring(0, 1).ToUpper() + sqlReader["USER_LOGIN"].ToString().Substring(1, sqlReader["USER_LOGIN"].ToString().Length - 1);
                }
            }
            uIDConn.Close();
        }
    }   

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {

        if (TextBoxUsername.Text.Equals("Username") && TextBoxPassword.Text.Equals("Password") || TextBoxUsername.Text.Equals("") && TextBoxPassword.Text.Equals(""))
        {
            LabelLoginMes.Text = "Enter your username and password.";
        }
        else if(TextBoxPassword.Text.Equals("Password") || TextBoxPassword.Text.Equals(""))
        {
            LabelLoginMes.Text = "Enter your password";
        }
        else if (TextBoxUsername.Text.Equals("Username") || TextBoxUsername.Text.Equals(""))
        {
            LabelLoginMes.Text = "Enter your username.";
            TextBoxPassword.Text = String.Empty;
            TextBoxPassword.Attributes["value"] = "Password";
        }
        else if(login(TextBoxUsername.Text.ToLower(), TextBoxPassword.Text.ToLower()))
        {

            SqlConnection uIDConn = GetDBCOnnection();
            SqlCommand getUID = new SqlCommand("SELECT USER_ID, USER_LOGIN FROM USER_INFO WHERE USER_LOGIN LIKE @userLogin", uIDConn);
            SqlParameter uIDPar = new SqlParameter("userLogin", TextBoxUsername.Text.ToLower());
            getUID.Parameters.Add(uIDPar);

            uIDConn.Open();
            using (SqlDataReader sqlReader = getUID.ExecuteReader())
            {

                while (sqlReader.Read())
                {
                    Session["user"] = sqlReader["USER_ID"].ToString();
                    LabelUsername.Text = sqlReader["USER_LOGIN"].ToString().Substring(0, 1).ToUpper() + sqlReader["USER_LOGIN"].ToString().Substring(1, sqlReader["USER_LOGIN"].ToString().Length - 1);
                }
            }
            uIDConn.Close();
            loggedIn.Visible = true;
            loginControls.Visible = false;
        }
    }

    //Handling login
    private bool login(string username, string password)
    {
        bool success = false;
        SqlConnection sqlConn = GetDBCOnnection();
        string salt = GetSalt(username, sqlConn);
        string encryptedPass = "";

        if (!salt.Equals("noUser"))
        {
            encryptedPass = EncryptPassword(password, salt);
            if (CheckPasswords(username, encryptedPass, sqlConn))
            {
                success = true;
            }
        }
        else
        {
            LabelLoginMes.Text = "No user found.";
        }

        return success;
    }
  

    //SQL functions
    private SqlConnection GetDBCOnnection()
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Builder.mdf;Integrated Security=True";

        SqlConnection loginConnection = new SqlConnection(conStr);

        return loginConnection;
    }

    //Checking entered password versus stored password.
    private bool CheckPasswords(string username, string encrpytedPassword, SqlConnection loginConn)
    {
        bool match = false;

        SqlCommand retrievePass = new SqlCommand("SELECT USER_PASSWORD FROM USER_INFO WHERE USER_LOGIN LIKE @userLogin", loginConn);
        SqlParameter loginPar = new SqlParameter("userLogin", username);
        retrievePass.Parameters.Add(loginPar);


        loginConn.Open();
        using (SqlDataReader sqlReader = retrievePass.ExecuteReader())
        {
           
            while (sqlReader.Read())
            {
                if (sqlReader["USER_PASSWORD"].ToString().Equals(encrpytedPassword))
                {
                    match = true;
                }
                else
                {
                    LabelLoginMes.Text = "Incorrect password.";
                    TextBoxPassword.Text = String.Empty;
                    TextBoxPassword.Attributes["value"] = "Password";
                }
            }
            loginConn.Close();
        }

        return match;
    }

    //Getting user salt.
    private string GetSalt(string username, SqlConnection loginConn)
    {
        string salt = "noUser";

        SqlCommand retrieveSalt = new SqlCommand("SELECT USER_SALT FROM USER_INFO WHERE USER_LOGIN LIKE @userLogin", loginConn);
        SqlParameter loginPar = new SqlParameter("userLogin", username);
        retrieveSalt.Parameters.Add(loginPar);

        loginConn.Open();

        using (SqlDataReader sqlReader = retrieveSalt.ExecuteReader())
        {

            while (sqlReader.Read())
            {
                LabelLoginMes.Text += "Salt is: " + sqlReader["USER_SALT"].ToString();

                if (!sqlReader["USER_SALT"].ToString().Equals(""))
                {
                    salt = sqlReader["USER_SALT"].ToString();
                }
            }

            loginConn.Close();
        }
        return salt;
    }


    //Encrypting entered password to compared to stored password.
    private string EncryptPassword(string password, string salt)
    {
        Byte[] fixedSalt = new Byte[8];

        fixedSalt = Convert.FromBase64String("+eroclis");
        password = salt + password + Convert.ToBase64String(fixedSalt);

        Byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

        SHA1 hash = SHA1CryptoServiceProvider.Create();

        for (int i = 0; i < 1000; i++)
        {
            Byte[] multiHashPassword = hash.ComputeHash(passwordBytes);
            passwordBytes = multiHashPassword;
        }

        return Convert.ToBase64String(passwordBytes);
    }

    protected void TextBoxUsername_TextChanged(object sender, EventArgs e)
    {

    }

    protected void LinkButtonLogout_Click(object sender, EventArgs e)
    {
        Session["user"] = null;
        Response.Redirect("Default.aspx");
    }

    protected void LinkButtonUser_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserPage.aspx");
    }
}
