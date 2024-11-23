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
    public partial class ConsultationRecordViewEvaluation : Form
    {
        private int consultationId;
        private int patientId;
        public ConsultationRecordViewEvaluation()
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
            string query = "SELECT e.diagnosis, md.name, md.dosage, md.price, md.physician_eval_id FROM physicianevaluation e JOIN medicaltreatment md ON e.id = md.physician_eval_id WHERE consultation_id = @consultationId";

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@consultationId", consultationId);
                    NpgsqlDataReader rd = cmd.ExecuteReader();

                    int yOffset = 38;
                    while (rd.Read())
                    {
                        //string lo = ($"Diagnosis: {rd["diagnosis"]}, Name: {rd["name"]}, Dosage: {rd["dosage"]}, Price: {rd["price"]}, Phy id: {rd["physician_eval_id"]}");
                        //MessageBox.Show(lo);

                        txtComplaint.Text = rd["diagnosis"].ToString();

                        TextBox txtMedName = new TextBox();
                        txtMedName.Location = new Point(3, yOffset);
                        txtMedName.Size = new Size(282, 20);
                        txtMedName.Text = rd["name"].ToString();
                        txtMedName.ReadOnly = true;
                        panel1.Controls.Add(txtMedName);
                       

                        TextBox txtDosage = new TextBox();
                        txtDosage.Location = new Point(367, yOffset);
                        txtDosage.Size = new Size(282, 20);
                        txtDosage.ReadOnly = true;
                        txtDosage.Text = rd["dosage"] + " ml";
                        panel1.Controls.Add(txtDosage);
                        

                        TextBox txtPrice = new TextBox();
                        txtPrice.Location = new Point(725, yOffset);
                        txtPrice.Size = new Size(282, 20);
                        txtPrice.Text = rd["price"].ToString();
                        txtPrice.ReadOnly = true;
                        panel1.Controls.Add(txtPrice);
                        

                        yOffset += 40; 
                    }
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
            ConsultationRecordViewHistory cr = new ConsultationRecordViewHistory();
            cr.FetchId(patientId, consultationId);
            cr.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultationRecordViewSOA cr = new ConsultationRecordViewSOA();
            cr.FetchId(patientId, consultationId);
            cr.ShowDialog();
            this.Close();
        }

        private void txtRR_TextChanged(object sender, EventArgs e)
        {

        }

        //private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{
        //    panel1.AutoScroll = false;
        //    panel1.VerticalScroll.Value = vScrollBar1.Value;
        //}
    }
}
