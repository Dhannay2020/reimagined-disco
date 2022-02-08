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

    public partial class FrmMain : Form
    {
        public Form RefToLoginForm { get; set; }
        public int UserID { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Warehouses records from the database
            // Function 1
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 1,
                Text = "Warehouses",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Supplier records from the database
            // Function 2
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 2,
                Text = "Suppliers",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void shopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Shop records from the database
            // Function 3
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 3,
                Text = "Shops",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void currentStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Current Stock records from the database
            // Function 4
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 4,
                Text = "Current Stock",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void allStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load All Stock records from the database
            // Function 5
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 5,
                Text = "All Stock",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void seasonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Season records from the database
            // Function 6
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 6,
                Text = "Seasons",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void purchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Purchase Order records from the database
            // Function 7
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 7,
                Text = "Purchase Orders",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void warehouseAdjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Warehouse Adjustment records from the database
            // Function 8
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 8,
                Text = "Warehouse Adjustments",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void warehouseTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Warehouse Transfer records from the database
            // Function 9
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 9,
                Text = "Warehouse Transfers",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void warehouseReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Warehouse Return records from the database
            // Function 10
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 10,
                Text = "Warehouse Returns",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void warehouseLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Warehouse Locations records from the database
            // Function 11
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 11,
                Text = "Warehouse Locations",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void warehouseOrderPickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Warehouse Order Picking records from the database
            // Function 12
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 12,
                Text = "Warehouse Order Picking",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void warehouseStockTakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Warehouse Return records from the database
            // Function 13
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 13,
                Text = "Warehouse Stock Take",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void shopDeliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Shop Delivery records from the database
            // Old Function 11 
            // New Function 14
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 14,
                Text = "Shop Delivery",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void shopAdjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Shop Adjustment records from the database
            // Old Function 12
            // New Function 15
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 15,
                Text = "Shop Adjustments",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void shopTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Shop Transfer records from the database
            // Old Function 13
            // New Function 16
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 16,
                Text = "Shop Transfers",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void shopSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Shop Sales records from the database
            // Old Function 14
            // New Function 17
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 17,
                Text = "Shop Sales",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void shopRefundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Shop Refunds records from the database
            // Function 18
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 18,
                Text = "Shop Refunds",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void shopReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Shop Return records from the database
            // Old Function 15
            // New Function 19
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 19,
                Text = "Shop Return",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void shopLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Shop Locations records from the database
            // Function 20
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 20,
                Text = "Shop Locations",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void shopStockTakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Shop Stock Take records from the database
            // Function 21
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 21,
                Text = "Shop Stock Take",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void totalValuationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Total Value records from the database
            // Old Function 16
            // New Function 22
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 22,
                Text = "Company Valuation",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void reportsSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportCriteria objReportCriteria = new FrmReportCriteria();
            objReportCriteria.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsSettings objSettings = new ClsSettings();
            objSettings.LoadSettings();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Employees records from the database
            // Function 23
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 23,
                Text = "Employees",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Employee Profile records from the database
            // Function 24
            FrmDataGrid objGrid = new FrmDataGrid
            {
                FunctionID = 24,
                Text = "Profile",
                UserID = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            }; // setup the form ready for the function
            objGrid.Show(); // Show the form
            splitContainer1.Panel2.Controls.Add(objGrid); // add the form to the area required
            objGrid.BringToFront(); // put the selected form topmost.
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword objChangePassword = new FrmChangePassword
            {
                UserID = UserID
            };
            objChangePassword.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int NumberOfWindows = 0;
           // NumberOfWindows = splitContainer1.Panel2.Controls.Count;
           // for (int i = 0; i > NumberOfWindows; i--)
//splitContainer1.Panel2.Controls.RemoveAt(i);
               // 
            //foreach(Form frm in splitContainer1.Panel2.Controls)
            //{
            //    frm.Dispose();
            //    frm.Close();
            //}
           
            RefToLoginForm.ShowDialog();
            this.Close();
            MessageBox.Show("Completed!!!!!");
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Quits the application cleanly
        }
    }
}
