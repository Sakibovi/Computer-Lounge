using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerLounge___ComputerServiceProvider
{
    public partial class AdminHomeForm : Form
    {

        public LoginForm Lf { get; set; }
        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();

        }
        public AdminHomeForm(string username, LoginForm lf)
        {
            InitializeComponent();
            this.Lf = lf;
            this.lblUsername.Text = username;
            this.lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            ApproveServiceProviderUC approveServiceProviderUC = new ApproveServiceProviderUC();
            this.AddUserControl(approveServiceProviderUC);
        }

        private void metroPanel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Lf.Show();
            this.Close();
        }

        private void btnApprovalList_Click(object sender, EventArgs e)
        {
            ApproveServiceProviderUC approveServiceProviderUC = new ApproveServiceProviderUC();
            this.AddUserControl(approveServiceProviderUC);
        }

        private void btnComplains_Click(object sender, EventArgs e)
        {
            CustomerComplainUC customerComplainUC = new CustomerComplainUC();
            this.AddUserControl(customerComplainUC);
        }
    }
}
