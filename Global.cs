using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Payment
{
  public class Global
    {
      private string Name = "Leul";
        private string id = "0";
       
        public string SCHOOL_ID
        {
            set { this.id = value;}
            get { return id; }
        }
        
    }
}
