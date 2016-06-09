using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using GIMS.Entities;
using GIMS.Repository;
using GIMS.ServiceLayer.Common;

namespace GIMS.ServiceLayer
{
    public class BranchStockService : ServiceBase<BranchStock>, IBranchStockService
    {
        private IBranchStockRepository _branchStockRepository;

        public BranchStockService(IBranchStockRepository repository)
            : base(repository)
        {
            _branchStockRepository = repository;
        }

        public IQueryable<BranchStock> GetAll(params Expression<Func<BranchStock, object>>[] includes)
        {
            return _branchStockRepository.GetAll(includes);
        }
    }

    public interface IBranchStockService : IService<BranchStock>
    {
        IQueryable<BranchStock> GetAll(params Expression<Func<BranchStock, object>>[] includes);
    }
}
