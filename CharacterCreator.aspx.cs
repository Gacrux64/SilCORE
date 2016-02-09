using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Template_Default : System.Web.UI.Page
{
    public static int number=10;
    public static bool hth = false;
    public static int lvlhth;
    public static bool melee = false;
    public static int lvlmelee;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = number.ToString();
      
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button36_Click(object sender, EventArgs e)
    {
        string skill = ListBox1.SelectedItem.Value;
        string level = DropDownList1.SelectedValue;
        if(skill=="Hand-to-hand"){
            hth = true;
            lvlhth = Int32.Parse(level);
        }
        if(skill=="Melee"){
            melee = true;
            lvlmelee = Int32.Parse(level);
        }
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
        if(itemBack=="Hand-to-hand"){
            hth = false;
        }
        if (itemBack == "Melee")
        {
            melee = false;
        }

        ListBox1.Items.Add(itemBack);
        ListBox4.Items.Remove(ListBox4.SelectedItem);
        
    }
    protected void Button37_Click(object sender, EventArgs e)
    {
        string perks = ListBox2.SelectedItem.Value;
        ListBox2.Items.Remove(ListBox2.SelectedItem);
        ListBox5.Items.Add(perks);
    }
    protected void Button38_Click(object sender, EventArgs e)
    {
        string item = ListBox5.SelectedItem.Value;
        ListBox2.Items.Add(item);
        ListBox5.Items.Remove(ListBox5.SelectedItem);
    }
    protected void Button39_Click(object sender, EventArgs e)
    {
        string flaws=ListBox3.SelectedItem.Value;
        ListBox3.Items.Remove(ListBox3.SelectedItem);
        ListBox6.Items.Add(flaws);
    }
    protected void Button40_Click(object sender, EventArgs e)
    {
        string item = ListBox6.SelectedItem.Value;
        ListBox3.Items.Add(item);
        ListBox6.Items.Remove(ListBox6.SelectedItem);
    }
    protected void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        int num = add(TextBox2.Text);
        Label1.Text = number.ToString();
        TextBox2.Text = num.ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox2.Text);
        Label1.Text = number.ToString();
        TextBox2.Text = num.ToString();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        int num = add(TextBox3.Text);
        Label1.Text = number.ToString();
        TextBox3.Text = num.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox3.Text);
        Label1.Text = number.ToString();
        TextBox3.Text = num.ToString();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        int num = Int32.Parse(TextBox4.Text);
        if (num < 5 && number > 0)
        {
            num = num + 1;
            number = number - 1;
        }
        Label1.Text = number.ToString();
        TextBox4.Text = num.ToString();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        int num = Int32.Parse(TextBox4.Text);
        if (num > -5)
        {
            num = num - 1;
            number = number + 1;
        }
        Label1.Text = number.ToString();
        TextBox4.Text = num.ToString();
    }
   
    protected void Button8_Click(object sender, EventArgs e)
    {
        int num = add(TextBox5.Text);
        Label1.Text = number.ToString();
        TextBox5.Text = num.ToString();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox5.Text);
        Label1.Text = number.ToString();
        TextBox5.Text = num.ToString();
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        int num = add(TextBox6.Text);
        Label1.Text = number.ToString();
        TextBox6.Text = num.ToString();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox6.Text);
        Label1.Text = number.ToString();
        TextBox6.Text = num.ToString();
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        int num = add(TextBox7.Text);
        Label1.Text = number.ToString();
        TextBox7.Text = num.ToString();
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox7.Text);
        Label1.Text = number.ToString();
        TextBox7.Text = num.ToString();
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        int num = add(TextBox8.Text);
        Label1.Text = number.ToString();
        TextBox8.Text = num.ToString();
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox8.Text);
        Label1.Text = number.ToString();
        TextBox8.Text = num.ToString();
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        int num = add(TextBox9.Text);
        Label1.Text = number.ToString();
        TextBox9.Text = num.ToString();
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox9.Text);
        Label1.Text = number.ToString();
        TextBox9.Text = num.ToString();
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        int num = add(TextBox10.Text);
        Label1.Text = number.ToString();
        TextBox10.Text = num.ToString();
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox10.Text);
        Label1.Text = number.ToString();
        TextBox10.Text = num.ToString();
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        int num = add(TextBox11.Text);
        Label1.Text = number.ToString();
        TextBox11.Text = num.ToString();
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox11.Text);
        Label1.Text = number.ToString();
        TextBox11.Text = num.ToString();
    }
    protected int add(string textNum)
    {
        int num = Int32.Parse(textNum);
        if (num < 3 && number > 0)
        {
            num = num + 1;
            number = number - 1;
        }
        return num;
    }
    protected int remove(string textNum)
    {
        int num = Int32.Parse(textNum);
        if (num > -3)
        {
            num = num - 1;
            number = number + 1;
        }
        return num;
    }
    protected void secondaryStats()
    {
        
        
    }
    protected void Button48_Click(object sender, EventArgs e)
    {
        double agi = Int32.Parse(TextBox2.Text);
        double app = Int32.Parse(TextBox3.Text);
        double bdl = Int32.Parse(TextBox4.Text);
        double cre = Int32.Parse(TextBox5.Text);
        double fit = Int32.Parse(TextBox6.Text);
        double inf = Int32.Parse(TextBox7.Text);
        double kno = Int32.Parse(TextBox8.Text);
        double per = Int32.Parse(TextBox9.Text);
        double psy = Int32.Parse(TextBox10.Text);
        double wil = Int32.Parse(TextBox11.Text);
        double str = Math.Round((bdl+fit)/2);
        double hea = Math.Round((fit+psy+wil)/3);
        double sta = Math.Round((bdl + hea) * 5 + 25);
        double ud;
        double ad;
        double fleshw = Math.Round(sta / 2);
        double deepw = sta;
        double death = sta * 2;
        if(str>3){
            str = 3;
        }
        if (hth)
        {
            ud = lvlhth + str + bdl;
            if(ud<1){
                ud = 1;
            }
        }
        else
        {
            ud = 1;
        }
        if(melee){
            ad = lvlmelee + str + bdl;
        }
        else
        {
            ad = 1;
        }

        TextBox12.Text = str.ToString();
        TextBox13.Text = hea.ToString();
        TextBox14.Text = sta.ToString();
        TextBox15.Text = ud.ToString();
        TextBox16.Text = ad.ToString();
        TextBox17.Text = fleshw.ToString();
        TextBox18.Text = deepw.ToString();
        TextBox19.Text = death.ToString();
        
    }
}