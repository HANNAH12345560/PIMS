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

namespace LoginScreen
{
    public partial class Login : Form
    {
        private string connString = "Host=localhost;Username=user1;Password=Miyaki_11;Database=PatientManagementSystem";

        public Login()
        {
            InitializeComponent();
        }

        private void guna2GradientButtonLogin_Click(object sender, EventArgs e)
        {
            string username = txtbUsername.Text;
            string password = txtbPassword.Text;

            // Validate user login with PostgreSQL
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
                                Error error = new Error();
                                error.ShowDialog();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Error error = new Error();
                    error.ShowDialog();
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