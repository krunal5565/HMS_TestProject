using HMS.Repository.EDMX;
using HMS.Repository.EMDX;
using HMS.Repository.GenericRepository;
using HMS.Repository.RepositoryPattern;
using System.Data.Entity;

namespace HMS.Repository
{
    public class UserMasterRepository : GenericRepository<UserMaster>, IUserMasterRepository
    {
        public UserMasterRepository(DbContext context) : base(context)
        {


        }
    }
}


