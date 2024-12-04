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
    public partial class AddRecordSOA : Form
    {
        private int consultationId;
        private int patientId;

        public AddRecordSOA(int consultationId, int patientId)
        {
            this.consultationId = consultationId;
            this.patientId = patientId;
            InitializeComponent();
        }
        dbConnection functions = new dbConnection();
        Bitmap bmp;

        private void CapturePanelShot(Panel panel)
        {
            bmp = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bmp, new Rectangle(0, 0, panel.Width, panel.Height));
        }


        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Consultation Fee");
            dataGridView1.Rows.Add("Medical Fee");
            dataGridView1.Rows.Add("Insurance Payment");
            dataGridView1.Rows.Add("PhilHealth");
            dataGridView1.Rows.Add("SC/PWD Discount");
            dataGridView1.Rows.Add("Other Discount");

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                string query =
    "SELECT CONCAT(p.first_name, ' ', p.middle_name, ' ', p.last_name) AS full_name, " +
    "e.physician, p.home_add, pm.id AS payment_id, p.age, c.date, pm.consultation_fee, " +
    "pm.balance_due, pm.philhealth_discount, pm.sc_pwd_discount, pm.other_discount, pm.insurance_payment, " +
    "SUM(mt.price) AS total_price " +
    "FROM patientinfo AS p " +
    "JOIN consultationassesment AS c ON p.id = c.patient_id " +
    "JOIN physicianevaluation AS e ON c.id = e.consultation_id " +
    "JOIN payment AS pm ON c.id = pm.consultation_id " +
    "JOIN medicaltreatment AS mt ON e.id = mt.physician_eval_id " +
    "WHERE c.id = @consultationId " +
    "GROUP BY mt.physician_eval_id, p.first_name, p.middle_name, p.last_name, " +
    "e.physician, p.home_add, pm.id, p.age, c.date, pm.consultation_fee, " +
    "pm.balance_due, pm.philhealth_discount, pm.sc_pwd_discount, pm.other_discount, pm.insurance_payment;";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@consultationId", consultationId);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TextBox txtPatientName = (TextBox)txtName.Controls[0];
                        TextBox innertxtPhysician = (TextBox)txtPhysician.Controls[0];
                        TextBox innerAdd = (TextBox)txtAdd.Controls[0];
                        TextBox innerSOAref = (TextBox)txtSOA.Controls[0];
                        TextBox innerAge = (TextBox)txtAge.Controls[0];
                        TextBox innerDate = (TextBox)txtDate.Controls[0];



                        txtPatientName.Text = dr["full_name"].ToString();
                        innertxtPhysician.Text = dr["physician"].ToString();
                        innerAdd.Text = dr["home_add"].ToString();
                        innerSOAref.Text = dr["payment_id"].ToString();
                        innerAge.Text = dr["age"].ToString();
                        innerDate.Text = dr["date"].ToString();
                        lblTotalBal.Text = string.Format("{0:n0}", dr["balance_due"]);

                        dataGridView1.Rows[0].Cells[1].Value = string.Format("{0:n0}", dr["consultation_fee"]);
                        dataGridView1.Rows[1].Cells[1].Value = string.Format("{0:n0}", dr["total_price"]);
                        dataGridView1.Rows[2].Cells[2].Value = string.Format("{0:n0}", dr["insurance_payment"]);
                        dataGridView1.Rows[3].Cells[2].Value = string.Format("{0:n0}", dr["philhealth_discount"]);
                        dataGridView1.Rows[4].Cells[2].Value = string.Format("{0:n0}", dr["sc_pwd_discount"]);
                        dataGridView1.Rows[5].Cells[2].Value = string.Format("{0:n0}", dr["other_discount"]);
                    }
                }
            }
        }


        public void InsertHospitalAdmission(int patientId)
        {
            string query = @"
                INSERT INTO HospitalAdmission 
                (patient_id, physician, complete_diagnosis, medical_treatment, med_fee, discount, total_bill, remarks, admit_date, discharge_date)
                SELECT 
                    pi.id AS patient_id,
                    pe.physician,
                    pe.diagnosis AS complete_diagnosis,
                    STRING_AGG(mt.name, ', ') AS medical_treatment,
                    COALESCE(SUM(mt.price), 0) AS med_fee,
                    COALESCE(SUM(p.sc_pwd_discount + p.other_discount + p.philhealth_discount), 0) AS discount,
                    p.balance_due AS total_bill,
                    pe.remark AS remarks,
                    pi.date_added AS admit_date,
                    ca.date AS discharge_date 
                FROM PatientInfo pi
                LEFT JOIN ConsultationAssesment ca ON ca.patient_id = pi.id
                LEFT JOIN PhysicianEvaluation pe ON pe.consultation_id = ca.id
                LEFT JOIN MedicalTreatment mt ON mt.physician_eval_id = pe.id
                LEFT JOIN Payment p ON p.consultation_id = ca.id
                WHERE pi.id = @PatientId AND pe.remark = 'Hospital Admission'
                GROUP BY pi.id, pe.physician, pe.diagnosis, p.balance_due, pe.remark, pi.date_added, ca.date";

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientId", patientId);
                    cmd.ExecuteNonQuery();
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





        private void btnPrint_Click(object sender, EventArgs e)
        {
            InsertHospitalAdmission(patientId);
            this.Hide();
            AddRecordScreen cr = new AddRecordScreen();
            cr.ShowDialog();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListScreen pl = new PatientListScreen();
            pl.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            CapturePanelShot(panelSOA);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle m = e.PageBounds;
            e.Graphics.DrawImage(bmp, m);
        }

        private void rjTextBox5__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
