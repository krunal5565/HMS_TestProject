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
    public class UserManager
    {
        private readonly IUserService _IUserService;
        public UserManager(IUserService IUserService)
        {
            _IUserService = IUserService;
        }

        public bool Login(LoginInputModel model)
        {
            bool success = false; 
            UserBAL response = _IUserService.Login(model.UserID , model.Password);
            return success; 
        }

        public void CreateUserActiveSession()
        {

        }

        public void CreateUserSessionHistory()
        {

        }

        public bool CreateUser(UserModel model)
        {
            bool success = false; 

            if(model != null)
            {
                UserBAL _user = HMSAutoMapper.mapper.Map<UserModel, UserBAL>(model);

                success = _IUserService.createUser(_user);
            }

            return success; 
        }

        public List<UserModel> GetAllUsersByCompany(string companyUniqueID)
        {
            List<UserModel> userModelList = new List<UserModel>(); 
            List<UserBAL> _userBALList =  _IUserService.GetAllUsersByCompany(companyUniqueID);
            if(_userBALList != null)
            {
                foreach(var objUser in _userBALList)
                {
                    userModelList.Add(HMSAutoMapper.mapper.Map<UserBAL, UserModel>(objUser)); 
                }
            }

            return userModelList; 
        }

        public UserModel GetUserByEmail(string emailID)
        {
            UserModel userModel = new UserModel();
            UserBAL _user =   _IUserService.GetUserByEmailId(emailID);

            if(_user != null)
            {
                userModel = HMSAutoMapper.mapper.Map<UserBAL, UserModel>(_user); 
            }

            return userModel; 
        }
    }
}