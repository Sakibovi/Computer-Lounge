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
    public partial class ServiceProviderAppointmentHistoryUC : UserControl
    {
        private DataAccess Da { get; set; }
        private void PopulateGridView(string companyID)
        {
            string sql = "select * from AppointmentHistory, UserInfo where AppointmentHistory.UserID = UserInfo.UserID and AppointmentHistory.CompanyID = '" + companyID + "';";
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvAppointmentHistory.AutoGenerateColumns = false;
            this.dgvAppointmentHistory.DataSource = ds.Tables[0];
        }
        public ServiceProviderAppointmentHistoryUC(string companyID)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView(companyID);
        }
    }
}
