using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Online_Payment
{
    public partial class loginform : Form
    {
        public static int i = 0;
        public String Conn = ("Data Source = LAPTOP-C473Q6SO; Initial Catalog = Online_Payment; Integrated Security = true");
        string choose = "Student";
        public loginform()
        {
            InitializeComponent();
        }
        public int getpid()
        {
            int id;
            string query = "execute Get_Parent_Id @username,@userpassword";
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Get_User_Name);
            cmd.Parameters.AddWithValue("@userpassword",User_Password);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return id;
        }

        public int getsid()
        {
            int id;
           string query = "execute Get_School_Id @username,@userpassword";
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Get_User_Name);
            cmd.Parameters.AddWithValue("@userpassword", User_Password);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return id;
        }

        public int getPacc()
        {
            int id = getpid(),account;
            string query = "select Account_num from Parent_Account where Parent_Id = " + id;
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            account = Convert.ToInt32(cmd.ExecuteScalar());
            return account;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Passwor_TextChanged(object sender, EventArgs e)
        {

        }

        public String Get_User_Name
        {
            get { return usersname.Text.ToString(); }
            
        }
        public String User_Password
        {
            get { return password.Text; }
        }
        public string choice()
        {
            choose = logas.Text.ToString();
            switch (choose)
            {
                case "School Adminstrator":
                    choose = "School";
                    break;
                case "Parent":
                    choose = "Parent";
                    break;
                case "Student":
                    choose = "Student";
                    break;
            }
            return choose;

        }
        private void logus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //logus.SelectedItem = "Student";
            //choose =logas.Text.ToString();
            //choose = "Student";
            
        }
        private void log_Click(object sender, EventArgs e)
        {
            try
            {
                if(usersname.Text == "" && password.Text =="")
                {
                    MessageBox.Show("Enter User Name and Password");
                }
                else
                {
                    choose = choice();
                    string query = "select *from "+choose+ " where User_Name=@usrname and password=@pass";
                    
                    SqlConnection conn = new SqlConnection(Conn);
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@usrname", usersname.Text);
                    cmd.Parameters.AddWithValue("@pass", password.Text);
                    conn.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    conn.Close();
                    int count = ds.Tables[0].Rows.Count;
                    
                    if (count==1)
                    {
                        switch (choose)
                        {
                            case "School":
                                 School_Adminstration schooladmin = new School_Adminstration(this);
                                 schooladmin.Show();
                                 this.Hide();
                                break;
                            case "Parent":
                                Parent_Form PF = new Parent_Form(this);
                                PF.Show();
                                this.Hide();
                                break;
                            case "Student":
                                MessageBox.Show("Comming soon");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or password",choose);
                            i++;
                        if (i >= 3)
                        {
                            forgpass.Visible = true;
                            //MessageBox.Show("Invalid User Name or password");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reg_Click(object sender, EventArgs e)
        {
            //loginform log = new loginform();
            RegForm regForm = new RegForm();
            MainMenu mains = new MainMenu();
            //mains.Show();
            regForm.Show();
            this.Hide();
        }

        private void Loginform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Forgpass_Click(object sender, EventArgs e)
        {
            password_recovery_form pasrec = new password_recovery_form();
            pasrec.Show();
            this.Hide();
        }

        private void Showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                password.UseSystemPasswordChar = false;

            }
            else
            {
                password.UseSystemPasswordChar = true;

            }
        }


        private void username(object sender, MouseEventArgs e)
        {
            if (usersname.Text == "Enter UserName")
            {
                usersname.Text = "";
                usersname.ForeColor = Color.Black;
                
            }
        }

        private void username(object sender, EventArgs e)
        {
            if (usersname.Text == "")
            {
                usersname.Text = "Enter UserName";
                usersname.ForeColor = Color.Red;

            }
        }

        private void logus(object sender, EventArgs e)
        {
            
        }

        private void Winclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
