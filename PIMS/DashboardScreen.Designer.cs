namespace PIMS
{
    partial class DashboardScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardScreen));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblTtlRevenue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblTtlPresc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblTtlAppointment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblTtlPatients = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogout = new CustomControls.Controls.RJButton();
            this.btnPatientList = new CustomControls.Controls.RJButton();
            this.btnAddRec = new CustomControls.Controls.RJButton();
            this.btnMedRec = new CustomControls.Controls.RJButton();
            this.btnDashboard = new CustomControls.Controls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(226, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1144, 749);
            this.panel6.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.panel14);
            this.panel9.Controls.Add(this.panel16);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(32, 140);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1087, 577);
            this.panel9.TabIndex = 2;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // panel14
            // 
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel14.Controls.Add(this.lblTtlRevenue);
            this.panel14.Controls.Add(this.label7);
            this.panel14.Location = new System.Drawing.Point(432, 333);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(252, 197);
            this.panel14.TabIndex = 8;
            // 
            // lblTtlRevenue
            // 
            this.lblTtlRevenue.AutoSize = true;
            this.lblTtlRevenue.Font = new System.Drawing.Font("Poppins SemiBold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.lblTtlRevenue.Location = new System.Drawing.Point(3, 38);
            this.lblTtlRevenue.Name = "lblTtlRevenue";
            this.lblTtlRevenue.Size = new System.Drawing.Size(193, 141);
            this.lblTtlRevenue.TabIndex = 1;
            this.lblTtlRevenue.Text = "150";
            this.lblTtlRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTtlRevenue.Click += new System.EventHandler(this.lblTtlRevenue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(56, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "    Total Revenue";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel16
            // 
            this.panel16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel16.BackgroundImage")));
            this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel16.Controls.Add(this.lblTtlPresc);
            this.panel16.Controls.Add(this.label6);
            this.panel16.Location = new System.Drawing.Point(115, 333);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(252, 197);
            this.panel16.TabIndex = 7;
            // 
            // lblTtlPresc
            // 
            this.lblTtlPresc.AutoSize = true;
            this.lblTtlPresc.Font = new System.Drawing.Font("Poppins SemiBold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlPresc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.lblTtlPresc.Location = new System.Drawing.Point(37, 38);
            this.lblTtlPresc.Name = "lblTtlPresc";
            this.lblTtlPresc.Size = new System.Drawing.Size(193, 141);
            this.lblTtlPresc.TabIndex = 1;
            this.lblTtlPresc.Text = "150";
            this.lblTtlPresc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(56, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "    Total Prescriptions";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel12.Controls.Add(this.lblTtlAppointment);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Location = new System.Drawing.Point(432, 112);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(252, 197);
            this.panel12.TabIndex = 6;
            // 
            // lblTtlAppointment
            // 
            this.lblTtlAppointment.AutoSize = true;
            this.lblTtlAppointment.Font = new System.Drawing.Font("Poppins SemiBold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.lblTtlAppointment.Location = new System.Drawing.Point(37, 38);
            this.lblTtlAppointment.Name = "lblTtlAppointment";
            this.lblTtlAppointment.Size = new System.Drawing.Size(193, 141);
            this.lblTtlAppointment.TabIndex = 1;
            this.lblTtlAppointment.Text = "150";
            this.lblTtlAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(56, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "    Total Consultation";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel13.BackgroundImage")));
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel13.Controls.Add(this.lblTtlPatients);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Location = new System.Drawing.Point(115, 112);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(252, 197);
            this.panel13.TabIndex = 5;
            // 
            // lblTtlPatients
            // 
            this.lblTtlPatients.AutoSize = true;
            this.lblTtlPatients.Font = new System.Drawing.Font("Poppins SemiBold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlPatients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.lblTtlPatients.Location = new System.Drawing.Point(37, 36);
            this.lblTtlPatients.Name = "lblTtlPatients";
            this.lblTtlPatients.Size = new System.Drawing.Size(193, 141);
            this.lblTtlPatients.TabIndex = 1;
            this.lblTtlPatients.Text = "150";
            this.lblTtlPatients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTtlPatients.Click += new System.EventHandler(this.lblTtlPatients_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(56, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "    Total Patients";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(709, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome to Harmony Medical Care!";
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Location = new System.Drawing.Point(707, 150);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(323, 397);
            this.panel10.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblDashboard);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 21);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1144, 84);
            this.panel8.TabIndex = 1;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDashboard.Font = new System.Drawing.Font("Poppins SemiBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(0, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(1144, 84);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "DASHBOARD";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1144, 21);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 749);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btnLogout);
            this.panel5.Controls.Add(this.btnPatientList);
            this.panel5.Controls.Add(this.btnAddRec);
            this.panel5.Controls.Add(this.btnMedRec);
            this.panel5.Controls.Add(this.btnDashboard);
            this.panel5.Location = new System.Drawing.Point(12, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 609);
            this.panel5.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(0, 493);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 54);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // btnPatientList
            // 
            this.btnPatientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btnPatientList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btnPatientList.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPatientList.BorderRadius = 10;
            this.btnPatientList.BorderSize = 0;
            this.btnPatientList.FlatAppearance.BorderSize = 0;
            this.btnPatientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientList.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.btnPatientList.Image = ((System.Drawing.Image)(resources.GetObject("btnPatientList.Image")));
            this.btnPatientList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientList.Location = new System.Drawing.Point(0, 228);
            this.btnPatientList.Name = "btnPatientList";
            this.btnPatientList.Size = new System.Drawing.Size(200, 54);
            this.btnPatientList.TabIndex = 3;
            this.btnPatientList.Text = "  Patient List";
            this.btnPatientList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatientList.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.btnPatientList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatientList.UseVisualStyleBackColor = false;
            this.btnPatientList.Click += new System.EventHandler(this.btnPatientList_Click);
            this.btnPatientList.MouseLeave += new System.EventHandler(this.btnPatientList_MouseLeave);
            this.btnPatientList.MouseHover += new System.EventHandler(this.btnPatientList_MouseHover);
            // 
            // btnAddRec
            // 
            this.btnAddRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btnAddRec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btnAddRec.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddRec.BorderRadius = 10;
            this.btnAddRec.BorderSize = 0;
            this.btnAddRec.FlatAppearance.BorderSize = 0;
            this.btnAddRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRec.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.btnAddRec.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRec.Image")));
            this.btnAddRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRec.Location = new System.Drawing.Point(0, 148);
            this.btnAddRec.Name = "btnAddRec";
            this.btnAddRec.Size = new System.Drawing.Size(200, 54);
            this.btnAddRec.TabIndex = 2;
            this.btnAddRec.Text = "   Add Record";
            this.btnAddRec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRec.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.btnAddRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRec.UseVisualStyleBackColor = false;
            this.btnAddRec.Click += new System.EventHandler(this.btnAddRec_Click);
            this.btnAddRec.MouseLeave += new System.EventHandler(this.btnAddRec_MouseLeave);
            this.btnAddRec.MouseHover += new System.EventHandler(this.btnAddRec_MouseHover);
            // 
            // btnMedRec
            // 
            this.btnMedRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btnMedRec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btnMedRec.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMedRec.BorderRadius = 10;
            this.btnMedRec.BorderSize = 0;
            this.btnMedRec.FlatAppearance.BorderSize = 0;
            this.btnMedRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedRec.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.btnMedRec.Image = ((System.Drawing.Image)(resources.GetObject("btnMedRec.Image")));
            this.btnMedRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedRec.Location = new System.Drawing.Point(0, 72);
            this.btnMedRec.Name = "btnMedRec";
            this.btnMedRec.Size = new System.Drawing.Size(200, 54);
            this.btnMedRec.TabIndex = 1;
            this.btnMedRec.Text = "   Medical Record";
            this.btnMedRec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedRec.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.btnMedRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedRec.UseVisualStyleBackColor = false;
            this.btnMedRec.Click += new System.EventHandler(this.btnMedRec_Click);
            this.btnMedRec.MouseLeave += new System.EventHandler(this.btnMedRec_MouseLeave);
            this.btnMedRec.MouseHover += new System.EventHandler(this.btnMedRec_MouseHover);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btnDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.BorderSize = 0;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 54);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(74)))), ((int)(((byte)(78)))));
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnDashboard_MouseLeave);
            this.btnDashboard.MouseHover += new System.EventHandler(this.btnDashboard_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 120);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 105);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 105);
            this.panel4.TabIndex = 1;
            // 
            // DashboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardScreen_Load);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private CustomControls.Controls.RJButton btnDashboard;
        private CustomControls.Controls.RJButton btnMedRec;
        private CustomControls.Controls.RJButton btnAddRec;
        private CustomControls.Controls.RJButton btnPatientList;
        private CustomControls.Controls.RJButton btnLogout;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblTtlAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTtlPatients;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblTtlPresc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblTtlRevenue;
        private System.Windows.Forms.Label label7;
    }
}