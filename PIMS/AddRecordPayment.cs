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
    public partial class AddRecordPayment: Form
    {
        dbConnection functions = new dbConnection();

        private double totalPriceMed = 0.0;
        private int consultationId;
        private int patientId;

        public AddRecordPayment(int consultationId, int patientId, double totalPriceMed)
        {
            this.consultationId = consultationId;
            this.patientId = patientId;
            this.totalPriceMed = totalPriceMed;
            InitializeComponent();
        }

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



        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    AddRecordInsurance i = new AddRecordInsurance();
        //    i.ShowDialog();
        //    this.Close();
        //}

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
                                other_discount, philhealth_discount, balance_due, name
                            )
                            VALUES (
                                @consultation_id, @consultation_fee, @insurance_payment, @sc_pwd_discount, 
                                @other_discount, @philhealth_discount, @balance_due, @name
                            ) RETURNING id";

                    using (var command = new NpgsqlCommand(query, conn))
                    {

                        double tentative_balance_due = Convert.ToDouble(txtConsult.Text) + totalPriceMed;
                        double sc_pwd_discount = Math.Round(tentative_balance_due * (Convert.ToDouble(txtSCPWDiscount.Text) / 100), 2);
                        double philhealth_discount = Math.Round(tentative_balance_due * (Convert.ToDouble(txtPhilDiscount.Text) / 100), 2);
                        double other = Math.Round(tentative_balance_due * (Convert.ToDouble(txtOtherDisc.Text) / 100), 2);

                        double balance_due = Math.Round(tentative_balance_due - sc_pwd_discount - philhealth_discount - other - Convert.ToDouble(txtInsurPay.Text), 2);

                        command.Parameters.AddWithValue("consultation_id", consultationId);
                        command.Parameters.AddWithValue("consultation_fee", Math.Round(double.Parse(txtConsult.Text), 2));
                        command.Parameters.AddWithValue("insurance_payment", Math.Round(double.Parse(txtInsurPay.Text), 2));
                        command.Parameters.AddWithValue("sc_pwd_discount", sc_pwd_discount);
                        command.Parameters.AddWithValue("other_discount", other);
                        command.Parameters.AddWithValue("philhealth_discount", philhealth_discount);
                        command.Parameters.AddWithValue("balance_due", balance_due);
                        command.Parameters.AddWithValue("name", fullName);

                        int paymentId = (int)command.ExecuteScalar();

                        MessageBox.Show("Payment added successfully");

                        this.Hide();
                        AddRecordSOA ps = new AddRecordSOA(consultationId, patientId);
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


        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
