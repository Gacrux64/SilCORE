Imports System.Data
Imports System.Data.SqlClient

Module PDUserSQLIO

    'Database  relatedfunctions
    Function NewDBConnection(ByRef connectionPerDiem) As Boolean
        Dim status As Boolean = False

        Try
            Dim connectionStringPerDiem As String = "Data Source=CORE-DB2;Initial Catalog=PERDIUMDB;User ID=SOPSA;Password=SO"
            connectionPerDiem = New SqlConnection(connectionStringPerDiem)
            status = True
        Catch ex As Exception
            NewErrorMail(ex.ToString(), "The PERDIUMDB Database is unreachable.", "NewDBConnection Function.")
        End Try

        Return status
    End Function

    Function NewInsertCommand(ByVal sqlConn As SqlConnection) As SqlCommand

        Dim insertComm As SqlCommand = New SqlCommand("INSERT INTO PERDIUMDB.dbo.PERDIUM_USERS (USER_ID, USER_LOGIN, USER_EMAIL, USER_NAME, USER_PERD_PASSWORD, USER_ID_CHECK, USER_SYSTEM) " +
                            "VALUES ((SELECT MAX(USER_ID)+1 FROM PERDIUM_USERS)," +
                            "@login," +
                            "@email," +
                            "@name," +
                            "@perdPassword," +
                            "CONVERT(varbinary(MAX), @salt)," +
                            "@userType)", sqlConn)
        Return insertComm
    End Function

    Function ExecuteInsertCommand(ByVal insertComm As SqlCommand) As Boolean

        Dim status As Boolean = False

        Try
            Dim adapterPerDiem As New SqlDataAdapter
            adapterPerDiem.InsertCommand = insertComm
            adapterPerDiem.InsertCommand.ExecuteNonQuery()
            status = True
        Catch ex As Exception
            NewErrorMail(ex.ToString(), "The insert command to enter a V1 user into the PERDIUMDB.dbo.PERDIUM_USERS table has failed.", "ExecuteInsertCommand Sub.")
        End Try

        Return status
    End Function

    'Entering the new user into the Per Diem system PERDIUM_USER table. If an error occurs along the way, a descriptive e-mail will be sent to the Scribe team and the entire application will exit.
    Function EnterUser(ByVal name As String, ByVal login As String, ByVal email As String, ByVal salt As Byte(), ByVal password As Byte(), ByVal userType As Integer) As Boolean

        Dim status As Boolean = False

        Dim connectionPerDiem As New SqlConnection
        'Create the connection, can throw an error.
        If NewDBConnection(connectionPerDiem) Then

            'Create the insert statement.
            Dim insertComm As New SqlCommand
            insertComm = NewInsertCommand(connectionPerDiem)

            'Setting the parameter values of the insert statement.
            insertComm.Parameters.Add("@login", SqlDbType.NVarChar, -1).Value = login
            insertComm.Parameters.Add("@email", SqlDbType.NVarChar, -1).Value = email
            insertComm.Parameters.Add("@name", SqlDbType.NVarChar, -1).Value = name
            insertComm.Parameters.Add("@perdPassword", SqlDbType.NVarChar, -1).Value = Convert.ToBase64String(password)
            insertComm.Parameters.Add("@salt", SqlDbType.NVarChar, -1).Value = Convert.ToBase64String(salt)
            insertComm.Parameters.Add("@userType", SqlDbType.Int, -1).Value = userType

            connectionPerDiem.Open()

            'Execute the insert command using the insert statement, can throw an error.
            If ExecuteInsertCommand(insertComm) Then

                status = True

            End If

            connectionPerDiem.Close()

        End If

        Return status
    End Function
End Module
