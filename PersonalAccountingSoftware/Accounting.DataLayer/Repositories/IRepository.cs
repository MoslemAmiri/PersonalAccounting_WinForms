using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(object id);
        void Delete(object id);
        void Delete(TEntity entity);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        bool Exists(Expression<Func<TEntity, bool>> expression);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null);
    }
}