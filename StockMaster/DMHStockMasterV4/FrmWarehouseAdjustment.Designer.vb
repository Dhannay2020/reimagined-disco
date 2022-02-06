<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWarehouseAdjustment
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
        Me.TxtRecordID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotalLoss = New System.Windows.Forms.Label()
        Me.TxtTotalGain = New System.Windows.Forms.Label()
        Me.LblTotalLoss = New System.Windows.Forms.Label()
        Me.lblTotalGain = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdRemoveFromGrid = New System.Windows.Forms.Button()
        Me.CboType = New System.Windows.Forms.ComboBox()
        Me.TxtAdjustHangers = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmdAddToGrid = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtWarehouseName = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.TxtCurrentHangers = New System.Windows.Forms.TextBox()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.TxtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.TxtReference = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtStockCode = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtRecordID
        '
        Me.TxtRecordID.Location = New System.Drawing.Point(616, 37)
        Me.TxtRecordID.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRecordID.Name = "TxtRecordID"
        Me.TxtRecordID.Size = New System.Drawing.Size(70, 29)
        Me.TxtRecordID.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(526, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 25)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Record ID:"
        '
        'TxtTotalLoss
        '
        Me.TxtTotalLoss.AutoSize = True
        Me.TxtTotalLoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtTotalLoss.Location = New System.Drawing.Point(297, 442)
        Me.TxtTotalLoss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTotalLoss.Name = "TxtTotalLoss"
        Me.TxtTotalLoss.Size = New System.Drawing.Size(36, 27)
        Me.TxtTotalLoss.TabIndex = 41
        Me.TxtTotalLoss.Text = "00"
        '
        'TxtTotalGain
        '
        Me.TxtTotalGain.AutoSize = True
        Me.TxtTotalGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtTotalGain.Location = New System.Drawing.Point(147, 442)
        Me.TxtTotalGain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTotalGain.Name = "TxtTotalGain"
        Me.TxtTotalGain.Size = New System.Drawing.Size(36, 27)
        Me.TxtTotalGain.TabIndex = 39
        Me.TxtTotalGain.Text = "00"
        '
        'LblTotalLoss
        '
        Me.LblTotalLoss.AutoSize = True
        Me.LblTotalLoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalLoss.Location = New System.Drawing.Point(265, 424)
        Me.LblTotalLoss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTotalLoss.Name = "LblTotalLoss"
        Me.LblTotalLoss.Size = New System.Drawing.Size(111, 27)
        Me.LblTotalLoss.TabIndex = 40
        Me.LblTotalLoss.Text = "Total Loss:"
        '
        'lblTotalGain
        '
        Me.lblTotalGain.AutoSize = True
        Me.lblTotalGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGain.Location = New System.Drawing.Point(127, 424)
        Me.lblTotalGain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalGain.Name = "lblTotalGain"
        Me.lblTotalGain.Size = New System.Drawing.Size(110, 27)
        Me.lblTotalGain.TabIndex = 38
        Me.lblTotalGain.Text = "Total Gain:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(36, 158)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.Size = New System.Drawing.Size(665, 262)
        Me.DataGridView1.TabIndex = 46
        '
        'Column1
        '
        Me.Column1.HeaderText = "LineID"
        Me.Column1.MinimumWidth = 9
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "RecID"
        Me.Column2.MinimumWidth = 9
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "StockCode"
        Me.Column3.MinimumWidth = 9
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Movement Type"
        Me.Column4.MinimumWidth = 9
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Qty"
        Me.Column5.MinimumWidth = 9
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Value"
        Me.Column6.MinimumWidth = 9
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'CmdRemoveFromGrid
        '
        Me.CmdRemoveFromGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdRemoveFromGrid.Location = New System.Drawing.Point(663, 107)
        Me.CmdRemoveFromGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdRemoveFromGrid.Name = "CmdRemoveFromGrid"
        Me.CmdRemoveFromGrid.Size = New System.Drawing.Size(38, 41)
        Me.CmdRemoveFromGrid.TabIndex = 34
        Me.CmdRemoveFromGrid.Text = "-"
        Me.CmdRemoveFromGrid.UseVisualStyleBackColor = True
        '
        'CboType
        '
        Me.CboType.AutoCompleteCustomSource.AddRange(New String() {"Gain", "Loss"})
        Me.CboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboType.FormattingEnabled = True
        Me.CboType.Items.AddRange(New Object() {"Loss", "Gain"})
        Me.CboType.Location = New System.Drawing.Point(280, 126)
        Me.CboType.Margin = New System.Windows.Forms.Padding(4)
        Me.CboType.Name = "CboType"
        Me.CboType.Size = New System.Drawing.Size(142, 32)
        Me.CboType.TabIndex = 31
        '
        'TxtAdjustHangers
        '
        Me.TxtAdjustHangers.Location = New System.Drawing.Point(430, 126)
        Me.TxtAdjustHangers.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAdjustHangers.Name = "TxtAdjustHangers"
        Me.TxtAdjustHangers.Size = New System.Drawing.Size(180, 29)
        Me.TxtAdjustHangers.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(433, 106)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 25)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Adjustment Qty:"
        '
        'CmdAddToGrid
        '
        Me.CmdAddToGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAddToGrid.Location = New System.Drawing.Point(616, 106)
        Me.CmdAddToGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdAddToGrid.Name = "CmdAddToGrid"
        Me.CmdAddToGrid.Size = New System.Drawing.Size(38, 42)
        Me.CmdAddToGrid.TabIndex = 33
        Me.CmdAddToGrid.Text = "+"
        Me.CmdAddToGrid.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(280, 106)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 25)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Adjustment Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Name:"
        '
        'TxtWarehouseName
        '
        Me.TxtWarehouseName.Enabled = False
        Me.TxtWarehouseName.Location = New System.Drawing.Point(324, 67)
        Me.TxtWarehouseName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtWarehouseName.Name = "TxtWarehouseName"
        Me.TxtWarehouseName.Size = New System.Drawing.Size(180, 29)
        Me.TxtWarehouseName.TabIndex = 53
        Me.TxtWarehouseName.Text = "Universal Warehouse"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 38)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(179, 29)
        Me.DateTimePicker1.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 25)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Date:"
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(413, 428)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(87, 28)
        Me.CmdOK.TabIndex = 35
        Me.CmdOK.Text = "Add"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'TxtCurrentHangers
        '
        Me.TxtCurrentHangers.Location = New System.Drawing.Point(177, 126)
        Me.TxtCurrentHangers.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCurrentHangers.Name = "TxtCurrentHangers"
        Me.TxtCurrentHangers.Size = New System.Drawing.Size(95, 29)
        Me.TxtCurrentHangers.TabIndex = 44
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(614, 428)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(87, 28)
        Me.CmdCancel.TabIndex = 37
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(518, 428)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(87, 28)
        Me.CmdClear.TabIndex = 36
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'TxtWarehouseRef
        '
        Me.TxtWarehouseRef.Enabled = False
        Me.TxtWarehouseRef.Location = New System.Drawing.Point(167, 68)
        Me.TxtWarehouseRef.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtWarehouseRef.MaxLength = 8
        Me.TxtWarehouseRef.Name = "TxtWarehouseRef"
        Me.TxtWarehouseRef.Size = New System.Drawing.Size(83, 29)
        Me.TxtWarehouseRef.TabIndex = 49
        Me.TxtWarehouseRef.Text = "UNI"
        '
        'TxtReference
        '
        Me.TxtReference.Location = New System.Drawing.Point(370, 37)
        Me.TxtReference.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtReference.MaxLength = 50
        Me.TxtReference.Name = "TxtReference"
        Me.TxtReference.Size = New System.Drawing.Size(148, 29)
        Me.TxtReference.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Reference:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Warehouse Ref:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Current Qty:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Stock Code:"
        '
        'TxtStockCode
        '
        Me.TxtStockCode.Location = New System.Drawing.Point(41, 126)
        Me.TxtStockCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockCode.MaxLength = 30
        Me.TxtStockCode.Name = "TxtStockCode"
        Me.TxtStockCode.Size = New System.Drawing.Size(128, 29)
        Me.TxtStockCode.TabIndex = 30
        '
        'FrmWarehouseAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 798)
        Me.Controls.Add(Me.TxtRecordID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTotalLoss)
        Me.Controls.Add(Me.TxtTotalGain)
        Me.Controls.Add(Me.LblTotalLoss)
        Me.Controls.Add(Me.lblTotalGain)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmdRemoveFromGrid)
        Me.Controls.Add(Me.CboType)
        Me.Controls.Add(Me.TxtAdjustHangers)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmdAddToGrid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtWarehouseName)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.TxtCurrentHangers)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.TxtWarehouseRef)
        Me.Controls.Add(Me.TxtReference)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtStockCode)
        Me.Name = "FrmWarehouseAdjustment"
        Me.Text = "FrmWarehouseAdjustment"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtRecordID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotalLoss As Label
    Friend WithEvents TxtTotalGain As Label
    Friend WithEvents LblTotalLoss As Label
    Friend WithEvents lblTotalGain As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents CmdRemoveFromGrid As Button
    Friend WithEvents CboType As ComboBox
    Friend WithEvents TxtAdjustHangers As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CmdAddToGrid As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtWarehouseName As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Public WithEvents CmdOK As Button
    Friend WithEvents TxtCurrentHangers As TextBox
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdClear As Button
    Friend WithEvents TxtWarehouseRef As TextBox
    Friend WithEvents TxtReference As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtStockCode As TextBox
End Class
