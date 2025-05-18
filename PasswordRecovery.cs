using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MySql.Data.MySqlClient;

namespace Hotel_System
{
    public partial class PasswordRecovery : Form
    {
        public PasswordRecovery()
        {
            InitializeComponent();
        }

        private void sendCode_Click(object sender, EventArgs e)
        {
            string username = reg_username.Text.Trim();
            string email = reg_email.Text.Trim();

            // Database connection string
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM system_users WHERE username = @username AND email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows) // If username and email exist in the database
                    {
                        // Show message indicating credentials found
                        MessageBox.Show("Credentials found! You can now reset your password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //targetUsername = username;

                        // Show the Reset Password form
                        ResetPassword resetPassword = new ResetPassword(username);
                        resetPassword.Show();
                        this.Hide(); 
                    }
                    else
                    {
                        // If credentials do not exist, show an error message
                        MessageBox.Show("The username or email is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
