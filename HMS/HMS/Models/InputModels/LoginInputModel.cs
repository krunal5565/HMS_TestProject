using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HMS.Models
{

    [Serializable]
    public class LoginInputModel
    {
        [Required(ErrorMessage = "Enter UserID")]
        public string UserID { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    [Serializable]
    public class LoggedInUser
    {
        public String FName { get; set; }
        public String LName { get; set; }
        public int UserID { get; set; }
        public string EmailID { get; set; }
    }
}