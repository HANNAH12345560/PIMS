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
    public partial class Prescription : Form
    {
        private int consultationId;
        private int patientId;

        private dbConnection db = new dbConnection(); 

        public Prescription(int consultationId, int patientId)
        {
            this.patientId = patientId;
            this.consultationId = consultationId;
            this.physicianEvaluationId = physicianEvaluationId;
            InitializeComponent();
        }

        Bitmap bmp;

        private void CapturePanelShot(Panel panel)
        {
            bmp = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bmp, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            try
            {
                string query = @"
                    SELECT last_name, first_name, middle_name, home_add, age, birthday, gender
                    FROM PatientInfo
                    WHERE id = @patient_id";

                using (var conn = new NpgsqlConnection(db.connectDb)) 
                {
                    conn.Open();

                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("patient_id", patientId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                txtName.Text = $"{reader["first_name"]} {reader["middle_name"]} {reader["last_name"]}";

                                txtAdd.Text = reader["home_add"].ToString();
                                txtAge.Text = reader["age"].ToString();
                                txtDate.Text = Convert.ToDateTime(reader["birthday"]).ToString("MM/dd/yyyy");
                                txtSex.Text = reader["gender"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Patient not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insurance i = new Insurance(consultationId, patientId);
            i.ShowDialog();
            this.Close();
        }



        private void rjButton1_Click(object sender, EventArgs e)
        {
            CapturePanelShot(PrescriptionPanel);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle m = e.PageBounds;
            e.Graphics.DrawImage(bmp, m);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListEvaluation pl = new PatientListEvaluation(consultationId, patientId);
            pl.ShowDialog();
            this.Close();
        }
    }
}