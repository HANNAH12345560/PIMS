namespace PIMS
{
    partial class AdmissionRecordEditContinuation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmissionRecordEditContinuation));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.btnReturn = new CustomControls.Controls.RJButton();
            this.btnBack = new CustomControls.Controls.RJButton();
            this.panelPhysicalExam = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdmissionFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedFee = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMedTreatment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelScroll.SuspendLayout();
            this.panelPhysicalExam.SuspendLayout();
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
            this.lblDashboard.Size = new System.Drawing.Size(699, 84);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "ADMISSION RECORD";
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
            this.panelScroll.Controls.Add(this.btnReturn);
            this.panelScroll.Controls.Add(this.btnBack);
            this.panelScroll.Controls.Add(this.panelPhysicalExam);
            this.panelScroll.Location = new System.Drawing.Point(12, 134);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1346, 700);
            this.panelScroll.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnReturn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnReturn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReturn.BorderRadius = 7;
            this.btnReturn.BorderSize = 0;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(611, 622);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(246, 40);
            this.btnReturn.TabIndex = 39;
            this.btnReturn.Text = "UPDATE";
            this.btnReturn.TextColor = System.Drawing.Color.White;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnContinue_Click);
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
            this.btnBack.Location = new System.Drawing.Point(342, 622);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(246, 40);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "BACK";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelPhysicalExam
            // 
            this.panelPhysicalExam.BackgroundImage = global::PIMS.Properties.Resources.PanelWhite1;
            this.panelPhysicalExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPhysicalExam.Controls.Add(this.panel1);
            this.panelPhysicalExam.Location = new System.Drawing.Point(0, 0);
            this.panelPhysicalExam.Name = "panelPhysicalExam";
            this.panelPhysicalExam.Size = new System.Drawing.Size(1350, 603);
            this.panelPhysicalExam.TabIndex = 0;
            this.panelPhysicalExam.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPhysicalExam_Paint);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PIMS.Properties.Resources.EvaluationPanelPink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtTotalBill);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAdmissionFee);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMedFee);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtMedTreatment);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(19, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 541);
            this.panel1.TabIndex = 18;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(724, 242);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(282, 20);
            this.txtTotalBill.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(720, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Total Billing:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(724, 188);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(282, 20);
            this.txtDiscount.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(720, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 60;
            this.label3.Text = "Discount (%):";
            // 
            // txtAdmissionFee
            // 
            this.txtAdmissionFee.Location = new System.Drawing.Point(724, 125);
            this.txtAdmissionFee.Name = "txtAdmissionFee";
            this.txtAdmissionFee.Size = new System.Drawing.Size(282, 20);
            this.txtAdmissionFee.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(720, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "Admission Fee";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(20, 322);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(1094, 132);
            this.txtRemarks.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(16, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "Remarks:";
            // 
            // txtMedFee
            // 
            this.txtMedFee.Location = new System.Drawing.Point(724, 64);
            this.txtMedFee.Name = "txtMedFee";
            this.txtMedFee.Size = new System.Drawing.Size(282, 20);
            this.txtMedFee.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label13.Location = new System.Drawing.Point(720, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 22);
            this.label13.TabIndex = 48;
            this.label13.Text = "Medical Fee:";
            // 
            // txtMedTreatment
            // 
            this.txtMedTreatment.Location = new System.Drawing.Point(20, 41);
            this.txtMedTreatment.Multiline = true;
            this.txtMedTreatment.Name = "txtMedTreatment";
            this.txtMedTreatment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMedTreatment.Size = new System.Drawing.Size(608, 237);
            this.txtMedTreatment.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label11.Location = new System.Drawing.Point(16, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 22);
            this.label11.TabIndex = 36;
            this.label11.Text = "Medical Treatment:";
            // 
            // AdmissionRecordEditContinuation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdmissionRecordEditContinuation";
            this.Text = "Medical Record";
            this.Load += new System.EventHandler(this.DashboardScreen_Load);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelScroll.ResumeLayout(false);
            this.panelPhysicalExam.ResumeLayout(false);
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
        private CustomControls.Controls.RJButton btnReturn;
        private CustomControls.Controls.RJButton btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMedTreatment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMedFee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdmissionFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label1;
    }
}