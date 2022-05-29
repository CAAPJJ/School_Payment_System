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
        loginform loginform = new loginform();
        Global global = new Global();
        public Payment(loginform logfor,Global glob)
        {
            InitializeComponent();
            this.loginform = logfor;
            this.global = glob;
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
                conn.Close();
            }catch (Exception ex)
            {

            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            School_List();
        }
        public void School_List()
        {
            int pid = loginform.getpid();
            string query = "select School_Name,School_Id from School s where s.School_Id in (select School_Id from Parent_cloud where Parent_Id =" + pid + ")";
           // string query1 = "select count(School_Id) as Number from Parent_cloud where Parent_Id = " + pid;
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
               // SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                schlistgrview.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void changepanle()
        {
            Payment pform = new Payment(loginform,global);
            pnlPaymnet.Controls.Clear();
            choosen_school choosen = new choosen_school(loginform);
            choosen.TopLevel = false;
            pnlPaymnet.Controls.Clear();
            pnlPaymnet.Controls.Add(choosen);
            choosen.Show();
        }
      
        public string scid, scname;
        private void Schlistgrview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Global global = new Global();
            if (schlistgrview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                schlistgrview.CurrentRow.Selected = true;
                scname = schlistgrview.Rows[e.RowIndex].Cells["School_Name"].FormattedValue.ToString();
                scid = schlistgrview.Rows[e.RowIndex].Cells["School_Id"].FormattedValue.ToString();
                global.SCHOOL_ID = scid;
                global.SCHOOL_NAME = scname;
            }
            changepanle();
        }
        //public void getid()
        //{
        //    MessageBox.Show(global.SCHOOL_ID, "when change get id");
        //}
       
    }
}
