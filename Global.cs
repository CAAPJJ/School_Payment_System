using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Payment
{
  public class Global
    {
      private static string School_Name,fname,lname;
        private static string id,stuid;
       
        public string SCHOOL_ID
        {
            set { id = value;}
            get { return id; }
        }
        public string STUDENT_ID
        {
            set { stuid = value; }
            get { return stuid; }
        }

        public string SCHOOL_NAME
        {
            set { School_Name = value; }
            get { return School_Name; }
        }
        public string STUDENT_FNAME
        {
            set { fname = value; }
            get { return fname; }
        }
        public string STUDENT_LNAME
        {
            set { lname = value; }
            get { return lname; }
        }

    }
}
