namespace PIMS
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.panelPhysicalExam = new System.Windows.Forms.Panel();
            this.btnCalculate = new CustomControls.Controls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhilDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOtherDisc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsurPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSCPWDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConsult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelScroll.SuspendLayout();
            this.panelPhysicalExam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1358, 834);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblDashboard);
            this.panel8.Controls.Add(this.panel4);
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
            this.lblDashboard.Text = "PAYMENT";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // panelScroll
            // 
            this.panelScroll.Controls.Add(this.panelPhysicalExam);
            this.panelScroll.Location = new System.Drawing.Point(12, 134);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1346, 700);
            this.panelScroll.TabIndex = 2;
            // 
            // panelPhysicalExam
            // 
            this.panelPhysicalExam.BackgroundImage = global::PIMS.Properties.Resources.PanelWhite1;
            this.panelPhysicalExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPhysicalExam.Controls.Add(this.btnCalculate);
            this.panelPhysicalExam.Controls.Add(this.panel1);
            this.panelPhysicalExam.Location = new System.Drawing.Point(0, 0);
            this.panelPhysicalExam.Name = "panelPhysicalExam";
            this.panelPhysicalExam.Size = new System.Drawing.Size(1350, 398);
            this.panelPhysicalExam.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnCalculate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnCalculate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCalculate.BorderRadius = 7;
            this.btnCalculate.BorderSize = 0;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(507, 319);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(246, 40);
            this.btnCalculate.TabIndex = 39;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.TextColor = System.Drawing.Color.White;
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PIMS.Properties.Resources.EvaluationPanelPink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtPhilDiscount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtOtherDisc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtInsurPay);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSCPWDiscount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtConsult);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(19, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 243);
            this.panel1.TabIndex = 18;
            // 
            // txtPhilDiscount
            // 
            this.txtPhilDiscount.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhilDiscount.Location = new System.Drawing.Point(46, 149);
            this.txtPhilDiscount.Name = "txtPhilDiscount";
            this.txtPhilDiscount.Size = new System.Drawing.Size(522, 24);
            this.txtPhilDiscount.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(43, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Philhealth (%):";
            // 
            // txtOtherDisc
            // 
            this.txtOtherDisc.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherDisc.Location = new System.Drawing.Point(632, 93);
            this.txtOtherDisc.Name = "txtOtherDisc";
            this.txtOtherDisc.Size = new System.Drawing.Size(522, 24);
            this.txtOtherDisc.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(628, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "Other Discount (%):";
            // 
            // txtInsurPay
            // 
            this.txtInsurPay.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsurPay.Location = new System.Drawing.Point(632, 39);
            this.txtInsurPay.Name = "txtInsurPay";
            this.txtInsurPay.Size = new System.Drawing.Size(522, 24);
            this.txtInsurPay.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(628, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Insurance Payment";
            // 
            // txtSCPWDiscount
            // 
            this.txtSCPWDiscount.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCPWDiscount.Location = new System.Drawing.Point(48, 93);
            this.txtSCPWDiscount.Name = "txtSCPWDiscount";
            this.txtSCPWDiscount.Size = new System.Drawing.Size(522, 24);
            this.txtSCPWDiscount.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label9.Location = new System.Drawing.Point(44, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "SC / PWD Discount (%):";
            // 
            // txtConsult
            // 
            this.txtConsult.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsult.Location = new System.Drawing.Point(48, 39);
            this.txtConsult.Name = "txtConsult";
            this.txtConsult.Size = new System.Drawing.Size(522, 24);
            this.txtConsult.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(44, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Consultation Fee:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient List";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSCPWDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConsult;
        private System.Windows.Forms.Label label3;
        private CustomControls.Controls.RJButton btnCalculate;
        private System.Windows.Forms.TextBox txtOtherDisc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsurPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhilDiscount;
        private System.Windows.Forms.Label label1;
    }
}