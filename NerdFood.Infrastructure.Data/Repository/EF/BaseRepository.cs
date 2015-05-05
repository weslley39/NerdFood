using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

using Microsoft.Practices.ServiceLocation;

using NerdFood.Infra.Data.Interfaces;
using NerdFood.Domain.Interfaces.Repository;
using NerdFood.Domain.Interfaces.Infra;
using NerdFood.Data.Config;

namespace NerdFood.Infra.Data.Repository.EF
{

    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private IDbContext _context;
        private readonly IDbSet<T> _dbset;

        public BaseRepository()
        {
            var contextManager = ServiceLocator.Current.GetInstance<IContextManager>() as ContextManager;
            _context = contextManager.NerdFoodContext;
            _dbset = _context.Set<T>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            if (_context == null) return;
            _context.Dispose();
            _context = null;
        }

        public virtual void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Deleted;
        }

        public virtual void Update(T entity)
        {
            var entry = _context.Entry(entity);
            _dbset.Attach(entity);
            entry.State = EntityState.Modified;
        }

        public virtual T GetById(long id)
        {
            return _dbset.Find(id);
        }

        public virtual IEnumerable<T> All()
        {
            return _dbset.ToList();
        }

        public virtual IEnumerable<T> AllReadOnly()
        {
            return _dbset.AsNoTracking().ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate);
        }
    }
}
