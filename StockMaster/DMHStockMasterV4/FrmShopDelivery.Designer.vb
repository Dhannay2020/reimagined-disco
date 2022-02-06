<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShopDelivery
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
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StockCodeDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarmentsDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValueCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Deliverlabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdClearForm = New System.Windows.Forms.Button()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.cmdAddItem = New System.Windows.Forms.Button()
        Me.txtQtyHangers = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtShopRef = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtShopName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalGarments = New System.Windows.Forms.TextBox()
        Me.txtDelNoteNumber = New System.Windows.Forms.TextBox()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtQty
        '
        Me.txtQty.Enabled = False
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.Red
        Me.txtQty.Location = New System.Drawing.Point(264, 268)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(115, 33)
        Me.txtQty.TabIndex = 53
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockCodeDG, Me.GarmentsDG, Me.ValueCol})
        Me.DataGridView1.Location = New System.Drawing.Point(105, 335)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.Size = New System.Drawing.Size(409, 252)
        Me.DataGridView1.TabIndex = 55
        '
        'StockCodeDG
        '
        Me.StockCodeDG.HeaderText = "Stock Code"
        Me.StockCodeDG.MinimumWidth = 9
        Me.StockCodeDG.Name = "StockCodeDG"
        '
        'GarmentsDG
        '
        Me.GarmentsDG.HeaderText = "Garments"
        Me.GarmentsDG.MinimumWidth = 9
        Me.GarmentsDG.Name = "GarmentsDG"
        '
        'ValueCol
        '
        Me.ValueCol.HeaderText = "Value"
        Me.ValueCol.MinimumWidth = 9
        Me.ValueCol.Name = "ValueCol"
        Me.ValueCol.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(175, 30)
        Me.ToolStripStatusLabel1.Text = "Delivery Lines :    "
        '
        'Deliverlabel
        '
        Me.Deliverlabel.Name = "Deliverlabel"
        Me.Deliverlabel.Size = New System.Drawing.Size(208, 30)
        Me.Deliverlabel.Text = "ToolStripStatusLabel2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 248)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 25)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Warehouse Qty"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Deliverlabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1012)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(923, 39)
        Me.StatusStrip1.TabIndex = 59
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label21.Location = New System.Drawing.Point(105, 248)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 25)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Stock Code"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(386, 248)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 25)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Delivery Qty"
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(458, 298)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(36, 28)
        Me.cmdClear.TabIndex = 36
        Me.cmdClear.Text = "-"
        Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdClearForm
        '
        Me.cmdClearForm.Location = New System.Drawing.Point(402, 645)
        Me.cmdClearForm.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClearForm.Name = "cmdClearForm"
        Me.cmdClearForm.Size = New System.Drawing.Size(112, 28)
        Me.cmdClearForm.TabIndex = 39
        Me.cmdClearForm.Text = "Clear"
        Me.cmdClearForm.UseVisualStyleBackColor = True
        '
        'txtStockCode
        '
        Me.txtStockCode.Location = New System.Drawing.Point(105, 268)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(149, 29)
        Me.txtStockCode.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(102, 136)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 25)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Shop Ref:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(225, 136)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 25)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Shop Name:"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(158, 645)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(112, 28)
        Me.cmdAdd.TabIndex = 37
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtWarehouseRef
        '
        Me.txtWarehouseRef.Enabled = False
        Me.txtWarehouseRef.Location = New System.Drawing.Point(105, 204)
        Me.txtWarehouseRef.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWarehouseRef.Name = "txtWarehouseRef"
        Me.txtWarehouseRef.Size = New System.Drawing.Size(84, 29)
        Me.txtWarehouseRef.TabIndex = 44
        Me.txtWarehouseRef.Text = "UNI"
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Location = New System.Drawing.Point(422, 298)
        Me.cmdAddItem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(36, 28)
        Me.cmdAddItem.TabIndex = 35
        Me.cmdAddItem.Text = "+"
        Me.cmdAddItem.UseVisualStyleBackColor = True
        '
        'txtQtyHangers
        '
        Me.txtQtyHangers.Location = New System.Drawing.Point(390, 268)
        Me.txtQtyHangers.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQtyHangers.Name = "txtQtyHangers"
        Me.txtQtyHangers.Size = New System.Drawing.Size(103, 29)
        Me.txtQtyHangers.TabIndex = 34
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(280, 645)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(112, 28)
        Me.cmdCancel.TabIndex = 38
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(201, 108)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(133, 29)
        Me.DateTimePicker1.TabIndex = 30
        '
        'txtShopRef
        '
        Me.txtShopRef.Location = New System.Drawing.Point(108, 156)
        Me.txtShopRef.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShopRef.MaxLength = 8
        Me.txtShopRef.Name = "txtShopRef"
        Me.txtShopRef.Size = New System.Drawing.Size(81, 29)
        Me.txtShopRef.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(257, 591)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 32)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Delivery Total:"
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(197, 156)
        Me.txtShopName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(293, 29)
        Me.txtShopName.TabIndex = 48
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Location = New System.Drawing.Point(104, 184)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 25)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Warehouse Ref:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(338, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 25)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Delivery Note No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(197, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Delivery Date:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(231, 184)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(177, 25)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Warehouse Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Record No:"
        '
        'txtTotalGarments
        '
        Me.txtTotalGarments.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotalGarments.Location = New System.Drawing.Point(354, 615)
        Me.txtTotalGarments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalGarments.Name = "txtTotalGarments"
        Me.txtTotalGarments.Size = New System.Drawing.Size(148, 29)
        Me.txtTotalGarments.TabIndex = 58
        '
        'txtDelNoteNumber
        '
        Me.txtDelNoteNumber.Location = New System.Drawing.Point(105, 108)
        Me.txtDelNoteNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDelNoteNumber.Name = "txtDelNoteNumber"
        Me.txtDelNoteNumber.Size = New System.Drawing.Size(84, 29)
        Me.txtDelNoteNumber.TabIndex = 41
        '
        'txtReference
        '
        Me.txtReference.BackColor = System.Drawing.SystemColors.Window
        Me.txtReference.Location = New System.Drawing.Point(342, 108)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReference.MaxLength = 90
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(148, 29)
        Me.txtReference.TabIndex = 31
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.Enabled = False
        Me.txtWarehouseName.Location = New System.Drawing.Point(197, 204)
        Me.txtWarehouseName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(252, 29)
        Me.txtWarehouseName.TabIndex = 50
        Me.txtWarehouseName.Text = "Universal Warehouse"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 620)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 25)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Total Garments:"
        '
        'FrmShopDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 1051)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdClearForm)
        Me.Controls.Add(Me.txtStockCode)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtWarehouseRef)
        Me.Controls.Add(Me.cmdAddItem)
        Me.Controls.Add(Me.txtQtyHangers)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtShopRef)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtShopName)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalGarments)
        Me.Controls.Add(Me.txtDelNoteNumber)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.txtWarehouseName)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrmShopDelivery"
        Me.Text = "FrmShopDelivery"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQty As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StockCodeDG As DataGridViewTextBoxColumn
    Friend WithEvents GarmentsDG As DataGridViewTextBoxColumn
    Friend WithEvents ValueCol As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Deliverlabel As ToolStripStatusLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdClearForm As Button
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtWarehouseRef As TextBox
    Friend WithEvents cmdAddItem As Button
    Friend WithEvents txtQtyHangers As TextBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtShopRef As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalGarments As TextBox
    Friend WithEvents txtDelNoteNumber As TextBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents Label5 As Label
End Class
