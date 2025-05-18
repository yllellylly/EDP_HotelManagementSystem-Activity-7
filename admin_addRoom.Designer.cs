namespace Hotel_System
{
    partial class admin_addRoom
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomStatus = new System.Windows.Forms.ComboBox();
            this.roomType = new System.Windows.Forms.ComboBox();
            this.deleteRoom = new System.Windows.Forms.Button();
            this.updateRoom = new System.Windows.Forms.Button();
            this.addRoom = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.roomPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dataGridViewRoom);
            this.panel2.Location = new System.Drawing.Point(396, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 743);
            this.panel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Room Summary";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRoom.EnableHeadersVisualStyles = false;
            this.dataGridViewRoom.Location = new System.Drawing.Point(31, 84);
            this.dataGridViewRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRoom.RowHeadersVisible = false;
            this.dataGridViewRoom.RowHeadersWidth = 51;
            this.dataGridViewRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewRoom.RowTemplate.Height = 24;
            this.dataGridViewRoom.Size = new System.Drawing.Size(742, 634);
            this.dataGridViewRoom.TabIndex = 0;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick_1);
            this.dataGridViewRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.roomStatus);
            this.panel1.Controls.Add(this.roomType);
            this.panel1.Controls.Add(this.deleteRoom);
            this.panel1.Controls.Add(this.updateRoom);
            this.panel1.Controls.Add(this.addRoom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.roomPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 743);
            this.panel1.TabIndex = 2;
            // 
            // roomStatus
            // 
            this.roomStatus.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomStatus.FormattingEnabled = true;
            this.roomStatus.Items.AddRange(new object[] {
            "Available",
            "Occupied"});
            this.roomStatus.Location = new System.Drawing.Point(55, 250);
            this.roomStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomStatus.Name = "roomStatus";
            this.roomStatus.Size = new System.Drawing.Size(227, 29);
            this.roomStatus.TabIndex = 21;
            this.roomStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.roomType.Location = new System.Drawing.Point(56, 79);
            this.roomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(227, 29);
            this.roomType.TabIndex = 20;
            // 
            // deleteRoom
            // 
            this.deleteRoom.BackColor = System.Drawing.Color.Brown;
            this.deleteRoom.FlatAppearance.BorderSize = 0;
            this.deleteRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.deleteRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.deleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRoom.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRoom.ForeColor = System.Drawing.Color.White;
            this.deleteRoom.Location = new System.Drawing.Point(55, 456);
            this.deleteRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteRoom.Name = "deleteRoom";
            this.deleteRoom.Size = new System.Drawing.Size(227, 40);
            this.deleteRoom.TabIndex = 17;
            this.deleteRoom.Text = "Delete";
            this.deleteRoom.UseVisualStyleBackColor = false;
            this.deleteRoom.Click += new System.EventHandler(this.deleteRoom_Click);
            // 
            // updateRoom
            // 
            this.updateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.updateRoom.FlatAppearance.BorderSize = 0;
            this.updateRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.updateRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.updateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateRoom.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRoom.ForeColor = System.Drawing.Color.White;
            this.updateRoom.Location = new System.Drawing.Point(55, 398);
            this.updateRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateRoom.Name = "updateRoom";
            this.updateRoom.Size = new System.Drawing.Size(227, 40);
            this.updateRoom.TabIndex = 16;
            this.updateRoom.Text = "Update";
            this.updateRoom.UseVisualStyleBackColor = false;
            this.updateRoom.Click += new System.EventHandler(this.updateRoom_Click);
            // 
            // addRoom
            // 
            this.addRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.addRoom.FlatAppearance.BorderSize = 0;
            this.addRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.addRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.addRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoom.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoom.ForeColor = System.Drawing.Color.White;
            this.addRoom.Location = new System.Drawing.Point(55, 340);
            this.addRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(227, 40);
            this.addRoom.TabIndex = 15;
            this.addRoom.Text = "Add";
            this.addRoom.UseVisualStyleBackColor = false;
            this.addRoom.Click += new System.EventHandler(this.addRoom_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Status";
            // 
            // roomPrice
            // 
            this.roomPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPrice.Location = new System.Drawing.Point(56, 164);
            this.roomPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(227, 28);
            this.roomPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Type";
            // 
            // admin_addRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "admin_addRoom";
            this.Size = new System.Drawing.Size(1219, 788);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteRoom;
        private System.Windows.Forms.Button updateRoom;
        private System.Windows.Forms.Button addRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roomPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roomType;
        private System.Windows.Forms.ComboBox roomStatus;
    }
}
