using HMS.Models;
using HMS.Web.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyMasterService _IcompanyMasterService ; 

        [HttpGet]
        public ActionResult index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveCompany(CompanyModel model)
        {
            if(model != null)
            {
                _IcompanyMasterService.Save(model);
            }
            return View();
        }

        [HttpPost]
        public ActionResult DeleteCompany(int companyId)
        {
            return View();
        }


    }
}