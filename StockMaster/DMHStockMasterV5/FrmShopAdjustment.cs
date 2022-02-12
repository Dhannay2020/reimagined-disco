namespace DMHStockMasterV5
{
    using System;
    using System.Windows.Forms;

    public partial class FrmShopAdjustment : Form
    {
        public string FormMode { get; set; }
        public int UserID { get; set; }
        public DateTime OldDate { get; set; }
        public FrmShopAdjustment()
        {
            InitializeComponent();
        }
    }
}
