using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;

namespace Online_Payment
{
    public partial class Parent_Form : Form
    {
        public String Conn = ("Data Source = LAPTOP-C473Q6SO; Initial Catalog = Online_Payment; Integrated Security = true");
        private Button currbtn;
        loginform loginform = new loginform();
        Global global = new Global();
        public Parent_Form(loginform logfor)
        {
            InitializeComponent();
            this.loginform = logfor;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            labels();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form pf = Form as Form;
            pf.TopLevel = false;
            pf.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(pf);
            this.mainpanel.Tag = pf;
            pf.Show();
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Parent_Form_Load(object sender, EventArgs e)
        {
            pnlnav.Location = new Point(0, dashboardd.Location.Y);
            ShowThisForm(new DashBoardForm(loginform));
            labels();
            lbltop.Text = "Dash Board";
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(loginform.getpid().ToString());
            Activate_Button(sender);
            labels();
            lbltop.Text = "Dash Board";
            ShowThisForm(new DashBoardForm(loginform));
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(loginform);
            profile.Fill_Profile();
            Activate_Button(sender);
            ShowThisForm(new ProfileForm(loginform));
            lbltop.Text = "Profile";
            labels();
        }
        private void School_Click(object sender, EventArgs e)
        {
            Parent_Form pform = new Parent_Form(loginform);
            Activate_Button(sender);
            ShowThisForm(new P_School_Form(loginform));
            labels();
            lbltop.Text = "School";

        }
        private void Pay_Click(object sender, EventArgs e)
        {
            Activate_Button(sender);
            //ShowThisForm(new Payment());
            labels();
            lbltop.Text = "Payment";
            Payment payment = new Payment(loginform,global);
            payment.TopLevel = false;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(payment);
            payment.Show();

        }
        private void Setting_Click(object sender, EventArgs e)
        {
            Activate_Button(sender);
            ShowThisForm(new SettingForm());
            labels();
            lbltop.Text = "Setting";
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            pnlnav.Location = new Point(0, 541);
            loginform loginform = new loginform();
            loginform.Show();
            this.Hide();
        }
        private void Urname_Click(object sender, EventArgs e)
        {

        }
        public void Disable_button()
        {
            if(currbtn != null)
            {
                currbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currbtn.BackColor = Color.FromArgb(24, 30, 54);
                currbtn.ForeColor = Color.FromArgb(0, 126, 249);
            }

        }

        public void Activate_Button(object senderbtn)
        {
            Disable_button();
            currbtn = (Button)senderbtn;
            currbtn.BackColor = Color.FromArgb(37, 36, 81);
            currbtn.ForeColor = Color.Orange;
            currbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            pnlnav.Location = new Point(0, currbtn.Location.Y);
        }
        public void ShowThisForm(object form)
        {
            mainpanel.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            mainpanel.Controls.Add(frm);
            mainpanel.Tag = frm;
            frm.Show();
        }

        private void Winclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMSg, int wParm, int lParam);
        private void Titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
       //          if(WindowState == FormWindowState.Normal)
       //{
       //    WindowState = FormWindowState.Maximized;

       //}
       //else
       //{
       //    WindowState = FormWindowState.Normal;
       //}

        }

        public void labels()
        {
            lbltop.ForeColor = Color.Orange;
            urname.Text = loginform.Get_User_Name;
        }
        private void Parent_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            
        }

        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            minimize.BackColor = Color.LightGray;
        }

        private void Winclose_MouseHover(object sender, EventArgs e)
        {
            winclose.BackColor = Color.LightGray;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Winclose_MouseLeave(object sender, EventArgs e)
        {
            winclose.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
