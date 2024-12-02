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
    public partial class PatientListSOA : Form
    {
        private int consultationId;
        private int patientId;
        public PatientListSOA(int consultationId, int patientId)
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
            MessageBox.Show(consultationId.ToString());
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListScreen cr = new PatientListScreen();
            cr.ShowDialog();
            this.Close();
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
    }
}
