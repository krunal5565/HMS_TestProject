using HMS.Models;
using HMS.Repository.EMDX;
using HMS.Repository.RepositoryPattern;
using System;

namespace HMS.Web.ServicePattern
{
    public class BedTypeMasterService : IBedTypeMasterService
    {
        private IBedTypeMasterRepository _Repository;

        public BedTypeMasterService(IBedTypeMasterRepository Repository)
        {
            _Repository = Repository; 
        }

        public void Save(BedTypeModel model)
        {
             BedTypeMaster _objData = new BedTypeMaster();
            _objData.BedTypeName = model.BedTypeName;
            _objData.BedTypeCode = model.BedTypeCode;
            _objData.ActiveStatus = model.ActiveStatus;
            _objData.CompanyUniqueID = model.CompanyUniqueID;
            _objData.UniqueID = Guid.NewGuid().ToString();

            _Repository.Add(_objData);
            _Repository.Save(); 
         }


    }
}
