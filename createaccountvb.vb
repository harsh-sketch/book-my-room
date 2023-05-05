Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class createaccountvb


    Function IsValidPassword(password As String) As Boolean
        Dim pattern As String = "^(?=.[A-Za-z])(?=.\d)(?=.[@$!%#?&])[A-Za-z\d@$!%*#?&]{8,}$"
        Dim regex As New Regex(pattern)
        MsgBox(regex.IsMatch(password))
        Return regex.IsMatch(password)
    End Function


    Dim count As Integer = 0
    Private Sub createButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password As String
        password = TextBox5.Text

        MsgBox("password has valid parameters")
        If (TextBox4.Text = TextBox5.Text) Then
            Dim adminuserid As String
            Dim adminpass As String
            Dim newuserid As String
            Dim newpass As String
            adminpass = TextBox2.Text
            adminuserid = TextBox1.Text
            newpass = TextBox5.Text
            newuserid = TextBox3.Text
            If Not (adminuserid.Equals("") Or adminpass.Equals("") Or TextBox4.Equals("")) Then
                If (adminuserid.Equals("harsh") And adminpass.Equals("pass")) Then
                    If Not (newuserid = "" Or newpass = "") Then
                        ' Create a connection to database
                        Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\lenovo\Downloads\pragati\database\usercredentialsDatabase2.accdb'"
                        Dim connection As New OleDbConnection(connectionstring)
                        'open connection
                        connection.Open()

                        'create an insert command
                        Dim commandText As String = "INSERT INTO usersTable1 VALUES (@param1, @param2);"

                        'Add parametres to command
                        Dim cmd As New OleDbCommand(commandText, connection)
                        cmd.Parameters.AddWithValue("@param1", newuserid)
                        cmd.Parameters.AddWithValue("@param2", newpass)
                        'Execute the command to insert the new account details
                        Try
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            connection.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            connection.Close()
                        End Try
                        'Now Close the connection
                        connection.Close()

                        MsgBox("New account has been Created!!!")

                    End If
saveerror:
                    Exit Sub
                Else
                    count = count + 1
                    If count = 3 Then
                        MsgBox("You enterd wrong Pssword of admin 3 times we blocked you")
                        Timer1.Enabled = True
                    Else
                        MsgBox("Barobar daal na bhai,  Now you have only ", count, "Moves left")
                    End If
                End If
            Else
                MsgBox("Fill all Credentials")

            End If

        Else
            MsgBox("Confirm password shold same in both field")

        End If


    End Sub

    Private Sub createaccountvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static count As Integer = 0
        count += 1
        If count >= 10 Then
            Button1.Hide()
        End If
        Button1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox4.UseSystemPasswordChar = True
            TextBox5.UseSystemPasswordChar = False
        Else
            TextBox4.UseSystemPasswordChar = False
            TextBox5.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
        Me.Close()
    End Sub
End Class