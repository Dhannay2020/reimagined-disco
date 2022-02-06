Imports System.Data.SqlClient

Public Class ClsDelete

End Class
Public Class CCheck
    Dim ut As New CUtils
    Dim result As Integer
    Public Function SaveWarehouse() As Boolean
        Return True
    End Function
    Public Function SaveShops() As Boolean
        Return True
    End Function
    Public Function SaveSupplier() As Boolean
        Return True
    End Function
    Public Function SaveStock() As Boolean

        Return True
    End Function
    Public Function SavePOrders() As Integer
        Using conn As New SqlConnection(ut.GetConnString())
            Dim selectCmd As New SqlCommand
            With selectCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(DeliveriesID) as MaxRef from tblDeliveries"
            End With
            result = selectCmd.ExecuteScalar
        End Using
        Return result
    End Function
    Public Function SaveWHAdjustHead() As Integer
        Using conn As New SqlConnection(ut.GetConnString())
            Dim selectCmd As New SqlCommand
            With selectCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(ID) as MaxRef from tblWarehouseAdjustments"
            End With
            result = selectCmd.ExecuteScalar
        End Using
        Return result
    End Function

    Public Function SaveShopDelHead() As Integer
        Using conn As New SqlConnection(ut.GetConnString())
            Dim selectCmd As New SqlCommand
            With selectCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(DeliveriesID) as MaxRef from tblShopDeliveries"
            End With
            result = selectCmd.ExecuteScalar
        End Using
        Return result
    End Function

    Public Function SaveShopAdjustHead() As Integer
        Using conn As New SqlConnection(ut.GetConnString())
            Dim selectCmd As New SqlCommand
            With selectCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(ID) as MaxRef from tblShopAdjustments"
            End With
            result = selectCmd.ExecuteScalar
        End Using
        Return result
    End Function

    Public Function SaveShopTransHead() As Integer
        Using conn As New SqlConnection(ut.GetConnString())
            Dim selectCmd As New SqlCommand
            With selectCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(TransferID) as MaxRef from tblShopTransfers"
            End With
            result = selectCmd.ExecuteScalar
        End Using
        Return result
    End Function

    Public Function SaveShopSalesHead() As Integer
        Using conn As New SqlConnection(ut.GetConnString())
            Dim selectCmd As New SqlCommand
            With selectCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(SalesID) as MaxRef from tblSales"
            End With
            result = selectCmd.ExecuteScalar
        End Using
        Return result
    End Function

    Public Function SaveShopReturnsHead() As Integer
        Using conn As New SqlConnection(ut.GetConnString())
            Dim selectCmd As New SqlCommand
            With selectCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(ReturnsID) as MaxRef from tblReturns"
            End With
            result = selectCmd.ExecuteScalar
        End Using
        Return result
    End Function
    Public Function SaveWHReturns() As Integer
        Using conn As New SqlConnection(ut.GetConnString())
            Dim selectCmd As New SqlCommand
            With selectCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(ID) as MaxRef from tblWReturns"
            End With
            result = selectCmd.ExecuteScalar
        End Using
        Return result
    End Function
    Public Function CheckStockCode(StockCode As String) As Boolean
        Dim result As Integer
        Dim returnresult As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim selectcmd As New SqlCommand
            With selectcmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT COUNT(*) AS numRows From tblStock WHERE StockCode =@StockCode"
                .Parameters.AddWithValue("@StockCode", StockCode)
                result = .ExecuteScalar
            End With
        End Using
        If result = 0 Then returnresult = True
        If result = 1 Then returnresult = False
        Return returnresult
    End Function
End Class
Public Class CLoad
    Dim ut As New CUtils()
    Dim connstring As String = ut.GetConnString()

    Public Sub LoadWarehouse(WarehouseRef As String)
        Dim objform As New FrmWarehouse
        With objform
            .TxtWarehouseRef.Text = WarehouseRef
            .TxtWarehouseRef.Enabled = False
            .CmdOK.Text = "OK"
            .CmdClear.Enabled = False
            .Show()
        End With
    End Sub
    Public Sub LoadSupplier(SupplierRef As String)
        Dim objform As New FrmSupplier
        With objform
            .TxtSupplierRef.Text = SupplierRef
            .TxtSupplierRef.Enabled = False
            .CmdOK.Text = "OK"
            .CmdClear.Enabled = False
            .Show()
        End With
    End Sub
    Public Sub LoadStock(StockCode As String, SFunction As String)
        Dim objform As New FrmStock
        With objform
            .StockCodeTextBox.Enabled = False
            Using conn As New SqlConnection(connstring)
                Dim dt As New DataTable
                Dim adp As New SqlDataAdapter With {.SelectCommand = New SqlCommand("SELECT * from qryStockValuesPC1 WHERE StockCode = '" + StockCode + "'", conn)}
                conn.Open()
                adp.Fill(dt)
                .StockCodeTextBox.Text = dt.Rows(0).Item("StockCode")
                .SupplierRefTextBox.Text = dt.Rows(0).Item("SupplierRef")
                .DeadCodeCheckBox.Checked = dt.Rows(0).Item("DeadCode")
                .AmountTakenTextBox.Text = dt.Rows(0).Item("SalesAmount")
                .CostValueTextBox.Text = dt.Rows(0).Item("CostValue")
                .PCMarkUpTextBox.Text = dt.Rows(0).Item("PCMarkUp")
                .PCMarkUpTextBox.Text = FormatPercent(.PCMarkUpTextBox.Text)
                .AmountTakenTextBox.Text = FormatCurrency(.AmountTakenTextBox.Text)
                .CostValueTextBox.Text = FormatCurrency(.CostValueTextBox.Text)
                '.sd = SFunction
            End Using
        End With
        objform.CmdOK.Text = "OK"
        objform.StockCodeTextBox.Enabled = False
        objform.Show()
    End Sub
    Public Sub LoadShop(shopref As String)
        Dim objform As New FrmShop()
        With objform
            .TxtShopRef.Enabled = False
            .CmdOK.Text = "OK"
            .TxtShopRef.Text = shopref
            .Show()
        End With
    End Sub
    Public Sub LoadPOrder(ID As Integer)
        Dim objForm As New FrmPurchaseOrder
        With objForm
            .txtOrderID.Enabled = False
            .cmdOK.Text = "OK"
            .txtOrderID.Text = ID.ToString
            .Show()
        End With
    End Sub
    Public Sub LoadShopAdjust(ID As Integer)
        Dim objform As New FrmShopAdjustment()
        With objform
            .TxtSID.Text = ID.ToString()
            .CmdOK.Text = "OK"
            .TxtSID.Enabled = False
            .CmdClear.Enabled = False
            .Text = "Shop Adjustment for [" + .txtWarehouseName.Text + "]"
            .Show()
        End With
    End Sub
    Public Sub LoadShopDelivery(ID As Integer)
        Dim objform As New FrmShopDelivery()
        With objform
            .txtDelNoteNumber.Text = ID.ToString()
            .txtDelNoteNumber.Enabled = False
            .cmdAdd.Text = "OK"
            .Show()
        End With
    End Sub

    Public Sub LoadShopSale(ID As Integer)
        Dim objform As New FrmShopSale
        With objform
            .txtSalesID.Text = ID.ToString()
            .cmdOK.Text = "OK"
            .txtSalesID.Enabled = False
            .Show()
        End With
    End Sub
    Public Sub LoadShopReturn(ID As Integer)
        Dim objform As New FrmShopReturn
        With objform
            .txtReturnID.Text = ID.ToString()
            .txtReturnID.Enabled = False
            .cmdOK.Text = "OK"
            .cmdClear.Enabled = False
            .Show()
        End With
    End Sub
    Public Sub LoadShopTrans(ID As Integer)
        Dim objform As New FrmShopTransfer
        With objform
            .TxtTransferID.Text = ID.ToString()
            .TxtTransferID.Enabled = False
            .CmdOK.Text = "OK"
            .CmdClear.Enabled = False
            .Show()
        End With

    End Sub

    Public Sub LoadWarehouseAdjust(ID As Integer)
        Dim objform As New FrmWarehouseAdjustment
        With objform
            .TxtRecordID.Text = ID.ToString()
            .CmdOK.Text = "OK"
            .CmdClear.Enabled = False
            .Show()
        End With
    End Sub
    Public Sub LoadWarehouseReturn(ID As Integer)
        Dim objform As New FrmWarehouseReturn
        With objform

        End With

    End Sub
End Class
Public Class CReports
    Dim syslog As New CSystemLog
    Dim ut As New CUtils
    Private Sub AddToLog()
        syslog.SaveSystemLog("All", "All", "All", 0, "Reports Gen", "Reports Gen", Date.Now, "Full Reports Generated")
    End Sub
    Private Sub DeleteTempTables(table As String)
        Using conn As New SqlConnection(ut.GetConnString())
            Dim delCmd As New SqlCommand
            With delCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "DELETE from " + table
                .ExecuteNonQuery()
            End With
        End Using
    End Sub
    Private Function checkrecords(table As String) As Integer
        Dim QueryResult As Integer
        Using conn As New SqlConnection(ut.GetConnString())
            Dim cmd As New SqlCommand
            With cmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT COUNT(*) as numRows From " + table
                QueryResult = .ExecuteScalar
            End With
        End Using
        Return QueryResult
    End Function
    Public Sub DeleteOldData()
        AddToLog()
        Dim result, result2, result3, result4, result5, result6, result7, result8, result9 As Integer
        result = checkrecords("tblSalesThisWeek")
        result2 = checkrecords("tblCurrentStock")
        result3 = checkrecords("tblShopStockReport")
        result4 = checkrecords("tblStockRepTotalDelivered")
        result5 = checkrecords("tblStockRepTotalGain")
        result6 = checkrecords("tblStockRepTotalLoss")
        result7 = checkrecords("tblStockRepTotalSold")
        result8 = checkrecords("tblStockRepTransfers")
        result9 = checkrecords("tblStockMovementsDate")
        If result > 0 Then DeleteTempTables("tblSalesThisWeek")
        If result2 > 0 Then DeleteTempTables("tblCurrentStock")
        If result3 > 0 Then DeleteTempTables("tblShopStockReport")
        If result4 > 0 Then DeleteTempTables("tblStockRepTotalDelivered")
        If result5 > 0 Then DeleteTempTables("tblStockRepTotalGain")
        If result6 > 0 Then DeleteTempTables("tblStockRepTotalLoss")
        If result7 > 0 Then DeleteTempTables("tblStockRepTotalSold")
        If result8 > 0 Then DeleteTempTables("tblStockRepTransfers")
        If result9 > 0 Then DeleteTempTables("tblStockMovementsDate")
    End Sub
    Public Sub CreateTempMovements(dte As Date, dte2 As Date)
        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlString As String = "Insert INTo tblStockMovementsDate(StockCode,SupplierRef,Location,LocationType,MovementType,MovementQtyHangers,MovementQtyBoxes,MovementDate,MovementValue,Reference,TransferReference,CreatedBy,CreatedDate) SELECT dbo.tblStockMovements.SMStockCode,dbo.tblStockMovements.SMSupplierRef,dbo.tblStockMovements.SMLocation,dbo.tblStockMovements.SMLocationType,dbo.tblStockMovements.MovementType,dbo.tblStockMovements.MovementQtyHangers,dbo.tblStockMovements.MovementQtyBoxes,dbo.tblStockMovements.MovementDate,dbo.tblStockMovements.MovementValue,dbo.tblStockMovements.Reference,dbo.tblStockMovements.TransferReference,dbo.tblStockMovements.SMCreatedBy,dbo.tblStockMovements.SMCreatedDate FROM dbo.tblStockMovements WHERE (dbo.tblStockMovements.MovementDate > @Date1) AND (dbo.tblStockMovements.MovementDate <= @Date2) GROUP BY dbo.tblStockMovements.SMStockCode,dbo.tblStockMovements.SMSupplierRef,dbo.tblStockMovements.SMLocation,dbo.tblStockMovements.SMLocationType,dbo.tblStockMovements.MovementType,dbo.tblStockMovements.MovementQtyHangers,dbo.tblStockMovements.MovementQtyBoxes,dbo.tblStockMovements.MovementDate,dbo.tblStockMovements.MovementValue,dbo.tblStockMovements.Reference,dbo.tblStockMovements.TransferReference,dbo.tblStockMovements.SMCreatedBy,dbo.tblStockMovements.SMCreatedDate;"
            Dim SCommand As New SqlCommand(sqlString, conn)
            SCommand.Parameters.AddWithValue("@Date1", dte)
            SCommand.Parameters.AddWithValue("@Date2", dte2)
            SCommand.Connection.Open()
            SCommand.ExecuteNonQuery()
        End Using
        ' End Sub
        ' Public Sub CreateStockListReport(dte As DateTime, dte2 As DateTime)
        Using conn As New SqlConnection(ut.GetConnString())
            '    Dim sqlString As String = "Insert INTo tblShopStockReport (ShopName,Location,Type,StockCode,DeadCode,TotalSold,CurrentQty,QtyDel,TranIn,TranOut,QtyUp,QtyDown) SELECT dbo.tblShops.ShopName, dbo.tblStockMovements.SMLocation, dbo.tblShops.ShopType, dbo.tblStockMovements.SMStockCode, dbo.tblStock.DeadCode,ISNULL(SUM(dbo.ssrStockmovementsShopSales.MovementQtyHangers * - 1), 0) AS TotalSold, '0' AS CurrentQty, ISNULL(SUM(dbo.ssrStockMovementsShopDelivery.MovementQtyHangers), 0) AS QtyDel, ISNULL(SUM(dbo.ssrStockMovementsShopTransfer.TransferIn), 0) AS TranIn, ISNULL(SUM(dbo.ssrStockMovementsShopTransfer.TransferOut), 0) AS TranOut,               ISNULL(SUM(dbo.ssrStockMovementsShopGain.MovementQtyHangers), 0) AS QtyUp, ISNULL(SUM(dbo.ssrStockMovementsShopLoss.MovementQtyHangers), 0) AS QtyDown FROM  dbo.tblShops INNER JOIN dbo.tblStockMovements ON dbo.tblShops.ShopRef = dbo.tblStockMovements.SMLocation LEFT OUTER JOIN dbo.ssrStockMovementsShopTransfer ON dbo.tblStockMovements.StockMovementID = dbo.ssrStockMovementsShopTransfer.StockMovementID LEFT OUTER JOIN                       dbo.ssrStockMovementsShopLoss ON dbo.tblStockMovements.MovementQtyHangers = dbo.ssrStockMovementsShopLoss.MovementQtyHangers AND dbo.tblStockMovements.StockMovementID = dbo.ssrStockMovementsShopLoss.StockMovementID LEFT OUTER JOIN                         dbo.ssrStockMovementsShopDelivery ON dbo.tblStockMovements.MovementQtyHangers = dbo.ssrStockMovementsShopDelivery.MovementQtyHangers AND dbo.tblStockMovements.StockMovementID = dbo.ssrStockMovementsShopDelivery.StockMovementID LEFT OUTER JOIN dbo.ssrStockmovementsShopSales ON dbo.tblStockMovements.MovementQtyHangers = dbo.ssrStockmovementsShopSales.MovementQtyHangers AND dbo.tblStockMovements.StockMovementID = dbo.ssrStockmovementsShopSales.StockMovementID LEFT OUTER JOIN dbo.ssrStockMovementsShopGain ON dbo.tblStockMovements.StockMovementID = dbo.ssrStockMovementsShopGain.StockMovementID FULL OUTER JOIN dbo.tblStock ON dbo.tblStockMovements.SMStockCode = dbo.tblStock.StockCode WHERE (dbo.tblStockMovements.MovementDate > @date1) AND (dbo.tblStockMovements.MovementDate < @date2) OR (dbo.tblStockMovements.MovementType = N'Delivery (S)') OR (dbo.tblStockMovements.MovementType = N'Stock Gain') OR (dbo.tblStockMovements.MovementType = N'Stock Loss') OR                        (dbo.tblStockMovements.MovementType = N'Shop Transfer') OR (dbo.tblStockMovements.MovementType = N'Sale') GROUP BY dbo.tblShops.ShopName, dbo.tblStockMovements.SMLocation, dbo.tblShops.ShopType, dbo.tblStockMovements.SMStockCode, dbo.tblStock.DeadCode"
            Dim sqlString2 As String = "Insert INTo tblShopStockReport (ShopName,Location,Type,StockCode,DeadCode,TotalSold,CurrentQty,QtyDel,TranIn,TranOut,QtyUp,QtyDown) SELECT  dbo.tblShops.ShopName, dbo.tblStockMovementsDate.Location, dbo.tblShops.ShopType, dbo.tblStockMovementsDate.StockCode, tblStock.DeadCode,'0' AS TotalSold, '0' AS CurrentQty, '0' AS QtyDel, '0' AS TranIn, '0' AS TranOut, '0' AS QtyUp, '0' AS QtyDown FROM dbo.tblStockMovementsDate INNER JOIN dbo.tblStock ON dbo.tblStockMovementsDate.StockCode = dbo.tblStock.StockCode RIGHT OUTER JOIN dbo.tblShops ON dbo.tblStockMovementsDate.Location = dbo.tblShops.ShopRef GROUP BY dbo.tblShops.ShopName, dbo.tblStockMovementsDate.Location, dbo.tblShops.ShopType,dbo.tblStock.DeadCode, dbo.tblStockMovementsDate.StockCode HAVING (dbo.tblStockMovementsDate.Location <> N'UNI')"
            Dim SCommand As New SqlCommand(sqlString2, conn)
            SCommand.Parameters.AddWithValue("@Date1", dte)
            SCommand.Parameters.AddWithValue("@Date2", dte2)
            SCommand.Connection.Open()
            SCommand.ExecuteNonQuery()
        End Using

        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "INSERT INTO tblStockRepTotalDelivered (StockCode,Location,Qty) SELECT StockCode,Location, SUM(MovementQtyHangers) AS Expr1 FROM  dbo.tblStockMovementsDate GROUP BY StockCode,Location, MovementType HAVING (MovementType = N'Delivery (S)') AND (Location <> N'UNI')"
            Dim SCommand As New SqlCommand(sqlstring, conn)
            SCommand.Connection.Open()
            SCommand.ExecuteNonQuery()
        End Using

        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlString As String = "INSERT INTO tblCurrentStock (StockCode,Location,Qty) SELECT dbo.tblStockMovementsDate.StockCode,dbo.tblStockMovementsDate.Location, SUM(dbo.tblStockMovementsDate.MovementQtyHangers) AS Qty FROM dbo.tblStockMovementsDate INNER JOIN dbo.tblStock ON dbo.tblStockMovementsDate.StockCode = dbo.tblStock.StockCode WHERE (dbo.tblStockMovementsDate.LocationType = 'Shop') AND (dbo.tblStockMovementsDate.MovementType = 'Delivery (S)' OR                    dbo.tblStockMovementsDate.MovementType = 'Sale' OR dbo.tblStockMovementsDate.MovementType = 'Shop Transfer' OR dbo.tblStockMovementsDate.MovementType = 'Stock Gain' OR dbo.tblStockMovementsDate.MovementType = 'Stock Loss' OR   dbo.tblStockMovementsDate.MovementType = 'Return') AND (dbo.tblStock.DeadCode = 0) GROUP BY dbo.tblStockMovementsDate.Location, dbo.tblStockMovementsDate.StockCode"
            Dim SCommand As New SqlCommand(sqlString, conn)
            SCommand.Connection.Open()
            SCommand.ExecuteNonQuery()
        End Using

        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "INSERT INTO tblStockRepTotalGain (StockCode,Location,Qty) SELECT StockCode,Location, SUM(MovementQtyHangers) AS Expr1 FROM   dbo.tblStockMovementsDate GROUP BY StockCode,Location, MovementType HAVING (MovementType = N'Stock Gain') AND (Location <> N'UNI')"
            Dim SCommand As New SqlCommand(sqlstring, conn)
            SCommand.Connection.Open()
            SCommand.ExecuteNonQuery()
        End Using

        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "INSERT INTO tblStockRepTotalLoss (StockCode,Location,Qty) SELECT StockCode,Location, SUM(MovementQtyHangers) AS Expr1 FROM   dbo.tblStockMovementsDate GROUP BY StockCode,Location, MovementType HAVING (MovementType = N'Stock Loss') AND (Location <> N'UNI')"
            Dim SCommand As New SqlCommand(sqlstring, conn)
            SCommand.Connection.Open()
            SCommand.ExecuteNonQuery()
        End Using

        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "INSERT INTO tblStockRepTotalSold (StockCode,Location,Qty) SELECT StockCode,Location, SUM(MovementQtyHangers * -1) AS Expr1 FROM   dbo.tblStockMovementsDate GROUP BY StockCode,Location, MovementType HAVING (MovementType = N'Sale') AND (Location <> N'UNI')"
            Dim SCommand As New SqlCommand(sqlstring, conn)
            SCommand.Connection.Open()
            SCommand.ExecuteNonQuery()
        End Using

        Using conn As New SqlConnection(ut.GetConnString())
            Dim cmd As New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO tblStockRepTransfers (StockCode,Location,LocationType,MovementType,TransferIn,TransferOut)SELECT StockCode, Location, LocationType, MovementType, ISNULL(TransferIn,0), ISNULL(TransferOut,0) FROM qryStockMovementsShopTransfer"
                .CommandType = CommandType.Text
                .Connection.Open()
                .ExecuteNonQuery()
            End With
        End Using
    End Sub
    Public Sub UpdateStockReport()
        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqestring As String = "UPDATE tblShopStockReport SET SoldThisWeek = ISNULL(tblSalesThisWeek.Qty,0) FROM tblShopStockReport,tblSalesThisWeek WHERE(tblShopStockReport.StockCode = tblSalesThisWeek.StockCode) AND (tblShopStockReport.Location = tblSalesThisWeek.ShopRef)"
            Dim scommand As New SqlCommand(sqestring, conn)
            scommand.Connection.Open()
            scommand.ExecuteNonQuery()
        End Using
        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "UPDATE tblShopStockReport SET CurrentQty = tblCurrentStock.Qty FROM tblShopStockReport,tblCurrentStock WHERE (tblShopStockReport.StockCode = tblCurrentStock.StockCode) AND (tblShopStockReport.Location = tblCurrentStock.Location)"
            Dim scommand As New SqlCommand(sqlstring, conn)
            scommand.Connection.Open()
            scommand.ExecuteNonQuery()
        End Using
        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "UPDATE tblShopStockReport SET TotalSold = tblStockRepTotalSold.Qty FROM tblShopStockReport,tblStockRepTotalSold WHERE (tblShopStockReport.StockCode = tblStockRepTotalSold.StockCode) AND (tblShopStockReport.Location = tblStockRepTotalSold.Location)"
            Dim scommand As New SqlCommand(sqlstring, conn)
            scommand.Connection.Open()
            scommand.ExecuteNonQuery()
        End Using
        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "UPDATE tblShopStockReport SET QtyDel = tblStockRepTotalDelivered.Qty FROM tblShopStockReport,tblStockRepTotalDelivered WHERE (tblShopStockReport.StockCode = tblStockRepTotalDelivered.StockCode) AND (tblShopStockReport.Location = tblStockRepTotalDelivered.Location)"
            Dim scommand As New SqlCommand(sqlstring, conn)
            scommand.Connection.Open()
            scommand.ExecuteNonQuery()
        End Using
        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "UPDATE tblShopStockReport SET QtyUp = tblStockRepTotalGain.Qty FROM tblShopStockReport,tblStockRepTotalGain WHERE (tblShopStockReport.StockCode = tblStockRepTotalGain.StockCode) AND (tblShopStockReport.Location = tblStockRepTotalGain.Location)"
            Dim scommand As New SqlCommand(sqlstring, conn)
            scommand.Connection.Open()
            scommand.ExecuteNonQuery()
        End Using
        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "UPDATE tblShopStockReport SET QtyDown = tblStockRepTotalLoss.Qty FROM tblShopStockReport,tblStockRepTotalLoss WHERE (tblShopStockReport.StockCode = tblStockRepTotalLoss.StockCode) AND (tblShopStockReport.Location = tblStockRepTotalLoss.Location)"
            Dim scommand As New SqlCommand(sqlstring, conn)
            scommand.Connection.Open()
            scommand.ExecuteNonQuery()
        End Using
        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "UPDATE tblShopStockReport SET TranIn = tblStockRepTransfers.TransferIn FROM tblShopStockReport,tblStockRepTransfers WHERE (tblShopStockReport.StockCode = tblStockRepTransfers.StockCode) AND (tblShopStockReport.Location = tblStockRepTransfers.Location)"
            Dim scommand As New SqlCommand(sqlstring, conn)
            scommand.Connection.Open()
            scommand.ExecuteNonQuery()
        End Using
        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlstring As String = "UPDATE tblShopStockReport SET TranOut = tblStockRepTransfers.TransferOut FROM tblShopStockReport,tblStockRepTransfers WHERE (tblShopStockReport.StockCode = tblStockRepTransfers.StockCode) AND (tblShopStockReport.Location = tblStockRepTransfers.Location)" '
            Dim scommand As New SqlCommand(sqlstring, conn)
            scommand.Connection.Open()
            scommand.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub SalesThisWeekGen(dte As Date, dte2 As Date)
        Using conn As New SqlConnection(ut.GetConnString())
            Dim sqlString As String = "INSERT INTO tblSalesThisWeek (ShopRef,StockCode,Qty,Date) SELECT tblSales.ShopRef,tblSalesLines.StockCode,SUM(tblSalesLines.QtySold) AS Qty,tblSales.TransactionDate FROM tblSales INNER JOIN tblSalesLines ON tblSales.SalesID = tblSalesLines.SalesID GROUP By tblSales.ShopRef,tblSalesLines.StockCode,tblSales.TransactionDate HAVING (((tblSales.TransactionDate) = @Date2));"
            ' Dim sqlString As String = "INSERT INTO tblSalesThisWeek (ShopRef,StockCode,Qty,Date) SELECT SMLocation,SMStockCode,Sales,MovementDate From qrySalesWeek Group By SMLocation,SMStockCode,Sales,MovementDate HAVING (((qrySalesWeek.MovementDate) = @Date2));"
            Dim SCommand As New SqlCommand()
            With SCommand
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = sqlString
                .Connection.Open()
                .Parameters.AddWithValue("@Date2", dte2)
                '  .ExecuteNonQueryAsync()
                .ExecuteNonQuery()
            End With
            '  SCommand.Connection.Open()
            ' SCommand.Parameters.AddWithValue("@Date1", dte)
            '  SCommand.Parameters.AddWithValue("@Date2", dte2)
            '  SCommand.ExecuteNonQuery()
        End Using
    End Sub
End Class
Public Class CSave
    Dim ut As New CUtils
    Dim username As String = ut.GetUserName()
    Public Function SaveWarehouse(WarehouseRef As String, WarehouseName As String, Address1 As String, Address2 As String, Address3 As String, Address4 As String, PostCode As String, ContactName As String, Telephone As String, Telephone2 As String, Fax As String, eMail As String, Memo As String, WarehouseType As String) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim cmd As New SqlCommand
            With cmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblWarehouses (WarehouseRef,WarehouseName,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,eMail,WarehouseType,Memo,CreatedBy,CreatedDate) VALUES (@WarehouseRef,@WarehouseName,@Address1,@Address2,@Address3,@Address4,@PostCode,@ContactName,@Telephone,@Telephone2,@Fax,@eMail,@WarehouseType,@Memo,@CreatedBy,@CreatedDate)"
                With .Parameters
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@WarehouseName", WarehouseName)
                    .AddWithValue("@Address1", Address1)
                    .AddWithValue("@Address2", Address2)
                    .AddWithValue("@Address3", Address3)
                    .AddWithValue("@Address4", Address4)
                    .AddWithValue("@PostCode", PostCode)
                    .AddWithValue("@ContactName", ContactName)
                    .AddWithValue("@Telephone", Telephone)
                    .AddWithValue("@Telephone2", Telephone2)
                    .AddWithValue("@Fax", Fax)
                    .AddWithValue("@eMail", eMail)
                    .AddWithValue("@Memo", Memo)
                    .AddWithValue("@WarehouseType", WarehouseType)
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShops(ShopRef As String, ShopName As String, Address1 As String, Address2 As String, Address3 As String, Address4 As String, PostCode As String, ContactName As String, Telephone As String, Telephone2 As String, Fax As String, eMail As String, Memo As String, ShopType As String) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim cmd As New SqlCommand
            With cmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShops (ShopRef,ShopName,ContactName,Street,Area,Town,County,Country,PostCode,Telephone,Telephone2,Fax,eMail,ShopType,Memo,CreatedBy,CreatedDate) VALUES (@ShopRef,@ShopName,@ContactName,@Street,@Area,@Town,@County,@Country,@PostCode,@Telephone,@Telephone2,@Fax,@eMail,@ShopType,@Memo,@CreatedBy,@CreatedDate)"
                With .Parameters
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@ShopName", ShopName)
                    .AddWithValue("@Street", Address1)
                    .AddWithValue("@Area", Address2)
                    .AddWithValue("@Town", Address3)
                    .AddWithValue("@County", Address4)
                    .AddWithValue("@Country", "UK")
                    .AddWithValue("@PostCode", PostCode)
                    .AddWithValue("@ContactName", ContactName)
                    .AddWithValue("@Telephone", Telephone)
                    .AddWithValue("@Telephone2", Telephone2)
                    .AddWithValue("@Fax", Fax)
                    .AddWithValue("@eMail", eMail)
                    .AddWithValue("@Memo", Memo)
                    .AddWithValue("@ShopType", ShopType)
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveSupplier(SupplierRef As String, SupplierName As String, Address1 As String, Address2 As String, Address3 As String, Address4 As String, PostCode As String, ContactName As String, Telephone As String, Telephone2 As String, Fax As String, eMail As String, Memo As String) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim cmd As New SqlCommand
            With cmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblSuppliers (SupplierRef,SupplierName,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,eMail,Memo,CreatedBy,CreatedDate) VALUES (@SupplierRef,@SupplierName,@Address1,@Address2,@Address3,@Address4,@PostCode,@ContactName,@Telephone,@Telephone2,@Fax,@eMail,@Memo,@CreatedBy,@CreatedDate)"
                With .Parameters
                    .AddWithValue("@SupplierRef", SupplierRef)
                    .AddWithValue("@SupplierName", SupplierName)
                    .AddWithValue("@Address1", Address1)
                    .AddWithValue("@Address2", Address2)
                    .AddWithValue("@Address3", Address3)
                    .AddWithValue("@Address4", Address4)
                    .AddWithValue("@PostCode", PostCode)
                    .AddWithValue("@ContactName", ContactName)
                    .AddWithValue("@Telephone", Telephone)
                    .AddWithValue("@Telephone2", Telephone2)
                    .AddWithValue("@Fax", Fax)
                    .AddWithValue("@eMail", eMail)
                    .AddWithValue("@Memo", Memo)
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SavePOrders(supplierRef As String, suppliername As String, locationref As String, locationname As String, stockcode As String, totalg As Integer, netamount As Decimal, commission As Decimal, delcharge As Decimal, totalv As Decimal, dte As Date, notes As String, invoice As String, shipper As String, shipperinv As String) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim insCmd As New SqlCommand
            With insCmd
                .Connection = conn
                .CommandText = "INSERT INTO tblDeliveries (OurRef,SupplierRef,SupplierName,LocationRef,LocationName,StockCode,DQtyGarments,DQtyBoxes,DQtyHangers,TotalGarments,TotalBoxes,TotalHangers,NetAmount,DeliveryCharge,Commission,TotalAmount,DeliveryDate,DeliveryType,ConfirmedDate,Notes,InvoiceNo,Shipper,ShipperInvoice,CreatedBy,CreatedDate) VALUES (@OurRef,@SupplierRef,@SupplierName,@LocationRef,@LocationName,@StockCode,@DQtyGarments,@DQtyBoxes,@DQtyHangers,@TotalGarments,@TotalBoxes,@TotalHangers,@NetAmount,@DeliveryCharge,@Commission,@TotalAmount,@DeliveryDate,@DeliveryType,@ConfirmedDate,@Notes,@InvoiceNo,@Shipper,@ShipperInvoice,@CreatedBy,@CreatedDate)"
                .CommandType = CommandType.Text
                With .Parameters
                    .AddWithValue("@OurRef", stockcode)
                    .AddWithValue("@SupplierRef", supplierRef)
                    .AddWithValue("@SupplierName", suppliername)
                    .AddWithValue("@LocationRef", locationref)
                    .AddWithValue("@LocationName", locationname)
                    .AddWithValue("@StockCode", stockcode)
                    .AddWithValue("@DQtyGarments", CInt(totalg))
                    .AddWithValue("@DQtyBoxes", "0")
                    .AddWithValue("@DQtyHangers", CInt(totalg))
                    .AddWithValue("@TotalGarments", CInt(totalg))
                    .AddWithValue("@TotalBoxes", "0")
                    .AddWithValue("@TotalHangers", CInt(totalg))
                    .AddWithValue("@NetAmount", CDec(netamount))
                    .AddWithValue("@DeliveryCharge", CDec(delcharge))
                    .AddWithValue("@Commission", CDec(commission))
                    .AddWithValue("@TotalAmount", CDec(totalv))
                    .AddWithValue("@DeliveryDate", CDate(dte))
                    .AddWithValue("@DeliveryType", "Confirmed")
                    .AddWithValue("@ConfirmedDate", CDate(dte))
                    .AddWithValue("@Notes", notes)
                    .AddWithValue("@InvoiceNo", invoice)
                    .AddWithValue("@Shipper", shipper)
                    .AddWithValue("@ShipperInvoice", shipperinv)
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Now)
                End With
                .Connection.Open()
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveWHAdjustHead(WarehouseRef As String, Reference As String, TotalLossItems As Integer, TotalGainItems As Integer, MovementDate As Date) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblWarehouseAdjustments(WarehouseRef,Reference,TotalLossItems,TotalGainItems,MovementDate,CreatedBy,CreatedDate) VALUES (@WarehouseRef,@Reference,@TotalLossItems,@TotalGainItems,@MovementDate,@CreatedBy,@CreatedDate)"
                With .Parameters
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalLossItems", CInt(TotalLossItems))
                    .AddWithValue("@TotalGainItems", CInt(TotalGainItems))
                    .AddWithValue("@MovementDate", CDate(MovementDate))
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveWhAdjustLines(WarehouseAdjustID As Integer, StockCode As String, MovementType As String, qty As Integer, Value As Decimal) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblWarehouseAdjustmentsLines(WarehouseAdjustID,StockCode,MovementType,Qty,Value) VALUES (@WarehouseAdjustID,@StockCode,@MovementType,@Qty,@Value)"
                With .Parameters
                    .AddWithValue("@WarehouseAdjustID", CInt(WarehouseAdjustID))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@MovementType", MovementType)
                    .AddWithValue("@Qty", CInt(qty))
                    .AddWithValue("@Value", CDec(Value))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveSHAdjustHead(ShopRef As String, Reference As String, TotalLossItems As Integer, TotalGainItems As Integer, MovementDate As Date) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopAdjustments(ShopRef,Reference,TotalLossItems,TotalGainItems,MovementDate,CreatedBy,CreatedDate) VALUES (@ShopRef,@Reference,@TotalLossItems,@TotalGainItems,@MovementDate,@CreatedBy,@CreatedDate)"
                With .Parameters
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalLossItems", CInt(TotalLossItems))
                    .AddWithValue("@TotalGainItems", CInt(TotalGainItems))
                    .AddWithValue("@MovementDate", CDate(MovementDate))
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveSHAdjustLines(ShopAdjustID As Integer, StockCode As String, MovementType As String, qty As Integer, Value As Decimal) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopAdjustmentsLines(ShopAdjustID,StockCode,MovementType,Qty,Value) VALUES (@ShopAdjustID,@StockCode,@MovementType,@Qty,@Value)"
                With .Parameters
                    .AddWithValue("@ShopAdjustID", CInt(ShopAdjustID))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@MovementType", MovementType)
                    .AddWithValue("@Qty", CInt(qty))
                    .AddWithValue("@Value", CDec(Value))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopDelHead(ShopRef As String, ShopName As String, WarehouseRef As String, WarehousesName As String, Reference As String, TotalItems As Integer, DeliveryDate As Date) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopDeliveries(ShopRef,ShopName,WarehouseRef,WarehouseName,Reference,TotalItems,DeliveryDate,DeliveryType,ConfirmedDate,Notes,CreatedBy,CreatedDate) VALUES (@ShopRef,@ShopName,@WarehouseRef,@WarehouseName,@Reference,@TotalItems,@DeliveryDate,@DeliveryType,@ConfirmedDate,@Notes,@CreatedBy,@CreatedDate)"
                With .Parameters
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@ShopName", ShopName)
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@WarehouseName", WarehousesName)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalItems", CInt(TotalItems))
                    .AddWithValue("@DeliveryDate", CDate(DeliveryDate))
                    .AddWithValue("@DeliveryType", "Confirmed")
                    .AddWithValue("@ConfirmedDate", CDate(DeliveryDate))
                    .AddWithValue("@Notes", "")
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopDelLines(SDeliveriesID As Integer, SStockCode As String, DeliveredQty As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopDeliveriesLines (SDeliveriesID,SStockCode,DeliveredQty) VALUES (@SDeliveriesID,@SStockCode,@DeliveredQty)"
                With .Parameters
                    .AddWithValue("@SDeliveriesID", CInt(SDeliveriesID))
                    .AddWithValue("@SStockCode", SStockCode)
                    .AddWithValue("@DeliveredQty", CInt(DeliveredQty))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopTransHead(Reference As String, TransferDate As Date, ShopRef As String, ShopName As String, ToShopRef As String, ToShopName As String, TotalQtyOut As Integer, TotalQtyIn As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopTransfers (Reference,TransferDate,ShopRef,ShopName,ToShopRef,ToShopName,TotalQtyOut,TotalQtyIn,CreatedBy,CreatedDate) VALUES (@Reference,@TransferDate,@ShopRef,@ShopName,@ToShopRef,@ToShopName,@TotalQtyOut,@TotalQtyIn,@CreatedBy,@CreatedDate)"
                With .Parameters
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TransferDate", CDate(TransferDate))
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@ShopName", ShopName)
                    .AddWithValue("@ToShopRef", ToShopRef)
                    .AddWithValue("@ToShopName", ToShopName)
                    .AddWithValue("@TotalQtyOut", CInt(TotalQtyOut))
                    .AddWithValue("@TotalQtyIn", CInt(TotalQtyIn))
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopTransLines(TransferID As Integer, smtoid As Integer, smtiid As Integer, StockCode As String, CurrQty As Integer, TOQty As Integer, TIQty As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopTransferLines (TransferID,SMTOID,SMTIID,StockCode,CurrentQty,TOQty,TIQty) VALUES (@TransferID,@SMTOID,@SMTIID,@StockCode,@CurrentQty,@TOQty,@TIQty)"
                With .Parameters
                    .AddWithValue("@TransferID", TransferID)
                    .AddWithValue("@SMTOID", CInt(smtoid))
                    .AddWithValue("@SMTIID", CInt(smtiid))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@CurrentQty", CInt(CurrQty))
                    .AddWithValue("@TOQty", CInt(TOQty))
                    .AddWithValue("@TIQty", CInt(TIQty))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopSalesHead(shopref As String, shopname As String, TransactionDate As Date, TotalQty As Integer, TotalValue As Decimal) As Boolean
        Try
            Using conn As New SqlConnection(ut.GetConnString())
                Dim inscmd As New SqlCommand
                With inscmd
                    .Connection = conn
                    .Connection.Open()
                    .CommandType = CommandType.Text
                    .CommandText = "INSERT INTO tblSales (ShopRef,ShopName,SAReference,TransactionDate,TotalQty,TotalValue,CreatedBy,CreatedDate) VALUES (@ShopRef,@ShopName,@SAReference,@TransactionDate,@TotalQty,@TotalValue,@CreatedBy,@CreatedDate)"
                    With .Parameters
                        .AddWithValue("@ShopRef", shopref)
                        .AddWithValue("@ShopName", shopname)
                        .AddWithValue("@SAReference", "0")
                        .AddWithValue("@TransactionDate", TransactionDate)
                        .AddWithValue("@TotalQty", TotalQty)
                        .AddWithValue("@TotalValue", TotalValue)
                        .AddWithValue("@CreatedBy", username)
                        .AddWithValue("@CreatedDate", Date.Now)
                    End With
                    .ExecuteNonQuery()
                End With
            End Using
            Return True
        Catch ex As SqlException
            MsgBox("Record Creation Failed because of" & vbCrLf & ex.ErrorCode & "  " & ex.Message, MsgBoxStyle.Information, Application.ProductName)
        End Try

    End Function
    Public Function SaveShopSalesLines(salesID As Integer, stockcode As String, CurrentQty As Integer, QtySold As Integer, SalesAmount As Decimal, StockID As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblSalesLines (SalesID,StockCode,CurrentQty,QtySold,SalesAmount,StockMovementID) VALUES (@SalesID,@StockCode,@CurrentQty,@QtySold,@SalesAmount,@StockMovementID)"
                With .Parameters
                    .AddWithValue("@SalesID", salesID)
                    .AddWithValue("@StockCode", stockcode)
                    .AddWithValue("@CurrentQty", CurrentQty)
                    .AddWithValue("@QtySold", QtySold)
                    .AddWithValue("@SalesAmount", SalesAmount)
                    .AddWithValue("@StockMovementID", StockID)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function

    Public Function deleteShopSalesLines(salesID As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "DELETE from tblSalesLines WHERE SalesID = @SalesID AND QtySold = @QtySold AND SalesAmount = @SalesAmount;"
                With .Parameters
                    .AddWithValue("@SalesID", salesID)
                    .AddWithValue("@QtySold", "0")
                    .AddWithValue("@SalesAmount", "0.00")

                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True

    End Function

    Public Function SaveShopReturnsHead(ShopRef As String, WarehouseRef As String, Reference As String, TotalItems As Integer, TransactionDate As Date) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblReturns(ShopRef,WarehouseRef,Reference,TotalItems,TransactionDate,CreatedBy,CreatedDate) VALUES (@ShopRef,@WarehouseRef,@Reference,@TotalItems,@TransactionDate,@CreatedBy,@CreatedDate)"
                With .Parameters
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalItems", CInt(TotalItems))
                    .AddWithValue("@TransactionDate", CDate(TransactionDate))
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopReturnsLines(ReturnID As Integer, StockCode As String, Qty As Integer, Value As Decimal) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblReturnLines (ReturnID,StockCode,Qty,Value) VALUES (@ReturnID,@StockCode,@Qty,@Value)"
                With .Parameters
                    .AddWithValue("@ReturnID", ReturnID)
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@Qty", Qty)
                    .AddWithValue("@Value", Value)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveStock(stockcode As String, supplierref As String, costvalue As Decimal, totalG As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim insertCmd As New SqlCommand
            With insertCmd
                .Connection = conn
                .CommandText = " INSERT INTO tblStock (StockCode,SupplierRef,DeadCode,DeliveredQtyHangers,AmountTaken,CostValue,PCMarkUp,ZeroQty,CreatedBy,CreatedDate,Season) VALUES (@StockCode,@SupplierRef,@DeadCode,@DeliveredQtyHangers,@AmountTaken,@CostValue,@PCMarkUp,@ZeroQty,@CreatedBy,@CreatedDate,@Season)"
                .CommandType = CommandType.Text
                With .Parameters
                    .AddWithValue("@ZeroQty", "0")
                    .AddWithValue("@StockCode", stockcode)
                    .AddWithValue("@SupplierRef", supplierref)
                    .AddWithValue("@DeadCode", "0")
                    .AddWithValue("@AmountTaken", "0.00")
                    .AddWithValue("@CostValue", CDec(costvalue))
                    .AddWithValue("@PCMarkUp", "0")
                    .AddWithValue("@Season", "ALL")
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                    .AddWithValue("@DeliveredQtyHangers", CInt(totalG))
                End With
                .Connection.Open()
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveWHReturnHead(WarehouseRef As String, SWarehouseRef As String, Reference As String, TotalItems As Integer, TransactionDate As Date) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblWReturns (WarehouseRef,SWarehouseRef,Reference,TotalItems,TransactionDate,CreatedBy,CreatedDate) VALUES (@WarehouseRef,@SWarehouseRef,@Reference,@TotalItems,@TransactionDate,@CreatedBy,@CreatedDate)"
                With .Parameters
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@SWarehouseRef", SWarehouseRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalItems", CInt(TotalItems))
                    .AddWithValue("@TransactionDate", CDate(TransactionDate))
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveWhReturnLines(WReturnID As Integer, StockCode As String, Qty As Integer, Value As Decimal) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblWReturnLines (WReturnID,StockCode,Qty,Value) VALUES (@WReturnID,@StockCode,@Qty,@Value)"
                With .Parameters
                    .AddWithValue("@WReturnID", CInt(WReturnID))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@Qty", CInt(Qty))
                    .AddWithValue("@Value", CDec(Value))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
End Class
Public Class CStockMovements
    Dim ut As New CUtils()
    Public Sub SaveStockMovements(stockcode As String, supplierref As String, location As String, locationtype As String, hqty As Integer, bqty As Integer, movementtype As String, movedate As Date, value As Decimal, IReference As String, TRef As Integer)
        Try
            Using conn As New SqlConnection(ut.GetConnString())
                Dim insertcmd As New SqlCommand
                With insertcmd
                    .CommandText = "INSERT INTO tblStockMovements(SMStockCode,SMSupplierRef,SMLocation,SMLocationType,MovementQtyHangers,MovementQtyBoxes,MovementType,MovementDate,MovementValue,Reference,TransferReference,SMCreatedBy,SMCreatedDate) VALUES(@SMStockCode,@SMSupplierRef,@SMLocation,@SMLocationType,@MovementQtyHangers,@MovementQtyBoxes,@MovementType,@MovementDate,@MovementValue,@Reference,@TransferReference,@SMCreatedBy,@SMCreatedDate)"
                    .CommandType = CommandType.Text
                    .Connection = conn
                    .Parameters.AddWithValue("@SMStockCode", stockcode)
                    .Parameters.AddWithValue("@SMSupplierRef", supplierref)
                    .Parameters.AddWithValue("@SMLocation", location)
                    .Parameters.AddWithValue("@SMLocationType", locationtype)
                    .Parameters.AddWithValue("@MovementQtyHangers", CInt(hqty))
                    .Parameters.AddWithValue("@MovementQtyBoxes", CInt(bqty))
                    .Parameters.AddWithValue("@MovementType", movementtype)
                    .Parameters.AddWithValue("@MovementDate", CDate(movedate))
                    .Parameters.AddWithValue("@MovementValue", CDec(value))
                    .Parameters.AddWithValue("@Reference", IReference)
                    .Parameters.AddWithValue("@TransferReference", CInt(TRef))
                    .Parameters.AddWithValue("@SMCreatedBy", ut.GetUserName())
                    .Parameters.AddWithValue("@SMCreatedDate", Date.Now)
                    .Connection.Open()
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As SqlException
            MsgBox("Record Creation Failed because of" & vbCrLf & ex.ErrorCode & "  " & ex.Message, MsgBoxStyle.Information, Application.ProductName)
        End Try
    End Sub
    Public Sub DeleteZeroStockMovements(movementtype As String, transferref As Integer, reference As String, dte As Date)
        Using conn As New SqlConnection(ut.GetConnString())
            Dim deleteCmd As New SqlCommand
            With deleteCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "DELETE FROM tblStockMovements WHERE movementtype = @MovementType AND TransferReference = @TransferReference AND Reference = @Reference AND MovementDate = @MovementDate AND MovementQtyHangers = '0' AND MovementValue = '0'"
                With .Parameters
                    .AddWithValue("@MovementType", movementtype)
                    .AddWithValue("@TransferReference", CInt(transferref))
                    .AddWithValue("@Reference", reference)
                    .AddWithValue("@MovementDate", dte)
                End With
                .ExecuteNonQuery()
            End With
        End Using
    End Sub
    Public Sub DeleteStockMovements(movementtype As String, transferref As Integer, reference As String, dte As Date)
        Using conn As New SqlConnection(ut.GetConnString())
            Dim deleteCmd As New SqlCommand
            With deleteCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "DELETE FROM tblStockMovements WHERE movementtype = @MovementType AND TransferReference = @TransferReference AND Reference = @Reference AND MovementDate = @MovementDate"
                With .Parameters
                    .AddWithValue("@MovementType", movementtype)
                    .AddWithValue("@TransferReference", CInt(transferref))
                    .AddWithValue("@Reference", reference)
                    .AddWithValue("@MovementDate", dte)
                End With
                .ExecuteNonQuery()
            End With
        End Using
    End Sub
    Public Function ChkStockMovements(movementtype As String, transferref As Integer, reference As String, dte As Date) As Integer
        Dim result As Integer = 0
        Using conn As New SqlConnection(ut.GetConnString())
            Dim deleteCmd As New SqlCommand
            With deleteCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(StockMovementID) as ID FROM tblStockMovements WHERE movementtype = @MovementType AND TransferReference = @TransferReference AND Reference = @Reference AND MovementDate = @MovementDate AND MovementQtyHangers < 0"
                With .Parameters
                    .AddWithValue("@MovementType", movementtype)
                    .AddWithValue("@TransferReference", CInt(transferref))
                    .AddWithValue("@Reference", reference)
                    .AddWithValue("@MovementDate", dte)
                End With
                result = .ExecuteNonQuery()
            End With
        End Using
        Return result
    End Function
    Public Function ChkStockMovementsplus(movementtype As String, transferref As Integer, reference As String, dte As Date) As Integer
        Dim result As Integer = 0
        Using conn As New SqlConnection(ut.GetConnString())
            Dim deleteCmd As New SqlCommand
            With deleteCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(StockMovementID) as ID FROM tblStockMovements WHERE movementtype = @MovementType AND TransferReference = @TransferReference AND Reference = @Reference AND MovementDate = @MovementDate AND MovementQtyHangers > 0"
                With .Parameters
                    .AddWithValue("@MovementType", movementtype)
                    .AddWithValue("@TransferReference", CInt(transferref))
                    .AddWithValue("@Reference", reference)
                    .AddWithValue("@MovementDate", dte)
                End With
                result = .ExecuteNonQuery()
            End With
        End Using
        Return result
    End Function
End Class
Public Class CSystemLog
    Dim ut As New CUtils

    Public Sub SaveSystemLog(stockcode As String, supplierref As String, location As String, qty As Integer, movementtype As String, recordtype As String, mdate As Date, reference As String)
        Using conn As New SqlConnection(ut.GetConnString())
            Dim ICmd As New SqlCommand()
            With ICmd
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblSystemLog (StockCode,SupplierRef,Location,Qty,MovementType,RecordType,MovementDate,Timestamp,Reference,CreatedBy) VALUES (@StockCode,@SupplierRef,@Location,@Qty,@MovementType,@RecordType,@MovementDate,@Timestamp,@Reference,@CreatedBy)"
                .Connection.Open()
                .Parameters.AddWithValue("@StockCode", stockcode)
                .Parameters.AddWithValue("@SupplierRef", supplierref)
                .Parameters.AddWithValue("@Location", location)
                .Parameters.AddWithValue("@Qty", qty)
                .Parameters.AddWithValue("@MovementType", movementtype)
                .Parameters.AddWithValue("@RecordType", recordtype)
                .Parameters.AddWithValue("@MovementDate", mdate)
                .Parameters.AddWithValue("@Timestamp", Date.Now)
                .Parameters.AddWithValue("@Reference", reference)
                .Parameters.AddWithValue("@CreatedBy", ut.GetUserName)
                .ExecuteNonQuery()
            End With
        End Using
    End Sub
End Class
Public Class CUpdate
    Dim ut As New CUtils
    Public Function SaveWarehouse(WarehouseRef As String, WarehouseName As String, Address1 As String, Address2 As String, Address3 As String, Address4 As String, PostCode As String, ContactName As String, Telephone As String, Telephone2 As String, Fax As String, eMail As String, Memo As String, WarehouseType As String) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblWarehouses SET WarehouseName = @WarehouseName,Address1=@Address1,Address2=@Address2,Address3=@Address3,Address4 = @Address4,PostCode = @PostCode,ContactName = @ContactName,Telephone = Telephone,Telephone2 = @Telephone2,Fax = @Fax,eMail = @eMail,Memo = @Memo,WarehouseType = @WarehouseType WHERE WarehouseRef = @WarehouseRef"
                With .Parameters
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@WarehouseName", WarehouseName)
                    .AddWithValue("@Address1", Address1)
                    .AddWithValue("@Address2", Address2)
                    .AddWithValue("@Address3", Address3)
                    .AddWithValue("@Address4", Address4)
                    .AddWithValue("@PostCode", PostCode)
                    .AddWithValue("@ContactName", ContactName)
                    .AddWithValue("@Telephone", Telephone)
                    .AddWithValue("@Telephone2", Telephone2)
                    .AddWithValue("@Fax", Fax)
                    .AddWithValue("@eMail", eMail)
                    .AddWithValue("@Memo", Memo)
                    .AddWithValue("@WarehouseType", WarehouseType)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShops(ShopRef As String, ShopName As String, Address1 As String, Address2 As String, Address3 As String, Address4 As String, PostCode As String, ContactName As String, Telephone As String, Telephone2 As String, Fax As String, eMail As String, Memo As String, ShopType As String) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShops SET ShopName = @ShopName,Street=@Street,Area=@Area,Town=@Town,County = @County,PostCode = @PostCode,ContactName = @ContactName,Telephone = Telephone,Telephone2 = @Telephone2,Fax = @Fax,eMail = @eMail,Memo = @Memo,ShopType = @ShopType WHERE ShopRef = @ShopRef"
                With .Parameters
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@ShopName", ShopName)
                    .AddWithValue("@Street", Address1)
                    .AddWithValue("@Area", Address2)
                    .AddWithValue("@Town", Address3)
                    .AddWithValue("@County", Address4)
                    .AddWithValue("@PostCode", PostCode)
                    .AddWithValue("@ContactName", ContactName)
                    .AddWithValue("@Telephone", Telephone)
                    .AddWithValue("@Telephone2", Telephone2)
                    .AddWithValue("@Fax", Fax)
                    .AddWithValue("@eMail", eMail)
                    .AddWithValue("@Memo", Memo)
                    .AddWithValue("@ShopType", ShopType)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveSupplier(SupplierRef As String, SupplierName As String, Address1 As String, Address2 As String, Address3 As String, Address4 As String, PostCode As String, ContactName As String, Telephone As String, Telephone2 As String, Fax As String, eMail As String, Memo As String) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblSuppliers SET SupplierName = @SupplierName,Address1=@Address1,Address2=@Address2,Address3=@Address3,Address4 = @Address4,PostCode = @PostCode,ContactName = @ContactName,Telephone = Telephone,Telephone2 = @Telephone2,Fax = @Fax,eMail = @eMail,Memo = @Memo WHERE SupplierRef = @SupplierRef"
                With .Parameters
                    .AddWithValue("@SupplierRef", SupplierRef)
                    .AddWithValue("@SupplierName", SupplierName)
                    .AddWithValue("@Address1", Address1)
                    .AddWithValue("@Address2", Address2)
                    .AddWithValue("@Address3", Address3)
                    .AddWithValue("@Address4", Address4)
                    .AddWithValue("@PostCode", PostCode)
                    .AddWithValue("@ContactName", ContactName)
                    .AddWithValue("@Telephone", Telephone)
                    .AddWithValue("@Telephone2", Telephone2)
                    .AddWithValue("@Fax", Fax)
                    .AddWithValue("@eMail", eMail)
                    .AddWithValue("@Memo", Memo)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveStock(StockCode As String, SupplierRef As String, DeadCode As Boolean, AmountTaken As Decimal, DelQtyH As Integer, CostValue As Decimal, PCMarkUp As Decimal, ZeroQty As Boolean, Season As String) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblStock SET SupplierRef=@SupplierRef,DeadCode=@DeadCode,AmountTaken=@AmountTaken,DeliveredQtyHangers=@DeliveredQtyHangers,CostValue=@CostValue,PCMarkUp=@PCMarkUp,ZeroQty=@ZeroQty,Season =@Season WHERE StockCode = @StockCode"
                With .Parameters
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@SupplierRef", SupplierRef)
                    .AddWithValue("@DeadCode", CBool(DeadCode))
                    .AddWithValue("@AmountTaken", CDec(AmountTaken))
                    .AddWithValue("@DeliveredQtyHangers", CInt(DelQtyH))
                    .AddWithValue("@CostValue", CDec(CostValue))
                    .AddWithValue("@PCMarkUp", CDec(PCMarkUp))
                    .AddWithValue("@ZeroQty", CBool(ZeroQty))
                    .AddWithValue("@Season", Season)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SavePOrders(DeliveriesID As Integer, supplierRef As String, suppliername As String, locationref As String, locationname As String, stockcode As String, totalg As Integer, netamount As Decimal, commission As Decimal, delcharge As Decimal, totalv As Decimal, dte As Date, notes As String, invoice As String, shipper As String, shipperinv As String) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblDeliveries
   SET OurRef = @OurRef, SupplierRef = @SupplierRef, SupplierName = @SupplierName, LocationRef = @LocationRef, LocationName = @LocationName, StockCode = @StockCode, DQtyGarments = @DQtyGarments ,DQtyBoxes = @DQtyBoxes,DQtyHangers = @DQtyHangers,TotalGarments = @TotalGarments,TotalBoxes = @TotalBoxes,TotalHangers = @TotalHangers,NetAmount = @NetAmount,DeliveryCharge = @DeliveryCharge,Commission = @Commission,TotalAmount = @TotalAmount,DeliveryDate = @DeliveryDate,DeliveryType = @DeliveryType,ConfirmedDate = @ConfirmedDate,Notes = @Notes,InvoiceNo = @InvoiceNo,Shipper = @Shipper,ShipperInvoice = @ShipperInvoice WHERE DeliveriesID = @DeliveriesID"
                With .Parameters
                    .AddWithValue("@DeliveriesID", CInt(DeliveriesID))
                    .AddWithValue("@OurRef", stockcode)
                    .AddWithValue("@SupplierRef", supplierRef)
                    .AddWithValue("@SupplierName", suppliername)
                    .AddWithValue("@LocationRef", locationref)
                    .AddWithValue("@LocationName", locationname)
                    .AddWithValue("@StockCode", stockcode)
                    .AddWithValue("@DQtyGarments", CInt(totalg))
                    .AddWithValue("@DQtyBoxes", "0")
                    .AddWithValue("@DQtyHangers", CInt(totalg))
                    .AddWithValue("@TotalGarments", CInt(totalg))
                    .AddWithValue("@TotalBoxes", "0")
                    .AddWithValue("@TotalHangers", CInt(totalg))
                    .AddWithValue("@NetAmount", CDec(netamount))
                    .AddWithValue("@DeliveryCharge", CDec(delcharge))
                    .AddWithValue("@Commission", CDec(commission))
                    .AddWithValue("@TotalAmount", CDec(totalv))
                    .AddWithValue("@DeliveryDate", CDate(dte))
                    .AddWithValue("@DeliveryType", "Confirmed")
                    .AddWithValue("@ConfirmedDate", CDate(dte))
                    .AddWithValue("@Notes", notes)
                    .AddWithValue("@InvoiceNo", invoice)
                    .AddWithValue("@Shipper", shipper)
                    .AddWithValue("@ShipperInvoice", shipperinv)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveWHAdjustHead(ID As Integer, ShopRef As String, Reference As String, TotalLossItems As Integer, TotalGainItems As Integer, MovementDate As Date) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblWarehouseAdjustments SET WarehouseRef = @WarehouseRef,Reference = @Reference,TotalLossItems = @TotalLossItems,TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE ID = @ID"
                With .Parameters
                    .AddWithValue("@ID", ID)
                    .AddWithValue("@WarehouseRef", ShopRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalLossItems", TotalLossItems)
                    .AddWithValue("@TotalGainItems", TotalGainItems)
                    .AddWithValue("@MovementDate", CDate(MovementDate))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveWHAdjustLines(StockCode As String, MovementType As String, Qty As Integer, Value As Decimal, ID As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblWarehouseAdjustmentsLines SET MovementType = @MovementType,Qty = @Qty,Value = @Value WHERE WarehouseAdjustID = @WarehouseAdjustID AND StockCode = @StockCode"
                With .Parameters
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@MovementType", MovementType)
                    .AddWithValue("@Qty", CInt(Qty))
                    .AddWithValue("@Value", CDec(Value))
                    .AddWithValue("@WarehouseAdjustID", CInt(ID))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopDelHead(DeliveriesID As Integer, ShopRef As String, ShopName As String, WarehouseRef As String, WarehousesName As String, Reference As String, TotalItems As Integer, DeliveryDate As Date) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopDeliveries SET ShopRef = @ShopRef,ShopName = @ShopName,WarehouseRef = @WarehouseRef,WarehouseName = @WarehouseName,Reference = @Reference,TotalItems = @TotalItems,DeliveryDate = @DeliveryDate,DeliveryType = @DeliveryType,ConfirmedDate = @ConfirmedDate,Notes = @Notes WHERE DeliveriesID = @DeliveriesID"
                With .Parameters
                    .AddWithValue("@DeliveriesID", CInt(DeliveriesID))
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@ShopName", ShopName)
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@WarehouseName", WarehousesName)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalItems", CInt(TotalItems))
                    .AddWithValue("@DeliveryDate", CDate(DeliveryDate))
                    .AddWithValue("@DeliveryType", "Confirmed")
                    .AddWithValue("@ConfirmedDate", CDate(DeliveryDate))
                    .AddWithValue("@Notes", "")
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopDelLines(SDeliveriesID As Integer, SStockCode As String, DeliveredQty As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopDeliveriesLines SET DeliveredQty = @DeliveredQty WHERE SDeliveriesID = @SDeliveriesID AND SStockCode = SStockCode"
                With .Parameters
                    .AddWithValue("@SDeliveriesID", CInt(SDeliveriesID))
                    .AddWithValue("@SStockCode", SStockCode)
                    .AddWithValue("@DeliveredQty", CInt(DeliveredQty))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopAdjustHead(ID As Integer, ShopRef As String, Reference As String, TotalLossItems As Integer, TotalGainItems As Integer, MovementDate As Date) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopAdjustments SET ShopRef = @ShopRef,Reference = @Reference,TotalLossItems = @TotalLossItems,TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE ID = @ID"
                With .Parameters
                    .AddWithValue("@ID", CInt(ID))
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalLossItems", CInt(TotalLossItems))
                    .AddWithValue("@TotalGainItems", CInt(TotalGainItems))
                    .AddWithValue("@MovementDate", CDate(MovementDate))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopAdjustLines(StockCode As String, MovementType As String, Qty As Integer, Value As Decimal, ID As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopAdjustmentsLines SET MovementType = @MovementType,Qty = @Qty,Value = @Value WHERE ShopAdjustID = @ShopAdjustID AND StockCode = @StockCode"
                With .Parameters
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@MovementType", MovementType)
                    .AddWithValue("@Qty", CInt(Qty))
                    .AddWithValue("@Value", CDec(Value))
                    .AddWithValue("@ShopAdjustID", CInt(ID))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopTransHead(TransferID As Integer, Reference As String, TransferDate As Date, ShopRef As String, ShopName As String, ToShopRef As String, ToShopName As String, TotalQtyOut As Integer, TotalQtyIn As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopTransfers SET Reference = @Reference,TransferDate = @TransferDate,ShopRef = @ShopRef,ShopName = @ShopName,ToShopRef = @ToShopRef,ToShopName = @ToShopName,TotalQtyOut = @TotalQtyOut,TotalQtyIn = @TotalQtyOut WHERE TransferID = @TransferID"
                With .Parameters
                    .AddWithValue("@TransferID", CInt(TransferID))
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TransferDate", CDate(TransferDate))
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@ShopName", ShopName)
                    .AddWithValue("@ToShopRef", ToShopRef)
                    .AddWithValue("@ToShopName", ToShopName)
                    .AddWithValue("@TotalQtyOut", CInt(TotalQtyOut))
                    .AddWithValue("@TotalQtyIn", CInt(TotalQtyIn))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopTransLines(TransferID As Integer, smtoid As Integer, smtiid As Integer, StockCode As String, CurrQty As Integer, TOQty As Integer, TIQty As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopTransferLines SET SMTOID = @SMTOID,SMTIID=@SMTIID,CurrentQty = @CurrentQty,TOQty=@TOQty,TIQty=@TIQty WHERE TransferID=@TransferID AND StockCode = @StockCode"
                With .Parameters
                    .AddWithValue("@TransferID", CInt(TransferID))
                    .AddWithValue("@SMTOID", CInt(smtoid))
                    .AddWithValue("@SMTIID", CInt(smtiid))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@CurrentQty", CInt(CurrQty))
                    .AddWithValue("@TOQty", CInt(TOQty))
                    .AddWithValue("@TIQty", CInt(TIQty))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopSalesHead(SalesID As Integer, shopref As String, shopname As String, SAReference As String, TransactionDate As Date, TotalQty As Integer, TotalValue As Decimal) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblSales SET ShopRef = @ShopRef,ShopName=@ShopName,SAReference = @SAReference,TransactionDate=@TransactionDate,TotalQty = @TotalQty,TotalValue=@TotalValue WHERE SalesID=@SalesID"
                With .Parameters
                    .AddWithValue("@SalesID", CInt(SalesID))
                    .AddWithValue("@ShopRef", shopref)
                    .AddWithValue("@ShopName", shopname)
                    .AddWithValue("@SAReference", SAReference)
                    .AddWithValue("@TransactionDate", CDate(TransactionDate))
                    .AddWithValue("@TotalQty", CInt(TotalQty))
                    .AddWithValue("@TotalValue", CDec(TotalValue))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopSalesLines(salesID As Integer, stockcode As String, CurrentQty As Integer, QtySold As Integer, SalesAmount As Decimal, StockID As Integer) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblSalesLines SET CurrentQty = @CurrentQty, QtySold = @QtySold,SalesAmount = @SalesAmount,StockMovementID = @StockMovementID WHERE SalesID = @SalesID AND StockCode =@StockCode"
                With .Parameters
                    .AddWithValue("@SalesID", CInt(salesID))
                    .AddWithValue("@StockCode", stockcode)
                    .AddWithValue("@CurrentQty", CInt(CurrentQty))
                    .AddWithValue("@QtySold", CInt(QtySold))
                    .AddWithValue("@SalesAmount", CDec(SalesAmount))
                    .AddWithValue("@StockMovementID", CInt(StockID))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopReturnsHead(ReturnID As Integer, ShopRef As String, WarehouseRef As String, Reference As String, TotalItems As Integer, TransactionDate As Date) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblReturns SET ShopRef=@ShopRef,WarehouseRef=@WarehouseRef,Reference=@Reference,TotalItems = @TotalItems,TransactionDate=@TransactionDate WHERE ReturnsID =@ReturnsID"
                With .Parameters
                    .AddWithValue("@ReturnsID", CInt(ReturnID))
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalItems", CInt(TotalItems))
                    .AddWithValue("@TransactionDate", CDate(TransactionDate))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveShopReturnsLines(ReturnID As Integer, StockCode As String, Qty As Integer, Value As Decimal) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblReturnLines SET Qty = @Qty,Value=@Value WHERE ReturnID = @ReturnID AND StockCode = @StockCode"
                With .Parameters
                    .AddWithValue("@ReturnID", CInt(ReturnID))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@Qty", CInt(Qty))
                    .AddWithValue("@Value", CInt(Value))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveWHReturnHead(WReturns As Integer, WarehouseRef As String, SWarehouseRef As String, Reference As String, TotalItems As Integer, TransactionDate As Date) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblWReturns SET WarehouseRef=@WarehouseRef,SWarehouseRef=@SWarehouseRef,Reference=@Reference,TotalItems=@TotalItems,TransactionDate=@TransactionDate WHERE WReturnsID =@WReturnsID"
                With .Parameters
                    .AddWithValue("@WReturnsID", CInt(WReturns))
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@SWarehouseRef", SWarehouseRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalItems", CInt(TotalItems))
                    .AddWithValue("@TransactionDate", CDate(TransactionDate))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
    Public Function SaveWhReturnLines(WReturnID As Integer, StockCode As String, Qty As Integer, Value As Decimal) As Boolean
        Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblWReturnLines SET Qty = @Qty,Value = @Value WHERE WReturnID = @WReturnID AND StockCode = @StockCode"
                With .Parameters
                    .AddWithValue("@WReturnID", CInt(WReturnID))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@Qty", CInt(Qty))
                    .AddWithValue("@Value", CDec(Value))
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
    End Function
End Class
Public Class CUtils
    Public Function GetConnString()
        Dim connString As String
        'connString = "Initial Catalog=DMHStockv4a;Data Source=.\SQLEXPRESS;Persist Security Info=False;Integrated Security=true;"
        connString = "Initial Catalog=DMHStockv4;Data Source=.\SQLEXPRESS;Persist Security Info=False;Integrated Security=true;"
        Return connString
    End Function
    Public Function GetSundaysDate(ByRef Dte As Date) As Date
        Return Dte.AddDays(0 - Dte.DayOfWeek)
    End Function
    Public Function GetNextSundaysDate(ByRef dte As Date) As Date
        Return dte.AddDays(0 - dte.DayOfWeek + 7)
    End Function
    Public Function GetUserName() As String
        Return "David"
    End Function
    Public Function GetBkConnString()
        Dim connString As String
        'connString = "Initial Catalog=DMHStockv4a;Data Source=.\SQLEXPRESS;Persist Security Info=False;Integrated Security=true;"
        connString = "Initial Catalog=master;Data Source=.\SQLEXPRESS;Persist Security Info=False;Integrated Security=true;"
        Return connString
    End Function
End Class






