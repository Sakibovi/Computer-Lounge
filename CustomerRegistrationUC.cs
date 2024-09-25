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
    public partial class CustomerRegistrationUC : UserControl
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
        public CustomerRegistrationUC(LoginForm lf)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Lf = lf;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string userID = "U-" + this.AutoId();
            string userName = txtUsername.Text;
            string phone = txtPhone.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

    
            var sql = "select * from UserInfo where username = '" + userName + "';";
            var ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
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
                return ;
            }
            else lblConfirmPasswordError.Visible = false;

            if (string.IsNullOrEmpty(txtConfirmPassword.Text) == true) lblConfirmPasswordError.Visible = true;
            else lblConfirmPasswordError.Visible = false;

            if (txtPhone.Text.Length != 11)
            {
                lblPhoneError.Visible = true;
                MessageBox.Show("Invalid phone number");
                return;
            }
            else lblPhoneError.Visible = false;


            if (lblUsernameError.Visible == true || lblPhoneError.Visible == true || lblPasswordError.Visible == true || lblConfirmPasswordError.Visible == true)  return;

            sql = "insert into UserInfo values ('" + userID + "', '" + userName + "', '" + password + "', '" + phone + "', 'Customer', 'Active');";
            ds = this.Da.ExecuteQuery(sql);
            MessageBox.Show("Account creation successful");
            this.Lf.Show();

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
    }
}
