using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Payment
{
    public partial class ProfileForm : Form
    {
        public String Conn = ("Data Source = LAPTOP-C473Q6SO; Initial Catalog = Online_Payment; Integrated Security = true");
        loginform loginform = new loginform();
        public ProfileForm(loginform logfor)
        {
            InitializeComponent();
            this.loginform = logfor;
           // Fill_Profile();
        }

        public void Fill_Profile()
        {
            string pass = loginform.User_Password.ToString();
            string username = loginform.Get_User_Name.ToString();
            string query = "execute School_Student_List '" + username + "'," + "'" + pass + "'";
            try
            {
                SqlConnection conn = new SqlConnection(Conn);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                //sda.Fill(dt);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fname.Text = dr.GetValue(1).ToString();
                    lname.Text = dr.GetValue(2).ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancelreg_Click(object sender, EventArgs e)
        {
            fname.Enabled = true;
            lname.Enabled = true;
            ages.Enabled = true;
            usrname.Enabled = true;
            email.Enabled = true;
            phonenum.Enabled = true;
            save.Enabled = true;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            School_add();

        }
        public void School_add()
        {
            //string pass = loginform.User_Password.ToString();
            //string username = loginform.Get_User_Name.ToString();
            //string query = "execute Fee_Information @id";
            //try
            //{
            //    SqlConnection conn = new SqlConnection(Conn);
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@id", 1);
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    classfee.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string query = "update Parent set First_Name = "+fname.Text+",Last_Name = "+lname.Text+",Age = "+ages.Text+",User_Name = "+usrname.Text+" where Parent_Id ="+loginform.getpid();
            SqlConnection conn = new SqlConnection(Conn);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
