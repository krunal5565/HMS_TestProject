using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using System.Collections.Generic;

namespace HMS.Web.ServicePattern
{
    public interface IUserService
    {
        bool createUser(UserBAL user);
        List<UserBAL> GetAllUsersByCompany(string companyUniqueID);
        UserBAL GetUserByEmailId(string emailId); 

        UserBAL Login(string  userID, string password); 
    }
}
