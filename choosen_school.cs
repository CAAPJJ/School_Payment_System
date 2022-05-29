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
            addemtptyrow();
        }

       public void addemtptyrow()
        {
            //Bitmap bmp;

            //for (int x = 0; x <= stulistgrview.Rows.Count - 1; x++)

            //{

            //    DataGridViewImageCell cell = (DataGridViewImageCell)stulistgrview.Rows[x].Cells["Status"];

            //    if (stulistgrview.Rows[x].Cells["Status"].Value.ToString() == "21")

            //    {
            //        bmp = new Bitmap(@"C:\Users\leul kahssaye\source\repos\CAAPJJ\School_Payment_System\Resources\winclose.png");
            //    }

            //    else

            //    {

            //        bmp = new Bitmap(@"C:\Users\leul kahssaye\source\repos\CAAPJJ\School_Payment_System\Resources\winclose.png");

            //    }

            //    cell.Value = bmp;

            //}
        }
        private void Stulistgrview_DoubleClick(object sender, EventArgs e)
        {
            changepanle();
        }
        public void changepanle()
        {
            pnlliststudent.Controls.Clear();
            Pay_Now paynow = new Pay_Now();
            paynow.TopLevel = false;
            pnlliststudent.Controls.Clear();
            pnlliststudent.Controls.Add(paynow);
            paynow.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void student_list()
        {
            int pid = loginform.getpid();
            string query = "select First_Name,Last_Name,Student_Id from Student s where s.Student_Id in " +
                            "(select Student_Id from Parent_cloud p where Parent_Id = " + pid + " and p.School_Id =" +global.SCHOOL_ID+")";
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                stulistgrview.DataSource = dt;
                addemtptyrow();
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
            changepanle();
        }
        public string stufname,stulname,stuid;

        private void Stulistgrview_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Payes"].Value = "Not payed";
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
        public void checkifpay()
        {
            string query = "SELECT CAST(CASE WHEN COUNT(*) > 0 THEN 1 ELSE 0 END AS BIT)FROM Pay WHERE Parent_Id = 100;";
        }
    }
}
