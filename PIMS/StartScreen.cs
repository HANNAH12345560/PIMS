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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            //milisecond
            timer1.Interval = 1000;
            foreverProgressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (foreverProgressBar1.Value != 10)
            {
                foreverProgressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                DashboardScreen ds = new DashboardScreen();
                ds.ShowDialog();
                this.Close();
            }
        }
    }
}
