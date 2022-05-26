using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FormMainMenu
{
    public partial class MainMenu : Form
    {
        private IconButton currbtn;
        private Panel leftBorderbt;
        //private FormMainMenu fmm;
        public MainMenu()
        {
            InitializeComponent();
            leftBorderbt = new Panel();
            leftBorderbt.Size = new Size(15,60);
            panelmenu.Controls.Add(leftBorderbt);

        }
        private struct RGBColors
        {
            public static Color color = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(172, 126, 241);
            public static Color color3 = Color.FromArgb(172, 126, 241);
            public static Color color4 = Color.FromArgb(172, 126, 241);

        }
        private void ActivateButton(object sederbtn,Color color)
        {
            if (sederbtn != null)
            {
                currbtn = (IconButton)sederbtn;
                currbtn.BackColor = Color.FromArgb(37,36,81);
                currbtn.ForeColor = color;
                currbtn.TextAlign = ContentAlignment.MiddleCenter;
                currbtn.IconColor = color;
                currbtn.TextImageRelation = TextImageRelation.TextBeforeImage;

               // leftBorderbt BackColor = color;

                    
                    }
        }
        private void DisplayBtn()
        {
            
            currbtn.BackColor = Color.FromArgb(37, 36, 81);
            currbtn.ForeColor = Color.Gainsboro;
            currbtn.TextAlign = ContentAlignment.MiddleLeft;
            currbtn.IconColor = Color.Gainsboro;
            currbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            currbtn.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void Dahs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
        }

        private void Order_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void Porduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }
    }
}
