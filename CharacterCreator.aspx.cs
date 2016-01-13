using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{   
    public int startPoint=10;
    public int agi = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Label1.Text = startPoint.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int agiGet = int.Parse(TextBox2.Text);
        agi= agiGet;
        if(startPoint<10){
            startPoint += 1;
            agi = agiGet - 1;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int agiGet = int.Parse(TextBox2.Text);
        agi = agiGet;
        if (startPoint > 0)
        {
            startPoint -= 1;
            agi = agiGet + 1;
        }
    }
}