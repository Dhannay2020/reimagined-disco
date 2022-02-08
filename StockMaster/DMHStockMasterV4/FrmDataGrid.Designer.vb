<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataGrid
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsbNew = New System.Windows.Forms.ToolStripButton()
        Me.TsbRecord = New System.Windows.Forms.ToolStripButton()
        Me.TsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.TsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.TsbPrint = New System.Windows.Forms.ToolStripButton()
        Me.TsbFind = New System.Windows.Forms.ToolStripButton()
        Me.TsbClose = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.toolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1393, 1172)
        Me.SplitContainer1.SplitterDistance = 51
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 1
        '
        'toolStrip1
        '
        Me.toolStrip1.AutoSize = False
        Me.toolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbNew, Me.TsbRecord, Me.TsbDelete, Me.TsbRefresh, Me.TsbPrint, Me.TsbFind, Me.TsbClose})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.toolStrip1.Size = New System.Drawing.Size(1393, 48)
        Me.toolStrip1.TabIndex = 4
        Me.toolStrip1.Text = "toolStrip1"
        '
        'TsbNew
        '
        Me.TsbNew.AutoSize = False
        Me.TsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbNew.Name = "TsbNew"
        Me.TsbNew.Size = New System.Drawing.Size(40, 51)
        Me.TsbNew.Text = "New"
        Me.TsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbRecord
        '
        Me.TsbRecord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbRecord.Name = "TsbRecord"
        Me.TsbRecord.Size = New System.Drawing.Size(82, 43)
        Me.TsbRecord.Text = "Record"
        Me.TsbRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbDelete
        '
        Me.TsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbDelete.Name = "TsbDelete"
        Me.TsbDelete.Size = New System.Drawing.Size(78, 43)
        Me.TsbDelete.Text = "Delete"
        Me.TsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbRefresh
        '
        Me.TsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbRefresh.Name = "TsbRefresh"
        Me.TsbRefresh.Size = New System.Drawing.Size(88, 43)
        Me.TsbRefresh.Text = "Refresh"
        Me.TsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbPrint
        '
        Me.TsbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbPrint.Name = "TsbPrint"
        Me.TsbPrint.Size = New System.Drawing.Size(62, 43)
        Me.TsbPrint.Text = "Print"
        Me.TsbPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbFind
        '
        Me.TsbFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbFind.Name = "TsbFind"
        Me.TsbFind.Size = New System.Drawing.Size(56, 43)
        Me.TsbFind.Text = "Find"
        Me.TsbFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbClose
        '
        Me.TsbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbClose.Name = "TsbClose"
        Me.TsbClose.Size = New System.Drawing.Size(66, 43)
        Me.TsbClose.Text = "Close"
        Me.TsbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1393, 1115)
        Me.SplitContainer2.SplitterDistance = 1076
        Me.SplitContainer2.SplitterWidth = 6
        Me.SplitContainer2.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.Size = New System.Drawing.Size(1393, 1076)
        Me.DataGridView1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TSSCount, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1393, 32)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(141, 25)
        Me.ToolStripStatusLabel1.Text = "Purchase Orders"
        '
        'TSSCount
        '
        Me.TSSCount.Name = "TSSCount"
        Me.TSSCount.Size = New System.Drawing.Size(52, 25)
        Me.TSSCount.Text = "0000"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(75, 25)
        Me.ToolStripStatusLabel3.Text = "Records"
        '
        'FrmDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1393, 1172)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmDataGrid"
        Me.Text = "FrmDataGrid"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Private WithEvents toolStrip1 As ToolStrip
    Private WithEvents TsbNew As ToolStripButton
    Private WithEvents TsbRecord As ToolStripButton
    Private WithEvents TsbDelete As ToolStripButton
    Public WithEvents TsbRefresh As ToolStripButton
    Private WithEvents TsbPrint As ToolStripButton
    Private WithEvents TsbFind As ToolStripButton
    Private WithEvents TsbClose As ToolStripButton
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TSSCount As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents BindingSource1 As BindingSource
End Class
