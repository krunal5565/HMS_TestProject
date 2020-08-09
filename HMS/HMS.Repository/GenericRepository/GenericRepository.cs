using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HMS.Repository.GenericRepository
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        protected GenericRepository(DbContext context)
        {
            _entities = context;
            Dbset = context.Set<T>();
        }

        protected DbContext _entities { get; set; }

        protected IDbSet<T> Dbset { get; }

        public virtual IQueryable<T> GetAll()
        {
            return Dbset;
        }

        public IQueryable<T> GetBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = Dbset.Where(predicate).AsQueryable();

            return query;
        }

        public virtual T Add(T entity)
        {
            return Dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return Dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public virtual int Save()
        {
           return _entities.SaveChanges();
        }
    }
}
