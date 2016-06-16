using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GIMS.Entities;
using GIMS.Repository;
using GIMS.Repository.Common;
using GIMS.ServiceLayer.Common;

namespace GIMS.ServiceLayer
{
    public class RoleService : ServiceBase<Role>, IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository repository)
            : base(repository)
        {
            _roleRepository = repository;
        }
    }

    public interface IRoleService : IService<Role>
    {
        
    }
}
