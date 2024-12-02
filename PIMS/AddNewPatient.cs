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
    public partial class AddNewPatient : Form
    {
        public AddNewPatient()
        {
            InitializeComponent();
        }
        dbConnection functions = new dbConnection();
        private void DashboardScreen_Load(object sender, EventArgs e)
        {

        }
        public void HoverBtn(Button btn)
        {
            if (btn.BackColor == Color.FromArgb(255, 192, 211))
            {
                btn.BackColor = Color.FromArgb(255, 240, 245);
                btn.ForeColor = Color.FromArgb(255, 92, 141);
            }
            
        }
        public void HoverbtnReset (Button btn)
        {
            btn.BackColor = Color.FromArgb(255, 192, 211);
            btn.ForeColor = Color.FromArgb(82, 74, 78);
        }
        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            HoverBtn(btnDashboard);
        }
        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            HoverbtnReset(btnDashboard);
        }
        private void btnMedRec_MouseHover(object sender, EventArgs e)
        {
            HoverBtn(btnMedRec);
        }
        private void btnMedRec_MouseLeave(object sender, EventArgs e)
        {
            HoverbtnReset(btnMedRec);
        }
        private void btnAddRec_MouseHover(object sender, EventArgs e)
        {
            HoverBtn(btnAddRec);
        }
        private void btnAddRec_MouseLeave(object sender, EventArgs e)
        {
            HoverbtnReset(btnAddRec);
        }
        private void btnPatientList_MouseHover(object sender, EventArgs e)
        {
            HoverBtn(btnPatientList);
        }
        private void btnPatientList_MouseLeave(object sender, EventArgs e)
        {
            HoverbtnReset(btnPatientList);
        }
        private void btnMedRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicalRecordScreen medicalRecordScreen = new MedicalRecordScreen();
            medicalRecordScreen.ShowDialog();
            this.Close();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardScreen newDashboard = new DashboardScreen();
            newDashboard.ShowDialog();
            this.Close();
        }
        private void btnPatientList_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListScreen edit = new PatientListScreen();
            edit.ShowDialog();
            this.Close();
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecordScreen Addrec = new AddRecordScreen();
            Addrec.ShowDialog();
            this.Close();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            txtPhilHealthNo.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtAddressS.Text = string.Empty;
            txtAge.Text = string.Empty;
            dtpBirthdate.Text = string.Empty;
            txtBirthPlace.Text = string.Empty;
            comboBoxGender.Text = string.Empty;
            comboBoxCivilStatus.Text = string.Empty;
            txtReligion.Text = string.Empty;
            txtTelNo.Text = string.Empty;
            txtOccupation.Text = string.Empty;
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                string query = @"
        INSERT INTO PatientInfo (
            status, philHealthNo, last_name, first_name, middle_name, home_add, 
            age, birthday, birthplace, civilStat, gender, religion, occupation, mobiletelno
        )
        VALUES (
            @status, @philHealthNo, @last_name, @first_name, @middle_name, @home_add, 
            @age, @birthday, @birthplace, @civilStat, @gender, @religion, @occupation, @mobileTelNo
        ) RETURNING id";  


                using (var conn = new NpgsqlConnection(functions.connectDb)) 
                {
                    conn.Open();

                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("status", comboBoxCivilStatus.SelectedItem?.ToString() ?? string.Empty);
                        command.Parameters.AddWithValue("philHealthNo", txtPhilHealthNo.Text);
                        command.Parameters.AddWithValue("last_name", txtLastName.Text);
                        command.Parameters.AddWithValue("first_name", txtFirstName.Text);
                        command.Parameters.AddWithValue("middle_name", txtMiddleName.Text);
                        command.Parameters.AddWithValue("home_add", txtAddressS.Text);
                        command.Parameters.AddWithValue("age", int.TryParse(txtAge.Text, out int age) && age > 0 ? age : (object)DBNull.Value);  
                        command.Parameters.AddWithValue("birthday", dtpBirthdate.Value.Date);
                        command.Parameters.AddWithValue("birthplace", txtBirthPlace.Text);
                        command.Parameters.AddWithValue("civilStat", comboBoxCivilStatus.SelectedItem?.ToString() ?? string.Empty);
                        command.Parameters.AddWithValue("gender", comboBoxGender.SelectedItem?.ToString() ?? string.Empty);
                        command.Parameters.AddWithValue("religion", txtReligion.Text);
                        command.Parameters.AddWithValue("occupation", txtOccupation.Text);
                        command.Parameters.AddWithValue("mobileTelNo", txtTelNo.Text);

                        int patientId = (int)command.ExecuteScalar();  

                        MessageBox.Show($"New patient added with ID: {patientId}");

                        this.Hide();
                        PatientListInitialAss pe = new PatientListInitialAss(patientId);  
                        pe.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PatientListScreen pl = new PatientListScreen();
            pl.ShowDialog();
            this.Close();
        }
        private void txtAddressS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
