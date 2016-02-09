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
                    AccountCharacters.Text = sqlReader["USER_ADMIN"].ToString();


                    if (sqlReader["USER_ADMIN"].ToString().Equals("True"))
                    {

                        AdminPanel.Visible = true;

                        if (sqlReader["USER_NEWS"].ToString().Equals("True"))
                        {
                            NewsPostButton.Visible = true;
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
        catch(Exception ex)
        {
            PostMessage.Text = "Error: " + ex.ToString();
        }
    }

    private void clearAll()
    {

    }
}