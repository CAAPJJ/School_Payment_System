using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Payment
{
    public partial class password_recovery_form : Form
    {
        int code,i;
        public String Conn = ("Data Source = DESKTOP-D6336JC; Initial Catalog = Online_Payment; Integrated Security = true");
        public static int count = 0;
        bool exist;

        public password_recovery_form()
        {
            InitializeComponent();
        }
        public int Generate_Secret_Code()
        {
            Random rnd = new Random();
            return code = rnd.Next(111111, 999999);
        } 
        private void Chngpass_Click(object sender, EventArgs e)
        {
            
           if(newpass.Text.ToString() == confpass.Text.ToString())
            {
                loginform loginform = new loginform();
                string choose = loginform.choice();
                SqlConnection conn = new SqlConnection(Conn);
                conn.Open();
                try
                {
                    string querys = "update "+choose+" set Password=@newpass where email=@email";
                    SqlCommand cmd = new SqlCommand(querys, conn);
                    cmd.Parameters.AddWithValue("@newpass", newpass.Text.ToString());
                    cmd.Parameters.AddWithValue("@email", emailadd.Text.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Password Succssfully Changed");
                   // loginform loginform = new loginform();
                    loginform.Show();
                    this.Hide();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            else
            {
                count++;
                MessageBox.Show("Passowrd didn't match");
                if(count == 5)
                {
                    MessageBox.Show("You tried more than 5 so try again");
                    newpass.Enabled = false;
                    confpass.Enabled = false;
                    chngpass.Enabled = false;
                    i = Generate_Secret_Code();
                }
            }
        }
        public bool ifexist()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                string querys = "select count(*) from Student where Email=@email";
                //SqlCommand cmd = new SqlCommand("insert into Student values(@School_id,@Fname,@Lname,@gender,@age,@usrname,@pass,@email,@current_class,@Address,@phonenumber)", conn);

                SqlCommand cmd = new SqlCommand(querys, conn);
                cmd.Parameters.AddWithValue("@email", emailadd.Text.ToString());
                int a = (Int32)cmd.ExecuteScalar();
                conn.Close();
                if (a >= 1)
                {
                    exist = true;
                }
                else
                {
                    exist = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            return exist;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (Secretcode.Text.ToString() == null)
            {
                MessageBox.Show("Enter Secrect code!!");
            }
            else
            {
                int enterdcode = int.Parse(Secretcode.Text.ToString());

                if (enterdcode == i)
                {
                    newpass.Enabled = true;
                    confpass.Enabled = true;
                    chngpass.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Secrect code!!");
                }
            }
        }

        private void Getcode_Click(object sender, EventArgs e)
        {
            if (emailadd.Text.ToString() == null)
            {
                MessageBox.Show("Enter your Email");
            }
            else
            {
                if (ifexist())
                {
                    i = Generate_Secret_Code();
                    string code = Convert.ToString(i);
                    MessageBox.Show(code,"Your Code");
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                    DialogResult result = MessageBox.Show("This email is not registered ", "Information", buttons,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign, true);
                }
            }
            getcode.Visible = false;
            resend.Visible = true;
        }

        private void Password_recovery_form_Load(object sender, EventArgs e)
        {

        }

        private void Resend_Click(object sender, EventArgs e)
        {
            if (ifexist())
            {
                i = Generate_Secret_Code();
                string picks = Convert.ToString(i);
                MessageBox.Show(picks);
            }
            else
            {
                MessageBox.Show("This email is not registered "+exist);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.Show();
            this.Hide();
        }
        private void Password_Recovery_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
