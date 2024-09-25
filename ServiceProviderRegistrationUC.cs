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
    public partial class ServiceProviderRegistrationUC : UserControl
    {
        private DataAccess Da { get; set; }
        private LoginForm Lf { get; set; }
        private string AutoId()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from UserInfo order by UserID Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");
        }
        private string CompanyAutoId()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from CompanyInfo order by CompanyID Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");
        }
        private void PopulateCmbService()
        {
            var sql = "select * from ServiceInfo;";
            var dt = Da.ExecuteQueryTable(sql);
            int index = 0;

            while (index < dt.Rows.Count)
            {
                this.cmbService.Items.Add(dt.Rows[index][0] + " " + dt.Rows[index][1]);
                index++;
            }

            this.cmbService.SelectedIndex = -1;

        }
        public ServiceProviderRegistrationUC(LoginForm lf)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateCmbService();
            this.Lf = lf;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblUsernameError.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasswordError.Visible = false;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            lblConfirmPasswordError.Visible = false;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            lblPhoneError.Visible = false;
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            lblCompanyError.Visible = false;
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblServiceError.Visible = false;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string userID = "U-" + this.AutoId();
            string userName = txtUsername.Text;
            string phone = txtPhone.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string companyID = "C-" + this.CompanyAutoId();
            string companyName = txtCompanyName.Text;
            string service = cmbService.Text;
            string[] serviceArr = service.Split(' ');
            string serviceID = serviceArr[0];
            string costRange = txtStartingRange.Text + '-' + txtEndingRange.Text;


            var sql = "select * from UserInfo where username = '" + userName + "';";
            var ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count >= 1)
            {
                lblUsernameError.Visible = true;
                MessageBox.Show("Username already exists");
                return;
            }
            else lblUsernameError.Visible = false;

            if (string.IsNullOrEmpty(txtUsername.Text) == true) lblUsernameError.Visible = true;
            else lblUsernameError.Visible = false;



            if (txtPassword.Text.Length < 4)
            {
                lblPasswordError.Visible = true;
                MessageBox.Show("Password must be atleast 4 characters");
                return;
            }
            else lblPasswordError.Visible = false;


            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblConfirmPasswordError.Visible = true;
                MessageBox.Show("Passwords do not match");
                return;
            }
            else lblConfirmPasswordError.Visible = false;

            if (string.IsNullOrEmpty(txtConfirmPassword.Text) == true) lblConfirmPasswordError.Visible = true;
            else lblConfirmPasswordError.Visible = false;

            if (txtPhone.Text.Length != 11)
            {
                lblPhoneError.Visible = true;
                MessageBox.Show("Invalid phone number");
                return ;
            }
            else lblPhoneError.Visible = false;


            sql = "select * from CompanyInfo where CompanyName = '" + companyName + "';";
            ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                lblCompanyError.Visible = true;
                MessageBox.Show("Company already exists");
                return;
            }
            else lblCompanyError.Visible = false;

            if (string.IsNullOrEmpty(txtCompanyName.Text) == true) lblCompanyError.Visible = true;
            else lblCompanyError.Visible = false;

            if (cmbService.SelectedIndex == -1) lblServiceError.Visible = true;
            else lblServiceError.Visible = false;



            if (lblUsernameError.Visible == true || lblPhoneError.Visible == true || lblPasswordError.Visible == true || lblConfirmPasswordError.Visible == true || lblCompanyError.Visible == true || lblServiceError.Visible == true) return;

            sql = "insert into UserInfo values ('" + userID + "', '" + userName + "', '" + password + "', '" + phone + "', 'Service Provider', 'Pending');";
            ds = this.Da.ExecuteQuery(sql);
            sql = "insert into CompanyInfo values ('" + companyID + "', '" + userID + "', '" + companyName + "', 0, '" + serviceID + "', '" + costRange + "', 0);";
            ds = this.Da.ExecuteQuery(sql);
            MessageBox.Show("Account creation successful");
            this.Lf.Show();
        }

        private void txtStartingRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEndingRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
