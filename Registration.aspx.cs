using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String fname = TextBox1.Text;
        String lname = TextBox2.Text;
        String username = TextBox3.Text;
        String email = TextBox4.Text;
        String pass = TextBox5.Text;
        String cpass = TextBox6.Text;
        Boolean valid=true;

        if (fname.Equals(""))
        {
            Label1.Text = "*Enter your First name";
            valid=false;
        }
        if (lname.Equals(""))
        {
            Label2.Text = "*Enter your Last name";
            valid=false;
        }
        if (username.Equals(""))
        {
            Label3.Text = "*Enter a username";
            valid=false;        
        }
        if (email.Equals(""))
        {
            Label4.Text = "*Enter your e-mail";
            valid=false;
        }
        if (pass.Equals(""))
        {
            Label5.Text = "*Enter a password";
            valid=false;
        }
        if (cpass.Equals("") || !cpass.Equals(pass))
        {
            Label6.Text = "*Confirm your password";
            valid=false;
        }
        if(valid){
            Label6.Text = "hello validation";
            //Query statement
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        Label1.Text = "";
        Label2.Text = "";
        Label3.Text = "";
        Label4.Text = "";
        Label5.Text = "";
        Label6.Text = "";
    }
}