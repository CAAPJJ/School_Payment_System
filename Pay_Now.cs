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
    public partial class Pay_Now : Form
    {
        public bool ispenality = false;
        public const int Penality = 100;
        public String Conn = ("Data Source = LAPTOP-C473Q6SO; Initial Catalog = Online_Payment; Integrated Security = true");
        int nextpayment = 0;
        DateTime d1 = new DateTime(2019, 12, 20);
        Global global = new Global();
        loginform loginform = new loginform();
        public Pay_Now(loginform logfor)
        {
            InitializeComponent();
            this.loginform = logfor;
        }

      public bool checkDate()
        {
            bool isdate = false;
            DateTime Date = DateTime.Now;
            int date = Convert.ToInt32(Date.ToString("dd"));
            nextpayment = date - 27;
            if (date == 27 || date == 28 || date == 29 || date == 30 || date == 31)
            {
                MessageBox.Show("Date");
                isdate = true;
            }
            else if (date == 1 || date == 2 || date == 3 || date == 6)
            {
                isdate = true;
                ispenality = true;
            }
            else
            {
                ispenality = true;
            }
            return isdate;
        }
        string payid;
        public string getdate()
        {
            string getd = "Select MAX(PId) as pid from Pay where Student_Id = "+global.STUDENT_ID;
            string paydate = null;
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(getd, conn);
                payid = cmd.ExecuteScalar().ToString();
                string getdates = "Select Pay_Date from Pay where PId = " + payid;
                SqlCommand cmd1 = new SqlCommand(getdates, conn);
                paydate = cmd1.ExecuteScalar().ToString();
            }
            catch
            {
                MessageBox.Show("No Payment History");
            }
            conn.Close();
            return paydate;
        }

        string classs;
        public float getfee()
        {
            string getClass = "Select Current_Class From Student where Student_Id = " + global.STUDENT_ID;
            float amount = 0;
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(getClass, conn);
                classs = cmd.ExecuteScalar().ToString();
                string getamount = "Select Calass_Fee_Amount from Fee where Class = " + classs + " and School_Id = " + global.SCHOOL_ID;
                SqlCommand cmd1 = new SqlCommand(getamount, conn);
                 amount = float.Parse(cmd1.ExecuteScalar().ToString());
            }
            catch
            {
                MessageBox.Show("Fee is not set For this Class");
            }
            conn.Close();
            return amount;
        }
            
            
            
               

        public static float penalityfee,monthfee,fee;
        public void CalculateFee()
        {
            float getfees = getfee();
            bool isdate = checkDate();
            string getdates = getdate();
            int month;
            DateTime Mydate = Convert.ToDateTime(getdates);
            DateTime dateTime = DateTime.Now;
            TimeSpan time = dateTime.Subtract(Mydate);
      
            if (isdate)
            { 
                if (ispenality)
                {
                   
                    month = Convert.ToInt32(time.Days) / 30;
                    penalityfee = ((month) * Penality);
                    monthfee = month * getfees;
                    fee = penalityfee + monthfee;
                }
                else
                {
                    month =Convert.ToInt32(time.Days) / 30;
                    penalityfee = ((month - 1) * Penality);
                    monthfee = month * getfees;
                    fee = penalityfee + monthfee;
                }
            }
            else
            {
                MessageBox.Show("You cant Pay Today!!!", "Message");
            } 
        }
        public int getschacc()
        {
            int account;
            string query = "select Account_num from School_Accounts where School_Id = " + global.SCHOOL_ID;
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            account = Convert.ToInt32(cmd.ExecuteScalar());
            return account;
        }
        private void Pay_Click(object sender, EventArgs e)
        {
            string paynow = "execute Payment @sender,@reciver,@Stu_Id,@amount";
            int j = loginform.getPacc();
            try
            {
                SqlConnection conn = new SqlConnection(Conn);
                conn.Open();
                SqlCommand cmd = new SqlCommand(paynow, conn);
                cmd.Parameters.AddWithValue("@sender", loginform.getPacc());
                cmd.Parameters.AddWithValue("@reciver", getschacc().ToString());
                cmd.Parameters.AddWithValue("@Stu_Id", global.STUDENT_ID);
                CalculateFee();
                cmd.Parameters.AddWithValue("@amount", fee);
                MessageBox.Show("payment Succssfully");
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            CalculateFee();
            
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Pay_Now_Load(object sender, EventArgs e)
        {
            CalculateFee();
            fees.Text = getfee().ToString();
            if (ispenality)
            {
                pena.Text = "Penality";
                pena.ForeColor = Color.Red;
            }
            else
            {
                pena.Text = "None";
                pena.ForeColor = Color.Green;
            }

            ttlpenality.Text = penalityfee.ToString();
            unpmonth.Text = monthfee.ToString();
            totalFee.Text = fee.ToString();
           

            stufname.Text = global.STUDENT_FNAME;
            stulname.Text = global.STUDENT_LNAME;
            stuid.Text = global.STUDENT_ID;
            schname.Text = global.SCHOOL_NAME;
            currclass.Text = classs;

           
        }
    }
}
