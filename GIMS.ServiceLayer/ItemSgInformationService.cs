using System;
using System.Linq;
using System.Linq.Expressions;
using GIMS.Entities;
using GIMS.Repository;
using GIMS.ServiceLayer.Common;

namespace GIMS.ServiceLayer
{
    public class ItemSgInformationService : ServiceBase<ItemSgInformation>, IItemSgInformationService
    {
        private IItemSgInformationRepository _itemRepository;

        public ItemSgInformationService(IItemSgInformationRepository repository)
            : base(repository)
        {
            _itemRepository = repository;
        }

        public IQueryable<ItemSgInformation> GetAll(params Expression<Func<ItemSgInformation, object>>[] includes)
        {
            return _itemRepository.GetAll(includes);
        }
    }

    public interface IItemSgInformationService : IService<ItemSgInformation>
    {
        IQueryable<ItemSgInformation> GetAll(params Expression<Func<ItemSgInformation, object>>[] includes);
    }
}
