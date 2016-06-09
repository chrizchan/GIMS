using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using GIMS.Entities;
using GIMS.Repository;
using GIMS.Repository.Common;
using GIMS.ServiceLayer.Common;
using GIMS.ViewModel.Item;

namespace GIMS.ServiceLayer
{
    public class XRefService : ServiceBase<XRef>, IXRefService
    {
        private IXRefRepository _xRefRepository;
        public XRefService(IXRefRepository repository)
            : base(repository)
        {
            _xRefRepository = repository;
        }

        public IQueryable<ItemSearchListViewModel> GetAllItemSearchList(params Expression<Func<XRef, object>>[] includes)
        {
            return _xRefRepository.GetAllItemSearchList(includes);
        }
    }

    public interface IXRefService : IService<XRef>
    {
        IQueryable<ItemSearchListViewModel> GetAllItemSearchList(params Expression<Func<XRef, object>>[] includes);
    }
}
