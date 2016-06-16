using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GIMS.Entities;
using GIMS.Repository.Common;

namespace GIMS.Repository
{
    public class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository
    {
    }

    public interface IUserRoleRepository : IRepository<UserRole>
    {
        
    }
}
