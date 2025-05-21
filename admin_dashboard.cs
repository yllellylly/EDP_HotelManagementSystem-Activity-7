using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Hotel_System
{
    public partial class admin_dashboard : UserControl
    {
        public admin_dashboard()
        {
            InitializeComponent();
            LoadBookingData();
            LoadRoomTypesToComboBox();
            LoadTotalRevenue();
            LoadTotalGuest();
            LoadAvailableRooms();
            LoadTotalBookings();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            LoadBookingData();
            LoadRoomTypesToComboBox();
            LoadTotalRevenue();
            LoadTotalGuest();
            LoadAvailableRooms();
            LoadTotalBookings();
            ClearBookingFields();
        }
        private void admin_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void LoadBookingData(string searchTerm = "")
        {
            /*string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT booking_id, guest_id, room_id, check_in_date, check_out_date, total_amount FROM booking";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataViewBookings.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load booking data.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT b.booking_id, b.guest_id, b.room_id, b.check_in_date, b.check_out_date, b.total_amount,
                       g.fname, g.lname
                FROM booking b
                JOIN guest g ON b.guest_id = g.guest_id
                WHERE 1=1";

                    List<MySqlParameter> parameters = new List<MySqlParameter>();

                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query += @" AND (
                    b.booking_id LIKE @searchTerm OR 
                    CONCAT(g.fname, ' ', g.lname) LIKE @searchTerm
                )";
                        parameters.Add(new MySqlParameter("@searchTerm", "%" + searchTerm + "%"));
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataViewBookings.DataSource = dt;

                    // Hide name columns
                    if (dataViewBookings.Columns.Contains("fname"))
                        dataViewBookings.Columns["fname"].Visible = false;
                    if (dataViewBookings.Columns.Contains("lname"))
                        dataViewBookings.Columns["lname"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load booking data.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Display the total revenue using the stored function to calculate total revenue
        private void LoadTotalRevenue()
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Call the stored procedure
                    using (MySqlCommand cmd = new MySqlCommand("CalcTotalRevenue", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Assuming the procedure returns a single scalar value
                        object result = cmd.ExecuteScalar();

                        if (result != null && decimal.TryParse(result.ToString(), out decimal totalRev))
                        {
                            totalRevenue.Text = totalRev.ToString("C"); // Format as currency
                        }
                        else
                        {
                            totalRevenue.Text = "₱0.00";  // Or some default value
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load total revenue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Display the number of total guest
        private void LoadTotalGuest()
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM guest;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int guestCount = Convert.ToInt32(cmd.ExecuteScalar());
                        totalGuest.Text = guestCount.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load total guests: " + ex.Message);
                    totalGuest.Text = "0";
                }
            }
        }

        //Call the function to display the number of avail rooms
        private void LoadAvailableRooms()
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // 1. Call the stored procedure to update room statuses
                    using (MySqlCommand cmdUpdate = new MySqlCommand("CALL hotel.UpdateRoomStatusWithCursor();", conn))
                    {
                        cmdUpdate.CommandType = CommandType.Text;
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // 2. Call the stored procedure to generate room report
                    using (MySqlCommand cmdReport = new MySqlCommand("CALL hotel.GenerateRoomReport();", conn))
                    {
                        cmdReport.CommandType = CommandType.Text;
                        cmdReport.ExecuteNonQuery();
                    }

                    // 3. Now, fetch the number of available rooms using the function
                    string query = "SELECT hotel.GetAvailableRoomsCount();";
                    using (MySqlCommand cmdCount = new MySqlCommand(query, conn))
                    {
                        int availableRooms = Convert.ToInt32(cmdCount.ExecuteScalar());
                        availRoomNum.Text = availableRooms.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading available rooms: " + ex.Message);
                    availRoomNum.Text = "0";
                }
            }
        }

        private void LoadTotalBookings()
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT COUNT(*) 
                FROM booking 
                WHERE check_out_date >= CURDATE();";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int bookingCount = Convert.ToInt32(cmd.ExecuteScalar());
                        noBookings.Text = bookingCount.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load total bookings: " + ex.Message);
                    noBookings.Text = "0";
                }
            }
        }

        private void dataViewBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public class RoomItem
        {
            public int RoomId { get; set; }
            public string RoomType { get; set; }

            public override string ToString()
            {
                return RoomType; // This is what shows in the ComboBox dropdown
            }
        }

        private void LoadRoomTypesToComboBox()
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT room_id, room_type FROM rooms";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    dashroom_id.Items.Clear(); // Clear first

                    while (reader.Read())
                    {
                        RoomItem room = new RoomItem
                        {
                            RoomId = Convert.ToInt32(reader["room_id"]),
                            RoomType = reader["room_type"].ToString()
                        };

                        dashroom_id.Items.Add(room);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading room types: " + ex.Message);
                }
            }
        }

        //Get the full name of the guest
        private string GetGuestFullName(int guestId)
        {
            string fullName = "";

            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT CONCAT(fname, ' ', lname) AS fullname FROM guest WHERE guest_id = @guestId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@guestId", guestId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        fullName = result.ToString();
                    }
                }
            }
            return fullName;
        }

        private int selectedGuestId;
        private void dataViewBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataViewBookings.Rows[e.RowIndex];

                getBookingID = Convert.ToInt32(row.Cells["booking_id"].Value);

                dashbooking_id.Text = row.Cells["booking_id"].Value.ToString();
                //dashfullname.Text = row.Cells["guest_id"].Value.ToString();

                int guestId = Convert.ToInt32(row.Cells["guest_id"].Value);
                //dashfullname.Text = GetGuestFullName(guestId);  // Display full name here
                dashfullname.Text = GetGuestFullName(guestId);
                selectedGuestId = guestId;

                dashcheckin.Value = Convert.ToDateTime(row.Cells["check_in_date"].Value);
                dashcheckout.Value = Convert.ToDateTime(row.Cells["check_out_date"].Value);
                dashtotalamount.Text = row.Cells["total_amount"].Value.ToString();

                int selectedRoomId = Convert.ToInt32(row.Cells["room_id"].Value);

                // Now match this ID with the ComboBox items
                foreach (RoomItem item in dashroom_id.Items)
                {
                    if (item.RoomId == selectedRoomId)
                    {
                        dashroom_id.SelectedItem = item;
                        break;
                    }
                }

                dashbooking_id.ReadOnly = true;
                dashfullname.ReadOnly = true;
                dashtotalamount.ReadOnly = true;
            }
        }

        private void DashUpdate_Click(object sender, EventArgs e)
        {
            RoomItem selectedRoom = dashroom_id.SelectedItem as RoomItem;
            if (selectedRoom == null)
            {
                MessageBox.Show("Please select a valid room type.");
                return;
            }

            int bookingId = Convert.ToInt32(dashbooking_id.Text);
            DateTime newCheckIn = dashcheckin.Value;
            DateTime newCheckOut = dashcheckout.Value;

            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // 🔍 Overlap check query
                    string overlapQuery = @"SELECT COUNT(*) FROM booking 
                                    WHERE room_id = @room_id 
                                    AND booking_id != @booking_id
                                    AND (@checkin < check_out_date AND @checkout > check_in_date)";

                    using (MySqlCommand overlapCmd = new MySqlCommand(overlapQuery, conn))
                    {
                        overlapCmd.Parameters.AddWithValue("@room_id", selectedRoom.RoomId);
                        overlapCmd.Parameters.AddWithValue("@booking_id", bookingId);
                        overlapCmd.Parameters.AddWithValue("@checkin", newCheckIn);
                        overlapCmd.Parameters.AddWithValue("@checkout", newCheckOut);

                        int overlapCount = Convert.ToInt32(overlapCmd.ExecuteScalar());

                        if (overlapCount > 0)
                        {
                            MessageBox.Show("The selected room is already booked for the chosen dates. Please choose different dates.", "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // ✅ No conflicts - proceed to update
                    string updateQuery = @"UPDATE booking 
                                   SET room_id = @room_id,
                                       guest_id = @guest_id,
                                       check_in_date = @checkin,
                                       check_out_date = @checkout,
                                       total_amount = @total
                                   WHERE booking_id = @booking_id";

                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@room_id", selectedRoom.RoomId);
                        //updateCmd.Parameters.AddWithValue("@guest_id", dashfullname.Text);
                        updateCmd.Parameters.AddWithValue("@guest_id", selectedGuestId);
                        updateCmd.Parameters.AddWithValue("@checkin", newCheckIn);
                        updateCmd.Parameters.AddWithValue("@checkout", newCheckOut);
                        updateCmd.Parameters.AddWithValue("@total", decimal.Parse(dashtotalamount.Text));
                        updateCmd.Parameters.AddWithValue("@booking_id", bookingId);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Booking updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBookingData();
                            LoadTotalRevenue();
                            LoadTotalBookings();
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Check if the booking ID exists.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void noBookings_Click(object sender, EventArgs e)
        {

        }

        private void generateInvoice_Click(object sender, EventArgs e)
        {
            int bookingId = Convert.ToInt32(dashbooking_id.Text);

            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            string storedProc = "CALL GenerateInvoice(@bookingId);";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(storedProc, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                DataRow row = dt.Rows[0];

                                Excel.Application excelApp = new Excel.Application();
                                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                                Excel.Worksheet sheet = workbook.Sheets[1];
                                sheet.Name = "Invoice";

                                int currentRow = 1;

                                // Title
                                sheet.Cells[currentRow, 1] = "🏨 The Masion Hotel";
                                Excel.Range titleRange = sheet.Range["A1", "F1"];
                                titleRange.Merge();
                                titleRange.Font.Size = 20;
                                titleRange.Font.Bold = true;
                                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                currentRow += 2;

                                // Guest Info
                                sheet.Cells[currentRow, 1] = "👤 Guest Information";
                                sheet.Range[$"A{currentRow}", $"F{currentRow}"].Merge();
                                sheet.Range[$"A{currentRow}"].Font.Size = 14;
                                sheet.Range[$"A{currentRow}"].Font.Bold = true;
                                currentRow++;

                                sheet.Cells[currentRow, 1] = "Full Name:";
                                sheet.Cells[currentRow, 2] = row["fname"] + " " + row["lname"];
                                sheet.Cells[currentRow, 1].Font.Bold = true;
                                currentRow++;

                                sheet.Cells[currentRow, 1] = "Address:";
                                sheet.Cells[currentRow, 2] = row["full_address"].ToString();
                                sheet.Cells[currentRow, 1].Font.Bold = true;
                                currentRow += 2;

                                // Booking Info
                                sheet.Cells[currentRow, 1] = "🛏️ Booking Information";
                                sheet.Range[$"A{currentRow}", $"F{currentRow}"].Merge();
                                sheet.Range[$"A{currentRow}"].Font.Size = 14;
                                sheet.Range[$"A{currentRow}"].Font.Bold = true;
                                currentRow +=1;

                                string[] bookingHeaders = { "Booking ID", "Room Type", "Check-In Date", "Check-Out Date" };
                                string[] bookingFields = { "booking_id", "room_type", "check_in_date", "check_out_date" };

                                for (int i = 0; i < bookingHeaders.Length; i++)
                                {
                                    sheet.Cells[currentRow, i + 1] = bookingHeaders[i];
                                    Excel.Range hdr = sheet.Cells[currentRow, i + 1];
                                    hdr.Font.Bold = true;
                                    hdr.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(3, 14, 28));
                                    hdr.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                                }

                                currentRow++;
                                for (int i = 0; i < bookingFields.Length; i++)
                                {
                                    sheet.Cells[currentRow, i + 1] = row[bookingFields[i]].ToString();
                                }

                                currentRow += 2;

                                // Billing Info
                                sheet.Cells[currentRow, 1] = "💳 Billing Information";
                                sheet.Range[$"A{currentRow}", $"F{currentRow}"].Merge();
                                sheet.Range[$"A{currentRow}"].Font.Size = 14;
                                sheet.Range[$"A{currentRow}"].Font.Bold = true;
                                currentRow ++;

                                sheet.Cells[currentRow, 1] = "Bill ID";
                                sheet.Cells[currentRow, 2] = row["bill_id"];
                                sheet.Cells[currentRow, 1].Font.Bold = true;
                                currentRow++;

                                sheet.Cells[currentRow, 1] = "Payment Method";
                                sheet.Cells[currentRow, 2] = row["bill_mode"];
                                sheet.Cells[currentRow, 1].Font.Bold = true;
                                currentRow++;

                                sheet.Cells[currentRow, 1] = "Bill Date";
                                sheet.Cells[currentRow, 2] = row["bill_date"];
                                sheet.Cells[currentRow, 1].Font.Bold = true;
                                currentRow++;

                                sheet.Cells[currentRow, 1] = "Room Price";
                                sheet.Cells[currentRow, 2] = row["original_amount"];
                                sheet.Cells[currentRow, 2].NumberFormat = "₱#,##0.00";
                                sheet.Cells[currentRow, 1].Font.Bold = true;
                                currentRow +=2;

                                // Total With Tax Highlight
                                sheet.Cells[currentRow, 1] = "Total Payment With Tax:";
                                sheet.Cells[currentRow, 2] = row["total_with_tax"];
                                Excel.Range taxLabel = sheet.Cells[currentRow, 1];
                                Excel.Range taxValue = sheet.Cells[currentRow, 2];

                                taxLabel.Font.Size = 13;
                                taxLabel.Font.Bold = true;

                                taxValue.Font.Size = 13;
                                taxValue.Font.Bold = true;
                                taxValue.NumberFormat = "₱#,##0.00";

                                taxValue.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(234, 125, 132)); // Pure red
                                taxValue.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White); // Optional: white text for contrast
                                currentRow += 2;

                                sheet.Columns.AutoFit();

                                // SAVE
                                string fileName = $"Invoice_{row["bill_id"]}_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
                                string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                                workbook.SaveAs(savePath);
                                workbook.Close(false);
                                excelApp.Quit();

                                MessageBox.Show($"Invoice saved to:\n{savePath}", "Success");
                            }
                            else
                            {
                                MessageBox.Show("No invoice data returned.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating invoice: " + ex.Message);
                }
            }
        }

        private void ClearBookingFields()
        {
            dashbooking_id.Clear();
            dashroom_id.SelectedIndex = -1;
            dashfullname.Clear();
            dashtotalamount.Clear();
            dashcheckin.Value = DateTime.Now;
            dashcheckout.Value = DateTime.Now;
            dashSearch.Clear();
        }

        private int getBookingID;
        
        private void deleteBooking_Click(object sender, EventArgs e)
        {
            if (getBookingID == 0)
            {
                MessageBox.Show("Please select a booking to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user before deleting
            if (MessageBox.Show("Are you sure you want to delete this booking",
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
                        string deleteQuery = "DELETE FROM booking WHERE booking_id = @bookingID";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            // Add parameter to avoid SQL injection
                            cmd.Parameters.AddWithValue("@bookingID", getBookingID);

                            // Execute the delete query
                            int result = cmd.ExecuteNonQuery();

                            // Check if the deletion was successful
                            if (result > 0)
                            {
                                // Refresh the DataGridView after deletion
                                LoadBookingData();

                                // Clear the input fields
                                ClearBookingFields();

                                // Show success message
                                MessageBox.Show("Booking deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // If no rows were affected, show an error message
                                MessageBox.Show("Failed to delete booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Catch any errors and display them
                        MessageBox.Show("Failed to delete booking.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Search and filtering
        private void dashSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = dashSearch.Text.Trim();
            LoadBookingData(searchTerm);
        }
    }
}
