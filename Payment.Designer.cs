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
            this.SuspendLayout();
            // 
            // racc
            // 
            this.racc.Location = new System.Drawing.Point(204, 152);
            this.racc.Name = "racc";
            this.racc.Size = new System.Drawing.Size(164, 22);
            this.racc.TabIndex = 0;
            // 
            // amounts
            // 
            this.amounts.Location = new System.Drawing.Point(204, 250);
            this.amounts.Name = "amounts";
            this.amounts.Size = new System.Drawing.Size(164, 22);
            this.amounts.TabIndex = 2;
            this.amounts.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // sacc
            // 
            this.sacc.Location = new System.Drawing.Point(204, 103);
            this.sacc.Name = "sacc";
            this.sacc.Size = new System.Drawing.Size(164, 22);
            this.sacc.TabIndex = 3;
            // 
            // acc
            // 
            this.acc.AutoSize = true;
            this.acc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acc.Location = new System.Drawing.Point(12, 103);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(163, 17);
            this.acc.TabIndex = 4;
            this.acc.Text = "Sender Account Number";
            // 
            // lblracc
            // 
            this.lblracc.AutoSize = true;
            this.lblracc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblracc.Location = new System.Drawing.Point(10, 153);
            this.lblracc.Name = "lblracc";
            this.lblracc.Size = new System.Drawing.Size(165, 17);
            this.lblracc.TabIndex = 5;
            this.lblracc.Text = "Reciver Account Number";
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.value.Location = new System.Drawing.Point(54, 253);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(121, 17);
            this.value.TabIndex = 7;
            this.value.Text = "Amount Of Money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(101, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student ID";
            // 
            // stuid
            // 
            this.stuid.Location = new System.Drawing.Point(204, 201);
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
            this.pay.Location = new System.Drawing.Point(204, 291);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(112, 36);
            this.pay.TabIndex = 10;
            this.pay.Text = "Pay Now";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(888, 700);
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
    }
}