using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

using Microsoft.Practices.ServiceLocation;

using NerdFood.Infra.Data.Interfaces;

using System.Data.Entity;
using NerdFood.Domain.Interfaces.Infra;
using NerdFood.Data.Config;

namespace NerdFood.Infra.Data.Config
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbContext _context;
        private bool _disposed;

        public IDbContext Context
        {
            get { return _context; }
        }

        public void Start()
        {
             var contextManager = ServiceLocator.Current.GetInstance<IContextManager>() as ContextManager;
             _context = contextManager.NerdFoodContext;
            _disposed = false;
        }

        public void Attach<TEntity>(TEntity item)
            where TEntity : class
        {
            _context.Entry<TEntity>(item).State = EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item)
            where TEntity : class
        {
            _context.Entry<TEntity>(item).State = EntityState.Modified;
        }
        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current)
            where TEntity : class
        {
            _context.Entry<TEntity>(original).CurrentValues.SetValues(current);
        }

        public void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.First().Reload();
            }
        }

        //public void RollbackChanges()
        //{
        //    _context.Entries()
        //             .ToList()
        //             .ForEach(entry => entry.State = System.Data.EntityState.Unchanged);
        //}

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}