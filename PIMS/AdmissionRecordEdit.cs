using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PIMS
{
    public partial class AdmissionRecordEdit : Form
    {
        private int patientId;
        private int admissionId;

        private string nurse;
        private string guardian;
        private string relation;
        private string dischargeDate;
        private string completeDiagnosis;
        private string ward;
        private string physician;

        public AdmissionRecordEdit()
        {
            InitializeComponent();

            string[] wards = new string[] {
                "General Ward",
                "Emergency Ward",
                "Intensive Care Unit",
                "Intensive Coronary Care Unit",
                "Nursery",
                "Special Septic Nursery",
                "Burns Ward",
                "Postoperative Ward",
                "Postnatal Ward"
            };
            cbWard.Items.AddRange(wards);

            cbWard.SelectedIndexChanged += cbWard_SelectedIndexChanged;
            this.Load += new EventHandler(DashboardScreen_Load);
        }
        dbConnection functions = new dbConnection();
        public void FetchId(int id, int id_2)
        {
            patientId = id;
            admissionId = id_2;
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            string query =
    "SELECT " +
    "a.id AS admission_id, " +
    "a.admit_date, " +
    "a.discharge_date, " +
    "a.nurse, " +
    "CONCAT(p.first_name, ' ', p.middle_name, ' ', p.last_name) AS full_name, " +
    "p.id AS patient_id, " +
    "a.guardian, " +
    "a.guardian_relation, " +
    "p.home_add, " +
    "p.mobiletelno, " +
    "a.ward, " +
    "a.physician, " +
    "a.complete_diagnosis, " +
    "a.medical_treatment, " +
    "a.med_fee, " +
    "a.admission_fee, " +
    "a.discount, " +
    "a.total_bill, " +
    "a.remarks " +
    "FROM patientinfo p " +
    "JOIN hospitaladmission a " +
    "ON p.id = a.patient_id " +
    "WHERE p.id = @patientId AND a.id = @admissionId;";

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@admissionId", admissionId);
                    using (NpgsqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            txtBP.Text = rd["admission_id"].ToString();
                            txtNurse.Text = rd["nurse"].ToString();
                            txtPatientName.Text = rd["full_name"].ToString();
                            txtGuardian.Text = rd["guardian"].ToString();
                            txtAdd.Text = rd["home_add"].ToString();
                            cbWard.Text = rd["ward"].ToString();
                            textBox11.Text = rd["admit_date"].ToString();
                            dtDischarge.Text = rd["discharge_date"].ToString();
                            txtPatientID.Text = rd["patient_id"].ToString();
                            txtRelation.Text = rd["guardian_relation"].ToString();
                            txtTelNo.Text = rd["mobiletelno"].ToString();
                            cbPhysician.Text = rd["physician"].ToString();
                            txtDiagnosis.Text = rd["complete_diagnosis"].ToString();
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

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

        private void panelPhysicalExam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdmissionRecord cr = new AdmissionRecord();
            cr.FetchId(patientId);
            cr.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            nurse = txtNurse.Text;
            guardian = txtGuardian.Text;
            relation = txtRelation.Text;
            dischargeDate = dtDischarge.Text;
            completeDiagnosis = txtDiagnosis.Text;
            ward = cbWard.Text;
            physician = cbPhysician.Text;

            this.Hide();
            AdmissionRecordEditContinuation cr = new AdmissionRecordEditContinuation();
            cr.FetchId(patientId, admissionId);
            cr.EditUpdate(nurse, guardian, relation, dischargeDate, completeDiagnosis, ward, physician);
            cr.ShowDialog();
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWard = cbWard.Text;
            string[] physicians;

            switch (selectedWard)
            {
                case "General Ward":
                    physicians = new string[] { "Dr. Alice Carter", "Dr. Benjamin Hughes", "Dr. Diana Patel", "Dr. Samuel Wong" };
                    break;
                case "Emergency Ward":
                    physicians = new string[] { "Dr. Clara Mitchell", "Dr. Jennette Margarita", "Dr. Olivia Kim", "Dr. Ethan Davis" };
                    break;
                case "Intensive Care Unit":
                    physicians = new string[] { "Dr. Laura Bennett", "Dr. Ryan Foster", "Dr. Maria Green", "Dr. David Cooper" };
                    break;
                case "Intensive Coronary Care Unit":
                    physicians = new string[] { "Dr. Karen Adams", "Dr. Michael Brown", "Dr. Athanasia Obelia", "Dr. Daniel Clark" };
                    break;
                case "Nursery":
                    physicians = new string[] { "Dr. Sebastian Michaelis", "Dr. Ciel Phantomhive", "Dr. Lily Rose", "Dr. Grell Sutcliff" };
                    break;
                case "Special Septic Nursery":
                    physicians = new string[] { "Dr. Susan Hill", "Dr. Andrew Turner", "Dr. Rachel Scott", "Dr. William White" };
                    break;
                case "Burns Ward":
                    physicians = new string[] { "Dr. Rebecca Harris", "Dr. Christopher Evans", "Dr. Anna Lopez", "Dr. Jonathan Edwards" };
                    break;
                case "Postoperative Ward":
                    physicians = new string[] { "Dr. Katherine Taylor", "Dr. Brian Morgan", "Dr. Sarah King", "Dr. Matthew Campbell" };
                    break;
                case "Postnatal Ward":
                    physicians = new string[] { "Dr. Megan Phillips", "Dr. Kevin Carter", "Dr. Sophie Bell", "Dr. Jack Murphy" };
                    break;
                default:
                    physicians = new string[] { };
                    break;
            }

            cbPhysician.Items.Clear();
            cbPhysician.Items.AddRange(physicians);
        }
    }
}
