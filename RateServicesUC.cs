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
    public partial class RateServicesUC : UserControl
    {
        private DataAccess Da { get; set; }
        public string ID { get; set; }
        public int Rating { get; set; }
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
        public RateServicesUC(string customerID)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateCmbCompany(customerID);
            lblCompany.Visible = true;
            this.cmbCompany.SelectedIndex = -1;
            this.ID = customerID;
            lblRatingError.Visible = false;
            lblCompanyError.Visible = false;
            lblSubmitted.Visible = false;
            this.Rating = 0;
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRatingError.Visible = false;
            lblCompanyError.Visible = false;
            lblSubmitted.Visible = false;
            lblCompany.Visible = false;
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.cmbCompany.SelectedIndex == -1)
            {

                lblCompanyError.Visible = true;
                return;

            }
            else lblCompanyError.Visible = false;

            if (this.Rating == 0)
            {

                lblRatingError.Visible = true;
                return;

            }
            else lblRatingError.Visible = false;

            string company = this.cmbCompany.Text;

            var dt = Da.ExecuteQueryTable(@"Select Rating, RatingCount from CompanyInfo where CompanyName = '" + company + "';");
            string ratingS = dt.Rows[0][0].ToString();
            string ratingCountS = dt.Rows[0][1].ToString();

            int rating = Convert.ToInt32(ratingS);
            int ratingCount = Convert.ToInt32(ratingCountS);

            ratingCount += 1;
            rating += this.Rating;

            int newRating = rating / ratingCount;


            var sql = "update CompanyInfo set Rating = " + newRating + ", RatingCount = " + ratingCount + " where CompanyName  = '" + company + "';";
            this.Da.ExecuteDMLQuery(sql);

            this.lblSubmitted.Visible = true;
            this.lblCompany.Visible = true;
            this.Rating = 0;

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.Rating = 1;
            lblRatingError.Visible = false;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.Rating = 2;
            lblRatingError.Visible = false;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.Rating = 3;
            lblRatingError.Visible = false;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.Rating = 4;
            lblRatingError.Visible = false;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.Rating = 5;
            lblRatingError.Visible = false;
        }
    }
}
