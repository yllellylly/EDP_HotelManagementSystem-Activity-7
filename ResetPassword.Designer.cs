namespace Hotel_System
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetShowPass = new System.Windows.Forms.CheckBox();
            this.backToLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmResetpass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.new_confirmpass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetShowPass);
            this.panel1.Controls.Add(this.backToLogin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.confirmResetpass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.new_pass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.new_confirmpass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.panel1.Location = new System.Drawing.Point(443, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 553);
            this.panel1.TabIndex = 5;
            // 
            // resetShowPass
            // 
            this.resetShowPass.AutoSize = true;
            this.resetShowPass.Location = new System.Drawing.Point(67, 327);
            this.resetShowPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetShowPass.Name = "resetShowPass";
            this.resetShowPass.Size = new System.Drawing.Size(148, 25);
            this.resetShowPass.TabIndex = 16;
            this.resetShowPass.Text = "Show Password";
            this.resetShowPass.UseVisualStyleBackColor = true;
            this.resetShowPass.CheckedChanged += new System.EventHandler(this.loginShowPass_CheckedChanged);
            // 
            // backToLogin
            // 
            this.backToLogin.FlatAppearance.BorderSize = 0;
            this.backToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLogin.Location = new System.Drawing.Point(68, 495);
            this.backToLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(412, 39);
            this.backToLogin.TabIndex = 14;
            this.backToLogin.Text = "Sign Up";
            this.backToLogin.UseVisualStyleBackColor = true;
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Remember your password?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Enter your new password.";
            // 
            // confirmResetpass
            // 
            this.confirmResetpass.BackColor = System.Drawing.Color.Black;
            this.confirmResetpass.FlatAppearance.BorderSize = 0;
            this.confirmResetpass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.confirmResetpass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(97)))), ((int)(((byte)(66)))));
            this.confirmResetpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmResetpass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmResetpass.ForeColor = System.Drawing.Color.White;
            this.confirmResetpass.Location = new System.Drawing.Point(67, 371);
            this.confirmResetpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmResetpass.Name = "confirmResetpass";
            this.confirmResetpass.Size = new System.Drawing.Size(412, 52);
            this.confirmResetpass.TabIndex = 6;
            this.confirmResetpass.Text = "Reset Password";
            this.confirmResetpass.UseVisualStyleBackColor = false;
            this.confirmResetpass.Click += new System.EventHandler(this.sendCode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm Password";
            // 
            // new_pass
            // 
            this.new_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_pass.Location = new System.Drawing.Point(68, 212);
            this.new_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(412, 28);
            this.new_pass.TabIndex = 3;
            this.new_pass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reset Password";
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
            // new_confirmpass
            // 
            this.new_confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_confirmpass.Location = new System.Drawing.Point(68, 291);
            this.new_confirmpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.new_confirmpass.Name = "new_confirmpass";
            this.new_confirmpass.Size = new System.Drawing.Size(412, 28);
            this.new_confirmpass.TabIndex = 5;
            this.new_confirmpass.UseSystemPasswordChar = true;
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
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ResetPassword
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
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backToLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button confirmResetpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox new_confirmpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox resetShowPass;
    }
}