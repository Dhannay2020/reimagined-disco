﻿namespace DMHStockMasterV5
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

    public partial class FrmAccessLevel : Form
    {
        public string FormMode { get; set; }
        public int UserID { get; set; }
        public DateTime OldDate { get; set; }
        public FrmAccessLevel()
        {
            InitializeComponent();
        }
    }
}