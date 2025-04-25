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
    public partial class LoginForm : Form
    {
        private ToolTip toolTip;

        public LoginForm()
        {
            InitializeComponent();

            toolTip = new ToolTip();
        }

        private void pictureBoxShowPass_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShowPass, "Show Password");
        }

        private void pictureBoxHidePass_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHidePass, "Hide Password");
        }

        private void pictureBoxShowPass_Click(object sender, EventArgs e)
        {
            pictureBoxShowPass.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHidePass.Show();
        }

        private void pictureBoxHidePass_Click(object sender, EventArgs e)
        {
            pictureBoxHidePass.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShowPass.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            dashboard Dashboard = new dashboard();

            // Show the Dashboard form
            Dashboard.Show();

            // Optionally, hide the LoginForm
            this.Hide();
        }
    }
}
