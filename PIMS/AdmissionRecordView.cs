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
    public partial class AdmissionRecordView : Form
    {
        private int patientId;
        private int admissionId;
        public AdmissionRecordView()
        {
            InitializeComponent();
        }
        dbConnection functions = new dbConnection();

        public void FetchId(int id, int id_2)
        {
            patientId = id;
            admissionId = id_2;
        }

        public string medTreat;
        public string remarks;
        public double medFee;
        public double addFee;
        public double discount;
        public double totalBill;



        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(admissionId.ToString());
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
                "WHERE p.id = @patientId;";

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    NpgsqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        remarks = rd["remarks"].ToString();
                        medFee = Convert.ToDouble(rd["med_fee"]);
                        addFee = rd["admission_fee"] != DBNull.Value ? Convert.ToDouble(rd["admission_fee"]) : 0.0;
                        discount = Convert.ToDouble(rd["discount"]);
                        totalBill = Convert.ToDouble(rd["total_bill"]);
                        medTreat = rd["medical_treatment"].ToString();
                        txtBP.Text = rd["admission_id"].ToString();
                        txtNurse.Text = rd["nurse"].ToString();
                        txtPatientName.Text = rd["full_name"].ToString();
                        txtGuardian.Text = rd["guardian"].ToString();
                        txtAdd.Text = rd["home_add"].ToString();
                        txtWard.Text = rd["ward"].ToString();
                        textBox11.Text = rd["admit_date"].ToString();
                        txtDischarge.Text = rd["discharge_date"].ToString();
                        txtPatientID.Text = rd["patient_id"].ToString();
                        txtRelation.Text = rd["guardian_relation"].ToString();
                        txtTelNo.Text = rd["mobiletelno"].ToString();
                        txtPhysician.Text = rd["physician"].ToString();
                        txtDiagnosis.Text = rd["complete_diagnosis"].ToString();

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
            this.Hide();
            AdmissionRecordViewContinuation cr = new AdmissionRecordViewContinuation();
            cr.FetchId(patientId, admissionId);
            cr.DisplayConn(medTreat, medFee, remarks, addFee, discount, totalBill);



            cr.ShowDialog();
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
