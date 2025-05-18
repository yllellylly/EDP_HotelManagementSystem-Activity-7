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
    public partial class admin_history : UserControl
    {
        string connStr = "server=localhost;user=admin1;password=admin123;database=hotel";
        public admin_history()
        {
            InitializeComponent();
            LoadHistory();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            LoadHistory();
        }

        private void LoadHistory()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT booking_id, guest_id, action, action_date_time FROM history";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridHistory.DataSource = dt;

                    // Optional: Customize column headers after binding
                    dataGridHistory.Columns["booking_id"].HeaderText = "Booking ID";
                    dataGridHistory.Columns["guest_id"].HeaderText = "Guest ID";
                    dataGridHistory.Columns["action"].HeaderText = "Action Performed";
                    dataGridHistory.Columns["action_date_time"].HeaderText = "Reservation Confirmed Date & Time";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load history data.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dataGrirdHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
