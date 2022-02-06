<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStock
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
        Dim StockCodeLabel As System.Windows.Forms.Label
        Dim SupplierRefLabel As System.Windows.Forms.Label
        Dim DeadCodeLabel As System.Windows.Forms.Label
        Dim AmountTakenLabel As System.Windows.Forms.Label
        Dim CostValueLabel As System.Windows.Forms.Label
        Dim PCMarkUpLabel As System.Windows.Forms.Label
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.StockCodeTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierRefTextBox = New System.Windows.Forms.TextBox()
        Me.DeadCodeCheckBox = New System.Windows.Forms.CheckBox()
        Me.AmountTakenTextBox = New System.Windows.Forms.TextBox()
        Me.CostValueTextBox = New System.Windows.Forms.TextBox()
        Me.PCMarkUpTextBox = New System.Windows.Forms.TextBox()
        StockCodeLabel = New System.Windows.Forms.Label()
        SupplierRefLabel = New System.Windows.Forms.Label()
        DeadCodeLabel = New System.Windows.Forms.Label()
        AmountTakenLabel = New System.Windows.Forms.Label()
        CostValueLabel = New System.Windows.Forms.Label()
        PCMarkUpLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(568, 537)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(112, 28)
        Me.CmdCancel.TabIndex = 21
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(442, 537)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(112, 28)
        Me.CmdOK.TabIndex = 20
        Me.CmdOK.Text = "Button1"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'StockCodeLabel
        '
        StockCodeLabel.AutoSize = True
        StockCodeLabel.Location = New System.Drawing.Point(417, 350)
        StockCodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StockCodeLabel.Name = "StockCodeLabel"
        StockCodeLabel.Size = New System.Drawing.Size(121, 25)
        StockCodeLabel.TabIndex = 22
        StockCodeLabel.Text = "Stock Code:"
        '
        'StockCodeTextBox
        '
        Me.StockCodeTextBox.Location = New System.Drawing.Point(525, 346)
        Me.StockCodeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StockCodeTextBox.MaxLength = 30
        Me.StockCodeTextBox.Name = "StockCodeTextBox"
        Me.StockCodeTextBox.Size = New System.Drawing.Size(155, 29)
        Me.StockCodeTextBox.TabIndex = 14
        '
        'SupplierRefLabel
        '
        SupplierRefLabel.AutoSize = True
        SupplierRefLabel.Location = New System.Drawing.Point(413, 382)
        SupplierRefLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupplierRefLabel.Name = "SupplierRefLabel"
        SupplierRefLabel.Size = New System.Drawing.Size(124, 25)
        SupplierRefLabel.TabIndex = 23
        SupplierRefLabel.Text = "Supplier Ref:"
        '
        'SupplierRefTextBox
        '
        Me.SupplierRefTextBox.Location = New System.Drawing.Point(525, 378)
        Me.SupplierRefTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierRefTextBox.MaxLength = 8
        Me.SupplierRefTextBox.Name = "SupplierRefTextBox"
        Me.SupplierRefTextBox.Size = New System.Drawing.Size(155, 29)
        Me.SupplierRefTextBox.TabIndex = 15
        '
        'DeadCodeLabel
        '
        DeadCodeLabel.AutoSize = True
        DeadCodeLabel.Location = New System.Drawing.Point(419, 417)
        DeadCodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DeadCodeLabel.Name = "DeadCodeLabel"
        DeadCodeLabel.Size = New System.Drawing.Size(118, 25)
        DeadCodeLabel.TabIndex = 24
        DeadCodeLabel.Text = "Dead Code:"
        '
        'DeadCodeCheckBox
        '
        Me.DeadCodeCheckBox.Location = New System.Drawing.Point(525, 410)
        Me.DeadCodeCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DeadCodeCheckBox.Name = "DeadCodeCheckBox"
        Me.DeadCodeCheckBox.Size = New System.Drawing.Size(300, 30)
        Me.DeadCodeCheckBox.TabIndex = 16
        Me.DeadCodeCheckBox.UseVisualStyleBackColor = True
        '
        'AmountTakenLabel
        '
        AmountTakenLabel.AutoSize = True
        AmountTakenLabel.Location = New System.Drawing.Point(394, 447)
        AmountTakenLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AmountTakenLabel.Name = "AmountTakenLabel"
        AmountTakenLabel.Size = New System.Drawing.Size(147, 25)
        AmountTakenLabel.TabIndex = 25
        AmountTakenLabel.Text = "Amount Taken:"
        '
        'AmountTakenTextBox
        '
        Me.AmountTakenTextBox.Location = New System.Drawing.Point(523, 444)
        Me.AmountTakenTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AmountTakenTextBox.Name = "AmountTakenTextBox"
        Me.AmountTakenTextBox.Size = New System.Drawing.Size(157, 29)
        Me.AmountTakenTextBox.TabIndex = 17
        '
        'CostValueLabel
        '
        CostValueLabel.AutoSize = True
        CostValueLabel.Location = New System.Drawing.Point(423, 481)
        CostValueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CostValueLabel.Name = "CostValueLabel"
        CostValueLabel.Size = New System.Drawing.Size(115, 25)
        CostValueLabel.TabIndex = 26
        CostValueLabel.Text = "Cost Value:"
        '
        'CostValueTextBox
        '
        Me.CostValueTextBox.Location = New System.Drawing.Point(523, 477)
        Me.CostValueTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostValueTextBox.Name = "CostValueTextBox"
        Me.CostValueTextBox.Size = New System.Drawing.Size(157, 29)
        Me.CostValueTextBox.TabIndex = 18
        '
        'PCMarkUpLabel
        '
        PCMarkUpLabel.AutoSize = True
        PCMarkUpLabel.Location = New System.Drawing.Point(417, 513)
        PCMarkUpLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PCMarkUpLabel.Name = "PCMarkUpLabel"
        PCMarkUpLabel.Size = New System.Drawing.Size(120, 25)
        PCMarkUpLabel.TabIndex = 27
        PCMarkUpLabel.Text = "PCMark Up:"
        '
        'PCMarkUpTextBox
        '
        Me.PCMarkUpTextBox.Location = New System.Drawing.Point(523, 509)
        Me.PCMarkUpTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PCMarkUpTextBox.Name = "PCMarkUpTextBox"
        Me.PCMarkUpTextBox.Size = New System.Drawing.Size(157, 29)
        Me.PCMarkUpTextBox.TabIndex = 19
        '
        'FrmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 911)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(StockCodeLabel)
        Me.Controls.Add(Me.StockCodeTextBox)
        Me.Controls.Add(SupplierRefLabel)
        Me.Controls.Add(Me.SupplierRefTextBox)
        Me.Controls.Add(DeadCodeLabel)
        Me.Controls.Add(Me.DeadCodeCheckBox)
        Me.Controls.Add(AmountTakenLabel)
        Me.Controls.Add(Me.AmountTakenTextBox)
        Me.Controls.Add(CostValueLabel)
        Me.Controls.Add(Me.CostValueTextBox)
        Me.Controls.Add(PCMarkUpLabel)
        Me.Controls.Add(Me.PCMarkUpTextBox)
        Me.Name = "FrmStock"
        Me.Text = "FrmStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdOK As Button
    Friend WithEvents StockCodeTextBox As TextBox
    Friend WithEvents SupplierRefTextBox As TextBox
    Friend WithEvents DeadCodeCheckBox As CheckBox
    Friend WithEvents AmountTakenTextBox As TextBox
    Friend WithEvents CostValueTextBox As TextBox
    Friend WithEvents PCMarkUpTextBox As TextBox
End Class
