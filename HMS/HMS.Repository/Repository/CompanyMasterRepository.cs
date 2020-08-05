using System.Data.Entity;
using HMS.Repository.EDMX;
using HMS.Repository.EMDX;
using HMS.Repository.GenericRepository;
using HMS.Repository.RepositoryPattern;

namespace HMS.Repository
{
    public class CompanyMasterRepository : GenericRepository<CompanyMaster>, ICompanyMasterRepository
    {
        public CompanyMasterRepository(DbContext context) : base(context)
        {
            
        }
    }
}


