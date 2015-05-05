using System;

namespace NerdFood.Domain.Interfaces.Infra
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
        void Start();

        //IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        //IPublicacaoRepository PublicacaoRepository();
    }
}
