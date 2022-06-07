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
        Global global = new Global();
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
        public void school_add()
        {
            string addtocloud = "execute add_cloud  @pid,@sid,@stuid";
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(addtocloud, conn);
                cmd.Parameters.AddWithValue("@pid", loginform.getpid());
                cmd.Parameters.AddWithValue("@sid", global.SCHOOL_ID);
                cmd.Parameters.AddWithValue("@stuid", stuid.Text);
                SqlDataAdapter adabter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adabter.Fill(table);
                gvschoolsearch.DataSource = table;
                MessageBox.Show("School Add Successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            School_List();
        }
        public void addemtptyrow(int i)
        {
            for (i = 0; i < 10; i++)
            {
                DataTable dt = schlistgrview.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
                schlistgrview.DataSource = dt;
            }
        }
        public bool checkifexist()
        {
            string query = "select count(*) from Student where Student_Id = "+ stuid.Text.ToString() + " and School_Id = "+ global.SCHOOL_ID;
           // MessageBox.Show(global.STUDENT_ID);
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            string row = cmd.ExecuteScalar().ToString();
            conn.Close();
            if (row == "1")
            {
                return true;
            }
            else
            { return false; }
            
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(countschid < 11)
            {
                int j = 11 - countschid;
                addemtptyrow(j);
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void School_name_TextChanged(object sender, EventArgs e)
        {

        }
        private void P_School_Form_Load(object sender, EventArgs e)
        {
            School_List();
        }

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

        private void Gvschoolsearch_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvschoolsearch.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    gvschoolsearch.CurrentRow.Selected = true;
                    school_name.Text = gvschoolsearch.Rows[e.RowIndex].Cells["School_Name"].FormattedValue.ToString();
                    address.Text = gvschoolsearch.Rows[e.RowIndex].Cells["Adress"].FormattedValue.ToString();
                    schemail.Text = gvschoolsearch.Rows[e.RowIndex].Cells["School_Email"].FormattedValue.ToString();
                    phonenum.Text = gvschoolsearch.Rows[e.RowIndex].Cells["Phone_number"].FormattedValue.ToString();
                    global.SCHOOL_ID = gvschoolsearch.Rows[e.RowIndex].Cells["School_Id"].FormattedValue.ToString();
                }
            }
            catch
            {

            }
            
        }

        private void Add_School_Click(object sender, EventArgs e)
        {
            bool checkes = checkifexist();
            if (checkes)
            {
                school_add();
            }
            else { 
                     MessageBox.Show("unavailable Student Id","Message",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            school_name.Clear();
            address.Clear();
            schemail.Clear();
            phonenum.Clear();
        }

        private void Stuid_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool checkes = checkifexist();
                if (checkes)
                {
                    school_add();
                }
                else
                {
                    MessageBox.Show("unavailable Student Id", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }
           
        }
    }
}
