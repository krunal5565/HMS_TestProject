using System.Data.Entity;
using HMS.Repository.EDMX;
using HMS.Repository.EMDX;
using HMS.Repository.GenericRepository;
using HMS.Repository.RepositoryPattern;

namespace HMS.Repository
{
    public class RoomTypeMasterRepository : GenericRepository<RoomTypeMaster>, IRoomTypeMasterRepository
    {
        public RoomTypeMasterRepository(DbContext context) : base(context)
        {
            
        }
    }
}


