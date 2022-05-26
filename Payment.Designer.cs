namespace Online_Payment
{
    partial class Payment
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
            this.racc = new System.Windows.Forms.TextBox();
            this.amounts = new System.Windows.Forms.TextBox();
            this.sacc = new System.Windows.Forms.TextBox();
            this.acc = new System.Windows.Forms.Label();
            this.lblracc = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stuid = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSchoolName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // racc
            // 
            this.racc.Location = new System.Drawing.Point(497, 335);
            this.racc.Margin = new System.Windows.Forms.Padding(2);
            this.racc.Name = "racc";
            this.racc.Size = new System.Drawing.Size(124, 20);
            this.racc.TabIndex = 0;
            // 
            // amounts
            // 
            this.amounts.Location = new System.Drawing.Point(497, 414);
            this.amounts.Margin = new System.Windows.Forms.Padding(2);
            this.amounts.Name = "amounts";
            this.amounts.Size = new System.Drawing.Size(124, 20);
            this.amounts.TabIndex = 2;
            this.amounts.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // sacc
            // 
            this.sacc.Location = new System.Drawing.Point(497, 295);
            this.sacc.Margin = new System.Windows.Forms.Padding(2);
            this.sacc.Name = "sacc";
            this.sacc.Size = new System.Drawing.Size(124, 20);
            this.sacc.TabIndex = 3;
            // 
            // acc
            // 
            this.acc.AutoSize = true;
            this.acc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acc.Location = new System.Drawing.Point(353, 295);
            this.acc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(124, 13);
            this.acc.TabIndex = 4;
            this.acc.Text = "Sender Account Number";
            // 
            // lblracc
            // 
            this.lblracc.AutoSize = true;
            this.lblracc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblracc.Location = new System.Drawing.Point(352, 335);
            this.lblracc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblracc.Name = "lblracc";
            this.lblracc.Size = new System.Drawing.Size(127, 13);
            this.lblracc.TabIndex = 5;
            this.lblracc.Text = "Reciver Account Number";
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.value.Location = new System.Drawing.Point(384, 417);
            this.value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(92, 13);
            this.value.TabIndex = 7;
            this.value.Text = "Amount Of Money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(420, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student ID";
            // 
            // stuid
            // 
            this.stuid.Location = new System.Drawing.Point(497, 374);
            this.stuid.Margin = new System.Windows.Forms.Padding(2);
            this.stuid.Name = "stuid";
            this.stuid.Size = new System.Drawing.Size(124, 20);
            this.stuid.TabIndex = 8;
            // 
            // pay
            // 
            this.pay.FlatAppearance.BorderSize = 0;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pay.Location = new System.Drawing.Point(497, 447);
            this.pay.Margin = new System.Windows.Forms.Padding(2);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(84, 29);
            this.pay.TabIndex = 10;
            this.pay.Text = "Pay Now";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(117, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 64;
            this.label6.Text = "Suba terara";
            // 
            // lbSchoolName
            // 
            this.lbSchoolName.AutoSize = true;
            this.lbSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSchoolName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSchoolName.Location = new System.Drawing.Point(117, 103);
            this.lbSchoolName.Name = "lbSchoolName";
            this.lbSchoolName.Size = new System.Drawing.Size(91, 24);
            this.lbSchoolName.TabIndex = 63;
            this.lbSchoolName.Text = "Danguaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(422, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "this month fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(64, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "student name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(225, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "school choosen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(434, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "notpayed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(434, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 69;
            this.label7.Text = "payed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(243, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 71;
            this.label8.Text = "notpayed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(12, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 70;
            this.label9.Text = "Suba terara";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(243, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 24);
            this.label10.TabIndex = 72;
            this.label10.Text = "this month fee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(12, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 73;
            this.label11.Text = "grade 5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(245, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 24);
            this.label12.TabIndex = 74;
            this.label12.Text = "fee: 1847";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(243, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 24);
            this.label13.TabIndex = 75;
            this.label13.Text = "paynow";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(666, 569);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSchoolName);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stuid);
            this.Controls.Add(this.value);
            this.Controls.Add(this.lblracc);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.sacc);
            this.Controls.Add(this.amounts);
            this.Controls.Add(this.racc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox racc;
        private System.Windows.Forms.TextBox amounts;
        private System.Windows.Forms.TextBox sacc;
        private System.Windows.Forms.Label acc;
        private System.Windows.Forms.Label lblracc;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stuid;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSchoolName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}