using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class RoomTypeModel: BaseClass
    {
        public string RoomTypeCode { get; set; }
        public string RoomTypeName { get; set; }
        public string CompanyUniqueID { get; set; }
        public string ActiveStatus { get; set; }
    }
}