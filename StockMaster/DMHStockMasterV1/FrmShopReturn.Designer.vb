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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colStockCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTransQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtShopName = New System.Windows.Forms.TextBox()
        Me.txtCurrentQty = New System.Windows.Forms.TextBox()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.txtShopRef = New System.Windows.Forms.TextBox()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdClearGrid = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtTransferQty = New System.Windows.Forms.TextBox()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.txtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTransRef = New System.Windows.Forms.Label()
        Me.cmdFindWarehouse = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtLocationType1 = New System.Windows.Forms.TextBox()
        Me.txtMovementType = New System.Windows.Forms.TextBox()
        Me.txtMovementBoxes = New System.Windows.Forms.TextBox()
        Me.cmdFindStock = New System.Windows.Forms.Button()
        Me.txtLocationType2 = New System.Windows.Forms.TextBox()
        Me.txtBoxes = New System.Windows.Forms.TextBox()
        Me.cmdFindShop = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(432, 996)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(138, 42)
        Me.cmdCancel.TabIndex = 127
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(499, 140)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(201, 29)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Return To Supplier"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStockCode, Me.colTransQty})
        Me.DataGridView2.Location = New System.Drawing.Point(15, 528)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 72
        Me.DataGridView2.Size = New System.Drawing.Size(763, 277)
        Me.DataGridView2.TabIndex = 122
        '
        'colStockCode
        '
        Me.colStockCode.HeaderText = "Stock Code"
        Me.colStockCode.MinimumWidth = 9
        Me.colStockCode.Name = "colStockCode"
        Me.colStockCode.ReadOnly = True
        Me.colStockCode.Width = 175
        '
        'colTransQty
        '
        Me.colTransQty.HeaderText = "Qty"
        Me.colTransQty.MinimumWidth = 9
        Me.colTransQty.Name = "colTransQty"
        Me.colTransQty.ReadOnly = True
        Me.colTransQty.Width = 175
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(418, 35)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Location = New System.Drawing.Point(499, 30)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(244, 29)
        Me.DateTimePicker1.TabIndex = 12
        Me.DateTimePicker1.Value = New Date(2016, 2, 7, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(15, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(853, 251)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current"
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(499, 89)
        Me.txtShopName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(334, 29)
        Me.txtShopName.TabIndex = 90
        Me.txtShopName.TabStop = False
        '
        'txtCurrentQty
        '
        Me.txtCurrentQty.Location = New System.Drawing.Point(224, 188)
        Me.txtCurrentQty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCurrentQty.Name = "txtCurrentQty"
        Me.txtCurrentQty.Size = New System.Drawing.Size(180, 29)
        Me.txtCurrentQty.TabIndex = 4
        '
        'txtStockCode
        '
        Me.txtStockCode.Location = New System.Drawing.Point(224, 140)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(180, 29)
        Me.txtStockCode.TabIndex = 2
        '
        'txtShopRef
        '
        Me.txtShopRef.Location = New System.Drawing.Point(238, 96)
        Me.txtShopRef.Margin = New System.Windows.Forms.Padding(6)
        Me.txtShopRef.MaxLength = 8
        Me.txtShopRef.Name = "txtShopRef"
        Me.txtShopRef.Size = New System.Drawing.Size(180, 29)
        Me.txtShopRef.TabIndex = 1
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(224, 35)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(6)
        Me.txtReference.MaxLength = 50
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(180, 29)
        Me.txtReference.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(418, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Current Qty:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stock Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shop Ref:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reference:"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(1070, 640)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 72
        Me.DataGridView3.Size = New System.Drawing.Size(440, 277)
        Me.DataGridView3.TabIndex = 124
        Me.DataGridView3.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdClearGrid)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.txtTransferQty)
        Me.GroupBox2.Controls.Add(Me.txtWarehouseName)
        Me.GroupBox2.Controls.Add(Me.txtWarehouseRef)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 286)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(853, 225)
        Me.GroupBox2.TabIndex = 125
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Return To:"
        '
        'cmdClearGrid
        '
        Me.cmdClearGrid.Location = New System.Drawing.Point(570, 150)
        Me.cmdClearGrid.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClearGrid.Name = "cmdClearGrid"
        Me.cmdClearGrid.Size = New System.Drawing.Size(138, 42)
        Me.cmdClearGrid.TabIndex = 42
        Me.cmdClearGrid.Text = "Delete All"
        Me.cmdClearGrid.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(420, 150)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(138, 42)
        Me.cmdAdd.TabIndex = 41
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtTransferQty
        '
        Me.txtTransferQty.Location = New System.Drawing.Point(224, 150)
        Me.txtTransferQty.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTransferQty.Name = "txtTransferQty"
        Me.txtTransferQty.Size = New System.Drawing.Size(180, 29)
        Me.txtTransferQty.TabIndex = 1
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.Location = New System.Drawing.Point(224, 103)
        Me.txtWarehouseName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(536, 29)
        Me.txtWarehouseName.TabIndex = 40
        Me.txtWarehouseName.TabStop = False
        '
        'txtWarehouseRef
        '
        Me.txtWarehouseRef.Location = New System.Drawing.Point(224, 54)
        Me.txtWarehouseRef.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWarehouseRef.MaxLength = 8
        Me.txtWarehouseRef.Name = "txtWarehouseRef"
        Me.txtWarehouseRef.Size = New System.Drawing.Size(180, 29)
        Me.txtWarehouseRef.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 150)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 25)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Transfer Qty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 103)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Warehouse Ref:"
        '
        'lblTransRef
        '
        Me.lblTransRef.AutoSize = True
        Me.lblTransRef.Location = New System.Drawing.Point(1171, 540)
        Me.lblTransRef.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTransRef.Name = "lblTransRef"
        Me.lblTransRef.Size = New System.Drawing.Size(82, 25)
        Me.lblTransRef.TabIndex = 137
        Me.lblTransRef.Text = "Label11"
        Me.lblTransRef.Visible = False
        '
        'cmdFindWarehouse
        '
        Me.cmdFindWarehouse.Location = New System.Drawing.Point(1332, 536)
        Me.cmdFindWarehouse.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindWarehouse.Name = "cmdFindWarehouse"
        Me.cmdFindWarehouse.Size = New System.Drawing.Size(46, 42)
        Me.cmdFindWarehouse.TabIndex = 138
        Me.cmdFindWarehouse.Text = "..."
        Me.cmdFindWarehouse.UseVisualStyleBackColor = True
        Me.cmdFindWarehouse.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1141, 788)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 25)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Needs coding"
        Me.Label10.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1070, 928)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.Size = New System.Drawing.Size(440, 277)
        Me.DataGridView1.TabIndex = 121
        Me.DataGridView1.Visible = False
        '
        'txtLocationType1
        '
        Me.txtLocationType1.Location = New System.Drawing.Point(918, 1234)
        Me.txtLocationType1.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLocationType1.Name = "txtLocationType1"
        Me.txtLocationType1.Size = New System.Drawing.Size(180, 29)
        Me.txtLocationType1.TabIndex = 132
        Me.txtLocationType1.Text = "3"
        '
        'txtMovementType
        '
        Me.txtMovementType.Location = New System.Drawing.Point(1328, 584)
        Me.txtMovementType.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMovementType.Name = "txtMovementType"
        Me.txtMovementType.Size = New System.Drawing.Size(180, 29)
        Me.txtMovementType.TabIndex = 133
        Me.txtMovementType.TabStop = False
        Me.txtMovementType.Text = "9"
        Me.txtMovementType.Visible = False
        Me.txtMovementType.WordWrap = False
        '
        'txtMovementBoxes
        '
        Me.txtMovementBoxes.Location = New System.Drawing.Point(1092, 584)
        Me.txtMovementBoxes.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMovementBoxes.Name = "txtMovementBoxes"
        Me.txtMovementBoxes.Size = New System.Drawing.Size(180, 29)
        Me.txtMovementBoxes.TabIndex = 134
        Me.txtMovementBoxes.Text = "0"
        Me.txtMovementBoxes.Visible = False
        '
        'cmdFindStock
        '
        Me.cmdFindStock.Location = New System.Drawing.Point(1292, 433)
        Me.cmdFindStock.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindStock.Name = "cmdFindStock"
        Me.cmdFindStock.Size = New System.Drawing.Size(119, 42)
        Me.cmdFindStock.TabIndex = 136
        Me.cmdFindStock.TabStop = False
        Me.cmdFindStock.Text = "..."
        Me.cmdFindStock.UseVisualStyleBackColor = True
        Me.cmdFindStock.Visible = False
        '
        'txtLocationType2
        '
        Me.txtLocationType2.Location = New System.Drawing.Point(1568, 708)
        Me.txtLocationType2.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLocationType2.Name = "txtLocationType2"
        Me.txtLocationType2.Size = New System.Drawing.Size(180, 29)
        Me.txtLocationType2.TabIndex = 129
        Me.txtLocationType2.Text = "2"
        Me.txtLocationType2.Visible = False
        '
        'txtBoxes
        '
        Me.txtBoxes.Location = New System.Drawing.Point(1070, 204)
        Me.txtBoxes.Margin = New System.Windows.Forms.Padding(6)
        Me.txtBoxes.Name = "txtBoxes"
        Me.txtBoxes.Size = New System.Drawing.Size(180, 29)
        Me.txtBoxes.TabIndex = 131
        Me.txtBoxes.Text = "0"
        Me.txtBoxes.Visible = False
        '
        'cmdFindShop
        '
        Me.cmdFindShop.Location = New System.Drawing.Point(1446, 536)
        Me.cmdFindShop.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdFindShop.Name = "cmdFindShop"
        Me.cmdFindShop.Size = New System.Drawing.Size(46, 42)
        Me.cmdFindShop.TabIndex = 135
        Me.cmdFindShop.TabStop = False
        Me.cmdFindShop.Text = "..."
        Me.cmdFindShop.UseVisualStyleBackColor = True
        Me.cmdFindShop.Visible = False
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(283, 996)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(138, 42)
        Me.cmdOK.TabIndex = 126
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(580, 996)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(138, 42)
        Me.cmdClear.TabIndex = 128
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'FrmShopReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1702, 1466)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTransRef)
        Me.Controls.Add(Me.cmdFindWarehouse)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtLocationType1)
        Me.Controls.Add(Me.txtMovementType)
        Me.Controls.Add(Me.txtMovementBoxes)
        Me.Controls.Add(Me.cmdFindStock)
        Me.Controls.Add(Me.txtLocationType2)
        Me.Controls.Add(Me.txtBoxes)
        Me.Controls.Add(Me.cmdFindShop)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdClear)
        Me.Name = "FrmShopReturn"
        Me.Text = "FrmShopReturn"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents colStockCode As DataGridViewTextBoxColumn
    Friend WithEvents colTransQty As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents txtCurrentQty As TextBox
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents txtShopRef As TextBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdClearGrid As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtTransferQty As TextBox
    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents txtWarehouseRef As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTransRef As Label
    Friend WithEvents cmdFindWarehouse As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtLocationType1 As TextBox
    Friend WithEvents txtMovementType As TextBox
    Friend WithEvents txtMovementBoxes As TextBox
    Friend WithEvents cmdFindStock As Button
    Friend WithEvents txtLocationType2 As TextBox
    Friend WithEvents txtBoxes As TextBox
    Friend WithEvents cmdFindShop As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdClear As Button
End Class
