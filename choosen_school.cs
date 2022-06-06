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
    public partial class choosen_school : Form
    {
        public String Conn = ("Data Source = LAPTOP-C473Q6SO; Initial Catalog = Online_Payment; Integrated Security = true");
         loginform loginform = new loginform();
        private static Global global = new Global();
        public choosen_school(loginform logfor)
        {
              InitializeComponent();
              this.loginform = logfor;
        }

        private void Label6_Click(object sender, EventArgs e)
        {
        }
        private void Choosen_school_Load(object sender, EventArgs e)
        {
            lbChoosenSchool.Text = global.SCHOOL_NAME;
            student_list();
           if(counts < 11)
            {
                int j = 11 - counts;
                addemtptyrow(j);
            }
        }
      public void addemtptyrow(int i)
        {
            //for(i = 0; i<10; i++)
            //{
            //    DataTable dt = stulistgrview.DataSource as DataTable;
            //    DataRow dr = dt.NewRow();
            //    dt.Rows.Add(dr);
            //    stulistgrview.DataSource = dt;
            //}
        }
     
        private void Stulistgrview_DoubleClick(object sender, EventArgs e)
        {
            changepanle();
        }
        public void changepanle()
        {
            pnlliststudent.Controls.Clear();
            Pay_Now paynow = new Pay_Now(loginform);
            paynow.TopLevel = false;
            pnlliststudent.Controls.Clear();
            pnlliststudent.Controls.Add(paynow);
            paynow.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       public static int counts;
        public void student_list()
        {
            int pid = loginform.getpid();
            string query = "select First_Name,Last_Name,Student_Id from Student s where s.Student_Id in " +
                            "(select Student_Id from Parent_cloud p where Parent_Id = " + pid + " and p.School_Id =" +global.SCHOOL_ID+")";
            string count = "select count(*) from Student s where s.Student_Id in " +
                            "(select Student_Id from Parent_cloud p where Parent_Id = " + pid + " and p.School_Id =" + global.SCHOOL_ID + ")";
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand cmd1 = new SqlCommand(count, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                stulistgrview.DataSource = dt;
                counts =Convert.ToInt32(cmd1.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            changepanle();
        }

        private void LbChoosenSchool_Click(object sender, EventArgs e)
        {
            
        }
        public string stufname,stulname,stuid;

        private void Stulistgrview_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Payes"].Value = "Not payed";
        }
        public void delteStudent()
        {
            string deleterecord = "delete from Parent_Cloud where Parent_Id =" + loginform.getpid() + " and Student_Id = " + global.STUDENT_ID + " and School_Id = " + global.SCHOOL_ID;
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(deleterecord, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Successfully","Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
            conn.Close();
            student_list();
        }
        private void Stulistgrview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                stuid = stulistgrview.Rows[e.RowIndex].Cells["Student_Id"].FormattedValue.ToString();
                global.STUDENT_ID = stuid;
                if (stulistgrview.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Are you sure want to delete this Student?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    {
                        delteStudent();
                    }
                    else
                    {
                        MessageBox.Show("Delte Cancceled");
                    }
                }
            }
            catch
            {

            }


        }

        private void Stulistgrview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stulistgrview.CurrentRow.Selected = true;
            stufname = stulistgrview.Rows[e.RowIndex].Cells["First_Name"].FormattedValue.ToString();
            stulname = stulistgrview.Rows[e.RowIndex].Cells["Last_Name"].FormattedValue.ToString();
            stuid = stulistgrview.Rows[e.RowIndex].Cells["Student_Id"].FormattedValue.ToString();
            global.STUDENT_ID = stuid;
            global.STUDENT_FNAME = stufname;
            global.STUDENT_LNAME = stulname;
            changepanle();
        }

        private void Stulistgrview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                pnlliststudent.Controls.Clear();
                Pay_Now paynow = new Pay_Now(loginform);
                paynow.TopLevel = false;
                pnlliststudent.Controls.Clear();
                pnlliststudent.Controls.Add(paynow);
                paynow.Show();
            }
        }

        public void checkifpay()
        {
            string query = "SELECT CAST(CASE WHEN COUNT(*) > 0 THEN 1 ELSE 0 END AS BIT)FROM Pay WHERE Parent_Id = 100;";
        }
    }
}
