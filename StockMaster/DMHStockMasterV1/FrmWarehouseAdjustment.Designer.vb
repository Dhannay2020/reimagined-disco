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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MovementDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransToQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransFromQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromShopRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UnitPrices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtAdjustHangers = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtCurrentHangers = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(922, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 25)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'MovementDate
        '
        Me.MovementDate.HeaderText = "Movement Date"
        Me.MovementDate.MinimumWidth = 9
        Me.MovementDate.Name = "MovementDate"
        Me.MovementDate.ReadOnly = True
        Me.MovementDate.Visible = False
        '
        'TransToQty
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "N0"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.TransToQty.DefaultCellStyle = DataGridViewCellStyle19
        Me.TransToQty.HeaderText = "Adjustment Qty"
        Me.TransToQty.MinimumWidth = 9
        Me.TransToQty.Name = "TransToQty"
        Me.TransToQty.ReadOnly = True
        '
        'TransFromQty
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.NullValue = Nothing
        Me.TransFromQty.DefaultCellStyle = DataGridViewCellStyle20
        Me.TransFromQty.HeaderText = "Adjustment Type"
        Me.TransFromQty.MinimumWidth = 9
        Me.TransFromQty.Name = "TransFromQty"
        Me.TransFromQty.ReadOnly = True
        '
        'CurrentQty
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N0"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.CurrentQty.DefaultCellStyle = DataGridViewCellStyle21
        Me.CurrentQty.HeaderText = "Current Qty"
        Me.CurrentQty.MinimumWidth = 9
        Me.CurrentQty.Name = "CurrentQty"
        Me.CurrentQty.ReadOnly = True
        '
        'FromShopRef
        '
        Me.FromShopRef.HeaderText = "From Shop"
        Me.FromShopRef.MinimumWidth = 9
        Me.FromShopRef.Name = "FromShopRef"
        Me.FromShopRef.ReadOnly = True
        Me.FromShopRef.Visible = False
        '
        'stockCodeCol
        '
        Me.stockCodeCol.HeaderText = "Stock Code"
        Me.stockCodeCol.MinimumWidth = 9
        Me.stockCodeCol.Name = "stockCodeCol"
        Me.stockCodeCol.ReadOnly = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stockCodeCol, Me.FromShopRef, Me.CurrentQty, Me.TransFromQty, Me.TransToQty, Me.MovementDate, Me.UnitPrices})
        Me.DataGridView1.Location = New System.Drawing.Point(36, 361)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.Size = New System.Drawing.Size(1071, 393)
        Me.DataGridView1.TabIndex = 93
        '
        'UnitPrices
        '
        Me.UnitPrices.HeaderText = "UnitPrices"
        Me.UnitPrices.MinimumWidth = 9
        Me.UnitPrices.Name = "UnitPrices"
        Me.UnitPrices.ReadOnly = True
        Me.UnitPrices.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(968, 259)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 61)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cboType
        '
        Me.cboType.AutoCompleteCustomSource.AddRange(New String() {"Gain", "Loss"})
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Loss", "Gain"})
        Me.cboType.Location = New System.Drawing.Point(445, 287)
        Me.cboType.Margin = New System.Windows.Forms.Padding(6)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(219, 32)
        Me.cboType.TabIndex = 75
        '
        'txtAdjustHangers
        '
        Me.txtAdjustHangers.Location = New System.Drawing.Point(678, 287)
        Me.txtAdjustHangers.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAdjustHangers.Name = "txtAdjustHangers"
        Me.txtAdjustHangers.Size = New System.Drawing.Size(219, 29)
        Me.txtAdjustHangers.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(691, 257)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 25)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Adjustment Qty:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(911, 257)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 63)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(469, 257)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 25)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Adjustment Type:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(911, 121)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 29)
        Me.TextBox1.TabIndex = 92
        Me.TextBox1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(397, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Name:"
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.Enabled = False
        Me.txtWarehouseName.Location = New System.Drawing.Point(469, 115)
        Me.txtWarehouseName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(334, 29)
        Me.txtWarehouseName.TabIndex = 83
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(907, 161)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 29)
        Me.TextBox2.TabIndex = 84
        Me.TextBox2.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(577, 62)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(259, 29)
        Me.DateTimePicker1.TabIndex = 71
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(504, 62)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 25)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Date:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(561, 765)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 42)
        Me.Button4.TabIndex = 80
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtCurrentHangers
        '
        Me.txtCurrentHangers.Location = New System.Drawing.Point(251, 287)
        Me.txtCurrentHangers.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCurrentHangers.Name = "txtCurrentHangers"
        Me.txtCurrentHangers.Size = New System.Drawing.Size(180, 29)
        Me.txtCurrentHangers.TabIndex = 73
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(795, 765)
        Me.Button5.Margin = New System.Windows.Forms.Padding(6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 42)
        Me.Button5.TabIndex = 82
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtStockCode
        '
        Me.txtStockCode.Location = New System.Drawing.Point(56, 287)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(180, 29)
        Me.txtStockCode.TabIndex = 74
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(678, 765)
        Me.Button6.Margin = New System.Windows.Forms.Padding(6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 42)
        Me.Button6.TabIndex = 81
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtWarehouseRef
        '
        Me.txtWarehouseRef.Enabled = False
        Me.txtWarehouseRef.Location = New System.Drawing.Point(203, 115)
        Me.txtWarehouseRef.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWarehouseRef.MaxLength = 8
        Me.txtWarehouseRef.Name = "txtWarehouseRef"
        Me.txtWarehouseRef.Size = New System.Drawing.Size(180, 29)
        Me.txtWarehouseRef.TabIndex = 72
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(203, 193)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(6)
        Me.txtReference.MaxLength = 50
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(180, 29)
        Me.txtReference.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 193)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Reference:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Warehouse Ref:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 257)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Current Qty:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 257)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Stock Code:"
        '
        'FrmWarehouseAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2288, 1330)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtAdjustHangers)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtWarehouseName)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtCurrentHangers)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtStockCode)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtWarehouseRef)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmWarehouseAdjustment"
        Me.Text = "FrmWarehouseAdjustment"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents MovementDate As DataGridViewTextBoxColumn
    Friend WithEvents TransToQty As DataGridViewTextBoxColumn
    Friend WithEvents TransFromQty As DataGridViewTextBoxColumn
    Friend WithEvents CurrentQty As DataGridViewTextBoxColumn
    Friend WithEvents FromShopRef As DataGridViewTextBoxColumn
    Friend WithEvents stockCodeCol As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UnitPrices As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtAdjustHangers As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents txtCurrentHangers As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents txtWarehouseRef As TextBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
