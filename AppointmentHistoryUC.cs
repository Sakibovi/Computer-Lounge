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
    public partial class AppointmentHistoryUC : UserControl
    {
        private DataAccess Da { get; set; }
        public AppointmentHistoryUC(string userID)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView(userID);
        }
        private void PopulateGridView(string userID)
        {
            string sql = "select * from AppointmentHistory, CompanyInfo, ServiceInfo where AppointmentHistory.CompanyID = CompanyInfo.CompanyID and CompanyInfo.ServiceID = ServiceInfo.ServiceID and AppointmentHistory.UserID = '" + userID + "';";
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvAppointmentHistory.AutoGenerateColumns = false;
            this.dgvAppointmentHistory.DataSource = ds.Tables[0];
        }
    }
}
