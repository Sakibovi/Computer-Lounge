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
    public partial class ServiceProviderHomeForm : Form
    {
        public LoginForm Lf { get; set; }
        public string CompanyID { get; set; }
        private DataAccess Da { get; set; }
        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();

        }
        public ServiceProviderHomeForm(string username, LoginForm lf)
        {
            InitializeComponent();
            this.Lf = lf;
            this.lblUsername.Text = username;
            this.lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            this.Da = new DataAccess();
            var dt = Da.ExecuteQueryTable(@"Select * from UserInfo where Username = '" + username + "';");
            string userID = dt.Rows[0][0].ToString();
            dt = Da.ExecuteQueryTable(@"Select * from CompanyInfo where UserID = '" + userID + "';");
            this.CompanyID = dt.Rows[0][0].ToString();
            AppointmentListUC appointmentListUC = new AppointmentListUC(CompanyID);
            this.AddUserControl(appointmentListUC);
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

        private void btnAppointmentList_Click(object sender, EventArgs e)
        {
            AppointmentListUC appointmentListUC = new AppointmentListUC(CompanyID);
            this.AddUserControl(appointmentListUC);
        }

        private void btnAppointmentHistory_Click(object sender, EventArgs e)
        {
            ServiceProviderAppointmentHistoryUC serviceProviderAppointmentHistoryUC = new ServiceProviderAppointmentHistoryUC(this.CompanyID);
            this.AddUserControl(serviceProviderAppointmentHistoryUC);
        }
    }
}
