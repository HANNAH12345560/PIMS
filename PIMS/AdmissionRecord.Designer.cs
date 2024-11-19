namespace PIMS
{
    partial class AdmissionRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmissionRecord));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnHospitalAdmission = new CustomControls.Controls.RJButton();
            this.btnConsultation = new CustomControls.Controls.RJButton();
            this.btnPatientInfo = new CustomControls.Controls.RJButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSearch = new CustomControls.Controls.RJButton();
            this.txtSearchName = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.AdmissionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nurse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DischargeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIEW = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
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
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::PIMS.Properties.Resources.PanelWhite;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.dataGridView1);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(19, 122);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1113, 627);
            this.panel9.TabIndex = 2;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdmissionID,
            this.Nurse,
            this.AdmissionDate,
            this.DischargeDate,
            this.VIEW,
            this.Edit});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 166);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.NullValue = "----";
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 367);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnHospitalAdmission);
            this.panel11.Controls.Add(this.btnConsultation);
            this.panel11.Controls.Add(this.btnPatientInfo);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 72);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1113, 67);
            this.panel11.TabIndex = 2;
            // 
            // btnHospitalAdmission
            // 
            this.btnHospitalAdmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnHospitalAdmission.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnHospitalAdmission.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHospitalAdmission.BorderRadius = 7;
            this.btnHospitalAdmission.BorderSize = 0;
            this.btnHospitalAdmission.FlatAppearance.BorderSize = 0;
            this.btnHospitalAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospitalAdmission.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospitalAdmission.ForeColor = System.Drawing.Color.White;
            this.btnHospitalAdmission.Location = new System.Drawing.Point(811, 18);
            this.btnHospitalAdmission.Name = "btnHospitalAdmission";
            this.btnHospitalAdmission.Size = new System.Drawing.Size(246, 40);
            this.btnHospitalAdmission.TabIndex = 3;
            this.btnHospitalAdmission.Text = "Hospital Admission";
            this.btnHospitalAdmission.TextColor = System.Drawing.Color.White;
            this.btnHospitalAdmission.UseVisualStyleBackColor = false;
            this.btnHospitalAdmission.Click += new System.EventHandler(this.btnHospitalAdmission_Click);
            // 
            // btnConsultation
            // 
            this.btnConsultation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnConsultation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnConsultation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultation.BorderRadius = 7;
            this.btnConsultation.BorderSize = 0;
            this.btnConsultation.FlatAppearance.BorderSize = 0;
            this.btnConsultation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultation.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultation.ForeColor = System.Drawing.Color.White;
            this.btnConsultation.Location = new System.Drawing.Point(425, 18);
            this.btnConsultation.Name = "btnConsultation";
            this.btnConsultation.Size = new System.Drawing.Size(246, 40);
            this.btnConsultation.TabIndex = 2;
            this.btnConsultation.Text = "Consultation";
            this.btnConsultation.TextColor = System.Drawing.Color.White;
            this.btnConsultation.UseVisualStyleBackColor = false;
            this.btnConsultation.Click += new System.EventHandler(this.btnConsultation_Click);
            // 
            // btnPatientInfo
            // 
            this.btnPatientInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnPatientInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.btnPatientInfo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPatientInfo.BorderRadius = 7;
            this.btnPatientInfo.BorderSize = 0;
            this.btnPatientInfo.FlatAppearance.BorderSize = 0;
            this.btnPatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientInfo.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientInfo.ForeColor = System.Drawing.Color.White;
            this.btnPatientInfo.Location = new System.Drawing.Point(16, 18);
            this.btnPatientInfo.Name = "btnPatientInfo";
            this.btnPatientInfo.Size = new System.Drawing.Size(246, 40);
            this.btnPatientInfo.TabIndex = 1;
            this.btnPatientInfo.Text = "Patient Information";
            this.btnPatientInfo.TextColor = System.Drawing.Color.White;
            this.btnPatientInfo.UseVisualStyleBackColor = false;
            this.btnPatientInfo.Click += new System.EventHandler(this.btnPatientInfo_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnSearch);
            this.panel10.Controls.Add(this.txtSearchName);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1113, 72);
            this.panel10.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.btnSearch.BorderRadius = 7;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PIMS.Properties.Resources.SearchIcon;
            this.btnSearch.Location = new System.Drawing.Point(965, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtSearchName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.txtSearchName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.txtSearchName.BorderRadius = 7;
            this.txtSearchName.BorderSize = 2;
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchName.Location = new System.Drawing.Point(112, 28);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchName.Multiline = false;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearchName.PasswordChar = false;
            this.txtSearchName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchName.PlaceholderText = "";
            this.txtSearchName.Size = new System.Drawing.Size(846, 31);
            this.txtSearchName.TabIndex = 2;
            this.txtSearchName.Texts = "";
            this.txtSearchName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
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
            this.lblDashboard.Text = "MEDICAL RECORD";
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
            this.panel1.BackgroundImage = global::PIMS.Properties.Resources.NavBarPanel1;
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
            this.btnLogout.Image = global::PIMS.Properties.Resources.LogoutIcon;
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
            this.btnPatientList.Image = global::PIMS.Properties.Resources.PatientListIcon;
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
            this.btnAddRec.Image = global::PIMS.Properties.Resources.AddRecIcon;
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
            this.btnMedRec.Image = global::PIMS.Properties.Resources.MedRecIcon;
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
            this.btnDashboard.Image = global::PIMS.Properties.Resources.Dashboard;
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
            this.panel3.BackgroundImage = global::PIMS.Properties.Resources.LogoPanel2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 105);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PIMS.Properties.Resources.LoginLbl;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 105);
            this.panel4.TabIndex = 1;
            // 
            // AdmissionID
            // 
            this.AdmissionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdmissionID.FillWeight = 150F;
            this.AdmissionID.HeaderText = "Admission ID";
            this.AdmissionID.Name = "AdmissionID";
            this.AdmissionID.ReadOnly = true;
            this.AdmissionID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nurse
            // 
            this.Nurse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nurse.FillWeight = 150F;
            this.Nurse.HeaderText = "Nurse";
            this.Nurse.Name = "Nurse";
            this.Nurse.ReadOnly = true;
            this.Nurse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AdmissionDate
            // 
            this.AdmissionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdmissionDate.FillWeight = 150F;
            this.AdmissionDate.HeaderText = "Admission Date";
            this.AdmissionDate.Name = "AdmissionDate";
            this.AdmissionDate.ReadOnly = true;
            this.AdmissionDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DischargeDate
            // 
            this.DischargeDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DischargeDate.FillWeight = 150F;
            this.DischargeDate.HeaderText = "Discharge Date";
            this.DischargeDate.Name = "DischargeDate";
            this.DischargeDate.ReadOnly = true;
            this.DischargeDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VIEW
            // 
            this.VIEW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VIEW.FillWeight = 150F;
            this.VIEW.HeaderText = "View";
            this.VIEW.Name = "VIEW";
            this.VIEW.ReadOnly = true;
            this.VIEW.Text = "V";
            this.VIEW.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "E";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // AdmissionRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdmissionRecord";
            this.Text = "Medical Record";
            this.Load += new System.EventHandler(this.DashboardScreen_Load);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
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
        private CustomControls.RJControls.RJTextBox txtSearchName;
        private System.Windows.Forms.Label label1;
        private CustomControls.Controls.RJButton btnSearch;
        private CustomControls.Controls.RJButton btnPatientInfo;
        private System.Windows.Forms.Panel panel11;
        private CustomControls.Controls.RJButton btnHospitalAdmission;
        private CustomControls.Controls.RJButton btnConsultation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nurse;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DischargeDate;
        private System.Windows.Forms.DataGridViewButtonColumn VIEW;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}