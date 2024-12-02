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
    public partial class PatientListEvaluation : Form
    {
        private int consultationId; 
        private int physicianEvaluationId;


        private dbConnection db = new dbConnection();

        public PatientListEvaluation(int consultationId, int physicianEvaluationId)
        {
            InitializeComponent();
           
            this.consultationId = consultationId; 
            this.physicianEvaluationId = physicianEvaluationId;
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {

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

                    MessageBox.Show("Data updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            this.Hide();
            Prescription pre = new Prescription(consultationId, physicianEvaluationId);
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
                    MessageBox.Show("Diagnosis and remark updated successfully.");
                }
                else
                {
                    MessageBox.Show("No records were updated. Ensure the record exists and has NULL values for diagnosis or remark.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListHistory pl = new PatientListHistory(physicianEvaluationId);
            pl.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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


                        MessageBox.Show($"Medical treatment added successfully with ID: {medicalTreatmentId}");

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
