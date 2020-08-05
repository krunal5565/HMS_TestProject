using HMS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class ErrorModel
    {
        public ErrorCode Code { get; set; }

        public string Message { get; set; }
    }
}