Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmMain
    Public Mode As String
    Public BusinessName As String = "David Oliver Fashion Group"
    Public Func As String
    Public User As String = "Test"
    Public ConnectionString As String = "Initial Catalog=FYPv2;Data Source=(local);Persist Security Info=False;Integrated Security=true;"
    Public Connection As New SqlConnection(ConnectionString)
    Public DeleteCmd As New SqlCommand()

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblSearch.Visible = False
        PrintToolStripButton.Visible = False
        DgvRecords.EnableHeadersVisualStyles = True
        FindInput.Visible = False
        ReturnsToolStripMenuItem.Visible = False
    End Sub

    Private Sub ShopsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopsToolStripMenuItem.Click
        LoadShop()
        'ShopRef
        DgvRecords.Columns.Item(0).HeaderText = "Shop Ref"
        DgvRecords.Columns.Item(0).Width = 82
        'ShopName
        DgvRecords.Columns.Item(1).HeaderText = "Shop Name"
        DgvRecords.Columns.Item(1).Width = 182
        'Shop.Address1
        DgvRecords.Columns.Item(2).Visible = True
        DgvRecords.Columns.Item(2).HeaderText = "Address"
        DgvRecords.Columns.Item(2).Width = 50
        'Shop.Address2
        DgvRecords.Columns.Item(3).Visible = False
        DgvRecords.Columns.Item(3).Width = 0
        'Shop.Address3
        DgvRecords.Columns.Item(4).Visible = False
        DgvRecords.Columns.Item(4).Width = 0
        'Shop.Address4
        DgvRecords.Columns.Item(5).Visible = False
        DgvRecords.Columns.Item(5).Width = 0
        'Shop.PostCode
        DgvRecords.Columns.Item(6).Visible = False
        DgvRecords.Columns.Item(6).Width = 0
        'Shop.ContactName
        DgvRecords.Columns.Item(7).Visible = False
        DgvRecords.Columns.Item(7).Width = 0
        'Shop.Telephone
        DgvRecords.Columns.Item(8).Visible = False
        DgvRecords.Columns.Item(9).HeaderText = "Telephone"
        DgvRecords.Columns.Item(9).Width = 50
        'Shop.Telephone2
        DgvRecords.Columns.Item(9).Visible = True
        DgvRecords.Columns.Item(8).Width = 0
        'Shop.Fax
        DgvRecords.Columns.Item(10).Visible = False
        DgvRecords.Columns.Item(10).Width = 0
        'Shop.eMail
        DgvRecords.Columns.Item(11).Visible = False
        DgvRecords.Columns.Item(11).Width = 0
        'Shop.ShopType
        DgvRecords.Columns.Item(13).HeaderText = "Type"
        DgvRecords.Columns.Item(12).Visible = False
        DgvRecords.Columns.Item(12).Width = 0
        DgvRecords.Columns.Item(14).Visible = False
        'Shop.CreatedBy
        DgvRecords.Columns.Item(15).HeaderText = "Created By"
        DgvRecords.Columns.Item(15).Visible = False
        DgvRecords.Columns.Item(14).Width = 0
        'Shop.CreatedDate
        DgvRecords.Columns.Item(16).HeaderText = "Created At"
        DgvRecords.Columns.Item(15).Width = 0
        ToolStripStatusLabel1.Text = "Shops"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Shop"
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        LoadSupplier()
        'SupplierRef
        DgvRecords.Columns.Item(0).Visible = True
        DgvRecords.Columns.Item(0).HeaderText = "Supplier Ref"
        DgvRecords.Columns.Item(0).Width = "182"
        'SupplierName
        DgvRecords.Columns.Item(1).HeaderText = "Supplier Name"
        DgvRecords.Columns.Item(1).Width = "182"
        'Supplier.Address1
        DgvRecords.Columns.Item(2).HeaderText = "Address"
        DgvRecords.Columns.Item(2).Width = "182"
        'Supplier.Address2
        DgvRecords.Columns.Item(3).Visible = False
        'Supplier.Address3
        DgvRecords.Columns.Item(4).Visible = False
        'Supplier.Address4
        DgvRecords.Columns.Item(5).Visible = False
        'Supplier.PostCode
        DgvRecords.Columns.Item(6).Visible = False
        'Supplier.ContactName
        DgvRecords.Columns.Item(7).HeaderText = "Contact Name"
        DgvRecords.Columns.Item(7).Width = "182"
        'Supplier.Telephone
        DgvRecords.Columns.Item(8).HeaderText = "Telephone"
        DgvRecords.Columns.Item(8).Width = "182"
        'Supplier.Telephone2
        DgvRecords.Columns.Item(9).Visible = False
        'Supplier.Fax
        DgvRecords.Columns.Item(10).Visible = False
        'Supplier.eMail
        DgvRecords.Columns.Item(11).Visible = False
        'Supplier.memo
        DgvRecords.Columns.Item(12).Visible = False
        'Supplier.CreatedBy
        DgvRecords.Columns.Item(13).HeaderText = "Created By"
        DgvRecords.Columns.Item(13).Visible = False
        'Supplier.CreatedDate
        DgvRecords.Columns.Item(14).HeaderText = "Created At"
        DgvRecords.Columns.Item(14).Width = 130
        DgvRecords.Columns.Item(14).Visible = False
        ToolStripStatusLabel1.Text = "Suppliers"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Supplier"
    End Sub

    Private Sub PurchaseOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseOrdersToolStripMenuItem.Click
        LoadPurchaseOrder()
        ' Delivery ID
        DgvRecords.Columns(0).HeaderText = "Delivery ID"
        DgvRecords.Columns(0).Width = 50
        DgvRecords.Columns.Item(0).DefaultCellStyle.Format = "000000"
        DgvRecords.Columns(0).Visible = True
        ' Our Ref
        DgvRecords.Columns(1).HeaderText = "Our Ref"
        DgvRecords.Columns(1).Width = 120
        DgvRecords.Columns(1).Visible = True
        ' Supplier Ref
        DgvRecords.Columns(2).HeaderText = "Supplier Ref"
        DgvRecords.Columns(2).Width = 100
        DgvRecords.Columns(2).Visible = False
        ' Supplier Name
        DgvRecords.Columns(3).HeaderText = "Supplier Name"
        DgvRecords.Columns(3).Width = 160
        DgvRecords.Columns(3).Visible = True
        ' Location Ref
        DgvRecords.Columns(4).HeaderText = "Location Ref"
        DgvRecords.Columns(4).Width = 150
        DgvRecords.Columns(4).Visible = False
        ' Location Name
        DgvRecords.Columns(5).HeaderText = "Location Name"
        DgvRecords.Columns(5).Width = 160
        DgvRecords.Columns(5).Visible = True
        ' Stock Code
        DgvRecords.Columns(6).HeaderText = "Stock Code"
        DgvRecords.Columns(6).Width = "50"
        DgvRecords.Columns(6).Visible = False
        ' DQty Garments
        DgvRecords.Columns(7).HeaderText = "Garments"
        DgvRecords.Columns(7).Width = 70
        DgvRecords.Columns(7).Visible = True
        ' DQty Boxes
        DgvRecords.Columns(8).HeaderText = "Boxes"
        DgvRecords.Columns(8).Width = 70
        DgvRecords.Columns(8).Visible = False
        ' DQty Hangers
        DgvRecords.Columns(9).HeaderText = "Hangers"
        DgvRecords.Columns(9).Width = "50"
        DgvRecords.Columns(9).Visible = False
        ' Total Garments
        DgvRecords.Columns(10).HeaderText = "Total Garments"
        DgvRecords.Columns(10).Width = "50"
        DgvRecords.Columns(10).Visible = False
        ' Total Boxes
        DgvRecords.Columns(11).HeaderText = "Total Boxes"
        DgvRecords.Columns(11).Width = "50"
        DgvRecords.Columns(11).Visible = False
        ' Total Hangers
        DgvRecords.Columns(12).HeaderText = "Total Hangers"
        DgvRecords.Columns(12).Width = "50"
        DgvRecords.Columns(12).Visible = False
        ' Net Amount
        DgvRecords.Columns(13).HeaderText = "Net Amount"
        DgvRecords.Columns.Item(13).DefaultCellStyle.Format = "c"
        DgvRecords.Columns(13).Width = 70
        DgvRecords.Columns(13).Visible = True
        ' Delivery Charge
        DgvRecords.Columns(14).HeaderText = "Del. Charge"
        DgvRecords.Columns(14).Width = "50"
        DgvRecords.Columns(14).Visible = False
        ' Commission
        DgvRecords.Columns(15).HeaderText = "Commission"
        DgvRecords.Columns(15).Width = "50"
        DgvRecords.Columns(15).Visible = False
        ' Total Amount
        DgvRecords.Columns(16).HeaderText = "Total Amount"
        DgvRecords.Columns(16).Width = "50"
        DgvRecords.Columns(16).Visible = False
        ' Delivery Date
        DgvRecords.Columns(17).HeaderText = "Delivery Date"
        DgvRecords.Columns(17).Width = 90
        DgvRecords.Columns(17).Visible = True
        ' Delivery Type
        DgvRecords.Columns(18).HeaderText = "Delivery Type"
        DgvRecords.Columns(18).Width = "50"
        DgvRecords.Columns(18).Visible = False
        ' Confirmed Date
        DgvRecords.Columns(19).HeaderText = "Confirmed Date"
        DgvRecords.Columns(19).Width = "50"
        DgvRecords.Columns(19).Visible = False
        ' Notes
        DgvRecords.Columns(20).HeaderText = "Notes"
        DgvRecords.Columns(20).Width = "50"
        DgvRecords.Columns(20).Visible = False
        ' InvoiceNo
        DgvRecords.Columns(21).HeaderText = "Invoice"
        DgvRecords.Columns(21).Width = "50"
        DgvRecords.Columns(21).Visible = False
        ' Shipper
        DgvRecords.Columns(22).HeaderText = "Shipper"
        DgvRecords.Columns(22).Width = "50"
        DgvRecords.Columns(22).Visible = False
        ' ShipperInvoice
        DgvRecords.Columns(23).HeaderText = "Shipper Invoice"
        DgvRecords.Columns(23).Width = "50"
        DgvRecords.Columns(23).Visible = False
        ' Created By
        DgvRecords.Columns(24).HeaderText = "Created By"
        DgvRecords.Columns(24).Width = 80
        DgvRecords.Columns(24).Visible = False
        ' Created Date
        DgvRecords.Columns(25).HeaderText = "Created Date"
        DgvRecords.Columns(25).Width = 100
        DgvRecords.Columns(25).Visible = False
        ToolStripStatusLabel1.Text = "Purchase Orders"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Purchase Orders"
    End Sub

    Private Sub WarehouseAdjustmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarehouseAdjustmentsToolStripMenuItem.Click
        LoadWarehouseAdjustment()
        'StockmovementID
        DgvRecords.Columns.Item(0).Visible = False
        DgvRecords.Columns.Item(0).HeaderText = "Stocmovement ID"
        DgvRecords.Columns.Item(0).Width = "182"
        'Reference
        DgvRecords.Columns.Item(1).Visible = True
        DgvRecords.Columns.Item(1).HeaderText = "Reference"
        DgvRecords.Columns.Item(1).Width = 80
        'Location
        DgvRecords.Columns.Item(2).Visible = False
        DgvRecords.Columns.Item(2).HeaderText = "Date"
        DgvRecords.Columns.Item(2).Width = "182"
        'WarehouseName
        DgvRecords.Columns.Item(3).Visible = True
        DgvRecords.Columns.Item(3).HeaderText = "Warehouse Name"
        DgvRecords.Columns.Item(3).Width = 150
        'StockCode
        DgvRecords.Columns.Item(4).Visible = True
        DgvRecords.Columns.Item(4).HeaderText = "Stock Code"
        DgvRecords.Columns.Item(4).Width = 80
        'Type
        DgvRecords.Columns.Item(5).Visible = False
        DgvRecords.Columns.Item(5).HeaderText = "Type"
        DgvRecords.Columns.Item(5).Width = 80
        'Qty
        DgvRecords.Columns.Item(6).Visible = True
        DgvRecords.Columns.Item(6).HeaderText = "Qty"
        DgvRecords.Columns.Item(6).Width = 50
        ' MovementDate
        DgvRecords.Columns.Item(7).Visible = True
        DgvRecords.Columns.Item(7).HeaderText = "Date"
        DgvRecords.Columns.Item(7).Width = 80
        ToolStripStatusLabel1.Text = "Warehouse Adjustments"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Warehouse Adjustment"
    End Sub

    Private Sub ShopDeliveriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopDeliveriesToolStripMenuItem.Click
        LoadShopDelivery()
        'DeliveryID
        DgvRecords.Columns.Item(0).Visible = True
        DgvRecords.Columns.Item(0).HeaderText = "Record No"
        DgvRecords.Columns.Item(0).Width = 80
        DgvRecords.Columns.Item(0).DefaultCellStyle.Format = "000000"
        'ShopRef
        DgvRecords.Columns.Item(1).Visible = False
        DgvRecords.Columns.Item(1).HeaderText = "Shop Ref"
        DgvRecords.Columns.Item(1).Width = 80
        'ShopName
        DgvRecords.Columns.Item(2).Visible = True
        DgvRecords.Columns.Item(2).HeaderText = "Shop"
        DgvRecords.Columns.Item(2).Width = 140
        'WarehouseRef
        DgvRecords.Columns.Item(3).Visible = False
        DgvRecords.Columns.Item(3).HeaderText = "Warehouse Ref"
        DgvRecords.Columns.Item(3).Width = 80
        'WarehouseName
        DgvRecords.Columns.Item(4).Visible = True
        DgvRecords.Columns.Item(4).HeaderText = "Warehouse"
        DgvRecords.Columns.Item(4).Width = 140
        'Reference
        DgvRecords.Columns.Item(5).Visible = True
        DgvRecords.Columns.Item(5).HeaderText = "Delivery No."
        DgvRecords.Columns.Item(5).Width = 80
        'TotalHangers
        DgvRecords.Columns.Item(6).Visible = True
        DgvRecords.Columns.Item(6).HeaderText = "Quantity"
        DgvRecords.Columns.Item(6).Width = 80
        'DeliveryDate
        DgvRecords.Columns.Item(7).Visible = True
        DgvRecords.Columns.Item(7).HeaderText = "Delivery Date"
        DgvRecords.Columns.Item(7).Width = 100
        'DeliveryType
        DgvRecords.Columns.Item(8).Visible = False
        DgvRecords.Columns.Item(8).HeaderText = "Created By"
        DgvRecords.Columns.Item(8).Width = "182"
        'ConfirmedDate
        DgvRecords.Columns.Item(9).Visible = False
        DgvRecords.Columns.Item(9).HeaderText = "Created Date"
        DgvRecords.Columns.Item(9).Width = "182"
        'Notes
        DgvRecords.Columns.Item(10).Visible = False
        DgvRecords.Columns.Item(10).HeaderText = "Notes"
        DgvRecords.Columns.Item(10).Width = "182"
        'CreatedBy
        DgvRecords.Columns.Item(11).Visible = False
        DgvRecords.Columns.Item(11).HeaderText = "Created By"
        DgvRecords.Columns.Item(11).Width = "182"
        'CreatedDate
        DgvRecords.Columns.Item(12).Visible = False
        DgvRecords.Columns.Item(12).HeaderText = "Created At"
        DgvRecords.Columns.Item(12).Width = "182"
        ToolStripStatusLabel1.Text = "Shop Deliveries"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Shop Delivery"
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        LoadShopSale()
        'SalesID
        DgvRecords.Columns.Item(0).Visible = True
        DgvRecords.Columns.Item(0).HeaderText = "Sales ID"
        DgvRecords.Columns.Item(0).DefaultCellStyle.Format = "000000"
        DgvRecords.Columns.Item(0).Width = 50
        'ShopRef
        DgvRecords.Columns.Item(1).Visible = True
        DgvRecords.Columns.Item(1).HeaderText = "Shop Ref"
        DgvRecords.Columns.Item(1).Width = 50
        'ShopName
        DgvRecords.Columns.Item(2).Visible = True
        DgvRecords.Columns.Item(2).HeaderText = "Shop Name"
        DgvRecords.Columns.Item(2).Width = 140
        'Reference
        DgvRecords.Columns.Item(3).Visible = False
        DgvRecords.Columns.Item(3).HeaderText = "Ref"
        DgvRecords.Columns.Item(3).Width = 10
        'TransactionDate
        DgvRecords.Columns.Item(4).Visible = True
        DgvRecords.Columns.Item(4).HeaderText = "Date"
        DgvRecords.Columns.Item(4).DefaultCellStyle.Format = "d"
        DgvRecords.Columns.Item(4).Width = 100
        'TotalQty
        DgvRecords.Columns.Item(5).Visible = True
        DgvRecords.Columns.Item(5).HeaderText = "Total Garments"
        DgvRecords.Columns.Item(5).Width = 80
        'TotalValue
        DgvRecords.Columns.Item(6).Visible = True
        DgvRecords.Columns.Item(6).HeaderText = "Total Sales"
        DgvRecords.Columns.Item(6).Width = 80
        DgvRecords.Columns.Item(6).DefaultCellStyle.Format = "c"
        'CreatedBy
        DgvRecords.Columns.Item(7).Visible = False
        DgvRecords.Columns.Item(7).HeaderText = "From ID"
        DgvRecords.Columns.Item(7).Width = 0
        'CreatedDate
        DgvRecords.Columns.Item(8).Visible = False
        DgvRecords.Columns.Item(8).HeaderText = "To ID"
        DgvRecords.Columns.Item(8).Width = 0
        ToolStripStatusLabel1.Text = "Sales"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Shop Sale"
    End Sub

    Private Sub ShopAdjustmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopAdjustmentsToolStripMenuItem.Click
        LoadShopAdjustment()
        'StockmovementID
        DgvRecords.Columns.Item(0).Visible = False
        DgvRecords.Columns.Item(0).HeaderText = "Stocmovement ID"
        DgvRecords.Columns.Item(0).Width = "182"
        'Reference
        DgvRecords.Columns.Item(1).Visible = True
        DgvRecords.Columns.Item(1).HeaderText = "Reference"
        DgvRecords.Columns.Item(1).Width = 200
        'Location
        DgvRecords.Columns.Item(2).Visible = False
        DgvRecords.Columns.Item(2).HeaderText = "Date"
        DgvRecords.Columns.Item(2).Width = "182"
        'ShopName
        DgvRecords.Columns.Item(3).Visible = False
        DgvRecords.Columns.Item(3).HeaderText = "Shop Name"
        DgvRecords.Columns.Item(3).Width = "182"
        'StockCode
        DgvRecords.Columns.Item(4).Visible = True
        DgvRecords.Columns.Item(5).HeaderText = "Stock Code"
        DgvRecords.Columns.Item(4).Width = "182"
        'Type
        DgvRecords.Columns.Item(5).Visible = True
        DgvRecords.Columns.Item(5).HeaderText = "Type"
        DgvRecords.Columns.Item(5).Width = "182"
        'Qty
        DgvRecords.Columns.Item(6).Visible = True
        DgvRecords.Columns.Item(6).HeaderText = "Qty"
        DgvRecords.Columns.Item(6).Width = 50
        ' MovementDate
        DgvRecords.Columns.Item(7).Visible = True
        DgvRecords.Columns.Item(7).HeaderText = "Date"
        DgvRecords.Columns.Item(7).Width = "182"
        ToolStripStatusLabel1.Text = "Shop Adjustments"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Shop Adjustment"
    End Sub

    Private Sub ShopTransfersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopTransfersToolStripMenuItem.Click
        LoadShopTransfer()
        'TransferID
        DgvRecords.Columns.Item(0).Visible = False
        'Reference
        DgvRecords.Columns.Item(1).Visible = True
        DgvRecords.Columns.Item(1).HeaderText = "TF Note"
        DgvRecords.Columns.Item(1).Width = 80
        'From Shop
        DgvRecords.Columns.Item(2).Visible = True
        DgvRecords.Columns.Item(2).HeaderText = "Date"
        DgvRecords.Columns.Item(2).Width = 80
        'To Shop
        DgvRecords.Columns.Item(3).Visible = True
        DgvRecords.Columns.Item(3).HeaderText = "From Shop Ref"
        DgvRecords.Columns.Item(3).Width = 80
        'From Quantity
        DgvRecords.Columns.Item(4).Visible = True
        DgvRecords.Columns.Item(4).HeaderText = "From Shop Name"
        DgvRecords.Columns.Item(4).Width = 120
        'Movement Date
        DgvRecords.Columns.Item(5).Visible = True
        DgvRecords.Columns.Item(5).HeaderText = "To Shop Ref"
        DgvRecords.Columns.Item(5).Width = 80
        'Transfer Reference
        DgvRecords.Columns.Item(6).Visible = False
        DgvRecords.Columns.Item(6).HeaderText = "To Shop Name"
        DgvRecords.Columns.Item(6).Width = 120
        'From Shop Ref
        DgvRecords.Columns.Item(6).Visible = False
        DgvRecords.Columns.Item(6).HeaderText = "From Shop Ref"
        DgvRecords.Columns.Item(6).Width = "182"
        'ToShopRef
        DgvRecords.Columns.Item(7).Visible = True
        DgvRecords.Columns.Item(7).HeaderText = "Quantity"
        DgvRecords.Columns.Item(7).Width = 50
        'TotalQtyIn
        DgvRecords.Columns.Item(8).Visible = False
        DgvRecords.Columns.Item(8).HeaderText = "To Quantity"
        DgvRecords.Columns.Item(8).Width = "182"
        DgvRecords.Columns.Item(9).Visible = False
        DgvRecords.Columns.Item(10).Visible = False
        ToolStripStatusLabel1.Text = "Shop Transfers"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Shop Transfer"
    End Sub

    Private Sub ReturnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnsToolStripMenuItem.Click
        LoadShopReturn()
        'Reference
        DgvRecords.Columns.Item(0).Visible = True
        DgvRecords.Columns.Item(6).HeaderText = "Our Reference"
        DgvRecords.Columns.Item(0).Width = 182
        'FromShop
        DgvRecords.Columns.Item(1).Visible = True
        DgvRecords.Columns.Item(0).HeaderText = "From Shop"
        DgvRecords.Columns.Item(1).Width = 182
        'ToWarehouse
        DgvRecords.Columns.Item(2).Visible = True
        DgvRecords.Columns.Item(1).HeaderText = "To Warehouse"
        DgvRecords.Columns.Item(2).Width = 182
        'SMStockCode
        DgvRecords.Columns.Item(3).Visible = True
        DgvRecords.Columns.Item(2).HeaderText = "Stock Code"
        DgvRecords.Columns.Item(3).Width = 182
        'MovementDate
        DgvRecords.Columns.Item(4).Visible = False
        DgvRecords.Columns.Item(7).HeaderText = "Movement Date"
        DgvRecords.Columns.Item(4).Width = 182
        'TransferReference
        DgvRecords.Columns.Item(5).Visible = False
        DgvRecords.Columns.Item(5).HeaderText = "Returns Reference"
        DgvRecords.Columns.Item(5).Width = 182
        'FromID
        DgvRecords.Columns.Item(6).Visible = False
        DgvRecords.Columns.Item(6).HeaderText = "Reference"
        DgvRecords.Columns.Item(6).Width = 182
        'ToID
        DgvRecords.Columns.Item(8).Visible = False
        DgvRecords.Columns.Item(7).HeaderText = "Reference"
        DgvRecords.Columns.Item(7).Width = 182
        'SMCreatedDate
        DgvRecords.Columns.Item(7).Visible = True
        DgvRecords.Columns.Item(3).HeaderText = "Qty"
        DgvRecords.Columns.Item(8).Width = 182
        'MovementQtyHangers
        DgvRecords.Columns.Item(9).Visible = True
        DgvRecords.Columns.Item(9).HeaderText = "Qty"
        DgvRecords.Columns.Item(9).Width = 182
        'SMLocation
        DgvRecords.Columns.Item(10).Visible = False
        DgvRecords.Columns.Item(10).HeaderText = "Reference"
        DgvRecords.Columns.Item(10).Width = 182
        ToolStripStatusLabel1.Text = "Returns"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Shop Return"
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        LoadStock(2)
        'StockCode
        DgvRecords.Columns.Item(0).Visible = True
        DgvRecords.Columns.Item(0).HeaderText = "Stock Code"
        DgvRecords.Columns.Item(0).Width = 120
        'SupplierRef
        DgvRecords.Columns.Item(1).Visible = True
        DgvRecords.Columns.Item(1).HeaderText = "Supplier Ref"
        DgvRecords.Columns.Item(1).Width = 80
        'Dead Code
        DgvRecords.Columns.Item(2).Visible = False
        DgvRecords.Columns.Item(2).HeaderText = "Dead Code"
        DgvRecords.Columns.Item(2).Width = 80
        DgvRecords.Columns.Item(2).DefaultCellStyle.Format = "Yes/No"
        'AmountTaken
        DgvRecords.Columns.Item(4).Visible = True
        DgvRecords.Columns.Item(4).HeaderText = "Amount Taken"
        DgvRecords.Columns.Item(4).Width = 80
        DgvRecords.Columns.Item(4).DefaultCellStyle.Format = "c"
        'DeliveredQtyHangers
        DgvRecords.Columns.Item(4).Visible = False
        DgvRecords.Columns.Item(4).Width = "10"
        'CostValue
        DgvRecords.Columns.Item(3).Visible = True
        DgvRecords.Columns.Item(3).HeaderText = "Cost Value"
        DgvRecords.Columns.Item(3).Width = 80
        DgvRecords.Columns.Item(3).DefaultCellStyle.Format = "c"
        'PCMarkUp
        DgvRecords.Columns.Item(5).HeaderText = "Markup"
        DgvRecords.Columns.Item(5).Width = 80
        DgvRecords.Columns.Item(5).DefaultCellStyle.Format = "p"
        'ZeroQty
        DgvRecords.Columns.Item(6).Visible = False
        DgvRecords.Columns.Item(6).Width = 0
        'Stock.CreatedDate
        ToolStripStatusLabel1.Text = "Stock"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Stock"
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub

    Private Sub AllStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllStockToolStripMenuItem.Click
        LoadStock(1)
        'StockCode
        DgvRecords.Columns.Item(0).Visible = True
        DgvRecords.Columns.Item(0).HeaderText = "Stock Code"
        DgvRecords.Columns.Item(0).Width = 120
        'SupplierRef
        DgvRecords.Columns.Item(1).Visible = True
        DgvRecords.Columns.Item(1).HeaderText = "Supplier Ref"
        DgvRecords.Columns.Item(1).Width = 80
        'Dead Code
        DgvRecords.Columns.Item(2).Visible = False
        DgvRecords.Columns.Item(2).HeaderText = "Dead Code"
        DgvRecords.Columns.Item(2).Width = 80
        DgvRecords.Columns.Item(2).DefaultCellStyle.Format = "Yes/No"
        'AmountTaken
        DgvRecords.Columns.Item(4).Visible = True
        DgvRecords.Columns.Item(4).HeaderText = "Amount Taken"
        DgvRecords.Columns.Item(4).Width = 80
        DgvRecords.Columns.Item(4).DefaultCellStyle.Format = "c"
        'DeliveredQtyHangers
        DgvRecords.Columns.Item(4).Visible = False
        DgvRecords.Columns.Item(4).Width = "10"
        'CostValue
        DgvRecords.Columns.Item(3).Visible = True
        DgvRecords.Columns.Item(3).HeaderText = "Cost Value"
        DgvRecords.Columns.Item(3).Width = 80
        DgvRecords.Columns.Item(3).DefaultCellStyle.Format = "c"
        'PCMarkUp
        DgvRecords.Columns.Item(5).HeaderText = "Markup"
        DgvRecords.Columns.Item(5).Width = 80
        DgvRecords.Columns.Item(5).DefaultCellStyle.Format = "p"
        'ZeroQty
        DgvRecords.Columns.Item(6).Visible = False
        DgvRecords.Columns.Item(6).Width = 0
        'Stock.CreatedDate
        ToolStripStatusLabel1.Text = "Stock"
        ToolStripStatusLabel2.Text = DgvRecords.Rows.Count
        Func = "Stock"
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        Mode = "New"
        Select Case Mode
            Case "Shop"

            Case "Supplier"

            Case "Stock"

            Case "Purchase Order"

            Case "Warehouse Adjustment"

            Case "Shop Delivery"

            Case "Shop Adjustment"

            Case "Shop Transfer"

            Case "Shop Sale"

            Case "Shop Return"

            Case Else
                MessageBox.Show("Unknown Function")
        End Select
    End Sub

    Private Sub RecordToolStripButton_Click(sender As Object, e As EventArgs) Handles RecordToolStripButton.Click
        Mode = "Old"
        Select Case Mode
            Case "Shop"

            Case "Supplier"

            Case "Stock"

            Case "Purchase Order"

            Case "Warehouse Adjustment"

            Case "Shop Delivery"

            Case "Shop Adjustment"

            Case "Shop Transfer"

            Case "Shop Sale"

            Case "Shop Return"

            Case Else
                MessageBox.Show("Unknown Function")
        End Select
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        Mode = "Delete"
        Select Case Mode
            Case "Shop"

            Case "Supplier"

            Case "Stock"

            Case "Purchase Order"

            Case "Warehouse Adjustment"

            Case "Shop Delivery"

            Case "Shop Adjustment"

            Case "Shop Transfer"

            Case "Shop Sale"

            Case "Shop Return"

            Case Else
                MessageBox.Show("Unknown Function")
        End Select
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshToolStripButton.Click
        Select Case Mode
            Case "Shop"
                ShopsToolStripMenuItem.PerformClick()
            Case "Supplier"
                SuppliersToolStripMenuItem.PerformClick()
            Case "Stock"
                StockToolStripMenuItem.PerformClick()
            Case "Purchase Order"
                PurchaseOrdersToolStripMenuItem.PerformClick()
            Case "Warehouse Adjustment"
                WarehouseAdjustmentsToolStripMenuItem.PerformClick()
            Case "Shop Delivery"
                ShopDeliveriesToolStripMenuItem.PerformClick()
            Case "Shop Adjustment"
                ShopAdjustmentsToolStripMenuItem.PerformClick()
            Case "Shop Transfer"
                ShopTransfersToolStripMenuItem.PerformClick()
            Case "Shop Sale"
                SalesToolStripMenuItem.PerformClick()
            Case "Shop Return"
                ReturnsToolStripMenuItem.PerformClick()
            Case Else
                MessageBox.Show("Unknown Function")
        End Select
    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click

    End Sub

    Private Sub ProveToolStripButton_Click(sender As Object, e As EventArgs) Handles ProveToolStripButton.Click

    End Sub

    Private Sub FindToolStripButton_Click(sender As Object, e As EventArgs) Handles FindToolStripButton.Click
        Select Case Mode
            Case "Shop"
                DataBinding.Filter = "[ShopRef] LIKE '" & FindInput.Text & "%'"
            Case "Supplier"
                DataBinding.Filter = "[SupplierRef] LIKE '" & FindInput.Text & "%'"
            Case "Stock"
                DataBinding.Filter = "[SupplierRef] LIKE '" & FindInput.Text & "%'"
            Case "Purchase Order"
                DataBinding.Filter = "[WarehouseRef] LIKE '" & FindInput.Text & "%'"
            Case "Warehouse Adjustment"
                DataBinding.Filter = "[WarehouseRef] LIKE '" & FindInput.Text & "%'"
            Case "Shop Delivery"
                DataBinding.Filter = "[ShopRef] LIKE '" & FindInput.Text & "%'"
            Case "Shop Adjustment"
                DataBinding.Filter = "[ShopRef] LIKE '" & FindInput.Text & "%'"
            Case "Shop Transfer"
                DataBinding.Filter = "[ShopRef] LIKE '" & FindInput.Text & "%'"
            Case "Shop Sale"
                DataBinding.Filter = "[ShopRef] LIKE '" & FindInput.Text & "%'"
            Case "Shop Return"
                DataBinding.Filter = "[ShopRef] LIKE '" & FindInput.Text & "%'"
            Case Else
                MessageBox.Show("Unknown Function")
        End Select
        DgvRecords.Refresh()
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
        FrmAboutBox.Show()
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

    Private Sub LoadStock(ID As Integer)
        ShopsToolStripMenuItem.BackColor = Nothing
        SettingsToolStripMenuItem.BackColor = Nothing
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
        If ID = 1 Then
            AllStockToolStripMenuItem.BackColor = Color.LightSkyBlue
            StockToolStripMenuItem.BackColor = Nothing
            LoadData(3)
        Else
            StockToolStripMenuItem.BackColor = Color.LightSkyBlue
            AllStockToolStripMenuItem.BackColor = Nothing
            LoadData(4)
        End If
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

    Private Sub DeleteRecords(funcID As Integer)
        Dim RowID As Integer
        Dim CellValue As String
        Dim data As New DataSet
        Dim tables As DataTableCollection = data.Tables
        Dim view1 As New DataView(tables(0))
        RowID = DgvRecords.CurrentRow.Index
        CellValue = DgvRecords.Item(0, RowID).Value
        Select Case Mode
            Case "Shop"
                Dim griddataadpter As New SqlDataAdapter("SELECT * from tblShops", Connection)
                griddataadpter.Fill(data, "tblShops")
                deleteShop(CellValue)
            Case "Supplier"
                Dim griddataadpter As New SqlDataAdapter("SELECT * from tblSuppliers", Connection)
                griddataadpter.Fill(data, "tblSuppliers")
            Case "Stock"

            Case "Purchase Order"
                Dim griddataadpter As New SqlDataAdapter("SELECT * from tblDeliveries order by deliveryDate desc", Connection)

            Case "Warehouse Adjustment"
                Dim griddataadpter As New SqlDataAdapter("SELECT * from qryWarehouseAdjustments", Connection)

            Case "Shop Delivery"
                Dim griddataadpter As New SqlDataAdapter("SELECT * from tblShopDeliveries", Connection)

            Case "Shop Adjustment"
                Dim griddataadpter As New SqlDataAdapter("SELECT * from qryShopAdjustments", Connection)

            Case "Shop Transfer"
                Dim griddataadpter As New SqlDataAdapter("SELECT * from tblShopTransfers", Connection)
                griddataadpter.Fill(data, "tblshopTransfers")
            Case "Shop Sale"
                Dim griddataadpter As New SqlDataAdapter("SELECT * from tblSales", Connection)

            Case "Shop Return"
                Dim griddataadpter As New SqlDataAdapter("SELECT * from qryReturns", Connection)
                griddataadpter.Fill(data, "qryReturns")
            Case Else
                MessageBox.Show("Unknown Function")
        End Select
    End Sub

    Private Sub deleteShop(ShopRef As String)
        DeleteCmd.Connection = Connection
        DeleteCmd.Connection.Open()
        DeleteCmd.CommandText = "DELETE FROM tblShops WHERE ShopRef='" & ShopRef & "'"
        DeleteCmd.CommandType = CommandType.Text
        DeleteCmd.ExecuteNonQuery()
        DeleteCmd.Connection.Close()
        ShopsToolStripMenuItem.PerformClick()
    End Sub
    Private Sub deleteSupplier(SupplierRef As String)

        Delcmd.Connection = conn
        Delcmd.Connection.Open()
        Delcmd.CommandType = CommandType.Text
        Delcmd.CommandText = "DELETE FROM tblSuppliers WHERE SupplierRef='" & CurrentID & "'"
        Delcmd.ExecuteNonQuery()
        Delcmd.Connection.Close()
        SuppliersToolStripMenuItem.PerformClick()
    End Sub
    Private Sub deletePurchaseOrder()
        Dim conn As New SqlConnection(ConnectionString)
        Dim deletecommand As New SqlCommand()
        Dim duplicatecommand As New SqlCommand()
        Dim data As New DataSet()
        Dim tables As DataTableCollection = data.Tables
        griddataadpter.Fill(data, "tblDeliveries")
        Dim view1 As New DataView(tables(0))
        Dim CurrentID As String
        Dim StockCode As String
        BindingSource1.DataSource = view1
        Dim i As Integer
        i = DgvRecords.CurrentRow.Index
        CurrentID = DgvRecords.Item(0, i).Value
        StockCode = DgvRecords.Item(6, i).Value.ToString
        DgvRecords.DataSource = BindingSource1

        Try
            Dim queryResult As Integer
            duplicatecommand.Connection = conn
            duplicatecommand.Connection.Open()
            duplicatecommand.CommandType = CommandType.Text
            duplicatecommand.CommandText = " SELECT COUNT(*) as numRows From tblStockMovements WHERE SMstockcode = '" + StockCode + "' AND MovementType <> 'Delivery (W)'"
            queryResult = duplicatecommand.ExecuteNonQuery()
            duplicatecommand.Connection.Close()
            If queryResult > 0 Then
                MessageBox.Show("Stock Record :" + StockCode + " Has Other records Unable to delete Purchase Order ", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Error in database", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        deletecommand.Connection = conn
        deletecommand.Connection.Open()
        deletecommand.CommandType = CommandType.Text
        deletecommand.CommandText = "DELETE FROM tblDeliveries WHERE DeliveriesID='" & CurrentID & "'"
        deletecommand.ExecuteNonQuery()
        deletecommand.Connection.Close()
        deletecommand.Connection = conn
        deletecommand.Connection.Open()
        deletecommand.CommandType = CommandType.Text
        deletecommand.CommandText = "DELETE FROM tblStockmovements WHERE TransferReference='" & CurrentID & "' AND MovementType = 'Delivery (W)'"
        deletecommand.ExecuteNonQuery()
        deletecommand.Connection.Close()
        ' MessageBox.Show("Purchase Order " + CurrentID + " Has been deleted")
        PurchaseOrdersToolStripMenuItem.PerformClick()

    End Sub
    Private Sub deleteWarehouseAdjustments()
        Dim conn As New SqlConnection(ConnectionString)
        Dim DeleteCommand As New SqlCommand()
        Dim data As New DataSet()
        Dim tables As DataTableCollection = data.Tables

        griddataadpter.Fill(data, "qryWarehouseAdjustments")
        Dim view1 As New DataView(tables(0))
        Dim CurrentID As String
        BindingSource1.DataSource = view1
        Dim i As Integer
        i = DgvRecords.CurrentRow.Index
        CurrentID = DgvRecords.Item(0, i).Value
        DgvRecords.DataSource = BindingSource1
        MessageBox.Show(CurrentID)
        DeleteCommand.Connection = conn
        DeleteCommand.Connection.Open()
        DeleteCommand.CommandType = CommandType.Text
        DeleteCommand.CommandText = "DELETE FROM tblStockmovements WHERE StockMovementID ='" & CurrentID & "'"
        DeleteCommand.ExecuteNonQuery()
        DeleteCommand.Connection.Close()
        '   MessageBox.Show("Warehouse Adjustment " + CurrentID + " Has been deleted")
        WarehouseAdjustmentsToolStripMenuItem.PerformClick()

    End Sub
    Private Sub deleteShopDelivery()
        Dim conn As New SqlConnection(ConnectionString)
        Dim Delcmd2 As New SqlCommand()

        Dim data As New DataSet()
        Dim tables As DataTableCollection = data.Tables

        griddataadpter.Fill(data, "tblshopDeliveries")
        Dim view1 As New DataView(tables(0))
        Dim CurrentID As String
        Dim DelNoteNumber As Integer
        BindingSource1.DataSource = view1
        Dim i As Integer
        i = DgvRecords.CurrentRow.Index
        CurrentID = DgvRecords.Item(0, i).Value
        DgvRecords.DataSource = BindingSource1
        '  MessageBox.Show(CurrentID)
        DelNoteNumber = DgvRecords.Item(0, i).Value
        Delcmd2.Connection = Connection
        Delcmd2.Connection.Open()
        Delcmd2.CommandType = CommandType.Text
        Delcmd2.CommandText = "DELETE from tblStockMovements where TransferReference = '" + CurrentID + "' AND MovementType = 'Delivery (S)';DELETE from tblShopDeliveriesLines where SDeliveriesID = '" + CurrentID + "';DELETE from tblShopDeliveries where DeliveriesID = '" + CurrentID + "'"
        Delcmd2.ExecuteNonQuery()
        Delcmd2.Connection.Close()
        ' Delcmd2.Connection = connection
        ' Delcmd2.Connection.Open()
        ' Delcmd2.CommandType = CommandType.Text
        ' deletecommand.CommandText = ""
        ' deletecommand.ExecuteNonQuery()
        ' deletecommand.Connection.Close()
        ' deletecommand.Connection = connection
        ' deletecommand.Connection.Open()
        ' deletecommand.CommandType = CommandType.Text
        ' deletecommand.CommandText = ""
        ' deletecommand.ExecuteNonQuery()
        ' deletecommand.Connection.Close()
        ShopDeliveriesToolStripMenuItem.PerformClick()
    End Sub
    Private Sub deleteShopAdjustments()
        Dim conn As New SqlConnection(ConnectionString)
        Dim Deletecommand As New SqlCommand()
        Dim data As New DataSet()
        Dim tables As DataTableCollection = data.Tables

        griddataadpter.Fill(data, "qryShopAdjustments")
        Dim view1 As New DataView(tables(0))
        Dim CurrentID As String
        'Dim reference As String
        BindingSource1.DataSource = view1
        Dim i As Integer
        i = DgvRecords.CurrentRow.Index
        CurrentID = DgvRecords.Item(0, i).Value
        DgvRecords.DataSource = BindingSource1
        '  MessageBox.Show(CurrentID)
        Deletecommand.Connection = conn
        Deletecommand.Connection.Open()
        Deletecommand.CommandType = CommandType.Text
        Deletecommand.CommandText = "DELETE FROM tblStockmovements WHERE StockMovementID ='" & CurrentID & "'"
        Deletecommand.ExecuteNonQuery()
        Deletecommand.Connection.Close()
        '   MessageBox.Show("Shop Adjustment " + CurrentID + " Has been deleted")
        ShopAdjustmentsToolStripMenuItem.PerformClick()
    End Sub
    Private Sub deleteShopSales()
        Dim conn As New SqlConnection(ConnectionString)
        Dim Deletecommand As New SqlCommand()
        Dim data As New DataSet()
        Dim tables As DataTableCollection = data.Tables

        griddataadpter.Fill(data, "tblsales")
        Dim view1 As New DataView(tables(0))
        Dim CurrentID As String
        BindingSource1.DataSource = view1
        Dim i As Integer
        i = DgvRecords.CurrentRow.Index
        CurrentID = DgvRecords.Item(0, i).Value
        DgvRecords.DataSource = BindingSource1
        '  MessageBox.Show("Sales Record " + CurrentID + "Has been deleted")
        Deletecommand.CommandType = CommandType.Text
        Deletecommand.CommandText = "Delete From tblSalesLines where SalesID='" + CurrentID + "';Delete from tblStockmovements where MovementType='Sale' AND TransferReference='" + CurrentID + "';Delete from tblSales where SalesID='" + CurrentID.ToString + "';"
        Deletecommand.Connection = Connection
        Deletecommand.Connection.Close()
        Deletecommand.Connection.Open()
        Deletecommand.ExecuteNonQuery()
        Deletecommand.Connection.Close()
        SalesToolStripMenuItem.PerformClick()
    End Sub
    Private Sub deleteShopTransfers()
        Dim conn As New SqlConnection(ConnectionString)
        Dim Deletecommand As New SqlCommand()
        Dim data As New DataSet()
        Dim tables As DataTableCollection = data.Tables


        Dim view1 As New DataView(tables(0))
        Dim CurrentID As String
        BindingSource1.DataSource = view1
        Dim i As Integer
        i = DgvRecords.CurrentRow.Index
        CurrentID = DgvRecords.Item(1, i).Value
        DgvRecords.DataSource = BindingSource1
        '  MessageBox.Show(CurrentID + " Has been deleted")
        Deletecommand.Connection = Connection
        Deletecommand.Connection.Open()
        Deletecommand.CommandType = CommandType.Text
        Deletecommand.CommandText = "DELETE from tblStockMovements where TransferReference = '" + CurrentID.ToString + "' AND MovementType='Shop Transfer';"
        Deletecommand.ExecuteNonQuery()
        Deletecommand.Connection.Close()
        Deletecommand.Connection = Connection
        Deletecommand.Connection.Open()
        Deletecommand.CommandType = CommandType.Text
        Deletecommand.CommandText = "DELETE from tblShopTransferLines where TransferID = '" + CurrentID.ToString + "'"
        Deletecommand.ExecuteNonQuery()
        Deletecommand.Connection.Close()
        Deletecommand.Connection = Connection
        Deletecommand.Connection.Open()
        Deletecommand.CommandType = CommandType.Text
        Deletecommand.CommandText = "DELETE from tblShopTransfers where TransferID = '" + CurrentID.ToString + "'"
        Deletecommand.ExecuteNonQuery()
        Deletecommand.Connection.Close()
        ShopTransfersToolStripMenuItem.PerformClick()
    End Sub
    Private Sub deleteReturns()
        Dim conn As New SqlConnection(ConnectionString)
        Dim Deletecommand As New SqlCommand()
        Dim data As New DataSet()
        Dim tables As DataTableCollection = data.Tables


        Dim view1 As New DataView(tables(0))
        Dim CurrentID As String
        BindingSource1.DataSource = view1
        Dim i As Integer
        Dim reference As String
        i = DgvRecords.CurrentRow.Index
        CurrentID = DgvRecords.Item(5, i).Value
        DgvRecords.DataSource = BindingSource1
        ' MessageBox.Show(CurrentID)

        reference = DgvRecords.Item(1, i).Value
        '     DateTimePicker1.Value = Main.DgvRecords.Item(9, i).Value
        Deletecommand.Connection = Connection
        Deletecommand.Connection.Open()
        Deletecommand.CommandType = CommandType.Text
        Deletecommand.CommandText = "DELETE from tblStockMovements where Reference = '" + CurrentID + "' AND MovementType = 'return'"
        Deletecommand.ExecuteNonQuery()
        Deletecommand.Connection.Close()
        Dim DeleteCommand2 As New SqlCommand With {
            .Connection = Connection,
            .CommandType = CommandType.Text,
            .CommandText = "DELETE from tblReturn where TFNote ='" + reference.ToString + "'"
        }
        DeleteCommand2.Connection.Close()
        DeleteCommand2.Connection.Open()
        DeleteCommand2.ExecuteNonQuery()
        DeleteCommand2.Connection.Close()
        ReturnsToolStripMenuItem.PerformClick()
    End Sub
    Private Sub deleteStock()
        Dim conn As New SqlConnection(ConnectionString)
        Dim Deletecommand As New SqlCommand()
        Dim data As New DataSet()
        Dim tables As DataTableCollection = data.Tables
        Dim griddataadpter As New SqlDataAdapter("SELECT * from tblStock", Connection)
        griddataadpter.Fill(data, "tblstock")
        Dim view1 As New DataView(tables(0))
        Dim CurrentID As String
        BindingSource1.DataSource = view1
        Dim i As Integer
        i = DgvRecords.CurrentRow.Index
        CurrentID = DgvRecords.Item(0, i).Value
        DgvRecords.DataSource = BindingSource1
        MessageBox.Show(CurrentID)
        cmd.Connection = Connection
        cmd.Connection.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "DELETE FROM tblStock WHERE StockCode='" & CurrentID.ToString & "'"
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        StockToolStripMenuItem.PerformClick()
    End Sub
End Class