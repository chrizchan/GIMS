using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GIMS.Entities;
using GIMS.Repository;
using GIMS.ServiceLayer.Common;

namespace GIMS.ServiceLayer
{
    public class ItemAdditionalInformationService : ServiceBase<ItemAdditionalInformation>, IItemAdditionalInformationService
    {
        private IItemAdditionalInformationRepository _itemAdditionalInformationRepository;

        public ItemAdditionalInformationService(IItemAdditionalInformationRepository repository)
            : base(repository)
        {
            _itemAdditionalInformationRepository = repository;
        }
    }

    public interface IItemAdditionalInformationService : IService<ItemAdditionalInformation>
    {
    }
}
