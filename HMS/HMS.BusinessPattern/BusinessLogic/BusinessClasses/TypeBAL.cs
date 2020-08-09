using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BusinessPattern.BusinessLogic.BusinessClasses
{
    public class BedTypeBAL : CommonBAL
    {
        public string BedTypeCode { get; set; }
        public string BedTypeName { get; set; }
        public string CompanyUniqueID { get; set; }
        public string ActiveStatus { get; set; }
    }
    public class RoomTypeBAL : CommonBAL
    {
        public string RoomTypeCode { get; set; }
        public string RoomTypeName { get; set; }
        public string CompanyUniqueID { get; set; }
        public string ActiveStatus { get; set; }
    }
}
