using HMS.Managers;
using HMS.Models;
using HMS.Web.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _IUserService;
        public UserManager userManager = null;

        public UserController(IUserService IUserService)
        {
            _IUserService = IUserService;
          
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginInputModel model)
        {
            if (this.ModelState.IsValid)
            {
                userManager = new UserManager(_IUserService);

                userManager.Login(model); 
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(UserModel model)
        {
            if (this.ModelState.IsValid)
            {
                userManager = new UserManager(_IUserService);

                userManager.CreateUser(model); 
            }

            return View();
        }

        [HttpGet]
        public ActionResult GetAllUsersByCompany(string companyId)
        {
            if (this.ModelState.IsValid)
            {
                 userManager = new UserManager(_IUserService);

                 List<UserModel> userModel =   userManager.GetAllUsersByCompany(companyId);
            }

            return View();
        }

        [HttpGet]
        public ActionResult GetUsersByEmail(string emailId)
        {
            if (this.ModelState.IsValid)
            {
                userManager = new UserManager(_IUserService);

                UserModel userModel = userManager.GetUserByEmail(emailId);
            }

            return View();
        }

        public ActionResult DeleteUser()
        {
            return View();
        }
    }
}