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
        public PatientListEdit()
        {
            InitializeComponent();
        }

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
            MessageBox.Show("Patient record has been updated.");

            this.Hide();
            PatientListScreen pl = new PatientListScreen();
            pl.ShowDialog();
            this.Close();

            
        }

        
    }
}
