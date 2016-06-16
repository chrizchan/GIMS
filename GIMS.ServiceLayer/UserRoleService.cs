using GIMS.Entities;
using GIMS.Repository;
using GIMS.ServiceLayer.Common;

namespace GIMS.ServiceLayer
{
    public class UserRoleService : ServiceBase<UserRole>, IUserRoleService
    {
        private readonly IUserRoleRepository _userRoleRepository;

        public UserRoleService(IUserRoleRepository repository)
            : base(repository)
        {
            _userRoleRepository = repository;
        }
    }

    public interface IUserRoleService : IService<UserRole>
    {
        
    }
}
