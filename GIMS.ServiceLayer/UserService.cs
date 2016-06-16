using GIMS.Entities;
using GIMS.Repository;
using GIMS.Repository.Common;
using GIMS.ServiceLayer.Common;

namespace GIMS.ServiceLayer
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository repository)
            : base(repository)
        {
            _userRepository = repository;
        }

        public User ValidateUser(string username, string password)
        {
            var info = Repository.Get(x => x.Username.ToLower() == username.ToLower() && x.Password == password && !x.Deleted);

            return info;
        }
    }

    public interface IUserService : IService<User>
    {
        User ValidateUser(string username, string password);
    }
}