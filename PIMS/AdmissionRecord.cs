using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    public partial class AdmissionRecord : Form
    {
        private int patientId;

        public AdmissionRecord()
        {
            InitializeComponent();
        }
        dbConnection functions = new dbConnection();
        public void FetchId(int id)
        {
            patientId = id;
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            string query = "SELECT id, nurse, TO_CHAR(admit_date, 'YYYY-MM-DD') AS admit_date, " +
                           "TO_CHAR(discharge_date, 'YYYY-MM-DD') AS discharge_date " +
                           "FROM hospitaladmission WHERE patient_id = @patientId";

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@patientId", patientId);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                }
            }

        }



        public void HoverBtn(Button btn)
        {
            if (btn.BackColor == Color.FromArgb(255, 192, 211))
            {
                btn.BackColor = Color.FromArgb(255, 240, 245);
                btn.ForeColor = Color.FromArgb(255, 92, 141);
            }
            
        }

        public void HoverbtnReset (Button btn)
        {
            btn.BackColor = Color.FromArgb(255, 192, 211);
            btn.ForeColor = Color.FromArgb(82, 74, 78);
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            HoverBtn(btnDashboard);
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            HoverbtnReset(btnDashboard);
        }


        private void btnMedRec_MouseHover(object sender, EventArgs e)
        {
            HoverBtn(btnMedRec);
        }

        private void btnMedRec_MouseLeave(object sender, EventArgs e)
        {
            HoverbtnReset(btnMedRec);
        }

        private void btnAddRec_MouseHover(object sender, EventArgs e)
        {
            HoverBtn(btnAddRec);
        }

        private void btnAddRec_MouseLeave(object sender, EventArgs e)
        {
            HoverbtnReset(btnAddRec);
        }

        private void btnPatientList_MouseHover(object sender, EventArgs e)
        {
            HoverBtn(btnPatientList);
        }

        private void btnPatientList_MouseLeave(object sender, EventArgs e)
        {
            HoverbtnReset(btnPatientList);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMedRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicalRecordScreen medicalRecordScreen = new MedicalRecordScreen();
            medicalRecordScreen.ShowDialog();
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardScreen newDashboard = new DashboardScreen();
            newDashboard.ShowDialog();
            this.Close();
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListScreen edit = new PatientListScreen();
            edit.ShowDialog();
            this.Close();
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecordScreen Addrec = new AddRecordScreen();
            Addrec.ShowDialog();
            this.Close();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPatientInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicalRecordScreen medicalRecordScreen = new MedicalRecordScreen();
            medicalRecordScreen.ShowDialog();
            this.Close();
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultationRecord con = new ConsultationRecord();
            con.FetchId(patientId);
            con.ShowDialog();
            this.Close();
        }

        private void btnHospitalAdmission_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdmissionRecord hr = new AdmissionRecord();
            hr.FetchId(patientId);
            hr.ShowDialog();
            this.Close();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["View"].Index && e.RowIndex >= 0)
            {
                int selectedConsultationRecord = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["AdmissionID"].Value.ToString());

                this.Hide();
                AdmissionRecordView consultationRecordView = new AdmissionRecordView();
                consultationRecordView.FetchId(patientId, selectedConsultationRecord);
                consultationRecordView.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int selectedConsultationRecord = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["AdmissionID"].Value.ToString());

                this.Hide();
                AdmissionRecordEdit editAdmissionRecord = new AdmissionRecordEdit();
                editAdmissionRecord.FetchId(patientId, selectedConsultationRecord);
                editAdmissionRecord.ShowDialog();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
