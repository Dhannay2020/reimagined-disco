<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShopReturn
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
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DgvRecords = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtReturnID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtShopName = New System.Windows.Forms.TextBox()
        Me.txtCurrentQty = New System.Windows.Forms.TextBox()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.txtShopRef = New System.Windows.Forms.TextBox()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdClearGrid = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalItems = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTransferQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.Location = New System.Drawing.Point(150, 52)
        Me.txtWarehouseName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(439, 29)
        Me.txtWarehouseName.TabIndex = 7
        Me.txtWarehouseName.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 87)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Transfer Qty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(146, 23)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Name:"
        '
        'DgvRecords
        '
        Me.DgvRecords.AllowUserToAddRows = False
        Me.DgvRecords.AllowUserToDeleteRows = False
        Me.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DgvRecords.Location = New System.Drawing.Point(15, 119)
        Me.DgvRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvRecords.Name = "DgvRecords"
        Me.DgvRecords.RowHeadersWidth = 72
        Me.DgvRecords.Size = New System.Drawing.Size(380, 162)
        Me.DgvRecords.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "ReturnLineID"
        Me.Column1.MinimumWidth = 9
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        Me.Column1.Width = 175
        '
        'Column2
        '
        Me.Column2.HeaderText = "ReturnID"
        Me.Column2.MinimumWidth = 9
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        Me.Column2.Width = 175
        '
        'Column3
        '
        Me.Column3.HeaderText = "Stock Code"
        Me.Column3.MinimumWidth = 9
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 175
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qty"
        Me.Column4.MinimumWidth = 9
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 175
        '
        'Column5
        '
        Me.Column5.HeaderText = "Value"
        Me.Column5.MinimumWidth = 9
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        Me.Column5.Width = 175
        '
        'txtReturnID
        '
        Me.txtReturnID.Enabled = False
        Me.txtReturnID.Location = New System.Drawing.Point(126, 12)
        Me.txtReturnID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReturnID.Name = "txtReturnID"
        Me.txtReturnID.Size = New System.Drawing.Size(148, 29)
        Me.txtReturnID.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 21)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 25)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "ReturnID"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(342, 47)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(201, 29)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Return To Supplier"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(284, 16)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 25)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Date:"
        '
        'DtpDate
        '
        Me.DtpDate.CustomFormat = "dd-MM-yyyy"
        Me.DtpDate.Location = New System.Drawing.Point(342, 12)
        Me.DtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(200, 29)
        Me.DtpDate.TabIndex = 0
        Me.DtpDate.Value = New Date(2016, 2, 7, 0, 0, 0, 0)
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(342, 76)
        Me.txtShopName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(274, 29)
        Me.txtShopName.TabIndex = 12
        Me.txtShopName.TabStop = False
        '
        'txtCurrentQty
        '
        Me.txtCurrentQty.Location = New System.Drawing.Point(126, 140)
        Me.txtCurrentQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentQty.Name = "txtCurrentQty"
        Me.txtCurrentQty.Size = New System.Drawing.Size(148, 29)
        Me.txtCurrentQty.TabIndex = 5
        '
        'txtStockCode
        '
        Me.txtStockCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStockCode.Location = New System.Drawing.Point(126, 108)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(148, 29)
        Me.txtStockCode.TabIndex = 4
        '
        'txtShopRef
        '
        Me.txtShopRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtShopRef.Location = New System.Drawing.Point(126, 76)
        Me.txtShopRef.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShopRef.MaxLength = 8
        Me.txtShopRef.Name = "txtShopRef"
        Me.txtShopRef.Size = New System.Drawing.Size(148, 29)
        Me.txtShopRef.TabIndex = 2
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(126, 44)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReference.MaxLength = 50
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(148, 29)
        Me.txtReference.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(279, 80)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Current Qty:"
        '
        'txtWarehouseRef
        '
        Me.txtWarehouseRef.Location = New System.Drawing.Point(14, 52)
        Me.txtWarehouseRef.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWarehouseRef.MaxLength = 8
        Me.txtWarehouseRef.Name = "txtWarehouseRef"
        Me.txtWarehouseRef.Size = New System.Drawing.Size(92, 29)
        Me.txtWarehouseRef.TabIndex = 6
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(816, 637)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(112, 28)
        Me.cmdClear.TabIndex = 9
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Stock Code:"
        '
        'cmdClearGrid
        '
        Me.cmdClearGrid.Location = New System.Drawing.Point(430, 84)
        Me.cmdClearGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClearGrid.Name = "cmdClearGrid"
        Me.cmdClearGrid.Size = New System.Drawing.Size(112, 28)
        Me.cmdClearGrid.TabIndex = 2
        Me.cmdClearGrid.Text = "Delete All"
        Me.cmdClearGrid.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(309, 84)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(112, 28)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalItems)
        Me.GroupBox2.Controls.Add(Me.cmdClearGrid)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.txtTransferQty)
        Me.GroupBox2.Controls.Add(Me.txtWarehouseName)
        Me.GroupBox2.Controls.Add(Me.txtWarehouseRef)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DgvRecords)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 328)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(639, 302)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Return To:"
        '
        'txtTotalItems
        '
        Me.txtTotalItems.Location = New System.Drawing.Point(408, 254)
        Me.txtTotalItems.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.Size = New System.Drawing.Size(86, 29)
        Me.txtTotalItems.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(404, 234)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 25)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Total Items:"
        '
        'txtTransferQty
        '
        Me.txtTransferQty.Location = New System.Drawing.Point(150, 84)
        Me.txtTransferQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransferQty.Name = "txtTransferQty"
        Me.txtTransferQty.Size = New System.Drawing.Size(148, 29)
        Me.txtTransferQty.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 25)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Warehouse Ref:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Shop Ref:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Reference:"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(572, 637)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(112, 28)
        Me.cmdOK.TabIndex = 7
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(694, 637)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(112, 28)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtReturnID)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DtpDate)
        Me.GroupBox1.Controls.Add(Me.txtShopName)
        Me.GroupBox1.Controls.Add(Me.txtCurrentQty)
        Me.GroupBox1.Controls.Add(Me.txtStockCode)
        Me.GroupBox1.Controls.Add(Me.txtShopRef)
        Me.GroupBox1.Controls.Add(Me.txtReference)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(310, 146)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(639, 178)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current"
        '
        'FrmShopReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 811)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmShopReturn"
        Me.Text = "FrmShopReturn"
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DgvRecords As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtReturnID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents txtCurrentQty As TextBox
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents txtShopRef As TextBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWarehouseRef As TextBox
    Friend WithEvents cmdClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdClearGrid As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotalItems As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTransferQty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
