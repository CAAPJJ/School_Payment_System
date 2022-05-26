﻿using System;
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

        private void Serch_Click(object sender, EventArgs e)
        {
            string searches = "execute Search_School @Schname";
            SqlConnection conn = new SqlConnection(Conn);
            SqlCommand cmd = new SqlCommand(searches, conn);
            cmd.Parameters.AddWithValue("@Schname", search.Text);
            SqlDataAdapter adabter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adabter.Fill(table);
            stugrv.DataSource = table;
            conn.Close();
        }
        public void RefreshData()
        {
            SqlConnection conn = new SqlConnection(Conn);
            SqlCommand cmd = new SqlCommand("select *from Student", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            stugrv.DataSource = dt;
        }

       public string scid;
        private void Stugrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(stugrv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                stugrv.CurrentRow.Selected = true;
                school_name.Text = stugrv.Rows[e.RowIndex].Cells["School_Name"].FormattedValue.ToString();
                address.Text = stugrv.Rows[e.RowIndex].Cells["Adress"].FormattedValue.ToString();
                schemail.Text = stugrv.Rows[e.RowIndex].Cells["School_Email"].FormattedValue.ToString();
                phonenum.Text = stugrv.Rows[e.RowIndex].Cells["Phone_number"].FormattedValue.ToString();
                scid = stugrv.Rows[e.RowIndex].Cells["School_Id"].FormattedValue.ToString();
            }
            sch_fee_info();
        }

        public void sch_fee_info()
        {
            string query = "execute Fee_Information @id";
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", loginform.getsid());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            schoolclassfee.DataSource = dt;
            conn.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
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
                stugrv.DataSource = table;
                MessageBox.Show("School Add Successfully");
            }catch(Exception ex)
            {

            }
            conn.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void School_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            school_name.Text = "";
            address.Text = "";
            schemail.Text = "";
            phonenum.Text = "";
        }

        private void P_School_Form_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
