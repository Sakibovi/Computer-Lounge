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
    public partial class LoginForm : Form
    {

        private DataAccess Da { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void metroPanel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new SignUpForm(this).Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var sql = "select * from UserInfo where Username = '" + this.txtUsername.Text + "' and Password = '" + this.txtPassword.Text + "';";
            var ds = this.Da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                if (ds.Tables[0].Rows[0][4].ToString() == "Admin" && ds.Tables[0].Rows[0][5].ToString() == "Active")
                {

                    new AdminHomeForm(this.txtUsername.Text, this).Show();
                    this.lblInactiveAccount.Visible = false;
                    this.lblInvalidLogin.Visible = false;
                    this.Hide();

                }
                else if (ds.Tables[0].Rows[0][4].ToString() == "Customer" && ds.Tables[0].Rows[0][5].ToString() == "Active")
                {

                    new CustomerHomeForm(this.txtUsername.Text, this).Show();
                    this.lblInactiveAccount.Visible = false;
                    this.lblInvalidLogin.Visible = false;
                    this.Hide();

                }
                else if (ds.Tables[0].Rows[0][4].ToString() == "Service Provider" && ds.Tables[0].Rows[0][5].ToString() == "Active")
                {

                    new ServiceProviderHomeForm(this.txtUsername.Text, this).Show();
                    this.lblInactiveAccount.Visible = false;
                    this.lblInvalidLogin.Visible = false;
                    this.Hide();

                }
                else { 
                    lblInactiveAccount.Visible = true;
                }
            }
            else
            {
                lblInvalidLogin.Visible = true;
            }
        }
    }
}
