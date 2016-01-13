Module CreatePDUser

    'Main function
    Function CreateUser(ByVal login As String, ByVal name As String, ByVal email As String, ByVal userType As Integer) As Boolean
        Dim status As Boolean = False

        Dim password As String = GeneratePassword()
        Dim salt() As Byte = GenerateSalt()
        Dim encryptedPassword() As Byte = EncodePassword(password, salt)

        Dim mailBody As String = NewPasswordEmail(name, login, password)

        If (EnterUser(name, login, email, salt, encryptedPassword, userType)) Then
            If SendEmail("MIS@FrescheLegacy.com", email, "New Per Diem System User", mailBody) Then
                status = True
            Else
                NewErrorMail("Undefined", "The resource has been successfully entered, but their initial login e-mail failed to be sent. Please use the Per Diem Tools application to generate and send them a new one.", "SendEMail Function")
            End If
        Else
            NewErrorMail("Undefined", "The Module to load a V1 resource into the Per Diem system has failed in some way.", "EnterUser Function")
        End If

        Return status
    End Function

End Module
