namespace ComputerLounge___ComputerServiceProvider
{
    partial class ReportToAdminUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubmitted = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.txtComplain = new MetroFramework.Controls.MetroTextBox();
            this.cmbCompany = new MetroFramework.Controls.MetroComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSubmitted);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtComplain);
            this.panel1.Controls.Add(this.lblCompany);
            this.panel1.Controls.Add(this.cmbCompany);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 393);
            this.panel1.TabIndex = 0;
            // 
            // lblSubmitted
            // 
            this.lblSubmitted.AutoSize = true;
            this.lblSubmitted.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmitted.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitted.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSubmitted.Location = new System.Drawing.Point(168, 286);
            this.lblSubmitted.Name = "lblSubmitted";
            this.lblSubmitted.Size = new System.Drawing.Size(168, 17);
            this.lblSubmitted.TabIndex = 116;
            this.lblSubmitted.Text = "Report Submitted to Admin";
            this.lblSubmitted.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(117, 286);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(271, 17);
            this.lblError.TabIndex = 115;
            this.lblError.Text = "Select the Company You Want to Report First";
            this.lblError.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSubmit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSubmit.Location = new System.Drawing.Point(144, 332);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(216, 39);
            this.btnSubmit.TabIndex = 114;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseCustomBackColor = true;
            this.btnSubmit.UseCustomForeColor = true;
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.UseStyleColors = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtComplain
            // 
            // 
            // 
            // 
            this.txtComplain.CustomButton.Image = null;
            this.txtComplain.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtComplain.CustomButton.Name = "";
            this.txtComplain.CustomButton.Size = new System.Drawing.Size(165, 165);
            this.txtComplain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComplain.CustomButton.TabIndex = 1;
            this.txtComplain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComplain.CustomButton.UseSelectable = true;
            this.txtComplain.CustomButton.Visible = false;
            this.txtComplain.Lines = new string[0];
            this.txtComplain.Location = new System.Drawing.Point(45, 95);
            this.txtComplain.MaxLength = 32767;
            this.txtComplain.Multiline = true;
            this.txtComplain.Name = "txtComplain";
            this.txtComplain.PasswordChar = '\0';
            this.txtComplain.PromptText = "Type Here...";
            this.txtComplain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComplain.SelectedText = "";
            this.txtComplain.SelectionLength = 0;
            this.txtComplain.SelectionStart = 0;
            this.txtComplain.ShortcutsEnabled = true;
            this.txtComplain.Size = new System.Drawing.Size(414, 167);
            this.txtComplain.Style = MetroFramework.MetroColorStyle.Black;
            this.txtComplain.TabIndex = 105;
            this.txtComplain.UseSelectable = true;
            this.txtComplain.WaterMark = "Type Here...";
            this.txtComplain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComplain.WaterMarkFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.ItemHeight = 23;
            this.cmbCompany.Location = new System.Drawing.Point(93, 23);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(318, 29);
            this.cmbCompany.TabIndex = 104;
            this.cmbCompany.UseSelectable = true;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(99, 27);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(276, 20);
            this.lblCompany.TabIndex = 103;
            this.lblCompany.Text = "Select the Company You Want to Report";
            // 
            // ReportToAdminUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ReportToAdminUC";
            this.Size = new System.Drawing.Size(505, 393);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox cmbCompany;
        private MetroFramework.Controls.MetroTextBox txtComplain;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblSubmitted;
        private System.Windows.Forms.Label lblCompany;
    }
}
