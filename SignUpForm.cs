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
    public partial class SignUpForm : Form
    {
        public LoginForm Lf { get; set; }

        public SignUpForm(LoginForm lf)
        {
            InitializeComponent();
            this.Lf = lf;
            CustomerRegistrationUC customerRegistrationUC = new CustomerRegistrationUC(this.Lf);
            this.AddUserControl(customerRegistrationUC);
        }
        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void metroPanel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroPanel1_Click(object sender, EventArgs e)
        {
            this.Lf.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerRegistrationUC customerRegistrationUC = new CustomerRegistrationUC(this.Lf);
            this.AddUserControl(customerRegistrationUC);
        }

        private void btnServiceProvider_Click(object sender, EventArgs e)
        {
            ServiceProviderRegistrationUC serviceProviderRegistrationUC = new ServiceProviderRegistrationUC(this.Lf);
            this.AddUserControl(serviceProviderRegistrationUC);
        }
    }
}
