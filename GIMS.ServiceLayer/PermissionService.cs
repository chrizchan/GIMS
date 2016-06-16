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
    public class PermissionService : ServiceBase<Permission>, IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        public PermissionService(IPermissionRepository repository)
            : base(repository)
        {
            _permissionRepository = repository;
        }
    }

    public interface IPermissionService : IService<Permission>
    {
        
    }
}
