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
    public partial class choosen_school : Form
    {
        private static loginform loginform = new loginform();
       private static  P_School_Form pforms = new P_School_Form(loginform);
        public choosen_school(loginform logfor,P_School_Form pform)
        {
            InitializeComponent();
            loginform = logfor;
            pforms = pform;
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pforms.getSchoolName());
            MessageBox.Show(pforms.getschoolId(),"School ID");
        }

        private void Choosen_school_Load(object sender, EventArgs e)
        {
            lbChoosenSchool.Text = pforms.getSchoolName();
        }
    }
}
