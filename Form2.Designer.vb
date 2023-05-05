<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchwindow
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotelsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberofroomsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberofbedsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PragatiDatabase2DataSet = New Pragati.pragatiDatabase2DataSet()
        Me.RoomTable1TableAdapter = New Pragati.pragatiDatabase2DataSetTableAdapters.roomTable1TableAdapter()
        Me.TableAdapterManager = New Pragati.pragatiDatabase2DataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PragatiDatabase2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.RosyBrown
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(161, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 28)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RosyBrown
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(161, 118)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 28)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.RosyBrown
        Me.TextBox3.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(162, 174)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 28)
        Me.TextBox3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "city"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RosyBrown
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(2, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of room"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RosyBrown
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(2, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number of bed "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.RosyBrown
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(304, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 35)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Book My Room"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lavender
        Me.Button1.BackgroundImage = Global.Pragati.My.Resources.Resources.images__3_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(329, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.RosyBrown
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(12, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Charges"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.RosyBrown
        Me.TextBox4.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(162, 230)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 28)
        Me.TextBox4.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.CausesValidation = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.HotelsDataGridViewTextBoxColumn, Me.NumberofroomsDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.NumberofbedsDataGridViewTextBoxColumn, Me.ChargesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RoomTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(329, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(459, 262)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 43
        '
        'HotelsDataGridViewTextBoxColumn
        '
        Me.HotelsDataGridViewTextBoxColumn.DataPropertyName = "hotels"
        Me.HotelsDataGridViewTextBoxColumn.HeaderText = "hotels"
        Me.HotelsDataGridViewTextBoxColumn.Name = "HotelsDataGridViewTextBoxColumn"
        Me.HotelsDataGridViewTextBoxColumn.Width = 60
        '
        'NumberofroomsDataGridViewTextBoxColumn
        '
        Me.NumberofroomsDataGridViewTextBoxColumn.DataPropertyName = "numberofrooms"
        Me.NumberofroomsDataGridViewTextBoxColumn.HeaderText = "numberofrooms"
        Me.NumberofroomsDataGridViewTextBoxColumn.Name = "NumberofroomsDataGridViewTextBoxColumn"
        Me.NumberofroomsDataGridViewTextBoxColumn.Width = 104
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.Width = 48
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.Width = 62
        '
        'NumberofbedsDataGridViewTextBoxColumn
        '
        Me.NumberofbedsDataGridViewTextBoxColumn.DataPropertyName = "numberofbeds"
        Me.NumberofbedsDataGridViewTextBoxColumn.HeaderText = "numberofbeds"
        Me.NumberofbedsDataGridViewTextBoxColumn.Name = "NumberofbedsDataGridViewTextBoxColumn"
        Me.NumberofbedsDataGridViewTextBoxColumn.Width = 99
        '
        'ChargesDataGridViewTextBoxColumn
        '
        Me.ChargesDataGridViewTextBoxColumn.DataPropertyName = "charges"
        Me.ChargesDataGridViewTextBoxColumn.HeaderText = "charges"
        Me.ChargesDataGridViewTextBoxColumn.Name = "ChargesDataGridViewTextBoxColumn"
        Me.ChargesDataGridViewTextBoxColumn.Width = 70
        '
        'RoomTable1BindingSource
        '
        Me.RoomTable1BindingSource.DataMember = "roomTable1"
        Me.RoomTable1BindingSource.DataSource = Me.PragatiDatabase2DataSet
        '
        'PragatiDatabase2DataSet
        '
        Me.PragatiDatabase2DataSet.DataSetName = "pragatiDatabase2DataSet"
        Me.PragatiDatabase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomTable1TableAdapter
        '
        Me.RoomTable1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.roomTable1TableAdapter = Me.RoomTable1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Pragati.pragatiDatabase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'searchwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BackgroundImage = Global.Pragati.My.Resources.Resources.west_baden_springs_hotel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "searchwindow"
        Me.Text = "sEARCH rOOM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PragatiDatabase2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PragatiDatabase2DataSet As pragatiDatabase2DataSet
    Friend WithEvents RoomTable1BindingSource As BindingSource
    Friend WithEvents RoomTable1TableAdapter As pragatiDatabase2DataSetTableAdapters.roomTable1TableAdapter
    Friend WithEvents TableAdapterManager As pragatiDatabase2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotelsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberofroomsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberofbedsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChargesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
