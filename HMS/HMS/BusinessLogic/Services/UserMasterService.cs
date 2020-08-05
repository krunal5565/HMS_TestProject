using HMS.Models;
using HMS.Repository.EDMX;
using HMS.Repository.EMDX;
using HMS.Repository.RepositoryPattern;
using System;
using System.Collections.Generic;

namespace HMS.Web.ServicePattern
{
    public class UserMasterService : IUserMasterService
    {

        private IUserMasterRepository _userMasterRepository;
    

        #region Constructors

        public UserMasterService(IUserMasterRepository userMasterRepository) 
        {
            _userMasterRepository = userMasterRepository;
        }

        #endregion

        public void Save(UserModel model)
        {
            UserMaster _objData = new UserMaster();
            _objData.Address = model.Address;
            _objData.CompanyUniqueID = model.CompanyUniqueID;
            _objData.ActiveStatus = model.ActiveStatus;
            _objData.UniqueID = Guid.NewGuid().ToString();
            _objData.Designation = model.Designation; 
            _objData.EmailID = model.EmailID;
            _objData.FirstName = model.FirstName;
            _objData.LastName = model.LastName;
            _objData.MiddleName = model.MiddleName;
            _objData.MobileNumber = model.MobileNumber;

            _userMasterRepository.Add(_objData);
            _userMasterRepository.Save();
        }
    }
}
