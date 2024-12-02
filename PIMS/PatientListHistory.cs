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
    public partial class PatientListHistory : Form
    {
        private int consultationId;
        private int patientId;
        private dbConnection db = new dbConnection();

        public PatientListHistory(int consultationId, int patientId)
        {
            InitializeComponent();
            this.consultationId = consultationId;
            this.patientId = patientId;
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
            AddNewPatient pl = new AddNewPatient();
            pl.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                int physicianEvalId;
                using (var connection = new NpgsqlConnection(db.connectDb))
                {
                    connection.Open();
                    InsertAllergyData(connection);
                    InsertMedicalHistoryData(connection);
                    physicianEvalId = InsertPhysicianEvaluation(consultationId, connection);

                    MessageBox.Show("Data inserted successfully.");
                }
                this.Hide();
                PatientListEvaluation pl = new PatientListEvaluation(consultationId, physicianEvalId, patientId);
                pl.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private int InsertPhysicianEvaluation(int consultationId, NpgsqlConnection connection)
        {
            string physician = comboBoxPhysician.SelectedItem?.ToString() ?? string.Empty;

            string query = @"
                INSERT INTO PhysicianEvaluation (
                    consultation_id, physician
                )
                VALUES (
                    @consultation_id, @physician
                ) RETURNING id";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@consultation_id", consultationId);
                command.Parameters.AddWithValue("@physician", physician);

                int physicianEvalId = (int)command.ExecuteScalar();

                MessageBox.Show("Patient successfully assigned to physician");
                return physicianEvalId;
            }
        }


        private void InsertMedicalHistoryData(NpgsqlConnection connection)
        {
            Action<string, CheckBox, CheckBox, CheckBox, TextBox> insertMedicalHistory =
                (type, yesCheckBox, notKnownCheckBox, noCheckBox, descriptionTextBox) =>
                {
                    string status = GetCheckBoxStatus(yesCheckBox, notKnownCheckBox, noCheckBox);

                    int medHistoryId = InsertIntoMedicalHistory(connection, type, status);

                    if (status == "yes" && descriptionTextBox != null)
                    {
                        InsertIntoMedicalHistoryDetails(connection, medHistoryId, descriptionTextBox.Text);
                    }
                };
            insertMedicalHistory("previous", chkStatusYES_MD1, chkStatusNOTKNOWN_MD1, chkStatusNO_MD1, txtMH1desc);
            insertMedicalHistory("current", chkStatusYES_MD2, chkStatusNOTKNOWN_MD2, chkStatusNO_MD2, txtMH2desc);
            insertMedicalHistory("family", chkStatusYES_MD3, chkStatusNOTKNOWN_MD3, chkStatusNO_MD3, txtMH3desc);
        }

        private void InsertAllergyData(NpgsqlConnection connection)
        {
            Action<string, string, TextBox> insertAllergy = (type, status, descriptionTextBox) =>
            {
                int allergyId = InsertIntoAllergies(connection, type, status);

                if (status == "yes")
                {
                    InsertIntoAllergiesDetails(connection, allergyId, descriptionTextBox.Text);
                }
            };

            insertAllergy("drug", GetCheckBoxStatus(chkStatusYES_DRUG, chkStatusNOTKNOWN_DRUG, chkStatusNO_DRUG), txtDrugDesc);
            insertAllergy("food", GetCheckBoxStatus(chkStatusYES_FOOD, chkStatusNOTKNOWN_FOOD, chkStatusNO_FOOD), txtFoodDesc);
            insertAllergy("other", GetCheckBoxStatus(chkStatusYES_OTHER, chkStatusNOTKNOWN_OTHER, chkStatusNO_OTHER), txtOtherDesc);
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
            if (yesCheckBox.Checked) return "yes";
            if (notKnownCheckBox.Checked) return "not_known";
            return "no";
        }
    }
}