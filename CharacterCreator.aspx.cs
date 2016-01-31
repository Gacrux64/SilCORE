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
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button36_Click(object sender, EventArgs e)
    {
        string skill = ListBox1.SelectedItem.Value;
        string level = DropDownList1.SelectedValue;
        string complex = DropDownList2.SelectedValue;
        ListBox1.Items.Remove(ListBox1.SelectedItem);

        string toListbox2 = skill + ": Level-" + level + ", Complexity-" + complex;
        
            ListBox4.Items.Add(toListbox2);
        
    }
    protected void Button35_Click(object sender, EventArgs e)
    {
        string item = ListBox4.SelectedItem.Text; 
        int l = item.IndexOf(":");
        string itemBack = item.Substring(0, l);

        ListBox1.Items.Add(itemBack);
        ListBox4.Items.Remove(ListBox4.SelectedItem);
        
    }

}