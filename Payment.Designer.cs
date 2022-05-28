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
            this.racc.Location = new System.Drawing.Point(663, 412);
            this.racc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.racc.Name = "racc";
            this.racc.Size = new System.Drawing.Size(164, 22);
            this.racc.TabIndex = 0;
            // 
            // amounts
            // 
            this.amounts.Location = new System.Drawing.Point(663, 510);
            this.amounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amounts.Name = "amounts";
            this.amounts.Size = new System.Drawing.Size(164, 22);
            this.amounts.TabIndex = 2;
            //this.amounts.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // sacc
            // 
            this.sacc.Location = new System.Drawing.Point(663, 363);
            this.sacc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sacc.Name = "sacc";
            this.sacc.Size = new System.Drawing.Size(164, 22);
            this.sacc.TabIndex = 3;
            // 
            // acc
            // 
            this.acc.AutoSize = true;
            this.acc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acc.Location = new System.Drawing.Point(471, 363);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(163, 17);
            this.acc.TabIndex = 4;
            this.acc.Text = "Sender Account Number";
            // 
            // lblracc
            // 
            this.lblracc.AutoSize = true;
            this.lblracc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblracc.Location = new System.Drawing.Point(469, 412);
            this.lblracc.Name = "lblracc";
            this.lblracc.Size = new System.Drawing.Size(165, 17);
            this.lblracc.TabIndex = 5;
            this.lblracc.Text = "Reciver Account Number";
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.value.Location = new System.Drawing.Point(512, 513);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(121, 17);
            this.value.TabIndex = 7;
            this.value.Text = "Amount Of Money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(560, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student ID";
            // 
            // stuid
            // 
            this.stuid.Location = new System.Drawing.Point(663, 460);
            this.stuid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuid.Name = "stuid";
            this.stuid.Size = new System.Drawing.Size(164, 22);
            this.stuid.TabIndex = 8;
            // 
            // pay
            // 
            this.pay.FlatAppearance.BorderSize = 0;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pay.Location = new System.Drawing.Point(663, 550);
            this.pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(112, 36);
            this.pay.TabIndex = 10;
            this.pay.Text = "Pay Now";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(347, 254);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.TabIndex = 71;
            this.label8.Text = "notpayed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(39, 251);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 29);
            this.label9.TabIndex = 70;
            this.label9.Text = "Suba terara";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(297, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 29);
            this.label10.TabIndex = 72;
            this.label10.Text = "this month fee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(39, 301);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 29);
            this.label11.TabIndex = 73;
            this.label11.Text = "grade 5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(350, 301);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 29);
            this.label12.TabIndex = 74;
            this.label12.Text = "fee: 1847";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(347, 365);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 29);
            this.label13.TabIndex = 75;
            this.label13.Text = "paynow";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(888, 700);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}