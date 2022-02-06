<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWarehouseReturn
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
        Me.txtTWarehouseName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.TxtRecordNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtFWarehouseName = New System.Windows.Forms.TextBox()
        Me.txtCurrentQty = New System.Windows.Forms.TextBox()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.txtFWarehouseRef = New System.Windows.Forms.TextBox()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvRecords = New System.Windows.Forms.DataGridView()
        Me.TRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTransQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.values = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTWarehouseRef = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdClearGrid = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTransferQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalItems = New System.Windows.Forms.TextBox()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTWarehouseName
        '
        Me.txtTWarehouseName.Enabled = False
        Me.txtTWarehouseName.Location = New System.Drawing.Point(183, 55)
        Me.txtTWarehouseName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTWarehouseName.Name = "txtTWarehouseName"
        Me.txtTWarehouseName.Size = New System.Drawing.Size(439, 29)
        Me.txtTWarehouseName.TabIndex = 6
        Me.txtTWarehouseName.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 84)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Transfer Qty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Warehouse Ref:"
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(622, 577)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(112, 28)
        Me.cmdClear.TabIndex = 12
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'TxtRecordNo
        '
        Me.TxtRecordNo.Enabled = False
        Me.TxtRecordNo.Location = New System.Drawing.Point(440, 23)
        Me.TxtRecordNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRecordNo.Name = "TxtRecordNo"
        Me.TxtRecordNo.Size = New System.Drawing.Size(103, 29)
        Me.TxtRecordNo.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(346, 26)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "RecordID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 25)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Date:"
        '
        'DtpDate
        '
        Me.DtpDate.CustomFormat = "dd-MM-yyyy"
        Me.DtpDate.Location = New System.Drawing.Point(122, 23)
        Me.DtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(200, 29)
        Me.DtpDate.TabIndex = 0
        Me.DtpDate.Value = New Date(2016, 2, 7, 0, 0, 0, 0)
        '
        'txtFWarehouseName
        '
        Me.txtFWarehouseName.Enabled = False
        Me.txtFWarehouseName.Location = New System.Drawing.Point(366, 87)
        Me.txtFWarehouseName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFWarehouseName.Name = "txtFWarehouseName"
        Me.txtFWarehouseName.Size = New System.Drawing.Size(274, 29)
        Me.txtFWarehouseName.TabIndex = 10
        Me.txtFWarehouseName.TabStop = False
        '
        'txtCurrentQty
        '
        Me.txtCurrentQty.Location = New System.Drawing.Point(141, 154)
        Me.txtCurrentQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentQty.Name = "txtCurrentQty"
        Me.txtCurrentQty.Size = New System.Drawing.Size(148, 29)
        Me.txtCurrentQty.TabIndex = 11
        '
        'txtStockCode
        '
        Me.txtStockCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStockCode.Location = New System.Drawing.Point(141, 122)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(148, 29)
        Me.txtStockCode.TabIndex = 2
        '
        'txtFWarehouseRef
        '
        Me.txtFWarehouseRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFWarehouseRef.Enabled = False
        Me.txtFWarehouseRef.Location = New System.Drawing.Point(141, 87)
        Me.txtFWarehouseRef.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFWarehouseRef.MaxLength = 8
        Me.txtFWarehouseRef.Name = "txtFWarehouseRef"
        Me.txtFWarehouseRef.Size = New System.Drawing.Size(148, 29)
        Me.txtFWarehouseRef.TabIndex = 7
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(141, 55)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReference.MaxLength = 50
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(148, 29)
        Me.txtReference.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 91)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Current Qty:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Stock Code:"
        '
        'DgvRecords
        '
        Me.DgvRecords.AllowUserToAddRows = False
        Me.DgvRecords.AllowUserToDeleteRows = False
        Me.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRef, Me.Ref, Me.colStockCode, Me.colTransQty, Me.values})
        Me.DgvRecords.Location = New System.Drawing.Point(46, 353)
        Me.DgvRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvRecords.Name = "DgvRecords"
        Me.DgvRecords.RowHeadersWidth = 72
        Me.DgvRecords.Size = New System.Drawing.Size(624, 185)
        Me.DgvRecords.TabIndex = 13
        '
        'TRef
        '
        Me.TRef.HeaderText = "Tref"
        Me.TRef.MinimumWidth = 9
        Me.TRef.Name = "TRef"
        Me.TRef.Visible = False
        Me.TRef.Width = 175
        '
        'Ref
        '
        Me.Ref.HeaderText = "Ref"
        Me.Ref.MinimumWidth = 9
        Me.Ref.Name = "Ref"
        Me.Ref.Visible = False
        Me.Ref.Width = 175
        '
        'colStockCode
        '
        Me.colStockCode.HeaderText = "Stock Code"
        Me.colStockCode.MinimumWidth = 9
        Me.colStockCode.Name = "colStockCode"
        Me.colStockCode.Width = 150
        '
        'colTransQty
        '
        Me.colTransQty.HeaderText = "Qty"
        Me.colTransQty.MinimumWidth = 9
        Me.colTransQty.Name = "colTransQty"
        Me.colTransQty.Width = 175
        '
        'values
        '
        Me.values.HeaderText = "Value"
        Me.values.MinimumWidth = 9
        Me.values.Name = "values"
        Me.values.Visible = False
        Me.values.Width = 175
        '
        'txtTWarehouseRef
        '
        Me.txtTWarehouseRef.Enabled = False
        Me.txtTWarehouseRef.Location = New System.Drawing.Point(183, 23)
        Me.txtTWarehouseRef.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTWarehouseRef.MaxLength = 8
        Me.txtTWarehouseRef.Name = "txtTWarehouseRef"
        Me.txtTWarehouseRef.Size = New System.Drawing.Size(148, 29)
        Me.txtTWarehouseRef.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Warehouse Ref:"
        '
        'cmdClearGrid
        '
        Me.cmdClearGrid.Location = New System.Drawing.Point(468, 87)
        Me.cmdClearGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClearGrid.Name = "cmdClearGrid"
        Me.cmdClearGrid.Size = New System.Drawing.Size(112, 28)
        Me.cmdClearGrid.TabIndex = 3
        Me.cmdClearGrid.Text = "Delete All"
        Me.cmdClearGrid.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(346, 87)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(112, 28)
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdClearGrid)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.txtTransferQty)
        Me.GroupBox2.Controls.Add(Me.txtTWarehouseName)
        Me.GroupBox2.Controls.Add(Me.txtTWarehouseRef)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(46, 221)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(663, 124)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Return To:"
        '
        'txtTransferQty
        '
        Me.txtTransferQty.Location = New System.Drawing.Point(184, 87)
        Me.txtTransferQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransferQty.Name = "txtTransferQty"
        Me.txtTransferQty.Size = New System.Drawing.Size(148, 29)
        Me.txtTransferQty.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Reference:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(226, 545)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 25)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Total Items:"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(366, 577)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(112, 28)
        Me.cmdOK.TabIndex = 10
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(500, 577)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(112, 28)
        Me.cmdCancel.TabIndex = 11
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtRecordNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DtpDate)
        Me.GroupBox1.Controls.Add(Me.txtFWarehouseName)
        Me.GroupBox1.Controls.Add(Me.txtCurrentQty)
        Me.GroupBox1.Controls.Add(Me.txtStockCode)
        Me.GroupBox1.Controls.Add(Me.txtFWarehouseRef)
        Me.GroupBox1.Controls.Add(Me.txtReference)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(663, 186)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current"
        '
        'txtTotalItems
        '
        Me.txtTotalItems.Location = New System.Drawing.Point(328, 545)
        Me.txtTotalItems.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.Size = New System.Drawing.Size(148, 29)
        Me.txtTotalItems.TabIndex = 15
        '
        'FrmWarehouseReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 1067)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.DgvRecords)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTotalItems)
        Me.Name = "FrmWarehouseReturn"
        Me.Text = "FrmWarehouseReturn"
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTWarehouseName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdClear As Button
    Friend WithEvents TxtRecordNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents txtFWarehouseName As TextBox
    Friend WithEvents txtCurrentQty As TextBox
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents txtFWarehouseRef As TextBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvRecords As DataGridView
    Friend WithEvents TRef As DataGridViewTextBoxColumn
    Friend WithEvents Ref As DataGridViewTextBoxColumn
    Friend WithEvents colStockCode As DataGridViewTextBoxColumn
    Friend WithEvents colTransQty As DataGridViewTextBoxColumn
    Friend WithEvents values As DataGridViewTextBoxColumn
    Friend WithEvents txtTWarehouseRef As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdClearGrid As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTransferQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTotalItems As TextBox
End Class
