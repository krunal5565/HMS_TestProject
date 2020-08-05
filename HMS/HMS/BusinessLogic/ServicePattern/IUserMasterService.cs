using HMS.Models;
using HMS.Repository.EDMX;
using System.Collections.Generic;

namespace HMS.Web.ServicePattern
{
    public interface IUserMasterService
    {
        void Save(UserModel model);

    }
}
