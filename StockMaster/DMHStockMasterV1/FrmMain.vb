Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmMain
    Public Mode As String
    Public BusinessName As String = "David Oliver Fashion Group"
    Public Func As String
    Public User As String = "Test"
    Public ConnectionString As String = "Initial Catalog=FYPv2;Data Source=(local);Persist Security Info=False;Integrated Security=true;"
    Public Connection As New SqlConnection(ConnectionString)

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblSearch.Visible = False
        PrintToolStripButton.Visible = False
        DgvRecords.EnableHeadersVisualStyles = True
        FindInput.Visible = False
        ReturnsToolStripMenuItem.Visible = False
    End Sub

    Private Sub ShopsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopsToolStripMenuItem.Click
        LoadShop()
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        LoadSupplier()
    End Sub

    Private Sub PurchaseOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseOrdersToolStripMenuItem.Click
        LoadPurchaseOrder()
    End Sub

    Private Sub WarehouseAdjustmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarehouseAdjustmentsToolStripMenuItem.Click
        LoadWarehouseAdjustment()
    End Sub

    Private Sub ShopDeliveriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopDeliveriesToolStripMenuItem.Click
        LoadShopDelivery()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        LoadShopSale()
    End Sub

    Private Sub ShopAdjustmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopAdjustmentsToolStripMenuItem.Click
        LoadShopAdjustment()
    End Sub

    Private Sub ShopTransfersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopTransfersToolStripMenuItem.Click
        LoadShopTransfer()
    End Sub

    Private Sub ReturnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnsToolStripMenuItem.Click
        LoadShopReturn()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        LoadCurrentStock()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub

    Private Sub AllStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllStockToolStripMenuItem.Click
        LoadAllStock()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click

    End Sub

    Private Sub RecordToolStripButton_Click(sender As Object, e As EventArgs) Handles RecordToolStripButton.Click

    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click

    End Sub

    Private Sub RefreshToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshToolStripButton.Click

    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click

    End Sub

    Private Sub ProveToolStripButton_Click(sender As Object, e As EventArgs) Handles ProveToolStripButton.Click

    End Sub

    Private Sub FindToolStripButton_Click(sender As Object, e As EventArgs) Handles FindToolStripButton.Click

    End Sub

    Private Sub TransferToolStripButton_Click(sender As Object, e As EventArgs) Handles TransferToolStripButton.Click

    End Sub

    Private Sub CloseToolStripButton_Click(sender As Object, e As EventArgs) Handles CloseToolStripButton.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you wish to exit", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If (result = DialogResult.Yes) Then
            Me.Close()
        Else

        End If
    End Sub

    Private Sub AboutToolStripButton_Click(sender As Object, e As EventArgs) Handles AboutToolStripButton.Click

    End Sub

    Private Sub StyleDataGrid()
        DgvRecords.AllowUserToResizeColumns = False
        DgvRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow
        DgvRecords.AutoGenerateColumns = True
        DgvRecords.AutoResizeColumns()
        DgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvRecords.BackgroundColor = Color.LightBlue
        DgvRecords.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgvRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        DgvRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DgvRecords.DefaultCellStyle.SelectionBackColor = Color.Red
        DgvRecords.DefaultCellStyle.SelectionForeColor = Color.Yellow
        DgvRecords.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
        DgvRecords.EditMode = DataGridViewEditMode.EditOnF2
        DgvRecords.EnableHeadersVisualStyles = False
        DgvRecords.GridColor = Color.Cornsilk
        DgvRecords.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        DgvRecords.RowsDefaultCellStyle.ForeColor = Color.LightSlateGray
        DgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Function GetCommandString(FunctionID As Int16)
        Dim CmdString As String
        Select Case FunctionID
            Case 1 ' Shop
                CmdString = "SELECT * from tblShops"
            Case 2 ' Supplier
                CmdString = "SELECT * from tblSuppliers"
            Case 3 ' All Stock
                CmdString = "SELECT * from qryStockvaluespc1"
            Case 4 ' Current Stock
                CmdString = "SELECT * from qryStockvaluespc1 Where DeadCode=0 order by StockCode"
            Case 5 ' Purchase Orders
                CmdString = "SELECT * FROM tblDeliveries Order by DeliveriesID Desc"
            Case 6 ' Warehouse Adjustments
                CmdString = "SELECT * from qryWarehouseAdjustments order by MovementDate desc"
            Case 7 ' Shop Delivery
                CmdString = "SELECT * from tblShopDeliveries Order by DeliveryDate desc"
            Case 8 ' Shop Adjustment
                CmdString = "SELECT * from qryShopAdjustments order by MovementDate desc"
            Case 9 ' Shop Transfer
                CmdString = "SELECT * from tblShopTransfers order by TransferDate desc"
            Case 10 ' Shop Sale
                CmdString = "SELECT * from tblSales order by TransactionDate desc"
            Case 11 ' Shop Return
                CmdString = "SELECT * from qryReturns order by MovementDate Desc"
            Case Else
                CmdString = "Nothing"
        End Select
        Return CmdString
    End Function

    Private Sub LoadData(ID As Integer)
        Try
            Using conn As New SqlConnection()
                conn.ConnectionString = ConnectionString
                conn.Open()
                Dim LDataTable As New DataTable
                Dim LDataAdapter As New SqlDataAdapter
                Using SelectCmd As New SqlCommand()
                    SelectCmd.Connection = conn
                    SelectCmd.CommandText = GetCommandString(ID)
                    LDataAdapter.SelectCommand = SelectCmd
                    LDataAdapter.Fill(LDataTable)
                    DataBinding.DataSource = LDataTable
                    DgvRecords.DataSource = DataBinding
                End Using
            End Using
        Catch ex As SqlException
            ' Display Error Message
            MessageBox.Show("To run this on this computer please specifiy the value of this computer" & vbCr & "In Data Source on the connectionString.", Application.ProductName)
        End Try
    End Sub

    Private Sub LoadShop()
        ShopsToolStripMenuItem.BackColor = Color.LightSkyBlue
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Nothing
        AllStockToolStripMenuItem.BackColor = Nothing
        PurchaseOrdersToolStripMenuItem.BackColor = Nothing
        ShopTransfersToolStripMenuItem.BackColor = Nothing
        ShopAdjustmentsToolStripMenuItem.BackColor = Nothing
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Nothing
        SuppliersToolStripMenuItem.BackColor = Nothing
        SalesToolStripMenuItem.BackColor = Nothing
        ShopDeliveriesToolStripMenuItem.BackColor = Nothing
        ReturnsToolStripMenuItem.BackColor = Nothing
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        LoadData(1)
        StyleDataGrid()
    End Sub

    Private Sub LoadAllStock()
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Nothing
        AllStockToolStripMenuItem.BackColor = Color.LightSkyBlue
        PurchaseOrdersToolStripMenuItem.BackColor = Nothing
        ShopTransfersToolStripMenuItem.BackColor = Nothing
        ShopAdjustmentsToolStripMenuItem.BackColor = Nothing
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Nothing
        SuppliersToolStripMenuItem.BackColor = Nothing
        SalesToolStripMenuItem.BackColor = Nothing
        ShopDeliveriesToolStripMenuItem.BackColor = Nothing
        ReturnsToolStripMenuItem.BackColor = Nothing
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        LoadData(3)
        StyleDataGrid()
    End Sub

    Private Sub LoadCurrentStock()
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Color.LightSkyBlue
        AllStockToolStripMenuItem.BackColor = Nothing
        PurchaseOrdersToolStripMenuItem.BackColor = Nothing
        ShopTransfersToolStripMenuItem.BackColor = Nothing
        ShopAdjustmentsToolStripMenuItem.BackColor = Nothing
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Nothing
        SuppliersToolStripMenuItem.BackColor = Nothing
        SalesToolStripMenuItem.BackColor = Nothing
        ShopDeliveriesToolStripMenuItem.BackColor = Nothing
        ReturnsToolStripMenuItem.BackColor = Nothing
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        LoadData(4)
        StyleDataGrid()
    End Sub

    Private Sub LoadSupplier()
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Nothing
        AllStockToolStripMenuItem.BackColor = Nothing
        PurchaseOrdersToolStripMenuItem.BackColor = Nothing
        ShopTransfersToolStripMenuItem.BackColor = Nothing
        ShopAdjustmentsToolStripMenuItem.BackColor = Nothing
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Nothing
        SuppliersToolStripMenuItem.BackColor = Color.LightSkyBlue
        SalesToolStripMenuItem.BackColor = Nothing
        ShopDeliveriesToolStripMenuItem.BackColor = Nothing
        ReturnsToolStripMenuItem.BackColor = Nothing
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        LoadData(2)
        StyleDataGrid()
    End Sub

    Private Sub LoadPurchaseOrder()
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Nothing
        AllStockToolStripMenuItem.BackColor = Nothing
        PurchaseOrdersToolStripMenuItem.BackColor = Color.LightSkyBlue
        ShopTransfersToolStripMenuItem.BackColor = Nothing
        ShopAdjustmentsToolStripMenuItem.BackColor = Nothing
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Nothing
        SuppliersToolStripMenuItem.BackColor = Nothing
        SalesToolStripMenuItem.BackColor = Nothing
        ShopDeliveriesToolStripMenuItem.BackColor = Nothing
        ReturnsToolStripMenuItem.BackColor = Nothing
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        LoadData(5)
        StyleDataGrid()
    End Sub

    Private Sub LoadWarehouseAdjustment()
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Nothing
        AllStockToolStripMenuItem.BackColor = Nothing
        PurchaseOrdersToolStripMenuItem.BackColor = Nothing
        ShopTransfersToolStripMenuItem.BackColor = Nothing
        ShopAdjustmentsToolStripMenuItem.BackColor = Nothing
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Color.LightSkyBlue
        SuppliersToolStripMenuItem.BackColor = Nothing
        SalesToolStripMenuItem.BackColor = Nothing
        ShopDeliveriesToolStripMenuItem.BackColor = Nothing
        ReturnsToolStripMenuItem.BackColor = Nothing
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        LoadData(6)
        StyleDataGrid()
    End Sub

    Private Sub LoadShopDelivery()
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Nothing
        AllStockToolStripMenuItem.BackColor = Nothing
        PurchaseOrdersToolStripMenuItem.BackColor = Nothing
        ShopTransfersToolStripMenuItem.BackColor = Nothing
        ShopAdjustmentsToolStripMenuItem.BackColor = Nothing
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Nothing
        SuppliersToolStripMenuItem.BackColor = Nothing
        SalesToolStripMenuItem.BackColor = Nothing
        ShopDeliveriesToolStripMenuItem.BackColor = Color.LightSkyBlue
        ReturnsToolStripMenuItem.BackColor = Nothing
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        LoadData(7)
        StyleDataGrid()
    End Sub

    Private Sub LoadShopAdjustment()
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Nothing
        AllStockToolStripMenuItem.BackColor = Nothing
        PurchaseOrdersToolStripMenuItem.BackColor = Nothing
        ShopTransfersToolStripMenuItem.BackColor = Nothing
        ShopAdjustmentsToolStripMenuItem.BackColor = Color.LightSkyBlue
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Nothing
        SuppliersToolStripMenuItem.BackColor = Nothing
        SalesToolStripMenuItem.BackColor = Nothing
        ShopDeliveriesToolStripMenuItem.BackColor = Nothing
        ReturnsToolStripMenuItem.BackColor = Nothing
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        StyleDataGrid()
        LoadData(8)
    End Sub

    Private Sub LoadShopTransfer()
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Nothing
        AllStockToolStripMenuItem.BackColor = Nothing
        PurchaseOrdersToolStripMenuItem.BackColor = Nothing
        ShopTransfersToolStripMenuItem.BackColor = Color.LightSkyBlue
        ShopAdjustmentsToolStripMenuItem.BackColor = Nothing
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Nothing
        SuppliersToolStripMenuItem.BackColor = Nothing
        SalesToolStripMenuItem.BackColor = Nothing
        ShopDeliveriesToolStripMenuItem.BackColor = Nothing
        ReturnsToolStripMenuItem.BackColor = Nothing
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        LoadData(9)
        StyleDataGrid()
    End Sub

    Private Sub LoadShopSale()
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Nothing
        AllStockToolStripMenuItem.BackColor = Nothing
        PurchaseOrdersToolStripMenuItem.BackColor = Nothing
        ShopTransfersToolStripMenuItem.BackColor = Nothing
        ShopAdjustmentsToolStripMenuItem.BackColor = Nothing
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Nothing
        SuppliersToolStripMenuItem.BackColor = Nothing
        SalesToolStripMenuItem.BackColor = Color.LightSkyBlue
        ShopDeliveriesToolStripMenuItem.BackColor = Nothing
        ReturnsToolStripMenuItem.BackColor = Nothing
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        LoadData(10)
        StyleDataGrid()
    End Sub

    Private Sub LoadShopReturn()
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
        StockToolStripMenuItem.BackColor = Nothing
        AllStockToolStripMenuItem.BackColor = Nothing
        PurchaseOrdersToolStripMenuItem.BackColor = Nothing
        ShopTransfersToolStripMenuItem.BackColor = Nothing
        ShopAdjustmentsToolStripMenuItem.BackColor = Nothing
        WarehouseAdjustmentsToolStripMenuItem.BackColor = Nothing
        SuppliersToolStripMenuItem.BackColor = Nothing
        SalesToolStripMenuItem.BackColor = Nothing
        ShopDeliveriesToolStripMenuItem.BackColor = Nothing
        ReturnsToolStripMenuItem.BackColor = Color.LightSkyBlue
        NewToolStripButton.Visible = True
        RecordToolStripButton.Visible = True
        DeleteToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        CloseToolStripButton.Visible = True
        RefreshToolStripButton.Visible = True
        FindToolStripButton.Visible = True
        PrintToolStripButton.Visible = True
        ProveToolStripButton.Visible = False
        TransferToolStripButton.Visible = False
        AboutToolStripButton.Visible = True
        LoadData(11)
        StyleDataGrid()
    End Sub


End Class