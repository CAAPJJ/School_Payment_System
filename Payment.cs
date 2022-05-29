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
                //string q1 = "";
                conn.Close();
            }catch (Exception ex)
            {

            }
        }

        //public void get_Id()
        //{
        //    SqlConnection conn = new SqlConnection(Conn);
        //    loginform loginform = new loginform();
        //    conn.Open();
        //    SqlDataReader dr;
        //    SqlCommand cmd = new SqlCommand("select Parent_Id from Parent Where User_Name ='"+loginform.Get_User_Name+"' and Password = '"+loginform.User_Password+"'", conn);
        //    dr = cmd.ExecuteReader();
        //    id = dr.GetValue(0).ToString();
        //    MessageBox.Show(id);
        //    conn.Close();
        //}

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
            //choosen_school choosens = new choosen_school();
            //((TextBox)choosens.Controls["textBox1"]).Text = "leul";
            MessageBox.Show(scild);
            MessageBox.Show(SCHOOL_NAME);
            Payment pform = new Payment(loginform);
            pnlPaymnet.Controls.Clear();
            choosen_school choosen = new choosen_school();
            choosen.TopLevel = false;
            pnlPaymnet.Controls.Clear();
            pnlPaymnet.Controls.Add(choosen);
            choosen.Show();
        }
        public string SCHOOL_NAME { get; private set; }
        public string SCHOOL_ID { get; private set; }
        public string scild;
        private void Schlistgrview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (schlistgrview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                schlistgrview.CurrentRow.Selected = true;
                SCHOOL_NAME = schlistgrview.Rows[e.RowIndex].Cells["School_Name"].FormattedValue.ToString();
                scild = schlistgrview.Rows[e.RowIndex].Cells["School_Id"].FormattedValue.ToString();
            }
            changepanle();
        }

        //public string getschoolId()
        //{
        //    return sclid;
        //}
    }
}
