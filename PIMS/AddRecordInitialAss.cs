﻿using Npgsql;
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
    public partial class AddRecordInitialAss: Form
    {
        private int patientId;
        public AddRecordInitialAss(int patientId)
        {
            this.patientId = patientId;
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

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecordScreen ars = new AddRecordScreen();
            ars.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBP.Text) || string.IsNullOrWhiteSpace(txtRR.Text) ||
                string.IsNullOrWhiteSpace(txtPR.Text) || string.IsNullOrWhiteSpace(txtTemp.Text) ||
                string.IsNullOrWhiteSpace(txtWT.Text) || string.IsNullOrWhiteSpace(txtHT.Text) ||
                string.IsNullOrWhiteSpace(txtComplaint.Text) || cbkBloodType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            int bp = Convert.ToInt32(txtBP.Text);
            int rr = Convert.ToInt32(txtRR.Text);
            int pr = Convert.ToInt32(txtPR.Text);
            int temp = Convert.ToInt32(txtTemp.Text);
            int wt = Convert.ToInt32(txtWT.Text);
            int ht = Convert.ToInt32(txtHT.Text);
            string complaint = txtComplaint.Text;
            string bloodType = cbkBloodType.SelectedItem.ToString();

            DateTime date = DateTime.Now;

            dbConnection functions = new dbConnection();

            string query = @"
        INSERT INTO ConsultationAssesment (patient_id, bp, rr, pr, temp, wt, ht, complaint, date, blood_type)
        VALUES (@patient_id, @bp, @rr, @pr, @temp, @wt, @ht, @complaint, @date, @blood_type)
        RETURNING id";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@patient_id", patientId);
                    cmd.Parameters.AddWithValue("@bp", bp);
                    cmd.Parameters.AddWithValue("@rr", rr);
                    cmd.Parameters.AddWithValue("@pr", pr);
                    cmd.Parameters.AddWithValue("@temp", temp);
                    cmd.Parameters.AddWithValue("@wt", wt);
                    cmd.Parameters.AddWithValue("@ht", ht);
                    cmd.Parameters.AddWithValue("@complaint", complaint);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@blood_type", bloodType);

                    int consultationId = (int)cmd.ExecuteScalar();

                    MessageBox.Show("Initial Assesment saved successfully!");

                    this.Hide();
                    AddRecordHistory pe = new AddRecordHistory(consultationId, patientId);
                    pe.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
