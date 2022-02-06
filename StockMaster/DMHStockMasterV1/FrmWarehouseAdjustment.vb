Imports System.Data.SqlClient
Public Class FrmWarehouseAdjustment
    Dim connectionString As String = "Initial Catalog=DMHStockv4;Data Source=(local)\SQLEXPRESS;Persist Security Info=False;Integrated Security=true;"
    Dim connection As New SqlConnection(connectionString)
    Dim InsertCommand As New SqlCommand
    Dim UpdateCommand As New SqlCommand
    Dim DeleteCommand As New SqlCommand
    Dim DuplicateCommand As New SqlCommand
    Dim SelectCommand As New SqlCommand
    Dim strWarehouse As String
    Dim strStock As String
    Dim strStockCode As String
    Dim dLastSaturday As Date = Now.AddDays(-(Now.DayOfWeek + 1))
    Dim dLastSunday As Date = Now.AddDays(-(Now.DayOfWeek + 7) + 7)

    Public Sub SELECTText(ByVal ctr As TextBox)
        ctr.SelectionStart = 0
        ctr.SelectionLength = Len(ctr.Text)
    End Sub
    Private Sub FrmWarehouseAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtWarehouseRef.Text = "UNI"
        txtWarehouseName.Text = "Universal Warehouse"
        If Main.txtMode.Text = "OLD" Then LoadOld()
        If Main.txtMode.Text = "NEW" Then LoadNew()
        If Main.txtMode.Text = "DELETE" Then LoadDelete()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SelectCommand.Connection = connection
        SelectCommand.CommandText = "Select unitprice from qryunitprice where StockCode = '" + txtStockCode.Text + "'"
        SelectCommand.Connection.Open()
        TextBox1.Text = SelectCommand.ExecuteScalar()
        SelectCommand.Connection.Close()
        Dim Values As Decimal
        Values = CDec(txtAdjustHangers.Text * TextBox1.Text)
        Dim rowNum As Integer = DataGridView1.Rows.Add()
        DataGridView1.Rows.Item(rowNum).Cells(0).Value = txtStockCode.Text.ToString()
        DataGridView1.Rows.Item(rowNum).Cells(1).Value = txtWarehouseRef.Text.ToString()
        DataGridView1.Rows.Item(rowNum).Cells(2).Value = txtCurrentHangers.Text.ToString()
        DataGridView1.Rows.Item(rowNum).Cells(3).Value = cboType.Text.ToString()
        DataGridView1.Rows.Item(rowNum).Cells(4).Value = txtAdjustHangers.Text.ToString()
        DataGridView1.Rows.Item(rowNum).Cells(5).Value = DateTimePicker1.Value()
        DataGridView1.Rows.Item(rowNum).Cells(6).Value = Values
        txtStockCode.Text = ""
        txtAdjustHangers.Text = ""
        txtCurrentHangers.Text = ""
        cboType.Text = ""
        txtStockCode.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count > 1 Then
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
        End If

        If DataGridView1.SelectedRows.Count = 1 Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        End If
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Select one or more rows before you click delete", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim value As Integer
        Dim nref As Integer
        Dim command As New SqlCommand("SELECT MAX(TransferReference) as MaxRef from tblStockMovements where MovementType = 'Stock Loss' or MovementType = 'Stock Gain'") With {
            .Connection = connection
        }
        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            value = reader(0)
        End If
        reader.Close()
        nref = IIf(IsDBNull(value.ToString), 1, value + 1)
        Label6.Text = nref

        '   txtReference.Text = txtWarehouseRef.Text.ToString + nref + ""
        ' Dim stockcode As String
        Dim insertcommand2 As New SqlCommand
        Dim shopcode As String
        Dim adjustmenttype As String
        Dim unitprice As Decimal
        Dim adjustmentqty As Integer
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            shopcode = DataGridView1.Rows(i).Cells(1).Value
            adjustmenttype = DataGridView1.Rows(i).Cells(3).Value
            unitprice = DataGridView1.Rows(i).Cells(6).Value
            adjustmentqty = DataGridView1.Rows(i).Cells(4).Value

            insertcommand2.CommandType = CommandType.Text
            insertcommand2.CommandText = " INSERT INTO tblStockMovements (SMStockCode,SMSupplierRef,SMLocation,SMLocationType,MovementQtyHangers,MovementType,MovementDate,MovementValue,Reference,TransferReference,SMCreatedBy,SMCreatedDate) VALUES(@SMStockCode,@SMSupplierRef,@SMLocation,@SMLocationType,@MovementQtyHangers,@MovementType,@MovementDate,@MovementValue,@Reference,@TransferReference,@SMCreatedBy,@SMCreatedDate)"

            insertcommand2.Parameters.AddWithValue("@SMStockCode", DataGridView1.Rows(i).Cells(0).Value) '1
            insertcommand2.Parameters.AddWithValue("@SMSupplierRef", "") '2
            insertcommand2.Parameters.AddWithValue("@SMLocation", txtWarehouseRef.Text) '3 
            insertcommand2.Parameters.AddWithValue("@SMLocationType", "Warehouse") '4
            If adjustmenttype = "Gain" Then insertcommand2.Parameters.AddWithValue("@MovementQtyHangers", adjustmentqty)
            If adjustmenttype = "Loss" Then insertcommand2.Parameters.AddWithValue("@MovementQtyHangers", adjustmentqty * -1)
            If adjustmenttype = "Gain" Then insertcommand2.Parameters.AddWithValue("@MovementType", "Stock Gain")
            If adjustmenttype = "Loss" Then insertcommand2.Parameters.AddWithValue("@MovementType", "Stock Loss")
            insertcommand2.Parameters.AddWithValue("@MovementDate", DateTimePicker1.Value) '7
            If adjustmenttype = "Gain" Then insertcommand2.Parameters.AddWithValue("@MovementValue", CDec(unitprice))
            If adjustmenttype = "Loss" Then insertcommand2.Parameters.AddWithValue("@MovementValue", CDec(unitprice * -1))
            insertcommand2.Parameters.AddWithValue("@Reference", txtReference.Text) '9
            insertcommand2.Parameters.AddWithValue("@TransferReference", Label6.Text) '10
            insertcommand2.Parameters.AddWithValue("@SMCreatedBy", Main.TextBox1.Text) '11
            insertcommand2.Parameters.AddWithValue("@SMCreatedDate", Date.Now) '12
            insertcommand2.Connection = connection
            insertcommand2.Connection.Close()

            insertcommand2.Connection.Open()
            insertcommand2.ExecuteNonQuery()
            insertcommand2.Parameters.Clear()
            insertcommand2.Connection.Close()
        Next
        Using dconn As New SqlConnection(connectionString)
            Dim insertcommand As New SqlCommand With {
                .Connection = dconn,
                .CommandType = CommandType.Text,
                .CommandText = "INSERT INTO tblSystemLog (StockCode,SupplierRef,Location,Qty,MovementType,RecordType,MovementDate,Timestamp,Reference) VALUES (@StockCode,@SupplierRef,@Location,@Qty,@MovementType,@RecordType,@MovementDate,@Timestamp,@Reference)"
            }
            insertcommand.Connection.Open()
            insertcommand.Parameters.AddWithValue("@StockCode", txtStockCode.Text)
            insertcommand.Parameters.AddWithValue("@SupplierRef", " ")
            insertcommand.Parameters.AddWithValue("@Location", txtWarehouseName.Text)
            insertcommand.Parameters.AddWithValue("@Qty", txtAdjustHangers.Text)
            insertcommand.Parameters.AddWithValue("@MovementType", "WAdjustment")
            insertcommand.Parameters.AddWithValue("@RecordType", "WAdjustment-Add")
            insertcommand.Parameters.AddWithValue("@MovementDate", DateTimePicker1.Value)
            insertcommand.Parameters.AddWithValue("@Timestamp", Date.Now)
            insertcommand.Parameters.AddWithValue("@Reference", txtReference.Text)
            insertcommand.Parameters.AddWithValue("@CreatedBy", Main.TextBox1.Text)
            insertcommand.ExecuteNonQuery()
        End Using
        Main.WarehouseAdjustmentsToolStripMenuItem.PerformClick()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtAdjustHangers.Clear()
        txtCurrentHangers.Clear()
        txtReference.Clear()
        txtStockCode.Clear()
        DataGridView1.Rows.Clear()
        DateTimePicker1.Value = dLastSunday
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub LoadOld()
        Button4.Text = "&Ok"
        '  Button6.Text = "Cancel"
        Button5.Visible = False

    End Sub
    Private Sub LoadNew()
        DateTimePicker1.Value = dLastSunday
        Button4.Text = "&Add"
        '  Button6.Text = "Cancel"
        '  Button5.Text = "Clear"
        Try
            Dim sqlds As New DataSet
            Dim adp As New SqlDataAdapter
            connection.Close()
            connection.Open()
            Dim comm As New SqlCommand("SELECT StockCode From tblStock where deadcode ='0'", connection) With {
                .CommandType = CommandType.Text
            }
            adp.SelectCommand = comm
            adp.Fill(sqlds)
            comm.Dispose()
            adp.Dispose()
            Dim ACSC As New AutoCompleteStringCollection
            Dim i As Integer
            For i = 0 To sqlds.Tables(0).Rows.Count - 1
                ACSC.Add(sqlds.Tables(0).Rows(i).Item(0).ToString)
            Next
            txtStockCode.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtStockCode.AutoCompleteCustomSource = ACSC
            txtStockCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            connection.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, ProductName)
        End Try

    End Sub
    Private Sub LoadDelete()
        Dim i As Integer
        '  i = Main.DataGridView1.CurrentRow.Index

        ' txtReference.Text = Main.DataGridView1.Item(0, i).Value
        DeleteCommand.Connection = connection
        DeleteCommand.Connection.Open()
        DeleteCommand.CommandType = CommandType.Text
        DeleteCommand.CommandText = "DELETE from tblStockMovements where StockmovementID = '" + txtReference.Text.ToString() + "'"
        DeleteCommand.ExecuteNonQuery()
        DeleteCommand.Connection.Close()
        FrmMain.WarehouseAdjustmentsToolStripMenuItem.PerformClick()
        Me.Close()

    End Sub
    Private Sub GetStock()
        txtStockCode.Text = UCase(txtStockCode.Text)
        Dim qty As String
        Dim sql As String = "SELECT QtyHangers from qryWarehouseStock Where SMLocation='" + txtWarehouseRef.Text + "' AND StockCode='" + txtStockCode.Text.ToString() + "'"
        SelectCommand.Connection = connection
        SelectCommand.CommandText = sql
        SelectCommand.CommandType = CommandType.Text
        SelectCommand.Connection.Close()
        SelectCommand.Connection.Open()
        qty = SelectCommand.ExecuteScalar
        SelectCommand.Connection.Close()
        If qty = " " Then
            txtCurrentHangers.Text = "0"
        Else
            txtCurrentHangers.Text = qty

        End If
    End Sub
End Class