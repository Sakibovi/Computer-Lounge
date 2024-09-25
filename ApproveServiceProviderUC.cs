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
    public partial class ApproveServiceProviderUC : UserControl
    {
        private DataAccess Da { get; set; }
        private void PopulateGridView(string sql = "select * from UserInfo, CompanyInfo, ServiceInfo where UserInfo.UserID = CompanyInfo.UserID and CompanyInfo.ServiceID = ServiceInfo.ServiceID and Status = 'Pending';")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvPendingServiceProvider.AutoGenerateColumns = false;
            this.dgvPendingServiceProvider.DataSource = ds.Tables[0];
        }
        public ApproveServiceProviderUC()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
        }

        private void dgvPendingServiceProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPendingServiceProvider.Columns[e.ColumnIndex].Name.Equals("Approval"))
            {
                var sql = "update UserInfo set Status = 'Active' where UserID  = '" + this.dgvPendingServiceProvider.CurrentRow.Cells["UserID"].Value.ToString() + "';";
                this.Da.ExecuteDMLQuery(sql);
                this.PopulateGridView();
            }
        }
    }
}
