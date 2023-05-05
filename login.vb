Imports System.Data.OleDb

Public Class login



    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
    Dim count As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim userid As String = ""
        Dim pass As String = ""
        Dim checkpass As String = ""
        pass = TextBox2.Text
        userid = TextBox1.Text



        ' Create a connection to database
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lenovo\Downloads\Pragati\database\usercredentialsDatabase2.accdb;")
        Dim command As New OleDbCommand("Select * FROM usersTable1 WHERE Username = '" & userid & "'", connection)
        connection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()

        If reader.Read() Then
            checkpass = reader.GetString(1)
            reader.Close()
        End If

        reader.Close()
        connection.Close()

        'Now Close the connection
        connection.Close()




        If Not (userid.Equals("") Or pass.Equals("")) Then
            If pass.Equals(checkpass) Then
                MainMenu.Show()
                Me.Hide()
                Form1.Hide()
            Else
                count = count + 1
                If count = 3 Then
                    MsgBox("You enterd wrong Password 3 times Now wait for 30 seconds")
                    Label5.Text = "Now wait 30 second"
                    Timer1.Enabled = True
                Else
                    MsgBox("Barobar daal na bhai,  Now you have only " & 3 - count & "Moves left")
                End If
            End If
        Else
            MsgBox("Fill all Credentials")

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static count As Integer = 0
        count += 1
        If count >= 10 Then
            Button1.Hide()
        End If
        Button1.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        createaccountvb.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class