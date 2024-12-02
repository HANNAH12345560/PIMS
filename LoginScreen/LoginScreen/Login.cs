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
using PIMS;

namespace LoginScreen
{
    public partial class Login : Form
    {
        public string connectDb = "Server=localhost;Port=5432;User Id = postgres; Password=hannah;Database=PatientManagementSystem;";

        public Login()
        {
            InitializeComponent();
        }

        private void guna2GradientButtonLogin_Click(object sender, EventArgs e)
        {
            string username = txtbUsername.Text;
            string password = txtbPassword.Text;

            // Validate user login with PostgreSQL
            using (var conn = new NpgsqlConnection(connectDb))
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
                                PIMS.StartScreen startScreen = new PIMS.StartScreen();
                                startScreen.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while trying to log in. Please try again later.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the toggle is ON (checked)
            if (guna2ToggleSwitch1.Checked)
            {
                // Show the password by setting the PasswordChar to the empty string
                txtbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide the password by setting the PasswordChar to '*'
                txtbPassword.UseSystemPasswordChar = true;
            }
        }

        private void guna2GradientButtonClear_Click(object sender, EventArgs e)
        {
            // Clear both the username and password textboxes
            txtbUsername.Clear();
            txtbPassword.Clear();

            // Optionally, reset the password visibility toggle to its default state
            guna2ToggleSwitch1.Checked = false;
            txtbPassword.UseSystemPasswordChar = true; // Ensure password is hidden when clearing
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtbPassword.UseSystemPasswordChar = true;
        }
    }
}