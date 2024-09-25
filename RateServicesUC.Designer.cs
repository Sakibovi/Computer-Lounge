namespace ComputerLounge___ComputerServiceProvider
{
    partial class RateServicesUC
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
            this.cmbCompany = new MetroFramework.Controls.MetroComboBox();
            this.btnOne = new MetroFramework.Controls.MetroButton();
            this.btnTwo = new MetroFramework.Controls.MetroButton();
            this.btnThree = new MetroFramework.Controls.MetroButton();
            this.btnFour = new MetroFramework.Controls.MetroButton();
            this.btnFive = new MetroFramework.Controls.MetroButton();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.lblCompanyError = new System.Windows.Forms.Label();
            this.lblRatingError = new System.Windows.Forms.Label();
            this.lblSubmitted = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSubmitted);
            this.panel1.Controls.Add(this.lblRatingError);
            this.panel1.Controls.Add(this.lblCompanyError);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnFour);
            this.panel1.Controls.Add(this.btnThree);
            this.panel1.Controls.Add(this.btnTwo);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Controls.Add(this.lblCompany);
            this.panel1.Controls.Add(this.cmbCompany);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 393);
            this.panel1.TabIndex = 0;
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.ItemHeight = 23;
            this.cmbCompany.Location = new System.Drawing.Point(93, 23);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(318, 29);
            this.cmbCompany.TabIndex = 106;
            this.cmbCompany.UseSelectable = true;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Transparent;
            this.btnOne.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOne.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnOne.Location = new System.Drawing.Point(96, 87);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(312, 33);
            this.btnOne.TabIndex = 107;
            this.btnOne.Text = "★";
            this.btnOne.UseCustomBackColor = true;
            this.btnOne.UseCustomForeColor = true;
            this.btnOne.UseSelectable = true;
            this.btnOne.UseStyleColors = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Transparent;
            this.btnTwo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTwo.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnTwo.Location = new System.Drawing.Point(96, 126);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(312, 33);
            this.btnTwo.TabIndex = 108;
            this.btnTwo.Text = "★★";
            this.btnTwo.UseCustomBackColor = true;
            this.btnTwo.UseCustomForeColor = true;
            this.btnTwo.UseSelectable = true;
            this.btnTwo.UseStyleColors = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Transparent;
            this.btnThree.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnThree.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnThree.Location = new System.Drawing.Point(96, 165);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(312, 33);
            this.btnThree.TabIndex = 109;
            this.btnThree.Text = "★★★";
            this.btnThree.UseCustomBackColor = true;
            this.btnThree.UseCustomForeColor = true;
            this.btnThree.UseSelectable = true;
            this.btnThree.UseStyleColors = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Transparent;
            this.btnFour.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnFour.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnFour.Location = new System.Drawing.Point(96, 204);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(312, 33);
            this.btnFour.TabIndex = 110;
            this.btnFour.Text = "★★★★";
            this.btnFour.UseCustomBackColor = true;
            this.btnFour.UseCustomForeColor = true;
            this.btnFour.UseSelectable = true;
            this.btnFour.UseStyleColors = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Transparent;
            this.btnFive.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnFive.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnFive.Location = new System.Drawing.Point(96, 243);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(312, 33);
            this.btnFive.TabIndex = 111;
            this.btnFive.Text = "★★★★★";
            this.btnFive.UseCustomBackColor = true;
            this.btnFive.UseCustomForeColor = true;
            this.btnFive.UseSelectable = true;
            this.btnFive.UseStyleColors = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSubmit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSubmit.Location = new System.Drawing.Point(144, 332);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(216, 39);
            this.btnSubmit.TabIndex = 115;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseCustomBackColor = true;
            this.btnSubmit.UseCustomForeColor = true;
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.UseStyleColors = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCompanyError
            // 
            this.lblCompanyError.AutoSize = true;
            this.lblCompanyError.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyError.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyError.ForeColor = System.Drawing.Color.Red;
            this.lblCompanyError.Location = new System.Drawing.Point(124, 295);
            this.lblCompanyError.Name = "lblCompanyError";
            this.lblCompanyError.Size = new System.Drawing.Size(257, 17);
            this.lblCompanyError.TabIndex = 116;
            this.lblCompanyError.Text = "Select the Company You Want to Rate First";
            this.lblCompanyError.Visible = false;
            // 
            // lblRatingError
            // 
            this.lblRatingError.AutoSize = true;
            this.lblRatingError.BackColor = System.Drawing.Color.Transparent;
            this.lblRatingError.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingError.ForeColor = System.Drawing.Color.Red;
            this.lblRatingError.Location = new System.Drawing.Point(181, 295);
            this.lblRatingError.Name = "lblRatingError";
            this.lblRatingError.Size = new System.Drawing.Size(142, 17);
            this.lblRatingError.TabIndex = 117;
            this.lblRatingError.Text = "Choose an Option First";
            this.lblRatingError.Visible = false;
            // 
            // lblSubmitted
            // 
            this.lblSubmitted.AutoSize = true;
            this.lblSubmitted.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmitted.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitted.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSubmitted.Location = new System.Drawing.Point(168, 295);
            this.lblSubmitted.Name = "lblSubmitted";
            this.lblSubmitted.Size = new System.Drawing.Size(180, 17);
            this.lblSubmitted.TabIndex = 118;
            this.lblSubmitted.Text = "Rating Submitted Successfully";
            this.lblSubmitted.Visible = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(99, 27);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(261, 20);
            this.lblCompany.TabIndex = 105;
            this.lblCompany.Text = "Select the Company You Want to Rate";
            // 
            // RateServicesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "RateServicesUC";
            this.Size = new System.Drawing.Size(505, 393);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox cmbCompany;
        private MetroFramework.Controls.MetroButton btnOne;
        private MetroFramework.Controls.MetroButton btnFive;
        private MetroFramework.Controls.MetroButton btnFour;
        private MetroFramework.Controls.MetroButton btnThree;
        private MetroFramework.Controls.MetroButton btnTwo;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private System.Windows.Forms.Label lblCompanyError;
        private System.Windows.Forms.Label lblRatingError;
        private System.Windows.Forms.Label lblSubmitted;
        private System.Windows.Forms.Label lblCompany;
    }
}
