using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GIMS.Entities.Enum;

namespace GIMS.Repository.Common
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetMany(Expression<Func<T, bool>> @where, params Expression<Func<T, object>>[] includes);
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);
        T Get(Expression<Func<T, bool>> where);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);        
        //bool SaveAll();
        int GetCount();
        int GetCount(Expression<Func<T, bool>> where);

        IList<T> GetMany<TKey>(Func<T, TKey> orderBySelector, int page, int pageSize, SortDirection sortDirection);
        IList<T> GetMany<TKey>(Expression<Func<T, bool>> where, Func<T, TKey> orderBySelector, int page, int pageSize, SortDirection sortDirection);

        
    }
}