using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GIMS.Entites.Enum;
using GIMS.Repository.Common;


namespace GIMS.ServiceLayer.Common
{
    public abstract class ServiceBase<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;

        protected ServiceBase(IRepository<T> repository)
        {
            _repository = repository;
        }

        protected IRepository<T> Repository { get { return _repository; } }
        public T Add(T entity)
        {
            return _repository.Add(entity);
        }

        public T Update(T entity)
        {
            return _repository.Update(entity);
        }

        public T Delete(T entity)
        {
            return _repository.Delete(entity);
        }

        public IList<T> GetAll()
        {
            var list = _repository.GetAll();
            //return list;
            return new List<T>(list.Cast<T>());
        }

        public T Get(Expression<Func<T, bool>> @where)
        {
            return _repository.Get(where);
        }

        public int GetCount()
        {
            return _repository.GetCount();
        }

        public int GetCount(Expression<Func<T, bool>> @where)
        {
            return _repository.GetCount(where);
        }

        public IList<T> GetMany<TKey>(Func<T, TKey> orderBySelector, int page, int pageSize, SortDirection sortDirection)
        {
            return _repository.GetMany(orderBySelector, page, pageSize, sortDirection);
        }

        public IList<T> GetMany<TKey>(Expression<Func<T, bool>> where, Func<T, TKey> orderBySelector, int page, int pageSize, SortDirection sortDirection)
        {
            return _repository.GetMany(where, orderBySelector, page, pageSize, sortDirection);
        }
    }
}
