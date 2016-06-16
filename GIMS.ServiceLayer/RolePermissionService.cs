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
    public class RolePermissionService : ServiceBase<RolePermission>, IRolePermissionService
    {
        private readonly IRolePermissionRepository _rolePermissionRepository;
        public RolePermissionService(IRolePermissionRepository repository)
            : base(repository)
        {
            _rolePermissionRepository = repository;
        }
    }

    public interface IRolePermissionService : IService<RolePermission>
    {
        
    }
}
