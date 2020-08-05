using HMS.Models;
using HMS.Repository.EDMX;
using HMS.Repository.EMDX;
using HMS.Repository.RepositoryPattern;
using System;

namespace HMS.Web.ServicePattern
{
    public class CompanyMasterService : ICompanyMasterService
    {

        public ICompanyMasterRepository _Repository;

        public CompanyMasterService(ICompanyMasterRepository Repository)
        {
            _Repository = Repository;
        }

        public void Save(CompanyModel model)
        {
            CompanyMaster _objData = new CompanyMaster();
            _objData.CompanyName = model.CompanyName;
            _objData.CompanyAddress = model.CompanyAddress;
            _objData.ActiveStatus = model.ActiveStatus;
            _objData.EmailID = model.MobileNumber;
            _objData.MobileNumber = model.MobileNumber;
            _objData.UniqueID = Guid.NewGuid().ToString();
            _objData.Website = model.Website;

            _Repository.Add(_objData);
            _Repository.Save();
        }

    }
}
