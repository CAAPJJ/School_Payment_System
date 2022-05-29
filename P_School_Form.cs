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
    public partial class P_School_Form : Form
    {
        public String Conn = ("Data Source = LAPTOP-C473Q6SO; Initial Catalog = Online_Payment; Integrated Security = true");
        public string scid;
        loginform loginform = new loginform();
        public P_School_Form(loginform logfor)
        {
            InitializeComponent();
            this.loginform = logfor;

        }

        private void Search_Click(object sender, EventArgs e)
        {
            search.Text = "";
            search.ForeColor = Color.Black;
        }

        public void search_school()
        {
            string searches = "execute Search_School @Schname";
            SqlConnection conn = new SqlConnection(Conn);
            SqlCommand cmd = new SqlCommand(searches, conn);
            cmd.Parameters.AddWithValue("@Schname", search.Text);
            SqlDataAdapter adabter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adabter.Fill(table);
            gvschoolsearch.DataSource = table;
            conn.Close();
        }
        private void Serch_Click(object sender, EventArgs e)
        {
            search_school();
           
        }

        //public void RefreshData()
        //{
        //    //SqlConnection conn = new SqlConnection(Conn);
        //    //SqlCommand cmd = new SqlCommand("select *from Student", conn);
        //    //SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    //DataTable dt = new DataTable();
        //    //sda.Fill(dt);
        //    //stugrv.DataSource = dt;
        //}
        private void gvschoolsearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvschoolsearch.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                gvschoolsearch.CurrentRow.Selected = true;
                school_name.Text = gvschoolsearch.Rows[e.RowIndex].Cells["School_Name"].FormattedValue.ToString();
                address.Text = gvschoolsearch.Rows[e.RowIndex].Cells["Adress"].FormattedValue.ToString();
                schemail.Text = gvschoolsearch.Rows[e.RowIndex].Cells["School_Email"].FormattedValue.ToString();
                phonenum.Text = gvschoolsearch.Rows[e.RowIndex].Cells["Phone_number"].FormattedValue.ToString();
                scid = gvschoolsearch.Rows[e.RowIndex].Cells["School_Id"].FormattedValue.ToString();
            }
        }
        public void school_add()
        {
            string addtocloud = "execute add_cloud  @pid,@sid,@stuid";
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(addtocloud, conn);
                cmd.Parameters.AddWithValue("@pid", loginform.getpid());
                cmd.Parameters.AddWithValue("@sid", scid);
                cmd.Parameters.AddWithValue("@stuid", stuid.Text);
                SqlDataAdapter adabter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adabter.Fill(table);
                gvschoolsearch.DataSource = table;
                MessageBox.Show("School Add Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            School_List();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            school_add();
        }

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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void School_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            school_name.Clear();
            address.Clear();
            schemail.Clear();
            phonenum.Clear();
        }

        private void P_School_Form_Load(object sender, EventArgs e)
        {
            School_List();
        }
        //string scname, sclid;
        //private void Schlistgrview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (schlistgrview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //    {
        //        schlistgrview.CurrentRow.Selected = true;
        //        scname = schlistgrview.Rows[e.RowIndex].Cells["School_Name"].FormattedValue.ToString();
        //        sclid = schlistgrview.Rows[e.RowIndex].Cells["School_Id"].FormattedValue.ToString();
        //    }
        //    changepanle();
        //}

        //public string SCHOOL_NAME{
        //    get { return scname; }
        //    }
        //public string getschoolId()
        //{
        //    return sclid;
        //}

        //public void changepanle()
        //{
        //    MessageBox.Show(SCHOOL_NAME);
        //    //MessageBox.Show(getSchoolName());
        //    P_School_Form pform = new P_School_Form(loginform);
        //    pnlP_School.Controls.Clear();
        //    choosen_school choosen = new choosen_school(pform, loginform);
        //    choosen.TopLevel = false;
        //    pnlP_School.Controls.Clear();
        //    pnlP_School.Controls.Add(choosen);
        //    choosen.Show();
        //}
        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_school();
            }
        }

        private void Stuid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                school_add();
            }
        }

        private void PnlP_School_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
