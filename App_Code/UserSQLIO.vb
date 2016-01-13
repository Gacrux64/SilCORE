Imports System.Data
Imports System.Data.SqlClient

Module PDUserSQLIO

    'Database  relatedfunctions
    Function NewDBConnection(ByRef connectionBuilder As SqlConnection) As Boolean
        Dim status As Boolean = False

        Try
            Dim connectionStringBuilder As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Builder.mdf;Integrated Security=True"
            connectionBuilder = New SqlConnection(connectionStringBuilder)
            status = True
        Catch ex As Exception
            NewErrorMail(ex.ToString(), "The Database Is unreachable.", "NewDBConnection Function.")
        End Try

        Return status
    End Function

    Function NewInsertCommand(ByVal sqlConn As SqlConnection) As SqlCommand

        Dim insertComm As SqlCommand = New SqlCommand("INSERT INTO  Builder.dbo.USER (USER_FIRST, USER_LAST, USER_EMAIL, USER_LOGIN, USER_PASSWORD, USER_SALT, USER_ADMIN) " +
                            "VALUES (" +
                            "@firstName," +
                            "@lastName," +
                            "@email," +
                            "@login," +
                            "@password," +
                            "CONVERT(varbinary(MAX), @salt)," +
                            "@userType)", sqlConn)
        Return insertComm
    End Function

    Function ExecuteInsertCommand(ByVal insertComm As SqlCommand) As Boolean

        Dim status As Boolean = False

        Try
            Dim adapterBuilder As New SqlDataAdapter
            adapterBuilder.InsertCommand = insertComm
            adapterBuilder.InsertCommand.ExecuteNonQuery()
            status = True
        Catch ex As Exception
            NewErrorMail(ex.ToString(), "The insert command to register a new user has failed.", "ExecuteInsertCommand Sub.")
        End Try

        Return status
    End Function

    'Entering the new user into the USER table. If an error occurs along the way, a descriptive e-mail will be sent to the Scribe team and the entire application will exit.
    Function EnterUser(ByVal firstName As String, ByVal lastName As String, ByVal login As String, ByVal email As String, ByVal salt As Byte(), ByVal password As Byte(), ByVal userType As Integer) As Boolean

        Dim status As Boolean = False

        Dim connectionBuilder As New SqlConnection
        'Create the connection, can throw an error.
        If NewDBConnection(connectionBuilder) Then

            'Create the insert statement.
            Dim insertComm As New SqlCommand
            insertComm = NewInsertCommand(connectionBuilder)

            'Setting the parameter values of the insert statement.
            insertComm.Parameters.Add("@firstName", SqlDbType.NVarChar, -1).Value = firstName
            insertComm.Parameters.Add("@lastName", SqlDbType.NVarChar, -1).Value = lastName
            insertComm.Parameters.Add("@email", SqlDbType.NVarChar, -1).Value = email
            insertComm.Parameters.Add("@login", SqlDbType.NVarChar, -1).Value = login
            insertComm.Parameters.Add("@password", SqlDbType.NVarChar, -1).Value = Convert.ToBase64String(password)
            insertComm.Parameters.Add("@salt", SqlDbType.NVarChar, -1).Value = Convert.ToBase64String(salt)
            insertComm.Parameters.Add("@userType", SqlDbType.Int, -1).Value = userType

            connectionBuilder.Open()

            'Execute the insert command using the insert statement, can throw an error.
            If ExecuteInsertCommand(insertComm) Then

                status = True

            End If

            connectionBuilder.Close()

        End If

        Return status
    End Function
End Module
