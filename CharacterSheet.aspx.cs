using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using SPF;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

public partial class CharacterSheet : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["user"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        else if(Session["character"] == null)
        {
            Response.Redirect("UserPage");
        }
        else
        {
            SqlConnection charConn = GetDBConnection();
            SqlCommand charComm = new SqlCommand("SELECT * FROM CHARACTER WHERE CHARACTER_ID = @CID" ,charConn);
            SqlParameter charPar = new SqlParameter("CID", Session["character"].ToString());
            charComm.Parameters.Add(charPar);

            charConn.Open();
            using (SqlDataReader sqlReader = charComm.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    LabelName.Text = "Name: " + sqlReader["CHARACTER_NAME"].ToString();

                    LabelAGI.Text = "AGI: " + sqlReader["CHARACTER_AGI"].ToString();
                    LabelAPP.Text = "APP: " + sqlReader["CHARACTER_APP"].ToString();
                    LabelBLD.Text = "BLD: " + sqlReader["CHARACTER_BLD"].ToString();
                    LabelCRE.Text = "CRE: " + sqlReader["CHARACTER_CRE"].ToString();
                    LabelFIT.Text = "FIT: " + sqlReader["CHARACTER_FIT"].ToString();

                    LabelINF.Text = "INF: " + sqlReader["CHARACTER_INF"].ToString();
                    LabelKNO.Text = "KNO: " + sqlReader["CHARACTER_KNO"].ToString();
                    LabelPER.Text = "PER: " + sqlReader["CHARACTER_PER"].ToString();
                    LabelPSY.Text = "PSY: " + sqlReader["CHARACTER_PSY"].ToString();
                    LabelWIL.Text = "WIL: " + sqlReader["CHARACTER_WIL"].ToString();

                    LabelSTR.Text = "STR: " + sqlReader["CHARACTER_SEC_STR"].ToString();
                    LabelHEA.Text = "HEA: " + sqlReader["CHARACTER_SEC_HEA"].ToString();
                    LabelSTA.Text = "STA: " + sqlReader["CHARACTER_SEC_STA"].ToString();
                    LabelUD.Text = "UD: " + sqlReader["CHARACTER_SEC_UD"].ToString();
                    LabelAD.Text = "AD: " + sqlReader["CHARACTER_SEC_AD"].ToString();

                    LabelFW.Text = "FW: " + sqlReader["CHARACTER_SEC_FLESH_WOUND"].ToString();
                    LabelDW.Text = "DW: " + sqlReader["CHARACTER_SEC_DEEP_WOUND"].ToString();
                    LabelID.Text = "ID: " + sqlReader["CHARACTER_SEC_INSTANT_DEATH"].ToString();
                    LabelSS.Text = "SS: " + sqlReader["CHARACTER_SEC_SYSTEM_SHOCK"].ToString();

                    XmlSerializer serialize = new XmlSerializer(typeof(List<Skill>));

                    //Code to handle skills
                    List<Skill> skills = new List<Skill>();
                    skills = (List<Skill>)serialize.Deserialize(new StringReader(sqlReader["CHARACTER_SKILLS"].ToString()));
                    foreach (Skill skill in skills)
                    {
                        LabelSkills.Text += skill.getSkillInfo() + "<br />";
                    }

                    //Code to handle perks
                    List<Perk> perks = new List<Perk>();
                    perks = (List<Perk>)serialize.Deserialize(new StringReader(sqlReader["CHARACTER_PERKS"].ToString()));
                    foreach (Perk perk in perks)
                    {
                        LabelPerks.Text += perk.getPerkInfo() + "<br />";
                    }

                    //Code to handle flaws
                    List<Flaw> flaws = new List<Flaw>();
                    flaws = (List<Flaw>)serialize.Deserialize(new StringReader(sqlReader["CHARACTER_FLAWS"].ToString()));
                    foreach (Flaw flaw in flaws)
                    {
                        LabelFlaws.Text += flaw.getFlawInfo() + "<br />";
                    }

                    LabelED.Text = "Emergency Dice: " + sqlReader["CHARACTER_EMERGENCY_DICE"].ToString();
                    LabelXP.Text = "XPs: " + sqlReader["CHARACTER_XP"].ToString();
                }
            }
        }
    }

    //SQL functions
    private SqlConnection GetDBConnection()
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Builder.mdf;Integrated Security=True";

        SqlConnection loginConnection = new SqlConnection(conStr);

        return loginConnection;
    }
}