namespace DMHStockMasterV5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SqlClient;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    internal class ClsDatabase
    {
    }
    public class ClsUtils
    {
        // Global properties
        // These are used by all objects
        public bool SaveToDB { get; set; }
        public bool UpdateToDB { get; set; }
        public bool DeleteFromDB { get; set; }
        public int Result { get; set; }
        public int UserID { get; set; }
        public string WarehouseRef { get; set; }
        public string ShopRef { get; set; }
        public string SupplierRef { get; set; }
        public string StockCode { get; set; }
        public int DeliveredQtyHangers { get; set; }
        public int DeliveredQtyBoxes { get; set; }
        public int DeliveredQtyGarments { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public string ContactName { get; set; }
        public string Fax { get; set; }
        public string eMail { get; set; }
        public string WebsiteAddress { get; set; }
        public string Memo { get; set; }
        public decimal VATAmount { get; set; }
        public DateTime MovementDate { get; set; }
        public string DeliveryType { get; set; }
        public string Reference { get; set; }
        public string SMovementType { get; set; }
        public int Qty { get; set; }
        public int TotalGainItems { get; set; }
        public int TotalLossItems { get; set; }
        public decimal Value { get; set; }
        public static string GetConnString(int ID)
        {
            // Returns the correct Database connection string for the identity record.
            if (ID == 1)
            {
                return @"Initial Catalog=FYPv2;Data Source=(local);Persist Security Info=False;Integrated Security=true;";
            }
            else if (ID == 2)
            {
                return @"Initial Catalog=FYPv2;Data Source=192.168.1.200;Persist Security Info=False;Integrated Security=false;User ID=FYPUser;Password=@35Adc@*K9z&QJ";
            }
            else if (ID == 3)
            {
                return @"Initial Catalog=master;Data Source=.\SQLEXPRESS;Persist Security Info=False;Integrated Security=true;";
            }
            else
            {
                return @"Initial Catalog=master;Data Source=192.168.1.200;Persist Security Info=False;Integrated Security=false;User ID=FYPUser;Password=@35Adc@*K9z&QJ";
            }
        }
        public static DateTime GetSundayDate(DateTime DatePicked, int DateType)
        {
            // Gives the correct Sunday's Date depending on the function that is calling the function.
            if (DateType == 1)
            {
                return DatePicked.AddDays(0 - DatePicked.DayOfWeek);
            }
            else
            {
                return DatePicked.AddDays(0 - DatePicked.DayOfWeek + 7);
            }
        }
        public static string ChangeCase(string TextToConvert, int TextType)
        {
            if (TextType == 1)
            {
                return TextToConvert.ToUpper();
            }
            else if (TextType == 2)
            {
                return TextToConvert.ToLower();
            }
            else
            {
                TextInfo textInfo = new CultureInfo("en-GB", false).TextInfo;
                return textInfo.ToTitleCase(TextToConvert);
            }
        }
        // URL: https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
        // User: Microsoft developers
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));
                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();
                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
    public class ClsEmployee : ClsUtils
    {
        // constructor for the class
        public ClsEmployee()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        // de-constructor for the class
        ~ClsEmployee()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        // properties for the class
        public string PasswordEntered { get; set; }
        private string PasswordHashed;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginCode { get; set; }
        public int ProfileID { get; set; }
        // methods for the class
        public static string HashingSHA1(string ValueToHash)
        {
            // Create The Highest Hash Value
            var sha1 = System.Security.Cryptography.SHA512.Create();
            // Encode the string passed in to a hash (7-bit)
            var inputValueToHash = Encoding.ASCII.GetBytes(ValueToHash);
            // Create the hash based on the encoded value
            var hashing = sha1.ComputeHash(inputValueToHash);
            // destroy the cryptography when not needed
            sha1.Dispose();
            // create a new string
            var stringbuilder = new StringBuilder();
            for (var a = 0; a < hashing.Length; a++)
            {
                // add the computed hash to a string value
                stringbuilder.Append(hashing[a].ToString("X2"));
            }
            return stringbuilder.ToString(); // return back to the calling function
        }
        public int GetAllUserTotal()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT COUNT(*) AS TotalRecords from tblEmployees";
                        SelectCmd.CommandType = CommandType.Text;
                        Result = (int)SelectCmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                return ex.Number;
                throw;
            }
            return Result;
        }
        public int GetLoginUserID(string LoginName, string Password)
        {
            UserID = 0;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandText = "SELECT EmployeeID,Password,UserGuid from tblEmployees WHERE LoginCode = @LoginCode";
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.AddWithValue("@LoginCode", LoginName);
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            int dbUserId = Convert.ToInt32(dataReader["EmployeeID"]);
                            string dbPassword = Convert.ToString(dataReader["Password"]);
                            string dbUserGuid = Convert.ToString(dataReader["UserGuid"]);
                            string PasswordHash = HashingSHA1(Password + dbUserGuid);
                            if (dbPassword == PasswordHash)
                            {
                                UserID = dbUserId;
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username and Password \nPlease try again", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                UserID = 0;
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return UserID;
        }
        public bool SaveToEmployeeTable()
        {
            SaveToDB = false;
            Guid usergiud = System.Guid.NewGuid();
            PasswordHashed = HashingSHA1(PasswordEntered + usergiud.ToString());
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandText = "INSERT INTO tblEmployees (FirstName, LastName, LoginCode, Password, ProfileID, UserGuid) VALUES (@FirstName, @LastName, @LoginCode, @Password, @ProfileID, @UserGuid)";
                        InsertCmd.Parameters.AddWithValue("@FirstName", FirstName);
                        InsertCmd.Parameters.AddWithValue("@LastName", LastName);
                        InsertCmd.Parameters.AddWithValue("@LoginCode", LoginCode);
                        InsertCmd.Parameters.AddWithValue("@Password", PasswordHashed);
                        InsertCmd.Parameters.AddWithValue("@ProfileID", ProfileID);
                        InsertCmd.Parameters.AddWithValue("@UserGuid", usergiud);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                SaveToDB = false;
                return SaveToDB;
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateToEmployeeTable()
        {
            PasswordHashed = HashingSHA1(PasswordEntered);
            UpdateToDB = false;
            try
            {

            }
            catch (SqlException ex)
            {
                UpdateToDB = false;
                MessageBox.Show(ex.Message);
                return UpdateToDB;
                throw;
            }
            return UpdateToDB;
        }
        public bool DeleteEmployee()
        {
            try
            {

            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                MessageBox.Show(ex.Message);
                throw;
            }
            return DeleteFromDB;
        }
    }
    public class ClsLogs : ClsUtils
    {
        public int LocationType { get; set; }
        public string LocationRef { get; set; }
        public string StringMovementType { get; set; }
        public int MovementType { get; set; }
        public decimal MovementValue { get; set; }
        public int TransferReference { get; set; }
        public bool SaveToStockMovementsTable()
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandType = CommandType.Text;
                        InsertCmd.CommandText = "INSERT INTO tblStockMovements (StockCode, LocationRef, LocationType, SupplierRef, MovementQtyHangers, MovementQtyBoxes, MovementQtyGarments, MovementType, MovementDate, MovementValue, MovementReference, TransferReference, CreatedBy, CreatedDate) VALUES (@StockCode, @LocationRef, @LocationType, @SupplierRef, @MovementQtyHangers, @MovementQtyBoxes, @MovementQtyGarments, @MovementType, @MovementDate, @MovementValue, @MovementReference, @TransferReference, @CreatedBy, @CreatedDate)";
                        InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        InsertCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        InsertCmd.Parameters.AddWithValue("@LocationRef", LocationRef);
                        InsertCmd.Parameters.AddWithValue("@LocationType", LocationType);
                        InsertCmd.Parameters.AddWithValue("@MovementQtyHangers", DeliveredQtyHangers);
                        InsertCmd.Parameters.AddWithValue("@MovementQtyBoxes", DeliveredQtyBoxes);
                        InsertCmd.Parameters.AddWithValue("@MovementQtyGarments", DeliveredQtyGarments);
                        InsertCmd.Parameters.AddWithValue("@MovementType", MovementType);
                        InsertCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                        InsertCmd.Parameters.AddWithValue("@MovementValue", MovementValue);
                        InsertCmd.Parameters.AddWithValue("@MovementReference", Reference);
                        InsertCmd.Parameters.AddWithValue("@TransferReference", TransferReference);
                        InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                        InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            if (Result != 1)
                SaveToDB = false;
            else
                SaveToDB = true;
            return SaveToDB;
        }
        public bool DeleteFromStockMovemmentsTable()
        {
            DeleteFromDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblStockMovements WHERE MovementType = @MovementType AND TransferReference = @TransferReference AND MovementDate = @MovementDate";
                        DeleteCmd.Parameters.AddWithValue("@MovementType", MovementType);
                        DeleteCmd.Parameters.AddWithValue("@TransferReference", TransferReference);
                        DeleteCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            if (Result != 1)
                DeleteFromDB = false;
            else
                DeleteFromDB = true;
            return DeleteFromDB;
        }
        public bool DeleteZeroQtyFromStockMovementsTable()
        {
            DeleteFromDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblStockMovements WHERE MovementType = @MovementType AND TransferReference = @TransferReference AND MovementReference = @MovementReference AND MovementDate = @MovementDate AND MovementQtyHangers = '0' AND MovementQtyBoxes = '0' AND MovementQtyGarments = '0' AND MovementValue = '0'";
                        DeleteCmd.Parameters.AddWithValue("@MovementType", MovementType);
                        DeleteCmd.Parameters.AddWithValue("@TransferReference", TransferReference);
                        DeleteCmd.Parameters.AddWithValue("@MovementReference", Reference);
                        DeleteCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            if (Result != 1)
                DeleteFromDB = false;
            else
                DeleteFromDB = true;
            return DeleteFromDB;
        }
    }
    public class ClsPurchaseOrder : ClsUtils
    {
        public int PurchaseOrderID { get; set; }
        public ClsPurchaseOrder()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        ~ClsPurchaseOrder()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        public void LoadNewPurchaseOrder()
        {
            FrmPurchaseOrder oPurchaseOrder = new FrmPurchaseOrder
            {
                FormMode = "New",
                UserID = UserID
            };
            oPurchaseOrder.ShowDialog();
        }
        public void LoadSelectedPurchaseOrder()
        {
            FrmPurchaseOrder oPurchaseOrder = new FrmPurchaseOrder
            {
                FormMode = "Old"
            };
            oPurchaseOrder.TxtOrderID.Text = PurchaseOrderID.ToString();
            oPurchaseOrder.ShowDialog();
        }
    }
    public class ClsPurchaseOrderHead : ClsPurchaseOrder
    {
        public int TotalGarments;
        public int TotalHangers;
        public int TotalBoxes;
        public decimal NetAmount;
        public decimal DeliveryCharge;
        public decimal Commission;
        public string SeasonName;
        public decimal TotalAmount;
        public string Shipper;
        public string ShipperInvoice;
        public string SupplierInvoice;
        public string OurRef;
        public ClsPurchaseOrderHead()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        ~ClsPurchaseOrderHead()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        public bool SaveToPurchaseOrderHeadToDB()
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "INSERT INTO tblPurchaseOrders (OurRef, SupplierRef, LocationRef, TotalGarments, TotalBoxes, TotalHangers, NetAmount, DeliveryCharge, Commission, VATAmount, TotalAmount, DeliveryDate, DeliveryType, SeasonName, Notes, InvoiceNumber, ShipperName, ShipperInvoice, CreatedBy, CreatedDate) VALUES (@OurRef, @SupplierRef, @LocationRef, @TotalGarments, @TotalBoxes, @TotalHangers, @NetAmount, @DeliveryCharge, @Commission, @VATAmount, @TotalAmount, @DeliveryDate, @DeliveryType, @SeasonName, @Notes, @InvoiceNumber, @ShipperName, @ShipperInvoice, @CreatedBy, @CreatedDate)";
                        sqlCommand.Parameters.AddWithValue("@OurRef", OurRef);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@LocationRef", WarehouseRef);
                        sqlCommand.Parameters.AddWithValue("@TotalGarments", TotalGarments);
                        sqlCommand.Parameters.AddWithValue("@TotalBoxes", TotalBoxes);
                        sqlCommand.Parameters.AddWithValue("@TotalHangers", TotalHangers);
                        sqlCommand.Parameters.AddWithValue("@NetAmount", NetAmount);
                        sqlCommand.Parameters.AddWithValue("@Commission", Commission);
                        sqlCommand.Parameters.AddWithValue("@DeliveryCharge", DeliveryCharge);
                        sqlCommand.Parameters.AddWithValue("@VATAmount", VATAmount);
                        sqlCommand.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        sqlCommand.Parameters.AddWithValue("@DeliveryDate", MovementDate);
                        sqlCommand.Parameters.AddWithValue("@DeliveryType", DeliveryType);
                        sqlCommand.Parameters.AddWithValue("@SeasonName", SeasonName);
                        sqlCommand.Parameters.AddWithValue("@Notes", Memo);
                        sqlCommand.Parameters.AddWithValue("@InvoiceNumber", SupplierInvoice);
                        sqlCommand.Parameters.AddWithValue("@ShipperName", Shipper);
                        sqlCommand.Parameters.AddWithValue("@ShipperInvoice", ShipperInvoice);
                        sqlCommand.Parameters.AddWithValue("@CreatedBy", UserID);
                        sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    SaveToDB = false;
                }
                else
                {
                    SaveToDB = true;
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            return SaveToDB;
        }
        public bool UpdateToPurchaseOrderHeadInDB()
        {
            UpdateToDB = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "UPDATE tblPurchaseOrders SET OurRef = @OurRef, SupplierRef = @SupplierRef, LocationRef = @LocationRef, TotalItems = @TotalItems, TotalBoxes = @TotalBoxes, TotalLoose = @TotalLoose, NetAmount = @NetAmount, DeliveryCharge = @DeliveryCharge, Commission = @Commission, VATAmount = @VATAmount, TotalAmount = @TotalAmount, DeliveryDate = @DeliveryDate, SeasonName = @SeasonName, Notes = @Notes, InvoiceNumber = @InvoiceNumber, ShipperName = @ShipperName, ShipperInvoice = @ShipperInvoice WHERE PurchaseOrderID = @PurchaseOrderID";
                        sqlCommand.Parameters.AddWithValue("@OurRef", OurRef);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@LocationRef", WarehouseRef);
                        sqlCommand.Parameters.AddWithValue("@TotalItems", TotalGarments);
                        sqlCommand.Parameters.AddWithValue("@TotalBoxes", TotalBoxes);
                        sqlCommand.Parameters.AddWithValue("@TotalLoose", TotalHangers);
                        sqlCommand.Parameters.AddWithValue("@NetAmount", NetAmount);
                        sqlCommand.Parameters.AddWithValue("@Commission", Commission);
                        sqlCommand.Parameters.AddWithValue("@DeliveryCharge", DeliveryCharge);
                        sqlCommand.Parameters.AddWithValue("@VATAmount", VATAmount);
                        sqlCommand.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        sqlCommand.Parameters.AddWithValue("@DeliveryDate", MovementDate);
                        sqlCommand.Parameters.AddWithValue("@SeasonName", SeasonName);
                        sqlCommand.Parameters.AddWithValue("@Notes", Memo);
                        sqlCommand.Parameters.AddWithValue("@InvoiceNumber", SupplierInvoice);
                        sqlCommand.Parameters.AddWithValue("@ShipperName", Shipper);
                        sqlCommand.Parameters.AddWithValue("@ShipperInvoice", ShipperInvoice);
                        sqlCommand.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderID);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    UpdateToDB = false;
                }
                else
                {
                    UpdateToDB = true;
                }
            }
            catch (SqlException ex)
            {
                UpdateToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            return UpdateToDB;
        }
        public bool DeletePurchaseOrderHeadFromDB()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                conn.Open();
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.CommandText = "DELETE FROM tblPurchaseOrders where PurchaseOrderID = @PurchaseOrderID";
                    DeleteCmd.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderID);
                    DeleteCmd.ExecuteNonQuery();
                }
            }
            return DeleteFromDB;
        }
        public int GetLastPurchaseOrderHead()
        {
            Result = 0;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                conn.Open();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblPurchaseOrders";
                    Result = (int)SelectCmd.ExecuteScalar();
                }
            }
            return Result;
        }
    }
    public class ClsPurchaseOrderLine : ClsPurchaseOrder
    {
        public decimal LineAmount { get; set; }
        public ClsPurchaseOrderLine()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }

        ~ClsPurchaseOrderLine()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        public bool SaveToPurchaseOrderLinetbl()
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "INSERT INTO tblPurchaseOrderLines (PurchaseOrderID, StockCode, DeliveredQtyGarments, DeliveredQtyBoxes, DeliveredQtyHangers, LineAmount) VALUES (@PurchaseOrderID, @StockCode, @DeliveredQtyGarments, @DeliveredQtyBoxes, @DeliveredQtyHangers, @LineAmount)";
                        sqlCommand.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderID);
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyGarments", DeliveredQtyGarments);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyBoxes", DeliveredQtyBoxes);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyHangers", DeliveredQtyHangers);
                        sqlCommand.Parameters.AddWithValue("@LineAmount", LineAmount);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    SaveToDB = false;
                }
                else
                {
                    SaveToDB = true;
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            return SaveToDB;
        }
        public bool UpdateToPurchaseOrderLinetbl()
        {
            UpdateToDB = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "UPDATE tblPurchaseOrderLines SET DeliveredQtyGarments = @DeliveredQtyGarments, DeliveredQtyBoxes = @DeliveredQtyBoxes, DeliveredQtyHangers = @DeliveredQtyHangers, LineAmount = @LineAmount WHERE PurchaseOrderID = @PurchaseOrderID AND StockCode = @StockCode";
                        sqlCommand.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderID);
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyGarments", DeliveredQtyGarments);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyBoxes", DeliveredQtyBoxes);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyHangers", DeliveredQtyHangers);
                        sqlCommand.Parameters.AddWithValue("@LineAmount", LineAmount);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    UpdateToDB = false;
                }
                else
                {
                    UpdateToDB = true;
                }
            }
            catch (SqlException ex)
            {
                UpdateToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            return UpdateToDB;
        }
        public bool DeletePurchaseOrderLineRecord()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                conn.Open();
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.CommandText = "DELETE FROM tblPurchaseOrders where PurchaseOrderID = @PurchaseOrderID";
                    DeleteCmd.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderID);
                    DeleteCmd.ExecuteNonQuery();
                }
            }
            return DeleteFromDB;
        }
    }
    public class ClsSeason : ClsUtils
    {
        // properties for the class
        // started 02/01/2020
        // completed 02/01/2020
        public int SeasonID { get; set; }
        public string SeasonName { get; set; }
        // constructor for the class
        public ClsSeason()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        // deconstructor for the class
        ~ClsSeason()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        public void LoadNewRecord()
        {
            FrmSeason season = new FrmSeason
            {
                FormMode = "New",
                Text = "New Season"
            };
            season.ShowDialog();
        }
        public void LoadSelectedSeason()
        {
            FrmSeason season = new FrmSeason()
            {
                FormMode = "Old",
                Text = "Update Season",
                SeasonID = SeasonID
            };
            season.ShowDialog();
        }
        public bool SaveSeasonRecordToDB()
        {
            // Save the Season name to the database
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandType = CommandType.Text;
                        InsertCmd.CommandText = "INSERT INTO tblSeasons (SeasonName) VALUES (@SeasonName)";
                        InsertCmd.Parameters.AddWithValue("@SeasonName", SeasonName);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Unable to Open connection to Database\nBecause : " + ex.Message.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            if (Result != 1)
            {
                SaveToDB = false;
            }
            else
            {
                SaveToDB = true;
            }
            return SaveToDB;
        }
        public bool UpdateSeasonRecordInDB()
        {
            // Update the season name against the Season ID
            UpdateToDB = true;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand UpdateCmd = new SqlCommand())
                    {
                        UpdateCmd.Connection = conn;
                        UpdateCmd.CommandType = CommandType.Text;
                        UpdateCmd.CommandText = "UPDATE tblSeasons SET SeasonName = @SeasonName WHERE SeasonID = @SeasonID";
                        UpdateCmd.Parameters.AddWithValue("@SeasonID", SeasonID);
                        UpdateCmd.Parameters.AddWithValue("@SeasonName", SeasonName);
                        Result = (int)UpdateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            if (Result != 1)
                UpdateToDB = false;
            else
                UpdateToDB = true;
            return UpdateToDB;
        }
        public bool DeleteSeasonRecordFromDB()
        {
            // delete the selected record from the database
            DeleteFromDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblSeasons WHERE SeasonID = @SeasonID";
                        DeleteCmd.Parameters.AddWithValue("@SeasonID", SeasonID);
                        DeleteFromDB = Convert.ToBoolean(DeleteCmd.ExecuteNonQuery());
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                DeleteFromDB = false;
                throw;
            }
            return DeleteFromDB;
        }
    }
    public class ClsSettings : ClsUtils
    {
        public string CompanyName;
        public string VATRegistration { get; set; }
        public decimal VATRate;
        public int ID;
        public void LoadSettings()
        {
            Result = CheckDB();
            if (Result == 1)
            {
                LoadOldForm();
            }
            else
            {
                LoadNewForm();
            }
        }
        private void LoadOldForm()
        {
            FrmSettings settings = new FrmSettings
            {
                FormMode = "Old"
            };
            settings.ShowDialog();
        }
        private void LoadNewForm()
        {
            FrmSettings settings = new FrmSettings
            {
                FormMode = "New"
            };
            settings.ShowDialog();
        }

        public bool SaveSettings()
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
                            InsertCmd.CommandText = "INSERT INTO tblCompanyDetails (CompanyName, Address1, Address2, Address3, Address4, PostCode, Telephone, Fax, VATRegistrationNo, Email, Website, VATRate) VALUES (@CompanyName, @Address1, @Address2, @Address3, @Address4, @PostCode, @Telephone, @Fax, @VATRegistrationNo, @Email, @Website, @VATRate)";
                            InsertCmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                            InsertCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                            InsertCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                            InsertCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                            InsertCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                            InsertCmd.Parameters.AddWithValue("@PostCode", PostCode);
                            InsertCmd.Parameters.AddWithValue("@Telephone", Telephone);
                            InsertCmd.Parameters.AddWithValue("@Fax", Fax);
                            InsertCmd.Parameters.AddWithValue("@VATRegistrationNo", VATRegistration);
                            InsertCmd.Parameters.AddWithValue("@Email", eMail);
                            InsertCmd.Parameters.AddWithValue("@Website", WebsiteAddress);
                            InsertCmd.Parameters.AddWithValue("@VATRate", VATRate);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        MessageBox.Show("Error in adding to database\n" + ex.Message);
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
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateSettings()
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
                            UpdateCmd.CommandText = "UPDATE tblCompanyDetails SET CompanyName =  @CompanyName, Address1 = @Address1, Address2 = @Address2, Address3 = @Address3, Address4 = @Address4, PostCode = @PostCode, Telephone = @Telephone, Fax = @Fax, VATRegistrationNo = @VATRegistrationNo, Email = @Email, Website = @Website, VATRate = @VATRate WHERE CompanyName = @CompanyName";

                            UpdateCmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                            UpdateCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                            UpdateCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                            UpdateCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                            UpdateCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                            UpdateCmd.Parameters.AddWithValue("@PostCode", PostCode);
                            UpdateCmd.Parameters.AddWithValue("@Telephone", Telephone);
                            UpdateCmd.Parameters.AddWithValue("@Fax", Fax);
                            UpdateCmd.Parameters.AddWithValue("@VATRegistrationNo", VATRegistration);
                            UpdateCmd.Parameters.AddWithValue("@Email", eMail);
                            UpdateCmd.Parameters.AddWithValue("@Website", WebsiteAddress);
                            UpdateCmd.Parameters.AddWithValue("@VATRate", VATRate);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error in adding to database\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error in adding to database\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public string Backup()
        {
            string UniqueIdenity;
            string time;
            string day;
            string month;
            string year;
            time = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            day = DateTime.Now.Day.ToString();
            month = DateTime.Now.Month.ToString();
            year = DateTime.Now.Year.ToString();
            UniqueIdenity = year + month + day + time;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(3);
                using (SqlCommand BackupCmd = new SqlCommand())
                {
                    BackupCmd.Connection = conn;
                    BackupCmd.Connection.Open();
                    BackupCmd.CommandText = "Backup database " + Reference + " to disk = 'C:\\DBBackup\\" + Reference + "_" + UniqueIdenity + ".bak'";
                    BackupCmd.ExecuteNonQuery();
                }
            }
            return "Backup Completed";
        }
        public string Restore()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(3);
                conn.Open();
                // Set Database to single mode
                using (SqlCommand RestoreCMD = new SqlCommand())
                {
                    RestoreCMD.Connection = conn;
                    RestoreCMD.CommandText = "ALTER DATABASE " + Reference + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    RestoreCMD.ExecuteNonQuery();
                }
                // Restore The Database
                using (SqlCommand RestoreCMD = new SqlCommand())
                {
                    RestoreCMD.Connection = conn;
                    RestoreCMD.CommandText = "Restore Database " + Reference + " FROM DISK ='C:\\DBBackup\\" + AddressLine1 + ".bak'";

                    RestoreCMD.ExecuteNonQuery();
                }
                // Change Database back to multi user
                using (SqlCommand RestoreCMD = new SqlCommand())
                {
                    RestoreCMD.Connection = conn;
                    RestoreCMD.CommandText = "ALTER DATABASE " + Reference + " SET Multi_User";

                    RestoreCMD.ExecuteNonQuery();
                }
            }
            return "Restore to the file name Required!";
        }
        public int CheckDB()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                conn.Open();
                using (SqlCommand selectCmd = new SqlCommand())
                {
                    selectCmd.Connection = conn;
                    selectCmd.CommandText = "Select COUNT(*) from tblCompanyDetails";
                    return (int)selectCmd.ExecuteScalar();
                }
            }
        }
    }
    public class ClsShop : ClsUtils
    {
        // properties for the class
        // started 02/01/2020
        // completed 03/01/2020
        public string ShopName;
        public string ShopType;
        // constructor for the class
        public ClsShop()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        // deconstructor for the class
        ~ClsShop()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        // Methods for the class
        public void LoadNewRecord()
        {
            // loading the new form and setting the properties for the new form
            FrmShop shop = new FrmShop
            {
                UserID = UserID,
                FormMode = "New"
            };
            shop.ShowDialog();
        }
        public void LoadSelectedShop()
        {
            // loading selected record into the shop form
            FrmShop shop = new FrmShop
            {
                FormMode = "Old",
                UserID = UserID,
            };
            shop.TxtShopRef.Text = ShopRef;
            shop.ShowDialog();
        }
        public bool SaveShopRecordToDB()
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandType = CommandType.Text;
                        InsertCmd.CommandText = "INSERT INTO tblShops (ShopRef, ShopName, Address1, Address2, Address3, Address4, PostCode, Telephone, Fax, eMail, ShopType, Memo, ContactName, CreatedBy, CreatedDate) VALUES (@ShopRef, @ShopName, @Address1, @Address2, @Address3, @Address4, @PostCode, @Telephone, @Fax, @eMail, @ShopType, @Memo, @ContactName, @CreatedBy, @CreatedDate)";
                        InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                        InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);
                        InsertCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        InsertCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                        InsertCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                        InsertCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                        InsertCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        InsertCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        InsertCmd.Parameters.AddWithValue("@Telephone", Telephone);
                        InsertCmd.Parameters.AddWithValue("@Fax", Fax);
                        InsertCmd.Parameters.AddWithValue("@eMail", eMail);
                        InsertCmd.Parameters.AddWithValue("@ShopType", ShopType);
                        InsertCmd.Parameters.AddWithValue("@Memo", Memo);
                        InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                        InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                    SaveToDB = false;
                else
                    SaveToDB = true;
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            return SaveToDB;
        }
        public bool UpdateShopRecordInDB()
        {
            UpdateToDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand UpdateCmd = new SqlCommand())
                    {
                        UpdateCmd.Connection = conn;
                        UpdateCmd.CommandType = CommandType.Text;
                        UpdateCmd.CommandText = "UPDATE tblShops SET ShopName = @ShopName, Address1 = @Address1, Address2 = @Address2, Address3 = @Address3, Address4 = @Address4, PostCode = @PostCode, ContactName = @ContactName, Telephone = Telephone, Fax = @Fax, eMail = @eMail, Memo = @Memo, ShopType = @ShopType WHERE ShopRef = @ShopRef";
                        UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                        UpdateCmd.Parameters.AddWithValue("@ShopName", ShopName);
                        UpdateCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                        UpdateCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                        UpdateCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                        UpdateCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        UpdateCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        UpdateCmd.Parameters.AddWithValue("@Telephone", Telephone);
                        UpdateCmd.Parameters.AddWithValue("@Fax", Fax);
                        UpdateCmd.Parameters.AddWithValue("@eMail", eMail);
                        UpdateCmd.Parameters.AddWithValue("@ShopType", ShopType);
                        UpdateCmd.Parameters.AddWithValue("@Memo", Memo);
                        Result = (int)UpdateCmd.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                    UpdateToDB = false;
                else
                    UpdateToDB = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                UpdateToDB = false;
                throw;
            }
            return UpdateToDB;
        }
        public bool DeleteShopRecordFromDB()
        {
            // Delete the selected Shop Record from the database
            DeleteFromDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblShops WHERE ShopRef = @ShopRef";
                        DeleteCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                    DeleteFromDB = false;
                else
                    DeleteFromDB = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                DeleteFromDB = false;
                throw;
            }
            return DeleteFromDB;
        }
        public string GetShopNameFromDB()
        {
            // Get Shop name from the selected shop reference in all shop functions of the application.
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT ShopName FROM tblShops WHERE ShopRef = @ShopRef";
                        sqlCommand.Parameters.AddWithValue("@ShopRef", ShopRef);
                        ShopName = (string)sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return ShopName;
        }
        public int TotalShopTransactionRecords()
        {
            // To get the total number of transactions before deleting the shop record from the database
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.CommandText = "SELECT * FROM tblStockMovements WHERE LocationRef = @LocationRef";
                        SelectCmd.Parameters.AddWithValue("@LocationRef", ShopRef);
                        Result = (int)SelectCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return Result;
        }
    }
    public class ClsShopAdjustment : ClsUtils
    {
        public int ID { get; set; }


        public void LoadNewForm()
        {
            FrmShopAdjustment shopAdjustment = new FrmShopAdjustment
            {
                FormMode = "New",
                UserID = UserID
            };
            shopAdjustment.Show();
        }
        public void LoadSelectedForm()
        {
            FrmShopAdjustment shopAdjustment = new FrmShopAdjustment
            {
                FormMode = "Old"
            };
            shopAdjustment.TxtSID.Text = ID.ToString();
            shopAdjustment.Show();
        }
        public int GetLastShopAdjustmentHead()
        {
            Result = 0;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                conn.Open();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblShopAdjustments";
                    Result = (int)SelectCmd.ExecuteScalar();
                }
            }
            return Result;
        }
    }
    public class ClsShopAdjustmentHead : ClsShopAdjustment
    {
        public bool SaveShopAdjustmentHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopAdjustments(ShopRef, Reference, TotalLossItems, TotalGainItems, MovementDate, CreatedBy, CreatedDate) VALUES (@ShopRef, @Reference, @TotalLossItems, @TotalGainItems, @MovementDate, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TotalLossItems", TotalLossItems);
                            InsertCmd.Parameters.AddWithValue("@TotalGainItems", TotalGainItems);
                            InsertCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
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
                if (Result == 1)
                    SaveToDB = true;
                else
                    SaveToDB = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in connecting\n" + ex.Message);
                SaveToDB = false;
                throw;
            }
            return SaveToDB;
        }
        public bool UpdateShopAdjustmentHead()
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
                            UpdateCmd.CommandText = "UPDATE tblShopAdjustments SET ShopRef = @ShopRef, Reference = @Reference, TotalLossItems = @TotalLossItems, TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE ShopAdjustmentID = @ShopAdjustmentID";
                            UpdateCmd.Parameters.AddWithValue("@ShopAdjustmentID", ID);
                            UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TotalLossItems", TotalLossItems);
                            UpdateCmd.Parameters.AddWithValue("@TotalGainItems", TotalGainItems);
                            UpdateCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Updating\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
                    }
                }
                if (Result == 1)
                    UpdateToDB = true;
                else
                    UpdateToDB = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in connecting\n" + ex.Message);
                UpdateToDB = false;
                throw;
            }
            return UpdateToDB;
        }
        public bool DeleteShopAdjustHead()
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
                            DeleteCmd.CommandText = "DELETE from tblShopAdjustments where ShopAdjustmentID = @ShopAdjustmentID;";
                            DeleteCmd.Parameters.AddWithValue("@ShopAdjustmentID", ID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in connecting\n" + ex.Message);
                        DeleteFromDB = false;
                        throw;
                    }
                }
                if (Result == 1)
                    DeleteFromDB = true;
                else
                    DeleteFromDB = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in connecting\n" + ex.Message);
                DeleteFromDB = false;
                throw;
            }
            return DeleteFromDB;
        }
    }
    public class ClsShopAdjustmentLine : ClsShopAdjustment
    {
        public bool SaveShopAdjustmentLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopAdjustmentLines(ShopAdjustmentID, StockCode, MovementType, Qty, Value) VALUES (@ShopAdjustmentID, @StockCode, @MovementType, @Qty, @Value)";
                            InsertCmd.Parameters.AddWithValue("@ShopAdjustmentID", ID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@MovementType", SMovementType);
                            InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                            InsertCmd.Parameters.AddWithValue("@Value", Value);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                }
                if (Result == 1)
                    SaveToDB = true;
                else
                    SaveToDB = false;
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            return SaveToDB;
        }
        public bool UpdateShopAdjustmentLine()
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
                            UpdateCmd.CommandText = "UPDATE tblShopAdjustmentLines SET MovementType = @MovementType, Qty = @Qty, Value = @Value WHERE ShopAdjustmentID = @ShopAdjustmentID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@MovementType", SMovementType);
                            UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                            UpdateCmd.Parameters.AddWithValue("@Value", Value);
                            UpdateCmd.Parameters.AddWithValue("@ShopAdjustmentID", ID);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Updating\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
                    }
                }
                if (Result == 1)
                    UpdateToDB = true;
                else
                    UpdateToDB = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Updating\n" + ex.Message);
                UpdateToDB = false;
                throw;
            }

            return UpdateToDB;
        }
        public bool DeleteShopAdjustLine()
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
                            DeleteCmd.CommandText = "DELETE from tblShopAdjustmentLines WHERE ShopAdjustmentID = @ShopAdjustmentID;";
                            DeleteCmd.Parameters.AddWithValue("@ShopAdjustmentID", ID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Delete\n" + ex.Message);
                        DeleteFromDB = false;
                        throw;
                    }
                }
                if (Result == 1)
                    DeleteFromDB = true;
                else
                    DeleteFromDB = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Delete\n" + ex.Message);
                DeleteFromDB = false;
                throw;
            }
            return DeleteFromDB;
        }
    }
    public class ClsShopDelivery : ClsUtils
    {
        public int ShopDelID;
        public void LoadNewForm()
        {
            FrmShopDelivery shopDelivery = new FrmShopDelivery
            {
                FormMode = "New",
                UserID = UserID
            };
            shopDelivery.ShowDialog();
        }
        public void LoadSelectedForm()
        {
            FrmShopDelivery shopDelivery = new FrmShopDelivery
            {
                FormMode = "Old",
                UserID = UserID
            };
            shopDelivery.txtDelNoteNumber.Text = ShopDelID.ToString();
            shopDelivery.ShowDialog();

        }
        public int GetLastShopDelivery()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand SelectCmd = new SqlCommand())
                        {
                            SelectCmd.Connection = conn;
                            SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblShopDeliveries";
                            Result = (int)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        Result = 0;
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
    }
    public class ClsShopDeliveryHead : ClsShopDelivery
    {

        public string ShopName;

        public string WarehouseName;

        public int TotalItems;
        public bool SaveShopDeliveryHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopDeliveries(ShopRef, WarehouseRef, Reference, TotalItems, DeliveryDate, DeliveryType, ConfirmedDate, Notes, CreatedBy, CreatedDate) VALUES (@ShopRef, @WarehouseRef, @Reference, @TotalItems, @DeliveryDate, @DeliveryType, @ConfirmedDate, @Notes, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            InsertCmd.Parameters.AddWithValue("@DeliveryDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@DeliveryType", "Confirmed");
                            InsertCmd.Parameters.AddWithValue("@ConfirmedDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@Notes", "");
                            InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                            InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateShopDeliveryHead()
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
                            UpdateCmd.CommandText = "UPDATE tblShopDeliveries SET ShopRef = @ShopRef, WarehouseRef = @WarehouseRef, Reference = @Reference, TotalItems = @TotalItems, DeliveryDate = @DeliveryDate, DeliveryType = @DeliveryType, ConfirmedDate = @ConfirmedDate, Notes = @Notes WHERE ShopDeliveryID = @ShopDeliveryID";
                            UpdateCmd.Parameters.AddWithValue("@ShopDeliveryID", ShopDelID);
                            UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            UpdateCmd.Parameters.AddWithValue("@DeliveryDate", MovementDate);
                            UpdateCmd.Parameters.AddWithValue("@DeliveryType", "Confirmed");
                            UpdateCmd.Parameters.AddWithValue("@ConfirmedDate", MovementDate);
                            UpdateCmd.Parameters.AddWithValue("@Notes", "");
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
                System.Windows.Forms.MessageBox.Show("Error in Updating\n" + ex.Message);
                UpdateToDB = false;
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteShopDeliveryHead()
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
                            DeleteCmd.CommandText = "DELETE from tblShopDeliveries where ShopDeliveryID = @ShopDeliveryID;";
                            DeleteCmd.Parameters.AddWithValue("@ShopDeliveryID", ShopDelID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Deleting\n" + ex.Message);
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
    public class ClsShopDeliveryLine : ClsShopDelivery
    {
        public bool SaveShopDeliveryLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopDeliveryLines (ShopDeliveryID, StockCode, DeliveredQty) VALUES (@ShopDeliveryID, @StockCode, @DeliveredQty)";
                            InsertCmd.Parameters.AddWithValue("@ShopDeliveryID", ShopDelID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@DeliveredQty", Qty);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
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
                SaveToDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateShopDeliveryLine()
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
                            UpdateCmd.CommandText = "UPDATE tblShopDeliveryLines SET DeliveredQty = @DeliveredQty WHERE ShopDeliveryID = @ShopDeliveryID AND StockCode = StockCode";
                            UpdateCmd.Parameters.AddWithValue("@ShopDeliveryID", ShopDelID);
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@DeliveredQty", Qty);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        UpdateToDB = false;
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
                UpdateToDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteShopDeliveryLine()
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
                            DeleteCmd.CommandText = "DELETE from tblShopDeliveryLines WHERE DeliveriesID = @DeliveriesID;";
                            DeleteCmd.Parameters.AddWithValue("@DeliveriesID", ShopDelID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        DeleteFromDB = false;
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
    }
    public class ClsShopReturn : ClsUtils
    {
        public int ShopReturnID { get; set; }
        public void LoadNewForm()
        {
            FrmShopReturn shopReturn = new FrmShopReturn()
            {
                FormMode = "New",
                UserID = UserID
            };
            shopReturn.Show();
        }
        public void LoadSelectedForm()
        {
            FrmShopReturn shopReturn = new FrmShopReturn()
            {
                FormMode = "Old"
            };
            shopReturn.txtReturnID.Text = ShopReturnID.ToString();
            shopReturn.Show();
        }
        public int GetLastShopReturnHead()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand SelectCmd = new SqlCommand())
                        {
                            SelectCmd.Connection = conn;
                            SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblShopReturns";
                            Result = (int)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            return Result;
        }
    }
    class ClsShopReturnHead : ClsShopReturn
    {
        public int TotalItems;
        public bool SaveShopReturnHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopReturns (ShopRef, WarehouseRef, Reference, TotalItems, TransactionDate, CreatedBy, CreatedDate) VALUES (@ShopRef, @WarehouseRef, @Reference, @TotalItems, @TransactionDate, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            InsertCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                            InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            InsertCmd.ExecuteNonQuery();
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

            return SaveToDB;
        }
        public bool UpdateShopReturnHead()
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
                            UpdateCmd.CommandText = "UPDATE tblShopReturns SET ShopRef = @ShopRef, WarehouseRef = @WarehouseRef, Reference = @Reference, TotalItems = @TotalItems,TransactionDate = @TransactionDate WHERE ReturnsID = @ReturnsID";
                            UpdateCmd.Parameters.AddWithValue("@ReturnsID", ShopReturnID);
                            UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            UpdateCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
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
        public bool DeleteShopReturnHead()
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
                            DeleteCmd.CommandText = "DELETE FROM tblShopReturns WHERE ReturnsID = @ReturnsID";
                            DeleteCmd.Parameters.AddWithValue("@ReturnsID", ShopReturnID);
                            DeleteCmd.ExecuteNonQuery();
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
    class ClsShopReturnLine : ClsShopReturn
    {
        public bool SaveShopReturnLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopReturnLines (ShopReturnID, StockCode, Qty) VALUES (@ShopReturnID, @StockCode, @Qty)";
                            InsertCmd.Parameters.AddWithValue("@ShopReturnID", ShopReturnID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@Qty", Qty);
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
        public bool UpdateShopReturnLine()
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
                            UpdateCmd.CommandText = "UPDATE tblShopReturnLines SET Qty = @Qty,Value = @Value WHERE ShopReturnID = @ShopReturnID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@ShopReturnID", ShopReturnID);
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                            UpdateCmd.Parameters.AddWithValue("@Value", Value);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
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
        public bool DeleteShopReturnLine()
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
                            DeleteCmd.CommandText = "DELETE FROM tblShopReturnLines WHERE ShopReturnID = @ShopReturnID;";
                            DeleteCmd.Parameters.AddWithValue("@ShopReturnID", ShopReturnID);
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
    public class ClsShopSale : ClsUtils
    {
        public int SalesID { get; set; }
        public void LoadNewForm()
        {
            FrmShopSale shopSale = new FrmShopSale()
            {
                FormMode = "New",
                UserID = UserID
            };
            shopSale.Show();
        }
        public void LoadSelectedForm()
        {
            FrmShopSale shopSale = new FrmShopSale()
            {
                FormMode = "Old"
            };
            shopSale.txtSalesID.Text = SalesID.ToString();
            shopSale.Show();
        }
        public int GetLastShopSaleHead()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand SelectCmd = new SqlCommand())
                        {
                            SelectCmd.Connection = conn;
                            SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblShopSales";
                            Result = (int)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            return Result;
        }
    }
    public class ClsShopSaleHead : ClsShopSale
    {
        public string ShopName;
        public decimal VATRate;
        public bool SaveShopSaleHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopSales (ShopRef, ShopName, TransactionDate, TotalQty, TotalVAT, TotalSale, CreatedBy, CreatedDate) VALUES (@ShopRef, @ShopName, @TransactionDate, @TotalQty, @TotalVAT, @TotalSale, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);
                            InsertCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@TotalQty", Qty);
                            InsertCmd.Parameters.AddWithValue("@TotalVAT", VATRate);
                            InsertCmd.Parameters.AddWithValue("@TotalSale", Value);
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
        public bool UpdateShopSaleHead()
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
                            UpdateCmd.CommandText = "UPDATE tblShopSales SET ShopRef = @ShopRef, ShopName = @ShopName,  TransactionDate = @TransactionDate, TotalQty = @TotalQty, TotalVAT = @TotalVAT, TotalSale = @TotalSale WHERE SalesID = @SalesID";
                            UpdateCmd.Parameters.AddWithValue("@SalesID", SalesID);
                            UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            UpdateCmd.Parameters.AddWithValue("@ShopName", ShopName);
                            UpdateCmd.Parameters.AddWithValue("@TotalVAT", VATRate);
                            UpdateCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            UpdateCmd.Parameters.AddWithValue("@TotalQty", Qty);
                            UpdateCmd.Parameters.AddWithValue("@TotalSale", Value);
                            UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
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
        public bool DeleteShopSaleHead()
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
                            DeleteCmd.CommandText = "DELETE from tblShopSales WHERE SalesID =@SalesID;";
                            DeleteCmd.Parameters.AddWithValue("@SalesID", SalesID);
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
    public class ClsShopSaleLine : ClsShopSale
    {
        public int CurrentQty;
        public int TotalItems;
        public decimal SalesAmount;
        public bool SaveShopSaleLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopSalesLines (SalesID, StockCode, DeliveredQty, CurrentQty, TotalSoldQty, QtySold, SalesAmount) VALUES (@SalesID, @StockCode, @DeliveredQty, @CurrentQty, @TotalSoldQty, @QtySold, @SalesAmount)";
                            InsertCmd.Parameters.AddWithValue("@SalesID", SalesID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@DeliveredQty", DeliveredQtyGarments);
                            InsertCmd.Parameters.AddWithValue("@CurrentQty", CurrentQty);
                            InsertCmd.Parameters.AddWithValue("@TotalSoldQty", TotalItems);
                            InsertCmd.Parameters.AddWithValue("@QtySold", Qty);
                            InsertCmd.Parameters.AddWithValue("@SalesAmount", SalesAmount);
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
        public bool UpdateShopSaleLine()
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
                            UpdateCmd.CommandText = "UPDATE tblShopSalesLines SET CurrentQty = @CurrentQty, QtySold = @QtySold, SalesAmount = @SalesAmount, StockMovementID = @StockMovementID WHERE SalesID = @SalesID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@SalesID", SalesID);
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@CurrentQty", CurrentQty);
                            UpdateCmd.Parameters.AddWithValue("@QtySold", Qty);
                            UpdateCmd.Parameters.AddWithValue("@SalesAmount", SalesAmount);
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
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
        public bool DeleteShopSaleLine()
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
                            DeleteCmd.CommandText = "DELETE from tblShopSalesLines WHERE SalesID = @SalesID;";
                            DeleteCmd.Parameters.AddWithValue("@SalesID", SalesID);
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
                DeleteFromDB = false;
                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
        public bool DeleteShopZeroSaleLine()
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
                            DeleteCmd.CommandText = "DELETE from tblShopSalesLines WHERE SalesID = @SalesID AND QtySold = @QtySold AND SalesAmount = @SalesAmount;";
                            DeleteCmd.Parameters.AddWithValue("@SalesID", SalesID);
                            DeleteCmd.Parameters.AddWithValue("@QtySold", "0");
                            DeleteCmd.Parameters.AddWithValue("@SalesAmount", "0.00");
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
    public class ClsShopTransfer : ClsUtils
    {
        public int ShopTransferID { get; set; }
        public void LoadNewForm()
        {
            FrmShopTransfer shopTransfer = new FrmShopTransfer()
            {
                FormMode = "New",
                UserID = UserID
            };
            shopTransfer.Show();
        }
        public void LoadSelectedForm()
        {
            FrmShopTransfer shopTransfer = new FrmShopTransfer()
            {
                FormMode = "Old"
            };
            shopTransfer.TxtTransferID.Text = ShopTransferID.ToString();
            shopTransfer.Show();
        }
        public int GetLastShopTransferHead()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand SelectCmd = new SqlCommand())
                        {
                            SelectCmd.Connection = conn;
                            SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblShopTransfers";
                            Result = (int)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            return Result;
        }
    }
    public class ClsShopTransferHead : ClsShopTransfer
    {
        public string ToShopRef;
        public string ShopName;
        public string ToShopName;
        public int ID;
        public bool SaveShopTransferHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopTransfers (Reference, TransferDate, ShopRef, ShopName, ToShopRef, ToShopName, TotalQtyOut, TotalQtyIn, CreatedBy, CreatedDate) VALUES (@Reference, @TransferDate, @ShopRef, @ShopName, @ToShopRef, @ToShopName, @TotalQtyOut, @TotalQtyIn, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TransferDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);
                            InsertCmd.Parameters.AddWithValue("@ToShopRef", ToShopRef);
                            InsertCmd.Parameters.AddWithValue("@ToShopName", ToShopName);
                            InsertCmd.Parameters.AddWithValue("@TotalQtyOut", Qty * -1);
                            InsertCmd.Parameters.AddWithValue("@TotalQtyIn", Qty);
                            InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                            InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateShopTransferHead()
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
                            UpdateCmd.CommandText = "UPDATE tblShopTransfers SET Reference = @Reference, TransferDate = @TransferDate, ShopRef = @ShopRef, ShopName = @ShopName, ToShopRef = @ToShopRef, ToShopName = @ToShopName, TotalQtyOut = @TotalQtyOut, TotalQtyOut = @TotalQtyOut WHERE TransferID = @TransferID";
                            UpdateCmd.Parameters.AddWithValue("@TransferID", ID);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TransferDate", MovementDate);
                            UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            UpdateCmd.Parameters.AddWithValue("@ShopName", ShopName);
                            UpdateCmd.Parameters.AddWithValue("@ToShopRef", ToShopRef);
                            UpdateCmd.Parameters.AddWithValue("@ToShopName", ToShopName);
                            UpdateCmd.Parameters.AddWithValue("@TotalQtyOut", Qty * -1);
                            UpdateCmd.Parameters.AddWithValue("@TotalQtyIn", Qty);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        UpdateToDB = false;
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                UpdateToDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteShopTransferHead()
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
                            DeleteCmd.CommandText = "DELETE FROM tblShopTransfers WHERE ShopTransferID = @ShopTransferID";
                            DeleteCmd.Parameters.AddWithValue("@ShopTransferID", ID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        DeleteFromDB = false;
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }

                }
            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
    }
    public class ClsShopTransferLine : ClsShopTransfer
    {
        public int ID;
        public int CurrQty;
        public int TOQty;
        public int TIQty;
        public bool SaveShopTransferLine()
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
                        InsertCmd.CommandText = "INSERT INTO tblShopTransferLines (ShopTransferID, StockCode, CurrentQty, TOQty, TIQty) VALUES (@ShopTransferID,  @StockCode, @CurrentQty, @TOQty, @TIQty)";
                        InsertCmd.Parameters.AddWithValue("@ShopTransferID", ID);
                        InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        InsertCmd.Parameters.AddWithValue("@CurrentQty", CurrQty);
                        InsertCmd.Parameters.AddWithValue("@TOQty", TOQty);
                        InsertCmd.Parameters.AddWithValue("@TIQty", TIQty);
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
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateShopTransferLine()
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
                            UpdateCmd.CommandText = "UPDATE tblShopTransferLines SET TOQty = @TOQty, TIQty = @TIQty WHERE ShopTransferID = @ShopTransferID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@ShopTransferID", ID);
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@TOQty", TOQty);
                            UpdateCmd.Parameters.AddWithValue("@TIQty", TIQty);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        UpdateToDB = false;
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
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
        public bool DeleteShopTransferLine()
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
                            DeleteCmd.CommandText = "DELETE FROM tblShopTransferLines WHERE ShopTransferID = @ShopTransferID;";
                            DeleteCmd.Parameters.AddWithValue("@ShopTransferID", ID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        DeleteFromDB = false;
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
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
    public class ClsStock : ClsUtils
    {
        public string SeasonName;
        public bool DeadCode;
        public bool ZeroQty;
        public decimal AmountTaken;
        public decimal CostValue;
        public decimal PCMarkUp;
        public ClsStock()
        {
            SaveToDB = false;
            DeleteFromDB = false;
            UpdateToDB = false;
        }
        ~ClsStock()
        {
            SaveToDB = false;
            DeleteFromDB = false;
            UpdateToDB = false;
        }
        public void LoadNewRecord()
        {

        }
        public void LoadSelectedStockRecord()
        {

        }
        public bool SaveStockCodeToDB()
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "INSERT INTO tblStock (StockCode, SupplierRef, SeasonName, DeadCode, AmountTaken, DeliveredQtyGarments, DeliveredQtyBoxes, DeliveredQtyHangers, CostValue, PCMarkUp, ZeroQty, CreatedBy, CreatedDate) VALUES (@StockCode, @SupplierRef, @SeasonName, @DeadCode, @AmountTaken, @DeliveredQtyGarments, @DeliveredQtyBoxes, @DeliveredQtyHangers, @CostValue, @PCMarkUp, @ZeroQty, @CreatedBy, @CreatedDate)";
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@SeasonName", SeasonName);
                        sqlCommand.Parameters.AddWithValue("@DeadCode", DeadCode);
                        sqlCommand.Parameters.AddWithValue("@AmountTaken", AmountTaken);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyGarments", DeliveredQtyGarments);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyBoxes", DeliveredQtyBoxes);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyHangers", DeliveredQtyHangers);
                        sqlCommand.Parameters.AddWithValue("@CostValue", CostValue);
                        sqlCommand.Parameters.AddWithValue("@PCMarkUp", PCMarkUp);
                        sqlCommand.Parameters.AddWithValue("@ZeroQty", ZeroQty);
                        sqlCommand.Parameters.AddWithValue("@CreatedBy", UserID);
                        sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    SaveToDB = false;
                }
                else
                {
                    SaveToDB = true;
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            return SaveToDB;
        }
        public bool UpdateStockCodeInDB()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "UPDATE tblStock SET SupplierRef = @SupplierRef, DeadCode = @DeadCode, AmountTaken = @AmountTaken, DeliveredQtyHangers = @DeliveredQtyHangers, DeliveredQtyBoxes = @DeliveredQtyBoxes,  DeliveredQtyGarments = @DeliveredQtyGarments, CostValue = @CostValue, PCMarkUp = @PCMarkUp, ZeroQty = @ZeroQty, SeasonName = @SeasonName WHERE StockCode = @StockCode";
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@SeasonName", SeasonName);
                        sqlCommand.Parameters.AddWithValue("@DeadCode", DeadCode);
                        sqlCommand.Parameters.AddWithValue("@AmountTaken", AmountTaken);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyGarments", DeliveredQtyGarments);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyBoxes", DeliveredQtyBoxes);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyHangers", DeliveredQtyHangers);
                        sqlCommand.Parameters.AddWithValue("@CostValue", CostValue);
                        sqlCommand.Parameters.AddWithValue("@PCMarkUp", PCMarkUp);
                        sqlCommand.Parameters.AddWithValue("@ZeroQty", ZeroQty);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                    UpdateToDB = false;
                else
                    UpdateToDB = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return UpdateToDB;
        }
        public bool DeleteStockCodeFromDB()
        {
            DeleteFromDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblStock where StockCode = @StockCode";
                        DeleteCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
                if (Result == 1)
                    DeleteFromDB = true;
                else
                    DeleteFromDB = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return DeleteFromDB;
        }
        public int TotalStockTransactionRecords()
        {
            // To get the total number of transactions before deleting the Stock Code record from the database
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.CommandText = "SELECT * FROM tblStockMovements WHERE StockCode = @StockCode";
                        SelectCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        Result = (int)SelectCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return Result;
        }
        public bool UpdateAmountTaken()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.CommandText = "UPDATE tblStock SET AmountTaken = SUM(tblSalesLine.LineAmount) As AmountTaken FROM tblStock,tblSalesLine WHERE (tblStock.StockCode = tblSalesLine.StockCode)";
                            UpdateCmd.CommandType = CommandType.Text;
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
                throw;
            }

            return UpdateToDB;
        }
        public bool UpdateCostValue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.CommandText = "UPDATE tblStock SET CostValue = qryPurchaseLineSum.LineAmount FROM tblStock,QryPurchaseLineSum WHERE (tblStock.StockCode = qryPurchaseLineSum.StockCode)";
                            UpdateCmd.CommandType = CommandType.Text;
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
                throw;
            }
            return UpdateToDB;
        }
        public bool UpdateDeliveredQtyHangersValue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.CommandText = "UPDATE tblStock SET DeliveredQtyHangers = qryPurchaseLineSum.QtyHangers FROM tblStock,qryPurchaseLineSum WHERE (tblStock.StockCode = qryPurchaseLineSum.StockCode)";
                            UpdateCmd.CommandType = CommandType.Text;
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
                throw;
            }
            return UpdateToDB;
        }
        public bool UpdateDeliveredQtyBoxesValue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.CommandText = "UPDATE tblStock SET DeliveredQtyBoxes = qryPurchaseLineSum.QtyBoxes FROM tblStock,qryPurchaseLineSum WHERE (tblStock.StockCode = qryPurchaseLineSum.StockCode)";
                            UpdateCmd.CommandType = CommandType.Text;
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
                throw;
            }
            return UpdateToDB;
        }
        public bool UpdateDeliveredQtyGarmentsValue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.CommandText = "UPDATE tblStock SET DeliveredQtyGarments = qryPurchaseLineSum.QtyGarments FROM tblStock,qryPurchaseLineSum WHERE (tblStock.StockCode = qryPurchaseLineSum.StockCode)";
                            UpdateCmd.CommandType = CommandType.Text;
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
                throw;
            }
            return UpdateToDB;
        }
        public int CheckStockCodeSave()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT COUNT(*) AS Records FROM tblStock WHERE StockCode = @StockCode";
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        Result = (int)SelectCmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return Result;
        }
        public bool UpdatePCMarkup()
        {
            // Due to restrictions unable to complete this section of code.
            return UpdateToDB;
        }
        public int GetWarehouseStockQty()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT QtyHangers FROM qryWarehouseStock WHERE StockCode = @StockCode AND LocationRef = @LocationRef";
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        SelectCmd.Parameters.AddWithValue("@LocationRef", WarehouseRef);
                        Result = (int)SelectCmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return Result;
        }
        public int GetShopStockQty()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT QtyHangers FROM qryShopStock WHERE StockCode = @StockCode AND LocationRef = @LocationRef";
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        SelectCmd.Parameters.AddWithValue("@LocationRef", ShopRef);
                        Result = (int)SelectCmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return Result;
        }
        public decimal GetStockValueQty(decimal qty)
        {
            decimal ValueToPassBack;
            decimal Start;
            decimal Exponent;
            Exponent = Convert.ToDecimal(qty);
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT UnitPrice FROM qryWarehouseStock WHERE StockCode = @StockCode AND LocationRef = @LocationRef";
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        SelectCmd.Parameters.AddWithValue("@LocationRef", WarehouseRef);
                        Start = (decimal)SelectCmd.ExecuteScalar();
                    }
                }
                ValueToPassBack = Start * Exponent;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return ValueToPassBack;
        }
        public decimal GetShopStockValue(decimal qty)
        {
            decimal ValueToPassBack;
            decimal Start;
            decimal Exponent;
            Exponent = Convert.ToDecimal(qty);
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT UnitPrice FROM qryShopStock WHERE StockCode = @StockCode AND LocationRef = @LocationRef";
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        SelectCmd.Parameters.AddWithValue("@LocationRef", ShopRef);
                        Start = (decimal)SelectCmd.ExecuteScalar();
                    }
                }
                ValueToPassBack = Start * Exponent;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return ValueToPassBack;
        }
    }
    public class ClsSupplier : ClsUtils
    {
        // properties for the class
        public string SupplierName { get; set; }
        // constructor for the class
        public ClsSupplier()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        // deconstructor for the class
        ~ClsSupplier()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        public void LoadNewRecord()
        {
            FrmSupplier supplier = new FrmSupplier
            {
                FormMode = "New",
                UserID = UserID
            };
            supplier.ShowDialog();
        }
        public void LoadSelectedSupplier()
        {
            FrmSupplier supplier = new FrmSupplier
            {
                FormMode = "Old"
            };
            supplier.TxtSupplierRef.Text = SupplierRef;
            supplier.ShowDialog();
        }
        public bool SaveSupplierRecordToDB()
        {
            // save supplier to database
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandType = CommandType.Text;
                        InsertCmd.CommandText = "INSERT INTO tblSuppliers (SupplierRef, SupplierName, Address1, Address2, Address3, Address4, PostCode, ContactName, Telephone, Fax, eMail, Memo, WebSite, CreatedBy, CreatedDate) VALUES (@SupplierRef, @SupplierName, @Address1, @Address2, @Address3, @Address4, @PostCode, @ContactName, @Telephone, @Fax, @eMail, @Memo, @Website, @CreatedBy, @CreatedDate)";
                        InsertCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        InsertCmd.Parameters.AddWithValue("@SupplierName", SupplierName);
                        InsertCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        InsertCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                        InsertCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                        InsertCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                        InsertCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        InsertCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        InsertCmd.Parameters.AddWithValue("@Telephone", Telephone);
                        InsertCmd.Parameters.AddWithValue("@Fax", Fax);
                        InsertCmd.Parameters.AddWithValue("@eMail", eMail);
                        InsertCmd.Parameters.AddWithValue("@Memo", Memo);
                        InsertCmd.Parameters.AddWithValue("@WebSite", WebsiteAddress);
                        InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                        InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    SaveToDB = false;
                }
                else
                {
                    SaveToDB = true;
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            return SaveToDB;
        }
        public bool UpdateSupplierRecordInDB()
        {
            // update supplier in database
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand UpdateCmd = new SqlCommand())
                    {
                        UpdateCmd.Connection = conn;
                        UpdateCmd.CommandType = CommandType.Text;
                        UpdateCmd.CommandText = "UPDATE tblSuppliers SET SupplierName = @SupplierName, Address1 = @Address1, Address2 = @Address2, Address3 = @Address3, Address4 = @Address4, PostCode = @PostCode, ContactName = @ContactName, Telephone = @Telephone, Fax = @Fax, eMail = @eMail, Memo = @Memo, WebSite = @WebSite WHERE SupplierRef = @SupplierRef";
                        UpdateCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        UpdateCmd.Parameters.AddWithValue("@SupplierName", SupplierName);
                        UpdateCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address2", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address3", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address4", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        UpdateCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        UpdateCmd.Parameters.AddWithValue("@Telephone", Telephone);
                        UpdateCmd.Parameters.AddWithValue("@Fax", Fax);
                        UpdateCmd.Parameters.AddWithValue("@eMail", eMail);
                        UpdateCmd.Parameters.AddWithValue("@Memo", Memo);
                        UpdateCmd.Parameters.AddWithValue("@WebSite", WebsiteAddress);
                        Result = (int)UpdateCmd.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    UpdateToDB = false;
                }
                else
                {
                    UpdateToDB = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return UpdateToDB;
        }
        public bool DeleteSupplierRecordFromDB()
        {
            // Delete supplier from database
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblSuppliers where SupplierRef = @SupplierRef";
                        DeleteCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
                if (Result == 1)
                {
                    DeleteFromDB = true;
                }
                else
                {
                    DeleteFromDB = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return DeleteFromDB;
        }
        public string GetSupplierNameFromDB()
        {
            // Get the supplier name for a selected supplier reference
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT SupplierName FROM tblSuppliers WHERE SupplierRef = @SupplierRef";
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        SupplierName = (string)sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return SupplierName;
        }
        public int TotalSupplierTransactionRecords()
        {
            // To get the total number of transactions before deleting the shop record from the database
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.CommandText = "SELECT * FROM tblStockMovements WHERE SupplierRef = @SupplierRef";
                        SelectCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        Result = (int)SelectCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return Result;
        }
    }
    public class ClsWarehouse : ClsUtils
    {
        // properties of the class
        // started 01/01/2020
        // Completed 02/01/2020 
        public string WarehouseName;
        public string WarehouseType;
        // constructor for the class
        public ClsWarehouse()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        // deconstructor for the class
        ~ClsWarehouse()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
            WarehouseName = "";
            WarehouseType = "";
        }
        // methods for the class
        public void LoadNewRecord()
        {
            // loading the new form and setting the properties of the form
            FrmWarehouse warehouse = new FrmWarehouse
            {
                UserID = UserID,
                FormMode = "New"
            };
            warehouse.ShowDialog();
        }
        public void LoadSelectedWarehouse()
        {
            // loading a selected record into the form
            FrmWarehouse warehouse = new FrmWarehouse
            {
                FormMode = "Old",
                UserID = UserID
            };
            warehouse.TxtWarehouseRef.Text = WarehouseRef;
            warehouse.ShowDialog();
        }
        public bool SaveWarehouseRecordToDB()
        {
            // Saving the entered data into the database
            SaveToDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandType = CommandType.Text;
                        InsertCmd.CommandText = "INSERT INTO tblWarehouses (WarehouseRef, WarehouseName, Address1, Address2, Address3, Address4 ,PostCode, ContactName, Telephone, WebSite, Fax, eMail, WarehouseType, Memo, CreatedBy, CreatedDate) VALUES (@WarehouseRef, @WarehouseName, @Address1, @Address2, @Address3, @Address4 , @PostCode, @ContactName, @Telephone, @WebSite, @Fax, @eMail, @WarehouseType, @Memo, @CreatedBy, @CreatedDate)";
                        InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        InsertCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                        InsertCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        InsertCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                        InsertCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                        InsertCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                        InsertCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        InsertCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        InsertCmd.Parameters.AddWithValue("@Telephone", Telephone);
                        InsertCmd.Parameters.AddWithValue("@WebSite", WebsiteAddress);
                        InsertCmd.Parameters.AddWithValue("@Fax", Fax);
                        InsertCmd.Parameters.AddWithValue("@eMail", eMail);
                        InsertCmd.Parameters.AddWithValue("@WarehouseType", WarehouseType);
                        InsertCmd.Parameters.AddWithValue("@Memo", Memo);
                        InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                        InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    SaveToDB = false;
                }
                else
                {
                    SaveToDB = true;
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            return SaveToDB;
        }
        public bool UpdateWarehouseRecordInDB()
        {
            // Updating selected warehouse record in the database
            UpdateToDB = true;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand UpdateCmd = new SqlCommand())
                    {
                        UpdateCmd.Connection = conn;
                        UpdateCmd.CommandType = CommandType.Text;
                        UpdateCmd.CommandText = "UPDATE tblWarehouses SET WarehouseName = @WarehouseName, Address1 = @Address1, Address2 = @Address2, Address3 = @Address3, Address4 = @Address4, PostCode = @PostCode, ContactName = @ContactName, Telephone = Telephone, WebSite = @WebSite, Fax = @Fax, eMail = @eMail, Memo = @Memo, WarehouseType = @WarehouseType WHERE WarehouseRef = @WarehouseRef";
                        UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        UpdateCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                        UpdateCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address2", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address3", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address4", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        UpdateCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        UpdateCmd.Parameters.AddWithValue("@Telephone", Telephone);
                        UpdateCmd.Parameters.AddWithValue("@WebSite", WebsiteAddress);
                        UpdateCmd.Parameters.AddWithValue("@Fax", Fax);
                        UpdateCmd.Parameters.AddWithValue("@eMail", eMail);
                        UpdateCmd.Parameters.AddWithValue("@WarehouseType", WarehouseType);
                        UpdateCmd.Parameters.AddWithValue("@Memo", Memo);
                        UpdateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return UpdateToDB;
        }
        public bool DeleteWarehouseRecordFromDB()
        {
            // delete the warehouse record from the database
            DeleteFromDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblWarehouses where WarehouseRef = @WarehouseRef";
                        DeleteCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
                if (Result == 1)
                {
                    DeleteFromDB = true;
                }
                else
                {
                    DeleteFromDB = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return DeleteFromDB;
        }
        public string GetWarehouseNameFromDB()
        {
            // getting the name of a specific warehouse from the database
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.CommandText = "SELECT WarehouseName FROM tblWarehouses WHERE WarehouseRef = @WarehouseRef";
                        SelectCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        WarehouseName = (string)SelectCmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return WarehouseName;
        }
        public int TotalWarehouseTransactionRecords()
        {
            // to check to see if warehouse can be deleted from the database
            Result = 0; // setting the inital value to be passed back if nothing is returned
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT COUNT(*) AS TotalRecords FROM tblStockMovements WHERE LocationRef = @LocationRef";
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.Parameters.AddWithValue("@LocationRef", WarehouseRef);
                        Result = (int)SelectCmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Result = 0;
                throw;
            }
            return Result;
        }
    }
    public class ClsWarehouseAdjustment : ClsUtils
    {
        public int WarehouseAdjustmentID { get; set; }
        public void LoadNewWarehouseAdjustment()
        {
            FrmWarehouseAdjustment warehouseAdjustment = new FrmWarehouseAdjustment
            {
                FormMode = "New",
                UserID = UserID
            };
            warehouseAdjustment.ShowDialog();
        }
        public void LoadSelectedWarehouseAdjustment()
        {
            FrmWarehouseAdjustment warehouseAdjustment = new FrmWarehouseAdjustment
            {
                FormMode = "Old",
                UserID = UserID

            };
            warehouseAdjustment.TxtRecordID.Text = WarehouseAdjustmentID.ToString();
            warehouseAdjustment.ShowDialog();
        }

        public int GetLastWarehouseAdjustmentHead()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand SelectCmd = new SqlCommand())
                        {
                            SelectCmd.Connection = conn;
                            SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblWarehouseAdjustments";
                            Result = (int)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Looking for Last Record\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Looking for Last Record\n" + ex.Message);
                throw;
            }
            return Result;
        }
    }
    public class ClsWarehouseAdjustmentHead : ClsWarehouseAdjustment
    {
        public bool SaveWarehouseAdjustmentHeadToDB()
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
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseAdjustments(WarehouseRef, Reference, TotalLossItems, TotalGainItems, MovementDate, CreatedBy, CreatedDate) VALUES (@WarehouseRef, @Reference, @TotalLossItems, @TotalGainItems, @MovementDate, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TotalLossItems", TotalLossItems);
                            InsertCmd.Parameters.AddWithValue("@TotalGainItems", TotalGainItems);
                            InsertCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                            InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        MessageBox.Show("Error in Saving\n" + ex.Message);
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
                SaveToDB = false;
                MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseAdjustmentHeadInDB()
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
                            UpdateCmd.CommandText = "UPDATE tblWarehouseAdjustments SET WarehouseRef = @WarehouseRef, Reference = @Reference, TotalLossItems = @TotalLossItems, TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE WarehouseAdjustmentID = @WarehouseAdjustmentID";
                            UpdateCmd.Parameters.AddWithValue("@WarehouseAdjustmentID", WarehouseAdjustmentID);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TotalLossItems", TotalLossItems);
                            UpdateCmd.Parameters.AddWithValue("@TotalGainItems", TotalGainItems);
                            UpdateCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                            UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        UpdateToDB = false;
                        MessageBox.Show("Error in Updating Record\n" + ex.Message);
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
                UpdateToDB = false;
                MessageBox.Show("Error in Updating Record\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseAdjustmentHeadFromDB()
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
                            DeleteCmd.CommandText = "DELETE from tblWarehouseAdjustments where WarehouseAdjustmentID = @WarehouseAdjustmentID;";
                            DeleteCmd.Parameters.AddWithValue("@WarehouseAdjustmentID", WarehouseAdjustmentID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error in Deleting Record\n" + ex.Message);
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
                MessageBox.Show("Error in Deleting Recordg\n" + ex.Message);
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
    public class ClsWarehouseAdjustmentLine : ClsWarehouseAdjustment
    {
        public bool SaveWarehouseAdjustmentLineToDB()
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
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseAdjustmentsLines (WarehouseAdjustmentID, StockCode, MovementType, Qty, Value) VALUES (@WarehouseAdjustmentID, @StockCode, @MovementType, @Qty, @Value)";
                            InsertCmd.Parameters.AddWithValue("@WarehouseAdjustmentID", WarehouseAdjustmentID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@MovementType", SMovementType);
                            InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                            InsertCmd.Parameters.AddWithValue("@Value", Value);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error in Saving\n" + ex.Message);
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
                MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseAdjustmentLineInDB()
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
                            UpdateCmd.CommandText = "UPDATE tblWarehouseAdjustmentsLines SET MovementType = @MovementType, Qty = @Qty, Value = @Value WHERE WarehouseAdjustmentID = @WarehouseAdjustmentID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@MovementType", SMovementType);
                            UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                            UpdateCmd.Parameters.AddWithValue("@Value", Value);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseAdjustmentID", WarehouseAdjustmentID);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error in Updating Record\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Updating Record\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseAdjustmentLineFromDB()
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
                            DeleteCmd.CommandText = "DELETE from tblWarehouseAdjustmentsLines WHERE WarehouseAdjustmentID = @WarehouseAdjustmentID;";
                            DeleteCmd.Parameters.AddWithValue("@WHAdjustID", WarehouseAdjustmentID);
                            DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        DeleteFromDB = false;
                        MessageBox.Show("Error in Deleting Record\n" + ex.Message);
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
                DeleteFromDB = false;
                MessageBox.Show("Error in Deleteing Record\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
    }
    public class ClsWarehouseReturn : ClsUtils
    {
        public int WarehouseReturnID { get; set; }
        public void LoadNewForm()
        {
            FrmWarehouseReturn warehouseReturn = new FrmWarehouseReturn()
            {
                FormMode = "New",
                UserID = UserID
            };
            warehouseReturn.Show();
        }
        public void LoadSelectedForm()
        {
            FrmWarehouseReturn warehouseReturn = new FrmWarehouseReturn()
            {
                FormMode = "Old"
            };
            warehouseReturn.txtReturnID.Text = WarehouseReturnID.ToString();
            warehouseReturn.Show();
        }
        public int GetLastWarehouseReturnHead()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand SelectCmd = new SqlCommand())
                        {
                            SelectCmd.Connection = conn;
                            SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblWarehouseReturns";
                            Result = (int)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            return Result;
        }
    }
    public class ClsWarehouseReturnHead : ClsWarehouseReturn
    {
        public int TotalItems;

        public bool SaveWarehouseReturnHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseReturns (WarehouseRef, SupplierRef, Reference, TotalItems, TransactionDate, CreatedBy, CreatedDate) VALUES (@WarehouseRef, @SupplierRef, @Reference, @TotalItems, @TransactionDate, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                            InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            InsertCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                            InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        MessageBox.Show(ex.Message);

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
                SaveToDB = false;
                MessageBox.Show(ex.Message);

                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseReturnHead()
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
                            UpdateCmd.CommandText = "UPDATE tblWarehouseReturns SET ToWarehouseRef = @ToWarehouseRef, WarehouseRef = @WarehouseRef, Reference = @Reference, TotalItems = @TotalItems, TransactionDate = @TransactionDate WHERE ReturnsID = @ReturnsID";
                            UpdateCmd.Parameters.AddWithValue("@ReturnsID", WarehouseReturnID);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@ToWarehouseRef", SupplierRef);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            UpdateCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        UpdateToDB = false;
                        MessageBox.Show(ex.Message);

                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                UpdateToDB = false;
                MessageBox.Show(ex.Message);

                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseReturnHead()
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
                            DeleteCmd.CommandText = "DELETE FROM tblWarehouseReturns WHERE ReturnsID = @ReturnsID";
                            DeleteCmd.Parameters.AddWithValue("@ReturnsID", WarehouseReturnID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        DeleteFromDB = false;
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

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
    public class ClsWarehouseReturnLine : ClsWarehouseReturn
    {
        public int ReturnQty;
        public int ReturnValue;
        public bool SaveWarehouseReturnLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseReturnLines (WarehouseReturnID, StockCode, Qty, Value) VALUES (@WarehouseReturnID, @StockCode, @Qty, @Value)";
                            InsertCmd.Parameters.AddWithValue("@WarehouseReturnID", WarehouseReturnID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@Qty", ReturnQty);
                            InsertCmd.Parameters.AddWithValue("@Value", ReturnValue);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        MessageBox.Show(ex.Message);

                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

                SaveToDB = false;
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseReturnLine()
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
                            UpdateCmd.CommandText = "UPDATE tblWarehouseReturnLines SET Qty = @Qty,Value = @Value WHERE ReturnID = @ReturnID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@ReturnID", WarehouseReturnID);
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@Qty", ReturnQty);
                            UpdateCmd.Parameters.AddWithValue("@Value", ReturnValue);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        UpdateToDB = false;
                        MessageBox.Show(ex.Message);

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
                UpdateToDB = false;
                MessageBox.Show(ex.Message);

                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseReturnLine()
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
                            DeleteCmd.CommandText = "DELETE FROM tblWarehouseReturnLines WHERE ReturnID = @ReturnID;";
                            DeleteCmd.Parameters.AddWithValue("@ReturnID", WarehouseReturnID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        DeleteFromDB = false;
                        MessageBox.Show(ex.Message);

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
                DeleteFromDB = false;
                MessageBox.Show(ex.Message);

                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
    }
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
    }
    public class ClsWarehouseTransferHead : ClsWarehouseTransfer
    {
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
    }
    public class ClsWarehouseTransferLine : ClsWarehouseTransfer
    {
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
