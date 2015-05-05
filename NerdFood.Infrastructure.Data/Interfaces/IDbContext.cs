using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace NerdFood.Infra.Data.Interfaces
{
    public interface IDbContext
    {
        DbSet<T> Set<T>() where T : class;
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
        void SaveChanges();
        void Dispose();
    }
}
