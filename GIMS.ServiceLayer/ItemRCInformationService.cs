using System;
using System.Linq;
using System.Linq.Expressions;
using GIMS.Entities;
using GIMS.Repository;
using GIMS.ServiceLayer.Common;

namespace GIMS.ServiceLayer
{
    public class ItemRCInformationService : ServiceBase<ItemRCInformation>, IItemRCInformationService
    {
        private IItemRCInformationRepository _itemRepository;

        public ItemRCInformationService(IItemRCInformationRepository repository)
            : base(repository)
        {
            _itemRepository = repository;
        }

        public IQueryable<ItemRCInformation> GetAll(params Expression<Func<ItemRCInformation, object>>[] includes)
        {
            return _itemRepository.GetAll(includes);
        }
    }

    public interface IItemRCInformationService : IService<ItemRCInformation>
    {
        IQueryable<ItemRCInformation> GetAll(params Expression<Func<ItemRCInformation, object>>[] includes);
    }
}
