<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWarehouse
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gridTrans = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TxtTotalValue = New System.Windows.Forms.Label()
        Me.TxtTotalStock = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gridStock = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboWType = New System.Windows.Forms.ComboBox()
        Me.TxteMail = New System.Windows.Forms.TextBox()
        Me.TxtMemo = New System.Windows.Forms.TextBox()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.TxtTelephone2 = New System.Windows.Forms.TextBox()
        Me.TxtTelephone1 = New System.Windows.Forms.TextBox()
        Me.TxtAddress4 = New System.Windows.Forms.TextBox()
        Me.TxtAddress3 = New System.Windows.Forms.TextBox()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.TxtContactName = New System.Windows.Forms.TextBox()
        Me.TxtWarehouseName = New System.Windows.Forms.TextBox()
        Me.TxtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtPostCode = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.gridStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridTrans)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(697, 431)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transactions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gridTrans
        '
        Me.gridTrans.AllowUserToAddRows = False
        Me.gridTrans.AllowUserToDeleteRows = False
        Me.gridTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTrans.Location = New System.Drawing.Point(4, 4)
        Me.gridTrans.Margin = New System.Windows.Forms.Padding(4)
        Me.gridTrans.Name = "gridTrans"
        Me.gridTrans.ReadOnly = True
        Me.gridTrans.RowHeadersVisible = False
        Me.gridTrans.RowHeadersWidth = 72
        Me.gridTrans.Size = New System.Drawing.Size(689, 423)
        Me.gridTrans.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TxtTotalValue)
        Me.TabPage3.Controls.Add(Me.TxtTotalStock)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.gridStock)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(697, 431)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stock"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TxtTotalValue
        '
        Me.TxtTotalValue.AutoSize = True
        Me.TxtTotalValue.Location = New System.Drawing.Point(532, 414)
        Me.TxtTotalValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTotalValue.Name = "TxtTotalValue"
        Me.TxtTotalValue.Size = New System.Drawing.Size(67, 25)
        Me.TxtTotalValue.TabIndex = 5
        Me.TxtTotalValue.Text = "£0000"
        '
        'TxtTotalStock
        '
        Me.TxtTotalStock.AutoSize = True
        Me.TxtTotalStock.Location = New System.Drawing.Point(369, 414)
        Me.TxtTotalStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTotalStock.Name = "TxtTotalStock"
        Me.TxtTotalStock.Size = New System.Drawing.Size(23, 25)
        Me.TxtTotalStock.TabIndex = 4
        Me.TxtTotalStock.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(208, 414)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 25)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Totals:"
        '
        'gridStock
        '
        Me.gridStock.AllowUserToAddRows = False
        Me.gridStock.AllowUserToDeleteRows = False
        Me.gridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridStock.Location = New System.Drawing.Point(4, 4)
        Me.gridStock.Margin = New System.Windows.Forms.Padding(4)
        Me.gridStock.Name = "gridStock"
        Me.gridStock.ReadOnly = True
        Me.gridStock.RowHeadersWidth = 72
        Me.gridStock.Size = New System.Drawing.Size(689, 406)
        Me.gridStock.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(106, 359)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 25)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "EMail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(135, 327)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 25)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "(2)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(135, 294)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "(1)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(374, 294)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Fax:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 294)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Telephone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 258)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 25)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Post Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 127)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(374, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contact Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Warehouse Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Warehouse Ref:"
        '
        'cboWType
        '
        Me.cboWType.FormattingEnabled = True
        Me.cboWType.Items.AddRange(New Object() {"Active Warehouse", "WriteOff Warehouse"})
        Me.cboWType.Location = New System.Drawing.Point(466, 21)
        Me.cboWType.Margin = New System.Windows.Forms.Padding(4)
        Me.cboWType.Name = "cboWType"
        Me.cboWType.Size = New System.Drawing.Size(180, 32)
        Me.cboWType.TabIndex = 2
        '
        'TxteMail
        '
        Me.TxteMail.Location = New System.Drawing.Point(172, 356)
        Me.TxteMail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxteMail.MaxLength = 255
        Me.TxteMail.Name = "TxteMail"
        Me.TxteMail.Size = New System.Drawing.Size(370, 29)
        Me.TxteMail.TabIndex = 12
        '
        'TxtMemo
        '
        Me.TxtMemo.Location = New System.Drawing.Point(9, 7)
        Me.TxtMemo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMemo.Multiline = True
        Me.TxtMemo.Name = "TxtMemo"
        Me.TxtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMemo.Size = New System.Drawing.Size(680, 420)
        Me.TxtMemo.TabIndex = 0
        '
        'TxtFax
        '
        Me.TxtFax.Location = New System.Drawing.Point(435, 290)
        Me.TxtFax.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFax.MaxLength = 20
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(148, 29)
        Me.TxtFax.TabIndex = 10
        '
        'TxtTelephone2
        '
        Me.TxtTelephone2.Location = New System.Drawing.Point(172, 324)
        Me.TxtTelephone2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelephone2.MaxLength = 20
        Me.TxtTelephone2.Name = "TxtTelephone2"
        Me.TxtTelephone2.Size = New System.Drawing.Size(192, 29)
        Me.TxtTelephone2.TabIndex = 11
        '
        'TxtTelephone1
        '
        Me.TxtTelephone1.Location = New System.Drawing.Point(172, 290)
        Me.TxtTelephone1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelephone1.MaxLength = 20
        Me.TxtTelephone1.Name = "TxtTelephone1"
        Me.TxtTelephone1.Size = New System.Drawing.Size(192, 29)
        Me.TxtTelephone1.TabIndex = 9
        '
        'TxtAddress4
        '
        Me.TxtAddress4.Location = New System.Drawing.Point(172, 219)
        Me.TxtAddress4.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddress4.MaxLength = 50
        Me.TxtAddress4.Name = "TxtAddress4"
        Me.TxtAddress4.Size = New System.Drawing.Size(502, 29)
        Me.TxtAddress4.TabIndex = 7
        '
        'TxtAddress3
        '
        Me.TxtAddress3.Location = New System.Drawing.Point(172, 187)
        Me.TxtAddress3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddress3.MaxLength = 50
        Me.TxtAddress3.Name = "TxtAddress3"
        Me.TxtAddress3.Size = New System.Drawing.Size(502, 29)
        Me.TxtAddress3.TabIndex = 6
        '
        'TxtAddress2
        '
        Me.TxtAddress2.Location = New System.Drawing.Point(172, 155)
        Me.TxtAddress2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddress2.MaxLength = 50
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(502, 29)
        Me.TxtAddress2.TabIndex = 5
        '
        'TxtAddress1
        '
        Me.TxtAddress1.Location = New System.Drawing.Point(172, 123)
        Me.TxtAddress1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddress1.MaxLength = 50
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.Size = New System.Drawing.Size(502, 29)
        Me.TxtAddress1.TabIndex = 4
        '
        'TxtContactName
        '
        Me.TxtContactName.Location = New System.Drawing.Point(172, 91)
        Me.TxtContactName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtContactName.MaxLength = 50
        Me.TxtContactName.Name = "TxtContactName"
        Me.TxtContactName.Size = New System.Drawing.Size(502, 29)
        Me.TxtContactName.TabIndex = 3
        '
        'TxtWarehouseName
        '
        Me.TxtWarehouseName.Location = New System.Drawing.Point(172, 59)
        Me.TxtWarehouseName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtWarehouseName.MaxLength = 50
        Me.TxtWarehouseName.Name = "TxtWarehouseName"
        Me.TxtWarehouseName.Size = New System.Drawing.Size(502, 29)
        Me.TxtWarehouseName.TabIndex = 1
        '
        'TxtWarehouseRef
        '
        Me.TxtWarehouseRef.Location = New System.Drawing.Point(171, 21)
        Me.TxtWarehouseRef.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtWarehouseRef.MaxLength = 8
        Me.TxtWarehouseRef.Name = "TxtWarehouseRef"
        Me.TxtWarehouseRef.Size = New System.Drawing.Size(192, 29)
        Me.TxtWarehouseRef.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cboWType)
        Me.TabPage1.Controls.Add(Me.TxteMail)
        Me.TabPage1.Controls.Add(Me.TxtFax)
        Me.TabPage1.Controls.Add(Me.TxtTelephone2)
        Me.TabPage1.Controls.Add(Me.TxtTelephone1)
        Me.TabPage1.Controls.Add(Me.TxtPostCode)
        Me.TabPage1.Controls.Add(Me.TxtAddress4)
        Me.TabPage1.Controls.Add(Me.TxtAddress3)
        Me.TabPage1.Controls.Add(Me.TxtAddress2)
        Me.TabPage1.Controls.Add(Me.TxtAddress1)
        Me.TabPage1.Controls.Add(Me.TxtContactName)
        Me.TabPage1.Controls.Add(Me.TxtWarehouseName)
        Me.TabPage1.Controls.Add(Me.TxtWarehouseRef)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(697, 431)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TxtPostCode
        '
        Me.TxtPostCode.Location = New System.Drawing.Point(172, 255)
        Me.TxtPostCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPostCode.MaxLength = 10
        Me.TxtPostCode.Name = "TxtPostCode"
        Me.TxtPostCode.Size = New System.Drawing.Size(192, 29)
        Me.TxtPostCode.TabIndex = 8
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TxtMemo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(697, 431)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Memo"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdClear.Location = New System.Drawing.Point(621, 545)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(112, 28)
        Me.CmdClear.TabIndex = 7
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancel.Location = New System.Drawing.Point(499, 545)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(112, 28)
        Me.CmdCancel.TabIndex = 6
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(51, 70)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(705, 468)
        Me.TabControl1.TabIndex = 4
        '
        'CmdOK
        '
        Me.CmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOK.Location = New System.Drawing.Point(378, 545)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(112, 28)
        Me.CmdOK.TabIndex = 5
        Me.CmdOK.Text = "Button1"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'FrmWarehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 1092)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CmdOK)
        Me.Name = "FrmWarehouse"
        Me.Text = "FrmWarehouse"
        Me.TabPage2.ResumeLayout(False)
        CType(Me.gridTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.gridStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gridTrans As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TxtTotalValue As Label
    Friend WithEvents TxtTotalStock As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents gridStock As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboWType As ComboBox
    Friend WithEvents TxteMail As TextBox
    Friend WithEvents TxtMemo As TextBox
    Friend WithEvents TxtFax As TextBox
    Friend WithEvents TxtTelephone2 As TextBox
    Friend WithEvents TxtTelephone1 As TextBox
    Friend WithEvents TxtAddress4 As TextBox
    Friend WithEvents TxtAddress3 As TextBox
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents TxtAddress1 As TextBox
    Friend WithEvents TxtContactName As TextBox
    Friend WithEvents TxtWarehouseName As TextBox
    Friend WithEvents TxtWarehouseRef As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtPostCode As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents CmdClear As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents TabControl1 As TabControl
    Public WithEvents CmdOK As Button
End Class
