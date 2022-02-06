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
        Me.Deliverlabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StockCodeDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarmentsDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValueCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.dgvShops = New System.Windows.Forms.DataGridView()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmdFindWarehouse = New System.Windows.Forms.Button()
        Me.cmdFindStockCode = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdFindSupplier = New System.Windows.Forms.Button()
        Me.cmdClearForm = New System.Windows.Forms.Button()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.cmdAddItem = New System.Windows.Forms.Button()
        Me.txtQtyHangers = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvShops, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQty
        '
        Me.txtQty.Enabled = False
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.Red
        Me.txtQty.Location = New System.Drawing.Point(293, 308)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(140, 33)
        Me.txtQty.TabIndex = 94
        '
        'Deliverlabel
        '
        Me.Deliverlabel.Name = "Deliverlabel"
        Me.Deliverlabel.Size = New System.Drawing.Size(208, 30)
        Me.Deliverlabel.Text = "ToolStripStatusLabel2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockCodeDG, Me.GarmentsDG, Me.ValueCol})
        Me.DataGridView1.Location = New System.Drawing.Point(27, 370)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.Size = New System.Drawing.Size(649, 415)
        Me.DataGridView1.TabIndex = 86
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(288, 278)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 25)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Warehouse Qty"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Deliverlabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1193)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 26, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1711, 39)
        Me.StatusStrip1.TabIndex = 92
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1113, 749)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 29)
        Me.TextBox1.TabIndex = 91
        Me.TextBox1.Visible = False
        '
        'dgvStock
        '
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Location = New System.Drawing.Point(955, 749)
        Me.dgvStock.Margin = New System.Windows.Forms.Padding(6)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.RowHeadersWidth = 72
        Me.dgvStock.Size = New System.Drawing.Size(440, 277)
        Me.dgvStock.TabIndex = 90
        Me.dgvStock.Visible = False
        '
        'dgvShops
        '
        Me.dgvShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShops.Location = New System.Drawing.Point(920, 749)
        Me.dgvShops.Margin = New System.Windows.Forms.Padding(6)
        Me.dgvShops.Name = "dgvShops"
        Me.dgvShops.RowHeadersWidth = 72
        Me.dgvShops.Size = New System.Drawing.Size(440, 277)
        Me.dgvShops.TabIndex = 89
        Me.dgvShops.Visible = False
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(1184, 1059)
        Me.TextBox24.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(180, 29)
        Me.TextBox24.TabIndex = 87
        Me.TextBox24.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label21.Location = New System.Drawing.Point(82, 274)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 25)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "Stock Code"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(442, 278)
        Me.Label22.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 25)
        Me.Label22.TabIndex = 82
        Me.Label22.Text = "Delivery Qty"
        '
        'cmdFindWarehouse
        '
        Me.cmdFindWarehouse.Enabled = False
        Me.cmdFindWarehouse.Location = New System.Drawing.Point(1072, 465)
        Me.cmdFindWarehouse.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindWarehouse.Name = "cmdFindWarehouse"
        Me.cmdFindWarehouse.Size = New System.Drawing.Size(50, 42)
        Me.cmdFindWarehouse.TabIndex = 85
        Me.cmdFindWarehouse.Text = "..."
        Me.cmdFindWarehouse.UseVisualStyleBackColor = True
        Me.cmdFindWarehouse.Visible = False
        '
        'cmdFindStockCode
        '
        Me.cmdFindStockCode.Location = New System.Drawing.Point(1179, 42)
        Me.cmdFindStockCode.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindStockCode.Name = "cmdFindStockCode"
        Me.cmdFindStockCode.Size = New System.Drawing.Size(62, 42)
        Me.cmdFindStockCode.TabIndex = 88
        Me.cmdFindStockCode.Text = "..."
        Me.cmdFindStockCode.UseVisualStyleBackColor = True
        Me.cmdFindStockCode.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1107, 843)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 25)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Needs coding"
        Me.Label7.Visible = False
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(631, 308)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(44, 42)
        Me.cmdClear.TabIndex = 62
        Me.cmdClear.Text = "-"
        Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdFindSupplier
        '
        Me.cmdFindSupplier.Enabled = False
        Me.cmdFindSupplier.Location = New System.Drawing.Point(1010, 343)
        Me.cmdFindSupplier.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindSupplier.Name = "cmdFindSupplier"
        Me.cmdFindSupplier.Size = New System.Drawing.Size(48, 42)
        Me.cmdFindSupplier.TabIndex = 84
        Me.cmdFindSupplier.Text = "..."
        Me.cmdFindSupplier.UseVisualStyleBackColor = True
        Me.cmdFindSupplier.Visible = False
        '
        'cmdClearForm
        '
        Me.cmdClearForm.Location = New System.Drawing.Point(539, 884)
        Me.cmdClearForm.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClearForm.Name = "cmdClearForm"
        Me.cmdClearForm.Size = New System.Drawing.Size(138, 42)
        Me.cmdClearForm.TabIndex = 65
        Me.cmdClearForm.Text = "Clear"
        Me.cmdClearForm.UseVisualStyleBackColor = True
        '
        'txtStockCode
        '
        Me.txtStockCode.Location = New System.Drawing.Point(27, 308)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(252, 29)
        Me.txtStockCode.TabIndex = 59
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(24, 110)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 25)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Shop Ref:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(238, 110)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 25)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "Shop Name:"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(242, 884)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(138, 42)
        Me.cmdAdd.TabIndex = 63
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtWarehouseRef
        '
        Me.txtWarehouseRef.Enabled = False
        Me.txtWarehouseRef.Location = New System.Drawing.Point(27, 212)
        Me.txtWarehouseRef.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWarehouseRef.Name = "txtWarehouseRef"
        Me.txtWarehouseRef.Size = New System.Drawing.Size(142, 29)
        Me.txtWarehouseRef.TabIndex = 67
        Me.txtWarehouseRef.Text = "uni"
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Location = New System.Drawing.Point(587, 308)
        Me.cmdAddItem.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(44, 42)
        Me.cmdAddItem.TabIndex = 61
        Me.cmdAddItem.Text = "+"
        Me.cmdAddItem.UseVisualStyleBackColor = True
        '
        'txtQtyHangers
        '
        Me.txtQtyHangers.Location = New System.Drawing.Point(447, 308)
        Me.txtQtyHangers.Margin = New System.Windows.Forms.Padding(6)
        Me.txtQtyHangers.Name = "txtQtyHangers"
        Me.txtQtyHangers.Size = New System.Drawing.Size(125, 29)
        Me.txtQtyHangers.TabIndex = 60
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(390, 884)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(138, 42)
        Me.cmdCancel.TabIndex = 64
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1149, 382)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 25)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Deliveries into Shops"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(251, 68)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(228, 29)
        Me.DateTimePicker1.TabIndex = 56
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.Enabled = False
        Me.txtWarehouseName.Location = New System.Drawing.Point(205, 212)
        Me.txtWarehouseName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(307, 29)
        Me.txtWarehouseName.TabIndex = 83
        Me.txtWarehouseName.Text = "Universal Warehouse"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 836)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 25)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Total Garments:"
        '
        'txtShopRef
        '
        Me.txtShopRef.Location = New System.Drawing.Point(31, 140)
        Me.txtShopRef.Margin = New System.Windows.Forms.Padding(6)
        Me.txtShopRef.MaxLength = 8
        Me.txtShopRef.Name = "txtShopRef"
        Me.txtShopRef.Size = New System.Drawing.Size(142, 29)
        Me.txtShopRef.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(332, 791)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 32)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Delivery Total:"
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(205, 140)
        Me.txtShopName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(446, 29)
        Me.txtShopName.TabIndex = 80
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Location = New System.Drawing.Point(26, 182)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 25)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "Warehouse Ref:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 25)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Delivery Note No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(246, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Delivery Date:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(222, 182)
        Me.Label20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(177, 25)
        Me.Label20.TabIndex = 79
        Me.Label20.Text = "Warehouse Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Record No:"
        '
        'txtTotalGarments
        '
        Me.txtTotalGarments.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotalGarments.Location = New System.Drawing.Point(405, 836)
        Me.txtTotalGarments.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTotalGarments.Name = "txtTotalGarments"
        Me.txtTotalGarments.Size = New System.Drawing.Size(180, 29)
        Me.txtTotalGarments.TabIndex = 68
        '
        'txtDelNoteNumber
        '
        Me.txtDelNoteNumber.Location = New System.Drawing.Point(27, 68)
        Me.txtDelNoteNumber.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDelNoteNumber.Name = "txtDelNoteNumber"
        Me.txtDelNoteNumber.Size = New System.Drawing.Size(180, 29)
        Me.txtDelNoteNumber.TabIndex = 66
        '
        'txtReference
        '
        Me.txtReference.BackColor = System.Drawing.SystemColors.Window
        Me.txtReference.Location = New System.Drawing.Point(493, 68)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(6)
        Me.txtReference.MaxLength = 90
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(180, 29)
        Me.txtReference.TabIndex = 57
        '
        'FrmShopDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1711, 1232)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvStock)
        Me.Controls.Add(Me.dgvShops)
        Me.Controls.Add(Me.TextBox24)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmdFindWarehouse)
        Me.Controls.Add(Me.cmdFindStockCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdFindSupplier)
        Me.Controls.Add(Me.cmdClearForm)
        Me.Controls.Add(Me.txtStockCode)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtWarehouseRef)
        Me.Controls.Add(Me.cmdAddItem)
        Me.Controls.Add(Me.txtQtyHangers)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtWarehouseName)
        Me.Controls.Add(Me.Label5)
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
        Me.Name = "FrmShopDelivery"
        Me.Text = "FrmShopDelivery"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvShops, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQty As TextBox
    Friend WithEvents Deliverlabel As ToolStripStatusLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StockCodeDG As DataGridViewTextBoxColumn
    Friend WithEvents GarmentsDG As DataGridViewTextBoxColumn
    Friend WithEvents ValueCol As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvStock As DataGridView
    Friend WithEvents dgvShops As DataGridView
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cmdFindWarehouse As Button
    Friend WithEvents cmdFindStockCode As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdFindSupplier As Button
    Friend WithEvents cmdClearForm As Button
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtWarehouseRef As TextBox
    Friend WithEvents cmdAddItem As Button
    Friend WithEvents txtQtyHangers As TextBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents Label5 As Label
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
End Class
