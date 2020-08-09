using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Helpers
{
    public class HMSLoginSessions
    {
        private const String fKeySessionAccount = "session_account_user";
        public static LoggedInUser LoggedInUser
        {
            get
            {
                if (SessionEnabled == false || HttpContext.Current.Session[fKeySessionAccount] == null)
                {
                    return null;
                }
                else
                {
                    return HttpContext.Current.Session[fKeySessionAccount] as LoggedInUser;
                }
            }

            set
            {
                if (SessionEnabled)
                {
                    HttpContext.Current.Session[fKeySessionAccount] = value;
                }
            }
        }

        private static Boolean SessionEnabled
        {
            get
            {
                return HttpContext.Current != null && HttpContext.Current.Session != null;
            }
        }

        public static Boolean IsLoggedIn
        {
            get
            {
                return (LoggedInUser != null);
            }
        }

        public static Boolean Logout()
        {
            if (IsLoggedIn)
            {
                LoggedInUser = null;
                HttpContext.Current.Session.Clear();
                HttpContext.Current.Session.Abandon();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}