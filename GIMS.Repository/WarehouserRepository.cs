﻿using GIMS.Entities;
using GIMS.Repository.Common;


namespace GIMS.Repository
{
    public class WarehouserRepository : RepositoryBase<Warehouse>, IWarehouseRepository
    {
         
    }

    public interface IWarehouseRepository : IRepository<Warehouse>
    {
        
    }
}