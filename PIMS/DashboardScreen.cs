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
    public partial class DashboardScreen : Form
    {
        public DashboardScreen()
        {
            InitializeComponent();
        }

        dbConnection functions = new dbConnection();

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            string query = "SELECT (SELECT COUNT(id) FROM patientinfo) AS PatientCount," +
                "(SELECT COUNT(id) FROM consultationassesment) AS AppointmentCount," +
                "(SELECT COUNT(id) FROM payment) AS PaymentCount," +
                "(SELECT SUM(balance_due) FROM payment) + (SELECT SUM(total_bill) FROM hospitaladmission) AS Revenue;";

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblTtlPatients.Text = FormatNumber(dr["PatientCount"]);
                    lblTtlAppointment.Text = FormatNumber(dr["AppointmentCount"]);
                    lblTtlPresc.Text = FormatNumber(dr["PaymentCount"]);
                    lblTtlRevenue.Text = FormatNumber(dr["Revenue"]);
                }
            }
        }

        private string FormatNumber(object number)
        {
            double num = Convert.ToDouble(number);
            if (num >= 1000000000)
                return (num / 1000000000D).ToString("0.#") + "B";
            if (num >= 1000000)
                return (num / 1000000D).ToString("0.#") + "M";
            if (num >= 1000)
                return (num / 1000D).ToString("0.#") + "K";
            return num.ToString("0.#");
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

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecordScreen Addrec = new AddRecordScreen();
            Addrec.ShowDialog();
            this.Close();
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListScreen edit = new PatientListScreen();
            edit.ShowDialog();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardScreen newDashboard = new DashboardScreen();
            newDashboard.ShowDialog();
            this.Close();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTtlPatients_Click(object sender, EventArgs e)
        {

        }

        private void lblTtlRevenue_Click(object sender, EventArgs e)
        {

        }
    }
}
