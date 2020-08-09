using HMS.Repository.EDMX;
using HMS.Repository.EMDX;
using HMS.Repository.GenericRepository;
using HMS.Repository.RepositoryPattern;
using System.Data.Entity;

namespace HMS.Repository
{
    public class UserSessionHistoryRepository : GenericRepository<UserSessionHistory>, IUserSessionHistoryRepository
    {
        public UserSessionHistoryRepository(DbContext context) : base(context)
        {


        }
    }
}


