//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS.Repository.EMDX
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLogin
    {
        public int ID { get; set; }
        public string UniqueID { get; set; }
        public string UserID { get; set; }
        public string KeyPass { get; set; }
        public string UserUniqueID { get; set; }
        public string LockStatus { get; set; }
        public string ActiveStatus { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTimeOffset CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
    
        public virtual UserMaster UserMaster { get; set; }
    }
}
