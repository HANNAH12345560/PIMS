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
    public partial class ConsultationRecordViewSOA : Form
    {
        public ConsultationRecordViewSOA()
        {
            InitializeComponent();
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Consultation Fee");
            dataGridView1.Rows.Add("Medical Fee");
            dataGridView1.Rows.Add("Insurance Payment");
            dataGridView1.Rows.Add("PhilHealth");
            dataGridView1.Rows.Add("SC/PWD Discount");
            dataGridView1.Rows.Add("Other Discount");
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
            ConsultationRecordViewEvaluation ce = new ConsultationRecordViewEvaluation();
            ce.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultationRecord cr = new ConsultationRecord();
            cr.ShowDialog();
            this.Close();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
