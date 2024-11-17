namespace PIMS
{
    partial class ConsultationRecordViewEvaluation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationRecordViewEvaluation));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.panelPhysicalExam = new System.Windows.Forms.Panel();
            this.btnContinue = new CustomControls.Controls.RJButton();
            this.btnBack = new CustomControls.Controls.RJButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelScroll.SuspendLayout();
            this.panelPhysicalExam.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1358, 21);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblDashboard);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 21);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1358, 95);
            this.panel8.TabIndex = 1;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Font = new System.Drawing.Font("Poppins SemiBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(213, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(811, 84);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "PHYSICIAN EVALUATION";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PIMS.Properties.Resources.LoginLbl;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(8, -12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 105);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panelScroll);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1370, 749);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panelScroll
            // 
            this.panelScroll.Controls.Add(this.btnBack);
            this.panelScroll.Controls.Add(this.btnContinue);
            this.panelScroll.Controls.Add(this.panelPhysicalExam);
            this.panelScroll.Location = new System.Drawing.Point(12, 134);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1346, 790);
            this.panelScroll.TabIndex = 2;
            // 
            // panelPhysicalExam
            // 
            this.panelPhysicalExam.BackgroundImage = global::PIMS.Properties.Resources.PanelWhite1;
            this.panelPhysicalExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPhysicalExam.Controls.Add(this.panel15);
            this.panelPhysicalExam.Controls.Add(this.label1);
            this.panelPhysicalExam.Location = new System.Drawing.Point(0, 0);
            this.panelPhysicalExam.Name = "panelPhysicalExam";
            this.panelPhysicalExam.Size = new System.Drawing.Size(1351, 700);
            this.panelPhysicalExam.TabIndex = 0;
            this.panelPhysicalExam.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPhysicalExam_Paint);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnContinue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnContinue.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnContinue.BorderRadius = 7;
            this.btnContinue.BorderSize = 0;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(593, 706);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(246, 40);
            this.btnContinue.TabIndex = 39;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.TextColor = System.Drawing.Color.White;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.BorderRadius = 7;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(332, 706);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(246, 40);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "BACK";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel15
            // 
            this.panel15.BackgroundImage = global::PIMS.Properties.Resources.EvaluationPanelPink;
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel15.Controls.Add(this.vScrollBar1);
            this.panel15.Controls.Add(this.label2);
            this.panel15.Controls.Add(this.panel1);
            this.panel15.Controls.Add(this.txtComplaint);
            this.panel15.Controls.Add(this.label14);
            this.panel15.Location = new System.Drawing.Point(15, 55);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1293, 581);
            this.panel15.TabIndex = 20;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1048, 271);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 235);
            this.vScrollBar1.TabIndex = 42;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(51, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 39);
            this.label2.TabIndex = 41;
            this.label2.Text = "Medical Treatment";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtMedName);
            this.panel1.Controls.Add(this.txtDosage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(48, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 235);
            this.panel1.TabIndex = 40;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(725, 33);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(282, 20);
            this.txtPrice.TabIndex = 46;
            // 
            // txtMedName
            // 
            this.txtMedName.Location = new System.Drawing.Point(3, 33);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.ReadOnly = true;
            this.txtMedName.Size = new System.Drawing.Size(282, 20);
            this.txtMedName.TabIndex = 44;
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(367, 33);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.ReadOnly = true;
            this.txtDosage.Size = new System.Drawing.Size(282, 20);
            this.txtDosage.TabIndex = 45;
            this.txtDosage.TextChanged += new System.EventHandler(this.txtRR_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(-1, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Medicine Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label7.Location = new System.Drawing.Point(363, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 42;
            this.label7.Text = "Dosage:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label8.Location = new System.Drawing.Point(721, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 43;
            this.label8.Text = "Price:";
            // 
            // txtComplaint
            // 
            this.txtComplaint.Location = new System.Drawing.Point(48, 60);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.ReadOnly = true;
            this.txtComplaint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComplaint.Size = new System.Drawing.Size(1004, 156);
            this.txtComplaint.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.label14.Location = new System.Drawing.Point(41, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 39);
            this.label14.TabIndex = 20;
            this.label14.Text = "Diagnosis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Evaluation:";
            // 
            // ConsultationRecordViewEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultationRecordViewEvaluation";
            this.Text = "Medical Record";
            this.Load += new System.EventHandler(this.DashboardScreen_Load);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelScroll.ResumeLayout(false);
            this.panelPhysicalExam.ResumeLayout(false);
            this.panelPhysicalExam.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelScroll;
        private System.Windows.Forms.Panel panelPhysicalExam;
        private System.Windows.Forms.Label label1;
        private CustomControls.Controls.RJButton btnContinue;
        private CustomControls.Controls.RJButton btnBack;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtComplaint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}