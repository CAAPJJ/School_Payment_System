using System;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Online_Payment
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Parse("05/07/2022");
            DateTime date2 = DateTime.Now;
            if (date1.Date > date2.Date)
            {
                //It's a later date
                int past;
                int date11 = int.Parse(date2.ToString());
                int date22 = int.Parse(date1.ToString());
                past = date11 - date22;
                MessageBox.Show(past.ToString()+" It's a later date");
            }
            else if (date1.Date < date2.Date)
            {
                //It's an earlier or equal date
                MessageBox.Show("It's an earlier date ");
            }
            else
            {
                PopupNotifier pop = new PopupNotifier();
                pop.Image = Properties.Resources.passicon;
                pop.TitleText = "its Daydate to Pay Your monthly Fee";
                pop.ContentText = "If you Don't Pay For the next Two Wee Your Son will Disqualified from School";
                pop.Popup();
            }
            Console.ReadLine();
        }
    }
}
