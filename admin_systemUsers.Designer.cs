namespace Hotel_System
{
    partial class admin_systemUsers
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
            this.dataGridViewSystemUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.system_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.system_ustatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.system_username = new System.Windows.Forms.TextBox();
            this.deleteSystemUser = new System.Windows.Forms.Button();
            this.updateSystemUser = new System.Windows.Forms.Button();
            this.addsystemUser = new System.Windows.Forms.Button();
            this.system_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dataGridViewSystemUsers);
            this.panel2.Location = new System.Drawing.Point(433, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 740);
            this.panel2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "System Users";
            // 
            // dataGridViewSystemUsers
            // 
            this.dataGridViewSystemUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSystemUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSystemUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSystemUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSystemUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewSystemUsers.Location = new System.Drawing.Point(34, 110);
            this.dataGridViewSystemUsers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridViewSystemUsers.Name = "dataGridViewSystemUsers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSystemUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSystemUsers.RowHeadersVisible = false;
            this.dataGridViewSystemUsers.RowHeadersWidth = 51;
            this.dataGridViewSystemUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSystemUsers.RowTemplate.Height = 24;
            this.dataGridViewSystemUsers.Size = new System.Drawing.Size(693, 604);
            this.dataGridViewSystemUsers.TabIndex = 0;
            this.dataGridViewSystemUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSystemUsers_CellClick);
            this.dataGridViewSystemUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSystemUsers_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.system_pass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.system_ustatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.system_username);
            this.panel1.Controls.Add(this.deleteSystemUser);
            this.panel1.Controls.Add(this.updateSystemUser);
            this.panel1.Controls.Add(this.addsystemUser);
            this.panel1.Controls.Add(this.system_email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 740);
            this.panel1.TabIndex = 4;
            // 
            // system_pass
            // 
            this.system_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.system_pass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system_pass.Location = new System.Drawing.Point(63, 283);
            this.system_pass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.system_pass.Name = "system_pass";
            this.system_pass.Size = new System.Drawing.Size(255, 28);
            this.system_pass.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Password";
            // 
            // system_ustatus
            // 
            this.system_ustatus.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system_ustatus.FormattingEnabled = true;
            this.system_ustatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.system_ustatus.Location = new System.Drawing.Point(63, 368);
            this.system_ustatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.system_ustatus.Name = "system_ustatus";
            this.system_ustatus.Size = new System.Drawing.Size(256, 29);
            this.system_ustatus.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Status";
            // 
            // system_username
            // 
            this.system_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.system_username.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system_username.Location = new System.Drawing.Point(62, 110);
            this.system_username.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.system_username.Name = "system_username";
            this.system_username.Size = new System.Drawing.Size(255, 28);
            this.system_username.TabIndex = 22;
            // 
            // deleteSystemUser
            // 
            this.deleteSystemUser.BackColor = System.Drawing.Color.Brown;
            this.deleteSystemUser.FlatAppearance.BorderSize = 0;
            this.deleteSystemUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.deleteSystemUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.deleteSystemUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSystemUser.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSystemUser.ForeColor = System.Drawing.Color.White;
            this.deleteSystemUser.Location = new System.Drawing.Point(61, 568);
            this.deleteSystemUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.deleteSystemUser.Name = "deleteSystemUser";
            this.deleteSystemUser.Size = new System.Drawing.Size(255, 40);
            this.deleteSystemUser.TabIndex = 17;
            this.deleteSystemUser.Text = "Delete";
            this.deleteSystemUser.UseVisualStyleBackColor = false;
            this.deleteSystemUser.Click += new System.EventHandler(this.deleteSystemUser_Click);
            // 
            // updateSystemUser
            // 
            this.updateSystemUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.updateSystemUser.FlatAppearance.BorderSize = 0;
            this.updateSystemUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.updateSystemUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.updateSystemUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSystemUser.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSystemUser.ForeColor = System.Drawing.Color.White;
            this.updateSystemUser.Location = new System.Drawing.Point(61, 506);
            this.updateSystemUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.updateSystemUser.Name = "updateSystemUser";
            this.updateSystemUser.Size = new System.Drawing.Size(255, 40);
            this.updateSystemUser.TabIndex = 16;
            this.updateSystemUser.Text = "Update";
            this.updateSystemUser.UseVisualStyleBackColor = false;
            this.updateSystemUser.Click += new System.EventHandler(this.updateSystemUser_Click);
            // 
            // addsystemUser
            // 
            this.addsystemUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.addsystemUser.FlatAppearance.BorderSize = 0;
            this.addsystemUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.addsystemUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.addsystemUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addsystemUser.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsystemUser.ForeColor = System.Drawing.Color.White;
            this.addsystemUser.Location = new System.Drawing.Point(62, 446);
            this.addsystemUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addsystemUser.Name = "addsystemUser";
            this.addsystemUser.Size = new System.Drawing.Size(255, 40);
            this.addsystemUser.TabIndex = 15;
            this.addsystemUser.Text = "Add";
            this.addsystemUser.UseVisualStyleBackColor = false;
            this.addsystemUser.Click += new System.EventHandler(this.addsystemUser_Click);
            // 
            // system_email
            // 
            this.system_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.system_email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system_email.Location = new System.Drawing.Point(63, 199);
            this.system_email.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.system_email.Name = "system_email";
            this.system_email.Size = new System.Drawing.Size(255, 28);
            this.system_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // admin_systemUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "admin_systemUsers";
            this.Size = new System.Drawing.Size(1219, 788);
            this.Load += new System.EventHandler(this.admin_systemUsers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewSystemUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteSystemUser;
        private System.Windows.Forms.Button updateSystemUser;
        private System.Windows.Forms.Button addsystemUser;
        private System.Windows.Forms.TextBox system_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox system_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox system_ustatus;
        private System.Windows.Forms.TextBox system_pass;
        private System.Windows.Forms.Label label3;
    }
}
