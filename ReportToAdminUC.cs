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
    public partial class ReportToAdminUC : UserControl
    {
        private DataAccess Da { get; set; }
        public string ID { get; set; }
        private void PopulateCmbCompany(string customerID)
        {
            var sql = "select Distinct(CompanyName) from AppointmentHistory, CompanyInfo where AppointmentHistory.CompanyID = CompanyInfo.CompanyID and AppointmentHistory.UserID = '" + customerID + "';";
            var dt = Da.ExecuteQueryTable(sql);
            int index = 0;

            while (index < dt.Rows.Count)
            {
                this.cmbCompany.Items.Add(dt.Rows[index][0]);
                index++;
            }

            this.cmbCompany.SelectedIndex = -1;

        }
        private string AutoId()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from ComplainInfo order by ComplainID Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");
        }
        public ReportToAdminUC(string customerID)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateCmbCompany(customerID);
            lblCompany.Visible = true;
            this.cmbCompany.SelectedIndex = -1;
            lblError.Visible = false;
            lblSubmitted.Visible = false;
            this.ID = customerID;
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCompany.Visible = false;
            lblError.Visible = false;
            lblSubmitted.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.lblCompany.Visible == true) { 
            
                lblError.Visible = true;
                return;

            }
            else lblError.Visible = false;

            string complainID = "C-" + this.AutoId();
            string userID = this.ID;

            var dt = Da.ExecuteQueryTable(@"Select * from CompanyInfo where CompanyName = '" + this.cmbCompany.Text + "';");
            string companyID = dt.Rows[0][0].ToString();

            string complain = this.txtComplain.Text;

            var sql = "insert into ComplainInfo values ('" + complainID + "', '" + userID + "', '" + companyID + "', '" + complain + "');";
            var ds = this.Da.ExecuteQuery(sql);

            this.txtComplain.Clear();
            this.lblSubmitted.Visible = true;

        }
    }
}
