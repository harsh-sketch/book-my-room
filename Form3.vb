Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        'TODO: This line of code loads data into the 'PragatiDatabase2DataSet.roomTable1' table. You can move, or remove it, as needed.
        Me.RoomTable1TableAdapter.Fill(Me.PragatiDatabase2DataSet.roomTable1)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            ' Retrieve values from text boxes and convert to appropriate data types
            Dim numberOfRooms As Integer = Convert.ToInt32(NumberofroomsToolStripTextBox.Text)
            Dim city As String = TextBox1.Text
            Dim numberOfBeds As Integer = Convert.ToInt32(TextBox3.Text)
            Dim maxCharges As Decimal = Convert.ToDecimal(TextBox4.Text)

            ' Call FillBy method on RoomTable1TableAdapter with the retrieved values
            Me.RoomTable1TableAdapter.FillBy(Me.PragatiDatabase2DataSet.roomTable1, numberOfRooms, city, numberOfBeds, maxCharges)
        Catch ex As Exception
            ' Display error message if an exception occurs
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.RoomTable1TableAdapter.FillBy(Me.PragatiDatabase2DataSet.roomTable1, TextBox2.Text, TextBox1.Text, TextBox3.Text, TextBox4.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class