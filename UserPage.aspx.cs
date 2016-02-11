using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class UserPage : System.Web.UI.Page
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
            SqlCommand getUserAdmin = new SqlCommand("SELECT USER_ADMIN, USER_NEWS FROM USER_INFO WHERE USER_ID LIKE @UID", userAdminConn);
            SqlParameter userAdminPar = new SqlParameter("UID", Session["user"].ToString());
            getUserAdmin.Parameters.Add(userAdminPar);

            userAdminConn.Open();
            using (SqlDataReader sqlReader = getUserAdmin.ExecuteReader())
            {

                while (sqlReader.Read())
                {
                    if (sqlReader["USER_ADMIN"].ToString().Equals("True"))
                    {

                        AdminPanel.Visible = true;

                        if (sqlReader["USER_NEWS"].ToString().Equals("True"))
                        {
                            NewsPostButton.Visible = true;
                            CheckboxNewsPosts.Enabled = true;
                        }
                        else
                        {
                            NewsPostButton.Visible = false;
                        }

                    }
                    else
                    {
                        AdminPanel.Visible = false;
                    }
                }
            }
            userAdminConn.Close();
        }
    }

    protected void MakeAdminButton_Click(object sender, EventArgs e)
    {
        if(SetAdminDiv.Visible)
        {
            SetAdminDiv.Visible = false;
            SetAdminBr.Visible = false;
            clearAll();
            DDLUsers.SelectedIndex = 0;
        }
        else
        {
            SetAdminDiv.Visible = true;
            SetAdminBr.Visible = true;
        }
        
    }

    protected void NewsPostButton_Click(object sender, EventArgs e)
    {
        if(MakeNewsPostDiv.Visible)
        {
            MakeNewsPostDiv.Visible = false;
            clearAll();
            DDLUsers.SelectedIndex = 0;
        }
        else
        {
            MakeNewsPostDiv.Visible = true;
        }
    }

    protected void PostYes_Click(object sender, EventArgs e)
    {
        if(!PostConfirm.Enabled)
        {
            PostConfirm.Enabled = true;
        }
    }


    //SQL functions
    private SqlConnection GetDBConnection()
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Builder.mdf;Integrated Security=True";

        SqlConnection loginConnection = new SqlConnection(conStr);

        return loginConnection;
    }

    protected void PostConfirm_Click(object sender, EventArgs e)
    {

        if (PostTitleText.Text.Equals(""))
        {
            PostMessage.Text = "Please enter a title for the post.";
        }
        else if(PostText.Text.Equals(""))
        {
            PostMessage.Text = "Please enter the content of the post.";
        }
        else if(PostTitle.Text.Equals("") && PostText.Text.Equals(""))
        {
            PostMessage.Text = "Please enter a title and content for the post.";
        }
        else
        {
            string newsPost = "<h3>" + PostTitleText.Text + "</h3>" +
                          "<p>" + PostText.Text + "</p>" +
                          "<hr />";

            SqlConnection newsConn = GetDBConnection();
            SqlCommand newsComm = new SqlCommand("INSERT INTO UPDATE_POST(UPDATE_POST_DATE, UPDATE_POST_NEWS) VALUES(GETDATE(), @post)", newsConn);
            SqlParameter newsPar = new SqlParameter("post", newsPost);
            newsComm.Parameters.Add(newsPar);

            try
            {
                newsConn.Open();
                newsComm.ExecuteNonQuery();
                newsConn.Close();
                PostMessage.Text = "Successfully posted.";
            }
            catch (Exception ex)
            {
                PostMessage.Text = "Error: " + ex.ToString();
            }
        }

        PostConfirm.Enabled = false;
    }

    private void clearAll()
    {
        PostMessage.Text = String.Empty;
        UserAdminLevelMessage.Text = String.Empty;
        UserAdminLevelConfirm.Enabled = false;
        PostConfirm.Enabled = false;
        CheckboxNewsPosts.Checked = false;
        ChecboxUserAdmin.Checked = false;
    }

    protected void NewCharButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("CharacterCreator.aspx");
    }

    protected void DDLUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(DDLUsers.SelectedIndex != 0)
        {
            ChecboxUserAdmin.Checked = false;
            CheckboxNewsPosts.Checked = false;

            SqlConnection adminConn = GetDBConnection();
            SqlCommand adminComm = new SqlCommand("SELECT USER_ADMIN, USER_NEWS FROM USER_INFO WHERE USER_ID = @UID", adminConn);
            SqlParameter uID = new SqlParameter("UID", DDLUsers.SelectedValue.ToString());
            adminComm.Parameters.Add(uID);

            adminConn.Open();
            using (SqlDataReader sqlReader = adminComm.ExecuteReader())
            {
                clearAll();
                while (sqlReader.Read())
                {
                    if (sqlReader["USER_ADMIN"].ToString().Equals("True"))
                    {
                        ChecboxUserAdmin.Checked = true;
                    }

                    if (sqlReader["USER_NEWS"].ToString().Equals("True"))
                    {
                        CheckboxNewsPosts.Checked = true;
                    }
                }
            }
            adminConn.Close();
        }
    }

    protected void UserAdminLevelConfirm_Click(object sender, EventArgs e)
    {
        
        SqlConnection updateConn = GetDBConnection();
        SqlCommand updateAdminComm = new SqlCommand("UPDATE USER_INFO SET USER_ADMIN = @admin, USER_NEWS = @news WHERE USER_ID = @UID", updateConn);
        SqlParameter uID = new SqlParameter("UID", DDLUsers.SelectedValue.ToString());
        updateAdminComm.Parameters.Add(uID);

        SqlParameter adminPar = new SqlParameter();
        adminPar.ParameterName = "admin";
        if (ChecboxUserAdmin.Checked)
        {
            adminPar.Value = "1";
        }
        else
        {
            adminPar.Value = "0";
        }

        SqlParameter newsPar = new SqlParameter();
        newsPar.ParameterName = "news";
        if(CheckboxNewsPosts.Checked)
        {
            newsPar.Value = "1";
        }
        else
        {
            newsPar.Value = "0";
        }
        updateAdminComm.Parameters.Add(adminPar);
        updateAdminComm.Parameters.Add(newsPar);

        updateConn.Open();
        updateAdminComm.ExecuteNonQuery();
        updateConn.Close();

        UserAdminLevelMessage.Text = "User's administrative levels updated.";
    }

    protected void UserAdminLevelSure_Click(object sender, EventArgs e)
    {
        UserAdminLevelConfirm.Enabled = true;
    }

    protected void DDLCharacterList_SelectedIndexChanged(object sender, EventArgs e)
    {
        LableDelConfirmMes.Text = "Are you sure?";
        ButtonDelete.Visible = true;
        DelConfirmDiv.Visible = false;
        ButtonDeleteConfirm.Enabled = false;

        if (DDLCharacterList.SelectedIndex != 0)
        {
            ButtonDelete.Visible = true;
            SqlConnection charConn = GetDBConnection();
            SqlCommand charComm = new SqlCommand("SELECT CHARACTER_NAME, CHARACTER_AGI, CHARACTER_APP, CHARACTER_BLD, CHARACTER_CRE, CHARACTER_FIT, CHARACTER_INF, CHARACTER_KNO, CHARACTER_PER, CHARACTER_PSY, CHARACTER_WIL, CHARACTER_EMERGENCY_DICE, CHARACTER_XP FROM CHARACTER WHERE CHARACTER_ID = @char", charConn);
            SqlParameter charPar = new SqlParameter("char", DDLCharacterList.SelectedValue.ToString());
            charComm.Parameters.Add(charPar);

            charConn.Open();

            using (SqlDataReader sqlReader = charComm.ExecuteReader())
            {
                while(sqlReader.Read())
                {
                    CharName.Text = "Name: " + sqlReader["CHARACTER_NAME"].ToString();

                    StatAgi.Text = "AGI: " + sqlReader["CHARACTER_AGI"].ToString();
                    StatApp.Text = "APP: " + sqlReader["CHARACTER_APP"].ToString();
                    StatBld.Text = "BLD: " + sqlReader["CHARACTER_BLD"].ToString();
                    StatCre.Text = "CRE: " + sqlReader["CHARACTER_CRE"].ToString();
                    StatFit.Text = "FIT: " + sqlReader["CHARACTER_FIT"].ToString();
                    StatInf.Text = "INF: " + sqlReader["CHARACTER_INF"].ToString();
                    StatKno.Text = "KNO: " + sqlReader["CHARACTER_KNO"].ToString();
                    StatPer.Text = "PER: " + sqlReader["CHARACTER_PER"].ToString();
                    StatPsy.Text = "PSY: " + sqlReader["CHARACTER_PSY"].ToString();
                    StatWil.Text = "WIL: " + sqlReader["CHARACTER_WIL"].ToString();

                    EmergencyDice.Text = "Emergency Dice: " + sqlReader["CHARACTER_EMERGENCY_DICE"].ToString();
                    Experience.Text = "XPs: " + sqlReader["CHARACTER_XP"].ToString();
                }
            }
            charConn.Close();
        }
        else
        {
            CharName.Text = "Name: ";

            StatAgi.Text = "AGI: ";
            StatApp.Text = "APP: ";
            StatBld.Text = "BLD: ";
            StatCre.Text = "CRE: ";
            StatFit.Text = "FIT: ";
            StatInf.Text = "INF: ";
            StatKno.Text = "KNO: ";
            StatPer.Text = "PER: ";
            StatPsy.Text = "PSY: ";
            StatWil.Text = "WIL: ";

            EmergencyDice.Text = "Emergency Dice: ";
            Experience.Text = "XPs: ";
        }
    }

    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        ButtonDelete.Visible = false;
        DelConfirmDiv.Visible = true;
        ButtonDeleteConfirm.Enabled = true;
    }

    protected void ButtonDeleteCancel_Click(object sender, EventArgs e)
    {
        LableDelConfirmMes.Text = "Are you sure?";
        ButtonDelete.Visible = true;
        DelConfirmDiv.Visible = false;
        ButtonDeleteConfirm.Enabled = false;
    }

    protected void ButtonDeleteConfirm_Click(object sender, EventArgs e)
    {
        if(DDLCharacterList.SelectedIndex != 0)
        {
            SqlConnection delConn = GetDBConnection();
            SqlCommand delComm = new SqlCommand("DELETE FROM CHARACTER WHERE CHARACTER_ID = @CID", delConn);
            SqlParameter delPar = new SqlParameter("CID", DDLCharacterList.SelectedValue.ToString());
            delComm.Parameters.Add(delPar);

            delConn.Open();
            delComm.ExecuteNonQuery();
            delConn.Close();

            LableDelConfirmMes.Text = "Character Deleted.";

            CharName.Text = "Name: ";

            StatAgi.Text = "AGI: ";
            StatApp.Text = "APP: ";
            StatBld.Text = "BLD: ";
            StatCre.Text = "CRE: ";
            StatFit.Text = "FIT: ";
            StatInf.Text = "INF: ";
            StatKno.Text = "KNO: ";
            StatPer.Text = "PER: ";
            StatPsy.Text = "PSY: ";
            StatWil.Text = "WIL: ";

            EmergencyDice.Text = "Emergency Dice: ";
            Experience.Text = "XPs: ";
        }
        
    }
}