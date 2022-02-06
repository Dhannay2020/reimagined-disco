<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShopTransfer
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
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFromShopType = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvFromShops = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvShopStock = New System.Windows.Forms.DataGridView()
        Me.dgvToShops = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtToShopType = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdDeleteFromGrid = New System.Windows.Forms.Button()
        Me.cmdAddToGrid = New System.Windows.Forms.Button()
        Me.txtTotalTransferFrom = New System.Windows.Forms.TextBox()
        Me.txtTotalTransferTo = New System.Windows.Forms.TextBox()
        Me.txtTransferToQty = New System.Windows.Forms.TextBox()
        Me.txtTransferFromQty = New System.Windows.Forms.TextBox()
        Me.txtCurrentQty = New System.Windows.Forms.TextBox()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.txtToShopName = New System.Windows.Forms.TextBox()
        Me.txtToShopRef = New System.Windows.Forms.TextBox()
        Me.txtFromShopName = New System.Windows.Forms.TextBox()
        Me.txtTFNote = New System.Windows.Forms.TextBox()
        Me.cmdFindStock = New System.Windows.Forms.Button()
        Me.cmdFindShopTo = New System.Windows.Forms.Button()
        Me.cmdFindShopFrom = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtFromShopRef = New System.Windows.Forms.TextBox()
        CType(Me.dgvFromShops, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvShopStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvToShops, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column4
        '
        Me.Column4.HeaderText = "SMTIID"
        Me.Column4.MinimumWidth = 9
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Current Qty"
        Me.Column6.MinimumWidth = 9
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Qty"
        Me.Column7.MinimumWidth = 9
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "To Qty"
        Me.Column8.MinimumWidth = 9
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "Stock Code"
        Me.Column5.MinimumWidth = 9
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'txtFromShopType
        '
        Me.txtFromShopType.Location = New System.Drawing.Point(1518, 277)
        Me.txtFromShopType.Margin = New System.Windows.Forms.Padding(6)
        Me.txtFromShopType.Name = "txtFromShopType"
        Me.txtFromShopType.Size = New System.Drawing.Size(180, 29)
        Me.txtFromShopType.TabIndex = 105
        Me.txtFromShopType.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1518, 523)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(180, 29)
        Me.TextBox4.TabIndex = 103
        Me.TextBox4.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1518, 571)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(180, 29)
        Me.TextBox3.TabIndex = 102
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1518, 619)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 29)
        Me.TextBox2.TabIndex = 101
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1518, 667)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 29)
        Me.TextBox1.TabIndex = 100
        Me.TextBox1.Visible = False
        '
        'dgvFromShops
        '
        Me.dgvFromShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFromShops.Location = New System.Drawing.Point(402, 416)
        Me.dgvFromShops.Margin = New System.Windows.Forms.Padding(6)
        Me.dgvFromShops.Name = "dgvFromShops"
        Me.dgvFromShops.RowHeadersWidth = 72
        Me.dgvFromShops.Size = New System.Drawing.Size(440, 277)
        Me.dgvFromShops.TabIndex = 97
        Me.dgvFromShops.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(585, 120)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(301, 29)
        Me.DateTimePicker1.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(1548, 416)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 25)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Transfer To Qty:"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(706, 273)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 25)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Transfer Qty:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(519, 273)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 25)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Current Qty:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(136, 273)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Stock Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(482, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(132, 222)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "To Shop:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(132, 174)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "From Shop"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 126)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "TF Note No:"
        '
        'dgvShopStock
        '
        Me.dgvShopStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShopStock.Location = New System.Drawing.Point(402, 393)
        Me.dgvShopStock.Margin = New System.Windows.Forms.Padding(6)
        Me.dgvShopStock.Name = "dgvShopStock"
        Me.dgvShopStock.RowHeadersWidth = 72
        Me.dgvShopStock.Size = New System.Drawing.Size(440, 277)
        Me.dgvShopStock.TabIndex = 99
        Me.dgvShopStock.Visible = False
        '
        'dgvToShops
        '
        Me.dgvToShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvToShops.Location = New System.Drawing.Point(402, 393)
        Me.dgvToShops.Margin = New System.Windows.Forms.Padding(6)
        Me.dgvToShops.Name = "dgvToShops"
        Me.dgvToShops.RowHeadersWidth = 72
        Me.dgvToShops.Size = New System.Drawing.Size(440, 277)
        Me.dgvToShops.TabIndex = 98
        Me.dgvToShops.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "SMTOID"
        Me.Column3.MinimumWidth = 9
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'txtToShopType
        '
        Me.txtToShopType.Location = New System.Drawing.Point(1518, 331)
        Me.txtToShopType.Margin = New System.Windows.Forms.Padding(6)
        Me.txtToShopType.Name = "txtToShopType"
        Me.txtToShopType.Size = New System.Drawing.Size(180, 29)
        Me.txtToShopType.TabIndex = 104
        Me.txtToShopType.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(147, 360)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.Size = New System.Drawing.Size(876, 456)
        Me.DataGridView1.TabIndex = 88
        '
        'Column1
        '
        Me.Column1.HeaderText = "LineID"
        Me.Column1.MinimumWidth = 9
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "TransferID"
        Me.Column2.MinimumWidth = 9
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'cmdDeleteFromGrid
        '
        Me.cmdDeleteFromGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteFromGrid.Location = New System.Drawing.Point(974, 303)
        Me.cmdDeleteFromGrid.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdDeleteFromGrid.Name = "cmdDeleteFromGrid"
        Me.cmdDeleteFromGrid.Size = New System.Drawing.Size(50, 42)
        Me.cmdDeleteFromGrid.TabIndex = 76
        Me.cmdDeleteFromGrid.Text = "-"
        Me.cmdDeleteFromGrid.UseVisualStyleBackColor = True
        '
        'cmdAddToGrid
        '
        Me.cmdAddToGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddToGrid.Location = New System.Drawing.Point(902, 303)
        Me.cmdAddToGrid.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdAddToGrid.Name = "cmdAddToGrid"
        Me.cmdAddToGrid.Size = New System.Drawing.Size(61, 42)
        Me.cmdAddToGrid.TabIndex = 75
        Me.cmdAddToGrid.Text = "+"
        Me.cmdAddToGrid.UseVisualStyleBackColor = True
        '
        'txtTotalTransferFrom
        '
        Me.txtTotalTransferFrom.Location = New System.Drawing.Point(831, 827)
        Me.txtTotalTransferFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTotalTransferFrom.Name = "txtTotalTransferFrom"
        Me.txtTotalTransferFrom.Size = New System.Drawing.Size(88, 29)
        Me.txtTotalTransferFrom.TabIndex = 96
        '
        'txtTotalTransferTo
        '
        Me.txtTotalTransferTo.Location = New System.Drawing.Point(933, 827)
        Me.txtTotalTransferTo.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTotalTransferTo.Name = "txtTotalTransferTo"
        Me.txtTotalTransferTo.Size = New System.Drawing.Size(87, 29)
        Me.txtTotalTransferTo.TabIndex = 95
        '
        'txtTransferToQty
        '
        Me.txtTransferToQty.Location = New System.Drawing.Point(1518, 445)
        Me.txtTransferToQty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTransferToQty.Name = "txtTransferToQty"
        Me.txtTransferToQty.Size = New System.Drawing.Size(180, 29)
        Me.txtTransferToQty.TabIndex = 74
        Me.txtTransferToQty.Visible = False
        '
        'txtTransferFromQty
        '
        Me.txtTransferFromQty.Location = New System.Drawing.Point(708, 312)
        Me.txtTransferFromQty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTransferFromQty.Name = "txtTransferFromQty"
        Me.txtTransferFromQty.Size = New System.Drawing.Size(180, 29)
        Me.txtTransferFromQty.TabIndex = 73
        '
        'txtCurrentQty
        '
        Me.txtCurrentQty.Location = New System.Drawing.Point(514, 312)
        Me.txtCurrentQty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCurrentQty.Name = "txtCurrentQty"
        Me.txtCurrentQty.Size = New System.Drawing.Size(180, 29)
        Me.txtCurrentQty.TabIndex = 94
        '
        'txtStockCode
        '
        Me.txtStockCode.Location = New System.Drawing.Point(129, 312)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(371, 29)
        Me.txtStockCode.TabIndex = 72
        '
        'txtToShopName
        '
        Me.txtToShopName.Location = New System.Drawing.Point(457, 216)
        Me.txtToShopName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtToShopName.Name = "txtToShopName"
        Me.txtToShopName.Size = New System.Drawing.Size(429, 29)
        Me.txtToShopName.TabIndex = 93
        Me.txtToShopName.TabStop = False
        '
        'txtToShopRef
        '
        Me.txtToShopRef.Location = New System.Drawing.Point(264, 216)
        Me.txtToShopRef.Margin = New System.Windows.Forms.Padding(6)
        Me.txtToShopRef.MaxLength = 8
        Me.txtToShopRef.Name = "txtToShopRef"
        Me.txtToShopRef.Size = New System.Drawing.Size(180, 29)
        Me.txtToShopRef.TabIndex = 71
        '
        'txtFromShopName
        '
        Me.txtFromShopName.Location = New System.Drawing.Point(459, 168)
        Me.txtFromShopName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtFromShopName.Name = "txtFromShopName"
        Me.txtFromShopName.Size = New System.Drawing.Size(428, 29)
        Me.txtFromShopName.TabIndex = 92
        Me.txtFromShopName.TabStop = False
        '
        'txtTFNote
        '
        Me.txtTFNote.Location = New System.Drawing.Point(264, 120)
        Me.txtTFNote.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTFNote.MaxLength = 30
        Me.txtTFNote.Name = "txtTFNote"
        Me.txtTFNote.Size = New System.Drawing.Size(180, 29)
        Me.txtTFNote.TabIndex = 68
        '
        'cmdFindStock
        '
        Me.cmdFindStock.Location = New System.Drawing.Point(1672, 715)
        Me.cmdFindStock.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindStock.Name = "cmdFindStock"
        Me.cmdFindStock.Size = New System.Drawing.Size(57, 42)
        Me.cmdFindStock.TabIndex = 91
        Me.cmdFindStock.Text = "..."
        Me.cmdFindStock.UseVisualStyleBackColor = True
        Me.cmdFindStock.Visible = False
        '
        'cmdFindShopTo
        '
        Me.cmdFindShopTo.Location = New System.Drawing.Point(1423, 327)
        Me.cmdFindShopTo.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindShopTo.Name = "cmdFindShopTo"
        Me.cmdFindShopTo.Size = New System.Drawing.Size(44, 42)
        Me.cmdFindShopTo.TabIndex = 90
        Me.cmdFindShopTo.Text = "..."
        Me.cmdFindShopTo.UseVisualStyleBackColor = True
        Me.cmdFindShopTo.Visible = False
        '
        'cmdFindShopFrom
        '
        Me.cmdFindShopFrom.Location = New System.Drawing.Point(1423, 273)
        Me.cmdFindShopFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindShopFrom.Name = "cmdFindShopFrom"
        Me.cmdFindShopFrom.Size = New System.Drawing.Size(44, 42)
        Me.cmdFindShopFrom.TabIndex = 89
        Me.cmdFindShopFrom.Text = "..."
        Me.cmdFindShopFrom.UseVisualStyleBackColor = True
        Me.cmdFindShopFrom.Visible = False
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(886, 875)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(138, 42)
        Me.cmdClear.TabIndex = 79
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(589, 875)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(138, 42)
        Me.cmdOK.TabIndex = 77
        Me.cmdOK.Text = "Ok"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(737, 875)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(138, 42)
        Me.cmdCancel.TabIndex = 78
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtFromShopRef
        '
        Me.txtFromShopRef.Location = New System.Drawing.Point(264, 168)
        Me.txtFromShopRef.Margin = New System.Windows.Forms.Padding(6)
        Me.txtFromShopRef.MaxLength = 8
        Me.txtFromShopRef.Name = "txtFromShopRef"
        Me.txtFromShopRef.Size = New System.Drawing.Size(180, 29)
        Me.txtFromShopRef.TabIndex = 70
        '
        'FrmShopTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2538, 1514)
        Me.Controls.Add(Me.txtFromShopType)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvFromShops)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvShopStock)
        Me.Controls.Add(Me.dgvToShops)
        Me.Controls.Add(Me.txtToShopType)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdDeleteFromGrid)
        Me.Controls.Add(Me.cmdAddToGrid)
        Me.Controls.Add(Me.txtTotalTransferFrom)
        Me.Controls.Add(Me.txtTotalTransferTo)
        Me.Controls.Add(Me.txtTransferToQty)
        Me.Controls.Add(Me.txtTransferFromQty)
        Me.Controls.Add(Me.txtCurrentQty)
        Me.Controls.Add(Me.txtStockCode)
        Me.Controls.Add(Me.txtToShopName)
        Me.Controls.Add(Me.txtToShopRef)
        Me.Controls.Add(Me.txtFromShopName)
        Me.Controls.Add(Me.txtTFNote)
        Me.Controls.Add(Me.cmdFindStock)
        Me.Controls.Add(Me.cmdFindShopTo)
        Me.Controls.Add(Me.cmdFindShopFrom)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtFromShopRef)
        Me.Name = "FrmShopTransfer"
        Me.Text = "FrmShopTransfer"
        CType(Me.dgvFromShops, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvShopStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvToShops, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtFromShopType As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvFromShops As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvShopStock As DataGridView
    Friend WithEvents dgvToShops As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txtToShopType As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents cmdDeleteFromGrid As Button
    Friend WithEvents cmdAddToGrid As Button
    Friend WithEvents txtTotalTransferFrom As TextBox
    Friend WithEvents txtTotalTransferTo As TextBox
    Friend WithEvents txtTransferToQty As TextBox
    Friend WithEvents txtTransferFromQty As TextBox
    Friend WithEvents txtCurrentQty As TextBox
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents txtToShopName As TextBox
    Friend WithEvents txtToShopRef As TextBox
    Friend WithEvents txtFromShopName As TextBox
    Friend WithEvents txtTFNote As TextBox
    Friend WithEvents cmdFindStock As Button
    Friend WithEvents cmdFindShopTo As Button
    Friend WithEvents cmdFindShopFrom As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents txtFromShopRef As TextBox
End Class
