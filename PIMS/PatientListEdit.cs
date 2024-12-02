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
    public partial class PatientListEdit : Form
    {
        private int patientId;

        public PatientListEdit(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        dbConnection functions = new dbConnection();

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                string query = "SELECT * FROM patientinfo WHERE id = @patientId;";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    using (NpgsqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            patientId = Convert.ToInt32(read["id"]);
                            comboBoxStatus.Text = read["status"].ToString();
                            txtPhilHealthNo.Text = read["philhealthno"].ToString();
                            txtFirstName.Text = read["first_name"].ToString();
                            txtLastName.Text = read["last_name"].ToString();
                            txtMiddleName.Text = read["middle_name"].ToString();
                            txtAddress.Text = read["home_add"].ToString();
                            txtAge.Text = CalculateAge(Convert.ToDateTime(read["birthday"])).ToString();
                            dtpBirthdate.Text = read["birthday"].ToString();
                            txtBirthPlace.Text = read["birthplace"].ToString();
                            comboBoxCivilStatus.Text = read["civilstat"].ToString();
                            comboBoxGender.Text = read["gender"].ToString();
                            txtTelNo.Text = read["mobiletelno"].ToString();
                            txtReligion.Text = read["religion"].ToString();
                            txtOccupation.Text = read["occupation"].ToString();
                        }
                    }
                }
            }
        }

        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }
            return age;
        }

        public void HoverBtn(Button btn)
        {
            if (btn.BackColor == Color.FromArgb(255, 192, 211))
            {
                btn.BackColor = Color.FromArgb(255, 240, 245);
                btn.ForeColor = Color.FromArgb(255, 92, 141);
            }
        }

        public void HoverbtnReset(Button btn)
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnMedRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicalRecordScreen medicalRecordScreen = new MedicalRecordScreen();
            medicalRecordScreen.ShowDialog();
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListScreen pl = new PatientListScreen();
            pl.ShowDialog();
            this.Close();
        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                string query = "UPDATE patientinfo SET status = @status, philhealthno = @philhealthno, first_name = @first_name, last_name = @last_name, middle_name = @middle_name, home_add = @home_add, age = @age, birthday = @birthday, birthplace = @birthplace, civilstat = @civilstat, gender = @gender, mobiletelno = @mobiletelno, religion = @religion, occupation = @occupation WHERE id = @patientId;";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", comboBoxStatus.Text);
                    cmd.Parameters.AddWithValue("@philhealthno", txtPhilHealthNo.Text);
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@middle_name", txtMiddleName.Text);
                    cmd.Parameters.AddWithValue("@home_add", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("@birthday", DateTime.Parse(dtpBirthdate.Text));
                    cmd.Parameters.AddWithValue("@birthplace", txtBirthPlace.Text);
                    cmd.Parameters.AddWithValue("@civilstat", comboBoxCivilStatus.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBoxGender.Text);
                    cmd.Parameters.AddWithValue("@mobiletelno", txtTelNo.Text);
                    cmd.Parameters.AddWithValue("@religion", txtReligion.Text);
                    cmd.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                    cmd.Parameters.AddWithValue("@patientId", patientId);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Patient record has been updated.");

                this.Hide();
                PatientListScreen pl = new PatientListScreen();
                pl.ShowDialog();
                this.Close();
            }
        }
    }
}
