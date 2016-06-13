using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GIMS.Entities;
using GIMS.Repository;
using GIMS.ServiceLayer.Common;

namespace GIMS.ServiceLayer
{
    public class HQStockStatusService : ServiceBase<HQStockStatus>, IHQStockStatusService
    {
        private IHQStockStatusRepository _hqStockStatusRepositoryy;
        public HQStockStatusService(IHQStockStatusRepository repository)
            : base(repository)
        {
            _hqStockStatusRepositoryy = repository;
        }
    }

    public interface IHQStockStatusService : IService<HQStockStatus>
    {
        
    }
}
