using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewUser;
using System.Data.SqlClient;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        CreateUser user = new CreateUser();
        SqlConnection usernameConn = GetDBCOnnection();

        SqlCommand checkUser = new SqlCommand("SELECT USER_LOGIN FROM USER_INFO WHERE USER_LOGIN LIKE @userLogin", usernameConn);
        SqlParameter loginPar = new SqlParameter("userLogin", TextBoxLogin.Text.ToLower());
        checkUser.Parameters.Add(loginPar);


        usernameConn.Open();

        using (SqlDataReader sqlReader = checkUser.ExecuteReader())
        {

            if (!sqlReader.HasRows)
            {
                if (user.CreateNewUser(TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxLogin.Text.ToLower(), TextBoxEmail.Text, TextBoxPass2.Text.ToLower()))
                {
                    LabelMsg.Text = "Account created successfully!";
                }
                else
                {
                    LabelMsg.Text = "Account creation failed. The system administrator has been notified.";
                }
            }
            else
            {
                LabelMsg.Text = "Username already in use.";
            } 
        }
        usernameConn.Close();
    }
    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
        TextBoxFirstName.Text = String.Empty;
        TextBoxLastName.Text = String.Empty;
        TextBoxLogin.Text = String.Empty;
        TextBoxEmail.Text = String.Empty;
        TextBoxPass1.Text = String.Empty;
        TextBoxPass2.Text = String.Empty;
    }

//SQL functions
private SqlConnection GetDBCOnnection()
{
    string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Builder.mdf;Integrated Security=True";

    SqlConnection loginConnection = new SqlConnection(conStr);

    return loginConnection;
}

}