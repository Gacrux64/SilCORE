using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Redirect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Query"].Equals("CharSubmit"))
        {
            LabelMes.Text = "Character successfully submitted.";
        }
        else if(Request.QueryString["Query"].Equals("Registration"))
        {
            LabelMes.Text = "Account successfully registered.";
        }

        Response.AddHeader("REFRESH", "5;URL=UserPage.aspx");
    }
}