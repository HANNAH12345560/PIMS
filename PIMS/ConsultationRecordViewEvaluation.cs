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
    public partial class ConsultationRecordViewEvaluation : Form
    {
        public ConsultationRecordViewEvaluation()
        {
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
            ConsultationRecordViewHistory cr = new ConsultationRecordViewHistory();
            cr.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultationRecordViewSOA cr = new ConsultationRecordViewSOA();
            cr.ShowDialog();
            this.Close();
        }

        private void txtRR_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.AutoScroll = false;
            panel1.VerticalScroll.Value = vScrollBar1.Value;
        }
    }
}
