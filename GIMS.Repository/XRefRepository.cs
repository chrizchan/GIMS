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
    public class XRefRepository : RepositoryBase<XRef>, IXRefRepository
    {
        public IQueryable<ItemSearchListViewModel> GetAllItemSearchList(params Expression<Func<XRef, object>>[] includes)
        {
            Db.Database.Log = message => Debug.WriteLine(message);

            var query = includes.Aggregate(DbSet, (current, item) => current.Include(item));

            var result = query.Select(x =>
                new ItemSearchListViewModel
                {
                    ItemNo2nd = x.Item.ItemNo2nd,
                    ShortItemNo = x.ShortItemNo,
                    XrefShortItemNo = x.XRefShortItemNo, 
                    XrefItemNo = Db.Items.Where(l=>l.ShortItemNo == x.XRefShortItemNo).Select(i=>i.ItemNo2nd).FirstOrDefault(),      
                    XType = x.Type,
                    Brand = x.Item.Brand,
                    BrandGroup = x.Item.BrandGroup,
                    Description1 = x.Item.Description1,
                    Description2 = x.Item.Description2,
                    Searchtext = x.Item.Searchtext,
                    MajorType = x.Item.MajorType,
                    GpQtyAvail = x.Item.GpQtyAvail,
                    GItemNo2nd = x.Item.GItemNo2nd,
                    TotalStocksSGP = Db.BranchStocks.Count(y => y.BranchId == Constant.Branches.SGD && y.ShortItemNo == x.ShortItemNo),
                    TotalStocksCHN = Db.BranchStocks.Count(y => y.BranchId == Constant.Branches.BDG && y.ShortItemNo == x.ShortItemNo),
                    TotalStocksIDN = Db.BranchStocks.Count(y => y.BranchId == Constant.Branches.BTM && y.ShortItemNo == x.ShortItemNo),
                    TotalStocksMNG = Db.BranchStocks.Count(y => y.BranchId == Constant.Branches.SGD && y.ShortItemNo == x.ShortItemNo),
                    TotalStocksMYS = Db.BranchStocks.Count(y => y.BranchId == Constant.Branches.SGD && y.ShortItemNo == x.ShortItemNo),
                    TotalStocksOthers = Db.BranchStocks.Count(y => y.BranchId == Constant.Branches.SGD && y.ShortItemNo == x.ShortItemNo),
                });

            return result;
        }
    }

    public interface IXRefRepository : IRepository<XRef>
    {
        IQueryable<ItemSearchListViewModel> GetAllItemSearchList(params Expression<Func<XRef, object>>[] includes);
    }  
}
