<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchaseOrder
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtHangers = New System.Windows.Forms.TextBox()
        Me.txtBoxes = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtQtyGarments = New System.Windows.Forms.TextBox()
        Me.cmdFindWarehouse = New System.Windows.Forms.Button()
        Me.cmdFindStockCode = New System.Windows.Forms.Button()
        Me.DGVStock = New System.Windows.Forms.DataGridView()
        Me.DGVSupplier = New System.Windows.Forms.DataGridView()
        Me.cmdFindSupplier = New System.Windows.Forms.Button()
        Me.txtNetCost = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DGVWarehouse = New System.Windows.Forms.DataGridView()
        Me.txtOurRef = New System.Windows.Forms.TextBox()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.txtSupplierInv = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtShipper = New System.Windows.Forms.TextBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.txtShipperInv = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.txtTotalGarments = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCommission = New System.Windows.Forms.TextBox()
        Me.txtDelCharges = New System.Windows.Forms.TextBox()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.txtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.txtSupplierRef = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(44, 529)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 25)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Qty Hangers"
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(62, 492)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 25)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Qty Boxes"
        Me.Label11.Visible = False
        '
        'txtHangers
        '
        Me.txtHangers.Location = New System.Drawing.Point(203, 529)
        Me.txtHangers.Margin = New System.Windows.Forms.Padding(6)
        Me.txtHangers.Name = "txtHangers"
        Me.txtHangers.Size = New System.Drawing.Size(180, 29)
        Me.txtHangers.TabIndex = 60
        Me.txtHangers.Visible = False
        '
        'txtBoxes
        '
        Me.txtBoxes.Location = New System.Drawing.Point(203, 492)
        Me.txtBoxes.Margin = New System.Windows.Forms.Padding(6)
        Me.txtBoxes.Name = "txtBoxes"
        Me.txtBoxes.Size = New System.Drawing.Size(180, 29)
        Me.txtBoxes.TabIndex = 59
        Me.txtBoxes.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(256, 49)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(152, 29)
        Me.CheckBox2.TabIndex = 70
        Me.CheckBox2.Text = "Consessions"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.Location = New System.Drawing.Point(203, 221)
        Me.txtWarehouseName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(241, 29)
        Me.txtWarehouseName.TabIndex = 72
        Me.txtWarehouseName.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(45, 49)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(169, 29)
        Me.CheckBox1.TabIndex = 69
        Me.CheckBox1.Text = "Direct To Shop"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtQtyGarments
        '
        Me.txtQtyGarments.Location = New System.Drawing.Point(203, 398)
        Me.txtQtyGarments.Margin = New System.Windows.Forms.Padding(6)
        Me.txtQtyGarments.Name = "txtQtyGarments"
        Me.txtQtyGarments.Size = New System.Drawing.Size(187, 29)
        Me.txtQtyGarments.TabIndex = 56
        Me.txtQtyGarments.Text = "0"
        '
        'cmdFindWarehouse
        '
        Me.cmdFindWarehouse.Location = New System.Drawing.Point(405, 169)
        Me.cmdFindWarehouse.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindWarehouse.Name = "cmdFindWarehouse"
        Me.cmdFindWarehouse.Size = New System.Drawing.Size(50, 42)
        Me.cmdFindWarehouse.TabIndex = 96
        Me.cmdFindWarehouse.Text = "..."
        Me.cmdFindWarehouse.UseVisualStyleBackColor = True
        Me.cmdFindWarehouse.Visible = False
        '
        'cmdFindStockCode
        '
        Me.cmdFindStockCode.Location = New System.Drawing.Point(405, 356)
        Me.cmdFindStockCode.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindStockCode.Name = "cmdFindStockCode"
        Me.cmdFindStockCode.Size = New System.Drawing.Size(50, 42)
        Me.cmdFindStockCode.TabIndex = 99
        Me.cmdFindStockCode.Text = "..."
        Me.cmdFindStockCode.UseVisualStyleBackColor = True
        Me.cmdFindStockCode.Visible = False
        '
        'DGVStock
        '
        Me.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStock.Location = New System.Drawing.Point(45, 631)
        Me.DGVStock.Margin = New System.Windows.Forms.Padding(6)
        Me.DGVStock.Name = "DGVStock"
        Me.DGVStock.RowHeadersWidth = 72
        Me.DGVStock.Size = New System.Drawing.Size(440, 277)
        Me.DGVStock.TabIndex = 91
        Me.DGVStock.Visible = False
        '
        'DGVSupplier
        '
        Me.DGVSupplier.AllowUserToAddRows = False
        Me.DGVSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSupplier.Location = New System.Drawing.Point(108, 631)
        Me.DGVSupplier.Margin = New System.Windows.Forms.Padding(6)
        Me.DGVSupplier.Name = "DGVSupplier"
        Me.DGVSupplier.RowHeadersVisible = False
        Me.DGVSupplier.RowHeadersWidth = 72
        Me.DGVSupplier.Size = New System.Drawing.Size(381, 306)
        Me.DGVSupplier.TabIndex = 90
        Me.DGVSupplier.Visible = False
        '
        'cmdFindSupplier
        '
        Me.cmdFindSupplier.Location = New System.Drawing.Point(405, 92)
        Me.cmdFindSupplier.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindSupplier.Name = "cmdFindSupplier"
        Me.cmdFindSupplier.Size = New System.Drawing.Size(50, 42)
        Me.cmdFindSupplier.TabIndex = 93
        Me.cmdFindSupplier.Text = "..."
        Me.cmdFindSupplier.UseVisualStyleBackColor = True
        Me.cmdFindSupplier.Visible = False
        '
        'txtNetCost
        '
        Me.txtNetCost.Location = New System.Drawing.Point(203, 442)
        Me.txtNetCost.Margin = New System.Windows.Forms.Padding(6)
        Me.txtNetCost.Name = "txtNetCost"
        Me.txtNetCost.Size = New System.Drawing.Size(187, 29)
        Me.txtNetCost.TabIndex = 57
        Me.txtNetCost.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(29, 99)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(124, 25)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Supplier Ref:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label25.Location = New System.Drawing.Point(29, 437)
        Me.Label25.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 25)
        Me.Label25.TabIndex = 86
        Me.Label25.Text = "Net Cost"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(29, 138)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 25)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Supplier Name:"
        '
        'DGVWarehouse
        '
        Me.DGVWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVWarehouse.Location = New System.Drawing.Point(49, 612)
        Me.DGVWarehouse.Margin = New System.Windows.Forms.Padding(6)
        Me.DGVWarehouse.Name = "DGVWarehouse"
        Me.DGVWarehouse.RowHeadersWidth = 72
        Me.DGVWarehouse.Size = New System.Drawing.Size(440, 277)
        Me.DGVWarehouse.TabIndex = 89
        Me.DGVWarehouse.Visible = False
        '
        'txtOurRef
        '
        Me.txtOurRef.Location = New System.Drawing.Point(203, 265)
        Me.txtOurRef.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOurRef.Name = "txtOurRef"
        Me.txtOurRef.Size = New System.Drawing.Size(187, 29)
        Me.txtOurRef.TabIndex = 68
        Me.txtOurRef.Visible = False
        '
        'txtStockCode
        '
        Me.txtStockCode.Location = New System.Drawing.Point(203, 359)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(187, 29)
        Me.txtStockCode.TabIndex = 55
        '
        'txtSupplierInv
        '
        Me.txtSupplierInv.Location = New System.Drawing.Point(661, 232)
        Me.txtSupplierInv.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSupplierInv.MaxLength = 60
        Me.txtSupplierInv.Name = "txtSupplierInv"
        Me.txtSupplierInv.Size = New System.Drawing.Size(219, 29)
        Me.txtSupplierInv.TabIndex = 63
        Me.txtSupplierInv.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(29, 317)
        Me.Label26.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(138, 25)
        Me.Label26.TabIndex = 83
        Me.Label26.Text = "Delivery Type:"
        Me.Label26.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(29, 404)
        Me.Label22.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(133, 25)
        Me.Label22.TabIndex = 85
        Me.Label22.Text = "Qty Garments"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label21.Location = New System.Drawing.Point(29, 365)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 25)
        Me.Label21.TabIndex = 84
        Me.Label21.Text = "Stock Code"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Expected", "Confirmed"})
        Me.cboType.Location = New System.Drawing.Point(203, 309)
        Me.cboType.Margin = New System.Windows.Forms.Padding(6)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(187, 32)
        Me.cboType.TabIndex = 73
        Me.cboType.Visible = False
        '
        'txtShipper
        '
        Me.txtShipper.Location = New System.Drawing.Point(661, 143)
        Me.txtShipper.Margin = New System.Windows.Forms.Padding(6)
        Me.txtShipper.MaxLength = 60
        Me.txtShipper.Name = "txtShipper"
        Me.txtShipper.Size = New System.Drawing.Size(219, 29)
        Me.txtShipper.TabIndex = 61
        Me.txtShipper.Text = "0"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(559, 612)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(138, 42)
        Me.cmdOK.TabIndex = 66
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'txtShipperInv
        '
        Me.txtShipperInv.Location = New System.Drawing.Point(661, 188)
        Me.txtShipperInv.Margin = New System.Windows.Forms.Padding(6)
        Me.txtShipperInv.MaxLength = 60
        Me.txtShipperInv.Name = "txtShipperInv"
        Me.txtShipperInv.Size = New System.Drawing.Size(219, 29)
        Me.txtShipperInv.TabIndex = 62
        Me.txtShipperInv.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Location = New System.Drawing.Point(29, 188)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 25)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Warehouse Ref:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(705, 612)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(138, 42)
        Me.cmdCancel.TabIndex = 67
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(661, 55)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 29)
        Me.DateTimePicker1.TabIndex = 58
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(29, 226)
        Me.Label20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(177, 25)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "Warehouse Name:"
        '
        'txtOrderID
        '
        Me.txtOrderID.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtOrderID.Location = New System.Drawing.Point(661, 99)
        Me.txtOrderID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(219, 29)
        Me.txtOrderID.TabIndex = 74
        Me.txtOrderID.TabStop = False
        '
        'txtTotalGarments
        '
        Me.txtTotalGarments.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotalGarments.Location = New System.Drawing.Point(661, 549)
        Me.txtTotalGarments.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTotalGarments.Name = "txtTotalGarments"
        Me.txtTotalGarments.Size = New System.Drawing.Size(180, 29)
        Me.txtTotalGarments.TabIndex = 77
        Me.txtTotalGarments.TabStop = False
        Me.txtTotalGarments.Text = "0"
        Me.txtTotalGarments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotal.Location = New System.Drawing.Point(661, 492)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(180, 29)
        Me.txtTotal.TabIndex = 76
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "£0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCommission
        '
        Me.txtCommission.Location = New System.Drawing.Point(661, 448)
        Me.txtCommission.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCommission.Name = "txtCommission"
        Me.txtCommission.Size = New System.Drawing.Size(180, 29)
        Me.txtCommission.TabIndex = 65
        Me.txtCommission.Text = "£0.00"
        Me.txtCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDelCharges
        '
        Me.txtDelCharges.Location = New System.Drawing.Point(661, 400)
        Me.txtDelCharges.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDelCharges.Name = "txtDelCharges"
        Me.txtDelCharges.Size = New System.Drawing.Size(180, 29)
        Me.txtDelCharges.TabIndex = 64
        Me.txtDelCharges.Text = "£0.00"
        Me.txtDelCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotalNet.Location = New System.Drawing.Point(661, 346)
        Me.txtTotalNet.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.Size = New System.Drawing.Size(180, 29)
        Me.txtTotalNet.TabIndex = 75
        Me.txtTotalNet.TabStop = False
        Me.txtTotalNet.Text = "£0.00"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWarehouseRef
        '
        Me.txtWarehouseRef.Location = New System.Drawing.Point(203, 182)
        Me.txtWarehouseRef.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWarehouseRef.MaxLength = 8
        Me.txtWarehouseRef.Name = "txtWarehouseRef"
        Me.txtWarehouseRef.Size = New System.Drawing.Size(187, 29)
        Me.txtWarehouseRef.TabIndex = 54
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(203, 132)
        Me.txtSupplierName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(187, 29)
        Me.txtSupplierName.TabIndex = 71
        Me.txtSupplierName.TabStop = False
        '
        'txtSupplierRef
        '
        Me.txtSupplierRef.Location = New System.Drawing.Point(203, 95)
        Me.txtSupplierRef.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSupplierRef.MaxLength = 8
        Me.txtSupplierRef.Name = "txtSupplierRef"
        Me.txtSupplierRef.Size = New System.Drawing.Size(187, 29)
        Me.txtSupplierRef.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(458, 60)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 25)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "Delivery Date:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(458, 105)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 25)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Order No:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(500, 555)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 25)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Total Garments:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(588, 505)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 25)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(531, 455)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 25)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Commission:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(485, 411)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 25)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Delivery Charges:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(601, 359)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 25)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Net:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(638, 285)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 32)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Order Totals:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(458, 237)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 25)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Suppliers Invoice No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(458, 193)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 25)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Shipper Invoice No:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 271)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Our Ref:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(458, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Shipper:"
        '
        'FrmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 1177)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtHangers)
        Me.Controls.Add(Me.txtBoxes)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.txtWarehouseName)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtQtyGarments)
        Me.Controls.Add(Me.cmdFindWarehouse)
        Me.Controls.Add(Me.cmdFindStockCode)
        Me.Controls.Add(Me.DGVStock)
        Me.Controls.Add(Me.DGVSupplier)
        Me.Controls.Add(Me.cmdFindSupplier)
        Me.Controls.Add(Me.txtNetCost)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DGVWarehouse)
        Me.Controls.Add(Me.txtOurRef)
        Me.Controls.Add(Me.txtStockCode)
        Me.Controls.Add(Me.txtSupplierInv)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtShipper)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.txtShipperInv)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.txtTotalGarments)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtCommission)
        Me.Controls.Add(Me.txtDelCharges)
        Me.Controls.Add(Me.txtTotalNet)
        Me.Controls.Add(Me.txtWarehouseRef)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.txtSupplierRef)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmPurchaseOrder"
        Me.Text = "FrmPurchaseOrder"
        CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtHangers As TextBox
    Friend WithEvents txtBoxes As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtQtyGarments As TextBox
    Friend WithEvents cmdFindWarehouse As Button
    Friend WithEvents cmdFindStockCode As Button
    Friend WithEvents DGVStock As DataGridView
    Friend WithEvents DGVSupplier As DataGridView
    Friend WithEvents cmdFindSupplier As Button
    Friend WithEvents txtNetCost As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DGVWarehouse As DataGridView
    Friend WithEvents txtOurRef As TextBox
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents txtSupplierInv As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtShipper As TextBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents txtShipperInv As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cmdCancel As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents txtTotalGarments As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCommission As TextBox
    Friend WithEvents txtDelCharges As TextBox
    Friend WithEvents txtTotalNet As TextBox
    Friend WithEvents txtWarehouseRef As TextBox
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents txtSupplierRef As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
