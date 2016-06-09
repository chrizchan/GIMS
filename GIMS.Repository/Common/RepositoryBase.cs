using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using GIMS.DataAccess;
using GIMS.Entities;
using GIMS.Entities.Enum;
using GIMS.Repository.Common;
using LinqKit;


namespace GIMS.Repository.Common
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected virtual IQueryable<T> DbSet { get; private set; }

        protected RepositoryBase()
        {
            Db = new GIMSContext();

            Database.SetInitializer<GIMSContext>(null);

            DbSet = Db.Set<T>().AsNoTracking();
            
        }

        public GIMSContext Db { get; set; }


        public T Get(Expression<Func<T, bool>> @where)
        {
            return DbSet.Where(where).FirstOrDefault();
        }

        public T Add(T entity)
        {
            Db.Database.Log = message => Debug.WriteLine(message);
            Db.Set<T>().Add(entity);
            Db.SaveChanges();

            return entity;
        }

        public T Update(T entity)
        {
            var updated = Db.Set<T>().Attach(entity);
            Db.Entry(entity).State = EntityState.Modified;

            Db.SaveChanges();
            
            return updated;        
        }

        public T Delete(T entity)
        {
            Db.Entry(entity).State = EntityState.Deleted;
            Db.Set<T>().Remove(entity);
            Db.SaveChanges();

            return entity;
        }

        //public bool SaveAll()
        //{
        //    try
        //    {
        //        return (!Db.ChangeTracker.HasChanges()) || Db.SaveChanges() > 0; // only return true if at least one row was changed
        //    }
        //    catch (Exception ex)
        //    {
        //        // TODO Add logging
        //        return false;
        //    }
        //}

        //public IList<T> GetAll()
        //{
        //    return DbSet.ToList();
        //}

        //public IQueryable<T> GetAllQueryable()
        //{
        //    return DbSet;
        //}

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }
        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {

            var query = includes.Aggregate(DbSet, (current, item) => current.Include(item));
            return query;

        }
        public IQueryable<T> GetMany(Expression<Func<T, bool>> @where, params Expression<Func<T, object>>[] includes)
        {

            var query = includes.Aggregate(DbSet, (current, item) => current.Include(item));
            return query.AsExpandable().Where(where);

        }

        public int GetCount()
        {
            return DbSet.Count();
        }

        public int GetCount(Expression<Func<T, bool>> @where)
        {
            return DbSet.AsExpandable().Where(where).Count();
        }

        public IList<T> GetMany<TKey>(Func<T, TKey> orderBySelector, int page, int pageSize, SortDirection sortDirection)
        {
            Db.Database.Log = message => Debug.WriteLine(message);
            if (sortDirection == SortDirection.Ascending)
            {
                return DbSet.AsExpandable().OrderBy(orderBySelector).Skip(page).Take(pageSize).ToList();
            }
            else
            {
                return DbSet.AsExpandable().OrderByDescending(orderBySelector).Skip(page).Take(pageSize).ToList();
            }
        }

        public IList<T> GetMany<TKey>(Expression<Func<T, bool>> where, Func<T, TKey> orderBySelector, int page, int pageSize, SortDirection sortDirection)
        {
            Db.Database.Log = message => Debug.WriteLine(message);
            if (sortDirection == SortDirection.Ascending)
            {
                return DbSet.AsExpandable().Where(where).OrderBy(orderBySelector).Skip(page).Take(pageSize).ToList();
            }
            else
            {
                return DbSet.AsExpandable().Where(where).OrderByDescending(orderBySelector).Skip(page).Take(pageSize).ToList();
            }
        }
    }
}
