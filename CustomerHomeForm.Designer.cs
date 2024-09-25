namespace ComputerLounge___ComputerServiceProvider
{
    partial class CustomerHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRateServices = new MetroFramework.Controls.MetroButton();
            this.btnReportToAdmin = new MetroFramework.Controls.MetroButton();
            this.btnAppointmentHistory = new MetroFramework.Controls.MetroButton();
            this.lblService = new System.Windows.Forms.Label();
            this.cmbService = new MetroFramework.Controls.MetroComboBox();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.metroPanel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 487);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 142);
            this.panel2.TabIndex = 19;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(18, 103);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 21);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(15, 7);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 40);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnRateServices);
            this.panel5.Controls.Add(this.btnReportToAdmin);
            this.panel5.Controls.Add(this.btnAppointmentHistory);
            this.panel5.Controls.Add(this.lblService);
            this.panel5.Controls.Add(this.cmbService);
            this.panel5.Controls.Add(this.btnLogout);
            this.panel5.Location = new System.Drawing.Point(12, 174);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 301);
            this.panel5.TabIndex = 20;
            // 
            // btnRateServices
            // 
            this.btnRateServices.BackColor = System.Drawing.Color.White;
            this.btnRateServices.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRateServices.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRateServices.Location = new System.Drawing.Point(22, 131);
            this.btnRateServices.Name = "btnRateServices";
            this.btnRateServices.Size = new System.Drawing.Size(227, 39);
            this.btnRateServices.TabIndex = 105;
            this.btnRateServices.Text = "Rate Services";
            this.btnRateServices.UseCustomBackColor = true;
            this.btnRateServices.UseCustomForeColor = true;
            this.btnRateServices.UseSelectable = true;
            this.btnRateServices.UseStyleColors = true;
            this.btnRateServices.Click += new System.EventHandler(this.btnRateServices_Click);
            // 
            // btnReportToAdmin
            // 
            this.btnReportToAdmin.BackColor = System.Drawing.Color.White;
            this.btnReportToAdmin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnReportToAdmin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnReportToAdmin.Location = new System.Drawing.Point(22, 185);
            this.btnReportToAdmin.Name = "btnReportToAdmin";
            this.btnReportToAdmin.Size = new System.Drawing.Size(227, 39);
            this.btnReportToAdmin.TabIndex = 104;
            this.btnReportToAdmin.Text = "Report to Admin";
            this.btnReportToAdmin.UseCustomBackColor = true;
            this.btnReportToAdmin.UseCustomForeColor = true;
            this.btnReportToAdmin.UseSelectable = true;
            this.btnReportToAdmin.UseStyleColors = true;
            this.btnReportToAdmin.Click += new System.EventHandler(this.btnReportToAdmin_Click);
            // 
            // btnAppointmentHistory
            // 
            this.btnAppointmentHistory.BackColor = System.Drawing.Color.White;
            this.btnAppointmentHistory.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAppointmentHistory.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAppointmentHistory.Location = new System.Drawing.Point(22, 77);
            this.btnAppointmentHistory.Name = "btnAppointmentHistory";
            this.btnAppointmentHistory.Size = new System.Drawing.Size(227, 39);
            this.btnAppointmentHistory.TabIndex = 103;
            this.btnAppointmentHistory.Text = "Appointment History";
            this.btnAppointmentHistory.UseCustomBackColor = true;
            this.btnAppointmentHistory.UseCustomForeColor = true;
            this.btnAppointmentHistory.UseSelectable = true;
            this.btnAppointmentHistory.UseStyleColors = true;
            this.btnAppointmentHistory.Click += new System.EventHandler(this.btnAppointmentHistory_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(28, 32);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(189, 20);
            this.lblService.TabIndex = 3;
            this.lblService.Text = "Select Your Desired Service";
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.ItemHeight = 23;
            this.cmbService.Location = new System.Drawing.Point(22, 27);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(227, 29);
            this.cmbService.TabIndex = 102;
            this.cmbService.UseSelectable = true;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            this.cmbService.SelectionChangeCommitted += new System.EventHandler(this.cmbService_SelectionChangeCommitted);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogout.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogout.Location = new System.Drawing.Point(22, 237);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(227, 39);
            this.btnLogout.TabIndex = 101;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseCustomBackColor = true;
            this.btnLogout.UseCustomForeColor = true;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.UseStyleColors = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(307, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 393);
            this.panel4.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(307, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 53);
            this.panel3.TabIndex = 21;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel3.BackgroundImage")));
            this.metroPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(772, 12);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(40, 40);
            this.metroPanel3.TabIndex = 22;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            this.metroPanel3.Click += new System.EventHandler(this.metroPanel3_Click);
            // 
            // CustomerHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerHomeForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroButton btnLogout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroComboBox cmbService;
        private System.Windows.Forms.Label lblService;
        private MetroFramework.Controls.MetroButton btnAppointmentHistory;
        private MetroFramework.Controls.MetroButton btnRateServices;
        private MetroFramework.Controls.MetroButton btnReportToAdmin;
    }
}