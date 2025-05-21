using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class LoginForm : Form
    {
        private ToolTip toolTip;

        public LoginForm()
        {
            InitializeComponent();

            toolTip = new ToolTip();
        }

        private void pictureBoxShowPass_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxHidePass_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void pictureBoxShowPass_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxHidePass_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = login_username.Text.Trim();
            string password = login_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // 👇 Modified query: also get status
                    string query = @"SELECT password, status FROM system_users WHERE username = @username LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHashedPassword = reader["password"].ToString();
                            string accountStatus = reader["status"].ToString();

                            if (accountStatus.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("Your account is currently inactive. Please contact admin.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);

                            if (isPasswordValid)
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                dashboard Dashboard = new dashboard();
                                Dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm registerform = new RegistrationForm();
            registerform.Show();
            this.Hide();

        }

        private void loginShowPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.UseSystemPasswordChar = !loginShowPass.Checked;
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRecovery passwordRecovery = new PasswordRecovery();
            passwordRecovery.Show();
            this.Hide();
        }
    }
}
