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
    public partial class admin_addGuest : UserControl
    {
        string connStr = "server=localhost;user=admin1;password=admin123;database=hotel";
        public admin_addGuest()
        {
            InitializeComponent();
            LoadGuestData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            ClearGuestFields();
            LoadGuestData();
        }
        private void LoadGuestData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT guest_id, fname, lname, dob, baranggay, city, province, postal_code FROM guest";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewGuest.DataSource = dt;

                    // Optional: Customize column headers
                    dataGridViewGuest.Columns["guest_id"].HeaderText = "Guest ID";
                    dataGridViewGuest.Columns["fname"].HeaderText = "First Name";
                    dataGridViewGuest.Columns["lname"].HeaderText = "Last Name";
                    dataGridViewGuest.Columns["dob"].HeaderText = "Birthday";
                    dataGridViewGuest.Columns["baranggay"].HeaderText = "Barangay";
                    dataGridViewGuest.Columns["city"].HeaderText = "City";
                    dataGridViewGuest.Columns["province"].HeaderText = "Province";
                    dataGridViewGuest.Columns["postal_code"].HeaderText = "Postal Code";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load guest data.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //Add Guest
        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";

            // Get values from input controls
            string fname = addG_fname.Text.Trim();
            string lname = addG_lname.Text.Trim();
            string dob = addG_bday.Value.ToString("yyyy-MM-dd");  // format the date
            string barangay = addG_baranggay.Text.Trim();
            string city = addG_city.Text.Trim();
            string province = addG_province.Text.Trim();
            string postal = addG_postal.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO guest (fname, lname, dob, baranggay, city, province, postal_code)
                                   VALUES (@fname, @lname, @dob, @barangay, @city, @province, @postal)";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@barangay", barangay);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@province", province);
                    cmd.Parameters.AddWithValue("@postal", postal);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Guest added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGuestData(); // Refresh DataGridView after adding
                        ClearGuestFields(); // Clear input fields
                    }
                    else
                    {
                        MessageBox.Show("Failed to add guest.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Auto clear the text fields
        private void ClearGuestFields()
        {
            addG_fname.Clear();
            addG_lname.Clear();
            addG_bday.Value = DateTime.Today;
            addG_baranggay.Clear();
            addG_city.Clear();
            addG_province.Clear();
            addG_postal.Clear();
        }

        //Get the guest ID from the selected row
        private int getID;

        // Update Guest Details
        private void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            // Check if any of the fields are empty
            if (addG_fname.Text == "" ||
                addG_lname.Text == "" ||
                addG_baranggay.Text == "" ||
                addG_city.Text == "" ||
                addG_province.Text == "" ||
                addG_postal.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user before updating
            if (MessageBox.Show("Are you sure you want to update this guest?",
                                "Confirmation Message",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Get values from input controls
                string fname = addG_fname.Text.Trim();
                string lname = addG_lname.Text.Trim();
                string dob = addG_bday.Value.ToString("yyyy-MM-dd");  // format the date
                string barangay = addG_baranggay.Text.Trim();
                string city = addG_city.Text.Trim();
                string province = addG_province.Text.Trim();
                string postal = addG_postal.Text.Trim();

                // Connection string to the MySQL database
                string connStr = "server=localhost;user=admin1;password=admin123;database=hotel";

                // Start the database connection and perform the update
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        string updateQuery = @"
                    UPDATE guest 
                    SET fname = @fname,
                        lname = @lname,
                        dob = @dob,
                        baranggay = @baranggay,
                        city = @city,
                        province = @province,
                        postal_code = @postal
                    WHERE guest_id = @guestId";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            // Add parameters to avoid SQL injection
                            cmd.Parameters.AddWithValue("@fname", fname);
                            cmd.Parameters.AddWithValue("@lname", lname);
                            cmd.Parameters.AddWithValue("@dob", dob);
                            cmd.Parameters.AddWithValue("@baranggay", barangay);
                            cmd.Parameters.AddWithValue("@city", city);
                            cmd.Parameters.AddWithValue("@province", province);
                            cmd.Parameters.AddWithValue("@postal", postal);
                            cmd.Parameters.AddWithValue("@guestId", getID); // Use the selected guest's ID

                            // Execute the update query
                            cmd.ExecuteNonQuery();
                        }

                        // Refresh DataGridView
                        LoadGuestData(); // Your custom function to load data into DataGridView
                        ClearGuestFields();    // Clear input fields after update

                        // Show success message
                        MessageBox.Show("Guest updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Catch any errors and display them
                        MessageBox.Show("Failed to update guest.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // When a cell in the DataGridView is clicked, populate the fields with the selected guest's data
        private void dataGridViewGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewGuest.Rows[e.RowIndex];

                // Get guest ID from the clicked row (assuming it's the first column)
                getID = Convert.ToInt32(row.Cells["guest_id"].Value);

                // Populate the fields with the selected guest's data
                addG_fname.Text = row.Cells["fname"].Value.ToString();
                addG_lname.Text = row.Cells["lname"].Value.ToString();
                addG_bday.Value = Convert.ToDateTime(row.Cells["dob"].Value);
                addG_baranggay.Text = row.Cells["baranggay"].Value.ToString();
                addG_city.Text = row.Cells["city"].Value.ToString();
                addG_province.Text = row.Cells["province"].Value.ToString();
                addG_postal.Text = row.Cells["postal_code"].Value.ToString();
            }
        }

        // Delete Guest
        private void buttonDeleteGuest_Click(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Please select a guest to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user before deleting
            if (MessageBox.Show("Are you sure you want to delete this guest?",
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
                        string deleteQuery = "DELETE FROM guest WHERE guest_id = @guestId";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            // Add parameter to avoid SQL injection
                            cmd.Parameters.AddWithValue("@guestId", getID);

                            // Execute the delete query
                            int result = cmd.ExecuteNonQuery();

                            // Check if the deletion was successful
                            if (result > 0)
                            {
                                // Refresh the DataGridView after deletion
                                LoadGuestData();

                                // Clear the input fields
                                ClearGuestFields();

                                // Show success message
                                MessageBox.Show("Guest deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // If no rows were affected, show an error message
                                MessageBox.Show("Failed to delete guest.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Catch any errors and display them
                        MessageBox.Show("Failed to delete guest.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
