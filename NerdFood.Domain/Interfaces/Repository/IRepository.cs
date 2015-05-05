using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NerdFood.Domain;

namespace NerdFood.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(long Id);
        IEnumerable<TEntity> All();
        IEnumerable<TEntity> AllReadOnly();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
