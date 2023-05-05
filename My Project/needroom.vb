Public Class needroom
    Private Sub needroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Login with " & login.TextBox1.Text
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.ControlBox = False
    End Sub
End Class