<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DgvRecords = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RecordToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RefreshToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ProveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FindToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TransferToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CloseToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AboutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ShopsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarehouseAdjustmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopDeliveriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopAdjustmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopTransfersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllStockMovementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeliveriesByStockCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockListByShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorehamwoodStockListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockListByStockCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarehouseStockListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalStockValuationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesAnalysisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.FindInput = New System.Windows.Forms.ToolStripTextBox()
        Me.AllStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(90, 1365)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 26, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(2474, 39)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 30)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(24, 30)
        Me.ToolStripStatusLabel2.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(98, 30)
        Me.ToolStripStatusLabel3.Text = "Record(s)"
        '
        'DgvRecords
        '
        Me.DgvRecords.AllowUserToAddRows = False
        Me.DgvRecords.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvRecords.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRecords.Location = New System.Drawing.Point(90, 39)
        Me.DgvRecords.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DgvRecords.Name = "DgvRecords"
        Me.DgvRecords.ReadOnly = True
        Me.DgvRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DgvRecords.Size = New System.Drawing.Size(2474, 1365)
        Me.DgvRecords.TabIndex = 21
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.RecordToolStripButton, Me.DeleteToolStripButton, Me.RefreshToolStripButton, Me.PrintToolStripButton, Me.ProveToolStripButton, Me.FindToolStripButton, Me.TransferToolStripButton, Me.CloseToolStripButton, Me.AboutToolStripButton})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 39)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(90, 1365)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(81, 58)
        Me.NewToolStripButton.Text = "New"
        Me.NewToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RecordToolStripButton
        '
        Me.RecordToolStripButton.Image = CType(resources.GetObject("RecordToolStripButton.Image"), System.Drawing.Image)
        Me.RecordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RecordToolStripButton.Name = "RecordToolStripButton"
        Me.RecordToolStripButton.Size = New System.Drawing.Size(81, 58)
        Me.RecordToolStripButton.Text = "Record"
        Me.RecordToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.Image = CType(resources.GetObject("DeleteToolStripButton.Image"), System.Drawing.Image)
        Me.DeleteToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(81, 58)
        Me.DeleteToolStripButton.Text = "Delete"
        Me.DeleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RefreshToolStripButton
        '
        Me.RefreshToolStripButton.Image = CType(resources.GetObject("RefreshToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshToolStripButton.Name = "RefreshToolStripButton"
        Me.RefreshToolStripButton.Size = New System.Drawing.Size(81, 58)
        Me.RefreshToolStripButton.Text = "Refresh"
        Me.RefreshToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(81, 58)
        Me.PrintToolStripButton.Text = "Print"
        Me.PrintToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ProveToolStripButton
        '
        Me.ProveToolStripButton.Image = CType(resources.GetObject("ProveToolStripButton.Image"), System.Drawing.Image)
        Me.ProveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ProveToolStripButton.Name = "ProveToolStripButton"
        Me.ProveToolStripButton.Size = New System.Drawing.Size(83, 58)
        Me.ProveToolStripButton.Text = "Preview"
        Me.ProveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ProveToolStripButton.Visible = False
        '
        'FindToolStripButton
        '
        Me.FindToolStripButton.Image = CType(resources.GetObject("FindToolStripButton.Image"), System.Drawing.Image)
        Me.FindToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FindToolStripButton.Name = "FindToolStripButton"
        Me.FindToolStripButton.Size = New System.Drawing.Size(81, 58)
        Me.FindToolStripButton.Text = "Find"
        Me.FindToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TransferToolStripButton
        '
        Me.TransferToolStripButton.Image = CType(resources.GetObject("TransferToolStripButton.Image"), System.Drawing.Image)
        Me.TransferToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TransferToolStripButton.Name = "TransferToolStripButton"
        Me.TransferToolStripButton.Size = New System.Drawing.Size(81, 58)
        Me.TransferToolStripButton.Text = "Sales"
        Me.TransferToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TransferToolStripButton.Visible = False
        '
        'CloseToolStripButton
        '
        Me.CloseToolStripButton.Image = CType(resources.GetObject("CloseToolStripButton.Image"), System.Drawing.Image)
        Me.CloseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseToolStripButton.Name = "CloseToolStripButton"
        Me.CloseToolStripButton.Size = New System.Drawing.Size(81, 58)
        Me.CloseToolStripButton.Text = "Close"
        Me.CloseToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AboutToolStripButton
        '
        Me.AboutToolStripButton.Image = CType(resources.GetObject("AboutToolStripButton.Image"), System.Drawing.Image)
        Me.AboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboutToolStripButton.Name = "AboutToolStripButton"
        Me.AboutToolStripButton.Size = New System.Drawing.Size(81, 58)
        Me.AboutToolStripButton.Text = "About"
        Me.AboutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShopsToolStripMenuItem, Me.SuppliersToolStripMenuItem, Me.PurchaseOrdersToolStripMenuItem, Me.WarehouseAdjustmentsToolStripMenuItem, Me.ShopDeliveriesToolStripMenuItem, Me.SalesToolStripMenuItem, Me.ShopAdjustmentsToolStripMenuItem, Me.ShopTransfersToolStripMenuItem, Me.ReturnsToolStripMenuItem, Me.StockToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.LblSearch, Me.FindInput, Me.AllStockToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(2564, 39)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ShopsToolStripMenuItem
        '
        Me.ShopsToolStripMenuItem.Name = "ShopsToolStripMenuItem"
        Me.ShopsToolStripMenuItem.Size = New System.Drawing.Size(87, 35)
        Me.ShopsToolStripMenuItem.Text = "Shops"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(115, 35)
        Me.SuppliersToolStripMenuItem.Text = "Suppliers"
        '
        'PurchaseOrdersToolStripMenuItem
        '
        Me.PurchaseOrdersToolStripMenuItem.Name = "PurchaseOrdersToolStripMenuItem"
        Me.PurchaseOrdersToolStripMenuItem.Size = New System.Drawing.Size(183, 35)
        Me.PurchaseOrdersToolStripMenuItem.Text = "Purchase Orders"
        '
        'WarehouseAdjustmentsToolStripMenuItem
        '
        Me.WarehouseAdjustmentsToolStripMenuItem.Name = "WarehouseAdjustmentsToolStripMenuItem"
        Me.WarehouseAdjustmentsToolStripMenuItem.Size = New System.Drawing.Size(257, 35)
        Me.WarehouseAdjustmentsToolStripMenuItem.Text = "Warehouse Adjustments"
        '
        'ShopDeliveriesToolStripMenuItem
        '
        Me.ShopDeliveriesToolStripMenuItem.Name = "ShopDeliveriesToolStripMenuItem"
        Me.ShopDeliveriesToolStripMenuItem.Size = New System.Drawing.Size(173, 35)
        Me.ShopDeliveriesToolStripMenuItem.Text = "Shop Deliveries"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(78, 35)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ShopAdjustmentsToolStripMenuItem
        '
        Me.ShopAdjustmentsToolStripMenuItem.Name = "ShopAdjustmentsToolStripMenuItem"
        Me.ShopAdjustmentsToolStripMenuItem.Size = New System.Drawing.Size(200, 35)
        Me.ShopAdjustmentsToolStripMenuItem.Text = "Shop Adjustments"
        '
        'ShopTransfersToolStripMenuItem
        '
        Me.ShopTransfersToolStripMenuItem.Name = "ShopTransfersToolStripMenuItem"
        Me.ShopTransfersToolStripMenuItem.Size = New System.Drawing.Size(166, 35)
        Me.ShopTransfersToolStripMenuItem.Text = "Shop Transfers"
        '
        'ReturnsToolStripMenuItem
        '
        Me.ReturnsToolStripMenuItem.Name = "ReturnsToolStripMenuItem"
        Me.ReturnsToolStripMenuItem.Size = New System.Drawing.Size(101, 35)
        Me.ReturnsToolStripMenuItem.Text = "Returns"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(155, 35)
        Me.StockToolStripMenuItem.Text = "Current Stock"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllStockMovementsToolStripMenuItem, Me.DeliveriesByStockCodeToolStripMenuItem, Me.StockListByShopToolStripMenuItem, Me.BorehamwoodStockListToolStripMenuItem, Me.StockListByStockCodeToolStripMenuItem, Me.WarehouseStockListToolStripMenuItem, Me.TotalStockValuationToolStripMenuItem, Me.SalesHistoryToolStripMenuItem, Me.SalesAnalysisToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(101, 35)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'AllStockMovementsToolStripMenuItem
        '
        Me.AllStockMovementsToolStripMenuItem.Name = "AllStockMovementsToolStripMenuItem"
        Me.AllStockMovementsToolStripMenuItem.Size = New System.Drawing.Size(357, 40)
        Me.AllStockMovementsToolStripMenuItem.Text = "All Stock Movements"
        '
        'DeliveriesByStockCodeToolStripMenuItem
        '
        Me.DeliveriesByStockCodeToolStripMenuItem.Name = "DeliveriesByStockCodeToolStripMenuItem"
        Me.DeliveriesByStockCodeToolStripMenuItem.Size = New System.Drawing.Size(357, 40)
        Me.DeliveriesByStockCodeToolStripMenuItem.Text = "Deliveries by Stock Code"
        '
        'StockListByShopToolStripMenuItem
        '
        Me.StockListByShopToolStripMenuItem.Name = "StockListByShopToolStripMenuItem"
        Me.StockListByShopToolStripMenuItem.Size = New System.Drawing.Size(357, 40)
        Me.StockListByShopToolStripMenuItem.Text = "Stock List by Shop"
        '
        'BorehamwoodStockListToolStripMenuItem
        '
        Me.BorehamwoodStockListToolStripMenuItem.Name = "BorehamwoodStockListToolStripMenuItem"
        Me.BorehamwoodStockListToolStripMenuItem.Size = New System.Drawing.Size(357, 40)
        Me.BorehamwoodStockListToolStripMenuItem.Text = "Borehamwood Stock List"
        '
        'StockListByStockCodeToolStripMenuItem
        '
        Me.StockListByStockCodeToolStripMenuItem.Name = "StockListByStockCodeToolStripMenuItem"
        Me.StockListByStockCodeToolStripMenuItem.Size = New System.Drawing.Size(357, 40)
        Me.StockListByStockCodeToolStripMenuItem.Text = "Stock List By StockCode"
        '
        'WarehouseStockListToolStripMenuItem
        '
        Me.WarehouseStockListToolStripMenuItem.Name = "WarehouseStockListToolStripMenuItem"
        Me.WarehouseStockListToolStripMenuItem.Size = New System.Drawing.Size(357, 40)
        Me.WarehouseStockListToolStripMenuItem.Text = "Warehouse Stock List"
        '
        'TotalStockValuationToolStripMenuItem
        '
        Me.TotalStockValuationToolStripMenuItem.Name = "TotalStockValuationToolStripMenuItem"
        Me.TotalStockValuationToolStripMenuItem.Size = New System.Drawing.Size(357, 40)
        Me.TotalStockValuationToolStripMenuItem.Text = "Total Stock Valuation"
        '
        'SalesHistoryToolStripMenuItem
        '
        Me.SalesHistoryToolStripMenuItem.Name = "SalesHistoryToolStripMenuItem"
        Me.SalesHistoryToolStripMenuItem.Size = New System.Drawing.Size(357, 40)
        Me.SalesHistoryToolStripMenuItem.Text = "Sales History"
        '
        'SalesAnalysisToolStripMenuItem
        '
        Me.SalesAnalysisToolStripMenuItem.Name = "SalesAnalysisToolStripMenuItem"
        Me.SalesAnalysisToolStripMenuItem.Size = New System.Drawing.Size(357, 40)
        Me.SalesAnalysisToolStripMenuItem.Text = "Sales Analysis"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(105, 35)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'LblSearch
        '
        Me.LblSearch.Enabled = False
        Me.LblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(180, 35)
        Me.LblSearch.Text = "Search Item:"
        '
        'FindInput
        '
        Me.FindInput.BackColor = System.Drawing.Color.Aqua
        Me.FindInput.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FindInput.Name = "FindInput"
        Me.FindInput.Size = New System.Drawing.Size(180, 35)
        '
        'AllStockToolStripMenuItem
        '
        Me.AllStockToolStripMenuItem.Name = "AllStockToolStripMenuItem"
        Me.AllStockToolStripMenuItem.Size = New System.Drawing.Size(110, 35)
        Me.AllStockToolStripMenuItem.Text = "All Stock"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2564, 1404)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DgvRecords)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMain"
        Me.Text = " "
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataBinding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents DgvRecords As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents RecordToolStripButton As ToolStripButton
    Friend WithEvents DeleteToolStripButton As ToolStripButton
    Friend WithEvents RefreshToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents ProveToolStripButton As ToolStripButton
    Friend WithEvents FindToolStripButton As ToolStripButton
    Friend WithEvents TransferToolStripButton As ToolStripButton
    Friend WithEvents CloseToolStripButton As ToolStripButton
    Friend WithEvents AboutToolStripButton As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ShopsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseOrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WarehouseAdjustmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShopDeliveriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShopAdjustmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShopTransfersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllStockMovementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeliveriesByStockCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockListByShopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorehamwoodStockListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockListByStockCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WarehouseStockListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalStockValuationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesAnalysisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblSearch As ToolStripTextBox
    Friend WithEvents FindInput As ToolStripTextBox
    Friend WithEvents AllStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBinding As BindingSource
End Class
