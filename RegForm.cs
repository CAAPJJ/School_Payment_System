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

namespace Online_Payment
{
    public partial class RegForm : Form

    {
        String Conn = ("Data Source = LAPTOP-C473Q6SO; Initial Catalog = Online_Payment; Integrated Security = true");
        String Gender;
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            passe.UseSystemPasswordChar = false;
            confpass.UseSystemPasswordChar = false;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            passe.UseSystemPasswordChar = true;
            confpass.UseSystemPasswordChar = true;
        }

        private void Submite_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int Account = random.Next(1000, 9999);
            try
            {
                //string name = fnapame.Text.ToString();
             if(passe.Text.ToString()=="" || fname.Text.ToString()=="" || lname.Text.ToString() == ""
                    || age.Text.ToString()=="" || Gender=="" || usrname.Text.ToString()=="" ||
                    phonenum.Text.ToString()==""|| email.Text.ToString()=="")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Information Missing Try Again","Information",buttons,MessageBoxIcon.Warning);
                }
                else
                {
                    if (passe.Text.ToString() == confpass.Text.ToString())
                    {
                        SqlConnection conn = new SqlConnection(Conn);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("execute Parent_val @fname,@lname,@gender,@age,@username,@passe, @email, @phone, @Account", conn);
                        cmd.Parameters.AddWithValue("@fname", fname.Text.ToString());
                        cmd.Parameters.AddWithValue("@lname", lname.Text.ToString());
                        cmd.Parameters.AddWithValue("@gender",Gender);
                        cmd.Parameters.AddWithValue("@age", ages.Text.ToString());
                        cmd.Parameters.AddWithValue("@username", usrname.Text.ToString());
                        cmd.Parameters.AddWithValue("@passe", passe.Text.ToString());
                        cmd.Parameters.AddWithValue("@email", email.Text.ToString());
                        cmd.Parameters.AddWithValue("@phone", phonenum.Text.ToString());
                        cmd.Parameters.AddWithValue("@Account", Account);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("you are Successuflly Register");
                        MessageBox.Show("you Account Number is "+Account,"Secrete");
                    }
                    else
                    {
                        MessageBox.Show("Password didn't match");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Cancelreg_Click(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.Show();
            this.Hide();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Cancelreg_Click_1(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.Show();
            this.Close();
        }

        private void Male_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void Female_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Female";
        }
    }
}
