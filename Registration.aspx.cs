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
            fnameAlert.Text = "*Enter your First name<br>";
            valid=false;
        }
        else
        {
            fnameAlert.Text = "";
        }
        if (lname.Equals(""))
        {
            lnameAlert.Text = "*Enter your Last name<br>";
            valid=false;
        }
        else
        {
            lnameAlert.Text = "";
        }
        if (username.Equals(""))
        {
            usernameAlert.Text = "*Enter a username<br>";
            valid=false;        
        }
        else
        {
            usernameAlert.Text = "";
        }
        if (email.Equals(""))
        {
            emailAlert.Text = "*Enter your e-mail<br>";
            valid=false;
        }
        else
        {
            emailAlert.Text = "";
        }
        if (pass.Equals(""))
        {
            passAlert.Text = "*Enter a password<br>";
            valid=false;
        }
        else
        {
            passAlert.Text = "";
        }
        if (cpass.Equals("") || !cpass.Equals(pass))
        {
            confpassAlert.Text = "*Confirm your password<br>";
            valid=false;
        }
        else
        {
            confpassAlert.Text = "";
        }
        if(valid){
            
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
        fnameAlert.Text = "";
        lnameAlert.Text = "";
        usernameAlert.Text = "";
        emailAlert.Text = "";
        passAlert.Text = "";
        confpassAlert.Text = "";
    }
}