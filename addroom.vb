Imports System.Data.OleDb

Public Class addroom
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo saveerr
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lenovo\Downloads\Pragati\bin\Debug\database\pragatiDatabase2.accdb" ' Replace with the actual path to your Access database file
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim insertQuery As String = "INSERT INTO roomTable1 (hotels, numberofrooms, city, phone, numberofbeds, charges) VALUES (?, ?, ?, ?, ?, ?)" ' Replace with your actual table name and column names

            Using command As New OleDbCommand(insertQuery, connection)
                ' Replace "?" with the actual parameter placeholders and set the parameter values
                command.Parameters.AddWithValue("?", TextBox2.Text)
                command.Parameters.AddWithValue("?", ComboBox1.Text)
                command.Parameters.AddWithValue("?", ComboBox3.Text)
                command.Parameters.AddWithValue("?", TextBox1.Text)
                command.Parameters.AddWithValue("?", ComboBox2.Text)
                command.Parameters.AddWithValue("?", TextBox3.Text)

                command.ExecuteNonQuery()
            End Using

            connection.Close()
        End Using

saveerr:

    End Sub

    Private Sub addroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
    End Sub

End Class