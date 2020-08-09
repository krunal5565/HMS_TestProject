using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BusinessPattern.BusinessLogic.BusinessClasses
{
    public class CommonBAL
    {
        public int ID { get; set; }
        public string UniqueID { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTimeOffset CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
    }
}
