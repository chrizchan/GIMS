using GIMS.Entities;
using GIMS.Repository.Common;

namespace GIMS.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
         
    }

    public interface IUserRepository : IRepository<User>
    {
        
    }
}