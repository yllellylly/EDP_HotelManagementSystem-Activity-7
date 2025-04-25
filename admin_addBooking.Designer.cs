namespace Hotel_System
{
    partial class admin_addBooking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeCheckOUT = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCheckIN = new System.Windows.Forms.DateTimePicker();
            this.roomType = new System.Windows.Forms.ComboBox();
            this.textBoxGuestName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeleteBooking = new System.Windows.Forms.Button();
            this.buttonUpdateBooking = new System.Windows.Forms.Button();
            this.buttonAddBooking = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridBookingDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimeCheckOUT);
            this.panel1.Controls.Add(this.dateTimeCheckIN);
            this.panel1.Controls.Add(this.roomType);
            this.panel1.Controls.Add(this.textBoxGuestName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonDeleteBooking);
            this.panel1.Controls.Add(this.buttonUpdateBooking);
            this.panel1.Controls.Add(this.buttonAddBooking);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(849, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 748);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Create New Booking";
            // 
            // dateTimeCheckOUT
            // 
            this.dateTimeCheckOUT.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCheckOUT.Location = new System.Drawing.Point(64, 398);
            this.dateTimeCheckOUT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeCheckOUT.Name = "dateTimeCheckOUT";
            this.dateTimeCheckOUT.Size = new System.Drawing.Size(224, 28);
            this.dateTimeCheckOUT.TabIndex = 24;
            // 
            // dateTimeCheckIN
            // 
            this.dateTimeCheckIN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCheckIN.Location = new System.Drawing.Point(65, 314);
            this.dateTimeCheckIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeCheckIN.Name = "dateTimeCheckIN";
            this.dateTimeCheckIN.Size = new System.Drawing.Size(224, 28);
            this.dateTimeCheckIN.TabIndex = 23;
            // 
            // roomType
            // 
            this.roomType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType.FormattingEnabled = true;
            this.roomType.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Suite Room",
            "Deluxe Room",
            "Penthouse Room"});
            this.roomType.Location = new System.Drawing.Point(66, 239);
            this.roomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(227, 29);
            this.roomType.TabIndex = 20;
            // 
            // textBoxGuestName
            // 
            this.textBoxGuestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGuestName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGuestName.Location = new System.Drawing.Point(66, 159);
            this.textBoxGuestName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuestName.Name = "textBoxGuestName";
            this.textBoxGuestName.Size = new System.Drawing.Size(227, 28);
            this.textBoxGuestName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Guest Name";
            // 
            // buttonDeleteBooking
            // 
            this.buttonDeleteBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.buttonDeleteBooking.FlatAppearance.BorderSize = 0;
            this.buttonDeleteBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.buttonDeleteBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.buttonDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteBooking.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteBooking.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteBooking.Location = new System.Drawing.Point(66, 659);
            this.buttonDeleteBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteBooking.Name = "buttonDeleteBooking";
            this.buttonDeleteBooking.Size = new System.Drawing.Size(227, 52);
            this.buttonDeleteBooking.TabIndex = 17;
            this.buttonDeleteBooking.Text = "Delete";
            this.buttonDeleteBooking.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateBooking
            // 
            this.buttonUpdateBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.buttonUpdateBooking.FlatAppearance.BorderSize = 0;
            this.buttonUpdateBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.buttonUpdateBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.buttonUpdateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateBooking.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateBooking.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateBooking.Location = new System.Drawing.Point(66, 599);
            this.buttonUpdateBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdateBooking.Name = "buttonUpdateBooking";
            this.buttonUpdateBooking.Size = new System.Drawing.Size(227, 52);
            this.buttonUpdateBooking.TabIndex = 16;
            this.buttonUpdateBooking.Text = "Update";
            this.buttonUpdateBooking.UseVisualStyleBackColor = false;
            // 
            // buttonAddBooking
            // 
            this.buttonAddBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.buttonAddBooking.FlatAppearance.BorderSize = 0;
            this.buttonAddBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.buttonAddBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.buttonAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBooking.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBooking.ForeColor = System.Drawing.Color.White;
            this.buttonAddBooking.Location = new System.Drawing.Point(66, 539);
            this.buttonAddBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddBooking.Name = "buttonAddBooking";
            this.buttonAddBooking.Size = new System.Drawing.Size(227, 52);
            this.buttonAddBooking.TabIndex = 15;
            this.buttonAddBooking.Text = "Add";
            this.buttonAddBooking.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Check out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Check-in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Type";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridBookingDetails);
            this.panel2.Location = new System.Drawing.Point(20, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 748);
            this.panel2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Booking Details";
            // 
            // dataGridBookingDetails
            // 
            this.dataGridBookingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBookingDetails.Location = new System.Drawing.Point(25, 84);
            this.dataGridBookingDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridBookingDetails.Name = "dataGridBookingDetails";
            this.dataGridBookingDetails.RowHeadersWidth = 51;
            this.dataGridBookingDetails.RowTemplate.Height = 24;
            this.dataGridBookingDetails.Size = new System.Drawing.Size(761, 643);
            this.dataGridBookingDetails.TabIndex = 0;
            // 
            // admin_addBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "admin_addBooking";
            this.Size = new System.Drawing.Size(1219, 788);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookingDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox roomType;
        private System.Windows.Forms.TextBox textBoxGuestName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeleteBooking;
        private System.Windows.Forms.Button buttonUpdateBooking;
        private System.Windows.Forms.Button buttonAddBooking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeCheckOUT;
        private System.Windows.Forms.DateTimePicker dateTimeCheckIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridBookingDetails;
        private System.Windows.Forms.Label label6;
    }
}
