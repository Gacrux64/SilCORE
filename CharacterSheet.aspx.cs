using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class CharacterSheet : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["user"].ToString() == null)
        {
            Response.Redirect("Default.aspx");
        }
        else if(Session["character"].ToString() == null)
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
                while(sqlReader.HasRows)
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

                    //Code to handle skills

                    //Code to handle perks

                    //Code to handle flaws

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