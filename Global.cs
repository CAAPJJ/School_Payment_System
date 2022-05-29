using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Payment
{
  public class Global
    {
      private static string School_Name;
        private static string id;
       
        public string SCHOOL_ID
        {
            set { id = value;}
            get { return id; }
        }

        public string SCHOOL_NAME
        {
            set { School_Name = value; }
            get { return School_Name; }
        }

    }
}
