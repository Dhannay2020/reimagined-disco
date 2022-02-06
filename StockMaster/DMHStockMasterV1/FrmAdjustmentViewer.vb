Imports System.Data.SqlClient
Public Class FrmAdjustmentViewer
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        adjustmentupdate()
        Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub FrmAdjustmentViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        If FrmMain.Func = "Shop Adjustments" Then ShopAdjustments()
        If FrmMain.Func = "Warehouse Adjustments" Then WarehouseAdjustments()
    End Sub
    Private Sub WarehouseAdjustments()
        Me.Text = "Warehouse Adjustment"
        Dim i As Integer
        i = FrmMain.DgvRecords.CurrentRow.Index
        Label9.Text = FrmMain.DgvRecords.Item(0, i).Value
        TextBox1.Text = FrmMain.DgvRecords.Item(1, i).Value
        TextBox2.Text = FrmMain.DgvRecords.Item(2, i).Value
        TextBox3.Text = FrmMain.DgvRecords.Item(3, i).Value
        TextBox4.Text = "Warehouse"
        TextBox5.Text = FrmMain.DgvRecords.Item(4, i).Value
        TextBox6.Text = FrmMain.DgvRecords.Item(6, i).Value
        DateTimePicker1.Value = FrmMain.DgvRecords.Item(7, i).Value
        ComboBox1.Text = FrmMain.DgvRecords.Item(8, i).Value

    End Sub
    Private Sub ShopAdjustments()
        Me.Text = "Shop Adjustment"
        Dim i As Integer
        i = FrmMain.DgvRecords.CurrentRow.Index
        Label9.Text = FrmMain.DgvRecords.Item(0, i).Value
        TextBox1.Text = FrmMain.DgvRecords.Item(1, i).Value
        TextBox2.Text = FrmMain.DgvRecords.Item(2, i).Value
        TextBox3.Text = FrmMain.DgvRecords.Item(4, i).Value
        TextBox4.Text = "Shop"
        TextBox5.Text = FrmMain.DgvRecords.Item(5, i).Value
        TextBox6.Text = FrmMain.DgvRecords.Item(6, i).Value
        DateTimePicker1.Value = FrmMain.DgvRecords.Item(7, i).Value
        ComboBox1.Text = FrmMain.DgvRecords.Item(8, i).Value
    End Sub
    Private Sub adjustmentupdate()
        Using conn As New SqlConnection(FrmMain.ConnectionString)
            Dim insertcommand As New SqlCommand With {
                .Connection = conn,
                .CommandType = CommandType.Text,
                .CommandText = "UPDATE tblStockMovements SET Movementtype = @MovementType, MovementQtyHangers = @MovementQtyHangers, MovementValue = @MovementValue Where StockMovementID ='" + Label9.Text + "'"
            }
            insertcommand.Parameters.AddWithValue("@MovementType", ComboBox1.Text)
            If ComboBox1.Text = "Stock Gain" Then insertcommand.Parameters.AddWithValue("@MovementQtyHangers", TextBox6.Text)
            If ComboBox1.Text = "Stock Loss" Then insertcommand.Parameters.AddWithValue("@MovementQtyHangers", CInt(TextBox6.Text * -1))
            insertcommand.Parameters.AddWithValue("@MovementValue", "0")  '8
            insertcommand.Connection.Open()
            insertcommand.ExecuteNonQuery()
            conn.Close()
        End Using
        Using dconn As New SqlConnection(FrmMain.ConnectionString)
            Dim insertCommand2 As New SqlCommand With {
                .Connection = dconn,
                .CommandType = CommandType.Text,
                .CommandText = "INSERT INTO tblSystemLog (StockCode,SupplierRef,Location,Qty,MovementType,RecordType,MovementDate,Timestamp,Reference) VALUES (@StockCode,@SupplierRef,@Location,@Qty,@MovementType,@RecordType,@MovementDate,@Timestamp,@Reference)"
            }
            insertCommand2.Connection.Open()
            insertCommand2.Parameters.AddWithValue("@StockCode", TextBox5.Text)
            insertCommand2.Parameters.AddWithValue("@SupplierRef", " ")
            insertCommand2.Parameters.AddWithValue("@Location", TextBox3.Text)
            insertCommand2.Parameters.AddWithValue("@MovementQtyHangers", TextBox6.Text)
            insertCommand2.Parameters.AddWithValue("@MovementType", "Adjustments")
            insertCommand2.Parameters.AddWithValue("@RecordType", "Adjustment-Update")
            insertCommand2.Parameters.AddWithValue("@MovementDate", DateTimePicker1.Value)
            insertCommand2.Parameters.AddWithValue("@Timestamp", Date.Now)
            insertCommand2.Parameters.AddWithValue("@Reference", Label9.Text)
            insertCommand2.Parameters.AddWithValue("@CreatedBy", FrmMain.User)
            insertCommand2.ExecuteNonQuery()
        End Using

    End Sub
End Class