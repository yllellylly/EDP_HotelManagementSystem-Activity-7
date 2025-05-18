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
    public partial class admin_addBooking : UserControl
    {
        string connStr = "server=localhost;user=admin1;password=admin123;database=hotel";
        public admin_addBooking()
        {
            InitializeComponent();
            this.BroomType.SelectedIndexChanged += new System.EventHandler(this.BroomType_SelectedIndexChanged);
            //LoadGuestData();
            LoadBookingListData();
            LoadRoomReport();

            LoadGuestDropdown();  // Refresh guests
            LoadRoomDropdown();   // Refresh room types
        }

        //Refresh Data
        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            ClearBookingFields();
            LoadRoomReport();
            LoadBookingListData();
            LoadGuestDropdown();  // Refresh guests
            LoadRoomDropdown();   // Refresh room types
        }

        //Display the Room Availability Summary Using the procedures
        private void LoadRoomReport()
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // 1. Call UpdateRoomStatusWithCursor stored procedure first
                    using (MySqlCommand cmdUpdate = new MySqlCommand("hotel.UpdateRoomStatusWithCursor", conn))
                    {
                        cmdUpdate.CommandType = CommandType.StoredProcedure;
                        cmdUpdate.ExecuteNonQuery();  // This updates the status
                    }

                    // 2. Then call GenerateRoomReport to get the updated data
                    using (MySqlCommand cmdReport = new MySqlCommand("hotel.GenerateRoomReport", conn))
                    {
                        cmdReport.CommandType = CommandType.StoredProcedure;

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmdReport);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridRoomAvailSummary.DataSource = dt;  // Bind to DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        //Display the guests
        private void LoadGuestData()
        {
            /*using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT guest_id, fname, lname, baranggay, city, province, postal_code FROM guest";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridGuests.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load guest data.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

        //Display the booking list
        private void LoadBookingListData()
        {
            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // 🔍 SELECT from your view
                    string query = "SELECT booking_id, full_name, full_address, room_id, check_in_date, check_out_date, total_amount, bill_mode FROM guestbookingdetails";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Bind to your DataGridView 
                    dataGridBooking.DataSource = table;

                    // Optional: Customize column headers after binding
                    dataGridBooking.Columns["booking_id"].HeaderText = "Booking ID";
                    dataGridBooking.Columns["full_name"].HeaderText = "Full Name";
                    dataGridBooking.Columns["full_address"].HeaderText = "Address";
                    dataGridBooking.Columns["room_id"].HeaderText = "Room ID";
                    dataGridBooking.Columns["check_in_date"].HeaderText = "Check In";
                    dataGridBooking.Columns["check_out_date"].HeaderText = "Check Out";
                    dataGridBooking.Columns["total_amount"].HeaderText = "Room Price";
                    dataGridBooking.Columns["bill_mode"].HeaderText = "Payment Method";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridBookingDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        //Load the guest name in the dropdown
        private void LoadGuestDropdown()
        {
            BGuestName.Items.Clear();

            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT guest_id, CONCAT(fname, ' ', lname) AS full_name FROM guest";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Display full name, store guest_id as value
                        BGuestName.Items.Add(new ComboBoxItem(reader["full_name"].ToString(), reader["guest_id"].ToString()));
                    }
                }
            }

            if (BGuestName.Items.Count > 0) BGuestName.SelectedIndex = 0;
        }

        //Load the room type in the dropdown
        private void LoadRoomDropdown()
        {
            BroomType.Items.Clear();

            string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT room_id, room_type FROM rooms";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Display room type, store room_id as value
                        BroomType.Items.Add(new ComboBoxItem(reader["room_type"].ToString(), reader["room_id"].ToString()));
                    }
                }
            }
        }

        //Load the price of the room in the dropdown
        private void Broomprice_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (BroomType.SelectedItem is ComboBoxItem selectedItem)
            {
                string roomId = selectedItem.Value;
                string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT price FROM rooms WHERE room_id = @room_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@room_id", roomId);
                        object price = cmd.ExecuteScalar();
                        if (price != null)
                        {
                            Broomprice.Text = price.ToString();
                        }
                        else
                        {
                            Broomprice.Text = "";
                        }
                    }
                }
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BroomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BroomType.SelectedItem is ComboBoxItem selectedItem)
            {
                string roomId = selectedItem.Value;
                string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT price FROM rooms WHERE room_id = @room_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@room_id", roomId);
                        object price = cmd.ExecuteScalar();
                        if (price != null)
                        {
                            Broomprice.Text = price.ToString();
                        }
                        else
                        {
                            Broomprice.Text = "";
                        }
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //Clear all fields
        private void ClearBookingFields()
        {
            BGuestName.SelectedIndex = -1;
            BroomType.SelectedIndex = -1;
            Broomprice.Text = string.Empty;
            Bpayment_method.SelectedIndex = -1;
            Bpayment_status.SelectedIndex = -1;
        }

        //Add new booking and displaying the details using the View
        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            /*try
            {
                ComboBoxItem selectedGuest = BGuestName.SelectedItem as ComboBoxItem;
                ComboBoxItem selectedRoom = BroomType.SelectedItem as ComboBoxItem;

                if (selectedGuest == null || selectedRoom == null)
                {
                    MessageBox.Show("Please select both a guest and a room.");
                    return;
                }

                if (!int.TryParse(selectedGuest?.Value, out int guestId) || !int.TryParse(selectedRoom?.Value, out int roomId))
                {
                    MessageBox.Show("Invalid Guest or Room selection.");
                    return;
                }

                if (!decimal.TryParse(Broomprice.Text, out decimal roomPrice))
                {
                    MessageBox.Show("Room price is not valid.");
                    return;
                }

                if (Bpayment_method.SelectedItem == null || Bpayment_status.SelectedItem == null)
                {
                    MessageBox.Show("Please select both payment method and status.");
                    return;
                }

                DateTime checkIn = dateTimeCheckIN.Value;
                DateTime checkOut = dateTimeCheckOUT.Value;
                string paymentMode = Bpayment_method.SelectedItem.ToString();
                string paymentStatus = Bpayment_status.SelectedItem.ToString();

                string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string bookingQuery = @"INSERT INTO booking (guest_id, room_id, check_in_date, check_out_date, total_amount) 
                                        VALUES (@guest_id, @room_id, @checkin, @checkout, @amount)";
                        MySqlCommand bookingCmd = new MySqlCommand(bookingQuery, conn, transaction);
                        bookingCmd.Parameters.AddWithValue("@guest_id", guestId);
                        bookingCmd.Parameters.AddWithValue("@room_id", roomId);
                        bookingCmd.Parameters.AddWithValue("@checkin", checkIn);
                        bookingCmd.Parameters.AddWithValue("@checkout", checkOut);
                        bookingCmd.Parameters.AddWithValue("@amount", roomPrice);
                        bookingCmd.ExecuteNonQuery();

                        long bookingId = bookingCmd.LastInsertedId;

                        string paymentQuery = @"INSERT INTO payment (booking_id, bill_date, bill_amount, bill_mode, payment_status)
                                        VALUES (@booking_id, @bill_date, @amount, @mode, @status)";
                        MySqlCommand paymentCmd = new MySqlCommand(paymentQuery, conn, transaction);
                        paymentCmd.Parameters.AddWithValue("@booking_id", bookingId);
                        paymentCmd.Parameters.AddWithValue("@bill_date", DateTime.Now);
                        paymentCmd.Parameters.AddWithValue("@amount", roomPrice);
                        paymentCmd.Parameters.AddWithValue("@mode", paymentMode);
                        paymentCmd.Parameters.AddWithValue("@status", paymentStatus);
                        paymentCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Booking and payment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadBookingListData();
                        LoadRoomReport();
                        LoadGuestDropdown();  // Refresh guests
                        LoadRoomDropdown();   // Refresh room types
                        ClearBookingFields();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Failed to save data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            try
            {
                ComboBoxItem selectedGuest = BGuestName.SelectedItem as ComboBoxItem;
                ComboBoxItem selectedRoom = BroomType.SelectedItem as ComboBoxItem;

                if (selectedGuest == null || selectedRoom == null)
                {
                    MessageBox.Show("Please select both a guest and a room.");
                    return;
                }

                if (!int.TryParse(selectedGuest?.Value, out int guestId) || !int.TryParse(selectedRoom?.Value, out int roomId))
                {
                    MessageBox.Show("Invalid Guest or Room selection.");
                    return;
                }

                if (!decimal.TryParse(Broomprice.Text, out decimal roomPrice))
                {
                    MessageBox.Show("Room price is not valid.");
                    return;
                }

                if (Bpayment_method.SelectedItem == null || Bpayment_status.SelectedItem == null)
                {
                    MessageBox.Show("Please select both payment method and status.");
                    return;
                }

                DateTime checkIn = dateTimeCheckIN.Value.Date;
                DateTime checkOut = dateTimeCheckOUT.Value.Date;
                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check-out date must be after check-in date.");
                    return;
                }

                string paymentMode = Bpayment_method.SelectedItem.ToString();
                string paymentStatus = Bpayment_status.SelectedItem.ToString();

                string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Check for booking conflicts
                        string conflictCheckQuery = @"
                        SELECT COUNT(*) FROM booking
                        WHERE room_id = @room_id
                        AND check_in_date < @check_out
                        AND check_out_date > @check_in";

                        MySqlCommand conflictCmd = new MySqlCommand(conflictCheckQuery, conn, transaction);
                        conflictCmd.Parameters.AddWithValue("@room_id", roomId);
                        conflictCmd.Parameters.AddWithValue("@check_in", checkIn);
                        conflictCmd.Parameters.AddWithValue("@check_out", checkOut);

                        int conflictCount = Convert.ToInt32(conflictCmd.ExecuteScalar());

                        if (conflictCount > 0)
                        {
                            MessageBox.Show("The selected room is already booked during the chosen dates. Please select different dates or room.", "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }

                        // No conflict, proceed with insertion
                        string bookingQuery = @"INSERT INTO booking (guest_id, room_id, check_in_date, check_out_date, total_amount) 
                                VALUES (@guest_id, @room_id, @checkin, @checkout, @amount)";
                        MySqlCommand bookingCmd = new MySqlCommand(bookingQuery, conn, transaction);
                        bookingCmd.Parameters.AddWithValue("@guest_id", guestId);
                        bookingCmd.Parameters.AddWithValue("@room_id", roomId);
                        bookingCmd.Parameters.AddWithValue("@checkin", checkIn);
                        bookingCmd.Parameters.AddWithValue("@checkout", checkOut);
                        bookingCmd.Parameters.AddWithValue("@amount", roomPrice);
                        bookingCmd.ExecuteNonQuery();

                        long bookingId = bookingCmd.LastInsertedId;

                        string paymentQuery = @"INSERT INTO payment (booking_id, bill_date, bill_amount, bill_mode, payment_status)
                                VALUES (@booking_id, @bill_date, @amount, @mode, @status)";
                        MySqlCommand paymentCmd = new MySqlCommand(paymentQuery, conn, transaction);
                        paymentCmd.Parameters.AddWithValue("@booking_id", bookingId);
                        paymentCmd.Parameters.AddWithValue("@bill_date", DateTime.Now);
                        paymentCmd.Parameters.AddWithValue("@amount", roomPrice);
                        paymentCmd.Parameters.AddWithValue("@mode", paymentMode);
                        paymentCmd.Parameters.AddWithValue("@status", paymentStatus);
                        paymentCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Booking and payment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadBookingListData();
                        LoadRoomReport();
                        LoadGuestDropdown();  // Refresh guests
                        LoadRoomDropdown();   // Refresh room types
                        ClearBookingFields();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Failed to save data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {

        }

        private void dataGridRoomAvailSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
