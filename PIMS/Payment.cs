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
    public partial class Payment: Form
    {
        int consultationId;
        public Payment()
        {
            InitializeComponent();
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {

        }


       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insurance i = new Insurance(consultationId);
            i.ShowDialog();
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListSOA pl = new PatientListSOA();
            pl.ShowDialog();
            this.Close();
        }

    }
}
