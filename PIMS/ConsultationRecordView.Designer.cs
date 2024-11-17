namespace PIMS
{
    partial class ConsultationRecordView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationRecordView));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.btnContinue = new CustomControls.Controls.RJButton();
            this.btnBack = new CustomControls.Controls.RJButton();
            this.panelPhysicalExam = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtWT = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPR = new System.Windows.Forms.TextBox();
            this.txtRR = new System.Windows.Forms.TextBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.lblDashboard.Text = "INITIAL ASSESSMENT";
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
            this.panelScroll.Controls.Add(this.btnContinue);
            this.panelScroll.Controls.Add(this.btnBack);
            this.panelScroll.Controls.Add(this.panelPhysicalExam);
            this.panelScroll.Location = new System.Drawing.Point(12, 134);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1346, 700);
            this.panelScroll.TabIndex = 2;
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
            this.btnContinue.Location = new System.Drawing.Point(611, 622);
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
            this.panelPhysicalExam.Controls.Add(this.label1);
            this.panelPhysicalExam.Controls.Add(this.txtLastName);
            this.panelPhysicalExam.Controls.Add(this.label6);
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
            this.panel1.Controls.Add(this.txtComplaint);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtBloodType);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtHT);
            this.panel1.Controls.Add(this.txtWT);
            this.panel1.Controls.Add(this.txtTemp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPR);
            this.panel1.Controls.Add(this.txtRR);
            this.panel1.Controls.Add(this.txtBP);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(19, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 475);
            this.panel1.TabIndex = 18;
            // 
            // txtComplaint
            // 
            this.txtComplaint.Location = new System.Drawing.Point(48, 251);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.ReadOnly = true;
            this.txtComplaint.Size = new System.Drawing.Size(1004, 156);
            this.txtComplaint.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label11.Location = new System.Drawing.Point(44, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 22);
            this.label11.TabIndex = 36;
            this.label11.Text = "Chief Complaints:";
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(48, 181);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.ReadOnly = true;
            this.txtBloodType.Size = new System.Drawing.Size(282, 20);
            this.txtBloodType.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label10.Location = new System.Drawing.Point(44, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 22);
            this.label10.TabIndex = 34;
            this.label10.Text = "Blood Type:";
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(770, 127);
            this.txtHT.Name = "txtHT";
            this.txtHT.ReadOnly = true;
            this.txtHT.Size = new System.Drawing.Size(282, 20);
            this.txtHT.TabIndex = 33;
            // 
            // txtWT
            // 
            this.txtWT.Location = new System.Drawing.Point(412, 127);
            this.txtWT.Name = "txtWT";
            this.txtWT.ReadOnly = true;
            this.txtWT.Size = new System.Drawing.Size(282, 20);
            this.txtWT.TabIndex = 32;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(48, 127);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(282, 20);
            this.txtTemp.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(766, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(408, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Weight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label9.Location = new System.Drawing.Point(44, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "Temperature:";
            // 
            // txtPR
            // 
            this.txtPR.Location = new System.Drawing.Point(770, 72);
            this.txtPR.Name = "txtPR";
            this.txtPR.ReadOnly = true;
            this.txtPR.Size = new System.Drawing.Size(282, 20);
            this.txtPR.TabIndex = 26;
            // 
            // txtRR
            // 
            this.txtRR.Location = new System.Drawing.Point(412, 72);
            this.txtRR.Name = "txtRR";
            this.txtRR.ReadOnly = true;
            this.txtRR.Size = new System.Drawing.Size(282, 20);
            this.txtRR.TabIndex = 25;
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(48, 72);
            this.txtBP.Name = "txtBP";
            this.txtBP.ReadOnly = true;
            this.txtBP.Size = new System.Drawing.Size(282, 20);
            this.txtBP.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label8.Location = new System.Drawing.Point(766, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Pulse Rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label7.Location = new System.Drawing.Point(408, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Respiratory Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(44, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Blood Pressure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(41, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 39);
            this.label2.TabIndex = 20;
            this.label2.Text = "Vital Signs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Physical Examination:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(209, 17);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(379, 20);
            this.txtLastName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Physician In charge: ";
            // 
            // ConsultationRecordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultationRecordView";
            this.Text = "Medical Record";
            this.Load += new System.EventHandler(this.DashboardScreen_Load);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelScroll.ResumeLayout(false);
            this.panelPhysicalExam.ResumeLayout(false);
            this.panelPhysicalExam.PerformLayout();
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
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComplaint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtWT;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPR;
        private System.Windows.Forms.TextBox txtRR;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private CustomControls.Controls.RJButton btnContinue;
        private CustomControls.Controls.RJButton btnBack;
    }
}