using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class LoginInputModel
    {
        [Required(ErrorMessage = "Enter UserID")]
        public string UserID { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string KeyPass { get; set; }

    }
}