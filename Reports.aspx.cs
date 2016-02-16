using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Template_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            SqlConnection userAdminConn = GetDBConnection();
            SqlCommand getUserAdmin = new SqlCommand("SELECT USER_ADMIN FROM USER_INFO WHERE USER_ID LIKE @UID", userAdminConn);
            SqlParameter userAdminPar = new SqlParameter("UID", Session["user"].ToString());
            getUserAdmin.Parameters.Add(userAdminPar);

            userAdminConn.Open();
            using (SqlDataReader sqlReader = getUserAdmin.ExecuteReader())
            {

                while (sqlReader.Read())
                {
                    if (sqlReader["USER_ADMIN"].ToString().Equals("False"))
                    {
                        Response.Redirect("UserPage.aspx");
                    }
                }
            }
            userAdminConn.Close();
        }


        SqlConnection avgConn = GetDBConnection();
        SqlCommand avgComm = new SqlCommand("SELECT AVG(CHARACTER_AGI) AS CHARACTER_AGI, AVG(CHARACTER_APP) AS CHARACTER_APP, AVG(CHARACTER_BLD) AS CHARACTER_BLD, AVG(CHARACTER_CRE) AS CHARACTER_CRE, AVG(CHARACTER_FIT) AS CHARACTER_FIT, AVG(CHARACTER_INF) AS CHARACTER_INF, AVG(CHARACTER_KNO) AS CHARACTER_KNO, AVG(CHARACTER_PER) AS CHARACTER_PER, AVG(CHARACTER_PSY) AS CHARACTER_PSY, AVG(CHARACTER_WIL) AS CHARACTER_WIL, AVG(CHARACTER_SEC_STR) AS CHARACTER_SEC_STR, AVG(CHARACTER_SEC_HEA) AS CHARACTER_SEC_HEA, AVG(CHARACTER_SEC_STA) AS CHARACTER_SEC_STA, AVG(CHARACTER_SEC_UD) AS CHARACTER_SEC_UD, AVG(CHARACTER_SEC_AD) AS CHARACTER_SEC_AD, AVG(CHARACTER_SEC_FLESH_WOUND) AS CHARACTER_SEC_FLESH_WOUND, AVG(CHARACTER_SEC_DEEP_WOUND) AS CHARACTER_SEC_DEEP_WOUND, AVG(CHARACTER_SEC_INSTANT_DEATH) AS CHARACTER_SEC_INSTANT_DEATH, AVG(CHARACTER_SEC_SYSTEM_SHOCK) AS CHARACTER_SEC_SYSTEM_SHOCK FROM CHARACTER", avgConn);

        avgConn.Open();
        using (SqlDataReader sqlReader = avgComm.ExecuteReader())
        {
            while (sqlReader.Read())
            {
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
            }
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = Calendar1.SelectedDate.Date.ToString("MM/dd/yyyy");
        LabelDateCheck.Text = String.Empty;
    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        Label2.Text = Calendar2.SelectedDate.Date.ToString("MM/dd/yyyy");
        LabelDateCheck.Text = String.Empty;
    }

    protected void Calendar1_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e)
    {
        // Select all dates in the past
        if (e.Day.Date > System.DateTime.Today)
        {
            // Disable date
            e.Day.IsSelectable = false;
            // Change color of disabled date
            e.Cell.ForeColor = System.Drawing.Color.Gray;
        }
    }

    protected void Calendar2_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e)
    {
        // Select all dates in the past
        if (e.Day.Date > System.DateTime.Today)
        {
            // Disable date
            e.Day.IsSelectable = false;
            // Change color of disabled date
            e.Cell.ForeColor = System.Drawing.Color.Gray;
        }
    }

    protected void ButtonDateCheck_Click(object sender, EventArgs e)
    {

        if (Calendar1.SelectedDate != DateTime.MinValue && Calendar2.SelectedDate != DateTime.MinValue)
        {
            SqlConnection dateConn = GetDBConnection();
            SqlCommand dateComm = new SqlCommand("SELECT COUNT(USER_DATE) AS USER_COUNT FROM USER_INFO WHERE USER_DATE <= CONVERT(DATE, @MaxDate) AND USER_DATE >= CONVERT(DATE, @MinDate)", dateConn);
            //string sqlDateMin = Calendar1.SelectedDate.Year.ToString() + "-" + Calendar1.SelectedDate.Month.ToString() + "-" + Calendar1.SelectedDate.Day.ToString();
            //string sqlDateMax = Calendar2.SelectedDate.Year.ToString() + "-" + Calendar2.SelectedDate.Month.ToString() + "-" + Calendar2.SelectedDate.Day.ToString();
            SqlParameter maxDatPar = new SqlParameter("MaxDate", Calendar2.SelectedDate);
            SqlParameter minDatPar = new SqlParameter("MinDate", Calendar1.SelectedDate);

            dateComm.Parameters.Add(maxDatPar);
            dateComm.Parameters.Add(minDatPar);

            dateConn.Open();
            using (SqlDataReader sqlReader = dateComm.ExecuteReader())
            {
                if (sqlReader.Read())
                {
                    LabelDateCheck.Text = "Number of users that registered in selected period: " + sqlReader["USER_COUNT"].ToString() + "<br />";
                }
            }
            dateConn.Close();
        }
    }

    //SQL functions
    private SqlConnection GetDBConnection()
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Builder.mdf;Integrated Security=True";

        SqlConnection loginConnection = new SqlConnection(conStr);

        return loginConnection;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewUserChars.DataBind();
    }

    protected void GridViewUserChars_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Detail")
        {
            Session["character"] = GridViewUserChars.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text.ToString().Trim();
            Response.Redirect("CharacterSheet.aspx");
        }
    }

}