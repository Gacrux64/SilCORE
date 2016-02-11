using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Template_Default : System.Web.UI.Page
{
    public static double number=10;
    public static int dependentValue;
    public static bool hth = false;
    public static int lvlhth;
    public static bool melee = false;
    public static int lvlmelee;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = number.ToString();
        if (!IsPostBack)
        {
            number = 10;
        }
        TextBox21.Text = number.ToString(); 
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button36_Click(object sender, EventArgs e)
    {
        string skill = ListBox1.SelectedItem.Value;
        string level = DropDownList1.SelectedValue;
        var listitem = new ListItem();
        if(skill=="Hand-to-hand"){
            hth = true;
            lvlhth = Int32.Parse(level);
        }
        if(skill=="Melee"){
            melee = true;
            lvlmelee = Int32.Parse(level);
        }
        string complex = DropDownList2.SelectedValue;
        

        string toListbox2 = skill + ": Level-" + level + ", Complexity-" + complex;
        int value = Int32.Parse(level) + Int32.Parse(complex);
        if (number >= value)
        {
            ListBox1.Items.Remove(ListBox1.SelectedItem);
            number = number - value;
            Label1.Text = number.ToString();
          
            TextBox21.Text = number.ToString();
            listitem.Text = toListbox2;
            listitem.Value = value.ToString();
            ListBox4.Items.Add(listitem);
        }
        
    }
    protected void Button35_Click(object sender, EventArgs e)
    {
        string item = ListBox4.SelectedItem.Text; 
        int l = item.IndexOf(":");
        string itemBack = item.Substring(0, l);
        number = number + Int32.Parse(ListBox4.SelectedItem.Value);
        if(itemBack=="Hand-to-hand"){
            hth = false;
        }
        if (itemBack == "Melee")
        {
            melee = false;
        }

        Label1.Text = number.ToString();
        ListBox1.Items.Add(itemBack);
        ListBox4.Items.Remove(ListBox4.SelectedItem);
        
    }
    protected void Button37_Click(object sender, EventArgs e)
    {
       
        string perks = ListBox2.SelectedItem.Text;
        string acutesense;
        string companion;
        string kinship;
        string allies;
        string contacts;
        string famous;
        string favor;
        string influence;
        string memory;
        string property;
        string rank;
        string sense;
        string wealthy;
        string cwealthy="";
        var listitem = new ListItem();
        string perkadd="";
        int value=0;
       
        if (ListBox2.SelectedItem.Text.Equals("Acute Sense (Specific)"))
        {
            
            acutesense = DropDownList3.SelectedItem.Text;
            perkadd = perks + "-" + acutesense;
            value = 1;
            
        }
        else if (ListBox2.SelectedItem.Text.Equals("Animal Companion"))
        {
            companion = DropDownList4.SelectedItem.Text;
            perkadd = perks + "-" + companion;
            value = Int32.Parse(DropDownList4.SelectedItem.Value);
        }
        else if (ListBox2.SelectedItem.Text.Equals("Animal Kinship"))
        {
            kinship = DropDownList5.SelectedItem.Text;
            perkadd = perks + "-" + kinship;
            value = Int32.Parse(DropDownList5.SelectedItem.Value);
        }
        else if (ListBox2.SelectedItem.Text.Equals("Connections (Allies)"))
        {
            allies = DropDownList6.SelectedItem.Text;
            perkadd = perks + "-" + allies;
            value = Int32.Parse(DropDownList5.SelectedItem.Value);
        }
        else if (ListBox2.SelectedItem.Text.Equals("Connections (Contacts)"))
        {
            contacts = DropDownList7.SelectedItem.Text;
            perkadd = perks + "-" + contacts;
            value = Int32.Parse(DropDownList7.SelectedItem.Value);
        }
        else if (ListBox2.SelectedItem.Text.Equals("Famous"))
        {
            famous = DropDownList8.SelectedItem.Text;
            perkadd = perks + "-" + famous;
            value = Int32.Parse(DropDownList8.SelectedItem.Value);
        }
        else if (ListBox2.SelectedItem.Text.Equals("Favor"))
        {
            favor = DropDownList9.SelectedItem.Text;
            perkadd = perks + "-" + favor;
            value = Int32.Parse(DropDownList9.SelectedItem.Value);
        }
        else if (ListBox2.SelectedItem.Text.Equals("Influence"))
        {
            influence = DropDownList10.SelectedItem.Text;
            perkadd = perks + "-" + influence;
            value = Int32.Parse(DropDownList10.SelectedItem.Value);
        }
        else if (ListBox2.SelectedItem.Text.Equals("Photographic Memory"))
        {
            memory = DropDownList11.SelectedItem.Text;
            perkadd = perks + "-" + memory;
            int value1 = Int32.Parse(DropDownList11.SelectedItem.Value);
            value = value1 * 2;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Property"))
        {
            property = DropDownList16.SelectedItem.Text;
            perkadd = perks + "-" + property;
            value = Int32.Parse(DropDownList16.SelectedItem.Value);
        }
        else if (ListBox2.SelectedItem.Text.Equals("Military Rank"))
        {
            if (number > Int32.Parse(DropDownList12.SelectedItem.Value))
            {
                rank = DropDownList12.SelectedItem.Text;
                perkadd = perks + "-" + rank;
                value = Int32.Parse(DropDownList12.SelectedItem.Value);
            }
        }
        else if (ListBox2.SelectedItem.Text.Equals("Sense of Direction"))
        {
            if (number > Int32.Parse(DropDownList13.SelectedItem.Value))
            {
                sense = DropDownList13.SelectedItem.Text;
                perkadd = perks + "-" + sense;
                value = Int32.Parse(DropDownList13.SelectedItem.Value);
            }
        }
        else if (ListBox2.SelectedItem.Text.Equals("Wealthy"))
        {
            wealthy = DropDownList17.SelectedItem.Text;
            if (wealthy != "" && number > Int32.Parse(DropDownList14.SelectedItem.Value))
            {
                if (wealthy.Equals("Renewable"))
                {
                    cwealthy = DropDownList14.SelectedItem.Text;
                    value = Int32.Parse(DropDownList14.SelectedItem.Value);
                }
                else if (wealthy.Equals("Non-Renewable"))
                {
                    cwealthy = DropDownList15.SelectedItem.Text;
                    value = Int32.Parse(DropDownList15.SelectedItem.Value);
                }
                perkadd = perks + "-" + wealthy + ":" + cwealthy;
            }
        }
        else if (ListBox2.SelectedItem.Text.Equals("Accelerated Healing"))
        {
            perkadd = perks;
            value = 4;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Smell"))
        {
            perkadd = perks;
            value = 2;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Taste"))
        {
            perkadd = perks;
            value = 2;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Ambidextrous"))
        {
            perkadd = perks;
            value = 1;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Authority"))
        {
            perkadd = perks;
            value = 3;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Common Sense"))
        {
            perkadd = perks;
            value = 4;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Double Jointed"))
        {
            perkadd = perks;
            value = 3;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Fake Identity"))
        {
            perkadd = perks;
            value = 3;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Immunity"))
        {
            perkadd = perks;
            value = 1;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Intuition"))
        {
            perkadd = perks;
            value = 4;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Light Sleeper"))
        {
            perkadd = perks;
            value = 5;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Longevity"))
        {
            perkadd = perks;
            value = 3;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Lucky"))
        {
            perkadd = perks;
            value = 10;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Machine-Touch"))
        {
            perkadd = perks;
            value = 5;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Perfect Pitch"))
        {
            perkadd = perks;
            value = 5;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Quick Learner"))
        {
            perkadd = perks;
            value = 2;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Radiation Resistance"))
        {
            perkadd = perks;
            value = 2;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Sense of Time"))
        {
            perkadd = perks;
            value = 2;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Strong Immune System"))
        {
            perkadd = perks;
            value = 3;
        }
        else if (ListBox2.SelectedItem.Text.Equals("Thick-Skinned"))
        {
            perkadd = perks;
            value = 4;
        }
        else
        {
            perkadd = "";
           
        }

        if (perkadd != "")
        {
            number = number - value;
            Label1.Text = number.ToString();
          
            TextBox21.Text = number.ToString();
            listitem.Text = perkadd;
            listitem.Value = value.ToString();
            ListBox5.Items.Add(listitem);
        }
    }
    protected void Button38_Click(object sender, EventArgs e)
    {
        string item = ListBox5.SelectedItem.Text;
        int value = Int32.Parse(ListBox5.SelectedItem.Value);
        number = number + value;
        Label1.Text = number.ToString();
    
        TextBox21.Text = number.ToString();
        ListBox5.Items.Remove(ListBox5.SelectedItem);
    }
    protected void Button39_Click(object sender, EventArgs e)
    {
        string flaws=ListBox3.SelectedItem.Value;
        string addiction;
        double rating;
        string age;
        string belief;
        string honor;
        string criminal;
        string curse;
        string debt;
        string dedicated;
        string infamous;
        string lame;
        string liar;
        string motionsickness;
        string obligation;
        string onearmed;
        string phobia;
        string poorsense;
        string quirk;
        string secret;
        string sick;
        string socialstigma;
        string wanted;
        string flawadd="";
        double value=0;
        if (ListBox3.SelectedItem.Text.Equals("Addiction"))
        {
            addiction = TextBox24.Text;
            

            if (!addiction.Equals("") || !addiction.Equals("Drugs"))
            {
                if (!TextBox25.Text.Equals("Rating"))
                {
                    
                    rating = Int32.Parse(TextBox25.Text);
                    value = Math.Round(-rating/3);
                    flawadd = flaws + "-" + addiction+":"+rating;
                }
            }
            else
            {

            }
        }
        else if (ListBox3.SelectedItem.Text.Equals("Age"))
        {
            age = DropDownList19.SelectedItem.Text;
            flawadd = flaws+"-"+age;
            value = Int32.Parse(DropDownList19.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Amnesiac"))
        {
            flawadd = flaws;
            value = -4;
        }
        else if(ListBox3.SelectedItem.Text.Equals("Animal Antipathy"))
        {
            flawadd = flaws;
            value = -2;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Bad Luck"))
        {
            flawadd = flaws;
            value = -2;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Beliefs"))
        {
            belief = DropDownList20.SelectedItem.Text;
            flawadd = flaws + "-" + belief;
            value = Int32.Parse(DropDownList20.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Bloodlust"))
        {
            flawadd = flaws;
            value = -4;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Code Honor"))
        {
            honor = DropDownList21.SelectedItem.Text;
            flawadd = flaws + "-" + honor;
            value = Int32.Parse(DropDownList21.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Criminal Background"))
        {
            criminal = DropDownList22.SelectedItem.Text;
            flawadd = flaws + "-" + criminal;
            value = Int32.Parse(DropDownList22.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Curse"))
        {
            curse = DropDownList23.SelectedItem.Text;
            flawadd = flaws + "-" + curse;
            value = Int32.Parse(DropDownList23.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Debt"))
        {
            debt = DropDownList24.SelectedItem.Text;
            flawadd = flaws + "-" + debt;
            value = Int32.Parse(DropDownList24.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Dedicated"))
        {
            dedicated = DropDownList25.SelectedItem.Text;
            flawadd = flaws + "-" + dedicated;
            value = Int32.Parse(DropDownList25.SelectedItem.Value);
        }
        
        else if (ListBox3.SelectedItem.Text.Equals("Destitute"))
        {
            flawadd = flaws;
            value = -2;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Flashbacks"))
        {
            flawadd = flaws;
            value = -2;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Goal"))
        {
            flawadd = flaws;
            value = -3;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Heavy Sleeper"))
        {
            flawadd = flaws;
            value = -2;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Infamous"))
        {
            infamous = DropDownList26.SelectedItem.Text;
            flawadd = flaws + "-" + infamous;
            value = Int32.Parse(DropDownList26.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Insomniac"))
        {
            flawadd = flaws;
            value = -1;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Lame"))
        {
            lame = DropDownList27.SelectedItem.Text;
            flawadd = flaws + "-" + lame;
            value = Int32.Parse(DropDownList27.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Liar"))
        {
            liar = DropDownList28.SelectedItem.Text;
            flawadd = flaws + "-" + liar;
            value = Int32.Parse(DropDownList28.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Mechanical Inaptitude"))
        {
            flawadd = flaws;
            value = -1;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Motion Sickness"))
        {
            motionsickness = TextBox26.Text;
            flawadd = flaws + "-" + motionsickness;
            value = Int32.Parse(TextBox26.Text);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Obligations"))
        {
            obligation = DropDownList30.SelectedItem.Text;
            flawadd = flaws + "-" + obligation;
            value = Int32.Parse(DropDownList30.SelectedItem.Value);

        }
        else if (ListBox3.SelectedItem.Text.Equals("One-Armed"))
        {
            onearmed = DropDownList31.SelectedItem.Text;
            flawadd = flaws+"-"+onearmed;
            value = Int32.Parse(DropDownList31.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Paranoid"))
        {
            flawadd = flaws;
            value = -3;

        }
        else if (ListBox3.SelectedItem.Text.Equals("Phobia"))
        {
            phobia = DropDownList32.SelectedItem.Text;
            flawadd = flaws + "-" + phobia;
            value = Int32.Parse(DropDownList33.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Poor Senses (Specific)"))
        {
            poorsense = DropDownList33.SelectedItem.Text;
            if (DropDownList33.SelectedItem.Text.Equals("Blind/Deaf"))
            {
                string badsense=DropDownList34.SelectedItem.Text;

                if (DropDownList34.SelectedItem.Text.Equals("Temporary Deaf"))
                {
                    value = -2;
                }
                else if (DropDownList34.SelectedItem.Text.Equals("Temporary Blind"))
                {
                    value = -2;
                }
                else if (DropDownList34.SelectedItem.Text.Equals("Permanently Deaf"))
                {
                    value = -8;
                }
                else if (DropDownList34.SelectedItem.Text.Equals("Permanently Blind"))
                {
                    value = -8;
                }
                flawadd = flaws + "-" + poorsense + "-" + badsense;
            }
            else
            {
                flawadd = flaws + "-" + poorsense;
                value = -2;
            }

        }
        else if (ListBox3.SelectedItem.Text.Equals("Quirk"))
        {
            quirk = DropDownList35.SelectedItem.Text;
            flawadd = flaws + "-" + quirk;
            value = Int32.Parse(DropDownList35.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Radiation Vulnerability"))
        {
            flawadd = flaws;
            value = -2;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Secret"))
        {
            secret = DropDownList36.SelectedItem.Text;
            flawadd = flaws + "-" + secret;
            value = Int32.Parse(DropDownList36.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Sick"))
        {
            sick = DropDownList37.SelectedItem.Text;
            flawadd = flaws + "-" + sick;
            value = Int32.Parse(DropDownList37.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Slow Healing"))
        {
            flawadd = flaws;
            value = -4;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Slow Learner"))
        {
            flawadd = flaws;
            value = -2;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Social Stigma"))
        {
            socialstigma = DropDownList38.SelectedItem.Text;
            flawadd = flaws + "-" + socialstigma;
            value = Int32.Parse(DropDownList38.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Split Personality"))
        {
            flawadd = flaws;
            value = -7;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Thin-Skinned"))
        {
            flawadd = flaws;
            value = -4;
        }
        else if (ListBox3.SelectedItem.Text.Equals("Wanted"))
        {
            wanted = DropDownList39.SelectedItem.Text;
            flawadd = flaws + "-" + wanted;
            value = Int32.Parse(DropDownList39.SelectedItem.Value);
        }
        else if (ListBox3.SelectedItem.Text.Equals("Weak Immune System"))
        {
            flawadd = flaws;
            value = -3;
        }
        var listitem = new ListItem();
        if (flawadd != "")
        {
            number = number - value;
            Label1.Text = number.ToString();

            TextBox21.Text = number.ToString();
            listitem.Text = flawadd;
            listitem.Value = value.ToString();
            ListBox6.Items.Add(listitem);
        }
     
    }
    protected void Button40_Click(object sender, EventArgs e)
    {
        string item = ListBox6.SelectedItem.Text;
        int removevalue = Int32.Parse(ListBox6.SelectedItem.Value);
        number = number + removevalue;
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        ListBox6.Items.Remove(ListBox6.SelectedItem);
    }
    protected void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ListBox3.SelectedItem.Text.Equals("Addiction"))
        {
            flawsDiv1.Visible = true;
        }
        else
        {
            flawsDiv1.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Age"))
        {
            age.Visible = true;
        }
        else
        {
            age.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Beliefs"))
        {
            belief.Visible = true;
        }
        else
        {
            belief.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Code of Honor"))
        {
            honor.Visible = true;
        }
        else
        {
            honor.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Criminal Background"))
        {
            criminal.Visible = true;
        }
        else
        {
            criminal.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Curse"))
        {
            curse.Visible = true;
        }
        else
        {
            curse.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Debt"))
        {
            debt.Visible = true;
        }
        else
        {
            debt.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Dedicated"))
        {
            dedicated.Visible = true;
        }
        else
        {
            dedicated.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Infamous"))
        {
            infamous.Visible = true;
        }
        else
        {
            infamous.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Lame"))
        {
            lame.Visible = true;
        }
        else
        {
            lame.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Liar"))
        {
            liar.Visible = true;
        }
        else
        {
            liar.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Motion Sickness"))
        {
            motionsickness.Visible = true;
        }
        else
        {
            motionsickness.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Obligations"))
        {
            obligation.Visible = true;
        }
        else
        {
            obligation.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("One-Armed"))
        {
            onearmed.Visible = true;
        }
        else
        {
            onearmed.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Phobia"))
        {
            phobia.Visible = true;
        }
        else
        {
            phobia.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Poor Senses (Specific)"))
        {
            poorsense.Visible = true;
        }
        else
        {
            poorsense.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Quirk"))
        {
            quirk.Visible = true;
        }
        else
        {
            quirk.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Secret"))
        {
            secret.Visible = true;
        }
        else
        {
            secret.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Sick"))
        {
            sick.Visible = true;
        }
        else
        {
            sick.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Social Stigma"))
        {
            socialstigma.Visible = true;
        }
        else
        {
            socialstigma.Visible = false;
        }
        if (ListBox3.SelectedItem.Text.Equals("Wanted"))
        {
            wanted.Visible = true;
        }
        else
        {
            wanted.Visible = false;
        }
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        int num = add(TextBox2.Text);
        Label1.Text = number.ToString();
     
        TextBox21.Text = number.ToString();
        TextBox2.Text = num.ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox2.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox2.Text = num.ToString();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        int num = add(TextBox3.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox3.Text = num.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox3.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
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
        TextBox21.Text = number.ToString();
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
        TextBox21.Text = number.ToString();
        TextBox4.Text = num.ToString();
    }
   
    protected void Button8_Click(object sender, EventArgs e)
    {
        int num = add(TextBox5.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox5.Text = num.ToString();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox5.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox5.Text = num.ToString();
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        int num = add(TextBox6.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox6.Text = num.ToString();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox6.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox6.Text = num.ToString();
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        int num = add(TextBox7.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox7.Text = num.ToString();
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox7.Text);
        Label1.Text = number.ToString();
        TextBox7.Text = num.ToString();
        TextBox21.Text = number.ToString();
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        int num = add(TextBox8.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox8.Text = num.ToString();
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox8.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox8.Text = num.ToString();
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        int num = add(TextBox9.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox9.Text = num.ToString();
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox9.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox9.Text = num.ToString();
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        int num = add(TextBox10.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox10.Text = num.ToString();
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox10.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox10.Text = num.ToString();
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        int num = add(TextBox11.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
        TextBox11.Text = num.ToString();
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        int num = remove(TextBox11.Text);
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
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
        secondaryStats();
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
        secondaryStats();
        return num;
    }
    protected void secondaryStats()
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
        double str = Math.Round((bdl + fit) / 2);
        double hea = Math.Round((fit + psy + wil) / 3);
        double sta = Math.Round((bdl + hea) * 5 + 25);
        double ud;
        double ad;
        double fleshw = Math.Round(sta / 2);
        double deepw = sta;
        double death = sta * 2;
        double system = hea + 5;
        if (str > 3)
        {
            str = 3;
        }
        if (hth)
        {
            ud = lvlhth + str + bdl;
            if (ud < 1)
            {
                ud = 1;
            }
        }
        else
        {
            ud = 1;
        }
        if (melee)
        {
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
        TextBox20.Text = system.ToString();

    }
    

    protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        
            if (ListBox2.SelectedItem.Value == "Acute Sense (Specific)")
            {
                perksDiv1.Visible = true;
            }
            else
            {
                perksDiv1.Visible = false;
            }
            if (ListBox2.SelectedItem.Text =="Animal Companion")
            {
                perksDiv2.Visible = true;
            }
            else
            {
                perksDiv2.Visible = false;
            }
        if (ListBox2.SelectedItem.Text == "Animal Kinship")
        {
            perksDiv3.Visible = true;
        }
        else
        {
            perksDiv3.Visible = false;
        }
        if (ListBox2.SelectedItem.Text == "Connections (Allies)")
        {
            perksDiv4.Visible = true;
        }
        else
        {
            perksDiv4.Visible = false;
        }
        if (ListBox2.SelectedItem.Text == "Connections (Contacts)")
        {
            perksDiv5.Visible = true;
        }
        else
        {
            perksDiv5.Visible = false;
        }
        if (ListBox2.SelectedItem.Text == "Famous")
        {
            perksDiv6.Visible = true;
        }
        else
        {
            perksDiv6.Visible = false;
        }
        if (ListBox2.SelectedItem.Text == "Favor")
        {
            perksDiv7.Visible = true;
        }
        else
        {
            perksDiv7.Visible = false;
        }
        if (ListBox2.SelectedItem.Text == "Influence")
        {
            perksDiv8.Visible = true;
        }
        else
        {
            perksDiv8.Visible = false;
        }
        if (ListBox2.SelectedItem.Text == "Photographic Memory")
        {
            perksDiv9.Visible = true;
        }
        else
        {
            perksDiv9.Visible = false;
        }
        if (ListBox2.SelectedItem.Text == "Property")
        {
            perksDiv105.Visible = true;
        }
        else
        {
            perksDiv105.Visible = false;
        }
        if (ListBox2.SelectedItem.Text == "Military Rank")
        {
            perksDiv10.Visible = true;
        }
        else
        {
            perksDiv10.Visible = false;
        }
        if (ListBox2.SelectedItem.Text == "Sense of Direction")
        {
            perksDiv11.Visible = true;
        }
        else
        {
            perksDiv11.Visible = false;
        }
        if(ListBox2.SelectedItem.Text == "Wealthy")
        {
            perksDiv12.Visible = true;
        }
        else
        {
            perksDiv12.Visible = false;
        }
    }

    protected void DropDownList17_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList17.SelectedItem.Value.Equals("Renewable")) {
            DropDownList14.Visible = true;
            DropDownList15.Visible = false;
        }
        else if (DropDownList17.SelectedItem.Value.Equals("Non-Renewable"))
        {
            DropDownList15.Visible = true;
            DropDownList14.Visible = false;
        }
        else
        {
            DropDownList16.Visible = false;
            DropDownList15.Visible = false;
        }
    }





    protected void DropDownList18_SelectedIndexChanged(object sender, EventArgs e)
    {
        number = Int32.Parse(DropDownList18.SelectedItem.Value);
        dependentValue = Int32.Parse(DropDownList18.SelectedItem.Value);
        reset();
        if (DropDownList18.SelectedItem.Text.Equals("Custom"))
        {
            customgame.Visible = true;
        }
        else
        {
            customgame.Visible = false;
        }
        Label1.Text = number.ToString();
        TextBox21.Text = number.ToString();
    }


   

    protected void Button42_Click(object sender, EventArgs e)
    {
if (number>0)
        {
            number = number - 1;
            int exp = Int32.Parse(TextBox22.Text);
            int newexp = exp + 1;
            string newnum = number.ToString();
            Label1.Text = newnum;
            TextBox21.Text = newnum;
            TextBox22.Text = newexp.ToString();
        }
    }

    protected void TextBox23_TextChanged(object sender, EventArgs e)
    {
        
        number = Int32.Parse(TextBox23.Text);
        reset();
        string newnum = number.ToString();
        Label1.Text = newnum;
    }
    protected void reset()
    {
        string resetValue = "0";
        
        TextBox2.Text = resetValue;
        TextBox3.Text = resetValue;
        TextBox4.Text = resetValue;
        TextBox5.Text = resetValue;
        TextBox6.Text = resetValue;
        TextBox7.Text = resetValue;
        TextBox8.Text = resetValue;
        TextBox9.Text = resetValue;
        TextBox10.Text = resetValue;
        TextBox11.Text = resetValue;
        TextBox12.Text = resetValue;
        TextBox13.Text = resetValue;
        TextBox14.Text = resetValue;
        TextBox15.Text = resetValue;
        TextBox16.Text = resetValue;
        TextBox17.Text = resetValue;
        TextBox18.Text = resetValue;
        TextBox19.Text = resetValue;
        TextBox20.Text = resetValue;
        TextBox21.Text = resetValue;
        TextBox22.Text = resetValue;
        TextBox23.Text = resetValue;
        ListBox4.Items.Clear();
        ListBox5.Items.Clear();
        ListBox6.Items.Clear();

    }

    protected void Button41_Click(object sender, EventArgs e)
    {
        int expback =Int32.Parse(TextBox22.Text);
        if (expback > 0)
        {
            number = number + 1;
            expback = expback - 1;
            TextBox22.Text = expback.ToString();
            TextBox21.Text = number.ToString();
            Label1.Text = number.ToString();
        }
    }

    protected void DropDownList33_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList33.SelectedItem.Text.Equals("Blind/Deaf"))
        {
            DropDownList34.Visible = true;
        }
    }
}