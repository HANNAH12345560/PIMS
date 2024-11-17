namespace PIMS
{
    partial class StartScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.foreverProgressBar1 = new ReaLTaiizor.Controls.ForeverProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // foreverProgressBar1
            // 
            this.foreverProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.foreverProgressBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.foreverProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.foreverProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foreverProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.foreverProgressBar1.Location = new System.Drawing.Point(0, 251);
            this.foreverProgressBar1.Maximum = 100;
            this.foreverProgressBar1.MoveBalloon = true;
            this.foreverProgressBar1.Name = "foreverProgressBar1";
            this.foreverProgressBar1.Pattern = true;
            this.foreverProgressBar1.PercentSign = false;
            this.foreverProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.foreverProgressBar1.ShowBalloon = true;
            this.foreverProgressBar1.Size = new System.Drawing.Size(727, 42);
            this.foreverProgressBar1.TabIndex = 2;
            this.foreverProgressBar1.Text = "foreverProgressBar1";
            this.foreverProgressBar1.Value = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PIMS.Properties.Resources.LoginLbl;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(167, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 112);
            this.panel4.TabIndex = 1;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 293);
            this.Controls.Add(this.foreverProgressBar1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harmony Medical Care";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private ReaLTaiizor.Controls.ForeverProgressBar foreverProgressBar1;
    }
}