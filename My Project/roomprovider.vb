Public Class roomprovider
    Private Sub roomprovider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Login with " & login.TextBox1.Text
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.ControlBox = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class