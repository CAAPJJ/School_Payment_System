namespace Online_Payment
{
    partial class Parent_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent_Form));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbltop = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.titlebar = new System.Windows.Forms.Panel();
            this.winmax = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.winclose = new System.Windows.Forms.PictureBox();
            this.Schooll = new System.Windows.Forms.Button();
            this.Profilee = new System.Windows.Forms.Button();
            this.dashboardd = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.pays = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.userpicpnl = new System.Windows.Forms.Panel();
            this.userpic = new System.Windows.Forms.PictureBox();
            this.urname = new System.Windows.Forms.Label();
            this.pnlnav = new System.Windows.Forms.Panel();
            this.navpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winclose)).BeginInit();
            this.userpicpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.navpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navpanel
            // 
            resources.ApplyResources(this.navpanel, "navpanel");
            this.navpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navpanel.Controls.Add(this.pnlnav);
            this.navpanel.Controls.Add(this.userpicpnl);
            this.navpanel.Controls.Add(this.logout);
            this.navpanel.Controls.Add(this.pays);
            this.navpanel.Controls.Add(this.settings);
            this.navpanel.Controls.Add(this.dashboardd);
            this.navpanel.Controls.Add(this.Profilee);
            this.navpanel.Controls.Add(this.Schooll);
            this.navpanel.Name = "navpanel";
            // 
            // pnlnav
            // 
            this.pnlnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            resources.ApplyResources(this.pnlnav, "pnlnav");
            this.pnlnav.Name = "pnlnav";
            // 
            // userpicpnl
            // 
            this.userpicpnl.Controls.Add(this.edit);
            this.userpicpnl.Controls.Add(this.urname);
            this.userpicpnl.Controls.Add(this.userpic);
            resources.ApplyResources(this.userpicpnl, "userpicpnl");
            this.userpicpnl.Name = "userpicpnl";
            // 
            // edit
            // 
            resources.ApplyResources(this.edit, "edit");
            this.edit.Name = "edit";
            this.edit.TabStop = false;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // urname
            // 
            resources.ApplyResources(this.urname, "urname");
            this.urname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.urname.Name = "urname";
            this.urname.Click += new System.EventHandler(this.Urname_Click);
            // 
            // userpic
            // 
            resources.ApplyResources(this.userpic, "userpic");
            this.userpic.Name = "userpic";
            this.userpic.TabStop = false;
            // 
            // logout
            // 
            resources.ApplyResources(this.logout, "logout");
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.logout.Name = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pays
            // 
            resources.ApplyResources(this.pays, "pays");
            this.pays.FlatAppearance.BorderSize = 0;
            this.pays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pays.Name = "pays";
            this.pays.UseVisualStyleBackColor = true;
            this.pays.Click += new System.EventHandler(this.Pay_Click);
            // 
            // settings
            // 
            resources.ApplyResources(this.settings, "settings");
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.settings.Name = "settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.Setting_Click);
            // 
            // dashboardd
            // 
            resources.ApplyResources(this.dashboardd, "dashboardd");
            this.dashboardd.FlatAppearance.BorderSize = 0;
            this.dashboardd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dashboardd.Name = "dashboardd";
            this.dashboardd.UseVisualStyleBackColor = true;
            this.dashboardd.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Profilee
            // 
            resources.ApplyResources(this.Profilee, "Profilee");
            this.Profilee.FlatAppearance.BorderSize = 0;
            this.Profilee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Profilee.Name = "Profilee";
            this.Profilee.UseVisualStyleBackColor = true;
            this.Profilee.Click += new System.EventHandler(this.Profile_Click);
            // 
            // Schooll
            // 
            resources.ApplyResources(this.Schooll, "Schooll");
            this.Schooll.FlatAppearance.BorderSize = 0;
            this.Schooll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Schooll.Name = "Schooll";
            this.Schooll.UseVisualStyleBackColor = true;
            this.Schooll.Click += new System.EventHandler(this.School_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // lbltop
            // 
            resources.ApplyResources(this.lbltop, "lbltop");
            this.lbltop.BackColor = System.Drawing.Color.Transparent;
            this.lbltop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbltop.Name = "lbltop";
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            resources.ApplyResources(this.mainpanel, "mainpanel");
            this.mainpanel.Name = "mainpanel";
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.titlebar.Controls.Add(this.winmax);
            this.titlebar.Controls.Add(this.minimize);
            this.titlebar.Controls.Add(this.winclose);
            this.titlebar.Controls.Add(this.lbltop);
            resources.ApplyResources(this.titlebar, "titlebar");
            this.titlebar.Name = "titlebar";
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // winmax
            // 
            resources.ApplyResources(this.winmax, "winmax");
            this.winmax.Name = "winmax";
            this.winmax.TabStop = false;
            // 
            // minimize
            // 
            resources.ApplyResources(this.minimize, "minimize");
            this.minimize.Name = "minimize";
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.PictureBox1_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.Minimize_MouseHover);
            // 
            // winclose
            // 
            resources.ApplyResources(this.winclose, "winclose");
            this.winclose.Name = "winclose";
            this.winclose.TabStop = false;
            this.winclose.Click += new System.EventHandler(this.Winclose_Click);
            this.winclose.MouseLeave += new System.EventHandler(this.Winclose_MouseLeave);
            this.winclose.MouseHover += new System.EventHandler(this.Winclose_MouseHover);
            // 
            // Schooll
            // 
            resources.ApplyResources(this.Schooll, "Schooll");
            this.Schooll.FlatAppearance.BorderSize = 0;
            this.Schooll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Schooll.Name = "Schooll";
            this.Schooll.UseVisualStyleBackColor = true;
            this.Schooll.Click += new System.EventHandler(this.School_Click);
            // 
            // Profilee
            // 
            resources.ApplyResources(this.Profilee, "Profilee");
            this.Profilee.FlatAppearance.BorderSize = 0;
            this.Profilee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Profilee.Name = "Profilee";
            this.Profilee.UseVisualStyleBackColor = true;
            this.Profilee.Click += new System.EventHandler(this.Profile_Click);
            // 
            // dashboardd
            // 
            resources.ApplyResources(this.dashboardd, "dashboardd");
            this.dashboardd.FlatAppearance.BorderSize = 0;
            this.dashboardd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dashboardd.Name = "dashboardd";
            this.dashboardd.UseVisualStyleBackColor = true;
            this.dashboardd.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // settings
            // 
            resources.ApplyResources(this.settings, "settings");
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.settings.Name = "settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.Setting_Click);
            // 
            // pays
            // 
            resources.ApplyResources(this.pays, "pays");
            this.pays.FlatAppearance.BorderSize = 0;
            this.pays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pays.Name = "pays";
            this.pays.UseVisualStyleBackColor = true;
            this.pays.Click += new System.EventHandler(this.Pay_Click);
            // 
            // logout
            // 
            resources.ApplyResources(this.logout, "logout");
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.logout.Name = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // userpicpnl
            // 
            this.userpicpnl.Controls.Add(this.urname);
            this.userpicpnl.Controls.Add(this.userpic);
            resources.ApplyResources(this.userpicpnl, "userpicpnl");
            this.userpicpnl.Name = "userpicpnl";
            // 
            // userpic
            // 
            resources.ApplyResources(this.userpic, "userpic");
            this.userpic.Name = "userpic";
            this.userpic.TabStop = false;
            // 
            // urname
            // 
            resources.ApplyResources(this.urname, "urname");
            this.urname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.urname.Name = "urname";
            this.urname.Click += new System.EventHandler(this.Urname_Click);
            // 
            // pnlnav
            // 
            this.pnlnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            resources.ApplyResources(this.pnlnav, "pnlnav");
            this.pnlnav.Name = "pnlnav";
            // 
            // navpanel
            // 
            resources.ApplyResources(this.navpanel, "navpanel");
            this.navpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navpanel.Controls.Add(this.pnlnav);
            this.navpanel.Controls.Add(this.userpicpnl);
            this.navpanel.Controls.Add(this.logout);
            this.navpanel.Controls.Add(this.pays);
            this.navpanel.Controls.Add(this.settings);
            this.navpanel.Controls.Add(this.dashboardd);
            this.navpanel.Controls.Add(this.Profilee);
            this.navpanel.Controls.Add(this.Schooll);
            this.navpanel.Name = "navpanel";
            // 
            // Parent_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.navpanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parent_Form";
            this.Opacity = 0.95D;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parent_Form_FormClosing);
            this.Load += new System.EventHandler(this.Parent_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winclose)).EndInit();
            this.userpicpnl.ResumeLayout(false);
            this.userpicpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.navpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.PictureBox winclose;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox winmax;
        private System.Windows.Forms.Panel navpanel;
        private System.Windows.Forms.Panel pnlnav;
        private System.Windows.Forms.Panel userpicpnl;
        private System.Windows.Forms.Label urname;
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button pays;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button dashboardd;
        private System.Windows.Forms.Button Profilee;
        private System.Windows.Forms.Button Schooll;
    }
}