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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.booking_form = new System.Windows.Forms.Panel();
            this.Broomprice = new System.Windows.Forms.TextBox();
            this.Bpayment_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Bpayment_method = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BGuestName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeCheckOUT = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCheckIN = new System.Windows.Forms.DateTimePicker();
            this.BroomType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddBooking = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridRoomAvailSummary = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridBooking = new System.Windows.Forms.DataGridView();
            this.booking_form.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomAvailSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // booking_form
            // 
            this.booking_form.BackColor = System.Drawing.Color.White;
            this.booking_form.Controls.Add(this.Broomprice);
            this.booking_form.Controls.Add(this.Bpayment_status);
            this.booking_form.Controls.Add(this.label10);
            this.booking_form.Controls.Add(this.Bpayment_method);
            this.booking_form.Controls.Add(this.label9);
            this.booking_form.Controls.Add(this.BGuestName);
            this.booking_form.Controls.Add(this.label8);
            this.booking_form.Controls.Add(this.label5);
            this.booking_form.Controls.Add(this.dateTimeCheckOUT);
            this.booking_form.Controls.Add(this.dateTimeCheckIN);
            this.booking_form.Controls.Add(this.BroomType);
            this.booking_form.Controls.Add(this.label3);
            this.booking_form.Controls.Add(this.buttonAddBooking);
            this.booking_form.Controls.Add(this.label7);
            this.booking_form.Controls.Add(this.label2);
            this.booking_form.Controls.Add(this.label1);
            this.booking_form.Location = new System.Drawing.Point(849, 21);
            this.booking_form.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.booking_form.Name = "booking_form";
            this.booking_form.Size = new System.Drawing.Size(348, 748);
            this.booking_form.TabIndex = 4;
            // 
            // Broomprice
            // 
            this.Broomprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Broomprice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Broomprice.Location = new System.Drawing.Point(52, 465);
            this.Broomprice.Name = "Broomprice";
            this.Broomprice.Size = new System.Drawing.Size(251, 28);
            this.Broomprice.TabIndex = 36;
            // 
            // Bpayment_status
            // 
            this.Bpayment_status.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpayment_status.FormattingEnabled = true;
            this.Bpayment_status.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "Failed"});
            this.Bpayment_status.Location = new System.Drawing.Point(52, 602);
            this.Bpayment_status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bpayment_status.Name = "Bpayment_status";
            this.Bpayment_status.Size = new System.Drawing.Size(250, 29);
            this.Bpayment_status.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 582);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Payment Status";
            // 
            // Bpayment_method
            // 
            this.Bpayment_method.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpayment_method.FormattingEnabled = true;
            this.Bpayment_method.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.Bpayment_method.Location = new System.Drawing.Point(52, 533);
            this.Bpayment_method.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bpayment_method.Name = "Bpayment_method";
            this.Bpayment_method.Size = new System.Drawing.Size(250, 29);
            this.Bpayment_method.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Payment Method";
            // 
            // BGuestName
            // 
            this.BGuestName.FormattingEnabled = true;
            this.BGuestName.Location = new System.Drawing.Point(56, 172);
            this.BGuestName.Name = "BGuestName";
            this.BGuestName.Size = new System.Drawing.Size(249, 29);
            this.BGuestName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Room Price";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.dateTimeCheckOUT.Location = new System.Drawing.Point(53, 399);
            this.dateTimeCheckOUT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeCheckOUT.Name = "dateTimeCheckOUT";
            this.dateTimeCheckOUT.Size = new System.Drawing.Size(250, 28);
            this.dateTimeCheckOUT.TabIndex = 24;
            // 
            // dateTimeCheckIN
            // 
            this.dateTimeCheckIN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCheckIN.Location = new System.Drawing.Point(53, 322);
            this.dateTimeCheckIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeCheckIN.Name = "dateTimeCheckIN";
            this.dateTimeCheckIN.Size = new System.Drawing.Size(250, 28);
            this.dateTimeCheckIN.TabIndex = 23;
            // 
            // BroomType
            // 
            this.BroomType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BroomType.FormattingEnabled = true;
            this.BroomType.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Suite Room",
            "Deluxe Room",
            "Penthouse Room"});
            this.BroomType.Location = new System.Drawing.Point(55, 249);
            this.BroomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BroomType.Name = "BroomType";
            this.BroomType.Size = new System.Drawing.Size(250, 29);
            this.BroomType.TabIndex = 20;
            this.BroomType.SelectedIndexChanged += new System.EventHandler(this.BroomType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Guest Name";
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
            this.buttonAddBooking.Location = new System.Drawing.Point(52, 680);
            this.buttonAddBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddBooking.Name = "buttonAddBooking";
            this.buttonAddBooking.Size = new System.Drawing.Size(250, 40);
            this.buttonAddBooking.TabIndex = 15;
            this.buttonAddBooking.Text = "Add";
            this.buttonAddBooking.UseVisualStyleBackColor = false;
            this.buttonAddBooking.Click += new System.EventHandler(this.buttonAddBooking_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 379);
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
            this.label2.Location = new System.Drawing.Point(50, 302);
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
            this.label1.Location = new System.Drawing.Point(51, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridRoomAvailSummary);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridBooking);
            this.panel2.Location = new System.Drawing.Point(20, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 748);
            this.panel2.TabIndex = 27;
            // 
            // dataGridRoomAvailSummary
            // 
            this.dataGridRoomAvailSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRoomAvailSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRoomAvailSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRoomAvailSummary.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRoomAvailSummary.EnableHeadersVisualStyles = false;
            this.dataGridRoomAvailSummary.Location = new System.Drawing.Point(24, 489);
            this.dataGridRoomAvailSummary.Name = "dataGridRoomAvailSummary";
            this.dataGridRoomAvailSummary.RowHeadersVisible = false;
            this.dataGridRoomAvailSummary.RowHeadersWidth = 51;
            this.dataGridRoomAvailSummary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridRoomAvailSummary.RowTemplate.Height = 24;
            this.dataGridRoomAvailSummary.Size = new System.Drawing.Size(761, 231);
            this.dataGridRoomAvailSummary.TabIndex = 5;
            this.dataGridRoomAvailSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoomAvailSummary_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Room Availability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Booking Lists";
            // 
            // dataGridBooking
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBooking.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridBooking.EnableHeadersVisualStyles = false;
            this.dataGridBooking.Location = new System.Drawing.Point(24, 58);
            this.dataGridBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridBooking.Name = "dataGridBooking";
            this.dataGridBooking.RowHeadersVisible = false;
            this.dataGridBooking.RowHeadersWidth = 51;
            this.dataGridBooking.RowTemplate.Height = 24;
            this.dataGridBooking.Size = new System.Drawing.Size(761, 369);
            this.dataGridBooking.TabIndex = 2;
            this.dataGridBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBooking_CellContentClick);
            // 
            // admin_addBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.booking_form);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "admin_addBooking";
            this.Size = new System.Drawing.Size(1219, 788);
            this.booking_form.ResumeLayout(false);
            this.booking_form.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomAvailSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel booking_form;
        private System.Windows.Forms.ComboBox BroomType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddBooking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeCheckOUT;
        private System.Windows.Forms.DateTimePicker dateTimeCheckIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridBooking;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BGuestName;
        private System.Windows.Forms.ComboBox Bpayment_method;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Bpayment_status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Broomprice;
        private System.Windows.Forms.DataGridView dataGridRoomAvailSummary;
        private System.Windows.Forms.Label label6;
    }
}
