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
    public partial class Prescription : Form
    {
        int consultationId;
        public Prescription(int consultationId)
        {
            this.consultationId = consultationId;
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

    }

       
        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insurance i = new Insurance(consultationId);
            i.ShowDialog();
            this.Close();
        }



        private void rjButton1_Click(object sender, EventArgs e)
        {
            CapturePanelShot(PrescriptionPanel); 
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle m = e.PageBounds;
            e.Graphics.DrawImage(bmp, m);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListEvaluation pl = new PatientListEvaluation(consultationId);
            pl.ShowDialog();
            this.Close();
        }
    }
}
