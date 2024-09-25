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
    public partial class AppointmentForm : Form
    {

        private CustomerHomeForm CustomerHomeForm { get; set; }
        private DataAccess Da { get; set; }
        private string Username { get; set; }
        private string CompanyName { get; set; }
        private string AutoId()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from AppointmentForm order by FormID Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");
        }
        public AppointmentForm(string username, CustomerHomeForm customerHomeForm, string companyName)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.lblUsername.Text = username;
            this.Username = username;
            this.lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            this.CustomerHomeForm = customerHomeForm;
            this.txtCompanyName.Text = companyName;
            this.CompanyName = companyName;
        }

        private void metroPanel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroPanel1_Click(object sender, EventArgs e)
        {
            this.CustomerHomeForm.Show();
            this.Close();
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblPaymentMethod.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var dt = Da.ExecuteQueryTable(@"Select * from UserInfo where Username = '" + this.Username + "';");
            string userID = dt.Rows[0][0].ToString();
            string customerName = dt.Rows[0][1].ToString();
            string password = dt.Rows[0][2].ToString();
            dt = Da.ExecuteQueryTable(@"Select * from CompanyInfo where CompanyName = '" + this.CompanyName + "';");
            string companyID = dt.Rows[0][0].ToString();
            string address = this.txtAddress.Text;
            string appointmentDate = this.dtpAppointmentDate.Text;
            string confirmPassword = this.txtPassword.Text;
            string paymentMethod = this.cmbPaymentMethod.Text;
            string formID = "F-" + this.AutoId();


            if (password != confirmPassword)
            {
                lblPasswordError.Visible = true;
                MessageBox.Show("Incorrect Password.");
                return;
            }
            else lblPasswordError.Visible = false;

            var sql = "insert into AppointmentForm values ('" + formID + "', '" + userID + "', '" + companyID + "', '" + customerName + "', '" + address + "', '" + appointmentDate + "', 'Pending',  '" + paymentMethod + "');";
            var ds = this.Da.ExecuteQuery(sql);
            MessageBox.Show("Appointment Form Submitted.");
            this.CustomerHomeForm.Show();
            this.Close();
        }
    }
}
