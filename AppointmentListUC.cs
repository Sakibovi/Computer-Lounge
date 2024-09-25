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
    public partial class AppointmentListUC : UserControl
    {
        private DataAccess Da { get; set; }
        public string ID { get; set; }
        private string AutoId()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from AppointmentHistory order by AppointmentHistoryID Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");
        }
        private void PopulateGridView(string companyID)
        {
            string sql = "select * from AppointmentForm where CompanyID = '" + companyID + "' and Status = 'Pending'";
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvAppointmentList.AutoGenerateColumns = false;
            this.dgvAppointmentList.DataSource = ds.Tables[0];
        }
        public AppointmentListUC(string companyID)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ID = companyID;
            this.PopulateGridView(ID);
        }

        private void dgvAppointmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAppointmentList.Columns[e.ColumnIndex].Name.Equals("Approval"))
            {
                string appointmentHistoryID = "A-" + this.AutoId();
                var sql = "update AppointmentForm set Status = 'Approved' where FormID  = '" + this.dgvAppointmentList.CurrentRow.Cells["FormID"].Value.ToString() + "';";
                this.Da.ExecuteDMLQuery(sql);
                sql = "insert into AppointmentHistory values ('" + appointmentHistoryID + "', '" + this.dgvAppointmentList.CurrentRow.Cells["UserID"].Value.ToString() + "', '" + this.dgvAppointmentList.CurrentRow.Cells["CompanyID"].Value.ToString() + "', '" + this.dgvAppointmentList.CurrentRow.Cells["AppointmentDate"].Value.ToString() + "');";
                this.Da.ExecuteDMLQuery(sql);
                MessageBox.Show("Appointment Request Approved");
                this.PopulateGridView(ID);
            }
        }
    }
}
