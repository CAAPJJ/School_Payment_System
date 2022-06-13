namespace Online_Payment
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.label1 = new System.Windows.Forms.Label();
            this.editprofile = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.usrname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.chgpass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.ages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Profile";
            // 
            // editprofile
            // 
            this.editprofile.BackColor = System.Drawing.Color.Cyan;
            this.editprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editprofile.Font = new System.Drawing.Font("Cambria", 10F);
            this.editprofile.Image = ((System.Drawing.Image)(resources.GetObject("editprofile.Image")));
            this.editprofile.Location = new System.Drawing.Point(161, 703);
            this.editprofile.Name = "editprofile";
            this.editprofile.Size = new System.Drawing.Size(136, 50);
            this.editprofile.TabIndex = 54;
            this.editprofile.Text = "Edit";
            this.editprofile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editprofile.UseVisualStyleBackColor = false;
            this.editprofile.Click += new System.EventHandler(this.editprofile_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Enabled = false;
            this.email.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(162, 514);
            this.email.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(476, 20);
            this.email.TabIndex = 51;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lname.Enabled = false;
            this.lname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lname.ForeColor = System.Drawing.Color.White;
            this.lname.Location = new System.Drawing.Point(161, 283);
            this.lname.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(475, 20);
            this.lname.TabIndex = 48;
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.save.Enabled = false;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Cambria", 10F);
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(489, 703);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(136, 50);
            this.save.TabIndex = 43;
            this.save.Text = "Save";
            this.save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // phonenum
            // 
            this.phonenum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.phonenum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phonenum.Enabled = false;
            this.phonenum.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.phonenum.ForeColor = System.Drawing.Color.White;
            this.phonenum.Location = new System.Drawing.Point(162, 581);
            this.phonenum.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(476, 20);
            this.phonenum.TabIndex = 41;
            this.phonenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usrname
            // 
            this.usrname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrname.Enabled = false;
            this.usrname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.usrname.ForeColor = System.Drawing.Color.White;
            this.usrname.Location = new System.Drawing.Point(163, 447);
            this.usrname.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(474, 20);
            this.usrname.TabIndex = 37;
            this.usrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fname.Enabled = false;
            this.fname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.fname.ForeColor = System.Drawing.Color.White;
            this.fname.Location = new System.Drawing.Point(161, 216);
            this.fname.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(475, 20);
            this.fname.TabIndex = 35;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chgpass
            // 
            this.chgpass.AutoSize = true;
            this.chgpass.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgpass.ForeColor = System.Drawing.Color.Lime;
            this.chgpass.Location = new System.Drawing.Point(208, 652);
            this.chgpass.Name = "chgpass";
            this.chgpass.Size = new System.Drawing.Size(163, 22);
            this.chgpass.TabIndex = 55;
            this.chgpass.Text = "Change Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(161, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 5);
            this.panel1.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(161, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 5);
            this.panel2.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(163, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 5);
            this.panel3.TabIndex = 59;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(163, 488);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 5);
            this.panel4.TabIndex = 59;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(162, 555);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(475, 5);
            this.panel5.TabIndex = 59;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(162, 622);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 5);
            this.panel6.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(57, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(61, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(113, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(30, 607);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(100, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(57, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "User Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(117, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Sex";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Enabled = false;
            this.female.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.female.Location = new System.Drawing.Point(286, 348);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(85, 24);
            this.female.TabIndex = 70;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Enabled = false;
            this.male.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.male.Location = new System.Drawing.Point(177, 348);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(67, 24);
            this.male.TabIndex = 69;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // ages
            // 
            this.ages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ages.Enabled = false;
            this.ages.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ages.ForeColor = System.Drawing.Color.White;
            this.ages.Location = new System.Drawing.Point(162, 395);
            this.ages.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.ages.Name = "ages";
            this.ages.Size = new System.Drawing.Size(475, 20);
            this.ages.TabIndex = 68;
            this.ages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(888, 800);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.ages);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chgpass);
            this.Controls.Add(this.editprofile);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.save);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editprofile;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox phonenum;
        private System.Windows.Forms.TextBox usrname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label chgpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.TextBox ages;
    }
}