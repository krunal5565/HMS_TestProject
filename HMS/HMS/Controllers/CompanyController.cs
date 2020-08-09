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
    public class CompanyController : Controller
    {
        private readonly ICompanyMasterService _IcompanyMasterService ;
        public CompanyManager companyManager = null;

        public CompanyController(ICompanyMasterService IcompanyMasterService)
        {
           
            _IcompanyMasterService = IcompanyMasterService; 
        }

        [HttpGet]
        public ActionResult index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult createCompany(CompanyModel model)
        {
            if(model != null && ModelState.IsValid)
            {
                companyManager = new CompanyManager(_IcompanyMasterService);
                companyManager.CreateCompany(model);
            }

            return View();
        }

        [HttpGet]
        public ActionResult GetAllCompanies()
        {     
            companyManager = new CompanyManager(_IcompanyMasterService);
            List<CompanyModel> userModel = companyManager.GetAllCompanies();
          
            return View();
        }

        [HttpPost]
        public ActionResult DeleteCompany(int companyId)
        {
            return View();
        }


    }
}