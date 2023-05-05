Public Class mainmenu
    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Login with " & login.TextBox1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addroom.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        removeroom.Show()
        Me.Close()
    End Sub
End Class