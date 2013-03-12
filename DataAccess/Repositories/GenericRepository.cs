using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Repositories.Interfaces;

namespace DataAccess.Repositories
{
    public abstract class GenericRepository<TContext, T> : IGenericRepository<T>
        where T : class
        where TContext : DbContext, new()
    {
        private TContext _entities = new TContext();

        public TContext Context
        {
            get { return _entities; }
            set { _entities = value; }
        }

        public IQueryable<T> GetAll()
        {
            return _entities.Set<T>();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _entities.Set<T>().Where(predicate);
        }

        public void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _entities.SaveChanges();
        }
    }
}