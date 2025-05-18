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
    public partial class admin_addRoom : UserControl
    {
        string connStr = "server=localhost;user=admin1;password=admin123;database=hotel";
        public admin_addRoom()
        {
            InitializeComponent();
            LoadRoomData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            ClearRoomFields();
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT *FROM rooms";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewRoom.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load guest data.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Add Room
        private void addRoom_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";

            // Get values from input controls
            string roomtype = roomType.Text.Trim();
            string roomprice = roomPrice.Text.Trim();
            string roomstatus = roomStatus.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO rooms (room_type, price, status)
                                   VALUES (@roomtype, @roomprice, @roomstatus)";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@roomtype", roomtype);
                    cmd.Parameters.AddWithValue("@roomprice", roomprice);
                    cmd.Parameters.AddWithValue("@roomstatus", roomstatus);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomData(); // Refresh DataGridView after adding
                        ClearRoomFields(); // Clear input fields
                    }
                    else
                    {
                        MessageBox.Show("Failed to add room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Auto clear the text fields
        private void ClearRoomFields()
        {
            roomType.SelectedIndex = -1;
            roomPrice.Clear();
            roomStatus.SelectedIndex = -1;
        }
        private int getRoomID;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Update Room
        private void updateRoom_Click(object sender, EventArgs e)
        {
            // Check if any of the fields are empty
            if (roomType.Text == "" ||
                roomPrice.Text == "" ||
                roomStatus.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user before updating
            if (MessageBox.Show("Are you sure you want to update this room?",
                                "Confirmation Message",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Get values from input controls
                string roomtype = roomType.Text.Trim();
                string roomprice = roomPrice.Text.Trim();
                string roomstatus = roomStatus.Text.Trim();

                // Connection string to the MySQL database
                string connStr = "server=localhost;user=admin1;password=admin123;database=hotel";

                // Start the database connection and perform the update
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        string updateQuery = @"
                    UPDATE rooms 
                    SET room_type = @roomtype,
                        price = @roomprice,
                        status = @roomstatus
                    WHERE room_id = @roomId";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            // Add parameters to avoid SQL injection
                            cmd.Parameters.AddWithValue("@roomtype", roomtype);
                            cmd.Parameters.AddWithValue("@roomprice", roomprice);
                            cmd.Parameters.AddWithValue("@roomstatus", roomstatus);
                            cmd.Parameters.AddWithValue("@roomId", getRoomID); // Use the selected guest's ID

                            // Execute the update query
                            cmd.ExecuteNonQuery();
                        }

                        // Refresh DataGridView
                        LoadRoomData(); // Your custom function to load data into DataGridView
                        ClearRoomFields();    // Clear input fields after update

                        // Show success message
                        MessageBox.Show("Room updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Catch any errors and display them
                        MessageBox.Show("Failed to update room.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        /*private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }*/
        //Select the ID and display
        private void dataGridViewRoom_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];

                // Get guest ID from the clicked row (assuming it's the first column)
                getRoomID = Convert.ToInt32(row.Cells["room_id"].Value);

                // Populate the fields with the selected guest's data
                roomType.Text = row.Cells["room_type"].Value.ToString();
                roomPrice.Text = row.Cells["price"].Value.ToString();
                roomStatus.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void deleteRoom_Click(object sender, EventArgs e)
        {
            if (getRoomID == 0)
            {
                MessageBox.Show("Please select a room to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user before deleting
            if (MessageBox.Show("Are you sure you want to delete this room?",
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
                        string deleteQuery = "DELETE FROM rooms WHERE room_id = @roomId";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            // Add parameter to avoid SQL injection
                            cmd.Parameters.AddWithValue("@roomId", getRoomID);

                            // Execute the delete query
                            int result = cmd.ExecuteNonQuery();

                            // Check if the deletion was successful
                            if (result > 0)
                            {
                                // Refresh the DataGridView after deletion
                                LoadRoomData();

                                // Clear the input fields
                                ClearRoomFields();

                                // Show success message
                                MessageBox.Show("Room deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // If no rows were affected, show an error message
                                MessageBox.Show("Failed to delete room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Catch any errors and display them
                        MessageBox.Show("Failed to delete room.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
