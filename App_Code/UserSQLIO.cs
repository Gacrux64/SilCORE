using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using NewUser;

/// <summary>
/// Summary description for UserSQLIO
/// </summary>
/// 
namespace NewUser
{
    public class UserSQLIO
    {
        //Database related functions
        public Boolean NewDBConnection(SqlConnection connectionBuilder)
        {

            NewUser.UserMail MailClass = new UserMail();
            Boolean status = false;

            try
            {
                
                String connectionStringBuilder = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Builder.mdf;Integrated Security=True";
                connectionBuilder = new SqlConnection(connectionStringBuilder);
                status = true;
            }
            catch (Exception ex)
            {
                MailClass.NewErrorMail(ex.ToString(), "The Database Is unreachable.", "NewDBConnection Function.");
            }

            return status;
        }

        public SqlCommand NewInsertCommand(SqlConnection sqlConn)
        {
            SqlCommand insertComm = new SqlCommand("INSERT INTO USER_INFO(USER_FIRST, USER_LAST, USER_EMAIL, USER_LOGIN, USER_PASSWORD, USER_SALT, USER_DATE) " +
                                "VALUES (" +
                                "@firstName," +
                                "@lastName," +
                                "@email," +
                                "@login," +
                                "@password," +
                                "CONVERT(varbinary(MAX), @salt)," +
                                "CONVERT(date, getdate()))", sqlConn);

            return insertComm;
        }

        public Boolean ExecuteInsertCommand(SqlCommand insertComm)
        {
            NewUser.UserMail MailClass = new UserMail();
            Boolean status = false;

            try
            {
                SqlDataAdapter adapterBuilder = new SqlDataAdapter();
                adapterBuilder.InsertCommand = insertComm;
                adapterBuilder.InsertCommand.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                MailClass.NewErrorMail(ex.ToString(), "The insert command to register a new user has failed.", "ExecuteInsertCommand Sub.");
            }

            return status;
        }


        //Entering the new user into the USER table. If an error occurs along the way, a descriptive e-mail will be sent to the Scribe team and the entire application will exit.
        public Boolean EnterUser(String firstName, String lastName, String login, String email, Byte[] salt, Byte[] password)
        {
            Boolean status = false;
            SqlConnection connectionBuilder = new SqlConnection();

            //Create the connection, can throw an error.

            if (NewDBConnection(connectionBuilder))
            {
                //Create the insert statement.
                SqlCommand insertComm = new SqlCommand();
                insertComm = NewInsertCommand(connectionBuilder);

                //Setting the parameter values of the insert statement.
                insertComm.Parameters.Add("@firstName", SqlDbType.NVarChar, -1).Value = firstName;
                insertComm.Parameters.Add("@lastName", SqlDbType.NVarChar, -1).Value = lastName;
                insertComm.Parameters.Add("@email", SqlDbType.NVarChar, -1).Value = email;
                insertComm.Parameters.Add("@login", SqlDbType.NVarChar, -1).Value = login;
                insertComm.Parameters.Add("@password", SqlDbType.NVarChar, -1).Value = Convert.ToBase64String(password);
                insertComm.Parameters.Add("@salt", SqlDbType.NVarChar, -1).Value = Convert.ToBase64String(salt);

                //Execute the insert command using the insert statement, can throw an error.
                connectionBuilder.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Builder.mdf;Integrated Security=True";
                connectionBuilder.Open();

                if (ExecuteInsertCommand(insertComm))
                {
                    status = true;
                }

                connectionBuilder.Close();
            }

            return status;
        }
    }
}
