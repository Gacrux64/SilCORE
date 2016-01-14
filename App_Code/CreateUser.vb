Module CreateUser

    'Main function
    Function CreateUser(ByVal firstName As String, ByVal lastName As String, ByVal login As String, ByVal email As String, ByVal password As String) As Boolean
        Dim status As Boolean = False

        Dim salt() As Byte = GenerateSalt()
        Dim encryptedPassword() As Byte = EncodePassword(password, salt)

        Dim mailBody As String = NewPasswordEmail(firstName, login, password)

        If (EnterUser(firstName, lastName, login, email, salt, encryptedPassword)) Then
            If SendEmail("CharacterCreator@DP9.com", email, "New SilCORE Character Creator System User", mailBody) Then
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
