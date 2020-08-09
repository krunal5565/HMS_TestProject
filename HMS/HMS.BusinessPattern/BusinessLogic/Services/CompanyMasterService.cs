using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using HMS.BusinessPattern.BusinessLogic.UtilityClasses;
using HMS.Repository.EMDX;
using HMS.Repository.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HMS.Web.ServicePattern
{
    public class CompanyMasterService : ICompanyMasterService
    {

        public ICompanyMasterRepository _CompanyRepository;

        public CompanyMasterService(ICompanyMasterRepository Repository)
        {
            _CompanyRepository = Repository;
        }

        public bool CreateCompany(CompanyBAL companyBAL)
        {
            bool success = false;

            try
            {
                if(companyBAL != null)
                {
                    CompanyMaster _objData = BPAutoMapper.mapper.Map<CompanyBAL, CompanyMaster>(companyBAL);

                    _CompanyRepository.Add(_objData);

                    if (_CompanyRepository.Save() == 1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                success = false;
            }

            return success;
        }

        public List<CompanyBAL> GetAllCompany()
        {
            List<CompanyBAL> companyBAL = new List<CompanyBAL>();
            List<CompanyMaster> _companyMasterList = _CompanyRepository.GetAll().ToList();

            if (_companyMasterList != null && _companyMasterList.Count > 0)
            {
                foreach (var objData in _companyMasterList)
                {
                    companyBAL.Add(BPAutoMapper.mapper.Map<CompanyMaster, CompanyBAL>(objData));
                }
            }
            return companyBAL;
        }


    }
}
