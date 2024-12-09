using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PIMS
{
    public partial class MedicalRecordScreen : Form
    {
        public MedicalRecordScreen()
        {
            InitializeComponent();
        }

        dbConnection functions = new dbConnection();
        string querySearch;
        private static Dictionary<string, string> patientInfoCache = new Dictionary<string, string>();
        public int patientId;

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            if (patientInfoCache.Count > 0)
            {
                patientId = Convert.ToInt32(patientInfoCache["id"]);
                lblStatus.Text = patientInfoCache["status"];
                txtPhilHealthNo.Text = patientInfoCache["philhealthno"];
                txtFirstName.Text = patientInfoCache["first_name"];
                txtLastName.Text = patientInfoCache["last_name"];
                txtMiddleName.Text = patientInfoCache["middle_name"];
                txtAddress.Text = patientInfoCache["home_add"];
                txtAge.Text = patientInfoCache["age"];
                txtBirthdate.Text = patientInfoCache["birthday"];
                txtBirthPlace.Text = patientInfoCache["birthplace"];
                txtCivilStatus.Text = patientInfoCache["civilstat"];
                txtGender.Text = patientInfoCache["gender"];
                txtTel.Text = patientInfoCache["mobiletelno"];
                txtReligion.Text = patientInfoCache["religion"];
                txtOccup.Text = patientInfoCache["occupation"];
            }
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
            patientInfoCache.Clear();
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
            patientInfoCache.Clear();
            this.Hide();
            DashboardScreen newDashboard = new DashboardScreen();
            newDashboard.ShowDialog();
            this.Close();
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            patientInfoCache.Clear();
            this.Hide();
            PatientListScreen edit = new PatientListScreen();
            edit.ShowDialog();
            this.Close();
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            patientInfoCache.Clear();
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

        private void btnPatientInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            CachePatientInfo();
            MedicalRecordScreen medicalRecordScreen = new MedicalRecordScreen();
            medicalRecordScreen.ShowDialog();
            this.Close();
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            this.Hide();
            CachePatientInfo();
            ConsultationRecord cr = new ConsultationRecord();
            cr.FetchId(patientId);
            cr.ShowDialog();
            this.Close();
        }

        private void btnHospitalAdmission_Click(object sender, EventArgs e)
        {
            this.Hide();
            CachePatientInfo();
            AdmissionRecord hr = new AdmissionRecord();
            hr.FetchId(patientId);
            hr.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearchName__TextChanged(object sender, EventArgs e)
        {
            querySearch = "SELECT * FROM patientinfo";

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(querySearch, conn))
                {
                    var source = new AutoCompleteStringCollection();

                    using (NpgsqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            string fullname = read["first_name"].ToString() + " " + read["middle_name"].ToString() + " " + read["last_name"].ToString();
                            source.Add(fullname);
                        }
                    }

                    TextBox innerTextBox = (TextBox)txtSearchName.Controls[0];
                    innerTextBox.AutoCompleteCustomSource = source;
                    innerTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    innerTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TextBox innerTextBox = (TextBox)txtSearchName.Controls[0];
            string search = innerTextBox.Text;

            if (string.IsNullOrWhiteSpace(search))
            {
                MessageBox.Show("Please enter a name to search");
            }
            else
            {
                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
                    {
                        conn.Open();
                        querySearch = "SELECT * FROM patientinfo WHERE first_name || ' ' || middle_name || ' ' || last_name = @search";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(querySearch, conn))
                        {
                            cmd.Parameters.AddWithValue("@search", search);
                            using (NpgsqlDataReader read = cmd.ExecuteReader())
                            {
                                if (read.Read())
                                {
                                    patientId = Convert.ToInt32(read["id"]);
                                    lblStatus.Text = read["status"].ToString();
                                    txtPhilHealthNo.Text = read["philhealthno"].ToString();
                                    txtFirstName.Text = read["first_name"].ToString();
                                    txtLastName.Text = read["last_name"].ToString();
                                    txtMiddleName.Text = read["middle_name"].ToString();
                                    txtAddress.Text = read["home_add"].ToString();
                                    txtAge.Text = read["age"].ToString();
                                    txtBirthdate.Text = Convert.ToDateTime(read["birthday"]).ToString("yyyy-MM-dd");
                                    txtBirthPlace.Text = read["birthplace"].ToString();
                                    txtCivilStatus.Text = read["civilstat"].ToString();
                                    txtGender.Text = read["gender"].ToString();
                                    txtTel.Text = read["mobiletelno"].ToString();
                                    txtReligion.Text = read["religion"].ToString();
                                    txtOccup.Text = read["occupation"].ToString();

                                    CachePatientInfo();
                                }
                                else
                                {
                                    MessageBox.Show("Patient not found.");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CachePatientInfo()
        {
            patientInfoCache["id"] = patientId.ToString();
            patientInfoCache["status"] = lblStatus.Text;
            patientInfoCache["philhealthno"] = txtPhilHealthNo.Text;
            patientInfoCache["first_name"] = txtFirstName.Text;
            patientInfoCache["last_name"] = txtLastName.Text;
            patientInfoCache["middle_name"] = txtMiddleName.Text;
            patientInfoCache["home_add"] = txtAddress.Text;
            patientInfoCache["age"] = txtAge.Text;
            patientInfoCache["birthday"] = txtBirthdate.Text;
            patientInfoCache["birthplace"] = txtBirthPlace.Text;
            patientInfoCache["civilstat"] = txtCivilStatus.Text;
            patientInfoCache["gender"] = txtGender.Text;
            patientInfoCache["mobiletelno"] = txtTel.Text;
            patientInfoCache["religion"] = txtReligion.Text;
            patientInfoCache["occupation"] = txtOccup.Text;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}

