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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            panelMain = new Panel();
            panelMain.Dock = DockStyle.Fill;
            this.Controls.Add(panelMain);
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();        // Remove previous control
            uc.Dock = DockStyle.Fill;          // Fill the panel
            panelMain.Controls.Add(uc);        // Add new control
        }

        private void buttonGotoGuest_Click(object sender, EventArgs e)
        {
            admin_addGuest1.Visible = true;
            admin_dashboard1.Visible = false;
            admin_addBooking1.Visible = false;
            admin_addRoom1.Visible = false;
            admin_systemUsers1.Visible = false;
            admin_history1.Visible = false;

            admin_addGuest adGuest = admin_addGuest1 as admin_addGuest;

            if (adGuest != null)
            {
                adGuest.refreshData();
            }
        }

        private void buttonGotoRoom_Click(object sender, EventArgs e)
        {
            admin_addGuest1.Visible = false;
            admin_dashboard1.Visible = false;
            admin_addBooking1.Visible = false;
            admin_addRoom1.Visible = true;
            admin_systemUsers1.Visible = false;
            admin_history1.Visible = false;

            admin_addRoom adRoom = admin_addRoom1 as admin_addRoom;

            if (adRoom != null)
            {
                adRoom.refreshData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_addGuest1.Visible = false;
            admin_dashboard1.Visible = true;
            admin_addBooking1.Visible = false;
            admin_addRoom1.Visible = false;
            admin_systemUsers1.Visible = false;
            admin_history1.Visible = false;

            admin_dashboard adDash = admin_dashboard1 as admin_dashboard;

            if (adDash != null)
            {
                adDash.refreshData();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void goToBookings_Click(object sender, EventArgs e)
        {
            admin_addGuest1.Visible = false;
            admin_dashboard1.Visible = false;
            admin_addBooking1.Visible = true;
            admin_addRoom1.Visible = false;
            admin_systemUsers1.Visible = false;
            admin_history1.Visible = false;

            admin_addBooking adBooking = admin_addBooking1 as admin_addBooking;

            if (adBooking != null)
            {
                adBooking.refreshData();
            }
        }

        private void gotoUsers_Click(object sender, EventArgs e)
        {
            admin_addGuest1.Visible = false;
            admin_dashboard1.Visible = false;
            admin_addBooking1.Visible = false;
            admin_addRoom1.Visible = false;
            admin_systemUsers1.Visible = true;
            admin_history1.Visible = false;

            admin_systemUsers adSysUser = admin_systemUsers1 as admin_systemUsers;

            if (adSysUser != null)
            {
                adSysUser.refreshData();
            }
        }

        private void gotoHistory_Click(object sender, EventArgs e)
        {
            admin_addGuest1.Visible = false;
            admin_dashboard1.Visible = false;
            admin_addBooking1.Visible = false;
            admin_addRoom1.Visible = false;
            admin_systemUsers1.Visible = false;
            admin_history1.Visible = true;

            admin_history adHistory = admin_history1 as admin_history;

            if (adHistory != null)
            {
                adHistory.refreshData();
            }
        }
    }
}
