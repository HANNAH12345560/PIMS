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
    public partial class ConsultationRecordViewSOA : Form
    {
        private int consultationId;
        private int patientId;
        public ConsultationRecordViewSOA()
        {
            InitializeComponent();
        }

        dbConnection functions = new dbConnection();

        public void FetchId(int id, int id_2)
        {
            consultationId = id;
            patientId = id_2;
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(consultationId.ToString());
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
    "pm.balance_due, pm.philhealth_discount, sc_pwd_discount, other_discount, " +
    "SUM(mt.price) AS total_price " +
    "FROM patientinfo AS p " +
    "JOIN consultationassesment AS c ON p.id = c.patient_id " +
    "JOIN physicianevaluation AS e ON c.id = e.consultation_id " +
    "JOIN payment AS pm ON c.id = pm.consultation_id " +
    "JOIN medicaltreatment AS mt ON e.id = mt.physician_eval_id " +
    "WHERE c.id = @consultationId " +
    "GROUP BY mt.physician_eval_id, p.first_name, p.middle_name, p.last_name, " +
    "e.physician, p.home_add, pm.id, p.age, c.date, pm.consultation_fee, " +
    "pm.balance_due, pm.philhealth_discount, sc_pwd_discount, other_discount;";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@consultationId", consultationId);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtPatientName.Text = dr["full_name"].ToString();
                        txtPhysician.Text = dr["physician"].ToString();
                        txtAdd.Text = dr["home_add"].ToString();
                        txtSOAref.Text = dr["payment_id"].ToString();
                        txtAge.Text = dr["age"].ToString();
                        txtDatetime.Text = dr["date"].ToString();
                        lblTotalBal.Text = dr["balance_due"].ToString();

                        dataGridView1.Rows[0].Cells[1].Value = dr["consultation_fee"].ToString();
                        dataGridView1.Rows[1].Cells[1].Value = dr["total_price"].ToString();
                        dataGridView1.Rows[2].Cells[2].Value = dr["philhealth_discount"].ToString();
                        dataGridView1.Rows[3].Cells[2].Value = dr["sc_pwd_discount"].ToString();
                        dataGridView1.Rows[4].Cells[2].Value = dr["other_discount"].ToString();




                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void panel9_Paint(object sender, PaintEventArgs e) { }

        private void panel7_Paint(object sender, PaintEventArgs e) { }

        private void panel6_Paint(object sender, PaintEventArgs e) { }

        private void panel11_Paint(object sender, PaintEventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void panel12_Paint(object sender, PaintEventArgs e) { }

        private void label16_Click(object sender, EventArgs e) { }

        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void panelPhysicalExam_Paint(object sender, PaintEventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultationRecordViewEvaluation ce = new ConsultationRecordViewEvaluation();
            ce.FetchId(consultationId, patientId);
            ce.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultationRecord cr = new ConsultationRecord();
            cr.FetchId(patientId);
            cr.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label10_Click(object sender, EventArgs e) { }
    }
}
