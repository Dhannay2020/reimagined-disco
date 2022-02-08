namespace DMHStockMasterV5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FrmPurchaseOrder : Form
    {
        public string FormMode { get; set; }
        public int UserID { get; set; }
        public DateTime OldDate { get; set; }
        public FrmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void FrmPurchaseOrder_Load(object sender, EventArgs e)
        {
            GetAllSeasonData();
            LoadWarehousesIntoForm();
            LoadSupplierIntoForm();
            LoadStockIntoForm();
            if (FormMode == "New")
            {
                cmdOK.Text = "Save";
                DteMovementDate.Value = ClsUtils.GetSundayDate(DateTime.Now, 0);
            }
            else
            {
                cmdOK.Text = "OK";
                LoadData();
            }
        }

        private void TxtWarehouseRef_Leave(object sender, EventArgs e)
        {
            TxtWarehouseRef.Text = ClsUtils.ChangeCase(TxtWarehouseRef.Text, 1);
            ClsWarehouse warehouse = new ClsWarehouse()
            {
                WarehouseRef = TxtWarehouseRef.Text
            };
            TxtWarehouseName.Text = warehouse.GetWarehouseNameFromDB();
        }

        private void TxtSupplierRef_Leave(object sender, EventArgs e)
        {
            TxtSupplierRef.Text = ClsUtils.ChangeCase(TxtSupplierRef.Text, 1);
            ClsSupplier supplier = new ClsSupplier()
            {
                SupplierRef = TxtSupplierRef.Text
            };
            TxtSupplierName.Text = supplier.GetSupplierNameFromDB();
        }

        private void TxtNotes_Leave(object sender, EventArgs e)
        {
            TxtNotes.Text = ClsUtils.ChangeCase(TxtNotes.Text, 0);
        }

        private void TxtShipperName_Leave(object sender, EventArgs e)
        {
            TxtShipperName.Text = ClsUtils.ChangeCase(TxtShipperName.Text, 0);
        }

        private void TxtSuppliersInvoiceNumber_Leave(object sender, EventArgs e)
        {

        }

        private void TxtDeliveryCharges_Leave(object sender, EventArgs e)
        {

        }

        private void TxtCommission_Leave(object sender, EventArgs e)
        {

        }

        private void TxtVATAmount_Leave(object sender, EventArgs e)
        {

        }

        private void TxtStockCode_Leave(object sender, EventArgs e)
        {
            TxtStockCode.Text = ClsUtils.ChangeCase(TxtStockCode.Text.TrimEnd(), 1);
            ClsStock stock = new ClsStock
            {
                StockCode = TxtStockCode.Text.TrimEnd()
            };
            if (stock.CheckStockCodeSave() != 0)
            {
                MessageBox.Show("Already StockCode in Database");
            }
            else
            { }
        }

        private void CmdAddToGrid_Click(object sender, EventArgs e)
        {

        }

        private void CmdDeleteFromGrid_Click(object sender, EventArgs e)
        {

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }

        private void TxtOurRef_Leave(object sender, EventArgs e)
        {
            TxtOurRef.Text = ClsUtils.ChangeCase(TxtOurRef.Text, 1);
        }
    }
}
