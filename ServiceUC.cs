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
    public partial class ServiceUC : UserControl
    {
        private DataAccess Da { get; set; }
        private CustomerHomeForm CustomerHomeForm { get; set; }
        public string Username { get; set; }
        private void PopulateGridView(string service)
        {
            string sql = "select * from CompanyInfo, ServiceInfo, UserInfo where ServiceInfo.ServiceID = CompanyInfo.ServiceID and UserInfo.UserID = CompanyInfo.UserID and Service = '" + service + "' and Status = 'Active'";
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvService.AutoGenerateColumns = false;
            this.dgvService.DataSource = ds.Tables[0];
        }
        public ServiceUC(string service, string username, CustomerHomeForm customerHomeForm)
        {
            InitializeComponent();
            this.Username = username;
            this.CustomerHomeForm = customerHomeForm;
            this.Da = new DataAccess();
            this.PopulateGridView(service);
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvService.Columns[e.ColumnIndex].Name.Equals("AppointmentForm"))
            {
                new AppointmentForm(this.Username, this.CustomerHomeForm, this.dgvService.CurrentRow.Cells["CompanyName"].Value.ToString()).ShowDialog();
                this.Hide();
            }
        }
    }
}
