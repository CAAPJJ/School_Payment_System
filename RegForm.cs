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

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            passe.UseSystemPasswordChar = false;
            confpass.UseSystemPasswordChar = false;
            //show.Visible = false;
            //hide.Visible = true;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            passe.UseSystemPasswordChar = true;
            confpass.UseSystemPasswordChar = true;
            //show.Visible = true;
            //hide.Visible = false;
        }

        private void Submite_Click(object sender, EventArgs e)
        {
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
                        SqlCommand cmd = new SqlCommand("insert into Parent values(@Fname,@Lname,@gender,@age,@usrname,@pass,@email,@phonenumber)", conn);
                        cmd.Parameters.AddWithValue("@Fname", fname.Text.ToString());
                        cmd.Parameters.AddWithValue("@Lname", lname.Text.ToString());
                        cmd.Parameters.AddWithValue("@gender", Gender);
                        cmd.Parameters.AddWithValue("@age", ages.Text.ToString());
                        cmd.Parameters.AddWithValue("@usrname", usrname.Text.ToString());
                        cmd.Parameters.AddWithValue("@pass", passe.Text.ToString());
                        cmd.Parameters.AddWithValue("@email", email.Text.ToString());
                        cmd.Parameters.AddWithValue("@phonenumber", phonenum.Text.ToString());
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("you are Successuflly Register");

                    }
                    else
                    {
                        MessageBox.Show("Password didn't match");
                    }
                }
                /*
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);*/
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
