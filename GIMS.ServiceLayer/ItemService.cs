﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using GIMS.Entites;
using GIMS.Repository;
using GIMS.Repository.Common;
using GIMS.ServiceLayer.Common;

namespace GIMS.ServiceLayer
{
    public class ItemService : ServiceBase<Item>, IItemService
    {
        private IItemRepository _itemRepository;

        public ItemService(IItemRepository repository)
            : base(repository)
        {
            _itemRepository = repository;
        }

        public IQueryable<Item> GetAll(params Expression<Func<Item, object>>[] includes)
        {
            return _itemRepository.GetAll(includes);
        }
    }

    public interface IItemService : IService<Item>
    {
        IQueryable<Item> GetAll(params Expression<Func<Item, object>>[] includes);
    }
}