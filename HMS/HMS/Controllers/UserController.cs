using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.Controllers
{
    public class UserController : Controller
    {

        public ActionResult Login(LoginInputModel model)
        {
            if (this.ModelState.IsValid)
            {
               
            }
            return View();
        }

        public ActionResult SaveUser()
        {
            return View();
        }

        public ActionResult DeleteUser()
        {
            return View();
        }
    }
}