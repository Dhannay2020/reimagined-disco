<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShopSale
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TxtStockCode = New System.Windows.Forms.TextBox()
        Me.cmdDelToGrid = New System.Windows.Forms.Button()
        Me.cmdAddToGrid = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSoldToDate = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCurrentQty = New System.Windows.Forms.TextBox()
        Me.txtDelivered = New System.Windows.Forms.TextBox()
        Me.lblShopName = New System.Windows.Forms.Label()
        Me.txtNetSale = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalDelivered = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalSold = New System.Windows.Forms.TextBox()
        Me.txtTotalCurrQty = New System.Windows.Forms.TextBox()
        Me.txtShopRef = New System.Windows.Forms.TextBox()
        Me.txtTotalGarments = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.txtVATRate = New System.Windows.Forms.TextBox()
        Me.txtSalesID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(77, 142)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(203, 29)
        Me.CheckBox1.TabIndex = 81
        Me.CheckBox1.Text = "Enter A Zero Stock"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TxtStockCode
        '
        Me.TxtStockCode.Location = New System.Drawing.Point(374, 110)
        Me.TxtStockCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockCode.Name = "TxtStockCode"
        Me.TxtStockCode.Size = New System.Drawing.Size(148, 29)
        Me.TxtStockCode.TabIndex = 43
        '
        'cmdDelToGrid
        '
        Me.cmdDelToGrid.Location = New System.Drawing.Point(1070, 142)
        Me.cmdDelToGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDelToGrid.Name = "cmdDelToGrid"
        Me.cmdDelToGrid.Size = New System.Drawing.Size(112, 28)
        Me.cmdDelToGrid.TabIndex = 47
        Me.cmdDelToGrid.Text = "Delete"
        Me.cmdDelToGrid.UseVisualStyleBackColor = True
        '
        'cmdAddToGrid
        '
        Me.cmdAddToGrid.Location = New System.Drawing.Point(949, 142)
        Me.cmdAddToGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAddToGrid.Name = "cmdAddToGrid"
        Me.cmdAddToGrid.Size = New System.Drawing.Size(112, 28)
        Me.cmdAddToGrid.TabIndex = 46
        Me.cmdAddToGrid.Text = "Add"
        Me.cmdAddToGrid.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Location = New System.Drawing.Point(1068, 547)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(112, 28)
        Me.cmdCancel.TabIndex = 50
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Location = New System.Drawing.Point(946, 547)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(112, 28)
        Me.cmdOK.TabIndex = 49
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(664, 93)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 25)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "Sold"
        '
        'txtSoldToDate
        '
        Me.txtSoldToDate.Location = New System.Drawing.Point(664, 110)
        Me.txtSoldToDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoldToDate.Name = "txtSoldToDate"
        Me.txtSoldToDate.Size = New System.Drawing.Size(82, 29)
        Me.txtSoldToDate.TabIndex = 74
        Me.txtSoldToDate.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(542, 90)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 25)
        Me.Label19.TabIndex = 77
        Me.Label19.Text = "Delivered"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(768, 93)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 25)
        Me.Label18.TabIndex = 72
        Me.Label18.Text = "Current Qty"
        '
        'txtCurrentQty
        '
        Me.txtCurrentQty.Location = New System.Drawing.Point(768, 110)
        Me.txtCurrentQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentQty.Name = "txtCurrentQty"
        Me.txtCurrentQty.Size = New System.Drawing.Size(128, 29)
        Me.txtCurrentQty.TabIndex = 73
        Me.txtCurrentQty.TabStop = False
        '
        'txtDelivered
        '
        Me.txtDelivered.Location = New System.Drawing.Point(534, 110)
        Me.txtDelivered.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDelivered.Name = "txtDelivered"
        Me.txtDelivered.Size = New System.Drawing.Size(110, 29)
        Me.txtDelivered.TabIndex = 76
        Me.txtDelivered.TabStop = False
        '
        'lblShopName
        '
        Me.lblShopName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShopName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblShopName.Location = New System.Drawing.Point(644, 41)
        Me.lblShopName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblShopName.Name = "lblShopName"
        Me.lblShopName.Size = New System.Drawing.Size(336, 30)
        Me.lblShopName.TabIndex = 80
        '
        'txtNetSale
        '
        Me.txtNetSale.Location = New System.Drawing.Point(1045, 110)
        Me.txtNetSale.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNetSale.Name = "txtNetSale"
        Me.txtNetSale.Size = New System.Drawing.Size(136, 29)
        Me.txtNetSale.TabIndex = 45
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(912, 110)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(122, 29)
        Me.txtQty.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1045, 93)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 25)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Net Sale:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(912, 93)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 25)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Quantity"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(294, 303)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 25)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "%"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(356, 178)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.Size = New System.Drawing.Size(831, 329)
        Me.DataGridView1.TabIndex = 48
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 85)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(176, 29)
        Me.DateTimePicker1.TabIndex = 41
        '
        'txtTotalDelivered
        '
        Me.txtTotalDelivered.Enabled = False
        Me.txtTotalDelivered.Location = New System.Drawing.Point(515, 515)
        Me.txtTotalDelivered.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalDelivered.Name = "txtTotalDelivered"
        Me.txtTotalDelivered.Size = New System.Drawing.Size(88, 29)
        Me.txtTotalDelivered.TabIndex = 67
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(380, 90)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 25)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Stock Code:"
        '
        'txtTotalSold
        '
        Me.txtTotalSold.Enabled = False
        Me.txtTotalSold.Location = New System.Drawing.Point(644, 515)
        Me.txtTotalSold.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalSold.Name = "txtTotalSold"
        Me.txtTotalSold.Size = New System.Drawing.Size(95, 29)
        Me.txtTotalSold.TabIndex = 69
        '
        'txtTotalCurrQty
        '
        Me.txtTotalCurrQty.Enabled = False
        Me.txtTotalCurrQty.Location = New System.Drawing.Point(763, 515)
        Me.txtTotalCurrQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalCurrQty.Name = "txtTotalCurrQty"
        Me.txtTotalCurrQty.Size = New System.Drawing.Size(89, 29)
        Me.txtTotalCurrQty.TabIndex = 68
        '
        'txtShopRef
        '
        Me.txtShopRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtShopRef.Location = New System.Drawing.Point(476, 41)
        Me.txtShopRef.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShopRef.Name = "txtShopRef"
        Me.txtShopRef.Size = New System.Drawing.Size(84, 29)
        Me.txtShopRef.TabIndex = 42
        '
        'txtTotalGarments
        '
        Me.txtTotalGarments.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTotalGarments.Location = New System.Drawing.Point(166, 396)
        Me.txtTotalGarments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalGarments.Name = "txtTotalGarments"
        Me.txtTotalGarments.Size = New System.Drawing.Size(148, 29)
        Me.txtTotalGarments.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(410, 515)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 25)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Totals:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTotal.Location = New System.Drawing.Point(166, 364)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(148, 29)
        Me.txtTotal.TabIndex = 63
        Me.txtTotal.TabStop = False
        '
        'txtVAT
        '
        Me.txtVAT.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtVAT.Location = New System.Drawing.Point(166, 332)
        Me.txtVAT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(148, 29)
        Me.txtVAT.TabIndex = 60
        Me.txtVAT.TabStop = False
        '
        'txtNet
        '
        Me.txtNet.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNet.Location = New System.Drawing.Point(166, 268)
        Me.txtNet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNet.Name = "txtNet"
        Me.txtNet.Size = New System.Drawing.Size(148, 29)
        Me.txtNet.TabIndex = 57
        Me.txtNet.TabStop = False
        '
        'txtVATRate
        '
        Me.txtVATRate.Location = New System.Drawing.Point(166, 300)
        Me.txtVATRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVATRate.Name = "txtVATRate"
        Me.txtVATRate.Size = New System.Drawing.Size(116, 29)
        Me.txtVATRate.TabIndex = 53
        '
        'txtSalesID
        '
        Me.txtSalesID.BackColor = System.Drawing.Color.White
        Me.txtSalesID.Location = New System.Drawing.Point(166, 41)
        Me.txtSalesID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalesID.Name = "txtSalesID"
        Me.txtSalesID.Size = New System.Drawing.Size(148, 29)
        Me.txtSalesID.TabIndex = 51
        Me.txtSalesID.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label10.Location = New System.Drawing.Point(380, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 25)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Shop Ref:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 399)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 25)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Total Garments:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 367)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 25)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(104, 335)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 25)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "VAT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 271)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 25)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Net:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(80, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 32)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Sales Totals:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 303)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "VAT Rate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 25)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Transaction Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Sales ID:"
        '
        'FrmShopSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1377, 873)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtStockCode)
        Me.Controls.Add(Me.cmdDelToGrid)
        Me.Controls.Add(Me.cmdAddToGrid)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtSoldToDate)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtCurrentQty)
        Me.Controls.Add(Me.txtDelivered)
        Me.Controls.Add(Me.lblShopName)
        Me.Controls.Add(Me.txtNetSale)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtTotalDelivered)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalSold)
        Me.Controls.Add(Me.txtTotalCurrQty)
        Me.Controls.Add(Me.txtShopRef)
        Me.Controls.Add(Me.txtTotalGarments)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtVAT)
        Me.Controls.Add(Me.txtNet)
        Me.Controls.Add(Me.txtVATRate)
        Me.Controls.Add(Me.txtSalesID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmShopSale"
        Me.Text = "FrmShopSale"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TxtStockCode As TextBox
    Friend WithEvents cmdDelToGrid As Button
    Friend WithEvents cmdAddToGrid As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtSoldToDate As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCurrentQty As TextBox
    Friend WithEvents txtDelivered As TextBox
    Friend WithEvents lblShopName As Label
    Friend WithEvents txtNetSale As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtTotalDelivered As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalSold As TextBox
    Friend WithEvents txtTotalCurrQty As TextBox
    Friend WithEvents txtShopRef As TextBox
    Friend WithEvents txtTotalGarments As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtNet As TextBox
    Friend WithEvents txtVATRate As TextBox
    Friend WithEvents txtSalesID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
