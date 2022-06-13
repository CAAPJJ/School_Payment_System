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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPaymnet = new System.Windows.Forms.Panel();
            this.schlistgrview = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlPaymnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schlistgrview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPaymnet
            // 
            this.pnlPaymnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlPaymnet.Controls.Add(this.schlistgrview);
            this.pnlPaymnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymnet.Location = new System.Drawing.Point(0, 0);
            this.pnlPaymnet.Name = "pnlPaymnet";
            this.pnlPaymnet.Size = new System.Drawing.Size(888, 800);
            this.pnlPaymnet.TabIndex = 77;
            // 
            // schlistgrview
            // 
            this.schlistgrview.AllowUserToAddRows = false;
            this.schlistgrview.AllowUserToDeleteRows = false;
            this.schlistgrview.AllowUserToResizeColumns = false;
            this.schlistgrview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            this.schlistgrview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.schlistgrview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schlistgrview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.schlistgrview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.schlistgrview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.schlistgrview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schlistgrview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.schlistgrview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schlistgrview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.schlistgrview.DefaultCellStyle = dataGridViewCellStyle4;
            this.schlistgrview.Location = new System.Drawing.Point(0, 81);
            this.schlistgrview.Name = "schlistgrview";
            this.schlistgrview.ReadOnly = true;
            this.schlistgrview.RowHeadersVisible = false;
            this.schlistgrview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.schlistgrview.RowTemplate.Height = 50;
            this.schlistgrview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.schlistgrview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.schlistgrview.Size = new System.Drawing.Size(888, 721);
            this.schlistgrview.TabIndex = 76;
            this.schlistgrview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Schlistgrview_CellContentClick);
            this.schlistgrview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Schlistgrview_CellDoubleClick);
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Null";
            this.delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 80;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(888, 800);
            this.Controls.Add(this.pnlPaymnet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.pnlPaymnet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schlistgrview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPaymnet;
        private System.Windows.Forms.DataGridView schlistgrview;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}