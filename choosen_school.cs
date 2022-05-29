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
        private static loginform loginform = new loginform();
        public Payment pforms = new Payment(loginform);
        public choosen_school()
        {
              InitializeComponent();
              // this.pforms = pform;
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            // //MessageBox.Show(pforms.getschoolId(),"loginform");
            // MessageBox.Show(pforms.SCHOOL_NAME,"School Name");
            //changepanle();
        }
        private void Choosen_school_Load(object sender, EventArgs e)
        {
            lbChoosenSchool.Text = loginform.getpid().ToString();
            student_list();
        }

        private void Stulistgrview_DoubleClick(object sender, EventArgs e)
        {
            changepanle();
        }
        public void changepanle()
        {
            MessageBox.Show(pforms.SCHOOL_ID,"School ID");
            MessageBox.Show(pforms.SCHOOL_NAME, "School NAME");

            //pnlliststudent.Controls.Clear();
            //Payme
            //choosen_school choosen = new choosen_school(pform,loginform);
            //choosen.TopLevel = false;
            //pnlliststudent.Controls.Clear();
            //pnlliststudent.Controls.Add(choosen);
            //choosen.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void student_list()
        {
            int pid = loginform.getpid();
            string scid = pforms.SCHOOL_ID;
            string query = "select First_Name,Last_Name,Student_Id from Student s where s.Student_Id in " +
                            "(select Student_Id from Parent_cloud p where Parent_Id = " + pid + " and p.School_Id =" +1+")";
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                //SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                stulistgrview.DataSource = dt;
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
    }
}
