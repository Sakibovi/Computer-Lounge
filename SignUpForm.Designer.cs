namespace ComputerLounge___ComputerServiceProvider
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnServiceProvider = new MetroFramework.Controls.MetroButton();
            this.btnCustomer = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.metroPanel3.TabIndex = 17;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            this.metroPanel3.Click += new System.EventHandler(this.metroPanel3_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(738, 16);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(33, 33);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Click += new System.EventHandler(this.metroPanel1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnServiceProvider);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Controls.Add(this.metroPanel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 487);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 386);
            this.panel2.TabIndex = 20;
            // 
            // btnServiceProvider
            // 
            this.btnServiceProvider.BackColor = System.Drawing.Color.White;
            this.btnServiceProvider.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnServiceProvider.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnServiceProvider.Location = new System.Drawing.Point(415, 27);
            this.btnServiceProvider.Name = "btnServiceProvider";
            this.btnServiceProvider.Size = new System.Drawing.Size(216, 39);
            this.btnServiceProvider.TabIndex = 50;
            this.btnServiceProvider.Text = "Register as a Service Provider";
            this.btnServiceProvider.UseCustomBackColor = true;
            this.btnServiceProvider.UseCustomForeColor = true;
            this.btnServiceProvider.UseSelectable = true;
            this.btnServiceProvider.UseStyleColors = true;
            this.btnServiceProvider.Click += new System.EventHandler(this.btnServiceProvider_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCustomer.Location = new System.Drawing.Point(193, 27);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(216, 39);
            this.btnCustomer.TabIndex = 50;
            this.btnCustomer.Text = "Register as a Customer";
            this.btnCustomer.UseCustomBackColor = true;
            this.btnCustomer.UseCustomForeColor = true;
            this.btnCustomer.UseSelectable = true;
            this.btnCustomer.UseStyleColors = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton btnServiceProvider;
        private MetroFramework.Controls.MetroButton btnCustomer;
    }
}