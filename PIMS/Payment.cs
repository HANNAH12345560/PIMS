using System;
using System.Windows.Forms;
using Npgsql;

namespace PIMS
{
    public partial class Payment : Form
    {
        dbConnection functions = new dbConnection();

        private int consultationId;
        private int patientId;

        public Payment(int consultationId, int patientId)
        {
            this.consultationId = consultationId;
            this.patientId = patientId;
            InitializeComponent();
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insurance i = new Insurance(consultationId, patientId);
            i.ShowDialog();
            this.Close();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtConsult.Text) || string.IsNullOrWhiteSpace(txtInsurPay.Text) ||
                    string.IsNullOrWhiteSpace(txtSCPWDiscount.Text) || string.IsNullOrWhiteSpace(txtOtherDisc.Text) ||
                    string.IsNullOrWhiteSpace(txtPhilDiscount.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                string getNameQuery = @"
                SELECT 
                    CONCAT(last_name, ', ', first_name, ' ', middle_name) AS full_name
                FROM PatientInfo
                WHERE id = @patient_id";

                string fullName = "";

                using (var conn = new NpgsqlConnection(functions.connectDb))
                {
                    conn.Open();

                    using (var nameCommand = new NpgsqlCommand(getNameQuery, conn))
                    {
                        nameCommand.Parameters.AddWithValue("patient_id", patientId);

                        var result = nameCommand.ExecuteScalar();
                        if (result != null)
                        {
                            fullName = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Patient ID not found.");
                            return;
                        }
                    }
                    string query = @"
                    INSERT INTO Payment (
                        consultation_id, consultation_fee, insurance_payment, sc_pwd_discount, 
                        other_discount, philhealth_discount, name
                    )
                    VALUES (
                        @consultation_id, @consultation_fee, @insurance_payment, @sc_pwd_discount, 
                        @other_discount, @philhealth_discount, @name
                    ) RETURNING id";

                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("consultation_id", consultationId);
                        command.Parameters.AddWithValue("consultation_fee", double.Parse(txtConsult.Text));
                        command.Parameters.AddWithValue("insurance_payment", double.Parse(txtInsurPay.Text));
                        command.Parameters.AddWithValue("sc_pwd_discount", double.Parse(txtSCPWDiscount.Text));
                        command.Parameters.AddWithValue("other_discount", double.Parse(txtOtherDisc.Text));
                        command.Parameters.AddWithValue("philhealth_discount", double.Parse(txtPhilDiscount.Text));
                        command.Parameters.AddWithValue("name", fullName);

                        int paymentId = (int)command.ExecuteScalar();

                        MessageBox.Show($"New payment added with ID: {paymentId}");

                        this.Hide();
                        PatientListSOA ps = new PatientListSOA();
                        ps.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
