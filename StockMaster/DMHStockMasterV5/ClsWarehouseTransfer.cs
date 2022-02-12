namespace DMHStockMasterV5
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClsWarehouseTransfer : ClsUtils
    {
        public int WarehouseTransferID;
        public string ToWarehouseRef { get; set; }
        public string ToWarehouseName { get; set; }
        public void LoadNewRecord()
        {
            FrmWarehouseTransfer warehouseTransfer = new FrmWarehouseTransfer()
            {
                FormMode = "New",
                UserID = UserID
            };
            warehouseTransfer.ShowDialog();
        }
        public void LoadSelectedWarehouseTransfer()
        {
            FrmWarehouseTransfer warehouseTransfer = new FrmWarehouseTransfer()
            {
                FormMode = "Old"
            };
            warehouseTransfer.TxtTransferID.Text = WarehouseTransferID.ToString();
            warehouseTransfer.ShowDialog();
        }
        public int GetLastWarehouseTransferHeadFromDB()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand SelectCmd = new SqlCommand())
                        {
                            SelectCmd.Connection = conn;
                            SelectCmd.Connection.Open();
                            SelectCmd.CommandType = CommandType.Text;
                            SelectCmd.CommandText = "SELECT COUNT(*) as MaxRows FROM tblWarehouseTransfers";
                            Result = (int)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                Result = 0;
                throw;
            }
            return Result;
        }
        public bool SaveWarehouseTransferHead()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand InsertCmd = new SqlCommand())
                        {
                            InsertCmd.Connection = conn;
                            InsertCmd.Connection.Open();
                            InsertCmd.CommandType = CommandType.Text;
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseTransfers (Reference, TransferDate, WarehouseRef,  ToWarehouseRef,  TotalQtyOutGarments, TotalQtyOutBoxes, TotalQtyOutHangers,TotalQtyInHangers, CreatedBy, CreatedDate) VALUES (@Reference, @TransferDate, @WarehouseRef,  @ToWarehouseRef, @TotalQtyOutGarments, @TotalQtyOutBoxes, @TotalQtyOutHangers, @TotalQtyInHangers, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TransferDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@ToWarehouseRef", ToWarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@TotalQtyOutGarments", DeliveredQtyGarments);
                            InsertCmd.Parameters.AddWithValue("@TotalQtyOutBoxes", DeliveredQtyBoxes);
                            InsertCmd.Parameters.AddWithValue("@TotalQtyOutHangers", DeliveredQtyHangers);
                            InsertCmd.Parameters.AddWithValue("@TotalQtyInHangers", Qty);
                            InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                            InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        SaveToDB = false;
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                SaveToDB = false;
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseTransferHead()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.Connection.Open();
                            UpdateCmd.CommandType = CommandType.Text;
                            UpdateCmd.CommandText = "UPDATE tblWarehouseTransfers SET Reference = @Reference, TransferDate = @TransferDate, WarehouseRef = @WarehouseRef, ToWarehouseRef = @ToWarehouseRef , TotalQtyOutGarments = @TotalQtyOutGarments, TotalQtyOutBoxes = @TotalQtyOutBoxes, TotalQtyOutHangers = @TotalQtyOutHangers, @TotalQtyInHangers = @TotalQtyInHangers WHERE WarehouseTransferID = @WarehouseTransferID";
                            UpdateCmd.Parameters.AddWithValue("@WarehouseTransferID", WarehouseTransferID);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TransferDate", MovementDate);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@ToWarehouseRef", ToWarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@TotalQtyOutGarments", DeliveredQtyGarments);
                            UpdateCmd.Parameters.AddWithValue("@TotalQtyOutBoxes", DeliveredQtyBoxes);
                            UpdateCmd.Parameters.AddWithValue("@TotalQtyOutHangers", DeliveredQtyHangers);
                            UpdateCmd.Parameters.AddWithValue("@TotalQtyInHangers", Qty);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                UpdateToDB = false;
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseTransferHead()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand DeleteCmd = new SqlCommand())
                        {
                            DeleteCmd.Connection = conn;
                            DeleteCmd.Connection.Open();
                            DeleteCmd.CommandType = CommandType.Text;
                            DeleteCmd.CommandText = "DELETE FROM tblWarehouseTransfers WHERE WarehouseTransferID = @WarehouseTransferID";
                            DeleteCmd.Parameters.AddWithValue("@WarehouseTransferID", WarehouseTransferID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        DeleteFromDB = false;
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
        public int CurrQtyGarments;
        public int CurrQtyBoxes;
        public int CurrQtyHangers;
        public int TOQtyGarments;
        public int TOQtyBoxes;
        public int TOQtyHangers;
        public int TIQty;

        public bool SaveWarehouseTransferLineToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand InsertCmd = new SqlCommand())
                        {
                            InsertCmd.Connection = conn;
                            InsertCmd.Connection.Open();
                            InsertCmd.CommandType = CommandType.Text;
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseTransferLines (WarehouseTransferID, StockCode, CurrentQtyGarments, CurrentQtyBoxes, CurrentQtyHangers, TOQtyGarments, TOQtyBoxes, TIQtyHangers, TOQtyHangers) VALUES (@WarehouseTransferID,  @StockCode, @CurrentQtyGarments, @CurrentQtyBoxes, @CurrentQtyHangers, @TOQtyGarments, @TOQtyBoxes , @TIQtyHangers, TOQtyHangers)";
                            InsertCmd.Parameters.AddWithValue("@WarehouseTransferID", WarehouseTransferID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@CurrentQtyHangers", CurrQtyHangers);
                            InsertCmd.Parameters.AddWithValue("@CurrentQtyBoxes", CurrQtyBoxes);
                            InsertCmd.Parameters.AddWithValue("@CurrentQtyGarments", CurrQtyGarments);
                            InsertCmd.Parameters.AddWithValue("@TOQtyGarments", TOQtyGarments);
                            InsertCmd.Parameters.AddWithValue("@TOQtyBoxes", TOQtyBoxes);
                            InsertCmd.Parameters.AddWithValue("@TOQtyHangers", TOQtyHangers);
                            InsertCmd.Parameters.AddWithValue("@TIQtyHangers", TIQty);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        SaveToDB = false;
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                SaveToDB = false;
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseTransferLineInDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.Connection.Open();
                            UpdateCmd.CommandType = CommandType.Text;
                            UpdateCmd.CommandText = "UPDATE tblWarehouseTransferLines SET CurrentQtyGarments = @CurrentQtyGarments, CurrentQtyBoxes = @CurrentQtyBoxes, CurrentQtyHangers = @CurrentQtyHangers, TOQtyGarments = @TOQtyGarments ,TOQtyBoxes = @TOQtyBoxes, TOQtyHangers = @TOQtyHangers, TIQtyHangers = @TIQtyHangers WHERE WarehouseTransferID = @WarehouseTransferID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@WarehouseTransferID", WarehouseTransferID);
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@CurrentQtyHangers", CurrQtyHangers);
                            UpdateCmd.Parameters.AddWithValue("@CurrentQtyBoxes", CurrQtyBoxes);
                            UpdateCmd.Parameters.AddWithValue("@CurrentQtyGarments", CurrQtyGarments);
                            UpdateCmd.Parameters.AddWithValue("@TOQtyGarments", TOQtyGarments);
                            UpdateCmd.Parameters.AddWithValue("@TOQtyBoxes", TOQtyBoxes);
                            UpdateCmd.Parameters.AddWithValue("@TOQtyHangers", TOQtyHangers);
                            UpdateCmd.Parameters.AddWithValue("@TIQtyHangers", TIQty);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                UpdateToDB = false;
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseTransferLineFromDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand DeleteCmd = new SqlCommand())
                        {
                            DeleteCmd.Connection = conn;
                            DeleteCmd.Connection.Open();
                            DeleteCmd.CommandType = CommandType.Text;
                            DeleteCmd.CommandText = "DELETE FROM tblWarehouseTransferLines WHERE WarehouseTransferID = @WarehouseTransferID;";
                            DeleteCmd.Parameters.AddWithValue("@WarehouseTransferID", WarehouseTransferID);
                            DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        DeleteFromDB = false;
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                DeleteFromDB = false;
                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
    }
}
