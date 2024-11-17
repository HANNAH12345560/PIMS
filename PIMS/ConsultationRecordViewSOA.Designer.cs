namespace PIMS
{
    partial class ConsultationRecordViewSOA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationRecordViewSOA));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.btnContinue = new CustomControls.Controls.RJButton();
            this.btnBack = new CustomControls.Controls.RJButton();
            this.panelPhysicalExam = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalBal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatetime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSOAref = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhysician = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelScroll.SuspendLayout();
            this.panelPhysicalExam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lblDashboard.Size = new System.Drawing.Size(1060, 84);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "STATEMENT OF AMOUNT";
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
            this.btnContinue.Text = "RETURN";
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
            this.panelPhysicalExam.Controls.Add(this.label9);
            this.panelPhysicalExam.Controls.Add(this.label1);
            this.panelPhysicalExam.Controls.Add(this.panel2);
            this.panelPhysicalExam.Controls.Add(this.panel1);
            this.panelPhysicalExam.Location = new System.Drawing.Point(0, 0);
            this.panelPhysicalExam.Name = "panelPhysicalExam";
            this.panelPhysicalExam.Size = new System.Drawing.Size(1350, 603);
            this.panelPhysicalExam.TabIndex = 0;
            this.panelPhysicalExam.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPhysicalExam_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(516, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Statement of Amount";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PIMS.Properties.Resources.LoginLbl;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(76, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 73);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PIMS.Properties.Resources.EvaluationPanelPink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDatetime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSOAref);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPhysician);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPatientName);
            this.panel1.Location = new System.Drawing.Point(96, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 480);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalBal);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(120, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 41);
            this.panel3.TabIndex = 36;
            // 
            // lblTotalBal
            // 
            this.lblTotalBal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalBal.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.lblTotalBal.Location = new System.Drawing.Point(766, 0);
            this.lblTotalBal.Name = "lblTotalBal";
            this.lblTotalBal.Size = new System.Drawing.Size(165, 39);
            this.lblTotalBal.TabIndex = 37;
            this.lblTotalBal.Text = "$$$$$$$$";
            this.lblTotalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(931, 39);
            this.label8.TabIndex = 37;
            this.label8.Text = "BALANCE DUE: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Charges,
            this.Payments});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(120, 145);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.NullValue = "----";
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(933, 239);
            this.dataGridView1.TabIndex = 35;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.FillWeight = 150F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Charges
            // 
            this.Charges.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Charges.FillWeight = 150F;
            this.Charges.HeaderText = "Charges";
            this.Charges.Name = "Charges";
            this.Charges.ReadOnly = true;
            this.Charges.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Payments
            // 
            this.Payments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Payments.FillWeight = 150F;
            this.Payments.HeaderText = "Payments";
            this.Payments.Name = "Payments";
            this.Payments.ReadOnly = true;
            this.Payments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(608, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Date/Time:";
            // 
            // txtDatetime
            // 
            this.txtDatetime.Location = new System.Drawing.Point(739, 98);
            this.txtDatetime.Name = "txtDatetime";
            this.txtDatetime.ReadOnly = true;
            this.txtDatetime.Size = new System.Drawing.Size(282, 20);
            this.txtDatetime.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(608, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(739, 56);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(282, 20);
            this.txtAge.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label7.Location = new System.Drawing.Point(608, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "SOA Reference No.";
            // 
            // txtSOAref
            // 
            this.txtSOAref.Location = new System.Drawing.Point(739, 15);
            this.txtSOAref.Name = "txtSOAref";
            this.txtSOAref.ReadOnly = true;
            this.txtSOAref.Size = new System.Drawing.Size(282, 20);
            this.txtSOAref.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(124, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Patient Address:";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(257, 98);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.ReadOnly = true;
            this.txtAdd.Size = new System.Drawing.Size(282, 20);
            this.txtAdd.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(124, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Attending Physician:";
            // 
            // txtPhysician
            // 
            this.txtPhysician.Location = new System.Drawing.Point(257, 56);
            this.txtPhysician.Name = "txtPhysician";
            this.txtPhysician.ReadOnly = true;
            this.txtPhysician.Size = new System.Drawing.Size(282, 20);
            this.txtPhysician.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(124, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(257, 15);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(282, 20);
            this.txtPatientName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label9.Location = new System.Drawing.Point(463, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(369, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "Dr Jose P. Rizal Ext, West Rembo, Taguig, 1644 Metro Manila";
            // 
            // ConsultationRecordViewSOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultationRecordViewSOA";
            this.Text = "Medical Record";
            this.Load += new System.EventHandler(this.DashboardScreen_Load);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelScroll.ResumeLayout(false);
            this.panelPhysicalExam.ResumeLayout(false);
            this.panelPhysicalExam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private CustomControls.Controls.RJButton btnContinue;
        private CustomControls.Controls.RJButton btnBack;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatetime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSOAref;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhysician;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalBal;
        private System.Windows.Forms.Label label9;
    }
}