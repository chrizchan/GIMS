using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using GIMS.Entities;
using GIMS.Repository.Common;
using GIMS.ViewModel.Item;

namespace GIMS.Repository
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        public IQueryable<ItemSearchListViewModel> GetAllItemSearchList(params Expression<Func<Item, object>>[] includes)
        {

            Db.Database.Log = message => Debug.WriteLine(message);

            var query = includes.Aggregate(DbSet, (current, item) => current.Include(item));

            var list = query.Select(x =>
                new ItemSearchListViewModel
                {
                    ItemNo2nd = x.ItemNo2nd,
                    ShortItemNo = x.ShortItemNo,
                    //TotalStocksSg = Db.BranchStocks.Count(y => y.BranchId == Constant.Branches.SGD && y.ShortItemNo == x.ShortItemNo),
                });

            var a = list.ToList();

            return list;

        }
    }

    public interface IItemRepository : IRepository<Item>
    {
        IQueryable<ItemSearchListViewModel> GetAllItemSearchList(params Expression<Func<Item, object>>[] includes);

    }
}
