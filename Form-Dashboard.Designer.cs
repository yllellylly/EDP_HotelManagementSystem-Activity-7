namespace Hotel_System
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gotoHistory = new System.Windows.Forms.Button();
            this.gotoUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.goToBookings = new System.Windows.Forms.Button();
            this.gotoRoom = new System.Windows.Forms.Button();
            this.gotoGuest = new System.Windows.Forms.Button();
            this.gotoDash = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.admin_dashboard1 = new Hotel_System.admin_dashboard();
            this.admin_addGuest1 = new Hotel_System.admin_addGuest();
            this.admin_addRoom1 = new Hotel_System.admin_addRoom();
            this.admin_addBooking1 = new Hotel_System.admin_addBooking();
            this.admin_systemUsers1 = new Hotel_System.admin_systemUsers();
            this.admin_history1 = new Hotel_System.admin_history();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.gotoHistory);
            this.panel1.Controls.Add(this.gotoUsers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.goToBookings);
            this.panel1.Controls.Add(this.gotoRoom);
            this.panel1.Controls.Add(this.gotoGuest);
            this.panel1.Controls.Add(this.gotoDash);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 788);
            this.panel1.TabIndex = 0;
            // 
            // gotoHistory
            // 
            this.gotoHistory.BackColor = System.Drawing.Color.Transparent;
            this.gotoHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.gotoHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.gotoHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoHistory.ForeColor = System.Drawing.Color.Transparent;
            this.gotoHistory.Location = new System.Drawing.Point(64, 549);
            this.gotoHistory.Name = "gotoHistory";
            this.gotoHistory.Size = new System.Drawing.Size(175, 50);
            this.gotoHistory.TabIndex = 9;
            this.gotoHistory.Text = "HISTORY";
            this.gotoHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gotoHistory.UseVisualStyleBackColor = false;
            this.gotoHistory.Click += new System.EventHandler(this.gotoHistory_Click);
            // 
            // gotoUsers
            // 
            this.gotoUsers.BackColor = System.Drawing.Color.Transparent;
            this.gotoUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.gotoUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.gotoUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoUsers.ForeColor = System.Drawing.Color.Transparent;
            this.gotoUsers.Location = new System.Drawing.Point(64, 476);
            this.gotoUsers.Name = "gotoUsers";
            this.gotoUsers.Size = new System.Drawing.Size(175, 50);
            this.gotoUsers.TabIndex = 8;
            this.gotoUsers.Text = "SYSTEM USERS";
            this.gotoUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gotoUsers.UseVisualStyleBackColor = false;
            this.gotoUsers.Click += new System.EventHandler(this.gotoUsers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hotel Management System";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.Transparent;
            this.logoutButton.Location = new System.Drawing.Point(64, 718);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(175, 50);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "LOG OUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // goToBookings
            // 
            this.goToBookings.BackColor = System.Drawing.Color.Transparent;
            this.goToBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToBookings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.goToBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.goToBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToBookings.ForeColor = System.Drawing.Color.Transparent;
            this.goToBookings.Location = new System.Drawing.Point(64, 407);
            this.goToBookings.Name = "goToBookings";
            this.goToBookings.Size = new System.Drawing.Size(175, 50);
            this.goToBookings.TabIndex = 5;
            this.goToBookings.Text = "BOOKINGS";
            this.goToBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToBookings.UseVisualStyleBackColor = false;
            this.goToBookings.Click += new System.EventHandler(this.goToBookings_Click);
            // 
            // gotoRoom
            // 
            this.gotoRoom.BackColor = System.Drawing.Color.Transparent;
            this.gotoRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.gotoRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.gotoRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoRoom.ForeColor = System.Drawing.Color.Transparent;
            this.gotoRoom.Location = new System.Drawing.Point(64, 337);
            this.gotoRoom.Name = "gotoRoom";
            this.gotoRoom.Size = new System.Drawing.Size(175, 50);
            this.gotoRoom.TabIndex = 4;
            this.gotoRoom.Text = "ROOMS";
            this.gotoRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gotoRoom.UseVisualStyleBackColor = false;
            this.gotoRoom.Click += new System.EventHandler(this.buttonGotoRoom_Click);
            // 
            // gotoGuest
            // 
            this.gotoGuest.BackColor = System.Drawing.Color.Transparent;
            this.gotoGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.gotoGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.gotoGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoGuest.ForeColor = System.Drawing.Color.Transparent;
            this.gotoGuest.Location = new System.Drawing.Point(64, 270);
            this.gotoGuest.Name = "gotoGuest";
            this.gotoGuest.Size = new System.Drawing.Size(175, 50);
            this.gotoGuest.TabIndex = 3;
            this.gotoGuest.Text = "GUESTS";
            this.gotoGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gotoGuest.UseVisualStyleBackColor = false;
            this.gotoGuest.Click += new System.EventHandler(this.buttonGotoGuest_Click);
            // 
            // gotoDash
            // 
            this.gotoDash.BackColor = System.Drawing.Color.Transparent;
            this.gotoDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoDash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.gotoDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.gotoDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoDash.ForeColor = System.Drawing.Color.Transparent;
            this.gotoDash.Location = new System.Drawing.Point(64, 199);
            this.gotoDash.Name = "gotoDash";
            this.gotoDash.Size = new System.Drawing.Size(175, 50);
            this.gotoDash.TabIndex = 2;
            this.gotoDash.Text = "DASHBOARD";
            this.gotoDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gotoDash.UseVisualStyleBackColor = false;
            this.gotoDash.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Masión";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMain.Controls.Add(this.admin_dashboard1);
            this.panelMain.Controls.Add(this.admin_addGuest1);
            this.panelMain.Controls.Add(this.admin_addRoom1);
            this.panelMain.Controls.Add(this.admin_addBooking1);
            this.panelMain.Controls.Add(this.admin_systemUsers1);
            this.panelMain.Controls.Add(this.admin_history1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(306, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1219, 788);
            this.panelMain.TabIndex = 1;
            // 
            // admin_dashboard1
            // 
            this.admin_dashboard1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.admin_dashboard1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.admin_dashboard1.Location = new System.Drawing.Point(0, 0);
            this.admin_dashboard1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.admin_dashboard1.Name = "admin_dashboard1";
            this.admin_dashboard1.Size = new System.Drawing.Size(1219, 788);
            this.admin_dashboard1.TabIndex = 5;
            // 
            // admin_addGuest1
            // 
            this.admin_addGuest1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.admin_addGuest1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_addGuest1.Location = new System.Drawing.Point(0, 0);
            this.admin_addGuest1.Name = "admin_addGuest1";
            this.admin_addGuest1.Size = new System.Drawing.Size(1219, 788);
            this.admin_addGuest1.TabIndex = 4;
            // 
            // admin_addRoom1
            // 
            this.admin_addRoom1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.admin_addRoom1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.admin_addRoom1.Location = new System.Drawing.Point(0, 0);
            this.admin_addRoom1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.admin_addRoom1.Name = "admin_addRoom1";
            this.admin_addRoom1.Size = new System.Drawing.Size(1219, 788);
            this.admin_addRoom1.TabIndex = 3;
            // 
            // admin_addBooking1
            // 
            this.admin_addBooking1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.admin_addBooking1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_addBooking1.Location = new System.Drawing.Point(0, 0);
            this.admin_addBooking1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.admin_addBooking1.Name = "admin_addBooking1";
            this.admin_addBooking1.Size = new System.Drawing.Size(1219, 788);
            this.admin_addBooking1.TabIndex = 2;
            // 
            // admin_systemUsers1
            // 
            this.admin_systemUsers1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.admin_systemUsers1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.admin_systemUsers1.Location = new System.Drawing.Point(0, 0);
            this.admin_systemUsers1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.admin_systemUsers1.Name = "admin_systemUsers1";
            this.admin_systemUsers1.Size = new System.Drawing.Size(1219, 788);
            this.admin_systemUsers1.TabIndex = 1;
            // 
            // admin_history1
            // 
            this.admin_history1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.admin_history1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.admin_history1.Location = new System.Drawing.Point(0, 0);
            this.admin_history1.Name = "admin_history1";
            this.admin_history1.Size = new System.Drawing.Size(1219, 788);
            this.admin_history1.TabIndex = 0;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 788);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dashboard";
            this.Text = "The Masion | Dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button gotoDash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button goToBookings;
        private System.Windows.Forms.Button gotoRoom;
        private System.Windows.Forms.Button gotoGuest;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gotoUsers;
        private System.Windows.Forms.Button gotoHistory;
        private admin_addRoom admin_addRoom1;
        private admin_addBooking admin_addBooking1;
        private admin_systemUsers admin_systemUsers1;
        private admin_history admin_history1;
        private admin_dashboard admin_dashboard1;
        private admin_addGuest admin_addGuest1;
    }
}