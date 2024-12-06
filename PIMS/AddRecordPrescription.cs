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
    public partial class AddRecordPrescription : Form
    {
        private double totalPrice = 0.0;
        private int consultationId;
        private int patientId;
        private int physicianEvaluationId;

        private dbConnection db = new dbConnection();

        public AddRecordPrescription(int consultationId, int patientId, int physicianEvaluationId, double totalPrice)
        {
            this.patientId = patientId;
            this.consultationId = consultationId;
            this.physicianEvaluationId = physicianEvaluationId;
            InitializeComponent();
            this.physicianEvaluationId = physicianEvaluationId;
            this.totalPrice = totalPrice;
        }

        Bitmap bmp;

        private void CapturePanelShot(Panel panel)
        {
            bmp = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bmp, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(physicianEvaluationId.ToString());

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
                        command.Parameters.AddWithValue("@patient_id", patientId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TextBox innerName = (TextBox)txtName.Controls[0];
                                TextBox innerAdd = (TextBox)txtAdd.Controls[0];
                                TextBox innerAge = (TextBox)txtAge.Controls[0];
                                TextBox innerDate = (TextBox)txtDate.Controls[0];
                                TextBox innerSex = (TextBox)txtSex.Controls[0];

                                innerName.Text = $"{reader["first_name"]} {reader["middle_name"]} {reader["last_name"]}";
                                innerAdd.Text = reader["home_add"].ToString();
                                innerAge.Text = reader["age"].ToString();
                                innerDate.Text = Convert.ToDateTime(reader["birthday"]).ToString("MM/dd/yyyy");
                                innerSex.Text = reader["gender"].ToString();
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


            //medicine display
            try
            {
                string queryMed = @"
                        SELECT * 
                        FROM medicaltreatment
                        WHERE physician_eval_id = @physicianEvaluationId";

                using (var conn = new NpgsqlConnection(db.connectDb))
                {
                    conn.Open();

                    using (var command = new NpgsqlCommand(queryMed, conn))
                    {
                        command.Parameters.AddWithValue("@physicianEvaluationId", physicianEvaluationId);

                        using (var reader = command.ExecuteReader())
                        {
                            int yOffset = 340;
                            while (reader.Read())
                            {


                                Label MedName = new Label();
                                MedName.Location = new Point(225, yOffset);
                                MedName.Text = reader["name"].ToString();
                                MedName.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                                MedName.AutoSize = true;
                                MedName.ForeColor = Color.Black;
                                MedName.BackColor = Color.Transparent;
                                this.PrescriptionPanel.Controls.Add(MedName);

                                Label Dosage = new Label();
                                Dosage.Location = new Point(416, yOffset);
                                Dosage.Text = reader["dosage"].ToString()+" ml";
                                Dosage.AutoSize = true;
                                Dosage.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                                Dosage.ForeColor = Color.Black;
                                Dosage.BackColor = Color.Transparent;
                                this.PrescriptionPanel.Controls.Add(Dosage);

                                yOffset += 30;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //physician name
            try
            {
                string query = @"
                        SELECT * FROM physicianevaluation WHERE consultation_id = @consultationId";

                using (var conn = new NpgsqlConnection(db.connectDb))
                {
                    conn.Open();

                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@consultationId", consultationId);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtPhysicianName.TextAlign = ContentAlignment.MiddleCenter;
                                txtPhysicianName.Text = reader["physician"].ToString();
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

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPhysician_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rjTextBox5__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            CapturePanelShot(PrescriptionPanel); // Assuming panelPrescription is the panel you want to print
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle m = e.PageBounds;
            e.Graphics.DrawImage(bmp, m);
        }

        private void btnBack_Click_2(object sender, EventArgs e)
        {
            //this.Hide();
            //AddRecordEvaluation pe = new AddRecordEvaluation();
            //pe.ShowDialog();
            //this.Close();
        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddRecordInsurance pe = new AddRecordInsurance(consultationId, patientId, totalPrice);
            pe.ShowDialog();
            this.Close();
        }
    }
}
