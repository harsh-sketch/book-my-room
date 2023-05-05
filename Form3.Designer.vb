<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RoomTable1TableAdapter = New Pragati.pragatiDatabase2DataSetTableAdapters.roomTable1TableAdapter()
        Me.TableAdapterManager = New Pragati.pragatiDatabase2DataSetTableAdapters.TableAdapterManager()
        Me.NumberofroomsToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NumberofroomsToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PragatiDatabase2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.CausesValidation = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.HotelsDataGridViewTextBoxColumn, Me.NumberofroomsDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.NumberofbedsDataGridViewTextBoxColumn, Me.ChargesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RoomTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(561, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(799, 444)
        Me.DataGridView1.TabIndex = 9
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'HotelsDataGridViewTextBoxColumn
        '
        Me.HotelsDataGridViewTextBoxColumn.DataPropertyName = "hotels"
        Me.HotelsDataGridViewTextBoxColumn.HeaderText = "hotels"
        Me.HotelsDataGridViewTextBoxColumn.Name = "HotelsDataGridViewTextBoxColumn"
        '
        'NumberofroomsDataGridViewTextBoxColumn
        '
        Me.NumberofroomsDataGridViewTextBoxColumn.DataPropertyName = "numberofrooms"
        Me.NumberofroomsDataGridViewTextBoxColumn.HeaderText = "numberofrooms"
        Me.NumberofroomsDataGridViewTextBoxColumn.Name = "NumberofroomsDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'NumberofbedsDataGridViewTextBoxColumn
        '
        Me.NumberofbedsDataGridViewTextBoxColumn.DataPropertyName = "numberofbeds"
        Me.NumberofbedsDataGridViewTextBoxColumn.HeaderText = "numberofbeds"
        Me.NumberofbedsDataGridViewTextBoxColumn.Name = "NumberofbedsDataGridViewTextBoxColumn"
        '
        'ChargesDataGridViewTextBoxColumn
        '
        Me.ChargesDataGridViewTextBoxColumn.DataPropertyName = "charges"
        Me.ChargesDataGridViewTextBoxColumn.HeaderText = "charges"
        Me.ChargesDataGridViewTextBoxColumn.Name = "ChargesDataGridViewTextBoxColumn"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.RosyBrown
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(25, 427)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 36)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Charges"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.RosyBrown
        Me.TextBox4.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(241, 423)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(314, 40)
        Me.TextBox4.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.RosyBrown
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(634, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 45)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Book My Room"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RosyBrown
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(25, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 36)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Number of bed "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RosyBrown
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(25, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 36)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Number of room"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(25, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 36)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "city"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.RosyBrown
        Me.TextBox3.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(241, 367)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(314, 40)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RosyBrown
        Me.TextBox2.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(240, 311)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(314, 40)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.RosyBrown
        Me.TextBox1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(240, 259)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(315, 40)
        Me.TextBox1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lavender
        Me.Button1.BackgroundImage = Global.Pragati.My.Resources.Resources.images__3_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(197, 557)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 67)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
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
        'NumberofroomsToolStripLabel
        '
        Me.NumberofroomsToolStripLabel.Name = "NumberofroomsToolStripLabel"
        Me.NumberofroomsToolStripLabel.Size = New System.Drawing.Size(97, 22)
        Me.NumberofroomsToolStripLabel.Text = "numberofrooms:"
        '
        'NumberofroomsToolStripTextBox
        '
        Me.NumberofroomsToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NumberofroomsToolStripTextBox.Name = "NumberofroomsToolStripTextBox"
        Me.NumberofroomsToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumberofroomsToolStripLabel, Me.NumberofroomsToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1288, 25)
        Me.FillByToolStrip.TabIndex = 20
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lavender
        Me.Button2.BackgroundImage = Global.Pragati.My.Resources.Resources.images__3_
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(1019, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 38)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Log OUT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pragati.My.Resources.Resources.west_baden_springs_hotel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1288, 734)
        Me.Controls.Add(Me.Button2)
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
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PragatiDatabase2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
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
    Friend WithEvents NumberofroomsToolStripLabel As ToolStripLabel
    Friend WithEvents NumberofroomsToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents Button2 As Button
End Class
