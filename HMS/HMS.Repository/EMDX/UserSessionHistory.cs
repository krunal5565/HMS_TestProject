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
    
    public partial class UserSessionHistory
    {
        public int ID { get; set; }
        public string UserUniqueID { get; set; }
        public string SessionID { get; set; }
        public System.DateTimeOffset LoginTime { get; set; }
        public Nullable<System.DateTimeOffset> LogoutTime { get; set; }
        public string SessionToken { get; set; }
        public string IPAddress { get; set; }
        public string Browser { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
    }
}
