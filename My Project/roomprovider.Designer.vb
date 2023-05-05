<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomprovider
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"aaaaa", "bbbb", "ccc", "ddd"})
        Me.ComboBox1.Location = New System.Drawing.Point(153, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(127, 21)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ListBox1.Location = New System.Drawing.Point(388, 83)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(90, 17)
        Me.ListBox1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(521, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(700, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"hello1", "hello2" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.CheckedListBox1.Location = New System.Drawing.Point(89, 125)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(174, 154)
        Me.CheckedListBox1.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(511, 122)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(370, 249)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(252, 150)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Login with xxx"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(711, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 20)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Log Out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(610, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 20)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Main Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'roomprovider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "roomprovider"
        Me.Text = "roomprovider"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
