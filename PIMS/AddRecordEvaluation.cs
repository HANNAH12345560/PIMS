using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PIMS
{
    public partial class AddRecordEvaluation : Form
    {
        private int consultationId;
        private int physicianEvaluationId;
        private int patientId;
        private double totalPrice = 0.0;

        public AddRecordEvaluation(int consultationId, int physicianEvaluationId, int patientId)
        {
            InitializeComponent();
            this.consultationId = consultationId;
            this.patientId = patientId;
            this.physicianEvaluationId = physicianEvaluationId;
        }

        dbConnection db = new dbConnection();

        private void DashboardScreen_Load(object sender, EventArgs e)
        {

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
            //this.Hide();
            //AddRecordHistory ar = new AddRecordHistory();
            //ar.ShowDialog();
            //this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new NpgsqlConnection(db.connectDb))
                {
                    connection.Open();

                    UpdateDiagnosisAndRemark(
                        connection,
                        physicianEvaluationId,
                        txtComplaint.Text,
                        comboBoxAfter.SelectedItem?.ToString()
                    );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            this.Hide();
            AddRecordPrescription pre = new AddRecordPrescription(consultationId, patientId, physicianEvaluationId, totalPrice);
            pre.ShowDialog();
            this.Close();
        }

        private void UpdateDiagnosisAndRemark(NpgsqlConnection connection, int physicianEvaluationId, string diagnosis, string remark)
        {
            if (string.IsNullOrEmpty(diagnosis) || string.IsNullOrEmpty(remark))
            {
                MessageBox.Show("Please provide both a diagnosis and a remark.");
                return;
            }

            string updateQuery = @"
            UPDATE PhysicianEvaluation
            SET diagnosis = @diagnosis, remark = @remark
            WHERE id = @id";

            using (var updateCommand = new NpgsqlCommand(updateQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@id", physicianEvaluationId);
                updateCommand.Parameters.AddWithValue("@diagnosis", diagnosis);
                updateCommand.Parameters.AddWithValue("@remark", remark);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Evaluation recorded succesfully!");
                }
                else
                {
                    MessageBox.Show("No records were updated. Ensure the record exists and has NULL values for diagnosis or remark.");
                }
            }
        }


        private void txtRR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtMedName.Text) || string.IsNullOrWhiteSpace(txtDosage.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }

                    string query = @"
                INSERT INTO MedicalTreatment (
                    physician_eval_id, name, dosage, price
                )
                VALUES (
                    @physician_eval_id, @name, @dosage, @price
                ) RETURNING id";

                    using (var conn = new NpgsqlConnection(db.connectDb))
                    {
                        conn.Open();

                        using (var command = new NpgsqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("physician_eval_id", physicianEvaluationId);
                            command.Parameters.AddWithValue("name", txtMedName.Text);
                            command.Parameters.AddWithValue("dosage", int.TryParse(txtDosage.Text, out int dosage) ? dosage : 0);
                            command.Parameters.AddWithValue("price", double.TryParse(txtPrice.Text, out double price) ? price : 0.0);
                            int medicalTreatmentId = (int)command.ExecuteScalar();

                            totalPrice += price;
                        MessageBox.Show("Medical treatment added successfully");


                        txtMedName.Clear();
                            txtDosage.Clear();
                            txtPrice.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        

        //private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{
        //    panel1.AutoScroll = false;
        //    panel1.VerticalScroll.Value = vScrollBar1.Value;
        //}
    }
}
