using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Template_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = Calendar1.SelectedDate.Date.ToString("MM/dd/yyyy");
    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        Label2.Text = Calendar2.SelectedDate.Date.ToString("MM/dd/yyyy");
    }
}