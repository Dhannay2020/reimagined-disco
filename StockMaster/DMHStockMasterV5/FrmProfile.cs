namespace DMHStockMasterV5
{
    using System.Windows.Forms;

    public partial class FrmProfile : Form
    {
        public string FormMode { get; set; }
        public int UserID { get; set; }
       
        public FrmProfile()
        {
            InitializeComponent();
        }
    }
}
