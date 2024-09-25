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
    public partial class CustomerComplainUC : UserControl
    {
        private DataAccess Da { get; set; }
        private void PopulateGridView()
        {
            string sql = "select * from ComplainInfo, CompanyInfo, UserInfo where ComplainInfo.UserID = UserInfo.UserID and ComplainInfo.CompanyID = CompanyInfo.CompanyID;";
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvComplain.AutoGenerateColumns = false;
            this.dgvComplain.DataSource = ds.Tables[0];
        }
        public CustomerComplainUC()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
        }

        private void dgvComplain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvComplain.SelectedRows.Count == 0) return;
            this.txtComplain.Text = this.dgvComplain.CurrentRow.Cells["Complain"].Value.ToString();
        }
    }
}
