namespace ComputerLounge___ComputerServiceProvider
{
    partial class CustomerComplainUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvComplain = new MetroFramework.Controls.MetroGrid();
            this.txtComplain = new MetroFramework.Controls.MetroTextBox();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtComplain);
            this.panel1.Controls.Add(this.dgvComplain);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 393);
            this.panel1.TabIndex = 0;
            // 
            // dgvComplain
            // 
            this.dgvComplain.AllowUserToAddRows = false;
            this.dgvComplain.AllowUserToDeleteRows = false;
            this.dgvComplain.AllowUserToResizeColumns = false;
            this.dgvComplain.AllowUserToResizeRows = false;
            this.dgvComplain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvComplain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvComplain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComplain.ColumnHeadersHeight = 30;
            this.dgvComplain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Complain,
            this.ComplainID,
            this.CompanyName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComplain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComplain.EnableHeadersVisualStyles = false;
            this.dgvComplain.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvComplain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvComplain.Location = new System.Drawing.Point(0, 0);
            this.dgvComplain.Name = "dgvComplain";
            this.dgvComplain.ReadOnly = true;
            this.dgvComplain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComplain.RowHeadersVisible = false;
            this.dgvComplain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvComplain.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvComplain.RowTemplate.Height = 30;
            this.dgvComplain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplain.Size = new System.Drawing.Size(261, 393);
            this.dgvComplain.TabIndex = 1;
            this.dgvComplain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplain_CellDoubleClick);
            // 
            // txtComplain
            // 
            // 
            // 
            // 
            this.txtComplain.CustomButton.Image = null;
            this.txtComplain.CustomButton.Location = new System.Drawing.Point(-154, 1);
            this.txtComplain.CustomButton.Name = "";
            this.txtComplain.CustomButton.Size = new System.Drawing.Size(365, 365);
            this.txtComplain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComplain.CustomButton.TabIndex = 1;
            this.txtComplain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComplain.CustomButton.UseSelectable = true;
            this.txtComplain.CustomButton.Visible = false;
            this.txtComplain.Lines = new string[] {
        "Double Click to Load Complain"};
            this.txtComplain.Location = new System.Drawing.Point(276, 12);
            this.txtComplain.MaxLength = 32767;
            this.txtComplain.Multiline = true;
            this.txtComplain.Name = "txtComplain";
            this.txtComplain.PasswordChar = '\0';
            this.txtComplain.ReadOnly = true;
            this.txtComplain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComplain.SelectedText = "";
            this.txtComplain.SelectionLength = 0;
            this.txtComplain.SelectionStart = 0;
            this.txtComplain.ShortcutsEnabled = true;
            this.txtComplain.Size = new System.Drawing.Size(212, 367);
            this.txtComplain.Style = MetroFramework.MetroColorStyle.Black;
            this.txtComplain.TabIndex = 106;
            this.txtComplain.Text = "Double Click to Load Complain";
            this.txtComplain.UseSelectable = true;
            this.txtComplain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComplain.WaterMarkFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Customer Name";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 120;
            // 
            // Complain
            // 
            this.Complain.DataPropertyName = "Complain";
            this.Complain.HeaderText = "Complain";
            this.Complain.Name = "Complain";
            this.Complain.ReadOnly = true;
            this.Complain.Visible = false;
            // 
            // ComplainID
            // 
            this.ComplainID.DataPropertyName = "ComplainID";
            this.ComplainID.HeaderText = "ComplainID";
            this.ComplainID.Name = "ComplainID";
            this.ComplainID.ReadOnly = true;
            this.ComplainID.Visible = false;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // CustomerComplainUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomerComplainUC";
            this.Size = new System.Drawing.Size(505, 393);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid dgvComplain;
        private MetroFramework.Controls.MetroTextBox txtComplain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
    }
}
