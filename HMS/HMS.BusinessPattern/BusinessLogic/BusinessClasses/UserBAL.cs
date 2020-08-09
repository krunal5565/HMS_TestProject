using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BusinessPattern.BusinessLogic.BusinessClasses
{
    public class UserBAL: CommonBAL
    {
        public string CompanyUniqueID { get; set; }
        public string ActiveStatus { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
    }
}
