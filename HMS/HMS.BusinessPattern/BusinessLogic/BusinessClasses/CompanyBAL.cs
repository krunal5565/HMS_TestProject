using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BusinessPattern.BusinessLogic.BusinessClasses
{
    public class CompanyBAL : CommonBAL
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        public string Website { get; set; }
        public string ActiveStatus { get; set; }
  
    }
}
