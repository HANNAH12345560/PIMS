using Npgsql;
using System.Windows.Forms;
using System;

namespace PIMS
{
    public partial class Insurance : Form
    {
        private int consultationId;
        private int patientId;
        private double totalPrice = 0.0;
        dbConnection functions = new dbConnection();

        public Insurance(int consultationId, int patientId, double totalPrice)
        {
            InitializeComponent();
            this.consultationId = consultationId;
            this.patientId = patientId;
            this.totalPrice = totalPrice;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Prescription p = new Prescription(consultationId, patientId, physicianEvaluationId);
            //p.ShowDialog();
            //this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtInsurID.Text) ||
                    string.IsNullOrWhiteSpace(txtLName.Text) ||
                    string.IsNullOrWhiteSpace(txtFName.Text) ||
                    string.IsNullOrWhiteSpace(txtInsurComp.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                string query = @"
        INSERT INTO Insurance (
            company, insurance_id, policyholder, consultation_id
        )
        VALUES (
            @company, @insurance_id, @policyholder, @consultation_id
        ) RETURNING id";

                using (var conn = new NpgsqlConnection(functions.connectDb))
                {
                    conn.Open();

                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("company", txtInsurComp.Text);
                        command.Parameters.AddWithValue("insurance_id", txtInsurID.Text);
                        command.Parameters.AddWithValue("policyholder", txtLName.Text + " " + txtFName.Text);
                        command.Parameters.AddWithValue("consultation_id", consultationId);

                        int insuranceId = (int)command.ExecuteScalar();

                        MessageBox.Show($"New insurance record added with ID: {insuranceId}");

                        this.Hide();
                        Payment pl = new Payment(consultationId, patientId, totalPrice);
                        pl.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {

        }
    }
}