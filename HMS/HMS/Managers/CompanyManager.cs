using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using HMS.BusinessPattern.BusinessLogic.UtilityClasses;
using HMS.Models;
using HMS.Web.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Managers
{
    public class CompanyManager
    {
        private readonly ICompanyMasterService _ICompanyMasterService;
        public CompanyManager(ICompanyMasterService ICompanyMasterService)
        {
            _ICompanyMasterService = ICompanyMasterService;
        }

        public bool CreateCompany(CompanyModel model)
        {
            bool success = false; 
            if(model != null)
            {
                CompanyBAL companyBAL = HMSAutoMapper.mapper.Map<CompanyModel, CompanyBAL>(model);

                success = _ICompanyMasterService.CreateCompany(companyBAL);
            }

            return success; 

        }

        public List<CompanyModel> GetAllCompanies()
        {
            List<CompanyModel> userModelList = new List<CompanyModel>();
            List<CompanyBAL> _companyBALList = _ICompanyMasterService.GetAllCompany();

            if (_companyBALList != null && _companyBALList.Count > 0)
            {
                foreach(var obj in _companyBALList)
                {
                    userModelList.Add(HMSAutoMapper.mapper.Map<CompanyBAL, CompanyModel>(obj));
                }
            }

            return userModelList;
        }
    }
}