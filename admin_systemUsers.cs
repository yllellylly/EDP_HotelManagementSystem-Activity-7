using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_System
{
    public partial class admin_systemUsers : UserControl
    {
        string connStr = "server=localhost;user=admin1;password=admin123;database=hotel";
        public admin_systemUsers()
        {
            InitializeComponent();
            LoadSystemUsersData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            ClearSysUserFields();
            LoadSystemUsersData();
        }
        private void LoadSystemUsersData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT user_id, username, email, status FROM system_users;";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewSystemUsers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load system users data.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void admin_systemUsers_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSystemUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Get the selected row data
        private int getSysUserID;
        private void updateSystemUser_Click(object sender, EventArgs e)
        {
            // Check if any of the fields are empty
            if (system_username.Text == "" ||
                system_email.Text == "" ||
                system_ustatus.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user before updating
            if (MessageBox.Show("Are you sure you want to update this user?",
                                "Confirmation Message",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Get values from input controls
                string sys_username = system_username.Text.Trim();
                string sys_email = system_email.Text.Trim();
                string sys_status = system_ustatus.Text.Trim();

                // Connection string to the MySQL database
                string connStr = "server=localhost;user=admin1;password=admin123;database=hotel";

                // Start the database connection and perform the update
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        string updateQuery = @"
                    UPDATE system_users 
                    SET username = @sys_username,
                        email = @sys_email,
                        status = @sys_status
                    WHERE user_id = @sysUserID";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            // Add parameters to avoid SQL injection
                            cmd.Parameters.AddWithValue("@sys_username", sys_username);
                            cmd.Parameters.AddWithValue("@sys_email", sys_email);
                            cmd.Parameters.AddWithValue("@sys_status", sys_status);
                            cmd.Parameters.AddWithValue("@sysUserID", getSysUserID); // Use the selected guest's ID

                            // Execute the update query
                            cmd.ExecuteNonQuery();
                        }

                        // Refresh DataGridView
                        LoadSystemUsersData(); // Your custom function to load data into DataGridView
                        ClearSysUserFields();    // Clear input fields after update

                        // Show success message
                        MessageBox.Show("User updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Catch any errors and display them
                        MessageBox.Show("Failed to update user.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Auto clear the text fields
        private void ClearSysUserFields()
        {
            system_username.Clear();
            system_email.Clear();
            system_ustatus.SelectedIndex = -1;
        }

        private void dataGridViewSystemUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewSystemUsers.Rows[e.RowIndex];

                // Get guest ID from the clicked row (assuming it's the first column)
                getSysUserID = Convert.ToInt32(row.Cells["user_id"].Value);

                // Populate the fields with the selected guest's data
                system_username.Text = row.Cells["username"].Value.ToString();
                system_email.Text = row.Cells["email"].Value.ToString();
                system_ustatus.Text = row.Cells["status"].Value.ToString();
            }

            system_pass.ReadOnly = true;
        }

        // Add new system user
        private void addsystemUser_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";

            string sys_username = system_username.Text.Trim();
            string sys_email = system_email.Text.Trim();

            //Hash the password before storing it
            string rawPassword = system_pass.Text.Trim();
            string sys_pass = BCrypt.Net.BCrypt.HashPassword(rawPassword);

            string sys_status = system_ustatus.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string insertQuery = @"INSERT INTO system_users (username, email, password, status)
                                   VALUES (@sys_username, @sys_email, @sys_pass, @sys_status)";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@sys_username", sys_username);
                    cmd.Parameters.AddWithValue("@sys_email", sys_email);
                    cmd.Parameters.AddWithValue("@sys_pass", sys_pass); // Hashed password
                    cmd.Parameters.AddWithValue("@sys_status", sys_status);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Registration complete! You can now log in using your credentials. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSystemUsersData();
                        ClearSysUserFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteSystemUser_Click(object sender, EventArgs e)
        {
            if (getSysUserID == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user before deleting
            if (MessageBox.Show("Are you sure you want to delete this user?",
                                "Confirmation Message",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Connection string to the MySQL database
                string connStr = "server=localhost;user=admin1;password=admin123;database=hotel";

                // Start the database connection and perform the delete
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM system_users WHERE user_id = @sysUserID";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            // Add parameter to avoid SQL injection
                            cmd.Parameters.AddWithValue("@sysUserID", getSysUserID);

                            // Execute the delete query
                            int result = cmd.ExecuteNonQuery();

                            // Check if the deletion was successful
                            if (result > 0)
                            {
                                // Refresh the DataGridView after deletion
                                LoadSystemUsersData();

                                // Clear the input fields
                                ClearSysUserFields();

                                // Show success message
                                MessageBox.Show("System User deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // If no rows were affected, show an error message
                                MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Catch any errors and display them
                        MessageBox.Show("Failed to delete user.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
