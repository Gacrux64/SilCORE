using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewUser;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        CreateUser user = new CreateUser();

        if(user.CreateNewUser(TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxLogin.Text, TextBoxEmail.Text, TextBoxPass2.Text))
        {
            LabelMsg.Text = "Account created successfully!";
        }
        else
        {
            LabelMsg.Text = "Account creation failed. The system administrator has been notified.";
        }
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
}