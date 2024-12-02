namespace PIMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2PanelLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButtonLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButtonClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblForget = new System.Windows.Forms.Label();
            this.lblShowPassword = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PanelLogo
            // 
            this.guna2PanelLogo.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelLogo.BackgroundImage = global::PIMS.Properties.Resources.LoginLbl;
            this.guna2PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PanelLogo.Location = new System.Drawing.Point(456, 59);
            this.guna2PanelLogo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.guna2PanelLogo.Name = "guna2PanelLogo";
            this.guna2PanelLogo.Size = new System.Drawing.Size(200, 87);
            this.guna2PanelLogo.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::PIMS.Properties.Resources.LOG_IN;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.guna2GradientButtonLogin);
            this.guna2Panel1.Controls.Add(this.guna2GradientButtonClear);
            this.guna2Panel1.Controls.Add(this.lblForget);
            this.guna2Panel1.Controls.Add(this.lblShowPassword);
            this.guna2Panel1.Controls.Add(this.guna2ToggleSwitch1);
            this.guna2Panel1.Controls.Add(this.txtbPassword);
            this.guna2Panel1.Controls.Add(this.txtbUsername);
            this.guna2Panel1.Controls.Add(this.lblPassword);
            this.guna2Panel1.Controls.Add(this.lblUsername);
            this.guna2Panel1.Controls.Add(this.guna2PanelLogo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(784, 456);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2GradientButtonLogin
            // 
            this.guna2GradientButtonLogin.AutoRoundedCorners = true;
            this.guna2GradientButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButtonLogin.BorderRadius = 15;
            this.guna2GradientButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2GradientButtonLogin.FillColor2 = System.Drawing.Color.HotPink;
            this.guna2GradientButtonLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButtonLogin.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButtonLogin.Location = new System.Drawing.Point(484, 355);
            this.guna2GradientButtonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GradientButtonLogin.Name = "guna2GradientButtonLogin";
            this.guna2GradientButtonLogin.Size = new System.Drawing.Size(133, 32);
            this.guna2GradientButtonLogin.TabIndex = 9;
            this.guna2GradientButtonLogin.Text = "LOGIN";
            this.guna2GradientButtonLogin.Click += new System.EventHandler(this.guna2GradientButtonLogin_Click);
            // 
            // guna2GradientButtonClear
            // 
            this.guna2GradientButtonClear.AutoRoundedCorners = true;
            this.guna2GradientButtonClear.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButtonClear.BorderRadius = 9;
            this.guna2GradientButtonClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButtonClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2GradientButtonClear.FillColor2 = System.Drawing.Color.HotPink;
            this.guna2GradientButtonClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButtonClear.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButtonClear.Location = new System.Drawing.Point(606, 280);
            this.guna2GradientButtonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GradientButtonClear.Name = "guna2GradientButtonClear";
            this.guna2GradientButtonClear.Size = new System.Drawing.Size(85, 21);
            this.guna2GradientButtonClear.TabIndex = 8;
            this.guna2GradientButtonClear.Text = "CLEAR";
            this.guna2GradientButtonClear.Click += new System.EventHandler(this.guna2GradientButtonClear_Click);
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.BackColor = System.Drawing.Color.Transparent;
            this.lblForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForget.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblForget.Location = new System.Drawing.Point(472, 322);
            this.lblForget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(155, 13);
            this.lblForget.TabIndex = 7;
            this.lblForget.Text = "Forgot Username or Password?";
            // 
            // lblShowPassword
            // 
            this.lblShowPassword.AutoSize = true;
            this.lblShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPassword.Location = new System.Drawing.Point(453, 280);
            this.lblShowPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowPassword.Name = "lblShowPassword";
            this.lblShowPassword.Size = new System.Drawing.Size(83, 13);
            this.lblShowPassword.TabIndex = 6;
            this.lblShowPassword.Text = "Show Password";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(416, 280);
            this.guna2ToggleSwitch1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(33, 13);
            this.guna2ToggleSwitch1.TabIndex = 5;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // txtbPassword
            // 
            this.txtbPassword.AutoRoundedCorners = true;
            this.txtbPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtbPassword.BorderColor = System.Drawing.Color.LightCoral;
            this.txtbPassword.BorderRadius = 14;
            this.txtbPassword.BorderThickness = 2;
            this.txtbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbPassword.DefaultText = "";
            this.txtbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbPassword.ForeColor = System.Drawing.Color.Black;
            this.txtbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtbPassword.IconLeft")));
            this.txtbPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtbPassword.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtbPassword.Location = new System.Drawing.Point(416, 247);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '\0';
            this.txtbPassword.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtbPassword.PlaceholderText = "";
            this.txtbPassword.SelectedText = "";
            this.txtbPassword.Size = new System.Drawing.Size(275, 30);
            this.txtbPassword.TabIndex = 4;
            // 
            // txtbUsername
            // 
            this.txtbUsername.AutoRoundedCorners = true;
            this.txtbUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtbUsername.BorderColor = System.Drawing.Color.LightCoral;
            this.txtbUsername.BorderRadius = 14;
            this.txtbUsername.BorderThickness = 2;
            this.txtbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbUsername.DefaultText = "";
            this.txtbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbUsername.ForeColor = System.Drawing.Color.Black;
            this.txtbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtbUsername.IconLeft")));
            this.txtbUsername.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtbUsername.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtbUsername.Location = new System.Drawing.Point(416, 193);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.PasswordChar = '\0';
            this.txtbUsername.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtbUsername.PlaceholderText = "";
            this.txtbUsername.SelectedText = "";
            this.txtbUsername.Size = new System.Drawing.Size(275, 30);
            this.txtbUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(413, 226);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(413, 172);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(90, 18);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 456);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harmony Medical Care";
            this.Load += new System.EventHandler(this.Login_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelLogo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtbUsername;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2TextBox txtbPassword;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonClear;
        private System.Windows.Forms.Label lblForget;
        private System.Windows.Forms.Label lblShowPassword;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonLogin;
    }
}