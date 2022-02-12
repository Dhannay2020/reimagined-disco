namespace DMHStockMasterV5
{
    using System;
    using System.Windows.Forms;

    public partial class FrmEmployee : Form
    {
        public string FormMode { get; set; }
        public int UserID { get; set; }
       
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            // New form = Saving to the database
            // Old form = Updating to the database
            if (FormMode == "New")
            {
                // changing the text of CmdOK to reflect the saving to the database
                CmdOK.Text = "Save";
            }
            else
            {
                // changing the text of CmdOK to reflect the updating to the database and loading the current selected form.
                CmdOK.Text = "OK";
                LoadData();
            }
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            ClsEmployee clsEmployee = new ClsEmployee
            {
                PasswordEntered = TxtPassword.Text.TrimEnd(),
                LoginCode = TxtLoginCode.Text.TrimEnd(),
                FirstName = TxtFirstName.Text.TrimEnd(),
                LastName = TxtLastName.Text.TrimEnd(),
                ProfileID = CboProfiles.SelectedIndex
            };
            if (FormMode == "New")
            {
                // Saving the form to the database
                clsEmployee.SaveToEmployeeTable();
            }
            else
            {
                // Update the Employee table in the database
                clsEmployee.UpdateToEmployeeTable();
            }
            this.Close();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // closing the form as requested.
        }
        private void LoadData()
        {

        }
    }
}
