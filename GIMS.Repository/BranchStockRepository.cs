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
        public List<BranchStockListViewModel> GetBranchStockList(int shortItemNo, params Expression<Func<BranchStock, object>>[] includes)
        {

            //Db.Database.Log = message => Debug.WriteLine(message);

            //var asd = DbSet.Include(x=>x.Branch).Include(x => x.Branch).Include(x => x.Warehouse).ToList();


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

            

            //var warehouses = Db.Warehouses.ToList();
            //var braches = Db.Branches.ToList();

            //var list = result.ToList();

            //foreach (var bs in list.SelectMany(item => item.BranchStocks))
            //{
            //    bs.Warehouse = warehouses.FirstOrDefault(x => x.WarehouseId== bs.WarehouseId && x.BranchId == bs.BranchId);
            //    bs.Branch = braches.FirstOrDefault(x => x.BranchId == bs.BranchId);
            //}

            return result.ToList();
        }

        public List<BranchStock> GetAllBranchStock()
        {

            Db.Database.Log = message => Debug.WriteLine(message);

            var asd = Db.BranchStocks.Include(x => x.Branch).Include(x => x.Warehouse).ToList();

            return asd;
        }
    }

    public interface IBranchStockRepository : IRepository<BranchStock>
    {
        List<BranchStockListViewModel> GetBranchStockList(int shortItemNo, params Expression<Func<BranchStock, object>>[] includes);

        List<BranchStock> GetAllBranchStock();
    }  
}
