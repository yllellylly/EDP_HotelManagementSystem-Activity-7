using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;


namespace Hotel_System
{
    public partial class ResetPassword : Form
    {
        private string targetUsername;
        public ResetPassword(string username)
        {
            InitializeComponent();
            targetUsername = username;
        }

        private void loginShowPass_CheckedChanged(object sender, EventArgs e)
        {
            new_pass.UseSystemPasswordChar = !resetShowPass.Checked;
            new_confirmpass.UseSystemPasswordChar = !resetShowPass.Checked;
        }

        // Method to hash the password before storing it
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Method to update the password in the database
        private void UpdatePasswordInDatabase(string hashedPassword)
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE system_users SET password = @password WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@username", targetUsername);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password reset successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginForm loginform = new LoginForm();
                        loginform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password reset failed. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sendCode_Click(object sender, EventArgs e)
        {
            string newPassword = new_pass.Text.Trim();
            string confirmPassword = new_confirmpass.Text.Trim();

            // Check if the new password and confirmation password match
            if (newPassword == confirmPassword)
            {
                // Hash the new password before storing it
                string hashedPassword = HashPassword(newPassword);

                // Update the password in the database for the target username
                UpdatePasswordInDatabase(hashedPassword);
            }
            else
            {
                // Display an error message if the passwords don't match
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }
    }
}
