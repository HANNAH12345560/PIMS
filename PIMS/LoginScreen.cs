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
    public partial class Login : Form
    {
        private string connString = "Host=localhost;Username=user1;Password=Miyaki_11;Database=PatientManagementSystem";

        public Login()
        {
            InitializeComponent();
        }
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2ToggleSwitch1.Checked)
            {
                txtbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtbPassword.UseSystemPasswordChar = true;
            }
        }

        private void guna2GradientButtonClear_Click(object sender, EventArgs e)
        {

            txtbUsername.Clear();
            txtbPassword.Clear();

            guna2ToggleSwitch1.Checked = false;
            txtbPassword.UseSystemPasswordChar = true;
        }

        private void guna2GradientButtonLogin_Click(object sender, EventArgs e)
        {
            string username = txtbUsername.Text;
            string password = txtbPassword.Text;

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM usernurse WHERE username = @username AND password = @password";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                this.Hide();
                                StartScreen startScreen = new StartScreen();
                                startScreen.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Login failed! Please check your username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtbPassword.UseSystemPasswordChar = true;
        }
    }
}
