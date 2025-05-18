namespace Hotel_System
{
    partial class PasswordRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRecovery));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.backtologin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sendCode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reg_email);
            this.panel1.Controls.Add(this.backtologin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.sendCode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.reg_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.panel1.Location = new System.Drawing.Point(443, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 553);
            this.panel1.TabIndex = 3;
            // 
            // reg_email
            // 
            this.reg_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_email.Location = new System.Drawing.Point(66, 297);
            this.reg_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(412, 28);
            this.reg_email.TabIndex = 15;
            // 
            // backtologin
            // 
            this.backtologin.FlatAppearance.BorderSize = 0;
            this.backtologin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtologin.Location = new System.Drawing.Point(69, 502);
            this.backtologin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backtologin.Name = "backtologin";
            this.backtologin.Size = new System.Drawing.Size(412, 39);
            this.backtologin.TabIndex = 14;
            this.backtologin.Text = "Sign Up";
            this.backtologin.UseVisualStyleBackColor = true;
            this.backtologin.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Remembered your password?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sendCode
            // 
            this.sendCode.BackColor = System.Drawing.Color.Black;
            this.sendCode.FlatAppearance.BorderSize = 0;
            this.sendCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.sendCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.sendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendCode.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendCode.ForeColor = System.Drawing.Color.White;
            this.sendCode.Location = new System.Drawing.Point(66, 371);
            this.sendCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendCode.Name = "sendCode";
            this.sendCode.Size = new System.Drawing.Size(412, 52);
            this.sendCode.TabIndex = 6;
            this.sendCode.Text = "Confirm";
            this.sendCode.UseVisualStyleBackColor = false;
            this.sendCode.Click += new System.EventHandler(this.sendCode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // reg_username
            // 
            this.reg_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_username.Location = new System.Drawing.Point(66, 222);
            this.reg_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(412, 28);
            this.reg_username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 98);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Masión";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Enter your username and email to reset the password.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reset Password";
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordRecovery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backtologin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sendCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}