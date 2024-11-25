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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Poppins-SemiBold", 12, FontStyle.Bold);
            label3.Font = new Font("Poppins-SemiBold", 12, FontStyle.Bold);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername__TextChanged(object sender, EventArgs e)
        {
            txtUsername.Font = new Font("Poppins", 10, FontStyle.Regular);
            txtPass.Font = new Font("Poppins", 10, FontStyle.Regular);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbConnection functions = new dbConnection();

            using (NpgsqlConnection conn = new NpgsqlConnection(functions.connectDb))
            {
                conn.Open();
                try
                {
                    MessageBox.Show("Connection successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed!");
                }
               

            }
            //this.Hide();
            //StartScreen startScreen = new StartScreen();
            //startScreen.ShowDialog();
            //this.Close();
        }

        private void txtPass__TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPass.Checked)
            {
                txtPass.PasswordChar = false;
            }
            else
            {
                txtPass.PasswordChar = true;
            }
        }

    }
}
