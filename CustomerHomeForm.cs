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
    public partial class CustomerHomeForm : Form
    {
        public LoginForm Lf { get; set; }
        public string Username { get; set; }
        public string ID { get; set; }
        private DataAccess Da { get; set; }
        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void PopulateCmbService()
        {
            var sql = "select * from ServiceInfo;";
            var dt = Da.ExecuteQueryTable(sql);
            int index = 0;

            while (index < dt.Rows.Count)
            {
                this.cmbService.Items.Add(dt.Rows[index][1]);
                index++;
            }

            this.cmbService.SelectedIndex = -1;

        }
        public CustomerHomeForm(string username, LoginForm lf)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Lf = lf;
            this.lblUsername.Text = username;
            this.Username = username;
            this.lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            this.PopulateCmbService();
            this.lblService.Visible = true;
            var dt = Da.ExecuteQueryTable(@"Select * from UserInfo where Username = '" + username + "';");
            this.ID = dt.Rows[0][0].ToString();
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

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblService.Visible = false;
        }

        private void cmbService_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ServiceUC serviceUC = new ServiceUC(cmbService.GetItemText(cmbService.SelectedItem), this.Username, this);
            this.AddUserControl(serviceUC);
        }

        private void btnAppointmentHistory_Click(object sender, EventArgs e)
        {
            AppointmentHistoryUC appointmentHistoryUC = new AppointmentHistoryUC(this.ID);
            this.AddUserControl(appointmentHistoryUC);
        }

        private void btnReportToAdmin_Click(object sender, EventArgs e)
        {
            ReportToAdminUC reportToAdminUC = new ReportToAdminUC(this.ID);
            this.AddUserControl(reportToAdminUC);
        }

        private void btnRateServices_Click(object sender, EventArgs e)
        {
            RateServicesUC rateServicesUC = new RateServicesUC(this.ID);
            this.AddUserControl(rateServicesUC);
        }
    }
}
