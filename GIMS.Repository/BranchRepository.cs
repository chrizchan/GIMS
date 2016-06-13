using GIMS.Entities;
using GIMS.Repository.Common;

namespace GIMS.Repository
{
    public class BranchRepository : RepositoryBase<Branch>, IBranchRepository
    {
         
    }

    public interface IBranchRepository : IRepository<Branch>
    {
        
    }
}