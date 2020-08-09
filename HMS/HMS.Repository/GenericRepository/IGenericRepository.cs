using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HMS.Repository.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetBy(Expression<Func<T, bool>> predicate );
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        int Save();
    }
}
