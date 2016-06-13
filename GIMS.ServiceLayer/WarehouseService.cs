using GIMS.Entities;
using GIMS.Repository;
using GIMS.Repository.Common;
using GIMS.ServiceLayer.Common;

namespace GIMS.ServiceLayer
{
    public class WarehouseService: ServiceBase<Warehouse>, IWarehouse
    {
        private IWarehouseRepository _warehouseRepository;
        public WarehouseService(IWarehouseRepository repository) : base(repository)
        {
            _warehouseRepository = repository;
        }
    }

    public interface IWarehouse : IService<Warehouse>
    {
        
    }
}