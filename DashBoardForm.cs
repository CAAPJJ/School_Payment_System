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
    public partial class DashBoardForm : Form
       
    {
        public String Conn = ("Data Source = LAPTOP-C473Q6SO; Initial Catalog = Online_Payment; Integrated Security = true");

        loginform loginform = new loginform();
        public DashBoardForm(loginform logfor)
        {
            InitializeComponent();
            this.loginform = logfor;
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            currbalance();
        }
        public void currbalance()
        {
            string query = "execute get_Amount @pid";
            SqlConnection conn = new SqlConnection(Conn);
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", loginform.getpid());
                curbala.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }catch
            {
               MessageBox.Show("error Occured","Message");
                conn.Close();
            }
            

        }


    }
}
