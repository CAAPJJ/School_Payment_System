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
using System.IO;
//alt + shift +uparrow/downarrow then click to write multi line at once

namespace Online_Payment
{
    public partial class School_Adminstration : Form
    {
        public String Conn = ("Data Source = LAPTOP-C473Q6SO; Initial Catalog = Online_Payment; Integrated Security = true");
        string Gender;
        string query;

        loginform loginform = new loginform();
        Global global = new Global();
        
        public School_Adminstration(loginform logfor)
        {
            
            InitializeComponent();
            this.loginform = logfor;
            lablename();
            Display_Student();
        }
        //public int getid()
        //{
        //    int id;
        //    query = "execute Get_School_Id @username,@userpassword";
        //    SqlConnection conn = new SqlConnection(Conn);
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    cmd.Parameters.AddWithValue("@username", loginform.Get_User_Name);
        //    cmd.Parameters.AddWithValue("@userpassword", loginform.User_Password);
        //    id = Convert.ToInt32(cmd.ExecuteScalar());
        //    conn.Close();
        //    return id;
        //}
        private void lablename()
        {
            SqlConnection conn = new SqlConnection(Conn);
            string pass = loginform.User_Password.ToString();
            string username = loginform.Get_User_Name.ToString();
            query = "select School_Name from School where User_Name='" + username + "'and Password=" + "'" + pass + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
              string name=  cmd.ExecuteScalar().ToString();
                schname.Text = name;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Display_Student()
        {
            string pass = loginform.User_Password.ToString();
            string username = loginform.Get_User_Name.ToString();
            query = "execute School_Student_List '"+username+"',"+"'"+pass+"'";
            try
            {
                SqlDataAdapter stu = new SqlDataAdapter(query, Conn);
                SqlCommandBuilder cnd = new SqlCommandBuilder(stu);
                var ds = new DataSet();
                stu.Fill(ds);
                StuListGv.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void StuListGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Stufname.Text = StuListGv.SelectedRows[0].Cells[1].Value.ToString();
            stulname.Text = StuListGv.SelectedRows[0].Cells[2].Value.ToString();
            stuage.Text = StuListGv.SelectedRows[0].Cells[3].Value.ToString();
            sex.Text = StuListGv.SelectedRows[0].Cells[4].Value.ToString();
            stuage.Text = StuListGv.SelectedRows[0].Cells[5].Value.ToString();
            stuemail.Text = StuListGv.SelectedRows[0].Cells[6].Value.ToString();
            currclass.Text = StuListGv.SelectedRows[0].Cells[7].Value.ToString();
            address.Text = StuListGv.SelectedRows[0].Cells[8].Value.ToString();
            stuponenum.Text = StuListGv.SelectedRows[0].Cells[9].Value.ToString();
        }

        bool checkes;
        public bool ifexist()
        {
            string query = "Select * from fee where School_Id = "+ loginform.getsid() + " and Class = "+currclass.Text.ToString();
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            object trying = cmd.ExecuteScalar();
           // MessageBox.Show(trying.ToString(), "what's this return");
                if(trying != null)
            {
                checkes = true;
            }
            else
            {
                checkes = false;
            }
            return checkes;
        }
        private void add_student_Click(object sender, EventArgs e)
            
        {
         
            if (ifexist())
            {
                int get_id = loginform.getsid();
                byte[] Imagebt = null;
                    try
                    {
                        FileStream fstream = new FileStream(this.picspath.Text, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fstream);
                        Imagebt = br.ReadBytes((int)fstream.Length);
                        SqlConnection conn = new SqlConnection(Conn);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("execute Student_info @schuid,@First,@Last,@sex,@age,@users," +
                            "@password,@email,@address,@phone,@Class,@Image", conn);
                        cmd.Parameters.AddWithValue("@schuid", get_id);
                        cmd.Parameters.AddWithValue("@First", Stufname.Text.ToString());
                        cmd.Parameters.AddWithValue("@Last", stulname.Text.ToString());
                        cmd.Parameters.AddWithValue("@sex", Gender);
                        cmd.Parameters.AddWithValue("@age", stuage.Text.ToString());
                        cmd.Parameters.AddWithValue("@users", stuusername.Text.ToString());
                        cmd.Parameters.AddWithValue("@password", "123456");
                        cmd.Parameters.AddWithValue("@email", stuemail.Text.ToString());
                        cmd.Parameters.AddWithValue("@address", address.Text.ToString());
                        cmd.Parameters.AddWithValue("@phone", stuponenum.Text.ToString());
                        cmd.Parameters.AddWithValue("@Class", currclass.Text.ToString());
                        cmd.Parameters.Add(new SqlParameter("@Image", Imagebt));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student " + Stufname.Text + " Registerde");
                        conn.Close();

                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("Username or email address are already registerd");
                        }
                    }
                }
            else
            {
                MessageBox.Show("School Fee Is not set For This Class " + currclass.Text, "Information");
            }
                
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }
      
        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Display_Student();
            Class_Fee_Info();
        }

        private void Srcid_Click(object sender, EventArgs e)
        {
            string student_id = id.Text.ToString();
            query = "select * from Student where Student_Id = "+ student_id;
            try
            {
                SqlDataAdapter stu = new SqlDataAdapter(query, Conn);
                SqlCommandBuilder cnd = new SqlCommandBuilder(stu);
                var ds = new DataSet();
                stu.Fill(ds);
                StuListGv.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
            //Display_Student();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
           
            loginform loginform = new loginform();
            loginform.Show();
            this.Hide();
        }

        private void Fee_add_Click(object sender, EventArgs e)
        {
            Class_Fee_Info();
            try
            {
                SqlConnection conn = new SqlConnection(Conn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("execute fee_info @Sch_Id,@class,@amount", conn);
                cmd.Parameters.AddWithValue("@Sch_Id", loginform.getsid());
                cmd.Parameters.AddWithValue("@class", classval.Text.ToString());          
                cmd.Parameters.AddWithValue("@amount", fee.Text.ToString());
                cmd.ExecuteNonQuery();
                int result = cmd.ExecuteNonQuery();
                if (result < 1)
                {
                    MessageBox.Show("u are already set the value to the class" + classval.Text);
                }
                else
                {
                    MessageBox.Show("u are Successfully set the value to the class  " + classval.Text + " \n try to update if you want it" + result);
                }
                conn.Close();
                
                
            }
            catch (SqlException ex)
            {
          
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Class "+classval.Text.ToString()+" is already set Fee "+fee.Text.ToString());
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Class_Fee_Info()
        {
            string pass = loginform.User_Password.ToString();
            string username = loginform.Get_User_Name.ToString();
            query = "execute Fee_Information @id";
            try
            {
                SqlConnection conn = new SqlConnection(Conn);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", loginform.getsid());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                classfee.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.gif; *.bmp;)";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string picpath = ofd.FileName.ToString();
                picspath.Text = picpath;
                userimage.ImageLocation = picpath;
            }
        }

        private void Update_class_fee_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update fee set Calass_Fee_Amount=@amount where Class=@class and School_Id = @Sch_Id", conn);
                cmd.Parameters.AddWithValue("@Sch_Id", loginform.getsid());
                cmd.Parameters.AddWithValue("@class", classval.Text.ToString());
                cmd.Parameters.AddWithValue("@amount", fee.Text.ToString());
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            conn.Close();
        }

        private void Currclass_TextChanged(object sender, EventArgs e)
        {

        }

        private void School_Adminstration_Load(object sender, EventArgs e)
        {
            Display_Student();
            Class_Fee_Info();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Stufname.Text = "Tegaye";
            stulname.Text = "Kahssaye";
            stuage.Text = "25";
            address.Text = "Sarbet";
            stuusername.Text = "@Tsegajan";
            stuemail.Text = "TsegaJanbo@gmai;.com";
            stuponenum.Text = "975171016";
            currclass.Text = "12";
        }
        private void Schoool_Adminstration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Winmax_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Winclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }
        public void deletestudent()
        {
            string deleterecord = "delete from Student where School_Id =" + loginform.getsid() + " and Student_Id = " + global.STUDENT_ID;
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(deleterecord, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Successfully");
            conn.Close();
            Display_Student();
        }

        private void StuListGv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (StuListGv.Columns[e.ColumnIndex].Name == "delete")

                {
                    if (MessageBox.Show("Are you sure want to delete this Student?\nThis Will Delete All Student you Added Before", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        global.STUDENT_ID = StuListGv.Rows[e.RowIndex].Cells["Student_Id"].FormattedValue.ToString();
                        deletestudent();
                    }

                }

            }
            catch
            {

            }
        }
        public void listpayer()
        {

        }
        private void TabPage3_Click(object sender, EventArgs e)
        {
            listpayer();
        }
    }
}
