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
    public partial class PatientListScreen : Form
    {
        public PatientListScreen()
        {
            InitializeComponent();
        }

        string querySearch;
        dbConnection functions = new dbConnection();
        int sortColumnIndex = 0;
        bool sortAscending = true;

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM patientinfo;";
            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    NpgsqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        string firstName = read["first_name"].ToString();
                        string middleName = read["middle_name"].ToString();
                        string lastName = read["last_name"].ToString();
                        string fullname = $"{firstName} {middleName} {lastName}";
                        string dateAdded = Convert.ToDateTime(read["date_added"]).ToString("yyyy-MM-dd");
                        dataGridView1.Rows.Add(read["id"], fullname, read["gender"], read["age"], dateAdded);
                    }
                }
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
            PatientListScreen pt = new PatientListScreen();
            pt.ShowDialog();
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

        private void btnPatientInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicalRecordScreen medicalRecordScreen = new MedicalRecordScreen();
            medicalRecordScreen.ShowDialog();
            this.Close();
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultationRecord con = new ConsultationRecord();
            con.ShowDialog();
            this.Close();
        }

        private void btnHospitalAdmission_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewPatient ap = new AddNewPatient();
            ap.ShowDialog();
            this.Close();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Action"].Index && e.RowIndex >= 0)
            {
                int selectedConsultationRecord = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CaseNo"].Value.ToString());

                this.Hide();
                PatientListEdit edit = new PatientListEdit(selectedConsultationRecord);
                edit.ShowDialog();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                                dataGridView1.Rows.Clear();
                                if (read.Read())
                                {
                                    string firstName = read["first_name"].ToString();
                                    string middleName = read["middle_name"].ToString();
                                    string lastName = read["last_name"].ToString();
                                    string fullname = $"{firstName} {middleName} {lastName}";
                                    string dateAdded = Convert.ToDateTime(read["date_added"]).ToString("yyyy-MM-dd");
                                    dataGridView1.Rows.Add(read["id"], fullname, read["gender"], read["age"], dateAdded);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DisplayAllPatientRow();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DisplayPatientRow(5);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                DisplayPatientRow(10);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                DisplayPatientRow(15);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                DisplayPatientRow(20);
            }
        }

        public void DisplayPatientRow(int limit)
        {
            int limitValue = limit;
            string query = "SELECT * FROM patientinfo ORDER BY id ASC LIMIT @limitValue;";
            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@limitValue", limitValue);
                    using (NpgsqlDataReader read = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();
                        while (read.Read())
                        {
                            string firstName = read["first_name"].ToString();
                            string middleName = read["middle_name"].ToString();
                            string lastName = read["last_name"].ToString();
                            string fullname = $"{firstName} {middleName} {lastName}";
                            string dateAdded = Convert.ToDateTime(read["date_added"]).ToString("yyyy-MM-dd");
                            dataGridView1.Rows.Add(read["id"], fullname, read["gender"], read["age"], dateAdded);
                        }
                    }
                }
            }
        }

        public void DisplayAllPatientRow()
        {
            string query = "SELECT * FROM patientinfo ORDER BY id ASC;";
            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader read = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();
                        while (read.Read())
                        {
                            string firstName = read["first_name"].ToString();
                            string middleName = read["middle_name"].ToString();
                            string lastName = read["last_name"].ToString();
                            string fullname = $"{firstName} {middleName} {lastName}";
                            string dateAdded = Convert.ToDateTime(read["date_added"]).ToString("yyyy-MM-dd");
                            dataGridView1.Rows.Add(read["id"], fullname, read["gender"], read["age"], dateAdded);
                        }
                    }
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == sortColumnIndex)
            {
                sortAscending = !sortAscending;
            }
            else
            {
                sortColumnIndex = e.ColumnIndex;
                sortAscending = true;
            }

            BubbleSort(dataGridView1);
        }

        private void BubbleSort(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv.Rows.Count - 1 - i; j++)
                {
                    string value1 = dgv.Rows[j].Cells[sortColumnIndex].Value.ToString();
                    string value2 = dgv.Rows[j + 1].Cells[sortColumnIndex].Value.ToString();

                    if (sortAscending)
                    {
                        if (CompareValues(value1, value2) > 0)
                        {
                            SwapRows(dgv, j, j + 1);
                        }
                    }
                    else
                    {
                        if (CompareValues(value1, value2) < 0)
                        {
                            SwapRows(dgv, j, j + 1);
                        }
                    }
                }
            }
        }

        private int CompareValues(string value1, string value2)
        {
            return string.Compare(value1, value2);
        }

        private void SwapRows(DataGridView dgv, int rowIndex1, int rowIndex2)
        {
            DataGridViewRow row1 = dgv.Rows[rowIndex1];
            DataGridViewRow row2 = dgv.Rows[rowIndex2];

            for (int i = 0; i < row1.Cells.Count; i++)
            {
                object temp = row1.Cells[i].Value;
                row1.Cells[i].Value = row2.Cells[i].Value;
                row2.Cells[i].Value = temp;
            }
        }
    }
}

      
