using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GIMS.Entites;
using GIMS.Repository.Common;

namespace GIMS.Repository
{
    public class BranchStockRepository : RepositoryBase<BranchStock>, IBranchStockRepository
    {

    }

    public interface IBranchStockRepository : IRepository<BranchStock>
    {
    }  
}
