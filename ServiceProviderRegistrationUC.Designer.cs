namespace ComputerLounge___ComputerServiceProvider
{
    partial class ServiceProviderRegistrationUC
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompanyName = new MetroFramework.Controls.MetroTextBox();
            this.cmbService = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblConfirmPasswordError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblServiceError = new System.Windows.Forms.Label();
            this.lblCompanyError = new System.Windows.Forms.Label();
            this.lblRangeError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStartingRange = new MetroFramework.Controls.MetroTextBox();
            this.txtEndingRange = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Name of the Company";
            // 
            // txtCompanyName
            // 
            // 
            // 
            // 
            this.txtCompanyName.CustomButton.Image = null;
            this.txtCompanyName.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtCompanyName.CustomButton.Name = "";
            this.txtCompanyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCompanyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCompanyName.CustomButton.TabIndex = 1;
            this.txtCompanyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCompanyName.CustomButton.UseSelectable = true;
            this.txtCompanyName.CustomButton.Visible = false;
            this.txtCompanyName.Lines = new string[0];
            this.txtCompanyName.Location = new System.Drawing.Point(429, 64);
            this.txtCompanyName.MaxLength = 32767;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.SelectionLength = 0;
            this.txtCompanyName.SelectionStart = 0;
            this.txtCompanyName.ShortcutsEnabled = true;
            this.txtCompanyName.Size = new System.Drawing.Size(216, 23);
            this.txtCompanyName.Style = MetroFramework.MetroColorStyle.Black;
            this.txtCompanyName.TabIndex = 36;
            this.txtCompanyName.UseSelectable = true;
            this.txtCompanyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCompanyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.ItemHeight = 23;
            this.cmbService.Location = new System.Drawing.Point(428, 119);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(217, 29);
            this.cmbService.TabIndex = 37;
            this.cmbService.UseSelectable = true;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "Phone Number";
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(145, 238);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(216, 23);
            this.txtPhone.Style = MetroFramework.MetroColorStyle.Black;
            this.txtPhone.TabIndex = 46;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtConfirmPassword
            // 
            // 
            // 
            // 
            this.txtConfirmPassword.CustomButton.Image = null;
            this.txtConfirmPassword.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtConfirmPassword.CustomButton.Name = "";
            this.txtConfirmPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPassword.CustomButton.TabIndex = 1;
            this.txtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPassword.CustomButton.UseSelectable = true;
            this.txtConfirmPassword.CustomButton.Visible = false;
            this.txtConfirmPassword.Lines = new string[0];
            this.txtConfirmPassword.Location = new System.Drawing.Point(144, 179);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.ShortcutsEnabled = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(216, 23);
            this.txtConfirmPassword.Style = MetroFramework.MetroColorStyle.Black;
            this.txtConfirmPassword.TabIndex = 44;
            this.txtConfirmPassword.UseSelectable = true;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(144, 119);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(216, 23);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Black;
            this.txtPassword.TabIndex = 42;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(145, 64);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(216, 23);
            this.txtUsername.Style = MetroFramework.MetroColorStyle.Black;
            this.txtUsername.TabIndex = 41;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Password";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.White;
            this.btnCreateAccount.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCreateAccount.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCreateAccount.Location = new System.Drawing.Point(292, 303);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(216, 39);
            this.btnCreateAccount.TabIndex = 50;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseCustomBackColor = true;
            this.btnCreateAccount.UseCustomForeColor = true;
            this.btnCreateAccount.UseSelectable = true;
            this.btnCreateAccount.UseStyleColors = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 47;
            this.label6.Text = "Service";
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneError.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(376, 238);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(24, 32);
            this.lblPhoneError.TabIndex = 58;
            this.lblPhoneError.Text = "*";
            this.lblPhoneError.Visible = false;
            // 
            // lblConfirmPasswordError
            // 
            this.lblConfirmPasswordError.AutoSize = true;
            this.lblConfirmPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPasswordError.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmPasswordError.Location = new System.Drawing.Point(376, 179);
            this.lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            this.lblConfirmPasswordError.Size = new System.Drawing.Size(24, 32);
            this.lblConfirmPasswordError.TabIndex = 57;
            this.lblConfirmPasswordError.Text = "*";
            this.lblConfirmPasswordError.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordError.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(376, 119);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(24, 32);
            this.lblPasswordError.TabIndex = 56;
            this.lblPasswordError.Text = "*";
            this.lblPasswordError.Visible = false;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameError.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameError.Location = new System.Drawing.Point(376, 64);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(24, 32);
            this.lblUsernameError.TabIndex = 55;
            this.lblUsernameError.Text = "*";
            this.lblUsernameError.Visible = false;
            // 
            // lblServiceError
            // 
            this.lblServiceError.AutoSize = true;
            this.lblServiceError.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceError.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceError.ForeColor = System.Drawing.Color.Red;
            this.lblServiceError.Location = new System.Drawing.Point(660, 119);
            this.lblServiceError.Name = "lblServiceError";
            this.lblServiceError.Size = new System.Drawing.Size(24, 32);
            this.lblServiceError.TabIndex = 60;
            this.lblServiceError.Text = "*";
            this.lblServiceError.Visible = false;
            // 
            // lblCompanyError
            // 
            this.lblCompanyError.AutoSize = true;
            this.lblCompanyError.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyError.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyError.ForeColor = System.Drawing.Color.Red;
            this.lblCompanyError.Location = new System.Drawing.Point(660, 64);
            this.lblCompanyError.Name = "lblCompanyError";
            this.lblCompanyError.Size = new System.Drawing.Size(24, 32);
            this.lblCompanyError.TabIndex = 59;
            this.lblCompanyError.Text = "*";
            this.lblCompanyError.Visible = false;
            // 
            // lblRangeError
            // 
            this.lblRangeError.AutoSize = true;
            this.lblRangeError.BackColor = System.Drawing.Color.Transparent;
            this.lblRangeError.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangeError.ForeColor = System.Drawing.Color.Red;
            this.lblRangeError.Location = new System.Drawing.Point(659, 180);
            this.lblRangeError.Name = "lblRangeError";
            this.lblRangeError.Size = new System.Drawing.Size(24, 32);
            this.lblRangeError.TabIndex = 63;
            this.lblRangeError.Text = "*";
            this.lblRangeError.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Range of Cost";
            // 
            // txtStartingRange
            // 
            // 
            // 
            // 
            this.txtStartingRange.CustomButton.Image = null;
            this.txtStartingRange.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.txtStartingRange.CustomButton.Name = "";
            this.txtStartingRange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStartingRange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStartingRange.CustomButton.TabIndex = 1;
            this.txtStartingRange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStartingRange.CustomButton.UseSelectable = true;
            this.txtStartingRange.CustomButton.Visible = false;
            this.txtStartingRange.Lines = new string[0];
            this.txtStartingRange.Location = new System.Drawing.Point(428, 183);
            this.txtStartingRange.MaxLength = 32767;
            this.txtStartingRange.Name = "txtStartingRange";
            this.txtStartingRange.PasswordChar = '\0';
            this.txtStartingRange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStartingRange.SelectedText = "";
            this.txtStartingRange.SelectionLength = 0;
            this.txtStartingRange.SelectionStart = 0;
            this.txtStartingRange.ShortcutsEnabled = true;
            this.txtStartingRange.Size = new System.Drawing.Size(86, 23);
            this.txtStartingRange.Style = MetroFramework.MetroColorStyle.Black;
            this.txtStartingRange.TabIndex = 62;
            this.txtStartingRange.UseSelectable = true;
            this.txtStartingRange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStartingRange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStartingRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartingRange_KeyPress);
            // 
            // txtEndingRange
            // 
            // 
            // 
            // 
            this.txtEndingRange.CustomButton.Image = null;
            this.txtEndingRange.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.txtEndingRange.CustomButton.Name = "";
            this.txtEndingRange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEndingRange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEndingRange.CustomButton.TabIndex = 1;
            this.txtEndingRange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEndingRange.CustomButton.UseSelectable = true;
            this.txtEndingRange.CustomButton.Visible = false;
            this.txtEndingRange.Lines = new string[0];
            this.txtEndingRange.Location = new System.Drawing.Point(559, 183);
            this.txtEndingRange.MaxLength = 32767;
            this.txtEndingRange.Name = "txtEndingRange";
            this.txtEndingRange.PasswordChar = '\0';
            this.txtEndingRange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndingRange.SelectedText = "";
            this.txtEndingRange.SelectionLength = 0;
            this.txtEndingRange.SelectionStart = 0;
            this.txtEndingRange.ShortcutsEnabled = true;
            this.txtEndingRange.Size = new System.Drawing.Size(86, 23);
            this.txtEndingRange.Style = MetroFramework.MetroColorStyle.Black;
            this.txtEndingRange.TabIndex = 64;
            this.txtEndingRange.UseSelectable = true;
            this.txtEndingRange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEndingRange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndingRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndingRange_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(525, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 32);
            this.label9.TabIndex = 65;
            this.label9.Text = "-";
            // 
            // ServiceProviderRegistrationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEndingRange);
            this.Controls.Add(this.lblRangeError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStartingRange);
            this.Controls.Add(this.lblServiceError);
            this.Controls.Add(this.lblCompanyError);
            this.Controls.Add(this.lblPhoneError);
            this.Controls.Add(this.lblConfirmPasswordError);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblUsernameError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCompanyName);
            this.Name = "ServiceProviderRegistrationUC";
            this.Size = new System.Drawing.Size(800, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtCompanyName;
        private MetroFramework.Controls.MetroComboBox cmbService;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtConfirmPassword;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnCreateAccount;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblConfirmPasswordError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblServiceError;
        private System.Windows.Forms.Label lblCompanyError;
        private System.Windows.Forms.Label lblRangeError;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtStartingRange;
        private MetroFramework.Controls.MetroTextBox txtEndingRange;
        private System.Windows.Forms.Label label9;
    }
}
