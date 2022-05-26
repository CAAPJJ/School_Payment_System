using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Payment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadingForm loading = new LoadingForm();
           // Parent_Form P_form = new Parent_Form();
            //P_form.Show();
            loading.Show();
            Application.Run();
            
        }
    }
}
