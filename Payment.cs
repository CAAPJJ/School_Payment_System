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
    public partial class Payment : Form
    {
        string id;
        public String Conn = ("Data Source = LAPTOP-C473Q6SO; Initial Catalog = Online_Payment; Integrated Security = true");
        //SqlConnection conn = new SqlConnection(Conn);
        loginform loginform = new loginform();
        public Payment(loginform logfor)
        {
            InitializeComponent();
            this.loginform = logfor;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pay_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Conn);
            int accnum = loginform.getPacc();
            try
            {
                conn.Open();
                string q1 = "";
                conn.Close();
            }catch (Exception ex)
            {

            }
        }

        public void get_Id()
        {
            SqlConnection conn = new SqlConnection(Conn);
            loginform loginform = new loginform();
            conn.Open();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select Parent_Id from Parent Where User_Name ='"+loginform.Get_User_Name+"' and Password = '"+loginform.User_Password+"'", conn);
            dr = cmd.ExecuteReader();
            id = dr.GetValue(0).ToString();
            MessageBox.Show(id);
            conn.Close();
        }
    }
}
