using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using GIMS.Entities;
using GIMS.Repository.Common;
using GIMS.ViewModel.ItemInquiry;

namespace GIMS.Repository
{
    public class BranchStockRepository : RepositoryBase<BranchStock>, IBranchStockRepository
    {
        public IList<BranchStockListViewModel> GetBranchStockList(int shortItemNo, params Expression<Func<BranchStock, object>>[] includes)
        {

            //Db.Database.Log = message => Debug.WriteLine(message);

            var query = includes.Aggregate(DbSet, (current, item) => current.Include(item));

            var result = query.Where(x => x.ShortItemNo == shortItemNo).ToList()
                              .GroupBy(x => x.BranchId)
                              .Select(grp =>
                                        new BranchStockListViewModel
                                        {
                                            BranchId = grp.Key,
                                            BranchName = grp.FirstOrDefault().Branch.Name,
                                            Reservation = grp.Sum(x=>x.ReserveQty),
                                            ExStockAtp = grp.Sum(x=>x.ExStockAtp),
                                            BranchStocks = grp.FirstOrDefault().Branch.BranchStocks.ToList(),
                                        });

            

            return result.ToList();
        }

    }

    public interface IBranchStockRepository : IRepository<BranchStock>
    {
        IList<BranchStockListViewModel> GetBranchStockList(int shortItemNo, params Expression<Func<BranchStock, object>>[] includes);
    }  
}
