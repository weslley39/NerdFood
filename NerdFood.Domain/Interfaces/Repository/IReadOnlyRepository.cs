using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NerdFood.Domain.Interfaces.Repository
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        TEntity GetById(long id);
        IEnumerable<TEntity> All();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
