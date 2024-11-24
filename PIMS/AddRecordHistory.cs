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
    public partial class AddRecordHistory : Form
    {
        private int consultationId;
        private dbConnection db = new dbConnection();

        public AddRecordHistory(int consultationId)
        {
            InitializeComponent();
            this.consultationId = consultationId;  
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            InitializeCheckBoxes();
        }

        private void InitializeCheckBoxes()
        {
            chkStatusYES_FOOD.Tag = "Row1";
            chkStatusNO_FOOD.Tag = "Row1";
            chkStatusNOTKNOWN_FOOD.Tag = "Row1";

            chkStatusNO_DRUG.Tag = "Row2";
            chkStatusYES_DRUG.Tag = "Row2";
            chkStatusNOTKNOWN_DRUG.Tag = "Row2";

            chkStatusNO_OTHER.Tag = "Row3";
            chkStatusYES_OTHER.Tag = "Row3";
            chkStatusNOTKNOWN_OTHER.Tag = "Row3";

            chkStatusNO_MD1.Tag = "Row4";
            chkStatusYES_MD1.Tag = "Row4";
            chkStatusNOTKNOWN_MD1.Tag = "Row4";

            chkStatusNO_MD2.Tag = "Row5";
            chkStatusYES_MD2.Tag = "Row5";
            chkStatusNOTKNOWN_MD2.Tag = "Row5";

            chkStatusNO_MD3.Tag = "Row6";
            chkStatusYES_MD3.Tag = "Row6";
            chkStatusNOTKNOWN_MD3.Tag = "Row6";
 
            AddCheckedChangedEventHandlers();
        }

        private void AddCheckedChangedEventHandlers()
        {
            chkStatusYES_FOOD.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNO_FOOD.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_FOOD.CheckedChanged += CheckBox_CheckedChanged;

            chkStatusNO_DRUG.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusYES_DRUG.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_DRUG.CheckedChanged += CheckBox_CheckedChanged;

            chkStatusNO_OTHER.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusYES_OTHER.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_OTHER.CheckedChanged += CheckBox_CheckedChanged;

            chkStatusNO_MD1.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusYES_MD1.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_MD1.CheckedChanged += CheckBox_CheckedChanged;

            chkStatusNO_MD2.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusYES_MD2.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_MD2.CheckedChanged += CheckBox_CheckedChanged;

            chkStatusNO_MD3.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusYES_MD3.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_MD3.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox selectedCheckbox && selectedCheckbox.Checked)
            {
                string rowIdentifier = selectedCheckbox.Tag?.ToString();

                UncheckOtherCheckBoxesInRow(tableLayoutPanel1, rowIdentifier, selectedCheckbox);
                UncheckOtherCheckBoxesInRow(tableLayoutPanel2, rowIdentifier, selectedCheckbox);
            }
        }

        private void UncheckOtherCheckBoxesInRow(TableLayoutPanel tableLayoutPanel, string rowIdentifier, CheckBox selectedCheckbox)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is CheckBox checkbox && checkbox.Tag?.ToString() == rowIdentifier && checkbox != selectedCheckbox)
                {
                    checkbox.Checked = false;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecordInitialAss ar = new AddRecordInitialAss();
            ar.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Host=localhost;Username=postgres;Password=Miyaki_11;Database=PatientManagementSystem";

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    InsertAllergyData(connection);
                    InsertMedicalHistoryData(connection);

                    MessageBox.Show("Data inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            // Optionally, you can hide the current form and show another one:
            // this.Hide();
            // AddRecordEvaluation ar = new AddRecordEvaluation();
            // ar.ShowDialog();
            // this.Close();
        }

        private void InsertMedicalHistoryData(NpgsqlConnection connection)
        {
            Action<string, CheckBox, CheckBox, CheckBox, TextBox> insertMedicalHistory =
                (type, yesCheckBox, notKnownCheckBox, noCheckBox, descriptionTextBox) =>
                {
                    string status = GetCheckBoxStatus(yesCheckBox, notKnownCheckBox, noCheckBox);

                    int medHistoryId = InsertIntoMedicalHistory(connection, type, status);

                    if (status == "Yes" && descriptionTextBox != null)
                    {
                        InsertIntoMedicalHistoryDetails(connection, medHistoryId, descriptionTextBox.Text);
                    }
                };
            insertMedicalHistory("MD1", chkStatusYES_MD1, chkStatusNOTKNOWN_MD1, chkStatusNO_MD1, txtMH1desc);
            insertMedicalHistory("MD2", chkStatusYES_MD2, chkStatusNOTKNOWN_MD2, chkStatusNO_MD2, txtMH2desc);
            insertMedicalHistory("MD3", chkStatusYES_MD3, chkStatusNOTKNOWN_MD3, chkStatusNO_MD3, txtMH3desc);
        }

        private void InsertAllergyData(NpgsqlConnection connection)
        {
            Action<string, string, TextBox> insertAllergy = (type, status, descriptionTextBox) =>
            {
                int allergyId = InsertIntoAllergies(connection, type, status);

                if (status == "Yes")
                {
                    InsertIntoAllergiesDetails(connection, allergyId, descriptionTextBox.Text);
                }
            };

            insertAllergy("DRUG", GetCheckBoxStatus(chkStatusYES_DRUG, chkStatusNOTKNOWN_DRUG, chkStatusNO_DRUG), txtDrugDesc);
            insertAllergy("FOOD", GetCheckBoxStatus(chkStatusYES_FOOD, chkStatusNOTKNOWN_FOOD, chkStatusNO_FOOD), txtFoodDesc);
            insertAllergy("OTHER", GetCheckBoxStatus(chkStatusYES_OTHER, chkStatusNOTKNOWN_OTHER, chkStatusNO_OTHER), txtOtherDesc);
        }

        private int InsertIntoAllergies(NpgsqlConnection connection, string type, string status)
        {
            string insertAllergyQuery = @"
                INSERT INTO Allergies (consultation_id, allergy_type, status)
                VALUES (@consultation_id, @allergy_type, @status)
                RETURNING id";

            using (var command = new NpgsqlCommand(insertAllergyQuery, connection))
            {
                command.Parameters.AddWithValue("consultation_id", consultationId);
                command.Parameters.AddWithValue("allergy_type", type);
                command.Parameters.AddWithValue("status", status);

                return (int)command.ExecuteScalar();
            }
        }
        private int InsertIntoMedicalHistory(NpgsqlConnection connection, string type, string status)
        {
            string insertMedHistoryQuery = @"
    INSERT INTO MedicalHistory (consultation_id, medical_history, status)
    VALUES (@consultation_id, @medical_history, @status)
    RETURNING id";

            using (var command = new NpgsqlCommand(insertMedHistoryQuery, connection))
            {
                command.Parameters.AddWithValue("consultation_id", consultationId);
                command.Parameters.AddWithValue("medical_history", type);
                command.Parameters.AddWithValue("status", status);

                return (int)command.ExecuteScalar();
            }
        }

        private void InsertIntoAllergiesDetails(NpgsqlConnection connection, int allergyId, string specificDetail)
        {
            string insertAllergyDetailQuery = @"
                INSERT INTO AllergiesDetails (allergy_id, specific_detail)
                VALUES (@allergy_id, @specific_detail)";

            using (var command = new NpgsqlCommand(insertAllergyDetailQuery, connection))
            {
                command.Parameters.AddWithValue("allergy_id", allergyId);
                command.Parameters.AddWithValue("specific_detail", specificDetail);

                command.ExecuteNonQuery();
            }
        }
        private void InsertIntoMedicalHistoryDetails(NpgsqlConnection connection, int medHistoryId, string specificDetail)
        {
            string insertMedHistoryDetailQuery = @"
    INSERT INTO MedicalHistoryDetails (med_history_id, specific_detail)
    VALUES (@med_history_id, @specific_detail)";

            using (var command = new NpgsqlCommand(insertMedHistoryDetailQuery, connection))
            {
                command.Parameters.AddWithValue("med_history_id", medHistoryId);
                command.Parameters.AddWithValue("specific_detail", specificDetail);

                command.ExecuteNonQuery();
            }
        }

        private string GetCheckBoxStatus(CheckBox yesCheckBox, CheckBox notKnownCheckBox, CheckBox noCheckBox)
        {
            if (yesCheckBox.Checked) return "Yes";
            if (notKnownCheckBox.Checked) return "Not Known";
            return "No";
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void panel9_Paint(object sender, PaintEventArgs e) { }
        private void panel7_Paint(object sender, PaintEventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void panel11_Paint(object sender, PaintEventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void panel12_Paint(object sender, PaintEventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void panelPhysicalExam_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
    }
}
