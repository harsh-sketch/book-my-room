Imports System.Data.OleDb

Public Class removeroom
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error GoTo saveerr
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\YourDatabase.accdb;"
        Dim connection As New OleDbConnection(connectionString)
        connection.Open()

        Dim sql As String = "DELETE FROM roomTable1 WHERE (hotels = @hotelname and city= @city and charges = @charges and phone = @phone)"
        Dim command As New OleDbCommand(sql, connection)
        command.Parameters.AddWithValue("@hotelname", TextBox2.Text)
        command.Parameters.AddWithValue("@city", ComboBox3.Text)
        command.Parameters.AddWithValue("@phone", TextBox1.Text)
        command.Parameters.AddWithValue("@charges", TextBox3.Text)
        command.ExecuteNonQuery()
        MsgBox("Item, Deleted")

        connection.Close()
saveerr:

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

        Form1.Show()
    End Sub

    Private Sub removeroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub
End Class