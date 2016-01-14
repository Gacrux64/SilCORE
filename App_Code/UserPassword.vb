﻿Imports System.Security.Cryptography

Module UserPassword

    Function GenerateSalt() As Byte()
        Dim salt(8) As Byte

        Dim rng As New RNGCryptoServiceProvider()
        rng.GetNonZeroBytes(salt)

        Return salt
    End Function

    Function EncodePassword(ByVal password As String, ByVal salt As Byte()) As Byte()

        Dim fixedSalt(8) As Byte

        fixedSalt = Convert.FromBase64String("+eroclis/")
        password = Convert.ToBase64String(salt) + password + Convert.ToBase64String(fixedSalt)

3:      Dim passwordBytes() As Byte = System.Text.Encoding.UTF8.GetBytes(password)
        Dim hash As SHA1 = SHA1CryptoServiceProvider.Create()

        For i As Integer = 0 To 999

            Dim multiHashPassword() As Byte = hash.ComputeHash(passwordBytes)
            passwordBytes = multiHashPassword

        Next

        Return passwordBytes
    End Function

End Module
