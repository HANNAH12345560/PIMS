namespace PIMS
{
    partial class Prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescription));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelPhysicalExam = new System.Windows.Forms.Panel();
            this.btnContinue = new CustomControls.Controls.RJButton();
            this.btnPrint = new CustomControls.Controls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrescriptionPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhysicianName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new CustomControls.RJControls.RJTextBox();
            this.txtAge = new CustomControls.RJControls.RJTextBox();
            this.txtAdd = new CustomControls.RJControls.RJTextBox();
            this.txtName = new CustomControls.RJControls.RJTextBox();
            this.txtDosage = new System.Windows.Forms.Label();
            this.txtMedName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSex = new CustomControls.RJControls.RJTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelPhysicalExam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PrescriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1420, 21);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.lblDashboard);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 21);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1420, 106);
            this.panel8.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PIMS.Properties.Resources.LoginLbl;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(56, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 95);
            this.panel4.TabIndex = 44;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDashboard.Location = new System.Drawing.Point(291, 14);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(674, 84);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "PRESCRIPTION";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panelPhysicalExam);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1370, 749);
            this.panel6.TabIndex = 1;
            // 
            // panelPhysicalExam
            // 
            this.panelPhysicalExam.BackgroundImage = global::PIMS.Properties.Resources.PanelWhite1;
            this.panelPhysicalExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPhysicalExam.Controls.Add(this.btnContinue);
            this.panelPhysicalExam.Controls.Add(this.btnPrint);
            this.panelPhysicalExam.Controls.Add(this.panel1);
            this.panelPhysicalExam.Location = new System.Drawing.Point(36, 152);
            this.panelPhysicalExam.Name = "panelPhysicalExam";
            this.panelPhysicalExam.Size = new System.Drawing.Size(1384, 836);
            this.panelPhysicalExam.TabIndex = 0;
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
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(571, 736);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(246, 40);
            this.btnContinue.TabIndex = 44;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.TextColor = System.Drawing.Color.White;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnPrint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrint.BorderRadius = 7;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(931, 24);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(246, 40);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PIMS.Properties.Resources.EvaluationPanelPink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.PrescriptionPanel);
            this.panel1.Location = new System.Drawing.Point(96, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 643);
            this.panel1.TabIndex = 18;
            // 
            // PrescriptionPanel
            // 
            this.PrescriptionPanel.AutoScroll = true;
            this.PrescriptionPanel.BackColor = System.Drawing.Color.White;
            this.PrescriptionPanel.Controls.Add(this.panel2);
            this.PrescriptionPanel.Controls.Add(this.label10);
            this.PrescriptionPanel.Controls.Add(this.txtPhysicianName);
            this.PrescriptionPanel.Controls.Add(this.label3);
            this.PrescriptionPanel.Controls.Add(this.label2);
            this.PrescriptionPanel.Controls.Add(this.txtDate);
            this.PrescriptionPanel.Controls.Add(this.txtAge);
            this.PrescriptionPanel.Controls.Add(this.txtAdd);
            this.PrescriptionPanel.Controls.Add(this.txtName);
            this.PrescriptionPanel.Controls.Add(this.txtDosage);
            this.PrescriptionPanel.Controls.Add(this.txtMedName);
            this.PrescriptionPanel.Controls.Add(this.label1);
            this.PrescriptionPanel.Controls.Add(this.label4);
            this.PrescriptionPanel.Controls.Add(this.panel5);
            this.PrescriptionPanel.Controls.Add(this.label9);
            this.PrescriptionPanel.Controls.Add(this.panel3);
            this.PrescriptionPanel.Controls.Add(this.label5);
            this.PrescriptionPanel.Controls.Add(this.txtSex);
            this.PrescriptionPanel.Location = new System.Drawing.Point(249, 19);
            this.PrescriptionPanel.Name = "PrescriptionPanel";
            this.PrescriptionPanel.Size = new System.Drawing.Size(626, 573);
            this.PrescriptionPanel.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PIMS.Properties.Resources.PRESCRIPTION;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(21, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 144);
            this.panel2.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(525, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 62;
            this.label10.Text = "Signature";
            // 
            // txtPhysicianName
            // 
            this.txtPhysicianName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhysicianName.AutoSize = true;
            this.txtPhysicianName.BackColor = System.Drawing.Color.Transparent;
            this.txtPhysicianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhysicianName.ForeColor = System.Drawing.Color.Black;
            this.txtPhysicianName.Location = new System.Drawing.Point(504, 546);
            this.txtPhysicianName.Name = "txtPhysicianName";
            this.txtPhysicianName.Size = new System.Drawing.Size(110, 15);
            this.txtPhysicianName.TabIndex = 61;
            this.txtPhysicianName.Text = "Physician Name";
            this.txtPhysicianName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(337, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(337, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtDate.BorderColor = System.Drawing.Color.Black;
            this.txtDate.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDate.BorderRadius = 0;
            this.txtDate.BorderSize = 1;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.Location = new System.Drawing.Point(371, 182);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Multiline = false;
            this.txtDate.Name = "txtDate";
            this.txtDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDate.PasswordChar = false;
            this.txtDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDate.PlaceholderText = "";
            this.txtDate.Size = new System.Drawing.Size(105, 31);
            this.txtDate.TabIndex = 59;
            this.txtDate.Texts = "";
            this.txtDate.UnderlinedStyle = true;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Window;
            this.txtAge.BorderColor = System.Drawing.Color.Black;
            this.txtAge.BorderFocusColor = System.Drawing.Color.Black;
            this.txtAge.BorderRadius = 0;
            this.txtAge.BorderSize = 1;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAge.Location = new System.Drawing.Point(371, 142);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Multiline = false;
            this.txtAge.Name = "txtAge";
            this.txtAge.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAge.PasswordChar = false;
            this.txtAge.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAge.PlaceholderText = "";
            this.txtAge.Size = new System.Drawing.Size(114, 31);
            this.txtAge.TabIndex = 58;
            this.txtAge.Texts = "";
            this.txtAge.UnderlinedStyle = true;
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdd.BorderColor = System.Drawing.Color.Black;
            this.txtAdd.BorderFocusColor = System.Drawing.Color.Black;
            this.txtAdd.BorderRadius = 0;
            this.txtAdd.BorderSize = 1;
            this.txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdd.Location = new System.Drawing.Point(80, 182);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd.Multiline = false;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAdd.PasswordChar = false;
            this.txtAdd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAdd.PlaceholderText = "";
            this.txtAdd.Size = new System.Drawing.Size(234, 31);
            this.txtAdd.TabIndex = 57;
            this.txtAdd.Texts = "";
            this.txtAdd.UnderlinedStyle = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.BorderFocusColor = System.Drawing.Color.Black;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(64, 138);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(250, 31);
            this.txtName.TabIndex = 56;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // txtDosage
            // 
            this.txtDosage.AutoSize = true;
            this.txtDosage.BackColor = System.Drawing.Color.Transparent;
            this.txtDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosage.ForeColor = System.Drawing.Color.Black;
            this.txtDosage.Location = new System.Drawing.Point(416, 304);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(56, 15);
            this.txtDosage.TabIndex = 54;
            this.txtDosage.Text = "Dosage";
            // 
            // txtMedName
            // 
            this.txtMedName.AutoSize = true;
            this.txtMedName.BackColor = System.Drawing.Color.Transparent;
            this.txtMedName.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedName.ForeColor = System.Drawing.Color.Black;
            this.txtMedName.Location = new System.Drawing.Point(225, 304);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(104, 22);
            this.txtMedName.TabIndex = 53;
            this.txtMedName.Text = "Medicine Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(492, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Sex:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(14, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 5);
            this.panel5.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(137, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(404, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Dr Jose P. Rizal Ext, West Rembo, Taguig, 1644 Metro Manila";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PIMS.Properties.Resources.LoginLbl;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 95);
            this.panel3.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Name:";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.Window;
            this.txtSex.BorderColor = System.Drawing.Color.Black;
            this.txtSex.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSex.BorderRadius = 0;
            this.txtSex.BorderSize = 1;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSex.Location = new System.Drawing.Point(517, 142);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4);
            this.txtSex.Multiline = false;
            this.txtSex.Name = "txtSex";
            this.txtSex.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSex.PasswordChar = false;
            this.txtSex.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSex.PlaceholderText = "";
            this.txtSex.Size = new System.Drawing.Size(97, 31);
            this.txtSex.TabIndex = 60;
            this.txtSex.Texts = "";
            this.txtSex.UnderlinedStyle = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient List";
            this.Load += new System.EventHandler(this.DashboardScreen_Load);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelPhysicalExam.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PrescriptionPanel.ResumeLayout(false);
            this.PrescriptionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelPhysicalExam;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.Controls.RJButton btnPrint;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PrescriptionPanel;
        private System.Windows.Forms.Label txtMedName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox txtDate;
        private CustomControls.RJControls.RJTextBox txtAge;
        private CustomControls.RJControls.RJTextBox txtAdd;
        private System.Windows.Forms.Label txtDosage;
        private CustomControls.RJControls.RJTextBox txtSex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtPhysicianName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.Controls.RJButton btnContinue;
        private CustomControls.RJControls.RJTextBox txtName;
    }
}