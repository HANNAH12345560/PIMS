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
    public partial class ConsultationRecordView : Form
    {
        private int patientId;
        private int consultationId;
        public ConsultationRecordView()
        {
            InitializeComponent();
        }

        dbConnection functions = new dbConnection();

        public void FetchId(int id, int id_2)
        {
            consultationId = id;
            patientId = id_2;
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            string query = "SELECT c.id,e.id, e.physician, c.bp, c.rr, c.pr, c.temp, c.wt, c.ht, c.blood_type, c.complaint FROM consultationassesment c JOIN physicianevaluation e ON c.id = e.consultation_id;";
            using(NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                using(NpgsqlCommand cmd = new NpgsqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@consultationId", consultationId);
                    NpgsqlDataReader rd = cmd.ExecuteReader();

                    rd.Read();
                    txtPhysician.Text = rd["physician"].ToString();
                    txtBP.Text = rd["bp"].ToString();
                    txtRR.Text = rd["rr"].ToString();
                    txtPR.Text = rd["pr"].ToString();
                    txtTemp.Text = rd["temp"].ToString();
                    txtWT.Text = rd["wt"].ToString();
                    txtHT.Text = rd["ht"].ToString();
                    txtBloodType.Text = rd["blood_type"].ToString();
                    txtComplaint.Text = rd["complaint"].ToString();
                }
            }
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
            ConsultationRecord cr = new ConsultationRecord();
            cr.FetchId(patientId);
            cr.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultationRecordViewHistory cr = new ConsultationRecordViewHistory();
            cr.FetchId(patientId, consultationId);
            cr.ShowDialog();
            this.Close();
        }
    }
}
