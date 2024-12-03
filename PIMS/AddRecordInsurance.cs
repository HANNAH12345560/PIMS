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
    public partial class AddRecordInsurance: Form
    {
        private int consultationId;
        private int patientId;
        private double totalPrice = 0.0;
        dbConnection functions = new dbConnection();

        public AddRecordInsurance(int consultationId, int patientId, double totalPrice)
        {
            InitializeComponent();
            this.consultationId = consultationId;
            this.patientId = patientId;
            this.totalPrice = totalPrice;
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

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //AddRecordPrescription p = new AddRecordPrescription();
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

                        MessageBox.Show("Insurance record added");

                        this.Hide();
                        AddRecordPayment pl = new AddRecordPayment(consultationId, patientId, totalPrice);
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
    }
}
