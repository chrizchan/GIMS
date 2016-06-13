using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using GIMS.Entities.Enum;

namespace GIMS.ServiceLayer.Common
{
    public interface IService<T>
    {
        T Add(T entity);
        T Update(T entity);

        T Delete(T entity);
        IList<T> GetAll();
        T Get(Expression<Func<T, bool>> where);
        int GetCount();
        int GetCount(Expression<Func<T, bool>> @where);

        IList<T> GetMany(Expression<Func<T, bool>> @where);
        IList<T> GetMany<TKey>(Func<T, TKey> orderBySelector, int page, int pageSize,
            SortDirection sortDirection);
        IList<T> GetMany<TKey>(Expression<Func<T, bool>> where, Func<T, TKey> orderBySelector, int page, int pageSize,
            SortDirection sortDirection);

        
    }
}
