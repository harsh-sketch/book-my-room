Public Class searchwindow
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PragatiDatabase2DataSet.roomTable1' table. You can move, or remove it, as needed.
        Me.RoomTable1TableAdapter.Fill(Me.PragatiDatabase2DataSet.roomTable1)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class