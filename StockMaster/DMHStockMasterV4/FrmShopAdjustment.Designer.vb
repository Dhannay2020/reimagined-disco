<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShopAdjustment
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtSID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalLoss = New System.Windows.Forms.TextBox()
        Me.txtTotalGain = New System.Windows.Forms.TextBox()
        Me.UnitPrices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.stockCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromShopRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransFromQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransToQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovementDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdDeleteFromGrid = New System.Windows.Forms.Button()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtAdjustHangers = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmdAddToGrid = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.txtCurrentHangers = New System.Windows.Forms.TextBox()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.txtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSID
        '
        Me.TxtSID.Location = New System.Drawing.Point(607, 77)
        Me.TxtSID.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSID.Name = "TxtSID"
        Me.TxtSID.Size = New System.Drawing.Size(76, 29)
        Me.TxtSID.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(557, 57)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 25)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Shop Adjustment ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(526, 464)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 25)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Total Gain"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(619, 464)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 25)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Total Loss"
        '
        'txtTotalLoss
        '
        Me.txtTotalLoss.Location = New System.Drawing.Point(623, 484)
        Me.txtTotalLoss.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalLoss.Name = "txtTotalLoss"
        Me.txtTotalLoss.Size = New System.Drawing.Size(70, 29)
        Me.txtTotalLoss.TabIndex = 54
        '
        'txtTotalGain
        '
        Me.txtTotalGain.Location = New System.Drawing.Point(531, 484)
        Me.txtTotalGain.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalGain.Name = "txtTotalGain"
        Me.txtTotalGain.Size = New System.Drawing.Size(85, 29)
        Me.txtTotalGain.TabIndex = 53
        '
        'UnitPrices
        '
        Me.UnitPrices.HeaderText = "UnitPrices"
        Me.UnitPrices.MinimumWidth = 9
        Me.UnitPrices.Name = "UnitPrices"
        Me.UnitPrices.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stockCodeCol, Me.FromShopRef, Me.CurrentQty, Me.TransFromQty, Me.TransToQty, Me.MovementDate, Me.UnitPrices})
        Me.DataGridView1.Location = New System.Drawing.Point(59, 198)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.Size = New System.Drawing.Size(641, 262)
        Me.DataGridView1.TabIndex = 39
        '
        'stockCodeCol
        '
        Me.stockCodeCol.HeaderText = "Stock Code"
        Me.stockCodeCol.MinimumWidth = 9
        Me.stockCodeCol.Name = "stockCodeCol"
        '
        'FromShopRef
        '
        Me.FromShopRef.HeaderText = "From Shop"
        Me.FromShopRef.MinimumWidth = 9
        Me.FromShopRef.Name = "FromShopRef"
        Me.FromShopRef.Visible = False
        '
        'CurrentQty
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.CurrentQty.DefaultCellStyle = DataGridViewCellStyle4
        Me.CurrentQty.HeaderText = "Current Qty"
        Me.CurrentQty.MinimumWidth = 9
        Me.CurrentQty.Name = "CurrentQty"
        '
        'TransFromQty
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.NullValue = Nothing
        Me.TransFromQty.DefaultCellStyle = DataGridViewCellStyle5
        Me.TransFromQty.HeaderText = "Adjustment Type"
        Me.TransFromQty.MinimumWidth = 9
        Me.TransFromQty.Name = "TransFromQty"
        '
        'TransToQty
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.TransToQty.DefaultCellStyle = DataGridViewCellStyle6
        Me.TransToQty.HeaderText = "Adjustment Qty"
        Me.TransToQty.MinimumWidth = 9
        Me.TransToQty.Name = "TransToQty"
        '
        'MovementDate
        '
        Me.MovementDate.HeaderText = "Movement Date"
        Me.MovementDate.MinimumWidth = 9
        Me.MovementDate.Name = "MovementDate"
        Me.MovementDate.Visible = False
        '
        'CmdDeleteFromGrid
        '
        Me.CmdDeleteFromGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDeleteFromGrid.Location = New System.Drawing.Point(596, 147)
        Me.CmdDeleteFromGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdDeleteFromGrid.Name = "CmdDeleteFromGrid"
        Me.CmdDeleteFromGrid.Size = New System.Drawing.Size(38, 41)
        Me.CmdDeleteFromGrid.TabIndex = 35
        Me.CmdDeleteFromGrid.Text = "-"
        Me.CmdDeleteFromGrid.UseVisualStyleBackColor = True
        '
        'cboType
        '
        Me.cboType.AutoCompleteCustomSource.AddRange(New String() {"Gain", "Loss"})
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Loss", "Gain"})
        Me.cboType.Location = New System.Drawing.Point(292, 166)
        Me.cboType.Margin = New System.Windows.Forms.Padding(4)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(116, 32)
        Me.cboType.TabIndex = 32
        '
        'txtAdjustHangers
        '
        Me.txtAdjustHangers.Location = New System.Drawing.Point(441, 167)
        Me.txtAdjustHangers.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdjustHangers.Name = "txtAdjustHangers"
        Me.txtAdjustHangers.Size = New System.Drawing.Size(79, 29)
        Me.txtAdjustHangers.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(427, 147)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 25)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Adjustment Qty:"
        '
        'CmdAddToGrid
        '
        Me.CmdAddToGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAddToGrid.Location = New System.Drawing.Point(550, 145)
        Me.CmdAddToGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdAddToGrid.Name = "CmdAddToGrid"
        Me.CmdAddToGrid.Size = New System.Drawing.Size(38, 42)
        Me.CmdAddToGrid.TabIndex = 34
        Me.CmdAddToGrid.Text = "+"
        Me.CmdAddToGrid.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(289, 144)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 25)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Adjustment Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Name:"
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.Enabled = False
        Me.txtWarehouseName.Location = New System.Drawing.Point(312, 95)
        Me.txtWarehouseName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(183, 29)
        Me.txtWarehouseName.TabIndex = 51
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(131, 59)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(162, 29)
        Me.DateTimePicker1.TabIndex = 28
        Me.DateTimePicker1.Value = New Date(2017, 9, 1, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 59)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 25)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Date:"
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(394, 521)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(87, 28)
        Me.CmdOK.TabIndex = 36
        Me.CmdOK.Text = "Add"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'txtCurrentHangers
        '
        Me.txtCurrentHangers.Location = New System.Drawing.Point(185, 166)
        Me.txtCurrentHangers.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentHangers.Name = "txtCurrentHangers"
        Me.txtCurrentHangers.Size = New System.Drawing.Size(76, 29)
        Me.txtCurrentHangers.TabIndex = 40
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(595, 521)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(87, 28)
        Me.CmdCancel.TabIndex = 38
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(499, 521)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(87, 28)
        Me.CmdClear.TabIndex = 37
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'txtWarehouseRef
        '
        Me.txtWarehouseRef.Location = New System.Drawing.Point(155, 95)
        Me.txtWarehouseRef.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWarehouseRef.MaxLength = 8
        Me.txtWarehouseRef.Name = "txtWarehouseRef"
        Me.txtWarehouseRef.Size = New System.Drawing.Size(76, 29)
        Me.txtWarehouseRef.TabIndex = 30
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(393, 61)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReference.MaxLength = 50
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(148, 29)
        Me.txtReference.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Reference:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Shop Ref:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Current Qty:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Stock Code:"
        '
        'txtStockCode
        '
        Me.txtStockCode.Location = New System.Drawing.Point(75, 166)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(102, 29)
        Me.txtStockCode.TabIndex = 31
        '
        'FrmShopAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 1133)
        Me.Controls.Add(Me.TxtSID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalLoss)
        Me.Controls.Add(Me.txtTotalGain)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmdDeleteFromGrid)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtAdjustHangers)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmdAddToGrid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtWarehouseName)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.txtCurrentHangers)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.txtWarehouseRef)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStockCode)
        Me.Name = "FrmShopAdjustment"
        Me.Text = "FrmShopAdjustment"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalLoss As TextBox
    Friend WithEvents txtTotalGain As TextBox
    Friend WithEvents UnitPrices As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents stockCodeCol As DataGridViewTextBoxColumn
    Friend WithEvents FromShopRef As DataGridViewTextBoxColumn
    Friend WithEvents CurrentQty As DataGridViewTextBoxColumn
    Friend WithEvents TransFromQty As DataGridViewTextBoxColumn
    Friend WithEvents TransToQty As DataGridViewTextBoxColumn
    Friend WithEvents MovementDate As DataGridViewTextBoxColumn
    Friend WithEvents CmdDeleteFromGrid As Button
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtAdjustHangers As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CmdAddToGrid As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents CmdOK As Button
    Friend WithEvents txtCurrentHangers As TextBox
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdClear As Button
    Friend WithEvents txtWarehouseRef As TextBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStockCode As TextBox
End Class
