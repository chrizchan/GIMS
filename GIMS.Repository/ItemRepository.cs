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

    }

    public interface IItemRepository : IRepository<Item>
    {


    }
}
