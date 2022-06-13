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
        public String Conn = ("Data Source = DESKTOP-D6336JC; Initial Catalog = Online_Payment; Integrated Security = true");
        loginform loginform = new loginform();
        Global global = new Global();
        public Payment(loginform logfor)
        {
            InitializeComponent();
            this.loginform = logfor;
            //this.global = glob;
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Conn);
            int accnum = loginform.getPacc();
            try
            {
                conn.Open();
                conn.Close();
            }catch
            {

            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            School_List();
        }
        public static int countschid;
        public void School_List()
        {
            int pid = loginform.getpid();
            string query = "select School_Name,School_Id from School s where s.School_Id in (select School_Id from Parent_cloud where Parent_Id =" + pid + ")";
             string query1 = "select count(School_Id) as Number from Parent_cloud where Parent_Id = " + pid;
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
               SqlCommand cmd1 = new SqlCommand(query1, conn);
                countschid = Convert.ToInt32(cmd1.ExecuteScalar());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                schlistgrview.DataSource = dt;
                schlistgrview.Columns[2].Visible = false;
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(countschid < 11)
            {
                int j = 11 - countschid;
            }
        }
        
        public void changepanle()
        {
            Payment pform = new Payment(loginform);
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
            try
            {
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
            catch
            {

            }
        }
        public void deleteSchool()
        {
            string deleterecord = "delete from Parent_Cloud where Parent_Id =" + loginform.getpid() + " and School_Id = " + global.SCHOOL_ID;
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(deleterecord, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Successfully");
            conn.Close();
            School_List();
        }
        private void Schlistgrview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    if(schlistgrview.Columns[e.ColumnIndex].Name == "delete")
                {
                    if(MessageBox.Show("Are you sure want to delete this School?\nThis Will Delete All Student you Added Before", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        
                    {
                         global.SCHOOL_ID = schlistgrview.Rows[e.RowIndex].Cells["School_Id"].FormattedValue.ToString();
                         deleteSchool();
                    }
                }
            }catch
            {

            }
        }
    }
}
