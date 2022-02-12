namespace DMHStockMasterV5
{
    using System;
    using System.Windows.Forms;

    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            int TotalUsers,UserID;     // Hold the number of users in the database
            bool PassResult;     // Hold the value of the password checking within the database
            ClsEmployee employee = new ClsEmployee();   // Create an object on the Employee class
            TotalUsers = employee.GetAllUserTotal();
            UserID = employee.GetLoginUserID(TxtUserName.Text.TrimEnd(),TxtPassword.Text.TrimEnd());
            if (TotalUsers > 0 && UserID > 0)
                PassResult = true;
            else if (TotalUsers > 0 || UserID > 0)
                PassResult = false;
            else
                PassResult = false;
            if (!PassResult)
            {
                // when the user hasn't got any credentials to use the system
                if (UserID > 0)
                    Application.Exit();
                else
                {
                    DialogResult dialog = MessageBox.Show("Unknown User and do you wish to add new user?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialog == DialogResult.Yes)
                    {
                        FrmEmployee frmEmployee = new FrmEmployee();
                        frmEmployee.FormMode = "New";
                        frmEmployee.ShowDialog();
                        Application.Exit();     // Reset the application 
                    }
                    else
                    {
                        TxtUserName.Clear();
                        TxtPassword.Clear();
                        TxtUserName.Select();
                    }
                }
            }
            else
            {
                FrmMain main = new FrmMain
                {
                    RefToLoginForm = this,
                    UserID = UserID
                };
                main.Show();
                this.Hide();
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();     // Exit the application
        }
    }
}
