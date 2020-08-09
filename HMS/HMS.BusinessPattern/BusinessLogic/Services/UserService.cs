using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using HMS.BusinessPattern.BusinessLogic.UtilityClasses;
using HMS.Repository.EMDX;
using HMS.Repository.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HMS.Web.ServicePattern
{
    public class UserService : IUserService
    {
        private IUserMasterRepository _userMasterRepository;
        private IUserLoginRepository _userLoginRepository;
        private IUserSessionHistoryRepository _userSessionHistoryRepository;
        private IUserActiveSessionRepository _userActiveSessionRepository;

        #region Constructors

        public UserService(IUserMasterRepository userMasterRepository, IUserLoginRepository userLoginRepository, IUserActiveSessionRepository userActiveSessionRepository, IUserSessionHistoryRepository userSessionHistoryRepository) 
        {
            _userMasterRepository = userMasterRepository;
            _userLoginRepository = userLoginRepository;
            _userSessionHistoryRepository = userSessionHistoryRepository;
            _userActiveSessionRepository = userActiveSessionRepository; 
        }

        #endregion

        public bool createUser(UserBAL userBAL)
        {
            bool success = false;

            try
            {
                if(userBAL != null)
                {
                    UserMaster _objData = BPAutoMapper.mapper.Map<UserBAL, UserMaster>(userBAL);
                    _userMasterRepository.Add(_objData);

                    if(_userMasterRepository.Save() == 1)
                    {
                        success = true; 
                    }
                }
            }
            catch(Exception ex)
            {
                success = false; 
            }
           
            return success; 
        }



        public List<UserBAL> GetAllUsersByCompany(string companyUniqueID)
        {
            List<UserBAL> usrBAL = new List<UserBAL>(); 
            List<UserMaster> _userMasterList = _userMasterRepository.GetBy(x => x.CompanyUniqueID == companyUniqueID).ToList(); 

            if(_userMasterList != null && _userMasterList.Count > 0)
            {
                foreach(var objMasterList in _userMasterList)
                {
                    usrBAL.Add(BPAutoMapper.mapper.Map<UserMaster, UserBAL>(objMasterList));
                }
            }
            return usrBAL; 
        }

        public UserBAL GetUserByEmailId(string emailId)
        {
            UserBAL usrBAL = new UserBAL();
            UserMaster _userMasterList = _userMasterRepository.GetBy(x => x.EmailID == emailId).FirstOrDefault();

            if (_userMasterList != null)
            {
                usrBAL = BPAutoMapper.mapper.Map<UserMaster, UserBAL>(_userMasterList);
            }
            return usrBAL;
        }

        public UserBAL Login(string userId, string password)
        {
            UserBAL objUserBAL = new UserBAL(); 

            UserLogin _userLogin = _userLoginRepository.GetBy(x => x.UserID == userId && x.KeyPass == password).FirstOrDefault();

            if(_userLogin != null)
            {
                UserMaster _userMaster = _userLogin.UserMaster;

                UserActiveSession _userActiveSession = new UserActiveSession();
                _userActiveSession.ActiveStatus = "";
                _userActiveSession.CreatedDate = DateTime.UtcNow;
                _userActiveSession.UniqueID = Guid.NewGuid().ToString();
                _userActiveSession.UserUniqueID = _userMaster.UniqueID;
                _userActiveSession.SessionStatus = "";
                _userActiveSession.SessionToken = "";
                _userActiveSession.CreatedBy = _userMaster.UniqueID; 

                _userActiveSessionRepository.Add(_userActiveSession);
                _userActiveSessionRepository.Save();


                UserSessionHistory _userSessionHistory = new UserSessionHistory();
                _userSessionHistory.UserUniqueID = Guid.NewGuid().ToString();
                _userSessionHistory.SessionID = "";
                _userSessionHistory.LoginTime = DateTime.UtcNow;
                _userSessionHistory.SessionToken = ""; 
                _userSessionHistoryRepository.Add(_userSessionHistory);
                _userSessionHistoryRepository.Save();

                 objUserBAL = BPAutoMapper.mapper.Map<UserMaster, UserBAL>(_userMaster);
            }
         
            return objUserBAL; 

        }

        
    }
}
