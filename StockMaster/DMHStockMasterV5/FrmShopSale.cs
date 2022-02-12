namespace DMHStockMasterV5
{
    using System;
    using System.Windows.Forms;

    public partial class FrmShopSale : Form
    {
        public string FormMode { get; set; }
        public int UserID { get; set; }
        public DateTime OldDate { get; set; }
        public FrmShopSale()
        {
            InitializeComponent();
        }
    }
}
