namespace PIMS
{
    partial class PatientListSOA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientListSOA));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPrint = new CustomControls.Controls.RJButton();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.btnDone = new CustomControls.Controls.RJButton();
            this.panelSOA = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDate = new CustomControls.RJControls.RJTextBox();
            this.txtAge = new CustomControls.RJControls.RJTextBox();
            this.txtSOA = new CustomControls.RJControls.RJTextBox();
            this.txtAdd = new CustomControls.RJControls.RJTextBox();
            this.txtPhysician = new CustomControls.RJControls.RJTextBox();
            this.txtName = new CustomControls.RJControls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalBal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelScroll.SuspendLayout();
            this.panelSOA.SuspendLayout();
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
            this.panel6.Controls.Add(this.btnPrint);
            this.panel6.Controls.Add(this.panelScroll);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1370, 749);
            this.panel6.TabIndex = 1;
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
            this.btnPrint.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1193, 122);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(138, 37);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // panelScroll
            // 
            this.panelScroll.Controls.Add(this.btnDone);
            this.panelScroll.Controls.Add(this.panelSOA);
            this.panelScroll.Location = new System.Drawing.Point(12, 165);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1346, 700);
            this.panelScroll.TabIndex = 2;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnDone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnDone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDone.BorderRadius = 7;
            this.btnDone.BorderSize = 0;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(571, 606);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(246, 40);
            this.btnDone.TabIndex = 39;
            this.btnDone.Text = "DONE";
            this.btnDone.TextColor = System.Drawing.Color.White;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panelSOA
            // 
            this.panelSOA.BackColor = System.Drawing.Color.White;
            this.panelSOA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSOA.Controls.Add(this.label10);
            this.panelSOA.Controls.Add(this.label9);
            this.panelSOA.Controls.Add(this.label1);
            this.panelSOA.Controls.Add(this.panel1);
            this.panelSOA.Location = new System.Drawing.Point(29, 0);
            this.panelSOA.Name = "panelSOA";
            this.panelSOA.Size = new System.Drawing.Size(1290, 600);
            this.panelSOA.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label10.Location = new System.Drawing.Point(538, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "Harmony Medical Care";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label9.Location = new System.Drawing.Point(459, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(369, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "Dr Jose P. Rizal Ext, West Rembo, Taguig, 1644 Metro Manila";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(471, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 48);
            this.label1.TabIndex = 25;
            this.label1.Text = "Statement of Amount";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtSOA);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.Controls.Add(this.txtPhysician);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(78, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 480);
            this.panel1.TabIndex = 18;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtDate.BorderColor = System.Drawing.Color.Black;
            this.txtDate.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtDate.BorderRadius = 0;
            this.txtDate.BorderSize = 1;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.Location = new System.Drawing.Point(736, 84);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Multiline = false;
            this.txtDate.Name = "txtDate";
            this.txtDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDate.PasswordChar = false;
            this.txtDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDate.PlaceholderText = "";
            this.txtDate.Size = new System.Drawing.Size(282, 31);
            this.txtDate.TabIndex = 42;
            this.txtDate.Texts = "";
            this.txtDate.UnderlinedStyle = true;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Window;
            this.txtAge.BorderColor = System.Drawing.Color.Black;
            this.txtAge.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtAge.BorderRadius = 0;
            this.txtAge.BorderSize = 1;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAge.Location = new System.Drawing.Point(736, 45);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Multiline = false;
            this.txtAge.Name = "txtAge";
            this.txtAge.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAge.PasswordChar = false;
            this.txtAge.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAge.PlaceholderText = "";
            this.txtAge.Size = new System.Drawing.Size(282, 31);
            this.txtAge.TabIndex = 41;
            this.txtAge.Texts = "";
            this.txtAge.UnderlinedStyle = true;
            // 
            // txtSOA
            // 
            this.txtSOA.BackColor = System.Drawing.SystemColors.Window;
            this.txtSOA.BorderColor = System.Drawing.Color.Black;
            this.txtSOA.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtSOA.BorderRadius = 0;
            this.txtSOA.BorderSize = 1;
            this.txtSOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSOA.Location = new System.Drawing.Point(736, 6);
            this.txtSOA.Margin = new System.Windows.Forms.Padding(4);
            this.txtSOA.Multiline = false;
            this.txtSOA.Name = "txtSOA";
            this.txtSOA.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSOA.PasswordChar = false;
            this.txtSOA.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSOA.PlaceholderText = "";
            this.txtSOA.Size = new System.Drawing.Size(282, 31);
            this.txtSOA.TabIndex = 40;
            this.txtSOA.Texts = "";
            this.txtSOA.UnderlinedStyle = true;
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdd.BorderColor = System.Drawing.Color.Black;
            this.txtAdd.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtAdd.BorderRadius = 0;
            this.txtAdd.BorderSize = 1;
            this.txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdd.Location = new System.Drawing.Point(257, 84);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd.Multiline = false;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAdd.PasswordChar = false;
            this.txtAdd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAdd.PlaceholderText = "";
            this.txtAdd.Size = new System.Drawing.Size(282, 31);
            this.txtAdd.TabIndex = 39;
            this.txtAdd.Texts = "";
            this.txtAdd.UnderlinedStyle = true;
            // 
            // txtPhysician
            // 
            this.txtPhysician.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhysician.BorderColor = System.Drawing.Color.Black;
            this.txtPhysician.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPhysician.BorderRadius = 0;
            this.txtPhysician.BorderSize = 1;
            this.txtPhysician.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhysician.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhysician.Location = new System.Drawing.Point(257, 45);
            this.txtPhysician.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhysician.Multiline = false;
            this.txtPhysician.Name = "txtPhysician";
            this.txtPhysician.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhysician.PasswordChar = false;
            this.txtPhysician.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhysician.PlaceholderText = "";
            this.txtPhysician.Size = new System.Drawing.Size(282, 31);
            this.txtPhysician.TabIndex = 38;
            this.txtPhysician.Texts = "";
            this.txtPhysician.UnderlinedStyle = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(257, 6);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(282, 31);
            this.txtName.TabIndex = 37;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
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
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Charges
            // 
            this.Charges.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Charges.FillWeight = 150F;
            this.Charges.HeaderText = "Charges";
            this.Charges.MinimumWidth = 6;
            this.Charges.Name = "Charges";
            this.Charges.ReadOnly = true;
            this.Charges.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Payments
            // 
            this.Payments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Payments.FillWeight = 150F;
            this.Payments.HeaderText = "Payments";
            this.Payments.MinimumWidth = 6;
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
            // PatientListSOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientListSOA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Record";
            this.Load += new System.EventHandler(this.DashboardScreen_Load);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelScroll.ResumeLayout(false);
            this.panelSOA.ResumeLayout(false);
            this.panelSOA.PerformLayout();
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
        private System.Windows.Forms.Panel panelSOA;
        private CustomControls.Controls.RJButton btnDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalBal;
        private System.Windows.Forms.Label label9;
        private CustomControls.Controls.RJButton btnPrint;
        private System.Windows.Forms.Label label10;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private CustomControls.RJControls.RJTextBox txtName;
        private CustomControls.RJControls.RJTextBox txtDate;
        private CustomControls.RJControls.RJTextBox txtAge;
        private CustomControls.RJControls.RJTextBox txtSOA;
        private CustomControls.RJControls.RJTextBox txtAdd;
        private CustomControls.RJControls.RJTextBox txtPhysician;
    }
}