namespace Online_Payment
{
    partial class password_recovery_form
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
            this.getcode = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.Secretcode = new System.Windows.Forms.TextBox();
            this.emailadd = new System.Windows.Forms.TextBox();
            this.chngpass = new System.Windows.Forms.Button();
            this.confpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newpasslbl = new System.Windows.Forms.Label();
            this.newpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resend = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getcode
            // 
            this.getcode.AutoSize = true;
            this.getcode.Location = new System.Drawing.Point(236, 117);
            this.getcode.Name = "getcode";
            this.getcode.Size = new System.Drawing.Size(78, 27);
            this.getcode.TabIndex = 0;
            this.getcode.Text = "Get Code";
            this.getcode.UseVisualStyleBackColor = true;
            this.getcode.Click += new System.EventHandler(this.Getcode_Click);
            // 
            // send
            // 
            this.send.AutoSize = true;
            this.send.Location = new System.Drawing.Point(97, 162);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(78, 27);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Secretcode
            // 
            this.Secretcode.Location = new System.Drawing.Point(61, 122);
            this.Secretcode.Name = "Secretcode";
            this.Secretcode.Size = new System.Drawing.Size(156, 22);
            this.Secretcode.TabIndex = 2;
            this.Secretcode.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // emailadd
            // 
            this.emailadd.Location = new System.Drawing.Point(61, 54);
            this.emailadd.Name = "emailadd";
            this.emailadd.Size = new System.Drawing.Size(156, 22);
            this.emailadd.TabIndex = 3;
            // 
            // chngpass
            // 
            this.chngpass.AutoSize = true;
            this.chngpass.Enabled = false;
            this.chngpass.Location = new System.Drawing.Point(577, 213);
            this.chngpass.Name = "chngpass";
            this.chngpass.Size = new System.Drawing.Size(132, 27);
            this.chngpass.TabIndex = 4;
            this.chngpass.Text = "Change Password";
            this.chngpass.UseVisualStyleBackColor = true;
            this.chngpass.Click += new System.EventHandler(this.Chngpass_Click);
            // 
            // confpass
            // 
            this.confpass.Enabled = false;
            this.confpass.Location = new System.Drawing.Point(577, 167);
            this.confpass.Name = "confpass";
            this.confpass.Size = new System.Drawing.Size(156, 22);
            this.confpass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confrim Your password";
            // 
            // newpasslbl
            // 
            this.newpasslbl.AutoSize = true;
            this.newpasslbl.Location = new System.Drawing.Point(417, 129);
            this.newpasslbl.Name = "newpasslbl";
            this.newpasslbl.Size = new System.Drawing.Size(135, 17);
            this.newpasslbl.TabIndex = 8;
            this.newpasslbl.Text = "Enter new password";
            // 
            // newpass
            // 
            this.newpass.Enabled = false;
            this.newpass.Location = new System.Drawing.Point(577, 124);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(156, 22);
            this.newpass.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Your Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Secret Code";
            // 
            // resend
            // 
            this.resend.AutoSize = true;
            this.resend.Location = new System.Drawing.Point(236, 117);
            this.resend.Name = "resend";
            this.resend.Size = new System.Drawing.Size(78, 27);
            this.resend.TabIndex = 11;
            this.resend.Text = "ReSend";
            this.resend.UseVisualStyleBackColor = true;
            this.resend.Visible = false;
            this.resend.Click += new System.EventHandler(this.Resend_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(4, 407);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(103, 31);
            this.logout.TabIndex = 12;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // password_recovery_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.resend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newpasslbl);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confpass);
            this.Controls.Add(this.chngpass);
            this.Controls.Add(this.emailadd);
            this.Controls.Add(this.Secretcode);
            this.Controls.Add(this.send);
            this.Controls.Add(this.getcode);
            this.Name = "password_recovery_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forger Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Password_recovery_form_FormClosing);
            this.Load += new System.EventHandler(this.Password_recovery_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button getcode;
        internal System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox Secretcode;
        private System.Windows.Forms.TextBox emailadd;
        internal System.Windows.Forms.Button chngpass;
        private System.Windows.Forms.TextBox confpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newpasslbl;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button resend;
        private System.Windows.Forms.Button logout;
    }
}