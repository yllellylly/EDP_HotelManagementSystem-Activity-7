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
            admin_addGuest guestsUC = new admin_addGuest();
            LoadUserControl(guestsUC);
        }

        private void buttonGotoRoom_Click(object sender, EventArgs e)
        {
            admin_addRoom roomUC = new admin_addRoom();
            LoadUserControl(roomUC);
        }
    }
}
