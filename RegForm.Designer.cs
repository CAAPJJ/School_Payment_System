namespace Online_Payment
{
    partial class RegForm
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
            this.finame = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.pusername = new System.Windows.Forms.Label();
            this.usrname = new System.Windows.Forms.TextBox();
            this.passe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submite = new System.Windows.Forms.Button();
            this.sex = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.ages = new System.Windows.Forms.TextBox();
            this.cancelreg = new System.Windows.Forms.Button();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.email = new System.Windows.Forms.TextBox();
            this.confpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.laname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finame
            // 
            this.finame.AutoSize = true;
            this.finame.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.finame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.finame.Location = new System.Drawing.Point(12, 63);
            this.finame.Name = "finame";
            this.finame.Size = new System.Drawing.Size(94, 20);
            this.finame.TabIndex = 0;
            this.finame.Text = "First Name";
            this.finame.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.fname.Location = new System.Drawing.Point(112, 63);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(206, 27);
            this.fname.TabIndex = 1;
            // 
            // pusername
            // 
            this.pusername.AutoSize = true;
            this.pusername.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.pusername.Location = new System.Drawing.Point(8, 263);
            this.pusername.Name = "pusername";
            this.pusername.Size = new System.Drawing.Size(94, 20);
            this.pusername.TabIndex = 4;
            this.pusername.Text = "User Name";
            this.pusername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // usrname
            // 
            this.usrname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.usrname.Location = new System.Drawing.Point(112, 256);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(206, 27);
            this.usrname.TabIndex = 5;
            // 
            // passe
            // 
            this.passe.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.passe.Location = new System.Drawing.Point(112, 400);
            this.passe.Name = "passe";
            this.passe.Size = new System.Drawing.Size(206, 27);
            this.passe.TabIndex = 9;
            this.passe.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(-2, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Passsword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone Numnber";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // phonenum
            // 
            this.phonenum.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.phonenum.Location = new System.Drawing.Point(175, 345);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(211, 27);
            this.phonenum.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // submite
            // 
            this.submite.Font = new System.Drawing.Font("Cambria", 10F);
            this.submite.Location = new System.Drawing.Point(36, 518);
            this.submite.Name = "submite";
            this.submite.Size = new System.Drawing.Size(108, 44);
            this.submite.TabIndex = 14;
            this.submite.Text = "Submite";
            this.submite.UseVisualStyleBackColor = true;
            this.submite.Click += new System.EventHandler(this.Submite_Click);
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.sex.Location = new System.Drawing.Point(12, 158);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(36, 20);
            this.sex.TabIndex = 15;
            this.sex.Text = "Sex";
            this.sex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.age.Location = new System.Drawing.Point(12, 212);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(38, 20);
            this.age.TabIndex = 18;
            this.age.Text = "Age";
            this.age.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ages
            // 
            this.ages.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ages.Location = new System.Drawing.Point(112, 205);
            this.ages.Name = "ages";
            this.ages.Size = new System.Drawing.Size(206, 27);
            this.ages.TabIndex = 22;
            // 
            // cancelreg
            // 
            this.cancelreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelreg.Font = new System.Drawing.Font("Cambria", 10F);
            this.cancelreg.Location = new System.Drawing.Point(166, 522);
            this.cancelreg.Name = "cancelreg";
            this.cancelreg.Size = new System.Drawing.Size(168, 37);
            this.cancelreg.TabIndex = 32;
            this.cancelreg.Text = "Go back TO Login";
            this.cancelreg.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.female.Location = new System.Drawing.Point(202, 154);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(85, 24);
            this.female.TabIndex = 30;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.male.Location = new System.Drawing.Point(112, 154);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(67, 24);
            this.male.TabIndex = 29;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.email.Location = new System.Drawing.Point(112, 298);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(206, 27);
            this.email.TabIndex = 28;
            // 
            // confpass
            // 
            this.confpass.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.confpass.Location = new System.Drawing.Point(175, 458);
            this.confpass.Name = "confpass";
            this.confpass.Size = new System.Drawing.Size(206, 27);
            this.confpass.TabIndex = 27;
            this.confpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-2, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Confrim Password";
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lname.Location = new System.Drawing.Point(112, 110);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(206, 27);
            this.lname.TabIndex = 25;
            // 
            // laname
            // 
            this.laname.AutoSize = true;
            this.laname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.laname.Location = new System.Drawing.Point(12, 113);
            this.laname.Name = "laname";
            this.laname.Size = new System.Drawing.Size(90, 20);
            this.laname.TabIndex = 24;
            this.laname.Text = "Last Name";
            this.laname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(38, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 44);
            this.label5.TabIndex = 33;
            this.label5.Text = "Get Started";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 620);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelreg);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.email);
            this.Controls.Add(this.confpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.laname);
            this.Controls.Add(this.ages);
            this.Controls.Add(this.age);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.submite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.pusername);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.finame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label finame;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label pusername;
        private System.Windows.Forms.TextBox usrname;
        private System.Windows.Forms.TextBox passe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phonenum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submite;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox ages;
        private System.Windows.Forms.Button cancelreg;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox confpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label laname;
        private System.Windows.Forms.Label label5;
    }
}