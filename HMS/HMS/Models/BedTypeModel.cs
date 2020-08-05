using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class BedTypeModel : BaseClass
    {
        public string BedTypeCode { get; set; }
        public string BedTypeName { get; set; }
        public string CompanyUniqueID { get; set; }
        public string ActiveStatus { get; set; }
    }
}