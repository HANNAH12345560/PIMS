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
    public partial class ConsultationRecordViewHistory : Form
    {
        private int patientId;
        private int consultationId;

        public ConsultationRecordViewHistory()
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
            //MessageBox.Show(consultationId.ToString());
            chkStatusNOTKNOWN_DRUG.Checked = true;
            chkStatusNOTKNOWN_FOOD.Checked = true;
            chkStatusNOTKNOWN_OTHER.Checked = true;

            string query = "SELECT a.allergy_type, a.status, ab.specific_detail FROM allergies a LEFT JOIN allergiesdetails ab ON a.id = ab.allergy_id WHERE a.consultation_id = @consultationId;";

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                //allergies
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@consultationId", consultationId);
                    using (NpgsqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            //string message = $"Allergy Type: {rd["allergy_type"]}, Status: {rd["status"]}";
                            //MessageBox.Show(message);

                            string allergyType = rd["allergy_type"].ToString().ToLower();
                            string status = rd["status"].ToString().ToLower();
                            string specificDetail = rd["specific_detail"]?.ToString() ?? "";

                            switch (allergyType)
                            {
                                case "drug":
                                    chkStatusNOTKNOWN_DRUG.Checked = false;
                                    break;
                                case "food":
                                    chkStatusNOTKNOWN_FOOD.Checked = false;
                                    break;
                                case "other":
                                    chkStatusNOTKNOWN_OTHER.Checked = false;
                                    break;
                            }

                            switch (allergyType)
                            {
                                case "drug":
                                    switch (status)
                                    {
                                        case "yes":
                                            chkStatusYES_DRUG.Checked = true;
                                            txtDrugDesc.Text = specificDetail;
                                            break;
                                        case "no":
                                            chkStatusNO_DRUG.Checked = true;
                                            break;
                                        default:
                                            chkStatusNOTKNOWN_DRUG.Checked = true;
                                            break;
                                    }
                                    break;

                                case "food":
                                    switch (status)
                                    {
                                        case "yes":
                                            chkStatusYES_FOOD.Checked = true;
                                            txtFoodDesc.Text = specificDetail;
                                            break;
                                        case "no":
                                            chkStatusNO_FOOD.Checked = true;
                                            break;
                                        default:
                                            chkStatusNOTKNOWN_FOOD.Checked = true;
                                            break;
                                    }
                                    break;

                                case "other":
                                    switch (status)
                                    {
                                        case "yes":
                                            chkStatusYES_OTHER.Checked = true;
                                            txtOtherDesc.Text = specificDetail;
                                            break;
                                        case "no":
                                            chkStatusNO_OTHER.Checked = true;
                                            break;
                                        default:
                                            chkStatusNOTKNOWN_OTHER.Checked = true;
                                            break;
                                    }
                                    break;
                            }
                        }
                    }
                }

                chkStatusYES_DRUG.Enabled = false;
                chkStatusYES_FOOD.Enabled = false;
                chkStatusYES_OTHER.Enabled = false;
                chkStatusNO_DRUG.Enabled = false;
                chkStatusNO_FOOD.Enabled = false;
                chkStatusNO_OTHER.Enabled = false;
                chkStatusNOTKNOWN_DRUG.Enabled = false;
                chkStatusNOTKNOWN_FOOD.Enabled = false;
                chkStatusNOTKNOWN_OTHER.Enabled = false;

                //medical history
                string query_2 = "SELECT m.medical_history, m.status, md.specific_detail FROM medicalhistory m LEFT JOIN medicalhistorydetails AS md ON m.id = md.med_history_id WHERE m.consultation_id = @consultationId;";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_2, conn))
                {
                    cmd.Parameters.AddWithValue("@consultationId", consultationId);
                    using (NpgsqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            //string message = $"Medical Type: {rd["medical_history"]}, Status: {rd["status"]}";
                            //MessageBox.Show(message);

                            string medicalType = rd["medical_history"].ToString().ToLower();
                            string status = rd["status"].ToString().ToLower();
                            string specificDetail = rd["specific_detail"]?.ToString() ?? "";

                            switch (medicalType)
                            {
                                case "previous":
                                    chkStatusNOTKNOWN_MD1.Checked = false;
                                    break;
                                case "current":
                                    chkStatusNOTKNOWN_MD2.Checked = false;
                                    break;
                                case "family":
                                    chkStatusNOTKNOWN_MD3.Checked = false;
                                    break;
                            }

                            switch (medicalType)
                            {
                                case "previous":
                                    switch (status)
                                    {
                                        case "yes":
                                            chkStatusYES_MD1.Checked = true;
                                            txtMH1desc.Text = specificDetail;
                                            break;
                                        case "no":
                                            chkStatusNO_MD1.Checked = true;
                                            break;
                                        default:
                                            chkStatusNOTKNOWN_MD1.Checked = true;
                                            break;
                                    }
                                    break;

                                case "current":
                                    switch (status)
                                    {
                                        case "yes":
                                            chkStatusYES_MD2.Checked = true;
                                            txtMH2desc.Text = specificDetail;
                                            break;
                                        case "no":
                                            chkStatusNO_MD2.Checked = true;
                                            break;
                                        default:
                                            chkStatusNOTKNOWN_MD2.Checked = true;
                                            break;
                                    }
                                    break;

                                case "family":
                                    switch (status)
                                    {
                                        case "yes":
                                            chkStatusYES_MD3.Checked = true;
                                            txtMH3desc.Text = specificDetail;
                                            break;
                                        case "no":
                                            chkStatusNO_MD3.Checked = true;
                                            break;
                                        default:
                                            chkStatusNOTKNOWN_MD3.Checked = true;
                                            break;
                                    }
                                    break;
                            }
                        }
                    }
                }

                chkStatusYES_MD1.Enabled = false;
                chkStatusYES_MD2.Enabled = false;
                chkStatusYES_MD3.Enabled = false;
                chkStatusNO_MD1.Enabled = false;
                chkStatusNO_MD2.Enabled = false;
                chkStatusNO_MD3.Enabled = false;
                chkStatusNOTKNOWN_MD1.Enabled = false;
                chkStatusNOTKNOWN_MD2.Enabled = false;
                chkStatusNOTKNOWN_MD3.Enabled = false;
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
            ConsultationRecordView cr = new ConsultationRecordView();
            cr.FetchId(patientId, consultationId);
            cr.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultationRecordViewEvaluation cr = new ConsultationRecordViewEvaluation();
            cr.FetchId(patientId, consultationId);
            cr.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDrugDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
