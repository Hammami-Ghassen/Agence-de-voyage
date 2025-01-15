Imports System.IO

Public Class login



    Private Function ValidateCredentials(username As String, password As String) As Boolean
        ' Path to the credentials file
        Dim filePath As String = "credentials.txt"

        ' Check if the file exists
        If Not File.Exists(filePath) Then
            MessageBox.Show("Credentials file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Read all lines from the file
        Dim lines() As String = File.ReadAllLines(filePath)

        ' Check each line for a matching username and password
        For Each line As String In lines
            Dim parts() As String = line.Split(":"c) ' Split by colon
            If parts.Length = 2 AndAlso parts(0) = username AndAlso parts(1) = password Then
                Return True
            End If
        Next

        Return False ' No match found
    End Function

    Private Sub btn_connecter_Click(sender As Object, e As EventArgs) Handles btn_connecter.Click
        ' Get user input
        Dim username As String = username_txt.Text
        Dim password As String = pwd_txt.Text

        ' Validate credentials
        If ValidateCredentials(username, password) And username.Equals("admin") Then
            If username.Equals("admin") Then

            Else

            End If

        Else
            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class