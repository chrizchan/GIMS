using GIMS.Entities;
using GIMS.Repository.Common;

namespace GIMS.Repository
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
         
    }

    public interface IRoleRepository : IRepository<Role>
    {
        
    }
}