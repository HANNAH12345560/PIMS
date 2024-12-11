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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PIMS
{

    public partial class AdmissionRecordEditContinuation : Form
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

        public AdmissionRecordEditContinuation()
        {
            InitializeComponent();
        }

        dbConnection functions = new dbConnection();
        public void FetchId(int id, int id_2)
        {
            patientId = id;
            admissionId = id_2;
        }

        public void EditUpdate(string nurse, string guardian, string relation, string dischargeDate, string completeDiagnosis, string ward, string physician)
        {
            this.nurse = nurse;
            this.guardian = guardian;
            this.relation = relation;
            this.dischargeDate = dischargeDate;
            this.completeDiagnosis = completeDiagnosis;
            this.ward = ward;
            this.physician = physician;
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            //string debug = ($"{nurse}, {guardian}, {relation}, {ward}, {physician}");
            //MessageBox.Show(debug);

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
                            txtRemarks.Text = rd["remarks"].ToString();
                            txtMedFee.Text = rd["med_fee"].ToString();
                            txtAdmissionFee.Text = rd["admission_fee"].ToString();
                            txtDiscount.Text = rd["discount"].ToString();
                            txtTotalBill.Text = rd["total_bill"].ToString();
                            txtMedTreatment.Text = rd["medical_treatment"].ToString();
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
            AdmissionRecordEdit cr = new AdmissionRecordEdit();
            cr.FetchId(patientId, admissionId);
            cr.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            DateTime dischargeDate = DateTime.Parse(this.dischargeDate);

            double medFee = double.Parse(txtMedFee.Text);
            double admissionFee = string.IsNullOrEmpty(txtAdmissionFee.Text) ? 0 : double.Parse(txtAdmissionFee.Text);
            double discountPercentage = double.Parse(txtDiscount.Text);
            double discount = (medFee + admissionFee) * (discountPercentage / 100);
            double totalBill = medFee + admissionFee - discount;

            txtTotalBill.Text = totalBill.ToString();

            string updateQuery = "UPDATE hospitaladmission SET admission_fee = @admissionFee, total_bill = @totalBill, nurse = @nurse, guardian = @guardian, guardian_relation = @relation, discharge_date = @dischargeDate, complete_diagnosis = @completeDiagnosis, ward = @ward, physician = @physician, medical_treatment = @medicalTreatment, remarks = @remarks, med_fee = @medFee, discount = @discount WHERE id = @admissionId;";

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@admissionFee", admissionFee);
                    cmd.Parameters.AddWithValue("@totalBill", totalBill);
                    cmd.Parameters.AddWithValue("@admissionId", admissionId);
                    cmd.Parameters.AddWithValue("@nurse", nurse);
                    cmd.Parameters.AddWithValue("@guardian", guardian);
                    cmd.Parameters.AddWithValue("@relation", relation);
                    cmd.Parameters.AddWithValue("@dischargeDate", dischargeDate);
                    cmd.Parameters.AddWithValue("@completeDiagnosis", completeDiagnosis);
                    cmd.Parameters.AddWithValue("@ward", ward);
                    cmd.Parameters.AddWithValue("@physician", physician);
                    cmd.Parameters.AddWithValue("@medicalTreatment", txtMedTreatment.Text);
                    cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);
                    cmd.Parameters.AddWithValue("@medFee", medFee);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Patient Record has been Updated");

            this.Hide();
            AdmissionRecord cr = new AdmissionRecord();
            cr.FetchId(patientId);
            cr.ShowDialog();
            this.Close();
        }

        private void txtMedFee_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAdmissionFee_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
