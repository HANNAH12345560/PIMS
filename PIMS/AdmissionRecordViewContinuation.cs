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
    public partial class AdmissionRecordViewContinuation : Form
    {

        private int patientId;
        private int admissionId;
        private string medTreat;
        private string remarks;
        private double medFee;
        private double addFee;
        private double discount;
        private double totalBill;

        public AdmissionRecordViewContinuation()
        {
            InitializeComponent();
        }

        public void FetchId(int patientId, int admissionId)
        {
            this.patientId = patientId;
            this.admissionId = admissionId;
        }

        public void DisplayConn(string medTreat, double medFee, string remarks, double addFee, double discount, double totalBill)
        {
            this.medTreat = medTreat;
            this.medFee = medFee;
            this.remarks = remarks;
            this.addFee = addFee;
            this.discount = discount;
            this.totalBill = totalBill;
        }



        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            txtMedTreatment.Text = medTreat.ToString();
         
            txtAdmissionFee.Text = "₱ " + addFee.ToString();
            txtMedFee.Text = "₱ " + medFee.ToString();
            txtDiscount.Text = "₱ " + discount.ToString();
            txtTotalBill.Text = "₱ " + totalBill.ToString();
            txtRemarks.Text = remarks;
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
            AdmissionRecordView cr = new AdmissionRecordView();
            cr.FetchId(patientId, admissionId);
            cr.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdmissionRecord cr = new AdmissionRecord();
            cr.FetchId(patientId);
            cr.ShowDialog();
            this.Close();
        }
    }
}
