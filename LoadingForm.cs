using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Payment
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           if(progressBar1.Value < 100)
            {
                progressBar1.Value += 5;
                percent.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                loginform log = new loginform();
                log.Show();
                this.Close();
            }
        }
    }
}
