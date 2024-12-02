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
    public partial class PatientListSOA : Form
    {
        public PatientListSOA()
        {
            InitializeComponent();
        }

        Bitmap bmp;

        private void CapturePanelShot(Panel panel)
        {
            bmp = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bmp, new Rectangle(0, 0, panel.Width, panel.Height));
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListScreen cr = new PatientListScreen();
            cr.ShowDialog();
            this.Close();
        }
     
        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            CapturePanelShot(panelSOA);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle m = e.PageBounds;
            e.Graphics.DrawImage(bmp, m);
        }
    }
}
