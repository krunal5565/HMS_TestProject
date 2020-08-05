using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Helpers
{
    public enum ErrorCode
    {
        ApplicationError = 999,
        UnauthorizedRequest = 401,
        Forbidden = 403,
    }
}