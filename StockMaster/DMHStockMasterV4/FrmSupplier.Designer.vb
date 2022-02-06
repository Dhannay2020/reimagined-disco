<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplier
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
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.gridTrans = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
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
        Me.TxteMail = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.TxtTelephone2 = New System.Windows.Forms.TextBox()
        Me.TxtTelephone = New System.Windows.Forms.TextBox()
        Me.TxtPostCode = New System.Windows.Forms.TextBox()
        Me.TxtAddress4 = New System.Windows.Forms.TextBox()
        Me.TxtAddress3 = New System.Windows.Forms.TextBox()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.TxtContactName = New System.Windows.Forms.TextBox()
        Me.TxtSupplierName = New System.Windows.Forms.TextBox()
        Me.TxtSupplierRef = New System.Windows.Forms.TextBox()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOK = New System.Windows.Forms.Button()
        CType(Me.gridTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMemo
        '
        Me.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMemo.Location = New System.Drawing.Point(4, 4)
        Me.txtMemo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMemo.Size = New System.Drawing.Size(525, 393)
        Me.txtMemo.TabIndex = 0
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
        Me.gridTrans.RowHeadersWidth = 72
        Me.gridTrans.Size = New System.Drawing.Size(525, 393)
        Me.gridTrans.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridTrans)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(533, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transactions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtMemo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(533, 401)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Memo"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(74, 370)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "EMail:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(289, 292)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Fax:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(103, 319)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "(2)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 289)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "(1)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 289)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Telephone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 256)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Post Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contact Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Supplier Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Supplier Ref:"
        '
        'TxteMail
        '
        Me.TxteMail.Location = New System.Drawing.Point(133, 364)
        Me.TxteMail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxteMail.MaxLength = 255
        Me.TxteMail.Name = "TxteMail"
        Me.TxteMail.Size = New System.Drawing.Size(330, 29)
        Me.TxteMail.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(71, 39)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(541, 438)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
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
        Me.TabPage1.Controls.Add(Me.TxteMail)
        Me.TabPage1.Controls.Add(Me.TxtFax)
        Me.TabPage1.Controls.Add(Me.TxtTelephone2)
        Me.TabPage1.Controls.Add(Me.TxtTelephone)
        Me.TabPage1.Controls.Add(Me.TxtPostCode)
        Me.TabPage1.Controls.Add(Me.TxtAddress4)
        Me.TabPage1.Controls.Add(Me.TxtAddress3)
        Me.TabPage1.Controls.Add(Me.TxtAddress2)
        Me.TabPage1.Controls.Add(Me.TxtAddress1)
        Me.TabPage1.Controls.Add(Me.TxtContactName)
        Me.TabPage1.Controls.Add(Me.TxtSupplierName)
        Me.TabPage1.Controls.Add(Me.TxtSupplierRef)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(533, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TxtFax
        '
        Me.TxtFax.Location = New System.Drawing.Point(334, 286)
        Me.TxtFax.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFax.MaxLength = 20
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(148, 29)
        Me.TxtFax.TabIndex = 10
        '
        'TxtTelephone2
        '
        Me.TxtTelephone2.Location = New System.Drawing.Point(133, 316)
        Me.TxtTelephone2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelephone2.MaxLength = 20
        Me.TxtTelephone2.Name = "TxtTelephone2"
        Me.TxtTelephone2.Size = New System.Drawing.Size(148, 29)
        Me.TxtTelephone2.TabIndex = 9
        '
        'TxtTelephone
        '
        Me.TxtTelephone.Location = New System.Drawing.Point(133, 285)
        Me.TxtTelephone.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelephone.MaxLength = 20
        Me.TxtTelephone.Name = "TxtTelephone"
        Me.TxtTelephone.Size = New System.Drawing.Size(148, 29)
        Me.TxtTelephone.TabIndex = 8
        '
        'TxtPostCode
        '
        Me.TxtPostCode.Location = New System.Drawing.Point(133, 253)
        Me.TxtPostCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPostCode.MaxLength = 10
        Me.TxtPostCode.Name = "TxtPostCode"
        Me.TxtPostCode.Size = New System.Drawing.Size(148, 29)
        Me.TxtPostCode.TabIndex = 7
        '
        'TxtAddress4
        '
        Me.TxtAddress4.Location = New System.Drawing.Point(133, 221)
        Me.TxtAddress4.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddress4.MaxLength = 50
        Me.TxtAddress4.Name = "TxtAddress4"
        Me.TxtAddress4.Size = New System.Drawing.Size(331, 29)
        Me.TxtAddress4.TabIndex = 6
        '
        'TxtAddress3
        '
        Me.TxtAddress3.Location = New System.Drawing.Point(133, 189)
        Me.TxtAddress3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddress3.MaxLength = 50
        Me.TxtAddress3.Name = "TxtAddress3"
        Me.TxtAddress3.Size = New System.Drawing.Size(331, 29)
        Me.TxtAddress3.TabIndex = 5
        '
        'TxtAddress2
        '
        Me.TxtAddress2.Location = New System.Drawing.Point(133, 157)
        Me.TxtAddress2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddress2.MaxLength = 50
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(331, 29)
        Me.TxtAddress2.TabIndex = 4
        '
        'TxtAddress1
        '
        Me.TxtAddress1.Location = New System.Drawing.Point(133, 122)
        Me.TxtAddress1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddress1.MaxLength = 50
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.Size = New System.Drawing.Size(331, 29)
        Me.TxtAddress1.TabIndex = 3
        '
        'TxtContactName
        '
        Me.TxtContactName.Location = New System.Drawing.Point(133, 83)
        Me.TxtContactName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtContactName.MaxLength = 50
        Me.TxtContactName.Name = "TxtContactName"
        Me.TxtContactName.Size = New System.Drawing.Size(331, 29)
        Me.TxtContactName.TabIndex = 2
        '
        'TxtSupplierName
        '
        Me.TxtSupplierName.Location = New System.Drawing.Point(133, 51)
        Me.TxtSupplierName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSupplierName.MaxLength = 50
        Me.TxtSupplierName.Name = "TxtSupplierName"
        Me.TxtSupplierName.Size = New System.Drawing.Size(330, 29)
        Me.TxtSupplierName.TabIndex = 1
        '
        'TxtSupplierRef
        '
        Me.TxtSupplierRef.Location = New System.Drawing.Point(133, 19)
        Me.TxtSupplierRef.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSupplierRef.MaxLength = 8
        Me.TxtSupplierRef.Name = "TxtSupplierRef"
        Me.TxtSupplierRef.Size = New System.Drawing.Size(117, 29)
        Me.TxtSupplierRef.TabIndex = 0
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(496, 481)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(112, 28)
        Me.CmdClear.TabIndex = 7
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(375, 481)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(112, 28)
        Me.CmdCancel.TabIndex = 6
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(254, 481)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(112, 28)
        Me.CmdOK.TabIndex = 5
        Me.CmdOK.Text = "Button1"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'FrmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 751)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOK)
        Me.Name = "FrmSupplier"
        Me.Text = "FrmSupplier"
        CType(Me.gridTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMemo As TextBox
    Friend WithEvents gridTrans As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
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
    Friend WithEvents TxteMail As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtFax As TextBox
    Friend WithEvents TxtTelephone2 As TextBox
    Friend WithEvents TxtTelephone As TextBox
    Friend WithEvents TxtPostCode As TextBox
    Friend WithEvents TxtAddress4 As TextBox
    Friend WithEvents TxtAddress3 As TextBox
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents TxtAddress1 As TextBox
    Friend WithEvents TxtContactName As TextBox
    Friend WithEvents TxtSupplierName As TextBox
    Friend WithEvents TxtSupplierRef As TextBox
    Friend WithEvents CmdClear As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdOK As Button
End Class
