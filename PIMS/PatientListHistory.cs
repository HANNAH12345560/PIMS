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
    public partial class PatientListHistory : Form
    {
        public PatientListHistory()
        {
            InitializeComponent();
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            chkStatusYES_FOOD.Tag = "Row1";
            chkStatusNO_FOOD.Tag = "Row1";
            chkStatusNOTKNOWN_FOOD.Tag = "Row1";

            chkStatusNO_DRUG.Tag = "Row2";
            chkStatusYES_DRUG.Tag = "Row2";
            chkStatusNOTKNOWN_DRUG.Tag = "Row2";

            chkStatusNO_OTHER.Tag = "Row3";
            chkStatusYES_OTHER.Tag = "Row3";
            chkStatusNOTKNOWN_OTHER.Tag = "Row3";

            chkStatusYES_MD1.Tag = "Row1";
            chkStatusNO_MD1.Tag = "Row1";
            chkStatusNOTKNOWN_MD1.Tag = "Row1";

            chkStatusYES_MD2.Tag = "Row2";
            chkStatusNO_MD2.Tag = "Row2";
            chkStatusNOTKNOWN_MD2.Tag = "Row2";

            chkStatusYES_MD3.Tag = "Row3";
            chkStatusNO_MD3.Tag = "Row3";
            chkStatusNOTKNOWN_MD3.Tag = "Row3";


            chkStatusYES_FOOD.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNO_FOOD.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_FOOD.CheckedChanged += CheckBox_CheckedChanged;

            chkStatusNO_DRUG.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusYES_DRUG.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_DRUG.CheckedChanged += CheckBox_CheckedChanged;

            chkStatusNO_OTHER.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusYES_OTHER.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_OTHER.CheckedChanged += CheckBox_CheckedChanged;

            chkStatusNO_MD1.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusYES_MD1.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_MD1.CheckedChanged += CheckBox_CheckedChanged;

            chkStatusNO_MD2.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusYES_MD2.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_MD2.CheckedChanged += CheckBox_CheckedChanged;

            chkStatusNO_MD3.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusYES_MD3.CheckedChanged += CheckBox_CheckedChanged;
            chkStatusNOTKNOWN_MD3.CheckedChanged += CheckBox_CheckedChanged;
        }


        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox selectedCheckbox && selectedCheckbox.Checked)
            {

                string rowIdentifier = selectedCheckbox.Tag?.ToString();


                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is CheckBox checkbox &&
                        checkbox.Tag?.ToString() == rowIdentifier &&
                        checkbox != selectedCheckbox)
                    {
                        checkbox.Checked = false; // Uncheck other checkboxes in the same row
                    }
                }

                foreach (Control control in tableLayoutPanel2.Controls)
                {
                    if (control is CheckBox checkbox &&
                        checkbox.Tag?.ToString() == rowIdentifier &&
                        checkbox != selectedCheckbox)
                    {
                        checkbox.Checked = false; // Uncheck other checkboxes in the same row
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
            AddNewPatient pl = new AddNewPatient();
            pl.ShowDialog();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListEvaluation pl = new PatientListEvaluation();
            pl.ShowDialog();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
